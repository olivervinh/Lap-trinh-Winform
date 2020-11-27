namespace listview
{
    partial class frmQLNS
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
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFrefres = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvNS = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.ckHoatDong = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản: ";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(176, 45);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(198, 22);
            this.txtTK.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(176, 99);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(198, 22);
            this.txtTen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên: ";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(178, 198);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 6;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(313, 198);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 7;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(176, 153);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(198, 22);
            this.dtpNgaySinh.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giới tính: ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::listview.Properties.Resources.cong;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(499, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 67);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::listview.Properties.Resources.sua;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(499, 85);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 62);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::listview.Properties.Resources.images__1_;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(499, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 66);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFrefres
            // 
            this.btnFrefres.BackgroundImage = global::listview.Properties.Resources.images__2_;
            this.btnFrefres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrefres.Location = new System.Drawing.Point(499, 226);
            this.btnFrefres.Name = "btnFrefres";
            this.btnFrefres.Size = new System.Drawing.Size(75, 60);
            this.btnFrefres.TabIndex = 15;
            this.btnFrefres.UseVisualStyleBackColor = true;
            this.btnFrefres.Click += new System.EventHandler(this.btnFrefres_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvNS);
            this.groupBox1.Location = new System.Drawing.Point(57, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 222);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân sự";
            // 
            // lvNS
            // 
            this.lvNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNS.HideSelection = false;
            this.lvNS.Location = new System.Drawing.Point(3, 18);
            this.lvNS.Name = "lvNS";
            this.lvNS.Size = new System.Drawing.Size(543, 201);
            this.lvNS.TabIndex = 0;
            this.lvNS.UseCompatibleStateImageBehavior = false;
            this.lvNS.SelectedIndexChanged += new System.EventHandler(this.lvNS_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Trạng thái: ";
            // 
            // ckHoatDong
            // 
            this.ckHoatDong.AutoSize = true;
            this.ckHoatDong.Location = new System.Drawing.Point(181, 248);
            this.ckHoatDong.Name = "ckHoatDong";
            this.ckHoatDong.Size = new System.Drawing.Size(96, 21);
            this.ckHoatDong.TabIndex = 17;
            this.ckHoatDong.Text = "Hoạt động";
            this.ckHoatDong.UseVisualStyleBackColor = true;
            // 
            // frmQLNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckHoatDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFrefres);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label1);
            this.Name = "frmQLNS";
            this.Text = "Quản lí nhân sự";
            this.Load += new System.EventHandler(this.frmQLNS_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFrefres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvNS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckHoatDong;
    }
}

