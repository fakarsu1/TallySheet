namespace TSheet.Forms
{
    partial class EmployeeAddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fc_stype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fc_phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.fc_salary = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fc_tc = new System.Windows.Forms.TextBox();
            this.fc_mgr = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.fc_addres = new System.Windows.Forms.RichTextBox();
            this.fc_fname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.fc_mail = new System.Windows.Forms.TextBox();
            this.fc_lname = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.fc_hiredate = new System.Windows.Forms.DateTimePicker();
            this.fc_title = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fc_stype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fc_phone);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.fc_salary);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.fc_tc);
            this.groupBox1.Controls.Add(this.fc_mgr);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.fc_addres);
            this.groupBox1.Controls.Add(this.fc_fname);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.fc_mail);
            this.groupBox1.Controls.Add(this.fc_lname);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.fc_hiredate);
            this.groupBox1.Controls.Add(this.fc_title);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 417);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Bilgileri";
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add.Location = new System.Drawing.Point(339, 345);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 60);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Ekle";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "* İsim :";
            // 
            // fc_stype
            // 
            this.fc_stype.FormattingEnabled = true;
            this.fc_stype.ItemHeight = 13;
            this.fc_stype.Location = new System.Drawing.Point(234, 318);
            this.fc_stype.Name = "fc_stype";
            this.fc_stype.Size = new System.Drawing.Size(185, 21);
            this.fc_stype.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ücret Tipi";
            // 
            // fc_phone
            // 
            this.fc_phone.Location = new System.Drawing.Point(6, 318);
            this.fc_phone.Name = "fc_phone";
            this.fc_phone.Size = new System.Drawing.Size(185, 20);
            this.fc_phone.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Ücret :";
            // 
            // fc_salary
            // 
            this.fc_salary.Location = new System.Drawing.Point(234, 267);
            this.fc_salary.Name = "fc_salary";
            this.fc_salary.Size = new System.Drawing.Size(185, 20);
            this.fc_salary.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "TC No :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(231, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Üst :";
            // 
            // fc_tc
            // 
            this.fc_tc.Location = new System.Drawing.Point(6, 205);
            this.fc_tc.Name = "fc_tc";
            this.fc_tc.Size = new System.Drawing.Size(185, 20);
            this.fc_tc.TabIndex = 4;
            // 
            // fc_mgr
            // 
            this.fc_mgr.FormattingEnabled = true;
            this.fc_mgr.Location = new System.Drawing.Point(234, 205);
            this.fc_mgr.Name = "fc_mgr";
            this.fc_mgr.Size = new System.Drawing.Size(185, 21);
            this.fc_mgr.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(231, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Adres :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 247);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "İş Başı Tarihi :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(231, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "E-posta :";
            // 
            // fc_addres
            // 
            this.fc_addres.Location = new System.Drawing.Point(234, 86);
            this.fc_addres.Name = "fc_addres";
            this.fc_addres.Size = new System.Drawing.Size(185, 79);
            this.fc_addres.TabIndex = 8;
            this.fc_addres.Text = "";
            // 
            // fc_fname
            // 
            this.fc_fname.Location = new System.Drawing.Point(6, 32);
            this.fc_fname.Name = "fc_fname";
            this.fc_fname.Size = new System.Drawing.Size(185, 20);
            this.fc_fname.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "* Görev :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 302);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Telefon :";
            // 
            // fc_mail
            // 
            this.fc_mail.Location = new System.Drawing.Point(234, 32);
            this.fc_mail.Name = "fc_mail";
            this.fc_mail.Size = new System.Drawing.Size(185, 20);
            this.fc_mail.TabIndex = 7;
            // 
            // fc_lname
            // 
            this.fc_lname.Location = new System.Drawing.Point(6, 86);
            this.fc_lname.Name = "fc_lname";
            this.fc_lname.Size = new System.Drawing.Size(185, 20);
            this.fc_lname.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "* Soyisim :";
            // 
            // fc_hiredate
            // 
            this.fc_hiredate.Checked = false;
            this.fc_hiredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fc_hiredate.Location = new System.Drawing.Point(6, 263);
            this.fc_hiredate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.fc_hiredate.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.fc_hiredate.Name = "fc_hiredate";
            this.fc_hiredate.Size = new System.Drawing.Size(185, 20);
            this.fc_hiredate.TabIndex = 5;
            // 
            // fc_title
            // 
            this.fc_title.FormattingEnabled = true;
            this.fc_title.Location = new System.Drawing.Point(6, 143);
            this.fc_title.Name = "fc_title";
            this.fc_title.Size = new System.Drawing.Size(185, 21);
            this.fc_title.TabIndex = 3;
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 417);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Ekle";
            this.Load += new System.EventHandler(this.EmployeeAddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fc_stype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fc_phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox fc_salary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox fc_tc;
        private System.Windows.Forms.ComboBox fc_mgr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox fc_addres;
        private System.Windows.Forms.TextBox fc_fname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox fc_mail;
        private System.Windows.Forms.TextBox fc_lname;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker fc_hiredate;
        private System.Windows.Forms.ComboBox fc_title;
    }
}