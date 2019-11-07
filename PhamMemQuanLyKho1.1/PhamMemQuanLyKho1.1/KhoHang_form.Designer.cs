namespace PhamMemQuanLyKho1._1
{
    partial class KhoHang_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoHang_form));
            this.DGVkho = new System.Windows.Forms.DataGridView();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTTP = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSLN = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVkho)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVkho
            // 
            this.DGVkho.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKho,
            this.TenKho});
            this.DGVkho.Location = new System.Drawing.Point(43, 44);
            this.DGVkho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVkho.Name = "DGVkho";
            this.DGVkho.RowHeadersWidth = 51;
            this.DGVkho.Size = new System.Drawing.Size(383, 267);
            this.DGVkho.TabIndex = 1;
            this.DGVkho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVkho_CellClick);
            // 
            // MaKho
            // 
            this.MaKho.DataPropertyName = "makho";
            this.MaKho.HeaderText = "Mã Kho";
            this.MaKho.MinimumWidth = 6;
            this.MaKho.Name = "MaKho";
            this.MaKho.Width = 70;
            // 
            // TenKho
            // 
            this.TenKho.DataPropertyName = "tenkho";
            this.TenKho.HeaderText = "Tên Kho";
            this.TenKho.MinimumWidth = 6;
            this.TenKho.Name = "TenKho";
            this.TenKho.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnthoat);
            this.panel3.Controls.Add(this.btnload);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(693, 330);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 209);
            this.panel3.TabIndex = 3;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnthoat.Location = new System.Drawing.Point(237, 117);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(107, 82);
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnload
            // 
            this.btnload.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnload.Location = new System.Drawing.Point(237, 14);
            this.btnload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(107, 96);
            this.btnload.TabIndex = 11;
            this.btnload.Text = "Reload";
            this.btnload.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Location = new System.Drawing.Point(125, 117);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 82);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(125, 65);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 44);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(11, 117);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 82);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(125, 14);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 44);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(11, 14);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 96);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.BackColor = System.Drawing.Color.Transparent;
            this.pnlcontrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlcontrol.BackgroundImage")));
            this.pnlcontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlcontrol.Controls.Add(this.txtTP);
            this.pnlcontrol.Controls.Add(this.label1);
            this.pnlcontrol.Controls.Add(this.txtTTP);
            this.pnlcontrol.Controls.Add(this.txtMP);
            this.pnlcontrol.Controls.Add(this.txtTT);
            this.pnlcontrol.Controls.Add(this.label2);
            this.pnlcontrol.Controls.Add(this.lbSLN);
            this.pnlcontrol.Controls.Add(this.lbMaPhong);
            this.pnlcontrol.Location = new System.Drawing.Point(693, 15);
            this.pnlcontrol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(357, 306);
            this.pnlcontrol.TabIndex = 4;
            // 
            // txtTP
            // 
            this.txtTP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTP.Location = new System.Drawing.Point(199, 53);
            this.txtTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(145, 29);
            this.txtTP.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Phòng : ";
            // 
            // txtTTP
            // 
            this.txtTTP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTP.Location = new System.Drawing.Point(199, 126);
            this.txtTTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTTP.Multiline = true;
            this.txtTTP.Name = "txtTTP";
            this.txtTTP.Size = new System.Drawing.Size(145, 86);
            this.txtTTP.TabIndex = 13;
            // 
            // txtMP
            // 
            this.txtMP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP.Location = new System.Drawing.Point(199, 16);
            this.txtMP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(145, 29);
            this.txtMP.TabIndex = 12;
            // 
            // txtTT
            // 
            this.txtTT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.Location = new System.Drawing.Point(199, 89);
            this.txtTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(145, 29);
            this.txtTT.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thông Tin Phòng :";
            // 
            // lbSLN
            // 
            this.lbSLN.AutoSize = true;
            this.lbSLN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLN.Location = new System.Drawing.Point(25, 98);
            this.lbSLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSLN.Name = "lbSLN";
            this.lbSLN.Size = new System.Drawing.Size(113, 22);
            this.lbSLN.TabIndex = 9;
            this.lbSLN.Text = "Trạng Thái :";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Location = new System.Drawing.Point(25, 22);
            this.lbMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(110, 22);
            this.lbMaPhong.TabIndex = 8;
            this.lbMaPhong.Text = "Mã Phòng : ";
            // 
            // KhoHang_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhamMemQuanLyKho1._1.Properties.Resources.background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlcontrol);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DGVkho);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KhoHang_form";
            this.Text = "KhoHang_form";
            this.Load += new System.EventHandler(this.KhoHang_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVkho)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnlcontrol.ResumeLayout(false);
            this.pnlcontrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVkho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlcontrol;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTTP;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSLN;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKho;
    }
}