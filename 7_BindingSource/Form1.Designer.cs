﻿namespace _7_BindingSource
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbGu = new System.Windows.Forms.ComboBox();
            this.dgvDong = new System.Windows.Forms.DataGridView();
            this.tbGuAvgDem = new System.Windows.Forms.TextBox();
            this.tbGuMinDem = new System.Windows.Forms.TextBox();
            this.tbGuMaxDem = new System.Windows.Forms.TextBox();
            this.tbDongMaxDem = new System.Windows.Forms.TextBox();
            this.tbDongMinDem = new System.Windows.Forms.TextBox();
            this.tbDongAvgDem = new System.Windows.Forms.TextBox();
            this.dgvDongDem = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongDem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "서울시 자치구 :";
            // 
            // cbGu
            // 
            this.cbGu.FormattingEnabled = true;
            this.cbGu.Location = new System.Drawing.Point(155, 46);
            this.cbGu.Name = "cbGu";
            this.cbGu.Size = new System.Drawing.Size(121, 23);
            this.cbGu.TabIndex = 1;
            // 
            // dgvDong
            // 
            this.dgvDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDong.Location = new System.Drawing.Point(40, 118);
            this.dgvDong.Name = "dgvDong";
            this.dgvDong.RowHeadersWidth = 51;
            this.dgvDong.RowTemplate.Height = 27;
            this.dgvDong.Size = new System.Drawing.Size(385, 182);
            this.dgvDong.TabIndex = 2;
            // 
            // tbGuAvgDem
            // 
            this.tbGuAvgDem.Location = new System.Drawing.Point(446, 168);
            this.tbGuAvgDem.Name = "tbGuAvgDem";
            this.tbGuAvgDem.Size = new System.Drawing.Size(100, 25);
            this.tbGuAvgDem.TabIndex = 4;
            // 
            // tbGuMinDem
            // 
            this.tbGuMinDem.Location = new System.Drawing.Point(565, 168);
            this.tbGuMinDem.Name = "tbGuMinDem";
            this.tbGuMinDem.Size = new System.Drawing.Size(100, 25);
            this.tbGuMinDem.TabIndex = 5;
            // 
            // tbGuMaxDem
            // 
            this.tbGuMaxDem.Location = new System.Drawing.Point(688, 168);
            this.tbGuMaxDem.Name = "tbGuMaxDem";
            this.tbGuMaxDem.Size = new System.Drawing.Size(100, 25);
            this.tbGuMaxDem.TabIndex = 6;
            // 
            // tbDongMaxDem
            // 
            this.tbDongMaxDem.Location = new System.Drawing.Point(688, 275);
            this.tbDongMaxDem.Name = "tbDongMaxDem";
            this.tbDongMaxDem.Size = new System.Drawing.Size(100, 25);
            this.tbDongMaxDem.TabIndex = 9;
            // 
            // tbDongMinDem
            // 
            this.tbDongMinDem.Location = new System.Drawing.Point(565, 275);
            this.tbDongMinDem.Name = "tbDongMinDem";
            this.tbDongMinDem.Size = new System.Drawing.Size(100, 25);
            this.tbDongMinDem.TabIndex = 8;
            // 
            // tbDongAvgDem
            // 
            this.tbDongAvgDem.Location = new System.Drawing.Point(446, 275);
            this.tbDongAvgDem.Name = "tbDongAvgDem";
            this.tbDongAvgDem.Size = new System.Drawing.Size(100, 25);
            this.tbDongAvgDem.TabIndex = 7;
            // 
            // dgvDongDem
            // 
            this.dgvDongDem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDongDem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDongDem.Location = new System.Drawing.Point(40, 358);
            this.dgvDongDem.Name = "dgvDongDem";
            this.dgvDongDem.RowHeadersWidth = 51;
            this.dgvDongDem.RowTemplate.Height = 27;
            this.dgvDongDem.Size = new System.Drawing.Size(748, 196);
            this.dgvDongDem.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "평균 표고";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "최소 표고";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "최대 표고";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(685, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "최대 표고";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(562, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "최소 표고";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "평균 표고";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "선택된 자치구의 DEM 통계";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "선택된 법정동의 DEM 통계";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "법정동 리스트";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "법정동 DEM 분석 결과";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDongDem);
            this.Controls.Add(this.tbDongMaxDem);
            this.Controls.Add(this.tbDongMinDem);
            this.Controls.Add(this.tbDongAvgDem);
            this.Controls.Add(this.tbGuMaxDem);
            this.Controls.Add(this.tbGuMinDem);
            this.Controls.Add(this.tbGuAvgDem);
            this.Controls.Add(this.dgvDong);
            this.Controls.Add(this.cbGu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDongDem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGu;
        private System.Windows.Forms.DataGridView dgvDong;
        private System.Windows.Forms.TextBox tbGuAvgDem;
        private System.Windows.Forms.TextBox tbGuMinDem;
        private System.Windows.Forms.TextBox tbGuMaxDem;
        private System.Windows.Forms.TextBox tbDongMaxDem;
        private System.Windows.Forms.TextBox tbDongMinDem;
        private System.Windows.Forms.TextBox tbDongAvgDem;
        private System.Windows.Forms.DataGridView dgvDongDem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

