namespace OOP_labs
{
    partial class Lab1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.creatingObjectPanel = new System.Windows.Forms.Panel();
            this.formOfEducationCombobox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentNameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.facultyTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.universityTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.actionsButton = new System.Windows.Forms.Panel();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.createStudentButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.infoTextbox = new System.Windows.Forms.RichTextBox();
            this.showGraduationYearHex = new System.Windows.Forms.Button();
            this.showUniversity = new System.Windows.Forms.Button();
            this.showFaculty = new System.Windows.Forms.Button();
            this.showDepartment = new System.Windows.Forms.Button();
            this.showAllInfo = new System.Windows.Forms.Button();
            this.showFormOfEducation = new System.Windows.Forms.Button();
            this.showName = new System.Windows.Forms.Button();
            this.showAverageScore = new System.Windows.Forms.Button();
            this.showNumbOfAbsent = new System.Windows.Forms.Button();
            this.averageScoreTextbox = new System.Windows.Forms.NumericUpDown();
            this.graduationYearTextbox = new System.Windows.Forms.NumericUpDown();
            this.numbOfAbsentTextbox = new System.Windows.Forms.NumericUpDown();
            this.creatingObjectPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            this.actionsButton.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averageScoreTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graduationYearTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbOfAbsentTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // creatingObjectPanel
            // 
            this.creatingObjectPanel.Controls.Add(this.numbOfAbsentTextbox);
            this.creatingObjectPanel.Controls.Add(this.graduationYearTextbox);
            this.creatingObjectPanel.Controls.Add(this.averageScoreTextbox);
            this.creatingObjectPanel.Controls.Add(this.formOfEducationCombobox);
            this.creatingObjectPanel.Controls.Add(this.label11);
            this.creatingObjectPanel.Controls.Add(this.label8);
            this.creatingObjectPanel.Controls.Add(this.label7);
            this.creatingObjectPanel.Controls.Add(this.label6);
            this.creatingObjectPanel.Controls.Add(this.studentNameTextbox);
            this.creatingObjectPanel.Controls.Add(this.label5);
            this.creatingObjectPanel.Controls.Add(this.label4);
            this.creatingObjectPanel.Controls.Add(this.departmentTextbox);
            this.creatingObjectPanel.Controls.Add(this.label3);
            this.creatingObjectPanel.Controls.Add(this.facultyTextbox);
            this.creatingObjectPanel.Controls.Add(this.label2);
            this.creatingObjectPanel.Controls.Add(this.universityTextbox);
            this.creatingObjectPanel.Controls.Add(this.label1);
            this.creatingObjectPanel.Location = new System.Drawing.Point(14, 12);
            this.creatingObjectPanel.Name = "creatingObjectPanel";
            this.creatingObjectPanel.Size = new System.Drawing.Size(321, 415);
            this.creatingObjectPanel.TabIndex = 0;
            // 
            // formOfEducationCombobox
            // 
            this.formOfEducationCombobox.FormattingEnabled = true;
            this.formOfEducationCombobox.Items.AddRange(new object[] {
            "Очная",
            "Очно-заочная",
            "Заочная"});
            this.formOfEducationCombobox.Location = new System.Drawing.Point(148, 186);
            this.formOfEducationCombobox.Name = "formOfEducationCombobox";
            this.formOfEducationCombobox.Size = new System.Drawing.Size(148, 28);
            this.formOfEducationCombobox.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Количество прогулов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Год выпуска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Средняя оценка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Имя студента";
            // 
            // studentNameTextbox
            // 
            this.studentNameTextbox.Location = new System.Drawing.Point(170, 245);
            this.studentNameTextbox.Name = "studentNameTextbox";
            this.studentNameTextbox.Size = new System.Drawing.Size(127, 26);
            this.studentNameTextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Форма обучения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кафедра";
            // 
            // departmentTextbox
            // 
            this.departmentTextbox.Location = new System.Drawing.Point(170, 128);
            this.departmentTextbox.Name = "departmentTextbox";
            this.departmentTextbox.Size = new System.Drawing.Size(127, 26);
            this.departmentTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Факультет";
            // 
            // facultyTextbox
            // 
            this.facultyTextbox.Location = new System.Drawing.Point(170, 78);
            this.facultyTextbox.Name = "facultyTextbox";
            this.facultyTextbox.Size = new System.Drawing.Size(127, 26);
            this.facultyTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Университет";
            // 
            // universityTextbox
            // 
            this.universityTextbox.Location = new System.Drawing.Point(170, 32);
            this.universityTextbox.Name = "universityTextbox";
            this.universityTextbox.Size = new System.Drawing.Size(127, 26);
            this.universityTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры объекта";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentTable);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(340, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 188);
            this.panel1.TabIndex = 1;
            // 
            // studentTable
            // 
            this.studentTable.AllowUserToAddRows = false;
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNumber,
            this.StudentName});
            this.studentTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.studentTable.Location = new System.Drawing.Point(3, 25);
            this.studentTable.Name = "studentTable";
            this.studentTable.RowHeadersVisible = false;
            this.studentTable.RowHeadersWidth = 62;
            this.studentTable.RowTemplate.Height = 28;
            this.studentTable.Size = new System.Drawing.Size(388, 163);
            this.studentTable.TabIndex = 1;
            this.studentTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentTable_CellClick);
            // 
            // StudentNumber
            // 
            this.StudentNumber.HeaderText = "№";
            this.StudentNumber.MinimumWidth = 8;
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.ReadOnly = true;
            this.StudentNumber.Width = 60;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Имя студента";
            this.StudentName.MinimumWidth = 8;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Список студентов";
            // 
            // actionsButton
            // 
            this.actionsButton.Controls.Add(this.editStudentButton);
            this.actionsButton.Controls.Add(this.createStudentButton);
            this.actionsButton.Location = new System.Drawing.Point(15, 446);
            this.actionsButton.Name = "actionsButton";
            this.actionsButton.Size = new System.Drawing.Size(300, 75);
            this.actionsButton.TabIndex = 2;
            // 
            // editStudentButton
            // 
            this.editStudentButton.Enabled = false;
            this.editStudentButton.Location = new System.Drawing.Point(146, 3);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(152, 72);
            this.editStudentButton.TabIndex = 1;
            this.editStudentButton.Text = "Изменить выбранного студента";
            this.editStudentButton.UseVisualStyleBackColor = true;
            this.editStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(3, 3);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(136, 72);
            this.createStudentButton.TabIndex = 0;
            this.createStudentButton.Text = "Создать нового студента";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.CreateStudentButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.infoTextbox);
            this.panel2.Location = new System.Drawing.Point(770, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 186);
            this.panel2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Информационное окно";
            // 
            // infoTextbox
            // 
            this.infoTextbox.Location = new System.Drawing.Point(0, 23);
            this.infoTextbox.Name = "infoTextbox";
            this.infoTextbox.ReadOnly = true;
            this.infoTextbox.Size = new System.Drawing.Size(542, 159);
            this.infoTextbox.TabIndex = 0;
            this.infoTextbox.Text = "";
            // 
            // showGraduationYearHex
            // 
            this.showGraduationYearHex.Location = new System.Drawing.Point(770, 214);
            this.showGraduationYearHex.Name = "showGraduationYearHex";
            this.showGraduationYearHex.Size = new System.Drawing.Size(321, 71);
            this.showGraduationYearHex.TabIndex = 4;
            this.showGraduationYearHex.Text = "Получить информацию о дате выпуска в шестнадцатеричном формате";
            this.showGraduationYearHex.UseVisualStyleBackColor = true;
            this.showGraduationYearHex.Click += new System.EventHandler(this.ShowGraduationYear_Click);
            // 
            // showUniversity
            // 
            this.showUniversity.Location = new System.Drawing.Point(770, 291);
            this.showUniversity.Name = "showUniversity";
            this.showUniversity.Size = new System.Drawing.Size(321, 40);
            this.showUniversity.TabIndex = 5;
            this.showUniversity.Text = "Вывести на экран университет";
            this.showUniversity.UseVisualStyleBackColor = true;
            this.showUniversity.Click += new System.EventHandler(this.ShowUniversity_Click);
            // 
            // showFaculty
            // 
            this.showFaculty.Location = new System.Drawing.Point(770, 345);
            this.showFaculty.Name = "showFaculty";
            this.showFaculty.Size = new System.Drawing.Size(321, 40);
            this.showFaculty.TabIndex = 6;
            this.showFaculty.Text = "Вывести на экран факультет";
            this.showFaculty.UseVisualStyleBackColor = true;
            this.showFaculty.Click += new System.EventHandler(this.ShowFaculty_Click);
            // 
            // showDepartment
            // 
            this.showDepartment.Location = new System.Drawing.Point(770, 392);
            this.showDepartment.Name = "showDepartment";
            this.showDepartment.Size = new System.Drawing.Size(321, 35);
            this.showDepartment.TabIndex = 7;
            this.showDepartment.Text = "Вывести на экран кафедру";
            this.showDepartment.UseVisualStyleBackColor = true;
            this.showDepartment.Click += new System.EventHandler(this.ShowDepartment_Click);
            // 
            // showAllInfo
            // 
            this.showAllInfo.Location = new System.Drawing.Point(340, 212);
            this.showAllInfo.Name = "showAllInfo";
            this.showAllInfo.Size = new System.Drawing.Size(321, 71);
            this.showAllInfo.TabIndex = 8;
            this.showAllInfo.Text = "Вывести на экран всю информацию";
            this.showAllInfo.UseVisualStyleBackColor = true;
            this.showAllInfo.Click += new System.EventHandler(this.ShowAllInfo_Click);
            // 
            // showFormOfEducation
            // 
            this.showFormOfEducation.Location = new System.Drawing.Point(340, 291);
            this.showFormOfEducation.Name = "showFormOfEducation";
            this.showFormOfEducation.Size = new System.Drawing.Size(321, 38);
            this.showFormOfEducation.TabIndex = 9;
            this.showFormOfEducation.Text = "Вывести на экран форму обучения";
            this.showFormOfEducation.UseVisualStyleBackColor = true;
            this.showFormOfEducation.Click += new System.EventHandler(this.ShowEducationForm_Click);
            // 
            // showName
            // 
            this.showName.Location = new System.Drawing.Point(344, 345);
            this.showName.Name = "showName";
            this.showName.Size = new System.Drawing.Size(316, 40);
            this.showName.TabIndex = 10;
            this.showName.Text = "Вывести на экран имя студента";
            this.showName.UseVisualStyleBackColor = true;
            this.showName.Click += new System.EventHandler(this.ShowName_Click);
            // 
            // showAverageScore
            // 
            this.showAverageScore.Location = new System.Drawing.Point(344, 392);
            this.showAverageScore.Name = "showAverageScore";
            this.showAverageScore.Size = new System.Drawing.Size(318, 35);
            this.showAverageScore.TabIndex = 11;
            this.showAverageScore.Text = "Вывести на экран среднюю оценку студента";
            this.showAverageScore.UseVisualStyleBackColor = true;
            this.showAverageScore.Click += new System.EventHandler(this.ShowAverageScore_Click);
            // 
            // showNumbOfAbsent
            // 
            this.showNumbOfAbsent.Location = new System.Drawing.Point(770, 446);
            this.showNumbOfAbsent.Name = "showNumbOfAbsent";
            this.showNumbOfAbsent.Size = new System.Drawing.Size(321, 57);
            this.showNumbOfAbsent.TabIndex = 7;
            this.showNumbOfAbsent.Text = "Вывести на экран количество прогулов";
            this.showNumbOfAbsent.UseVisualStyleBackColor = true;
            this.showNumbOfAbsent.Click += new System.EventHandler(this.ShowNumbAbsent_Click);
            // 
            // averageScoreTextbox
            // 
            this.averageScoreTextbox.DecimalPlaces = 1;
            this.averageScoreTextbox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.averageScoreTextbox.Location = new System.Drawing.Point(181, 291);
            this.averageScoreTextbox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.averageScoreTextbox.Name = "averageScoreTextbox";
            this.averageScoreTextbox.Size = new System.Drawing.Size(120, 26);
            this.averageScoreTextbox.TabIndex = 16;
            // 
            // graduationYearTextbox
            // 
            this.graduationYearTextbox.Location = new System.Drawing.Point(181, 336);
            this.graduationYearTextbox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.graduationYearTextbox.Name = "graduationYearTextbox";
            this.graduationYearTextbox.Size = new System.Drawing.Size(120, 26);
            this.graduationYearTextbox.TabIndex = 17;
            // 
            // numbOfAbsentTextbox
            // 
            this.numbOfAbsentTextbox.Location = new System.Drawing.Point(180, 380);
            this.numbOfAbsentTextbox.Name = "numbOfAbsentTextbox";
            this.numbOfAbsentTextbox.Size = new System.Drawing.Size(120, 26);
            this.numbOfAbsentTextbox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 777);
            this.Controls.Add(this.showAverageScore);
            this.Controls.Add(this.showName);
            this.Controls.Add(this.showFormOfEducation);
            this.Controls.Add(this.showAllInfo);
            this.Controls.Add(this.showNumbOfAbsent);
            this.Controls.Add(this.showDepartment);
            this.Controls.Add(this.showFaculty);
            this.Controls.Add(this.showUniversity);
            this.Controls.Add(this.showGraduationYearHex);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.actionsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.creatingObjectPanel);
            this.Name = "Form1";
            this.Text = "ЛБ 1. Сазонов/Зимин 23ВП1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.creatingObjectPanel.ResumeLayout(false);
            this.creatingObjectPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
            this.actionsButton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averageScoreTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graduationYearTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbOfAbsentTextbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel creatingObjectPanel;
        private System.Windows.Forms.TextBox universityTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentNameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox departmentTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox facultyTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox formOfEducationCombobox;
        private System.Windows.Forms.Panel actionsButton;
        private System.Windows.Forms.Button editStudentButton;
        private System.Windows.Forms.Button createStudentButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView studentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox infoTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button showGraduationYearHex;
        private System.Windows.Forms.Button showUniversity;
        private System.Windows.Forms.Button showFaculty;
        private System.Windows.Forms.Button showDepartment;
        private System.Windows.Forms.Button showAllInfo;
        private System.Windows.Forms.Button showFormOfEducation;
        private System.Windows.Forms.Button showName;
        private System.Windows.Forms.Button showAverageScore;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button showNumbOfAbsent;
        private System.Windows.Forms.NumericUpDown averageScoreTextbox;
        private System.Windows.Forms.NumericUpDown numbOfAbsentTextbox;
        private System.Windows.Forms.NumericUpDown graduationYearTextbox;
    }
}

