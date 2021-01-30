namespace WindowsFormsApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.textStudentID = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textStuMark = new System.Windows.Forms.TextBox();
            this.comboGroupID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddStud = new System.Windows.Forms.Button();
            this.textGroupID = new System.Windows.Forms.TextBox();
            this.textGroupMark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCreateGrp = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.textGroupName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortGroupID = new System.Windows.Forms.Button();
            this.SortStudentID = new System.Windows.Forms.Button();
            this.SortName = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BulkAssign = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonImportCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // textStudentID
            // 
            this.textStudentID.Location = new System.Drawing.Point(169, 66);
            this.textStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.textStudentID.Name = "textStudentID";
            this.textStudentID.Size = new System.Drawing.Size(140, 24);
            this.textStudentID.TabIndex = 1;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(169, 98);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(140, 24);
            this.textFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(169, 130);
            this.textSurname.Margin = new System.Windows.Forms.Padding(4);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(140, 24);
            this.textSurname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(169, 162);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(140, 24);
            this.textEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Student Mark";
            // 
            // textStuMark
            // 
            this.textStuMark.Location = new System.Drawing.Point(169, 196);
            this.textStuMark.Margin = new System.Windows.Forms.Padding(4);
            this.textStuMark.Name = "textStuMark";
            this.textStuMark.Size = new System.Drawing.Size(140, 24);
            this.textStuMark.TabIndex = 9;
            // 
            // comboGroupID
            // 
            this.comboGroupID.FormattingEnabled = true;
            this.comboGroupID.Location = new System.Drawing.Point(169, 229);
            this.comboGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.comboGroupID.Name = "comboGroupID";
            this.comboGroupID.Size = new System.Drawing.Size(140, 26);
            this.comboGroupID.TabIndex = 10;
            this.comboGroupID.SelectedIndexChanged += new System.EventHandler(this.comboGroupID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Group ID";
            // 
            // buttonAddStud
            // 
            this.buttonAddStud.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStud.Location = new System.Drawing.Point(20, 283);
            this.buttonAddStud.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddStud.Name = "buttonAddStud";
            this.buttonAddStud.Size = new System.Drawing.Size(187, 50);
            this.buttonAddStud.TabIndex = 12;
            this.buttonAddStud.Text = "Add/Update Student";
            this.buttonAddStud.UseVisualStyleBackColor = false;
            this.buttonAddStud.Click += new System.EventHandler(this.buttonAddStud_Click);
            // 
            // textGroupID
            // 
            this.textGroupID.Location = new System.Drawing.Point(164, 57);
            this.textGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.textGroupID.Name = "textGroupID";
            this.textGroupID.Size = new System.Drawing.Size(166, 24);
            this.textGroupID.TabIndex = 15;
            // 
            // textGroupMark
            // 
            this.textGroupMark.Location = new System.Drawing.Point(164, 145);
            this.textGroupMark.Margin = new System.Windows.Forms.Padding(4);
            this.textGroupMark.Name = "textGroupMark";
            this.textGroupMark.Size = new System.Drawing.Size(166, 24);
            this.textGroupMark.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Group ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 151);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Group Mark";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(443, 786);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(151, 38);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(601, 786);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(151, 38);
            this.buttonLoad.TabIndex = 22;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCreateGrp
            // 
            this.buttonCreateGrp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCreateGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateGrp.Location = new System.Drawing.Point(97, 196);
            this.buttonCreateGrp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateGrp.Name = "buttonCreateGrp";
            this.buttonCreateGrp.Size = new System.Drawing.Size(164, 50);
            this.buttonCreateGrp.TabIndex = 24;
            this.buttonCreateGrp.Text = "Create/Update Group";
            this.buttonCreateGrp.UseVisualStyleBackColor = false;
            this.buttonCreateGrp.Click += new System.EventHandler(this.buttonCreateGrp_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(916, 785);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(151, 38);
            this.buttonReset.TabIndex = 25;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.Location = new System.Drawing.Point(28, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(631, 210);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(674, 146);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(528, 209);
            this.dataGridView2.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 107);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Group Name";
            // 
            // textGroupName
            // 
            this.textGroupName.Location = new System.Drawing.Point(164, 101);
            this.textGroupName.Margin = new System.Windows.Forms.Padding(4);
            this.textGroupName.Name = "textGroupName";
            this.textGroupName.Size = new System.Drawing.Size(166, 24);
            this.textGroupName.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 101);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Student Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(670, 101);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(250, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Students in a selected group";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.sortGroupID);
            this.groupBox1.Controls.Add(this.SortStudentID);
            this.groupBox1.Controls.Add(this.SortName);
            this.groupBox1.Controls.Add(this.textStudentID);
            this.groupBox1.Controls.Add(this.textFirstName);
            this.groupBox1.Controls.Add(this.textSurname);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textStuMark);
            this.groupBox1.Controls.Add(this.comboGroupID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonAddStud);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 399);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(402, 424);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sortGroupID
            // 
            this.sortGroupID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sortGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortGroupID.Location = new System.Drawing.Point(20, 352);
            this.sortGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.sortGroupID.Name = "sortGroupID";
            this.sortGroupID.Size = new System.Drawing.Size(187, 46);
            this.sortGroupID.TabIndex = 15;
            this.sortGroupID.Text = "Sort by Group ID";
            this.sortGroupID.UseVisualStyleBackColor = false;
            this.sortGroupID.Click += new System.EventHandler(this.sortGroupID_Click);
            // 
            // SortStudentID
            // 
            this.SortStudentID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SortStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortStudentID.Location = new System.Drawing.Point(228, 287);
            this.SortStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.SortStudentID.Name = "SortStudentID";
            this.SortStudentID.Size = new System.Drawing.Size(163, 46);
            this.SortStudentID.TabIndex = 14;
            this.SortStudentID.Text = "Sort by Student ID";
            this.SortStudentID.UseVisualStyleBackColor = false;
            this.SortStudentID.Click += new System.EventHandler(this.SortStudentID_Click);
            // 
            // SortName
            // 
            this.SortName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortName.Location = new System.Drawing.Point(228, 352);
            this.SortName.Margin = new System.Windows.Forms.Padding(4);
            this.SortName.Name = "SortName";
            this.SortName.Size = new System.Drawing.Size(163, 46);
            this.SortName.TabIndex = 13;
            this.SortName.Text = "Sort by First Name";
            this.SortName.UseVisualStyleBackColor = false;
            this.SortName.Click += new System.EventHandler(this.SortName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.textGroupID);
            this.groupBox2.Controls.Add(this.textGroupName);
            this.groupBox2.Controls.Add(this.textGroupMark);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonCreateGrp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(461, 399);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(351, 285);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group Details";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1073, 786);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(155, 38);
            this.ExitButton.TabIndex = 34;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BulkAssign
            // 
            this.BulkAssign.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BulkAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulkAssign.Location = new System.Drawing.Point(755, 785);
            this.BulkAssign.Margin = new System.Windows.Forms.Padding(4);
            this.BulkAssign.Name = "BulkAssign";
            this.BulkAssign.Size = new System.Drawing.Size(151, 38);
            this.BulkAssign.TabIndex = 35;
            this.BulkAssign.Text = "Bulk Assign";
            this.BulkAssign.UseVisualStyleBackColor = false;
            this.BulkAssign.Click += new System.EventHandler(this.BulkAssign_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(830, 427);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(367, 257);
            this.dataGridView3.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(826, 399);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Group Details";
            // 
            // buttonImportCSV
            // 
            this.buttonImportCSV.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonImportCSV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportCSV.ForeColor = System.Drawing.Color.White;
            this.buttonImportCSV.Location = new System.Drawing.Point(1007, 43);
            this.buttonImportCSV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImportCSV.Name = "buttonImportCSV";
            this.buttonImportCSV.Size = new System.Drawing.Size(195, 46);
            this.buttonImportCSV.TabIndex = 38;
            this.buttonImportCSV.Text = "Import CSV";
            this.buttonImportCSV.UseVisualStyleBackColor = false;
            this.buttonImportCSV.Click += new System.EventHandler(this.buttonImportCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 917);
            this.Controls.Add(this.buttonImportCSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.BulkAssign);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textStudentID;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textStuMark;
        private System.Windows.Forms.ComboBox comboGroupID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddStud;
        private System.Windows.Forms.TextBox textGroupID;
        private System.Windows.Forms.TextBox textGroupMark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCreateGrp;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textGroupName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SortStudentID;
        private System.Windows.Forms.Button SortName;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button sortGroupID;
        private System.Windows.Forms.Button BulkAssign;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonImportCSV;
    }
}

