namespace PhamMemQuanLyKho1._1
{
    partial class BoPhanNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoPhanNhanVien));
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv_bophannhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ten = new System.Windows.Forms.TextBox();
            this.txb_ma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exitncc = new System.Windows.Forms.Button();
            this.btn_deletencc = new System.Windows.Forms.Button();
            this.btn_clearncc = new System.Windows.Forms.Button();
            this.btn_fixncc = new System.Windows.Forms.Button();
            this.btn_addncc = new System.Windows.Forms.Button();
            this.txb_searchid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bophannhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(202, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "BỘ PHẬN NHÂN VIÊN";
            // 
            // dtgv_bophannhanvien
            // 
            this.dtgv_bophannhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_bophannhanvien.Location = new System.Drawing.Point(276, 97);
            this.dtgv_bophannhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_bophannhanvien.Name = "dtgv_bophannhanvien";
            this.dtgv_bophannhanvien.RowHeadersWidth = 51;
            this.dtgv_bophannhanvien.RowTemplate.Height = 24;
            this.dtgv_bophannhanvien.Size = new System.Drawing.Size(309, 216);
            this.dtgv_bophannhanvien.TabIndex = 4;
            this.dtgv_bophannhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_bophannhanvien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(272, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(42, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên bộ phận";
            // 
            // txb_ten
            // 
            this.txb_ten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ten.Location = new System.Drawing.Point(46, 263);
            this.txb_ten.Margin = new System.Windows.Forms.Padding(2);
            this.txb_ten.Name = "txb_ten";
            this.txb_ten.Size = new System.Drawing.Size(166, 26);
            this.txb_ten.TabIndex = 7;
            // 
            // txb_ma
            // 
            this.txb_ma.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ma.Location = new System.Drawing.Point(46, 176);
            this.txb_ma.Margin = new System.Windows.Forms.Padding(2);
            this.txb_ma.Name = "txb_ma";
            this.txb_ma.Size = new System.Drawing.Size(166, 26);
            this.txb_ma.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã bộ phận";
            // 
            // btn_exitncc
            // 
            this.btn_exitncc.BackColor = System.Drawing.Color.Transparent;
            this.btn_exitncc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exitncc.BackgroundImage")));
            this.btn_exitncc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exitncc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitncc.ForeColor = System.Drawing.Color.Navy;
            this.btn_exitncc.Location = new System.Drawing.Point(510, 330);
            this.btn_exitncc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exitncc.Name = "btn_exitncc";
            this.btn_exitncc.Size = new System.Drawing.Size(84, 39);
            this.btn_exitncc.TabIndex = 7;
            this.btn_exitncc.Text = "Thoát";
            this.btn_exitncc.UseVisualStyleBackColor = false;
            this.btn_exitncc.Click += new System.EventHandler(this.btn_exitncc_Click);
            // 
            // btn_deletencc
            // 
            this.btn_deletencc.BackColor = System.Drawing.Color.Transparent;
            this.btn_deletencc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_deletencc.BackgroundImage")));
            this.btn_deletencc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deletencc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletencc.ForeColor = System.Drawing.Color.Navy;
            this.btn_deletencc.Location = new System.Drawing.Point(393, 330);
            this.btn_deletencc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deletencc.Name = "btn_deletencc";
            this.btn_deletencc.Size = new System.Drawing.Size(84, 39);
            this.btn_deletencc.TabIndex = 6;
            this.btn_deletencc.Text = "Xóa";
            this.btn_deletencc.UseVisualStyleBackColor = false;
            this.btn_deletencc.Click += new System.EventHandler(this.btn_deletencc_Click);
            // 
            // btn_clearncc
            // 
            this.btn_clearncc.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearncc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clearncc.BackgroundImage")));
            this.btn_clearncc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clearncc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearncc.ForeColor = System.Drawing.Color.Navy;
            this.btn_clearncc.Location = new System.Drawing.Point(33, 330);
            this.btn_clearncc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearncc.Name = "btn_clearncc";
            this.btn_clearncc.Size = new System.Drawing.Size(84, 39);
            this.btn_clearncc.TabIndex = 3;
            this.btn_clearncc.Text = "Làm mới";
            this.btn_clearncc.UseVisualStyleBackColor = false;
            this.btn_clearncc.Click += new System.EventHandler(this.btn_clearncc_Click);
            // 
            // btn_fixncc
            // 
            this.btn_fixncc.BackColor = System.Drawing.Color.Transparent;
            this.btn_fixncc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fixncc.BackgroundImage")));
            this.btn_fixncc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fixncc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fixncc.ForeColor = System.Drawing.Color.Navy;
            this.btn_fixncc.Location = new System.Drawing.Point(274, 330);
            this.btn_fixncc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fixncc.Name = "btn_fixncc";
            this.btn_fixncc.Size = new System.Drawing.Size(84, 39);
            this.btn_fixncc.TabIndex = 5;
            this.btn_fixncc.Text = "Sửa ";
            this.btn_fixncc.UseVisualStyleBackColor = false;
            this.btn_fixncc.Click += new System.EventHandler(this.btn_fixncc_Click);
            // 
            // btn_addncc
            // 
            this.btn_addncc.BackColor = System.Drawing.Color.Transparent;
            this.btn_addncc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addncc.BackgroundImage")));
            this.btn_addncc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addncc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addncc.ForeColor = System.Drawing.Color.Navy;
            this.btn_addncc.Location = new System.Drawing.Point(154, 330);
            this.btn_addncc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addncc.Name = "btn_addncc";
            this.btn_addncc.Size = new System.Drawing.Size(84, 39);
            this.btn_addncc.TabIndex = 4;
            this.btn_addncc.Text = "Thêm";
            this.btn_addncc.UseVisualStyleBackColor = false;
            this.btn_addncc.Click += new System.EventHandler(this.btn_addncc_Click);
            // 
            // txb_searchid
            // 
            this.txb_searchid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_searchid.Location = new System.Drawing.Point(136, 79);
            this.txb_searchid.Margin = new System.Windows.Forms.Padding(2);
            this.txb_searchid.Name = "txb_searchid";
            this.txb_searchid.Size = new System.Drawing.Size(47, 23);
            this.txb_searchid.TabIndex = 11;
            this.txb_searchid.TextChanged += new System.EventHandler(this.txb_searchid_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(44, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tìm kiếm:   ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PhamMemQuanLyKho1._1.Properties.Resources.imagesSearch1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(188, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 32);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BoPhanNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhamMemQuanLyKho1._1.Properties.Resources.awesome_collection_of_simple_background_on_hd_wallpapers_elegant_formal_powerpoint_background_designs_640x480;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_searchid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_exitncc);
            this.Controls.Add(this.btn_deletencc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_fixncc);
            this.Controls.Add(this.btn_clearncc);
            this.Controls.Add(this.btn_addncc);
            this.Controls.Add(this.txb_ten);
            this.Controls.Add(this.txb_ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_bophannhanvien);
            this.Controls.Add(this.label5);
            this.Name = "BoPhanNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bộ Phận Nhân Viên";
            this.Load += new System.EventHandler(this.BoPhanNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bophannhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgv_bophannhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_ten;
        private System.Windows.Forms.TextBox txb_ma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_exitncc;
        private System.Windows.Forms.Button btn_deletencc;
        private System.Windows.Forms.Button btn_clearncc;
        private System.Windows.Forms.Button btn_fixncc;
        private System.Windows.Forms.Button btn_addncc;
        private System.Windows.Forms.TextBox txb_searchid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

