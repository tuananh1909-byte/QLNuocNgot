using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNuocNgot
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy registerForm = new FormDangKy(); // Tạo Form đăng ký
            this.Hide(); // Ẩn Form đăng nhập
            registerForm.ShowDialog(); // Hiển thị Form đăng ký (chờ đóng)
            this.Show(); // Hiện lại Form đăng nhập khi Form đăng ký đóng
        }
    }
}
