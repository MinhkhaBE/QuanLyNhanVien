using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class bcnv : Form
    {
        string ckt = @"Data Source=DESKTOP-CI36P6F\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thucthi;
        DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public bcnv()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            ReportBcnv rp = new ReportBcnv();
            thucthi = ketnoi.CreateCommand();
            thucthi.CommandText = @"SELECT MaBoPhan , MaPhong, MaNV , HoTen , NgaySinh , GioiTinh , CMTND , ChucVu , GhiChu
            FROM dbo.TblTTNVCoBan ";
            adapter.SelectCommand = thucthi;
            dt = new DataTable();
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = thucthi;
            adapter.Fill(dt);
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
        private void bcnv_Load(object sender, EventArgs e)
        {


            ketnoi = new SqlConnection(ckt);
            ketnoi.Open();
            hienthi();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        
        }

       
       
        
    }
}
