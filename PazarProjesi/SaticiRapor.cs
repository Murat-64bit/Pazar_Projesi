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
    public partial class SaticiRapor : Form
    {
        public SaticiRapor()
        {
            InitializeComponent();
        }

        private void SaticiRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbPazarDataSet3.Satici' table. You can move, or remove it, as needed.
            this.SaticiTableAdapter.Fill(this.DbPazarDataSet3.Satici);
            // TODO: This line of code loads data into the 'DbPazarDataSet1.TBL_SATISHARAKET' table. You can move, or remove it, as needed.
            this.TBL_SATISHARAKETTableAdapter.Fill(this.DbPazarDataSet1.TBL_SATISHARAKET);

            this.reportViewer1.RefreshReport();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
