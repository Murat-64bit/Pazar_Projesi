using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PazarProjesi
{
    public partial class AliciRaporForm : Form
    {
        public AliciRaporForm()
        {
            InitializeComponent();
        }

        private void AliciRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbPazarDataSet2.Alici' table. You can move, or remove it, as needed.
            this.AliciTableAdapter.Fill(this.DbPazarDataSet2.Alici);

            this.reportViewer1.RefreshReport();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
