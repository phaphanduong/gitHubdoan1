namespace TuDienAnh_Viet
{
    partial class fmain
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
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.listBoxNghia = new System.Windows.Forms.ListBox();
            this.listBoxTu = new System.Windows.Forms.ListBox();
            this.btnnoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(16, 28);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(202, 26);
            this.txtTimkiem.TabIndex = 0;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(274, 28);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(106, 26);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.listBoxNghia);
            this.panel1.Controls.Add(this.listBoxTu);
            this.panel1.Location = new System.Drawing.Point(16, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 367);
            this.panel1.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(161, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 29);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(280, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 29);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(25, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 29);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // listBoxNghia
            // 
            this.listBoxNghia.FormattingEnabled = true;
            this.listBoxNghia.Location = new System.Drawing.Point(258, 72);
            this.listBoxNghia.Name = "listBoxNghia";
            this.listBoxNghia.Size = new System.Drawing.Size(258, 290);
            this.listBoxNghia.TabIndex = 1;
            // 
            // listBoxTu
            // 
            this.listBoxTu.FormattingEnabled = true;
            this.listBoxTu.Location = new System.Drawing.Point(3, 74);
            this.listBoxTu.Name = "listBoxTu";
            this.listBoxTu.Size = new System.Drawing.Size(202, 290);
            this.listBoxTu.TabIndex = 0;
            // 
            // btnnoi
            // 
            this.btnnoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnoi.Location = new System.Drawing.Point(411, 28);
            this.btnnoi.Name = "btnnoi";
            this.btnnoi.Size = new System.Drawing.Size(53, 25);
            this.btnnoi.TabIndex = 3;
            this.btnnoi.Text = "nói";
            this.btnnoi.UseVisualStyleBackColor = true;
            this.btnnoi.Click += new System.EventHandler(this.btnnoi_Click);
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 430);
            this.Controls.Add(this.btnnoi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fmain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxTu;
        private System.Windows.Forms.ListBox listBoxNghia;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnnoi;
    }
}

