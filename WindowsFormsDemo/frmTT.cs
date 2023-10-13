using BusinessObjects;
using EnvDTE90;
using Microsoft.VisualStudio.Shell.Interop;
using Repositories;
using System;
using System.Windows.Forms;

namespace ProjectManagementWinApp_NguyenQuangVinh
{
    public enum State
    {
        EDIT,
        INSERT,
        DELETE,
        NORMAL
    }
    public partial class frmTT : Form
    {
        private State formState;
        private ICartoonRepository cartoonRepository;
        public frmTT()
        {
            InitializeComponent();
            cartoonRepository = new CartoonRepository();
            formState = State.NORMAL;
            StateChangeHandler();
            LoadType();
        }

        private void LoadType()
        {
            var list = cartoonRepository.GetCartoonTypes();
            foreach (var type in list)
            {
                cbCartoonType.Items.Insert(type.CartoonTypeId - 1, type.CartoonName);
            }

        }

        void Reset()
        {
            txtCartoonCode.Text = "";
            txtCartoonName.Text = "";
            txtActors.Text = "";
            cbCartoonType.SelectedIndex = 0;
            txtReleaseDate.Text = "";
            txtProducer.Text = "";
            txtCountry.Text = "";
            txtDirector.Text = "";
            rtbShortDescription.Text = "";
        }
        private void DisableInput()
        {
            txtCartoonCode.Enabled = false;
            txtCartoonName.Enabled = false;
            txtActors.Enabled = false;
            cbCartoonType.Enabled = false;
            txtReleaseDate.Enabled = false;
            txtProducer.Enabled = false;
            txtCountry.Enabled = false;
            txtDirector.Enabled = false;
            rtbShortDescription.Enabled = false;
            btnLuu.Enabled = false;
        }
        void CapNhatListView()
        {
            lvData.Items.Clear();
            var cartoonList = cartoonRepository.GetCartoons();
            foreach (var cartoon in cartoonList)
            {
                lvData.Items.Add(new ListViewItem(new string[] { "" +
                    cartoon.CartoonId, cartoon.CartoonName, cartoon.LaunchDate.ToString(), cartoon.CartoonTypeNavigation.CartoonName,
                    cartoon.ShortDescription, cartoon.Actors, cartoon.Director,cartoon.Country,cartoon.Producer }));
            }
        }

        private void frmTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("You already want to exit?", "Cartoon Management System",
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
                formState = State.INSERT;
                for (int i = 0; i < lvData.SelectedItems.Count; i++)
                {
                    lvData.SelectedItems[i].Selected = false;
                }
                StateChangeHandler();
                txtCartoonCode.Focus();
            }
            else
            {
                formState = State.NORMAL;
                StateChangeHandler();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(formState == State.EDIT)
            {
                try
                {
                    var cartoon = new Cartoon(
                        decimal.Parse(txtCartoonCode.Text),
                        txtCartoonName.Text,
                        DateTime.Parse(txtReleaseDate.Text),
                        cbCartoonType.SelectedIndex + 1,
                        rtbShortDescription.Text,
                        txtActors.Text,
                        txtDirector.Text,
                        txtCountry.Text,
                        txtProducer.Text
                    );
                    cartoonRepository.UpdateCartoon(cartoon);
                    CapNhatListView();
                    formState = State.NORMAL;
                    StateChangeHandler();
                    MessageBox.Show("Lưu thành công!", "Quản lý thông tin truyện tranh - Lưu thay đổi",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                    Reset();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi dữ liệu!", "Quản lý thông tin truyện tranh - Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtCartoonCode.Focus();
                    txtCartoonCode.SelectAll();
                }
            }
            if(formState == State.INSERT)
            {
                try
                {
                    var cartoon = new Cartoon(
                        txtCartoonName.Text,
                        DateTime.Parse(txtReleaseDate.Text),
                        cbCartoonType.SelectedIndex + 1,
                        rtbShortDescription.Text,
                        txtActors.Text,
                        txtDirector.Text,
                        txtCountry.Text,
                        txtProducer.Text
                    );
                    cartoonRepository.SaveCartoon(cartoon);
                    CapNhatListView();
                    MessageBox.Show("Lưu thành công!", "Quản lý thông tin truyện tranh - Thêm dữ liệu",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                    Reset();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi dữ liệu!", "Quản lý thông tin truyện tranh - Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtCartoonCode.Focus();
                    txtCartoonCode.SelectAll();
                }
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
                    var temp = cartoonRepository.GetCartoonById(maSo);
                    cartoonRepository.DeleteCartoon(temp);
                }
            }
            CapNhatListView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CapNhatListView();
        }

        private void lvData_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < lvData.SelectedItems.Count; i++)
            {
                int maSo = int.Parse(lvData.SelectedItems[i].SubItems[0].Text);
                Cartoon cartoon = cartoonRepository.GetCartoonById((int)maSo);
                if(cartoon != null) FetchCartoonData(cartoon);
            }
            formState = State.EDIT;
            StateChangeHandler();
        }

        private void FetchCartoonData(Cartoon data)
        {
            txtCartoonCode.Text = data.CartoonId.ToString();
            txtCartoonName.Text = data.CartoonName;
            txtActors.Text = data.Actors;
            cbCartoonType.SelectedIndex = data.CartoonType - 1;
            txtReleaseDate.Text = data.LaunchDate.ToString();
            txtProducer.Text = data.Producer;
            txtCountry.Text = data.Country;
            txtDirector.Text = data.Director;
            rtbShortDescription.Text = data.ShortDescription;
        }

        private void StateChangeHandler()
        {
            switch(this.formState)
            {
                case State.EDIT:
                    txtCartoonName.Enabled = true;
                    txtActors.Enabled = true;
                    cbCartoonType.Enabled = true;
                    txtReleaseDate.Enabled = true;
                    txtProducer.Enabled = true;
                    txtCountry.Enabled = true;
                    txtDirector.Enabled = true;
                    rtbShortDescription.Enabled = true;
                    btnLuu.Enabled = true;
                    btnThem.Enabled = false;
                    txtCartoonCode.Focus();
                    break;

                case State.NORMAL:
                    btnThem.Text = "Thêm";
                    DisableInput();
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = true;
                    break;

                case State.INSERT:
                    Reset();
                    btnThem.Text = "Hủy";
                    txtCartoonName.Enabled = true;
                    txtActors.Enabled = true;
                    cbCartoonType.SelectedIndex = 0;
                    cbCartoonType.Enabled = true;
                    txtReleaseDate.Enabled = true;
                    txtProducer.Enabled = true;
                    txtCountry.Enabled = true;
                    txtDirector.Enabled = true;
                    rtbShortDescription.Enabled = true;
                    btnLuu.Enabled = true;
                    txtCartoonCode.Focus();
                    break;
            }
        }


        
    }
}


