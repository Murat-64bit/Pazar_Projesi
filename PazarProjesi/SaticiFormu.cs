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
    public partial class SaticiFormu : Form
    {
        public SaticiFormu()
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

            SqlCommand bakiye = new SqlCommand("select para from TBL_SATICI", bgl.baglanti());
            SqlDataReader dr = bakiye.ExecuteReader();
            if (dr.Read())
            {
                lblBakiye.Text = dr[0].ToString();
            }
        }

        private void SaticiFormu_Load(object sender, EventArgs e)
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

        private void SaticiFormu_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;

        }

        private void SaticiFormu_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void SaticiFormu_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMiktar.Text != "" && txtAlimTutari.Text != "" && txtUrunTip.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_PAZAR (UrunTip,AlimTutari,Miktar) values (@UrunTip,@AlimTutari,@Miktar)", bgl.baglanti());
                komut.Parameters.AddWithValue("@UrunTip", txtUrunTip.Text);
                komut.Parameters.AddWithValue("@AlimTutari", decimal.Parse(txtAlimTutari.Text));
                komut.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün fiyatlandırması başarı ile eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Eksik ve hatalı girdiniz lütfen tekrar deneyin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtUrunID.Text != "")
            {
                SqlCommand komut = new SqlCommand("delete from TBL_PAZAR where id=@id", bgl.baglanti());
                komut.Parameters.AddWithValue("@id", txtUrunID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün fiyatlandırması başarı ile silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Eksik ve hatalı girdiniz lütfen tekrar deneyin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = grd.SelectedCells[0].RowIndex;
                txtUrunID.Text = grd.Rows[secilen].Cells[0].Value.ToString();
                txtUrunTip.Text = grd.Rows[secilen].Cells[1].Value.ToString();
                txtAlimTutari.Text = grd.Rows[secilen].Cells[2].Value.ToString();
                txtMiktar.Text = grd.Rows[secilen].Cells[3].Value.ToString();
            }
            catch (Exception)
            {


            }


        }

        private void grd2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int secilen = grd2.SelectedCells[0].RowIndex;
                lblurunid.Text = grd2.Rows[secilen].Cells[0].Value.ToString();
                lbluruntip.Text = grd2.Rows[secilen].Cells[1].Value.ToString();
                lblalimtutari.Text = grd2.Rows[secilen].Cells[2].Value.ToString();
                lblmiktar.Text = grd2.Rows[secilen].Cells[3].Value.ToString();

                double alim, komisyon, toplam;
                alim = Convert.ToDouble(lblalimtutari.Text);
                komisyon = alim * 0.01;
                toplam = alim + komisyon;
                lblkomisyon.Text = toplam.ToString();

                double komisyonlabel = Convert.ToDouble(lblkomisyon.Text);
                double bakiyelabel = Convert.ToDouble(lblBakiye.Text);

                DialogResult secenek = MessageBox.Show("Seçmiş olduğunuz ürünü " + lblkomisyon.Text + " TL'ye satmak istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (secenek == DialogResult.Yes)
                {
                    if (lblmiktar.Text != "" && lblalimtutari.Text != "" && lbluruntip.Text != "")
                    {
                        // Satıcıya para aktarılması
                        SqlCommand komut1 = new SqlCommand("update TBL_SATICI set para+=@para where saticiad=@saticiad", bgl.baglanti());
                        komut1.Parameters.AddWithValue("@para", decimal.Parse(lblalimtutari.Text));
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
                        komut3.Parameters.AddWithValue("@uruntip", lbluruntip.Text);
                        komut3.Parameters.AddWithValue("@alimtutari", decimal.Parse(lblalimtutari.Text));
                        komut3.Parameters.AddWithValue("@miktar", lblmiktar.Text);
                        komut3.Parameters.AddWithValue("@haraketkim", 0);
                        komut3.ExecuteNonQuery();
                        // Teklifi Tablodan düşürmek
                        SqlCommand komut4 = new SqlCommand("update TBL_TEKLIFLER set durum=0", bgl.baglanti());
                        komut4.ExecuteNonQuery();
                        bgl.baglanti().Close();

                        MessageBox.Show("Ürün fiyatlandırması başarı ile eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listele();
                    }
                    else
                    {
                        MessageBox.Show("Bir şey yanlış gitti lütfen tekrar deneyiniz.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (secenek == DialogResult.No)
                {

                }
           
           
        }

        private void btnKurIslemleri_Click(object sender, EventArgs e)
        {
            SaticiKurFormu krf = new SaticiKurFormu();
            krf.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaticiRapor sr = new SaticiRapor();
            sr.Show();
        }
    }
}

