using System;
using System.Windows.Forms;

namespace ProjectManagementWinApp_NguyenQuangVinh
{
    public partial class frmTT : Form
    {
        private DanhSachTruyenTranh ds;
        public frmTT()
        {
            InitializeComponent();
            ds = new DanhSachTruyenTranh();
        }

        void Reset()
        {
            txtMaTruyen.Text = "";
            txtNamXuatBan.Text = "";
            txtNhaXuatBan.Text = "";
            txtSoLuong.Text = "";
            txtTacGia.Text = "";
            txtTenTruyen.Text = "";
        }

        void CapNhatListView()
        {
            lvData.Items.Clear();
            for (int i = 0; i < ds.SoPhanTu; i++)
            {
                TruyenTranh tempData = ds.LayThongTinTuViTri(i);
                lvData.Items.Add(new ListViewItem(new string[] { "" + 
                    tempData.MaTruyen, tempData.NamXuatBan, tempData.TacGia, tempData.TenTruyen, 
                    tempData.NhaXuatBan, tempData.SoLuong.ToString() }));
            }
        }

        private void frmTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn có thật sự muốn thoát hay không?", "Quản lý thông tin truyện tranh", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
            if (btnThem.Text.Equals("Thêm"))
            {
                for (int i = 0; i < lvData.SelectedItems.Count; i++)
                {
                    lvData.SelectedItems[i].Selected = false;
                }
                btnThem.Text = "Hủy";
                txtMaTruyen.Enabled = true;
                txtNamXuatBan.Enabled = true;
                txtNhaXuatBan.Enabled = true;
                txtSoLuong.Enabled = true;
                txtTacGia.Enabled = true;
                txtTenTruyen.Enabled = true;
                btnLuu.Enabled = true;
                txtMaTruyen.Focus();
            }
            else
            {
                btnThem.Text = "Thêm";
                txtMaTruyen.Enabled = false;
                txtNamXuatBan.Enabled = false;
                txtNhaXuatBan.Enabled = false;
                txtSoLuong.Enabled = false;
                txtTacGia.Enabled = false;
                txtTenTruyen.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                TruyenTranh truyentranh = new TruyenTranh(int.Parse(txtMaTruyen.Text), txtNamXuatBan.Text,
                    txtTacGia.Text, txtTenTruyen.Text, txtNhaXuatBan.Text, int.Parse(txtSoLuong.Text));
                if (ds.ThemTruyenTranh(truyentranh))
                {
                    CapNhatListView();
                    Reset();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi dữ liệu!", "Quản lý thông tin truyện tranh - Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMaTruyen.Focus();
                txtMaTruyen.SelectAll();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn có thật sự muốn xóa hay không?", "Quản lý thông tin truyện tranh - Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            for (int i = 0; i < lvData.SelectedItems.Count; i++)
            {
                int maSo = int.Parse(lvData.SelectedItems[i].SubItems[0].Text);
                if (d == DialogResult.OK)
                {
                    ds.XoaTruyenTranh(maSo);
                }
            }
            CapNhatListView();
        }
    }
}


