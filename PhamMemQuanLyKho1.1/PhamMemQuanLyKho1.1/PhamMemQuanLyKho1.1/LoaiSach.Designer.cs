namespace PhamMemQuanLyKho1._1
{
    partial class LoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiSach));
            this.txb_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_loaisach = new System.Windows.Forms.DataGridView();
            this.tenloaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_exitncc = new System.Windows.Forms.Button();
            this.btn_deletencc = new System.Windows.Forms.Button();
            this.btn_clearncc = new System.Windows.Forms.Button();
            this.btn_addncc = new System.Windows.Forms.Button();
            this.txb_searchid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_lưu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaisach)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_ten
            // 
            this.txb_ten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ten.Location = new System.Drawing.Point(15, 129);
            this.txb_ten.Margin = new System.Windows.Forms.Padding(2);
            this.txb_ten.Name = "txb_ten";
            this.txb_ten.Size = new System.Drawing.Size(185, 26);
            this.txb_ten.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên thể loại : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(200, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách thể loại ";
            // 
            // dtgv_loaisach
            // 
            this.dtgv_loaisach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_loaisach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_loaisach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenloaisach});
            this.dtgv_loaisach.Location = new System.Drawing.Point(204, 108);
            this.dtgv_loaisach.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_loaisach.Name = "dtgv_loaisach";
            this.dtgv_loaisach.RowHeadersWidth = 51;
            this.dtgv_loaisach.RowTemplate.Height = 24;
            this.dtgv_loaisach.Size = new System.Drawing.Size(322, 235);
            this.dtgv_loaisach.TabIndex = 13;
            this.dtgv_loaisach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_loaisach_CellClick);
            // 
            // tenloaisach
            // 
            this.tenloaisach.DataPropertyName = "tenloaisach";
            this.tenloaisach.HeaderText = "Tên loại sách";
            this.tenloaisach.Name = "tenloaisach";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(171, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "THỂ LOẠI SÁCH";
            // 
            // btn_exitncc
            // 
            this.btn_exitncc.BackColor = System.Drawing.Color.Transparent;
            this.btn_exitncc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exitncc.BackgroundImage")));
            this.btn_exitncc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exitncc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitncc.ForeColor = System.Drawing.Color.Red;
            this.btn_exitncc.Location = new System.Drawing.Point(110, 307);
            this.btn_exitncc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exitncc.Name = "btn_exitncc";
            this.btn_exitncc.Size = new System.Drawing.Size(90, 40);
            this.btn_exitncc.TabIndex = 18;
            this.btn_exitncc.Text = "Thoát";
            this.btn_exitncc.UseVisualStyleBackColor = false;
            this.btn_exitncc.Click += new System.EventHandler(this.btn_exitncc_Click);
            // 
            // btn_deletencc
            // 
            this.btn_deletencc.BackColor = System.Drawing.Color.Transparent;
            this.btn_deletencc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_deletencc.BackgroundImage")));
            this.btn_deletencc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deletencc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletencc.ForeColor = System.Drawing.Color.Navy;
            this.btn_deletencc.Location = new System.Drawing.Point(15, 307);
            this.btn_deletencc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deletencc.Name = "btn_deletencc";
            this.btn_deletencc.Size = new System.Drawing.Size(90, 40);
            this.btn_deletencc.TabIndex = 16;
            this.btn_deletencc.Text = "Xóa";
            this.btn_deletencc.UseVisualStyleBackColor = false;
            this.btn_deletencc.Click += new System.EventHandler(this.btn_deletencc_Click);
            // 
            // btn_clearncc
            // 
            this.btn_clearncc.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearncc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clearncc.BackgroundImage")));
            this.btn_clearncc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clearncc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearncc.ForeColor = System.Drawing.Color.Navy;
            this.btn_clearncc.Location = new System.Drawing.Point(15, 226);
            this.btn_clearncc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearncc.Name = "btn_clearncc";
            this.btn_clearncc.Size = new System.Drawing.Size(90, 40);
            this.btn_clearncc.TabIndex = 10;
            this.btn_clearncc.Text = "Làm mới";
            this.btn_clearncc.UseVisualStyleBackColor = false;
            this.btn_clearncc.Click += new System.EventHandler(this.btn_clearncc_Click);
            // 
            // btn_addncc
            // 
            this.btn_addncc.BackColor = System.Drawing.Color.Transparent;
            this.btn_addncc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addncc.BackgroundImage")));
            this.btn_addncc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addncc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addncc.ForeColor = System.Drawing.Color.Navy;
            this.btn_addncc.Location = new System.Drawing.Point(15, 182);
            this.btn_addncc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addncc.Name = "btn_addncc";
            this.btn_addncc.Size = new System.Drawing.Size(90, 40);
            this.btn_addncc.TabIndex = 12;
            this.btn_addncc.Text = "Thêm";
            this.btn_addncc.UseVisualStyleBackColor = false;
            this.btn_addncc.Click += new System.EventHandler(this.btn_addncc_Click);
            // 
            // txb_searchid
            // 
            this.txb_searchid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_searchid.Location = new System.Drawing.Point(439, 83);
            this.txb_searchid.Margin = new System.Windows.Forms.Padding(2);
            this.txb_searchid.Name = "txb_searchid";
            this.txb_searchid.Size = new System.Drawing.Size(47, 23);
            this.txb_searchid.TabIndex = 23;
            this.txb_searchid.TextChanged += new System.EventHandler(this.txb_searchid_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(373, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tìm kiếm: ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PhamMemQuanLyKho1._1.Properties.Resources.imagesSearch;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(491, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_lưu
            // 
            this.btn_lưu.BackColor = System.Drawing.Color.Transparent;
            this.btn_lưu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_lưu.BackgroundImage")));
            this.btn_lưu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lưu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lưu.ForeColor = System.Drawing.Color.Navy;
            this.btn_lưu.Location = new System.Drawing.Point(110, 226);
            this.btn_lưu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_lưu.Name = "btn_lưu";
            this.btn_lưu.Size = new System.Drawing.Size(90, 40);
            this.btn_lưu.TabIndex = 25;
            this.btn_lưu.Text = "Lưu";
            this.btn_lưu.UseVisualStyleBackColor = false;
            this.btn_lưu.Click += new System.EventHandler(this.btn_fixncc_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Transparent;
            this.btn_sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sua.BackgroundImage")));
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sua.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Navy;
            this.btn_sua.Location = new System.Drawing.Point(110, 183);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(90, 40);
            this.btn_sua.TabIndex = 26;
            this.btn_sua.Text = "sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 361);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_lưu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_searchid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_exitncc);
            this.Controls.Add(this.btn_deletencc);
            this.Controls.Add(this.btn_clearncc);
            this.Controls.Add(this.btn_addncc);
            this.Controls.Add(this.txb_ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_loaisach);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Các loại sách - phần mềm quản lý kho";
            this.Load += new System.EventHandler(this.LoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaisach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exitncc;
        private System.Windows.Forms.Button btn_deletencc;
        private System.Windows.Forms.Button btn_clearncc;
        private System.Windows.Forms.Button btn_addncc;
        private System.Windows.Forms.TextBox txb_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_loaisach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_searchid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_lưu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaisach;
    }
}