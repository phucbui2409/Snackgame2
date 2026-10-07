using System;
using System.Drawing;
using System.Windows.Forms;
using SnakeGame.Utils;

namespace SnakeGame.Forms
{
    public partial class MainForm : Form
    {
        // Biến lưu trạng thái bật/tắt âm thanh
        private bool isSoundEnabled = true;

        public MainForm()
        {
            InitializeComponent();
            this.BackColor = GameConfig.BgColor; // dung mau tu config
        }

        private void btnChoi_Click(object sender, EventArgs e)
        {
            // Tam thoi hien thi form trang, doi cac ban khac code game roi xoa dong nay di
            Form frmGame = new Form();
            frmGame.Text = "Màn hình Game";
            
            frmGame.Show();
            this.Hide(); // an menu
        }

        private void btnThanhTich_Click(object sender, EventArgs e)
        {
            LeaderboardForm frm = new LeaderboardForm();
            frm.ShowDialog(); // Hiện form bảng thành tích
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            HowToPlayForm frm = new HowToPlayForm();
            frm.ShowDialog(); // Hiện form hướng dẫn
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Sự kiện khi bấm nút Âm Thanh
        private void btnSound_Click(object sender, EventArgs e)
        {
            isSoundEnabled = !isSoundEnabled; // Đảo trạng thái

            if (isSoundEnabled)
            {
                btnSound.Text = "🔊 Âm Thanh: BẬT";
                btnSound.ForeColor = Color.FromArgb(50, 205, 50); // Màu xanh
            }
            else
            {
                btnSound.Text = "🔇 Âm Thanh: TẮT";
                btnSound.ForeColor = Color.Gray; // Màu xám
            }
        }
    }
}
