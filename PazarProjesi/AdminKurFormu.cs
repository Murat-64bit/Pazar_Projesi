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
    public partial class AdminKurFormu : Form
    {
        public AdminKurFormu()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnUsd_Click(object sender, EventArgs e)
        {
            if (txtDolar.Text != "" && txtEuro.Text != "" && txtPound.Text != "" && txtTarih.Text != "")
            {
                SqlCommand komut = new SqlCommand("update TBL_KUR set dolar=@dolar,euro=@euro,sterlin=@sterlin,sontarih=@sontarih where id=1",bgl.baglanti());
                komut.Parameters.AddWithValue("@dolar", txtDolar.Text);
                komut.Parameters.AddWithValue("@euro", txtEuro.Text);
                komut.Parameters.AddWithValue("@sterlin", txtPound.Text);
                komut.Parameters.AddWithValue("@sontarih", txtTarih.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarı ile kurlar güncellendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Tarih'in hepsini kapsaması için tüm boşlukları doldurun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
