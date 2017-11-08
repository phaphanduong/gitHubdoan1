namespace Tudien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbtratu = new System.Windows.Forms.TextBox();
            this.btntratu = new System.Windows.Forms.Button();
            this.rdanhviet = new System.Windows.Forms.RadioButton();
            this.rdvietanh = new System.Windows.Forms.RadioButton();
            this.btnthemtuvung = new System.Windows.Forms.Button();
            this.btnnghe = new System.Windows.Forms.Button();
            this.dgvTD = new System.Windows.Forms.DataGridView();
            this.Tu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTD)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuExit.Text = "Thoát";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(100, 20);
            this.toolStripMenuItem6.Text = "Quản lý từ điển";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // tbtratu
            // 
            this.tbtratu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtratu.Location = new System.Drawing.Point(12, 39);
            this.tbtratu.Name = "tbtratu";
            this.tbtratu.Size = new System.Drawing.Size(238, 23);
            this.tbtratu.TabIndex = 15;
            // 
            // btntratu
            // 
            this.btntratu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btntratu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntratu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btntratu.Location = new System.Drawing.Point(281, 39);
            this.btntratu.Name = "btntratu";
            this.btntratu.Size = new System.Drawing.Size(73, 32);
            this.btntratu.TabIndex = 19;
            this.btntratu.Text = "Tra từ";
            this.btntratu.UseVisualStyleBackColor = false;
            this.btntratu.Click += new System.EventHandler(this.btntratu_Click);
            // 
            // rdanhviet
            // 
            this.rdanhviet.AutoSize = true;
            this.rdanhviet.Checked = true;
            this.rdanhviet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdanhviet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdanhviet.Location = new System.Drawing.Point(29, 78);
            this.rdanhviet.Name = "rdanhviet";
            this.rdanhviet.Size = new System.Drawing.Size(76, 19);
            this.rdanhviet.TabIndex = 22;
            this.rdanhviet.TabStop = true;
            this.rdanhviet.Text = "Anh - Việt";
            this.rdanhviet.UseVisualStyleBackColor = true;
            this.rdanhviet.Click += new System.EventHandler(this.rdanhviet_Click);
            // 
            // rdvietanh
            // 
            this.rdvietanh.AutoSize = true;
            this.rdvietanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdvietanh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdvietanh.Location = new System.Drawing.Point(130, 78);
            this.rdvietanh.Name = "rdvietanh";
            this.rdvietanh.Size = new System.Drawing.Size(76, 19);
            this.rdvietanh.TabIndex = 23;
            this.rdvietanh.Text = "Việt - Anh";
            this.rdvietanh.UseVisualStyleBackColor = true;
            this.rdvietanh.Click += new System.EventHandler(this.rdvietanh_Click);
            // 
            // btnthemtuvung
            // 
            this.btnthemtuvung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnthemtuvung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemtuvung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnthemtuvung.Location = new System.Drawing.Point(475, 39);
            this.btnthemtuvung.Name = "btnthemtuvung";
            this.btnthemtuvung.Size = new System.Drawing.Size(124, 32);
            this.btnthemtuvung.TabIndex = 26;
            this.btnthemtuvung.Text = "Thêm từ vựng";
            this.btnthemtuvung.UseVisualStyleBackColor = false;
            this.btnthemtuvung.Click += new System.EventHandler(this.btnthemtuvung_Click);
            // 
            // btnnghe
            // 
            this.btnnghe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnnghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnghe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnnghe.Location = new System.Drawing.Point(377, 39);
            this.btnnghe.Name = "btnnghe";
            this.btnnghe.Size = new System.Drawing.Size(75, 32);
            this.btnnghe.TabIndex = 32;
            this.btnnghe.Text = "Nghe";
            this.btnnghe.UseVisualStyleBackColor = false;
            this.btnnghe.Click += new System.EventHandler(this.btnnghe_Click);
            // 
            // dgvTD
            // 
            this.dgvTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tu});
            this.dgvTD.Location = new System.Drawing.Point(13, 132);
            this.dgvTD.Name = "dgvTD";
            this.dgvTD.Size = new System.Drawing.Size(237, 228);
            this.dgvTD.TabIndex = 33;
            this.dgvTD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTD_CellClick);
            // 
            // Tu
            // 
            this.Tu.DataPropertyName = "Tu";
            this.Tu.FillWeight = 200F;
            this.Tu.HeaderText = "Từ";
            this.Tu.Name = "Tu";
            this.Tu.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nghĩa của từ";
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(618, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTD);
            this.Controls.Add(this.btnnghe);
            this.Controls.Add(this.btnthemtuvung);
            this.Controls.Add(this.rdvietanh);
            this.Controls.Add(this.rdanhviet);
            this.Controls.Add(this.btntratu);
            this.Controls.Add(this.tbtratu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fmain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.TextBox tbtratu;
        private System.Windows.Forms.Button btntratu;
        private System.Windows.Forms.RadioButton rdanhviet;
        private System.Windows.Forms.RadioButton rdvietanh;
        private System.Windows.Forms.Button btnthemtuvung;
        private System.Windows.Forms.Button btnnghe;
        private System.Windows.Forms.DataGridView dgvTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tu;
        private System.Windows.Forms.Label label1;
    }
}

