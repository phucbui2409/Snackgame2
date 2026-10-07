namespace SnakeGame.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnChoi = new System.Windows.Forms.Button();
            this.btnThanhTich = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(85, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "🐍 SNAKE GAME";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitle.Location = new System.Drawing.Point(145, 115);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(200, 20);
            this.lblSubtitle.TabIndex = 6;
            this.lblSubtitle.Text = "Lập Trình Windows — Nhóm 5";
            // 
            // btnChoi
            // 
            this.btnChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnChoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoi.FlatAppearance.BorderSize = 0;
            this.btnChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChoi.ForeColor = System.Drawing.Color.White;
            this.btnChoi.Location = new System.Drawing.Point(140, 180);
            this.btnChoi.Name = "btnChoi";
            this.btnChoi.Size = new System.Drawing.Size(220, 52);
            this.btnChoi.TabIndex = 1;
            this.btnChoi.Text = "🎮 Chơi Game";
            this.btnChoi.UseVisualStyleBackColor = false;
            this.btnChoi.Click += new System.EventHandler(this.btnChoi_Click);
            // 
            // btnThanhTich
            // 
            this.btnThanhTich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnThanhTich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhTich.FlatAppearance.BorderSize = 0;
            this.btnThanhTich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhTich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhTich.ForeColor = System.Drawing.Color.White;
            this.btnThanhTich.Location = new System.Drawing.Point(140, 250);
            this.btnThanhTich.Name = "btnThanhTich";
            this.btnThanhTich.Size = new System.Drawing.Size(220, 52);
            this.btnThanhTich.TabIndex = 2;
            this.btnThanhTich.Text = "🏆 Bảng Thành Tích";
            this.btnThanhTich.UseVisualStyleBackColor = false;
            this.btnThanhTich.Click += new System.EventHandler(this.btnThanhTich_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnHuongDan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuongDan.FlatAppearance.BorderSize = 0;
            this.btnHuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuongDan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuongDan.ForeColor = System.Drawing.Color.White;
            this.btnHuongDan.Location = new System.Drawing.Point(140, 320);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(220, 52);
            this.btnHuongDan.TabIndex = 3;
            this.btnHuongDan.Text = "📖 Hướng Dẫn";
            this.btnHuongDan.UseVisualStyleBackColor = false;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(140, 390);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(220, 52);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "❌ Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.btnSound.Location = new System.Drawing.Point(340, 15);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(130, 32);
            this.btnSound.TabIndex = 5;
            this.btnSound.Text = "🔊 Âm Thanh: BẬT";
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnThanhTich);
            this.Controls.Add(this.btnChoi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game - Nhóm 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnChoi;
        private System.Windows.Forms.Button btnThanhTich;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSound;
    }
}
