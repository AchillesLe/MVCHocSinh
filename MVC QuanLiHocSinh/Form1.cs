using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace MVC_QuanLiHocSinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
               ItemLop();
            loadDSHocSinh();
            GridLoad();
        }
        private void ItemLop()
        {
            LopBUS lopbus = new LopBUS();
            DataTable dt = new DataTable();
            dt = lopbus.LoadDSLop();
            cb_lop.DataSource = dt;
            cb_lop.DisplayMember = "TenLop";
            cb_lop.ValueMember = "MaLop";
        }
        private void loadDSHocSinh()
        {
            DataTable datahs = new DataTable();
            HocSinhBUS hsbus = new HocSinhBUS();
            datahs = hsbus.LoadDSHocSinh();
            ListViewItem item = new ListViewItem();
            tbl_HS.Items.Clear();
            tbl_HS.View = View.Details;
            tbl_HS.Columns.Add("MaHS");
            tbl_HS.Columns.Add("TenHS");
            tbl_HS.Columns.Add("Địa Chỉ");
            tbl_HS.Columns.Add("Điện thoại");
            tbl_HS.Columns.Add("Ngày Sinh");
            tbl_HS.Columns.Add("Mã Lớp");
            tbl_HS.GridLines = true;
           // tbl_HS.FullRowSelect = true;

            //for(int i=0;i<datahs.Rows.Count;i++)
            //{
            //    item = tbl_HS.Items.Add(datahs.Rows[i][0].ToString());
            //    for(int j=1;j<datahs.Columns.Count;j++)
            //    {
            //        item.SubItems.Add(datahs.Rows[i][j].ToString());
            //    }
            //    tbl_HS.Items.Add(item);
            //}
            int i = 0;
            foreach(DataRow row in datahs.Rows)
            {
                tbl_HS.Items.Add(row[0].ToString());
                tbl_HS.Items[i].SubItems.Add(row[1].ToString());
                tbl_HS.Items[i].SubItems.Add(row[2].ToString());
                tbl_HS.Items[i].SubItems.Add(row[3].ToString());
                tbl_HS.Items[i].SubItems.Add(row[4].ToString());
                tbl_HS.Items[i].SubItems.Add(row[5].ToString());
                i++;
            }
           
        }
        private void GridLoad()
        {
            HocSinhBUS bus = new HocSinhBUS();
            bus.LoadDSHocSinh();
            DataSet ds = new DataSet();
            ds.Tables.Add(bus.LoadDSHocSinh());
            //Grid_tblHS.Columns.Add[""];
            Grid_tblHS.DataSource = ds.Tables[0];
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            if(txt_hoten.Text.Trim().Length==0)
            {
                MessageBox.Show("Vui lòng nhập họ và tên !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hoten.Focus();
                return;
            }
            if(txt_diachi.Text.Trim().Length==0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ !", "Thông báo lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_diachi.Focus();
                return;
            }
            if(txtx_dienthoai.Text.Trim().Length==0)
            {
                MessageBox.Show("Vui lòng nhập điện thoại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show(""+cb_lop.SelectedValue, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            int malop = Convert.ToInt32(cb_lop.SelectedValue);
          MessageBox.Show(malop.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //HocSinhDTO hs = new HocSinhDTO(-1,txt_hoten.Text.Trim(),txt_diachi.Text.Trim(),txtx_dienthoai.Text.Trim(),date_ngaysinh.Value,malop);
            HocSinhDTO hs = new HocSinhDTO();
            hs.Tenhs = txt_hoten.Text.Trim();
            hs.Diachi = txt_diachi.Text.Trim();
            hs.Dienthoai = txtx_dienthoai.Text.Trim();
            hs.Ngaysinh = date_ngaysinh.Value;
            hs.Malop = Convert.ToInt32(cb_lop.SelectedValue.ToString());
            HocSinhBUS hsbus = new HocSinhBUS();
            hsbus.AddHocSinh(hs);
             loadDSHocSinh();
            GridLoad();
            txt_hoten.Text = "";
            txtx_dienthoai.Text = "";
            txt_diachi.Text = "";
            cb_lop.SelectedIndex = 0;
            date_ngaysinh.ResetText();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            Console.WriteLine("fsafasfhajk");
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            //int choose = tbl_HS.SelectedItems[0].Index;
            //int ma =Convert.ToInt32( tbl_HS.Items[choose].SubItems[0].Text);
            //int ma = Grid_tblHS.SelectedRows[Grid_tblHS].Cells[0];
            HocSinhBUS bus = new HocSinhBUS();
            bus.deleteHS(Convert.ToInt32(tbl_HS.Items[tbl_HS.SelectedIndices[0]].SubItems[0].Text));
           // bus.deleteHS();
            loadDSHocSinh();
            GridLoad();

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HocSinhInfor(object sender, EventArgs e)
        {
            //int vt=Grid_tblHS.CurrentCell.
            //txt_hoten.Text=Grid_tblHS.
            try
            {
                int vt = Grid_tblHS.CurrentCell.RowIndex;
                
                txt_hoten.Text = Grid_tblHS.Rows[vt].Cells[1].Value.ToString();
                txtx_dienthoai.Text = Grid_tblHS.Rows[vt].Cells[3].Value.ToString();
                txt_diachi.Text = Grid_tblHS.Rows[vt].Cells[2].Value.ToString();
                date_ngaysinh.Value =Convert.ToDateTime( Grid_tblHS.Rows[vt].Cells[4].Value.ToString());
                cb_lop.SelectedItem = Grid_tblHS.Rows[vt].Cells[5].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
