using OOP_labs.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_labs
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        private Student currentStudent;
        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void createStudentButton_Click(object sender, EventArgs e)
        {
            string university = universityTextbox.Text;
            string faculty = facultyTextbox.Text;
            string department = departmentTextbox.Text;
            EducationForm educationForm = (EducationForm) formOfEducationCombobox.SelectedIndex;
            string studentName = studentNameTextbox.Text;
            double averageScore = averageScoreTextbox.Text.Length == 0 ? 0.0: double.Parse(averageScoreTextbox.Text);
            int graduationYear = graduationYearTextbox.Text.Length == 0 ? 0 : int.Parse(graduationYearTextbox.Text);
            int numbOfAbsent = numbOfAbsentTextbox.Text.Length == 0 ? 0 : int.Parse(numbOfAbsentTextbox.Text);

            if (!string.IsNullOrEmpty(university) && !string.IsNullOrEmpty(faculty)
                && !string.IsNullOrEmpty(department) && educationForm != EducationForm.Undefined &&
                averageScore != 0 && graduationYear != 0) {
                try
                {
                    Student student = new Student(university, faculty, department, educationForm, studentName, averageScore, graduationYear, numbOfAbsent);
                    students.Add(student);
                    showMessage("Студент " + studentName + " создан\n");
                }
                catch (TooManyObjectsException ex) {
                    Win32.MessageBox(0, ex.Message + "\nЛимит: " + ex.Limit + " объектов", "Ошибка", 0);
                }
                   

            }
            updateStudentsTable();
        }
        private void updateStudentsTable()
        {

            clearStudentsTable();
            showStudentsTable();
        }

        private void clearStudentsTable()
        {
            studentTable.DataSource = null;
            studentTable.Rows.Clear();
        }

        private void showStudentsTable() {
            foreach (Student student in students) {
                studentTable.Rows.Add(student.Id, student.Name);
            }
        }
        private void showMessage(string message)
        {
            infoTextbox.AppendText(message);
        }

        private void studentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) {
                return;
            }
            long studentId = (long)studentTable.Rows[e.RowIndex].Cells[0].Value;
            Student student = students.ElementAt((int)studentId - 1);
            currentStudent = student;
            universityTextbox.Text = student.University;
            facultyTextbox.Text = student.Faculty;
            departmentTextbox.Text = student.Department;
            formOfEducationCombobox.Text = formOfEducationCombobox.Items[(int)student.EduForm].ToString();
            studentNameTextbox.Text = student.Name;
            averageScoreTextbox.Text = student.AverageScore.ToString();
            graduationYearTextbox.Text = student.YearOfGraduation.ToString();
            numbOfAbsentTextbox.Text = student.NumbOfAbsent.ToString();

            editStudentButton.Enabled = true;
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }
            string university = universityTextbox.Text;
            string faculty = facultyTextbox.Text;
            string department = departmentTextbox.Text;
            EducationForm educationForm = (EducationForm)formOfEducationCombobox.SelectedIndex;
            string studentName = studentNameTextbox.Text;
            double averageScore = averageScoreTextbox.Text.Length == 0 ? 0.0 : double.Parse(averageScoreTextbox.Text);
            int graduationYear = graduationYearTextbox.Text.Length == 0 ? 0 : int.Parse(graduationYearTextbox.Text);
            int numbOfAbsent = numbOfAbsentTextbox.Text.Length == 0 ? 0 : int.Parse(numbOfAbsentTextbox.Text);

            currentStudent.University = university;
            currentStudent.Faculty = faculty;
            currentStudent.Department = department;
            currentStudent.EduForm = educationForm;
            currentStudent.Name = studentName;
            currentStudent.AverageScore = averageScore;
            currentStudent.YearOfGraduation = graduationYear;
            currentStudent.NumbOfAbsent = numbOfAbsent;

            showMessage("\nДанные студента с ID " + currentStudent.Id + " изменены\n");

            currentStudent = null;
            editStudentButton.Enabled = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            showMessage(currentStudent.ToString());
        }

        private void infoTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            showMessage("Форма обучения выбранного студента: \n" + currentStudent.EduForm + "\n");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            showMessage("Имя выбранного студента: \n" + currentStudent.Name + "\n");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            showMessage("Средняя оценка выбранного студента: \n" + currentStudent.AverageScore + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            showMessage("Информация о дате выпуска в шестнадцатиричном формате выбранного студента: : \n" + currentStudent.getYearOfGraduationInHex() + "\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            showMessage("Университет выбранного студента: \n" + currentStudent.University + "\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            showMessage("Факультет выбранного студента: \n" + currentStudent.Faculty + "\n");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            showMessage("Кафедра выбранного студента: \n" + currentStudent.Department + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            showMessage("Количество прогулов выбранного студента:\n " + currentStudent.NumbOfAbsent + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showMessage("Лабораторная работа #1: Класс. Статические члены класса. Обработка исключений.\n" +
                "Группа 23ВП1, состав бригады: Сазонов А. Н., Зимин Е. А.");
        }
    }
}
