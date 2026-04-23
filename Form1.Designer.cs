namespace StudentGrading
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
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cboYear = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFirstname = new System.Windows.Forms.TextBox();
			this.cboProgram = new System.Windows.Forms.ComboBox();
			this.MidtermTab = new System.Windows.Forms.TabControl();
			this.midtermGradingTab = new System.Windows.Forms.TabPage();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.txtMidtermGrade = new System.Windows.Forms.TextBox();
			this.txtMLabGrade = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.txtMQ3Ave = new System.Windows.Forms.TextBox();
			this.txtMQ4Ave = new System.Windows.Forms.TextBox();
			this.txtMEAve = new System.Windows.Forms.TextBox();
			this.txtMQ2Ave = new System.Windows.Forms.TextBox();
			this.txtMQ4 = new System.Windows.Forms.TextBox();
			this.txtMQ3 = new System.Windows.Forms.TextBox();
			this.txtME = new System.Windows.Forms.TextBox();
			this.txtMQ1Ave = new System.Windows.Forms.TextBox();
			this.txtMQ2 = new System.Windows.Forms.TextBox();
			this.cboMItemsQ1 = new System.Windows.Forms.ComboBox();
			this.cboMItemsQ2 = new System.Windows.Forms.ComboBox();
			this.cboMItemsQ3 = new System.Windows.Forms.ComboBox();
			this.cboMItemsQ4 = new System.Windows.Forms.ComboBox();
			this.cboMItemsME = new System.Windows.Forms.ComboBox();
			this.txtMQ1 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.txtMA = new System.Windows.Forms.TextBox();
			this.txtMCP = new System.Windows.Forms.TextBox();
			this.finalGradingTab = new System.Windows.Forms.TabPage();
			this.txtFinalGrade = new System.Windows.Forms.TextBox();
			this.txtFQ1 = new System.Windows.Forms.TextBox();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.txtFLabGrade = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtFQ3Ave = new System.Windows.Forms.TextBox();
			this.txtFQ4Ave = new System.Windows.Forms.TextBox();
			this.txtFEAve = new System.Windows.Forms.TextBox();
			this.txtFQ2Ave = new System.Windows.Forms.TextBox();
			this.txtFQ4 = new System.Windows.Forms.TextBox();
			this.txtFQ3 = new System.Windows.Forms.TextBox();
			this.txtFE = new System.Windows.Forms.TextBox();
			this.txtFQ1Ave = new System.Windows.Forms.TextBox();
			this.txtFQ2 = new System.Windows.Forms.TextBox();
			this.cboFItemsQ1 = new System.Windows.Forms.ComboBox();
			this.cboFItemsQ2 = new System.Windows.Forms.ComboBox();
			this.cboFItemsQ3 = new System.Windows.Forms.ComboBox();
			this.cboFItemsQ4 = new System.Windows.Forms.ComboBox();
			this.cboFItemsFE = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtFA = new System.Windows.Forms.TextBox();
			this.txtFCP = new System.Windows.Forms.TextBox();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtSN = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnRecompute = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.txtFinalAve = new System.Windows.Forms.TextBox();
			this.txtSA = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.MidtermTab.SuspendLayout();
			this.midtermGradingTab.SuspendLayout();
			this.finalGradingTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvStudents
			// 
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(21, 171);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.RowHeadersWidth = 51;
			this.dgvStudents.RowTemplate.Height = 24;
			this.dgvStudents.Size = new System.Drawing.Size(879, 664);
			this.dgvStudents.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(800, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(285, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "PLMUN GRADING SYSTEM";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Student Number:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Surname:";
			// 
			// cboYear
			// 
			this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboYear.FormattingEnabled = true;
			this.cboYear.Location = new System.Drawing.Point(444, 65);
			this.cboYear.Name = "cboYear";
			this.cboYear.Size = new System.Drawing.Size(158, 28);
			this.cboYear.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(620, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Program:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(331, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Firstname:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(331, 75);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "Year Level:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(620, 121);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 20);
			this.label7.TabIndex = 10;
			this.label7.Text = "Subject:";
			// 
			// txtFirstname
			// 
			this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstname.Location = new System.Drawing.Point(444, 113);
			this.txtFirstname.Name = "txtFirstname";
			this.txtFirstname.Size = new System.Drawing.Size(158, 28);
			this.txtFirstname.TabIndex = 12;
			// 
			// cboProgram
			// 
			this.cboProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboProgram.FormattingEnabled = true;
			this.cboProgram.Location = new System.Drawing.Point(704, 65);
			this.cboProgram.Name = "cboProgram";
			this.cboProgram.Size = new System.Drawing.Size(158, 28);
			this.cboProgram.TabIndex = 13;
			// 
			// MidtermTab
			// 
			this.MidtermTab.Controls.Add(this.midtermGradingTab);
			this.MidtermTab.Controls.Add(this.finalGradingTab);
			this.MidtermTab.Location = new System.Drawing.Point(906, 171);
			this.MidtermTab.Name = "MidtermTab";
			this.MidtermTab.SelectedIndex = 0;
			this.MidtermTab.Size = new System.Drawing.Size(633, 465);
			this.MidtermTab.TabIndex = 14;
			// 
			// midtermGradingTab
			// 
			this.midtermGradingTab.Controls.Add(this.linkLabel1);
			this.midtermGradingTab.Controls.Add(this.txtMidtermGrade);
			this.midtermGradingTab.Controls.Add(this.txtMLabGrade);
			this.midtermGradingTab.Controls.Add(this.label20);
			this.midtermGradingTab.Controls.Add(this.label21);
			this.midtermGradingTab.Controls.Add(this.txtMQ3Ave);
			this.midtermGradingTab.Controls.Add(this.txtMQ4Ave);
			this.midtermGradingTab.Controls.Add(this.txtMEAve);
			this.midtermGradingTab.Controls.Add(this.txtMQ2Ave);
			this.midtermGradingTab.Controls.Add(this.txtMQ4);
			this.midtermGradingTab.Controls.Add(this.txtMQ3);
			this.midtermGradingTab.Controls.Add(this.txtME);
			this.midtermGradingTab.Controls.Add(this.txtMQ1Ave);
			this.midtermGradingTab.Controls.Add(this.txtMQ2);
			this.midtermGradingTab.Controls.Add(this.cboMItemsQ1);
			this.midtermGradingTab.Controls.Add(this.cboMItemsQ2);
			this.midtermGradingTab.Controls.Add(this.cboMItemsQ3);
			this.midtermGradingTab.Controls.Add(this.cboMItemsQ4);
			this.midtermGradingTab.Controls.Add(this.cboMItemsME);
			this.midtermGradingTab.Controls.Add(this.txtMQ1);
			this.midtermGradingTab.Controls.Add(this.label22);
			this.midtermGradingTab.Controls.Add(this.label23);
			this.midtermGradingTab.Controls.Add(this.label24);
			this.midtermGradingTab.Controls.Add(this.label25);
			this.midtermGradingTab.Controls.Add(this.label26);
			this.midtermGradingTab.Controls.Add(this.label27);
			this.midtermGradingTab.Controls.Add(this.label28);
			this.midtermGradingTab.Controls.Add(this.txtMA);
			this.midtermGradingTab.Controls.Add(this.txtMCP);
			this.midtermGradingTab.Location = new System.Drawing.Point(4, 25);
			this.midtermGradingTab.Name = "midtermGradingTab";
			this.midtermGradingTab.Padding = new System.Windows.Forms.Padding(3);
			this.midtermGradingTab.Size = new System.Drawing.Size(625, 436);
			this.midtermGradingTab.TabIndex = 0;
			this.midtermGradingTab.Text = "MIDTERM GRADING";
			this.midtermGradingTab.UseVisualStyleBackColor = true;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(546, 18);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(54, 16);
			this.linkLabel1.TabIndex = 69;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Refresh\r\n";
			// 
			// txtMidtermGrade
			// 
			this.txtMidtermGrade.Enabled = false;
			this.txtMidtermGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMidtermGrade.Location = new System.Drawing.Point(217, 381);
			this.txtMidtermGrade.Name = "txtMidtermGrade";
			this.txtMidtermGrade.Size = new System.Drawing.Size(383, 28);
			this.txtMidtermGrade.TabIndex = 68;
			// 
			// txtMLabGrade
			// 
			this.txtMLabGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMLabGrade.Location = new System.Drawing.Point(217, 333);
			this.txtMLabGrade.Name = "txtMLabGrade";
			this.txtMLabGrade.Size = new System.Drawing.Size(383, 28);
			this.txtMLabGrade.TabIndex = 67;
			this.txtMLabGrade.TextChanged += new System.EventHandler(this.txtMLabGrade_TextChanged);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(18, 389);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(157, 20);
			this.label20.TabIndex = 66;
			this.label20.Text = "MIDTERM GRADE:";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(18, 341);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(193, 20);
			this.label21.TabIndex = 65;
			this.label21.Text = "LABORATORY GRADE:\r\n";
			// 
			// txtMQ3Ave
			// 
			this.txtMQ3Ave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMQ3Ave.Location = new System.Drawing.Point(454, 217);
			this.txtMQ3Ave.Name = "txtMQ3Ave";
			this.txtMQ3Ave.ReadOnly = true;
			this.txtMQ3Ave.Size = new System.Drawing.Size(146, 28);
			this.txtMQ3Ave.TabIndex = 64;
			// 
			// txtMQ4Ave
			// 
			this.txtMQ4Ave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMQ4Ave.Location = new System.Drawing.Point(454, 253);
			this.txtMQ4Ave.Name = "txtMQ4Ave";
			this.txtMQ4Ave.ReadOnly = true;
			this.txtMQ4Ave.Size = new System.Drawing.Size(146, 28);
			this.txtMQ4Ave.TabIndex = 63;
			// 
			// txtMEAve
			// 
			this.txtMEAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMEAve.Location = new System.Drawing.Point(454, 290);
			this.txtMEAve.Name = "txtMEAve";
			this.txtMEAve.ReadOnly = true;
			this.txtMEAve.Size = new System.Drawing.Size(146, 28);
			this.txtMEAve.TabIndex = 62;
			// 
			// txtMQ2Ave
			// 
			this.txtMQ2Ave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMQ2Ave.Location = new System.Drawing.Point(454, 177);
			this.txtMQ2Ave.Name = "txtMQ2Ave";
			this.txtMQ2Ave.ReadOnly = true;
			this.txtMQ2Ave.Size = new System.Drawing.Size(146, 28);
			this.txtMQ2Ave.TabIndex = 61;
			// 
			// txtMQ4
			// 
			this.txtMQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMQ4.Location = new System.Drawing.Point(302, 253);
			this.txtMQ4.Name = "txtMQ4";
			this.txtMQ4.Size = new System.Drawing.Size(146, 28);
			this.txtMQ4.TabIndex = 60;
			this.txtMQ4.TextChanged += new System.EventHandler(this.txtMQ4_TextChanged);
			// 
			// txtMQ3
			// 
			this.txtMQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMQ3.Location = new System.Drawing.Point(302, 217);
			this.txtMQ3.Name = "txtMQ3";
			this.txtMQ3.Size = new System.Drawing.Size(146, 28);
			this.txtMQ3.TabIndex = 59;
			this.txtMQ3.TextChanged += new System.EventHandler(this.txtMQ3_TextChanged);
			// 
			// txtME
			// 
			this.txtME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtME.Location = new System.Drawing.Point(302, 290);
			this.txtME.Name = "txtME";
			this.txtME.Size = new System.Drawing.Size(146, 28);
			this.txtME.TabIndex = 58;
			this.txtME.TextChanged += new System.EventHandler(this.txtMe_TextChanged);
			// 
			// txtMQ1Ave
			// 
			this.txtMQ1Ave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMQ1Ave.Location = new System.Drawing.Point(454, 143);
			this.txtMQ1Ave.Name = "txtMQ1Ave";
			this.txtMQ1Ave.ReadOnly = true;
			this.txtMQ1Ave.Size = new System.Drawing.Size(146, 28);
			this.txtMQ1Ave.TabIndex = 57;
			// 
			// txtMQ2
			// 
			this.txtMQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMQ2.Location = new System.Drawing.Point(302, 177);
			this.txtMQ2.Name = "txtMQ2";
			this.txtMQ2.Size = new System.Drawing.Size(146, 28);
			this.txtMQ2.TabIndex = 56;
			this.txtMQ2.TextChanged += new System.EventHandler(this.txtMQ2_TextChanged);
			// 
			// cboMItemsQ1
			// 
			this.cboMItemsQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMItemsQ1.FormattingEnabled = true;
			this.cboMItemsQ1.Items.AddRange(new object[] {
            "-set number of items",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cboMItemsQ1.Location = new System.Drawing.Point(150, 143);
			this.cboMItemsQ1.Name = "cboMItemsQ1";
			this.cboMItemsQ1.Size = new System.Drawing.Size(146, 28);
			this.cboMItemsQ1.TabIndex = 55;
			// 
			// cboMItemsQ2
			// 
			this.cboMItemsQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMItemsQ2.FormattingEnabled = true;
			this.cboMItemsQ2.Items.AddRange(new object[] {
            "-set number of items",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cboMItemsQ2.Location = new System.Drawing.Point(150, 177);
			this.cboMItemsQ2.Name = "cboMItemsQ2";
			this.cboMItemsQ2.Size = new System.Drawing.Size(146, 28);
			this.cboMItemsQ2.TabIndex = 54;
			// 
			// cboMItemsQ3
			// 
			this.cboMItemsQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMItemsQ3.FormattingEnabled = true;
			this.cboMItemsQ3.Items.AddRange(new object[] {
            "-set number of items",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cboMItemsQ3.Location = new System.Drawing.Point(150, 217);
			this.cboMItemsQ3.Name = "cboMItemsQ3";
			this.cboMItemsQ3.Size = new System.Drawing.Size(146, 28);
			this.cboMItemsQ3.TabIndex = 53;
			// 
			// cboMItemsQ4
			// 
			this.cboMItemsQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMItemsQ4.FormattingEnabled = true;
			this.cboMItemsQ4.Items.AddRange(new object[] {
            "-set number of items",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cboMItemsQ4.Location = new System.Drawing.Point(150, 253);
			this.cboMItemsQ4.Name = "cboMItemsQ4";
			this.cboMItemsQ4.Size = new System.Drawing.Size(146, 28);
			this.cboMItemsQ4.TabIndex = 52;
			// 
			// cboMItemsME
			// 
			this.cboMItemsME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMItemsME.FormattingEnabled = true;
			this.cboMItemsME.Items.AddRange(new object[] {
            "-set number of items",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cboMItemsME.Location = new System.Drawing.Point(150, 290);
			this.cboMItemsME.Name = "cboMItemsME";
			this.cboMItemsME.Size = new System.Drawing.Size(146, 28);
			this.cboMItemsME.TabIndex = 43;
			// 
			// txtMQ1
			// 
			this.txtMQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMQ1.Location = new System.Drawing.Point(302, 143);
			this.txtMQ1.Name = "txtMQ1";
			this.txtMQ1.Size = new System.Drawing.Size(146, 28);
			this.txtMQ1.TabIndex = 51;
			this.txtMQ1.TextChanged += new System.EventHandler(this.txtMQ1_TextChanged);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(18, 298);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(122, 20);
			this.label22.TabIndex = 50;
			this.label22.Text = "Midterm Exam:";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(18, 261);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(63, 20);
			this.label23.TabIndex = 49;
			this.label23.Text = "Quiz 4:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(18, 225);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(63, 20);
			this.label24.TabIndex = 48;
			this.label24.Text = "Quiz 3:";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(18, 185);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(63, 20);
			this.label25.TabIndex = 47;
			this.label25.Text = "Quiz 2:";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(18, 151);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(63, 20);
			this.label26.TabIndex = 46;
			this.label26.Text = "Quiz 1:";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(18, 102);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(98, 20);
			this.label27.TabIndex = 45;
			this.label27.Text = "Attendance:";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(18, 55);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(155, 20);
			this.label28.TabIndex = 42;
			this.label28.Text = "Class Participation:";
			// 
			// txtMA
			// 
			this.txtMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMA.Location = new System.Drawing.Point(194, 94);
			this.txtMA.Name = "txtMA";
			this.txtMA.Size = new System.Drawing.Size(406, 28);
			this.txtMA.TabIndex = 44;
			this.txtMA.TextChanged += new System.EventHandler(this.txtMA_TextChanged);
			// 
			// txtMCP
			// 
			this.txtMCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMCP.Location = new System.Drawing.Point(194, 47);
			this.txtMCP.Name = "txtMCP";
			this.txtMCP.Size = new System.Drawing.Size(406, 28);
			this.txtMCP.TabIndex = 41;
			this.txtMCP.TextChanged += new System.EventHandler(this.txtMCP_TextChanged);
			// 
			// finalGradingTab
			// 
			this.finalGradingTab.Controls.Add(this.txtFinalGrade);
			this.finalGradingTab.Controls.Add(this.txtFQ1);
			this.finalGradingTab.Controls.Add(this.linkLabel2);
			this.finalGradingTab.Controls.Add(this.txtFLabGrade);
			this.finalGradingTab.Controls.Add(this.label16);
			this.finalGradingTab.Controls.Add(this.label15);
			this.finalGradingTab.Controls.Add(this.txtFQ3Ave);
			this.finalGradingTab.Controls.Add(this.txtFQ4Ave);
			this.finalGradingTab.Controls.Add(this.txtFEAve);
			this.finalGradingTab.Controls.Add(this.txtFQ2Ave);
			this.finalGradingTab.Controls.Add(this.txtFQ4);
			this.finalGradingTab.Controls.Add(this.txtFQ3);
			this.finalGradingTab.Controls.Add(this.txtFE);
			this.finalGradingTab.Controls.Add(this.txtFQ1Ave);
			this.finalGradingTab.Controls.Add(this.txtFQ2);
			this.finalGradingTab.Controls.Add(this.cboFItemsQ1);
			this.finalGradingTab.Controls.Add(this.cboFItemsQ2);
			this.finalGradingTab.Controls.Add(this.cboFItemsQ3);
			this.finalGradingTab.Controls.Add(this.cboFItemsQ4);
			this.finalGradingTab.Controls.Add(this.cboFItemsFE);
			this.finalGradingTab.Controls.Add(this.label14);
			this.finalGradingTab.Controls.Add(this.label13);
			this.finalGradingTab.Controls.Add(this.label12);
			this.finalGradingTab.Controls.Add(this.label11);
			this.finalGradingTab.Controls.Add(this.label10);
			this.finalGradingTab.Controls.Add(this.label9);
			this.finalGradingTab.Controls.Add(this.label8);
			this.finalGradingTab.Controls.Add(this.txtFA);
			this.finalGradingTab.Controls.Add(this.txtFCP);
			this.finalGradingTab.Location = new System.Drawing.Point(4, 25);
			this.finalGradingTab.Name = "finalGradingTab";
			this.finalGradingTab.Padding = new System.Windows.Forms.Padding(3);
			this.finalGradingTab.Size = new System.Drawing.Size(625, 436);
			this.finalGradingTab.TabIndex = 1;
			this.finalGradingTab.Text = "FINAL GRADING";
			this.finalGradingTab.UseVisualStyleBackColor = true;
			this.finalGradingTab.Click += new System.EventHandler(this.finalGradingTab_Click);
			// 
			// txtFinalGrade
			// 
			this.txtFinalGrade.Enabled = false;
			this.txtFinalGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFinalGrade.Location = new System.Drawing.Point(230, 380);
			this.txtFinalGrade.Name = "txtFinalGrade";
			this.txtFinalGrade.Size = new System.Drawing.Size(356, 28);
			this.txtFinalGrade.TabIndex = 72;
			// 
			// txtFQ1
			// 
			this.txtFQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFQ1.Location = new System.Drawing.Point(289, 140);
			this.txtFQ1.Name = "txtFQ1";
			this.txtFQ1.Size = new System.Drawing.Size(146, 28);
			this.txtFQ1.TabIndex = 71;
			this.txtFQ1.TextChanged += new System.EventHandler(this.txtFQ1_TextChanged);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(519, 15);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(54, 16);
			this.linkLabel2.TabIndex = 70;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Refresh\r\n";
			// 
			// txtFLabGrade
			// 
			this.txtFLabGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFLabGrade.Location = new System.Drawing.Point(230, 332);
			this.txtFLabGrade.Name = "txtFLabGrade";
			this.txtFLabGrade.Size = new System.Drawing.Size(356, 28);
			this.txtFLabGrade.TabIndex = 39;
			this.txtFLabGrade.TextChanged += new System.EventHandler(this.txtFLabGrade_TextChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(18, 388);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(126, 20);
			this.label16.TabIndex = 38;
			this.label16.Text = "FINAL GRADE:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(18, 340);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(193, 20);
			this.label15.TabIndex = 37;
			this.label15.Text = "LABORATORY GRADE:\r\n";
			// 
			// txtFQ3Ave
			// 
			this.txtFQ3Ave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFQ3Ave.Location = new System.Drawing.Point(441, 216);
			this.txtFQ3Ave.Name = "txtFQ3Ave";
			this.txtFQ3Ave.Size = new System.Drawing.Size(146, 28);
			this.txtFQ3Ave.TabIndex = 36;
			// 
			// txtFQ4Ave
			// 
			this.txtFQ4Ave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFQ4Ave.Location = new System.Drawing.Point(441, 252);
			this.txtFQ4Ave.Name = "txtFQ4Ave";
			this.txtFQ4Ave.Size = new System.Drawing.Size(146, 28);
			this.txtFQ4Ave.TabIndex = 35;
			// 
			// txtFEAve
			// 
			this.txtFEAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFEAve.Location = new System.Drawing.Point(441, 289);
			this.txtFEAve.Name = "txtFEAve";
			this.txtFEAve.Size = new System.Drawing.Size(146, 28);
			this.txtFEAve.TabIndex = 34;
			// 
			// txtFQ2Ave
			// 
			this.txtFQ2Ave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFQ2Ave.Location = new System.Drawing.Point(441, 176);
			this.txtFQ2Ave.Name = "txtFQ2Ave";
			this.txtFQ2Ave.Size = new System.Drawing.Size(146, 28);
			this.txtFQ2Ave.TabIndex = 33;
			// 
			// txtFQ4
			// 
			this.txtFQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFQ4.Location = new System.Drawing.Point(289, 252);
			this.txtFQ4.Name = "txtFQ4";
			this.txtFQ4.Size = new System.Drawing.Size(146, 28);
			this.txtFQ4.TabIndex = 32;
			this.txtFQ4.TextChanged += new System.EventHandler(this.txtFQ4_TextChanged);
			// 
			// txtFQ3
			// 
			this.txtFQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFQ3.Location = new System.Drawing.Point(289, 216);
			this.txtFQ3.Name = "txtFQ3";
			this.txtFQ3.Size = new System.Drawing.Size(146, 28);
			this.txtFQ3.TabIndex = 31;
			this.txtFQ3.TextChanged += new System.EventHandler(this.txtFQ3_TextChanged);
			// 
			// txtFE
			// 
			this.txtFE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFE.Location = new System.Drawing.Point(289, 289);
			this.txtFE.Name = "txtFE";
			this.txtFE.Size = new System.Drawing.Size(146, 28);
			this.txtFE.TabIndex = 30;
			this.txtFE.TextChanged += new System.EventHandler(this.txtFE_TextChanged);
			// 
			// txtFQ1Ave
			// 
			this.txtFQ1Ave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFQ1Ave.Location = new System.Drawing.Point(441, 142);
			this.txtFQ1Ave.Name = "txtFQ1Ave";
			this.txtFQ1Ave.Size = new System.Drawing.Size(146, 28);
			this.txtFQ1Ave.TabIndex = 29;
			// 
			// txtFQ2
			// 
			this.txtFQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFQ2.Location = new System.Drawing.Point(289, 176);
			this.txtFQ2.Name = "txtFQ2";
			this.txtFQ2.Size = new System.Drawing.Size(146, 28);
			this.txtFQ2.TabIndex = 28;
			this.txtFQ2.TextChanged += new System.EventHandler(this.txtFQ2_TextChanged);
			// 
			// cboFItemsQ1
			// 
			this.cboFItemsQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboFItemsQ1.FormattingEnabled = true;
			this.cboFItemsQ1.Items.AddRange(new object[] {
            "-set number of items",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cboFItemsQ1.Location = new System.Drawing.Point(137, 142);
			this.cboFItemsQ1.Name = "cboFItemsQ1";
			this.cboFItemsQ1.Size = new System.Drawing.Size(146, 28);
			this.cboFItemsQ1.TabIndex = 27;
			// 
			// cboFItemsQ2
			// 
			this.cboFItemsQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboFItemsQ2.FormattingEnabled = true;
			this.cboFItemsQ2.Items.AddRange(new object[] {
            "-set number of items",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cboFItemsQ2.Location = new System.Drawing.Point(137, 176);
			this.cboFItemsQ2.Name = "cboFItemsQ2";
			this.cboFItemsQ2.Size = new System.Drawing.Size(146, 28);
			this.cboFItemsQ2.TabIndex = 26;
			// 
			// cboFItemsQ3
			// 
			this.cboFItemsQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboFItemsQ3.FormattingEnabled = true;
			this.cboFItemsQ3.Items.AddRange(new object[] {
            "-set number of items",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cboFItemsQ3.Location = new System.Drawing.Point(137, 216);
			this.cboFItemsQ3.Name = "cboFItemsQ3";
			this.cboFItemsQ3.Size = new System.Drawing.Size(146, 28);
			this.cboFItemsQ3.TabIndex = 25;
			// 
			// cboFItemsQ4
			// 
			this.cboFItemsQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboFItemsQ4.FormattingEnabled = true;
			this.cboFItemsQ4.Items.AddRange(new object[] {
            "-set number of items",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cboFItemsQ4.Location = new System.Drawing.Point(137, 252);
			this.cboFItemsQ4.Name = "cboFItemsQ4";
			this.cboFItemsQ4.Size = new System.Drawing.Size(146, 28);
			this.cboFItemsQ4.TabIndex = 24;
			// 
			// cboFItemsFE
			// 
			this.cboFItemsFE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboFItemsFE.FormattingEnabled = true;
			this.cboFItemsFE.Items.AddRange(new object[] {
            "-set number of items",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cboFItemsFE.Location = new System.Drawing.Point(137, 289);
			this.cboFItemsFE.Name = "cboFItemsFE";
			this.cboFItemsFE.Size = new System.Drawing.Size(146, 28);
			this.cboFItemsFE.TabIndex = 15;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(18, 297);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(97, 20);
			this.label14.TabIndex = 22;
			this.label14.Text = "Final Exam:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(18, 260);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(63, 20);
			this.label13.TabIndex = 21;
			this.label13.Text = "Quiz 4:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(18, 224);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(63, 20);
			this.label12.TabIndex = 20;
			this.label12.Text = "Quiz 3:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(18, 184);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(63, 20);
			this.label11.TabIndex = 19;
			this.label11.Text = "Quiz 2:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(18, 150);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 20);
			this.label10.TabIndex = 18;
			this.label10.Text = "Quiz 1:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(18, 101);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(98, 20);
			this.label9.TabIndex = 17;
			this.label9.Text = "Attendance:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(18, 54);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(155, 20);
			this.label8.TabIndex = 15;
			this.label8.Text = "Class Participation:";
			// 
			// txtFA
			// 
			this.txtFA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFA.Location = new System.Drawing.Point(192, 93);
			this.txtFA.Name = "txtFA";
			this.txtFA.Size = new System.Drawing.Size(394, 28);
			this.txtFA.TabIndex = 16;
			this.txtFA.TextChanged += new System.EventHandler(this.txtFA_TextChanged);
			// 
			// txtFCP
			// 
			this.txtFCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFCP.Location = new System.Drawing.Point(192, 49);
			this.txtFCP.Name = "txtFCP";
			this.txtFCP.Size = new System.Drawing.Size(394, 28);
			this.txtFCP.TabIndex = 15;
			this.txtFCP.TextChanged += new System.EventHandler(this.txtFCP_TextChanged);
			// 
			// txtSubject
			// 
			this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubject.Location = new System.Drawing.Point(704, 113);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(158, 28);
			this.txtSubject.TabIndex = 15;
			// 
			// txtSurname
			// 
			this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSurname.Location = new System.Drawing.Point(158, 113);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(158, 28);
			this.txtSurname.TabIndex = 18;
			// 
			// txtSN
			// 
			this.txtSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSN.Location = new System.Drawing.Point(158, 67);
			this.txtSN.Name = "txtSN";
			this.txtSN.Size = new System.Drawing.Size(158, 28);
			this.txtSN.TabIndex = 19;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(966, 713);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(158, 20);
			this.label17.TabIndex = 41;
			this.label17.Text = "Special Assesment:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(966, 663);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(116, 20);
			this.label18.TabIndex = 42;
			this.label18.Text = "Final Average:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(1128, 736);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(208, 18);
			this.label19.TabIndex = 46;
			this.label19.Text = "(eg., 6.00 for UW,  4.00 = INC)";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Blue;
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(1405, 658);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(130, 41);
			this.btnSave.TabIndex = 47;
			this.btnSave.Text = "SAVE CHANGES";
			this.btnSave.UseVisualStyleBackColor = false;
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Blue;
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(1405, 794);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(130, 41);
			this.btnClear.TabIndex = 48;
			this.btnClear.Text = "CLEAR GRADES";
			this.btnClear.UseVisualStyleBackColor = false;
			// 
			// btnRecompute
			// 
			this.btnRecompute.BackColor = System.Drawing.Color.Blue;
			this.btnRecompute.ForeColor = System.Drawing.Color.White;
			this.btnRecompute.Location = new System.Drawing.Point(1405, 747);
			this.btnRecompute.Name = "btnRecompute";
			this.btnRecompute.Size = new System.Drawing.Size(130, 41);
			this.btnRecompute.TabIndex = 49;
			this.btnRecompute.Text = "RECOMPLETE";
			this.btnRecompute.UseVisualStyleBackColor = false;
			// 
			// btnUpload
			// 
			this.btnUpload.BackColor = System.Drawing.Color.Yellow;
			this.btnUpload.ForeColor = System.Drawing.Color.Black;
			this.btnUpload.Location = new System.Drawing.Point(1405, 701);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(130, 41);
			this.btnUpload.TabIndex = 50;
			this.btnUpload.Text = "UPLOAD";
			this.btnUpload.UseVisualStyleBackColor = false;
			// 
			// txtFinalAve
			// 
			this.txtFinalAve.Enabled = false;
			this.txtFinalAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFinalAve.Location = new System.Drawing.Point(1130, 655);
			this.txtFinalAve.Name = "txtFinalAve";
			this.txtFinalAve.Size = new System.Drawing.Size(206, 28);
			this.txtFinalAve.TabIndex = 51;
			this.txtFinalAve.TextChanged += new System.EventHandler(this.txtFinalAve_TextChanged);
			// 
			// txtSA
			// 
			this.txtSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSA.Location = new System.Drawing.Point(1130, 705);
			this.txtSA.Name = "txtSA";
			this.txtSA.Size = new System.Drawing.Size(206, 28);
			this.txtSA.TabIndex = 52;
			this.txtSA.Text = "encode here";
			this.txtSA.TextChanged += new System.EventHandler(this.txtSA_TextChanged);
			this.txtSA.Enter += new System.EventHandler(this.txtSA_Enter);
			this.txtSA.Leave += new System.EventHandler(this.txtSA_Leave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1549, 860);
			this.Controls.Add(this.txtSA);
			this.Controls.Add(this.txtFinalAve);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.btnRecompute);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtSN);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.MidtermTab);
			this.Controls.Add(this.cboProgram);
			this.Controls.Add(this.txtFirstname);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboYear);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvStudents);
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.MidtermTab.ResumeLayout(false);
			this.midtermGradingTab.ResumeLayout(false);
			this.midtermGradingTab.PerformLayout();
			this.finalGradingTab.ResumeLayout(false);
			this.finalGradingTab.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboYear;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtFirstname;
		private System.Windows.Forms.ComboBox cboProgram;
		private System.Windows.Forms.TabControl MidtermTab;
		private System.Windows.Forms.TabPage midtermGradingTab;
		private System.Windows.Forms.TabPage finalGradingTab;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtFA;
		private System.Windows.Forms.TextBox txtFCP;
		private System.Windows.Forms.TextBox txtFQ4;
		private System.Windows.Forms.TextBox txtFQ3;
		private System.Windows.Forms.TextBox txtFE;
		private System.Windows.Forms.TextBox txtFQ1Ave;
		private System.Windows.Forms.TextBox txtFQ2;
		private System.Windows.Forms.ComboBox cboFItemsQ1;
		private System.Windows.Forms.ComboBox cboFItemsQ2;
		private System.Windows.Forms.ComboBox cboFItemsQ3;
		private System.Windows.Forms.ComboBox cboFItemsQ4;
		private System.Windows.Forms.ComboBox cboFItemsFE;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtFLabGrade;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtFQ3Ave;
		private System.Windows.Forms.TextBox txtFQ4Ave;
		private System.Windows.Forms.TextBox txtFEAve;
		private System.Windows.Forms.TextBox txtFQ2Ave;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.TextBox txtSN;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtMidtermGrade;
		private System.Windows.Forms.TextBox txtMLabGrade;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtMQ3Ave;
		private System.Windows.Forms.TextBox txtMQ4Ave;
		private System.Windows.Forms.TextBox txtMEAve;
		private System.Windows.Forms.TextBox txtMQ2Ave;
		private System.Windows.Forms.TextBox txtMQ4;
		private System.Windows.Forms.TextBox txtMQ3;
		private System.Windows.Forms.TextBox txtME;
		private System.Windows.Forms.TextBox txtMQ1Ave;
		private System.Windows.Forms.TextBox txtMQ2;
		private System.Windows.Forms.ComboBox cboMItemsQ1;
		private System.Windows.Forms.ComboBox cboMItemsQ2;
		private System.Windows.Forms.ComboBox cboMItemsQ3;
		private System.Windows.Forms.ComboBox cboMItemsQ4;
		private System.Windows.Forms.ComboBox cboMItemsME;
		private System.Windows.Forms.TextBox txtMQ1;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox txtMA;
		private System.Windows.Forms.TextBox txtMCP;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnRecompute;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.TextBox txtFinalAve;
		private System.Windows.Forms.TextBox txtSA;
		private System.Windows.Forms.TextBox txtFQ1;
		private System.Windows.Forms.TextBox txtFinalGrade;
	}
}

