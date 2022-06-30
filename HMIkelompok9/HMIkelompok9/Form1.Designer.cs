
namespace HMIkelompok9
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dispClock = new System.Windows.Forms.TextBox();
            this.dispDay = new System.Windows.Forms.TextBox();
            this.dispDate = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.editJam = new System.Windows.Forms.ComboBox();
            this.editMenit = new System.Windows.Forms.ComboBox();
            this.editHari = new System.Windows.Forms.ComboBox();
            this.editTgl = new System.Windows.Forms.ComboBox();
            this.editBln = new System.Windows.Forms.ComboBox();
            this.editTahun = new System.Windows.Forms.TextBox();
            this.editDetik = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(12, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dispClock
            // 
            this.dispClock.BackColor = System.Drawing.SystemColors.MenuText;
            this.dispClock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dispClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispClock.ForeColor = System.Drawing.Color.Yellow;
            this.dispClock.Location = new System.Drawing.Point(12, 12);
            this.dispClock.Name = "dispClock";
            this.dispClock.Size = new System.Drawing.Size(522, 109);
            this.dispClock.TabIndex = 2;
            this.dispClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dispClock.TextChanged += new System.EventHandler(this.dispClock_TextChanged);
            // 
            // dispDay
            // 
            this.dispDay.BackColor = System.Drawing.SystemColors.MenuText;
            this.dispDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dispDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispDay.ForeColor = System.Drawing.Color.Yellow;
            this.dispDay.Location = new System.Drawing.Point(12, 134);
            this.dispDay.Name = "dispDay";
            this.dispDay.Size = new System.Drawing.Size(522, 40);
            this.dispDay.TabIndex = 3;
            this.dispDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dispDay.TextChanged += new System.EventHandler(this.dispDay_TextChanged);
            // 
            // dispDate
            // 
            this.dispDate.BackColor = System.Drawing.SystemColors.MenuText;
            this.dispDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dispDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispDate.ForeColor = System.Drawing.Color.Yellow;
            this.dispDate.Location = new System.Drawing.Point(12, 187);
            this.dispDate.Name = "dispDate";
            this.dispDate.Size = new System.Drawing.Size(522, 40);
            this.dispDate.TabIndex = 4;
            this.dispDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dispDate.TextChanged += new System.EventHandler(this.dispDate_TextChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonEdit.Location = new System.Drawing.Point(464, 245);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(70, 60);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSend.Location = new System.Drawing.Point(464, 311);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(70, 61);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // editJam
            // 
            this.editJam.AllowDrop = true;
            this.editJam.DropDownHeight = 200;
            this.editJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editJam.ForeColor = System.Drawing.SystemColors.MenuText;
            this.editJam.FormattingEnabled = true;
            this.editJam.IntegralHeight = false;
            this.editJam.ItemHeight = 20;
            this.editJam.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.editJam.Location = new System.Drawing.Point(6, 42);
            this.editJam.MaxDropDownItems = 4;
            this.editJam.Name = "editJam";
            this.editJam.Size = new System.Drawing.Size(60, 28);
            this.editJam.TabIndex = 7;
            this.editJam.SelectedIndexChanged += new System.EventHandler(this.editJam_SelectedIndexChanged);
            // 
            // editMenit
            // 
            this.editMenit.AllowDrop = true;
            this.editMenit.DropDownHeight = 200;
            this.editMenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenit.FormattingEnabled = true;
            this.editMenit.IntegralHeight = false;
            this.editMenit.ItemHeight = 20;
            this.editMenit.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.editMenit.Location = new System.Drawing.Point(72, 42);
            this.editMenit.MaxDropDownItems = 4;
            this.editMenit.Name = "editMenit";
            this.editMenit.Size = new System.Drawing.Size(60, 28);
            this.editMenit.TabIndex = 8;
            this.editMenit.SelectedIndexChanged += new System.EventHandler(this.editMenit_SelectedIndexChanged);
            // 
            // editHari
            // 
            this.editHari.AllowDrop = true;
            this.editHari.DropDownHeight = 200;
            this.editHari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editHari.FormattingEnabled = true;
            this.editHari.IntegralHeight = false;
            this.editHari.ItemHeight = 20;
            this.editHari.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.editHari.Location = new System.Drawing.Point(204, 42);
            this.editHari.MaxDropDownItems = 4;
            this.editHari.Name = "editHari";
            this.editHari.Size = new System.Drawing.Size(152, 28);
            this.editHari.TabIndex = 10;
            this.editHari.SelectedIndexChanged += new System.EventHandler(this.editHari_SelectedIndexChanged);
            // 
            // editTgl
            // 
            this.editTgl.AllowDrop = true;
            this.editTgl.DropDownHeight = 200;
            this.editTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTgl.FormattingEnabled = true;
            this.editTgl.IntegralHeight = false;
            this.editTgl.ItemHeight = 20;
            this.editTgl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.editTgl.Location = new System.Drawing.Point(6, 98);
            this.editTgl.MaxDropDownItems = 4;
            this.editTgl.Name = "editTgl";
            this.editTgl.Size = new System.Drawing.Size(67, 28);
            this.editTgl.TabIndex = 11;
            this.editTgl.SelectedIndexChanged += new System.EventHandler(this.editTgl_SelectedIndexChanged);
            // 
            // editBln
            // 
            this.editBln.AllowDrop = true;
            this.editBln.DropDownHeight = 200;
            this.editBln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBln.FormattingEnabled = true;
            this.editBln.IntegralHeight = false;
            this.editBln.ItemHeight = 20;
            this.editBln.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "Desember"});
            this.editBln.Location = new System.Drawing.Point(79, 98);
            this.editBln.MaxDropDownItems = 4;
            this.editBln.Name = "editBln";
            this.editBln.Size = new System.Drawing.Size(175, 28);
            this.editBln.TabIndex = 14;
            this.editBln.SelectedIndexChanged += new System.EventHandler(this.editBln_SelectedIndexChanged);
            // 
            // editTahun
            // 
            this.editTahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTahun.Location = new System.Drawing.Point(263, 98);
            this.editTahun.Name = "editTahun";
            this.editTahun.Size = new System.Drawing.Size(96, 26);
            this.editTahun.TabIndex = 15;
            this.editTahun.TextChanged += new System.EventHandler(this.editTahun_TextChanged);
            // 
            // editDetik
            // 
            this.editDetik.AllowDrop = true;
            this.editDetik.DropDownHeight = 200;
            this.editDetik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDetik.FormattingEnabled = true;
            this.editDetik.IntegralHeight = false;
            this.editDetik.ItemHeight = 20;
            this.editDetik.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.editDetik.Location = new System.Drawing.Point(138, 42);
            this.editDetik.MaxDropDownItems = 4;
            this.editDetik.Name = "editDetik";
            this.editDetik.Size = new System.Drawing.Size(60, 28);
            this.editDetik.TabIndex = 17;
            this.editDetik.SelectedIndexChanged += new System.EventHandler(this.editDetik_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.editDetik);
            this.groupBox1.Controls.Add(this.editTahun);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.editBln);
            this.groupBox1.Controls.Add(this.editTgl);
            this.groupBox1.Controls.Add(this.editHari);
            this.groupBox1.Controls.Add(this.editMenit);
            this.groupBox1.Controls.Add(this.editJam);
            this.groupBox1.ForeColor = System.Drawing.Color.Ivory;
            this.groupBox1.Location = new System.Drawing.Point(93, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 132);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Second";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hour";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(546, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dispDate);
            this.Controls.Add(this.dispDay);
            this.Controls.Add(this.dispClock);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Jam Digital Kelompok 9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox dispClock;
        private System.Windows.Forms.TextBox dispDay;
        private System.Windows.Forms.TextBox dispDate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox editJam;
        private System.Windows.Forms.ComboBox editMenit;
        private System.Windows.Forms.ComboBox editHari;
        private System.Windows.Forms.ComboBox editTgl;
        private System.Windows.Forms.ComboBox editBln;
        private System.Windows.Forms.TextBox editTahun;
        private System.Windows.Forms.ComboBox editDetik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

