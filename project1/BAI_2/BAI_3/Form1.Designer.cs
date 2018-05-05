namespace BAI_3
{
    partial class GPT_bac2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_heso1 = new System.Windows.Forms.TextBox();
            this.textBox_heso3 = new System.Windows.Forms.TextBox();
            this.textBox_heso2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_ketqua = new System.Windows.Forms.TextBox();
            this.button_kq = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_nhaplai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phương trình bậc 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ số thứ nhất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ số thứ hai:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hệ số thứ ba:";
            // 
            // textBox_heso1
            // 
            this.textBox_heso1.Location = new System.Drawing.Point(130, 45);
            this.textBox_heso1.Name = "textBox_heso1";
            this.textBox_heso1.Size = new System.Drawing.Size(217, 20);
            this.textBox_heso1.TabIndex = 4;
            this.textBox_heso1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_heso3
            // 
            this.textBox_heso3.Location = new System.Drawing.Point(130, 126);
            this.textBox_heso3.Name = "textBox_heso3";
            this.textBox_heso3.Size = new System.Drawing.Size(217, 20);
            this.textBox_heso3.TabIndex = 5;
            // 
            // textBox_heso2
            // 
            this.textBox_heso2.Location = new System.Drawing.Point(130, 85);
            this.textBox_heso2.Name = "textBox_heso2";
            this.textBox_heso2.Size = new System.Drawing.Size(217, 20);
            this.textBox_heso2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "KẾT QUẢ:";
            // 
            // textbox_ketqua
            // 
            this.textbox_ketqua.AllowDrop = true;
            this.textbox_ketqua.Location = new System.Drawing.Point(130, 199);
            this.textbox_ketqua.Name = "textbox_ketqua";
            this.textbox_ketqua.ReadOnly = true;
            this.textbox_ketqua.Size = new System.Drawing.Size(217, 20);
            this.textbox_ketqua.TabIndex = 8;
            this.textbox_ketqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox_ketqua.UseWaitCursor = true;
            // 
            // button_kq
            // 
            this.button_kq.Location = new System.Drawing.Point(180, 161);
            this.button_kq.Name = "button_kq";
            this.button_kq.Size = new System.Drawing.Size(75, 23);
            this.button_kq.TabIndex = 9;
            this.button_kq.Text = "Tính";
            this.button_kq.UseVisualStyleBackColor = true;
            this.button_kq.Click += new System.EventHandler(this.button_kq_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(373, 247);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(75, 23);
            this.button_thoat.TabIndex = 10;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_nhaplai
            // 
            this.button_nhaplai.Location = new System.Drawing.Point(252, 247);
            this.button_nhaplai.Name = "button_nhaplai";
            this.button_nhaplai.Size = new System.Drawing.Size(75, 23);
            this.button_nhaplai.TabIndex = 11;
            this.button_nhaplai.Text = "Nhập lại";
            this.button_nhaplai.UseVisualStyleBackColor = true;
            this.button_nhaplai.Click += new System.EventHandler(this.button_nhaplai_Click);
            // 
            // GPT_bac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 282);
            this.Controls.Add(this.button_nhaplai);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_kq);
            this.Controls.Add(this.textbox_ketqua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_heso2);
            this.Controls.Add(this.textBox_heso3);
            this.Controls.Add(this.textBox_heso1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GPT_bac2";
            this.Text = "GPT bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_heso1;
        private System.Windows.Forms.TextBox textBox_heso3;
        private System.Windows.Forms.TextBox textBox_heso2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_ketqua;
        private System.Windows.Forms.Button button_kq;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_nhaplai;
    }
}

