﻿namespace Calculator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnDoiDau = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnPhanTram = new System.Windows.Forms.Button();
            this.btnBe = new System.Windows.Forms.Button();
            this.btnNho = new System.Windows.Forms.Button();
            this.btnThapPhan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(22, 18);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(202, 37);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0.";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(66, 232);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(35, 35);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(25, 191);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 35);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(66, 191);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 35);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(107, 191);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 35);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(25, 150);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 35);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(148, 108);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(35, 35);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(66, 150);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 35);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(66, 109);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(35, 35);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(107, 150);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 35);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(148, 150);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(35, 35);
            this.btnTru.TabIndex = 10;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(107, 109);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(35, 35);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(148, 232);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(35, 35);
            this.btnChia.TabIndex = 12;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(148, 191);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(35, 35);
            this.btnNhan.TabIndex = 13;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btnDoiDau
            // 
            this.btnDoiDau.Location = new System.Drawing.Point(25, 232);
            this.btnDoiDau.Name = "btnDoiDau";
            this.btnDoiDau.Size = new System.Drawing.Size(35, 35);
            this.btnDoiDau.TabIndex = 14;
            this.btnDoiDau.Text = "-/+";
            this.btnDoiDau.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(25, 109);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 35);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnPhanTram
            // 
            this.btnPhanTram.Location = new System.Drawing.Point(189, 108);
            this.btnPhanTram.Name = "btnPhanTram";
            this.btnPhanTram.Size = new System.Drawing.Size(35, 35);
            this.btnPhanTram.TabIndex = 16;
            this.btnPhanTram.Text = "%";
            this.btnPhanTram.UseVisualStyleBackColor = true;
            // 
            // btnBe
            // 
            this.btnBe.Location = new System.Drawing.Point(189, 150);
            this.btnBe.Name = "btnBe";
            this.btnBe.Size = new System.Drawing.Size(35, 35);
            this.btnBe.TabIndex = 17;
            this.btnBe.Text = "<";
            this.btnBe.UseVisualStyleBackColor = true;
            // 
            // btnNho
            // 
            this.btnNho.Location = new System.Drawing.Point(25, 68);
            this.btnNho.Name = "btnNho";
            this.btnNho.Size = new System.Drawing.Size(76, 35);
            this.btnNho.TabIndex = 18;
            this.btnNho.Text = "C";
            this.btnNho.UseVisualStyleBackColor = true;
            // 
            // btnThapPhan
            // 
            this.btnThapPhan.Location = new System.Drawing.Point(107, 232);
            this.btnThapPhan.Name = "btnThapPhan";
            this.btnThapPhan.Size = new System.Drawing.Size(35, 35);
            this.btnThapPhan.TabIndex = 19;
            this.btnThapPhan.Text = ".";
            this.btnThapPhan.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(107, 68);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 35);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Backspace";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnBang
            // 
            this.btnBang.Location = new System.Drawing.Point(189, 191);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(35, 76);
            this.btnBang.TabIndex = 21;
            this.btnBang.Text = "=";
            this.btnBang.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 308);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThapPhan);
            this.Controls.Add(this.btnNho);
            this.Controls.Add(this.btnBe);
            this.Controls.Add(this.btnPhanTram);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDoiDau);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.lblDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.NhapPhepToan);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnDoiDau;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnPhanTram;
        private System.Windows.Forms.Button btnBe;
        private System.Windows.Forms.Button btnNho;
        private System.Windows.Forms.Button btnThapPhan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBang;
    }
}

