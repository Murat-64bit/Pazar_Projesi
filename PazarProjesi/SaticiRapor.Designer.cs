
namespace PazarProjesi
{
    partial class SaticiRapor
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
            this.TBL_SATISHARAKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbPazarDataSet1 = new PazarProjesi.DbPazarDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TBL_SATISHARAKETTableAdapter = new PazarProjesi.DbPazarDataSet1TableAdapters.TBL_SATISHARAKETTableAdapter();
            this.btnCikis = new System.Windows.Forms.Button();
            this.DbPazarDataSet3 = new PazarProjesi.DbPazarDataSet3();
            this.SaticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaticiTableAdapter = new PazarProjesi.DbPazarDataSet3TableAdapters.SaticiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_SATISHARAKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbPazarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbPazarDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaticiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TBL_SATISHARAKETBindingSource
            // 
            this.TBL_SATISHARAKETBindingSource.DataMember = "TBL_SATISHARAKET";
            this.TBL_SATISHARAKETBindingSource.DataSource = this.DbPazarDataSet1;
            // 
            // DbPazarDataSet1
            // 
            this.DbPazarDataSet1.DataSetName = "DbPazarDataSet1";
            this.DbPazarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SaticiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PazarProjesi.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(929, 430);
            this.reportViewer1.TabIndex = 0;
            // 
            // TBL_SATISHARAKETTableAdapter
            // 
            this.TBL_SATISHARAKETTableAdapter.ClearBeforeFill = true;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCikis.Location = new System.Drawing.Point(839, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 25);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // DbPazarDataSet3
            // 
            this.DbPazarDataSet3.DataSetName = "DbPazarDataSet3";
            this.DbPazarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaticiBindingSource
            // 
            this.SaticiBindingSource.DataMember = "Satici";
            this.SaticiBindingSource.DataSource = this.DbPazarDataSet3;
            // 
            // SaticiTableAdapter
            // 
            this.SaticiTableAdapter.ClearBeforeFill = true;
            // 
            // SaticiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(929, 430);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaticiRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaticiRapor";
            this.Load += new System.EventHandler(this.SaticiRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBL_SATISHARAKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbPazarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbPazarDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaticiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TBL_SATISHARAKETBindingSource;
        private DbPazarDataSet1 DbPazarDataSet1;
        private DbPazarDataSet1TableAdapters.TBL_SATISHARAKETTableAdapter TBL_SATISHARAKETTableAdapter;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.BindingSource SaticiBindingSource;
        private DbPazarDataSet3 DbPazarDataSet3;
        private DbPazarDataSet3TableAdapters.SaticiTableAdapter SaticiTableAdapter;
    }
}