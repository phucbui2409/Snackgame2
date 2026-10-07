using System;
using System.Windows.Forms;
using SnakeGame.Utils;

namespace SnakeGame.Forms
{
    public partial class HowToPlayForm : Form
    {
        public HowToPlayForm()
        {
            InitializeComponent();
            this.BackColor = GameConfig.BgColor; // Đồng bộ màu nền
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hướng dẫn để quay lại menu
        }
    }
}
