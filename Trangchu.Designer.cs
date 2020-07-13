namespace LB
{
    partial class Trangchu
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
            this.tenqttxt = new System.Windows.Forms.Label();
            this.doimkbtn = new System.Windows.Forms.Button();
            this.dangxuatbtn = new System.Windows.Forms.Button();
            this.tkbtn = new System.Windows.Forms.Button();
            this.xoabtn = new System.Windows.Forms.Button();
            this.thembtn = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.tg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tenqttxt
            // 
            this.tenqttxt.AutoSize = true;
            this.tenqttxt.Location = new System.Drawing.Point(149, 15);
            this.tenqttxt.Name = "tenqttxt";
            this.tenqttxt.Size = new System.Drawing.Size(77, 17);
            this.tenqttxt.TabIndex = 0;
            this.tenqttxt.Text = "Ten ng qtri";
            // 
            // doimkbtn
            // 
            this.doimkbtn.Location = new System.Drawing.Point(628, 5);
            this.doimkbtn.Name = "doimkbtn";
            this.doimkbtn.Size = new System.Drawing.Size(135, 37);
            this.doimkbtn.TabIndex = 1;
            this.doimkbtn.Text = "Đổi mật khẩu";
            this.doimkbtn.UseVisualStyleBackColor = true;
            this.doimkbtn.Click += new System.EventHandler(this.doimkbtn_Click);
            // 
            // dangxuatbtn
            // 
            this.dangxuatbtn.Location = new System.Drawing.Point(789, 5);
            this.dangxuatbtn.Name = "dangxuatbtn";
            this.dangxuatbtn.Size = new System.Drawing.Size(95, 37);
            this.dangxuatbtn.TabIndex = 2;
            this.dangxuatbtn.Text = "Đăng xuất";
            this.dangxuatbtn.UseVisualStyleBackColor = true;
            this.dangxuatbtn.Click += new System.EventHandler(this.dangxuatbtn_Click);
            // 
            // tkbtn
            // 
            this.tkbtn.Location = new System.Drawing.Point(152, 100);
            this.tkbtn.Name = "tkbtn";
            this.tkbtn.Size = new System.Drawing.Size(123, 36);
            this.tkbtn.TabIndex = 3;
            this.tkbtn.Text = "Xem thống kê";
            this.tkbtn.UseVisualStyleBackColor = true;
            this.tkbtn.Click += new System.EventHandler(this.tkbtn_Click);
            // 
            // xoabtn
            // 
            this.xoabtn.Location = new System.Drawing.Point(307, 100);
            this.xoabtn.Name = "xoabtn";
            this.xoabtn.Size = new System.Drawing.Size(98, 36);
            this.xoabtn.TabIndex = 4;
            this.xoabtn.Text = "Xóa thủ thư";
            this.xoabtn.UseVisualStyleBackColor = true;
            this.xoabtn.Click += new System.EventHandler(this.xoabtn_Click);
            // 
            // thembtn
            // 
            this.thembtn.Location = new System.Drawing.Point(450, 100);
            this.thembtn.Name = "thembtn";
            this.thembtn.Size = new System.Drawing.Size(106, 36);
            this.thembtn.TabIndex = 5;
            this.thembtn.Text = "Thêm thủ thư";
            this.thembtn.UseVisualStyleBackColor = true;
            this.thembtn.Click += new System.EventHandler(this.thembtn_Click);
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tg,
            this.matt,
            this.tglv});
            this.Dgv.Location = new System.Drawing.Point(45, 167);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersWidth = 51;
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(839, 336);
            this.Dgv.TabIndex = 7;
            this.Dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // tg
            // 
            this.tg.DataPropertyName = "tentt";
            this.tg.HeaderText = "tentt";
            this.tg.MaxInputLength = 100;
            this.tg.MinimumWidth = 6;
            this.tg.Name = "tg";
            this.tg.Width = 125;
            // 
            // matt
            // 
            this.matt.DataPropertyName = "matt";
            this.matt.HeaderText = "matt";
            this.matt.MaxInputLength = 100;
            this.matt.MinimumWidth = 6;
            this.matt.Name = "matt";
            this.matt.Width = 125;
            // 
            // tglv
            // 
            this.tglv.DataPropertyName = "tglv";
            this.tglv.HeaderText = "tglv";
            this.tglv.MaxInputLength = 100;
            this.tglv.MinimumWidth = 6;
            this.tglv.Name = "tglv";
            this.tglv.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LB.Properties.Resources.danh_sach_cac_tiem_chup_anh_the_lay_ngay_dep_nhat_ha_noi_15653_130862_0;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 515);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.thembtn);
            this.Controls.Add(this.xoabtn);
            this.Controls.Add(this.tkbtn);
            this.Controls.Add(this.dangxuatbtn);
            this.Controls.Add(this.doimkbtn);
            this.Controls.Add(this.tenqttxt);
            this.Name = "Trangchu";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tenqttxt;
        private System.Windows.Forms.Button doimkbtn;
        private System.Windows.Forms.Button dangxuatbtn;
        private System.Windows.Forms.Button tkbtn;
        private System.Windows.Forms.Button xoabtn;
        private System.Windows.Forms.Button thembtn;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg;
        private System.Windows.Forms.DataGridViewTextBoxColumn matt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglv;
    }
}

