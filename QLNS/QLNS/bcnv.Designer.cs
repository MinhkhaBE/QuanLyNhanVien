namespace QLNS
{
    partial class bcnv
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
            this.TblTTNVCoBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QLNS.DataSet1();
            this.TblTTNVCoBanTableAdapter = new QLNS.DataSet1TableAdapters.TblTTNVCoBanTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportBcnv1 = new QLNS.ReportBcnv();
            ((System.ComponentModel.ISupportInitialize)(this.TblTTNVCoBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TblTTNVCoBanBindingSource
            // 
            this.TblTTNVCoBanBindingSource.DataMember = "TblTTNVCoBan";
            this.TblTTNVCoBanBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblTTNVCoBanTableAdapter
            // 
            this.TblTTNVCoBanTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ReportBcnv1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1036, 431);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // bcnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 431);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "bcnv";
            this.Text = "bcnv";
            this.Load += new System.EventHandler(this.bcnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblTTNVCoBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource TblTTNVCoBanBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.TblTTNVCoBanTableAdapter TblTTNVCoBanTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ReportBcnv ReportBcnv1;
    }
}