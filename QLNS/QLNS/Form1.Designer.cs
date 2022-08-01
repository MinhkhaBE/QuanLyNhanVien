namespace QLNS
{
    partial class Form1
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
            this.TblCongKhoiDieuHanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new QLNS.DataSet2();
            this.TblCongKhoiDieuHanhTableAdapter = new QLNS.DataSet2TableAdapters.TblCongKhoiDieuHanhTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportLuong1 = new QLNS.ReportLuong();
            ((System.ComponentModel.ISupportInitialize)(this.TblCongKhoiDieuHanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // TblCongKhoiDieuHanhBindingSource
            // 
            this.TblCongKhoiDieuHanhBindingSource.DataMember = "TblCongKhoiDieuHanh";
            this.TblCongKhoiDieuHanhBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblCongKhoiDieuHanhTableAdapter
            // 
            this.TblCongKhoiDieuHanhTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ReportLuong1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1036, 431);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 431);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblCongKhoiDieuHanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource TblCongKhoiDieuHanhBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.TblCongKhoiDieuHanhTableAdapter TblCongKhoiDieuHanhTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ReportLuong ReportLuong1;
    }
}