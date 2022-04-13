using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PazarProjesi
{
    public partial class AliciFormu : Form
    {
        public AliciFormu()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        int Move;
        int Mouse_X;
        int Mouse_Y;

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'ID',UrunTip as 'Ürün Tipi', AlimTutari as 'Alım Tutarı', Miktar from TBL_PAZAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            grd.DataSource = dt;

            SqlDataAdapter da2 = new SqlDataAdapter("select id as 'ID',UrunTip as 'Ürün Tipi', AlimTutari as 'Alım Tutarı', Miktar from TBL_TEKLIFLER where durum=1", bgl.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            grd2.DataSource = dt2;

            SqlCommand bakiye = new SqlCommand("select para from TBL_ALICI", bgl.baglanti());
            SqlDataReader dr = bakiye.ExecuteReader();
            if (dr.Read())
            {
                lblbakiye.Text = dr[0].ToString();
            }

        }


        private void AliciFormu_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;

            String.Format("{0:dd-MM-yyyy}", dt);

            lblTarih.Text = dt.ToString();

            listele();


            grd.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grd.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grd.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= grd.Columns.Count - 1; i++)
            {
                int colw = grd.Columns[i].Width;

                grd.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                grd.Columns[i].Width = colw;
            }

            grd2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grd2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grd2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= grd2.Columns.Count - 1; i++)
            {
                int colw = grd2.Columns[i].Width;

                grd2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                grd2.Columns[i].Width = colw;
            }
        }

        private void AliciFormu_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void AliciFormu_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void AliciFormu_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            try
            {


                double alim, komisyon, toplam;
                alim = Convert.ToDouble(txtAlimTutari.Text);
                komisyon = alim * 0.01;
                toplam = alim + komisyon;
                lblkomisyon.Text = toplam.ToString();

                double komisyonlabel = Convert.ToDouble(lblkomisyon.Text);
                double bakiyelabel = Convert.ToDouble(lblbakiye.Text);

                DialogResult secenek = MessageBox.Show("Seçmiş olduğunuz ürünü " + lblkomisyon.Text + " TL'ye almak istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                SqlCommand komut = new SqlCommand("select * from TBL_ALICI where para=@para", bgl.baglanti());
                komut.Parameters.AddWithValue("@para", lblbakiye.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (bakiyelabel >= komisyonlabel)
                {
                    if (txtAlimTutari.Text == lblalimtutari.Text && txtUrunTip.Text == lblUrunTipi.Text && txtMiktar.Text == lblMiktar.Text)
                    {
                        if (secenek == DialogResult.Yes)
                        {
                            if (txtMiktar.Text != "" && txtAlimTutari.Text != "" && txtUrunTip.Text != "")
                            {
                                // Satıcıya para aktarılması
                                SqlCommand komut1 = new SqlCommand("update TBL_SATICI set para+=@para where saticiad=@saticiad", bgl.baglanti());
                                komut1.Parameters.AddWithValue("@para", decimal.Parse(txtAlimTutari.Text));
                                komut1.Parameters.AddWithValue("@saticiad", "Mehmet");
                                komut1.ExecuteNonQuery();
                                bgl.baglanti().Close();
                                // Alıcının Parasının Azalması 
                                SqlCommand komut2 = new SqlCommand("update TBL_ALICI set para-=@para where aliciad=@aliciad", bgl.baglanti());
                                komut2.Parameters.AddWithValue("@para", komisyonlabel);
                                komut2.Parameters.AddWithValue("@aliciad", "Safinaz");
                                komut2.ExecuteNonQuery();
                                bgl.baglanti().Close();

                                // Satış Haraket
                                SqlCommand komut3 = new SqlCommand("insert into TBL_SATISHARAKET (Tarih,UrunTip,AlimTutari,Miktar,HaraketKim) values (@tarih,@uruntip,@alimtutari,@miktar,@haraketkim)", bgl.baglanti());
                                komut3.Parameters.AddWithValue("@tarih", lblTarih.Text);
                                komut3.Parameters.AddWithValue("@uruntip", txtUrunTip.Text);
                                komut3.Parameters.AddWithValue("@alimtutari", decimal.Parse(txtAlimTutari.Text));
                                komut3.Parameters.AddWithValue("@miktar", txtMiktar.Text);
                                komut3.Parameters.AddWithValue("@haraketkim", 1);
                                komut3.ExecuteNonQuery();
                                bgl.baglanti().Close();

                                MessageBox.Show("Ürün başarı ile satın alındı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                            }
                            else
                            {
                                MessageBox.Show("Eksik ve hatalı girdiniz lütfen tekrar deneyin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (secenek == DialogResult.No)
                        {

                        }
                       


                    }
                    else
                    {
                        MessageBox.Show("Üründe oynama yaparak satın almaya çalıştınız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }

                }
                else
                {

                    MessageBox.Show("Seçmiş olduğunuzu ürünü almak için yeterli bakiyeniz bulunmamaktadır.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                bgl.baglanti().Close();
            }
            catch (Exception)
            {


            }



        }

        private void grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = grd.SelectedCells[0].RowIndex;
                txtUrunID.Text = grd.Rows[secilen].Cells[0].Value.ToString();
                txtUrunTip.Text = grd.Rows[secilen].Cells[1].Value.ToString();
                lblUrunTipi.Text = grd.Rows[secilen].Cells[1].Value.ToString();
                txtAlimTutari.Text = grd.Rows[secilen].Cells[2].Value.ToString();
                lblalimtutari.Text = grd.Rows[secilen].Cells[2].Value.ToString();
                txtMiktar.Text = grd.Rows[secilen].Cells[3].Value.ToString();
                lblMiktar.Text = grd.Rows[secilen].Cells[3].Value.ToString();

            }
            catch (Exception)
            {


            }

        }

        private void btnTeklifVer_Click(object sender, EventArgs e)
        {
            if (txtMiktar.Text != "" && txtAlimTutari.Text != "" && txtUrunTip.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_TEKLIFLER (UrunTip,AlimTutari,Miktar,Durum) values (@UrunTip,@AlimTutari,@Miktar,@Durum)", bgl.baglanti());
                komut.Parameters.AddWithValue("@UrunTip", txtUrunTip.Text);
                komut.Parameters.AddWithValue("@AlimTutari", decimal.Parse(txtAlimTutari.Text));
                komut.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                komut.Parameters.AddWithValue("@Durum", 1);
                komut.ExecuteNonQuery();
                MessageBox.Show("Fiyat teklifi başarı ile eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Eksik ve hatalı girdiniz lütfen tekrar deneyin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBakiyeEkle_Click(object sender, EventArgs e)
        {
            AliciKurFormu arf = new AliciKurFormu();
            arf.Show();
        }

        private void grd2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = grd2.SelectedCells[0].RowIndex;
                lblid.Text = grd2.Rows[secilen].Cells[0].Value.ToString();
                DialogResult secenek = MessageBox.Show("Seçmiş olduğunuz ürünü teklif listenizden kaldırmak istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    SqlCommand komut1 = new SqlCommand("delete from TBL_TEKLIFLER where id=@id", bgl.baglanti());
                    komut1.Parameters.AddWithValue("@id", lblid.Text);
                    komut1.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Fiyat teklifi başarı ile silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }

            }
            catch (Exception)
            {


            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AliciRaporForm fr = new AliciRaporForm();
            fr.Show();
        }

        private void txtAlimTutari_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
