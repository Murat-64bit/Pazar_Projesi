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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Alıcı
            SqlCommand komut = new SqlCommand("select * from TBL_ALICI where aliciad=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAlici.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                AliciFormu fr = new AliciFormu();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            bgl.baglanti().Close();



        }

        private void btnSatici_Click(object sender, EventArgs e)
        {
            if (txtAlici.Text == "Admin" && txtSatici.Text == "Admin")
            {
                DialogResult secenek = MessageBox.Show("Admin girişi yapmayı mi denediniz?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    linkLabel1.Visible = true;
                }
            }
            else
            {
                // Satıcı
                SqlCommand komut2 = new SqlCommand("select * from TBL_SATICI where saticiad=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", txtSatici.Text);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    SaticiFormu fr2 = new SaticiFormu();
                    fr2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bgl.baglanti().Close();
            }
          
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;

        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
