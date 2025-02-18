namespace OOP_labs
{
    partial class Form1
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
            this.label8 = new System.Windows.Forms.Label();
            this.graduationYearTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.averageScoreTextbox = new System.Windows.Forms.TextBox();
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.numbOfAbsentTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.creatingObjectPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            this.actionsButton.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // creatingObjectPanel
            // 
            this.creatingObjectPanel.Controls.Add(this.formOfEducationCombobox);
            this.creatingObjectPanel.Controls.Add(this.label11);
            this.creatingObjectPanel.Controls.Add(this.label8);
            this.creatingObjectPanel.Controls.Add(this.numbOfAbsentTextbox);
            this.creatingObjectPanel.Controls.Add(this.graduationYearTextbox);
            this.creatingObjectPanel.Controls.Add(this.label7);
            this.creatingObjectPanel.Controls.Add(this.averageScoreTextbox);
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
            this.creatingObjectPanel.Location = new System.Drawing.Point(9, 8);
            this.creatingObjectPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creatingObjectPanel.Name = "creatingObjectPanel";
            this.creatingObjectPanel.Size = new System.Drawing.Size(214, 270);
            this.creatingObjectPanel.TabIndex = 0;
            // 
            // formOfEducationCombobox
            // 
            this.formOfEducationCombobox.FormattingEnabled = true;
            this.formOfEducationCombobox.Items.AddRange(new object[] {
            "Очная",
            "Очно-заочная",
            "Заочная"});
            this.formOfEducationCombobox.Location = new System.Drawing.Point(99, 121);
            this.formOfEducationCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formOfEducationCombobox.Name = "formOfEducationCombobox";
            this.formOfEducationCombobox.Size = new System.Drawing.Size(100, 21);
            this.formOfEducationCombobox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Год выпуска";
            // 
            // graduationYearTextbox
            // 
            this.graduationYearTextbox.Location = new System.Drawing.Point(113, 219);
            this.graduationYearTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graduationYearTextbox.Name = "graduationYearTextbox";
            this.graduationYearTextbox.Size = new System.Drawing.Size(86, 20);
            this.graduationYearTextbox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Средняя оценка";
            // 
            // averageScoreTextbox
            // 
            this.averageScoreTextbox.Location = new System.Drawing.Point(112, 190);
            this.averageScoreTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.averageScoreTextbox.Name = "averageScoreTextbox";
            this.averageScoreTextbox.Size = new System.Drawing.Size(86, 20);
            this.averageScoreTextbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Имя студента";
            // 
            // studentNameTextbox
            // 
            this.studentNameTextbox.Location = new System.Drawing.Point(113, 159);
            this.studentNameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentNameTextbox.Name = "studentNameTextbox";
            this.studentNameTextbox.Size = new System.Drawing.Size(86, 20);
            this.studentNameTextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Форма обучения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кафедра";
            // 
            // departmentTextbox
            // 
            this.departmentTextbox.Location = new System.Drawing.Point(113, 83);
            this.departmentTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departmentTextbox.Name = "departmentTextbox";
            this.departmentTextbox.Size = new System.Drawing.Size(86, 20);
            this.departmentTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Факультет";
            // 
            // facultyTextbox
            // 
            this.facultyTextbox.Location = new System.Drawing.Point(113, 51);
            this.facultyTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facultyTextbox.Name = "facultyTextbox";
            this.facultyTextbox.Size = new System.Drawing.Size(86, 20);
            this.facultyTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Университет";
            // 
            // universityTextbox
            // 
            this.universityTextbox.Location = new System.Drawing.Point(113, 21);
            this.universityTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.universityTextbox.Name = "universityTextbox";
            this.universityTextbox.Size = new System.Drawing.Size(86, 20);
            this.universityTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры объекта";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentTable);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(227, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 122);
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
            this.studentTable.Location = new System.Drawing.Point(2, 16);
            this.studentTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentTable.Name = "studentTable";
            this.studentTable.RowHeadersVisible = false;
            this.studentTable.RowHeadersWidth = 62;
            this.studentTable.RowTemplate.Height = 28;
            this.studentTable.Size = new System.Drawing.Size(259, 106);
            this.studentTable.TabIndex = 1;
            this.studentTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentTable_CellClick);
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
            this.label9.Location = new System.Drawing.Point(2, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Список студентов";
            // 
            // actionsButton
            // 
            this.actionsButton.Controls.Add(this.editStudentButton);
            this.actionsButton.Controls.Add(this.createStudentButton);
            this.actionsButton.Location = new System.Drawing.Point(10, 290);
            this.actionsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actionsButton.Name = "actionsButton";
            this.actionsButton.Size = new System.Drawing.Size(200, 49);
            this.actionsButton.TabIndex = 2;
            // 
            // editStudentButton
            // 
            this.editStudentButton.Enabled = false;
            this.editStudentButton.Location = new System.Drawing.Point(97, 2);
            this.editStudentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(101, 47);
            this.editStudentButton.TabIndex = 1;
            this.editStudentButton.Text = "Изменить выбранного студента";
            this.editStudentButton.UseVisualStyleBackColor = true;
            this.editStudentButton.Click += new System.EventHandler(this.editStudentButton_Click);
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(2, 2);
            this.createStudentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(91, 47);
            this.createStudentButton.TabIndex = 0;
            this.createStudentButton.Text = "Создать нового студента";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createStudentButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.infoTextbox);
            this.panel2.Location = new System.Drawing.Point(513, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 121);
            this.panel2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Информационное окно";
            // 
            // infoTextbox
            // 
            this.infoTextbox.Location = new System.Drawing.Point(0, 15);
            this.infoTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoTextbox.Name = "infoTextbox";
            this.infoTextbox.ReadOnly = true;
            this.infoTextbox.Size = new System.Drawing.Size(363, 105);
            this.infoTextbox.TabIndex = 0;
            this.infoTextbox.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 139);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Получить информацию о дате выпуска в шестнадцатеричном формате";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(513, 189);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "Вывести на экран университет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(513, 224);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 26);
            this.button5.TabIndex = 6;
            this.button5.Text = "Вывести на экран факультет";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(513, 255);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(214, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Вывести на экран кафедру";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(227, 138);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(214, 46);
            this.button7.TabIndex = 8;
            this.button7.Text = "Вывести на экран всю информацию";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(227, 189);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(214, 25);
            this.button8.TabIndex = 9;
            this.button8.Text = "Вывести на экран форму обучения";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(229, 224);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(211, 26);
            this.button9.TabIndex = 10;
            this.button9.Text = "Вывести на экран имя студента";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(229, 255);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(212, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Вывести на экран среднюю оценку студента";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 247);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Количество прогулов";
            // 
            // numbOfAbsentTextbox
            // 
            this.numbOfAbsentTextbox.Location = new System.Drawing.Point(115, 244);
            this.numbOfAbsentTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.numbOfAbsentTextbox.Name = "numbOfAbsentTextbox";
            this.numbOfAbsentTextbox.Size = new System.Drawing.Size(86, 20);
            this.numbOfAbsentTextbox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вывести на экран количество прогулов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 505);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.actionsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.creatingObjectPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel creatingObjectPanel;
        private System.Windows.Forms.TextBox universityTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox graduationYearTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox averageScoreTextbox;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox numbOfAbsentTextbox;
        private System.Windows.Forms.Button button1;
    }
}

