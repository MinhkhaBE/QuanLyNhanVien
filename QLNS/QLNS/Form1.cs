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
    public partial class Form1 : Form
    {
        string ckt = @"Data Source=DESKTOP-CI36P6F\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thucthi;
        DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public Form1()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            ReportLuong rp = new ReportLuong();
            thucthi = ketnoi.CreateCommand();
            thucthi.CommandText = @"SELECT  MaNV , HoTen , LCB, PCChucVu, Thuong, KyLuat,Luong,GhiChu
            FROM dbo.TblCongKhoiDieuHanh ";
            adapter.SelectCommand = thucthi;
            dt = new DataTable();
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = thucthi;
            adapter.Fill(dt);
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(ckt);
            ketnoi.Open();
            hienthi();
        }

       
    }
}
