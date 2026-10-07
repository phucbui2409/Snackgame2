using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SnakeGame.Utils;

namespace SnakeGame.Forms
{
    public partial class LeaderboardForm : Form
    {
        class NguoiChoi 
        {
            public string Ten { get; set; }
            public int Diem { get; set; }
        }

        public LeaderboardForm()
        {
            InitializeComponent();
            this.BackColor = GameConfig.BgColor; 
        }

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            string filePath = "scores.txt";

            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, new string[] {
                    "Chuyên Gia|500",
                    "Thành Viên Nhóm|350",
                    "Gà Mờ|100",
                    "Cao Thủ|420",
                    "Người Qua Đường|50"
                });
            }

            List<NguoiChoi> danhSach = new List<NguoiChoi>();
            string[] lines = File.ReadAllLines(filePath);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    NguoiChoi nc = new NguoiChoi();
                    nc.Ten = parts[0];
                    
                    int diem = 0;
                    int.TryParse(parts[1], out diem);
                    nc.Diem = diem;
                    
                    danhSach.Add(nc);
                }
            }

            danhSach = danhSach.OrderByDescending(x => x.Diem).ToList();

            // Đổ dữ liệu vào bảng DataGridView mới
            dgvDiem.Rows.Clear();
            for (int i = 0; i < danhSach.Count; i++)
            {
                string xepHang = "";
                
                if (i == 0) xepHang = "🥇 Hạng 1";
                else if (i == 1) xepHang = "🥈 Hạng 2";
                else if (i == 2) xepHang = "🥉 Hạng 3";
                else xepHang = $"   Hạng {i + 1}";

                dgvDiem.Rows.Add(xepHang, danhSach[i].Ten, danhSach[i].Diem);
            }
            
            dgvDiem.ClearSelection(); // Xóa bôi xanh dòng đầu tiên
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
