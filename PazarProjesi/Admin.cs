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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id as 'ID',UrunTip as 'Ürün Tipi', AlimTutari as 'Alım Tutarı', Miktar from TBL_PAZAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            listele();

            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dataGridView2.Columns.Count - 1; i++)
            {
                int colw = dataGridView2.Columns[i].Width;

                dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dataGridView2.Columns[i].Width = colw;
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
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

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView2.SelectedCells[0].RowIndex;
                txtUrunID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
                txtUrunTip.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
                txtAlimTutari.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
                txtMiktar.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            AdminKurFormu akf = new AdminKurFormu();
            akf.Show();
        }

        private void txtCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
