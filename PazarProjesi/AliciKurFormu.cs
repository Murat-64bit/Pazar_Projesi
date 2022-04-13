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
    public partial class AliciKurFormu : Form
    {
        public AliciKurFormu()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void AliciKurFormu_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tcmb.gov.tr/kurlar/today.xml");

            // Dolar
            SqlCommand dolar = new SqlCommand("select dolar from TBL_KUR where id=1", bgl.baglanti());
            SqlDataReader dr = dolar.ExecuteReader();
            if (dr.Read())
            {
                lblusd.Text = dr[0].ToString();
            }

            // Euro
            SqlCommand euro = new SqlCommand("select euro from TBL_KUR where id=1", bgl.baglanti());
            SqlDataReader dr2 = euro.ExecuteReader();
            if (dr2.Read())
            {
                lbleuro.Text = dr2[0].ToString();
            }

            // Sterlin
            SqlCommand sterlin = new SqlCommand("select sterlin from TBL_KUR where id=1", bgl.baglanti());
            SqlDataReader dr3 = sterlin.ExecuteReader();
            if (dr3.Read())
            {
                lblsterlin.Text = dr3[0].ToString();
            }   
            
            // Tarih
            SqlCommand tarih = new SqlCommand("select sontarih from TBL_KUR where id=1", bgl.baglanti());
            SqlDataReader dr4 = tarih.ExecuteReader();
            if (dr4.Read())
            {
                lblTarih.Text = dr4[0].ToString();
            }
        }

        private void AliciKurFormu_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;

        }

        private void AliciKurFormu_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void AliciKurFormu_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnUsd_Click(object sender, EventArgs e)
        {
            try
            {
                double usd, text, toplam;
                usd = Convert.ToDouble(lblusd.Text);
                text = Convert.ToDouble(txtKur.Text);
                toplam = usd * text;

                // Satıcıya para aktarılması
                SqlCommand komut1 = new SqlCommand("update TBL_ALICI set para+=@para where aliciad=@aliciad", bgl.baglanti());
                komut1.Parameters.AddWithValue("@para", toplam);
                komut1.Parameters.AddWithValue("@aliciad", "Safinaz");
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarı ile DOLAR, Türk Lirasına çevrildi. Lütfen hesabınızı kontrol ediniz.");
            }
            catch (Exception)
            {


            }
        }

        private void btnEUR_Click(object sender, EventArgs e)
        {
            try
            {
                double eur, text, toplam;
                eur = Convert.ToDouble(lbleuro.Text);
                text = Convert.ToDouble(txtKur.Text);
                toplam = eur * text;

                // Satıcıya para aktarılması
                SqlCommand komut1 = new SqlCommand("update TBL_ALICI set para+=@para where aliciad=@aliciad", bgl.baglanti());
                komut1.Parameters.AddWithValue("@para", toplam);
                komut1.Parameters.AddWithValue("@aliciad", "Safinaz");
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarı ile EURO, Türk Lirasına çevrildi. Lütfen hesabınızı kontrol ediniz.");
            }
            catch (Exception)
            {


            }
        }

        private void btnGBP_Click(object sender, EventArgs e)
        {
            try
            {
                double gbp, text, toplam;
                gbp = Convert.ToDouble(lblsterlin.Text);
                text = Convert.ToDouble(txtKur.Text);
                toplam = gbp * text;

                // Satıcıya para aktarılması
                SqlCommand komut1 = new SqlCommand("update TBL_ALICI set para+=@para where aliciad=@aliciad", bgl.baglanti());
                komut1.Parameters.AddWithValue("@para", toplam);
                komut1.Parameters.AddWithValue("@aliciad", "Safinaz");
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarı ile STERLIN, Türk Lirasına çevrildi. Lütfen hesabınızı kontrol ediniz.");
            }
            catch (Exception)
            {


            }
        }
    }
}
