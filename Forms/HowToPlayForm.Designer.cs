namespace SnakeGame.Forms
{
    partial class HowToPlayForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblHuongDanTitle = new System.Windows.Forms.Label();
            this.lblHuongDanText = new System.Windows.Forms.Label();
            this.lblLuatChoiTitle = new System.Windows.Forms.Label();
            this.lblLuatChoiText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "📖 HƯỚNG DẪN CHƠI";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(140, 420);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(200, 45);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "🔙 Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.lblHuongDanText);
            this.panel1.Controls.Add(this.lblHuongDanTitle);
            this.panel1.Location = new System.Drawing.Point(40, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 140);
            this.panel1.TabIndex = 3;
            // 
            // lblHuongDanTitle
            // 
            this.lblHuongDanTitle.AutoSize = true;
            this.lblHuongDanTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHuongDanTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.lblHuongDanTitle.Location = new System.Drawing.Point(10, 10);
            this.lblHuongDanTitle.Name = "lblHuongDanTitle";
            this.lblHuongDanTitle.Size = new System.Drawing.Size(201, 25);
            this.lblHuongDanTitle.TabIndex = 0;
            this.lblHuongDanTitle.Text = "🎮 CÁCH ĐIỀU KHIỂN";
            // 
            // lblHuongDanText
            // 
            this.lblHuongDanText.AutoSize = true;
            this.lblHuongDanText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHuongDanText.ForeColor = System.Drawing.Color.White;
            this.lblHuongDanText.Location = new System.Drawing.Point(20, 45);
            this.lblHuongDanText.Name = "lblHuongDanText";
            this.lblHuongDanText.Size = new System.Drawing.Size(350, 84);
            this.lblHuongDanText.TabIndex = 1;
            this.lblHuongDanText.Text = "• Dùng 4 phím Mũi Tên (Lên, Xuống, Trái, Phải)\r\n• Hoặc dùng phím W, A, S, D để di chuyển rắn.\r\n• Nhấn phím P hoặc ESC để Tạm dừng game.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.lblLuatChoiText);
            this.panel2.Controls.Add(this.lblLuatChoiTitle);
            this.panel2.Location = new System.Drawing.Point(40, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 150);
            this.panel2.TabIndex = 4;
            // 
            // lblLuatChoiTitle
            // 
            this.lblLuatChoiTitle.AutoSize = true;
            this.lblLuatChoiTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLuatChoiTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.lblLuatChoiTitle.Location = new System.Drawing.Point(10, 10);
            this.lblLuatChoiTitle.Name = "lblLuatChoiTitle";
            this.lblLuatChoiTitle.Size = new System.Drawing.Size(133, 25);
            this.lblLuatChoiTitle.TabIndex = 0;
            this.lblLuatChoiTitle.Text = "📜 LUẬT CHƠI";
            // 
            // lblLuatChoiText
            // 
            this.lblLuatChoiText.AutoSize = true;
            this.lblLuatChoiText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLuatChoiText.ForeColor = System.Drawing.Color.White;
            this.lblLuatChoiText.Location = new System.Drawing.Point(20, 45);
            this.lblLuatChoiText.Name = "lblLuatChoiText";
            this.lblLuatChoiText.Size = new System.Drawing.Size(350, 84);
            this.lblLuatChoiText.TabIndex = 1;
            this.lblLuatChoiText.Text = "• Điều khiển rắn ăn các chấm mồi để ghi điểm.\r\n• Mỗi lần ăn mồi, rắn sẽ dài thêm 1 ô.\r\n• Game Over nếu rắn đâm vào tường hoặc tự cắn.";
            // 
            // HowToPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(484, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HowToPlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hướng Dẫn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHuongDanTitle;
        private System.Windows.Forms.Label lblHuongDanText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLuatChoiTitle;
        private System.Windows.Forms.Label lblLuatChoiText;
    }
}
