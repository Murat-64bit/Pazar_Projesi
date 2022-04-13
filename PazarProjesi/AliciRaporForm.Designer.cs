
namespace PazarProjesi
{
    partial class AliciRaporForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DbPazarDataSet2 = new PazarProjesi.DbPazarDataSet2();
            this.AliciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AliciTableAdapter = new PazarProjesi.DbPazarDataSet2TableAdapters.AliciTableAdapter();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DbPazarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AliciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AliciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PazarProjesi.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(913, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // DbPazarDataSet2
            // 
            this.DbPazarDataSet2.DataSetName = "DbPazarDataSet2";
            this.DbPazarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AliciBindingSource
            // 
            this.AliciBindingSource.DataMember = "Alici";
            this.AliciBindingSource.DataSource = this.DbPazarDataSet2;
            // 
            // AliciTableAdapter
            // 
            this.AliciTableAdapter.ClearBeforeFill = true;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCikis.Location = new System.Drawing.Point(823, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 25);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AliciRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(913, 391);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AliciRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AliciRaporForm";
            this.Load += new System.EventHandler(this.AliciRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbPazarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AliciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AliciBindingSource;
        private DbPazarDataSet2 DbPazarDataSet2;
        private DbPazarDataSet2TableAdapters.AliciTableAdapter AliciTableAdapter;
        private System.Windows.Forms.Button btnCikis;
    }
}