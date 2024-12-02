using System;
using System.Windows.Forms;

namespace TuQuangMinh_B3
{
    public partial class ListView1 : Form
    {
        public ListView1()
        {
            InitializeComponent();
        }

        // Thêm sinh viên vào danh sách
        private void btnThem_Click(object sender, EventArgs e)
        {
            var newItem = new ListViewItem(txtLastName.Text)
            {
                SubItems = { txtFirstName.Text, txtPhone.Text }
            };
            lvSinhVien.Items.Add(newItem);
            ClearTextBoxes();
        }

        // Cập nhật thông tin sinh viên được chọn
        private void button2_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để cập nhật!");
                return;
            }

            var selectedItem = lvSinhVien.SelectedItems[0];
            selectedItem.SubItems[0].Text = txtLastName.Text;
            selectedItem.SubItems[1].Text = txtFirstName.Text;
            selectedItem.SubItems[2].Text = txtPhone.Text;
        }

        // Xóa sinh viên được chọn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng để xóa!");
                return;
            }

            lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
        }

        // Tải thông tin sinh viên vào các TextBox khi form load
        private void Form2_Load(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                var selectedItem = lvSinhVien.SelectedItems[0];
                txtLastName.Text = selectedItem.SubItems[0].Text;
                txtFirstName.Text = selectedItem.SubItems[1].Text;
                txtPhone.Text = selectedItem.SubItems[2].Text;
            }

        }

        // Xóa nội dung các TextBox
        private void ClearTextBoxes()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();
        }
    }
}
