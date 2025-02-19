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
    public partial class Lab1 : Form
    {
        private List<Student> students;
        private Student currentStudent;
        public Lab1()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string university = universityTextbox.Text;
                string faculty = facultyTextbox.Text;
                string department = departmentTextbox.Text;
                EducationForm educationForm = (EducationForm)formOfEducationCombobox.SelectedIndex;
                string studentName = studentNameTextbox.Text;
                double averageScore = averageScoreTextbox.Text.Length == 0 ? 0.0 : double.Parse(averageScoreTextbox.Text);
                int graduationYear = graduationYearTextbox.Text.Length == 0 ? 0 : int.Parse(graduationYearTextbox.Text);
                int numbOfAbsent = numbOfAbsentTextbox.Text.Length == 0 ? 0 : int.Parse(numbOfAbsentTextbox.Text);
                try
                {
                    if (!string.IsNullOrEmpty(university) && !string.IsNullOrEmpty(faculty)
                    && !string.IsNullOrEmpty(department) && educationForm != EducationForm.Undefined &&
                    averageScore != 0 && graduationYear != 0)
                    {

                        Student student = new Student(university, faculty, department, educationForm, studentName,
                            averageScore, graduationYear, numbOfAbsent);

                        students.Add(student);
                        ShowMessage("Студент " + studentName + " создан\n");
                    }
                    else if (!string.IsNullOrEmpty(university) && !string.IsNullOrEmpty(studentName))
                    {
                        Student student = new Student(studentName, university);
                        students.Add(student);
                        ShowMessage("Студент " + studentName + " создан\n");
                    }
                    else if (!string.IsNullOrEmpty(studentName))
                    {
                        Student student = new Student(studentName);
                        students.Add(student);
                        ShowMessage("Студент " + studentName + " создан\n");
                    }
                    else
                    {
                        Student student = new Student();
                        students.Add(student);
                        ShowMessage("Студент с ID " + student.Id + " создан\n");
                    }
                }
                catch (TooManyObjectsException ex)
                {
                    Win32.MessageBox(0, ex.Message + "\nЛимит: " + ex.Limit + " объектов", "Ошибка", 0);
                }
                UpdateStudentsTable();
            }
            catch (Exception ex) {
                Win32.MessageBox(0, ex.Message, "Ошибка", 0);
            }
        }
        private void UpdateStudentsTable()
        {

            ClearStudentsTable();
            ShowStudentsTable();
        }

        private void ClearStudentsTable()
        {
            studentTable.DataSource = null;
            studentTable.Rows.Clear();
        }

        private void ShowStudentsTable() {
            foreach (Student student in students) {
                studentTable.Rows.Add(student.Id, student.Name);
            }
        }
        private void ShowMessage(string message)
        {
            infoTextbox.AppendText(message);
        }

        private void StudentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                long studentId = (long)studentTable.Rows[e.RowIndex].Cells[0].Value;
                Student student = students.ElementAt((int)studentId - 1);
                currentStudent = student;

                WriteStudentInfo(currentStudent);

                editStudentButton.Enabled = true;
            }
            catch (Exception ex) {
                Win32.MessageBox(0, ex.Message, "Ошибка", 0);
            }
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            try
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

                ShowMessage("\nДанные студента с ID " + currentStudent.Id + " изменены\n");

                currentStudent = null;
                editStudentButton.Enabled = false;
            }
            catch (Exception ex) {
                Win32.MessageBox(0, ex.Message, "Ошибка", 0);
            }
        }

        private void WriteStudentInfo(Student student) {
            universityTextbox.Text = student.University;
            facultyTextbox.Text = student.Faculty;
            departmentTextbox.Text = student.Department;
            formOfEducationCombobox.Text = formOfEducationCombobox.Items[(int)student.EduForm].ToString();
            studentNameTextbox.Text = student.Name;
            averageScoreTextbox.Text = student.AverageScore.ToString();
            graduationYearTextbox.Text = student.YearOfGraduation.ToString();
            numbOfAbsentTextbox.Text = student.NumbOfAbsent.ToString();
        }
        private void ShowEducationForm_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            ShowMessage("Форма обучения выбранного студента: \n" + currentStudent.EduForm + "\n");
        }

        private void ShowName_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            ShowMessage("Имя выбранного студента: \n" + currentStudent.Name + "\n");
        }

        private void ShowAverageScore_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            ShowMessage("Средняя оценка выбранного студента: \n" + currentStudent.AverageScore + "\n");
        }

        private void ShowGraduationYear_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            ShowMessage("Информация о дате выпуска в шестнадцатиричном формате выбранного студента: \n" + currentStudent.getYearOfGraduationInHex() + "\n");
        }

        private void ShowUniversity_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            ShowMessage("Университет выбранного студента: \n" + currentStudent.University + "\n");
        }

        private void ShowFaculty_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            ShowMessage("Факультет выбранного студента: \n" + currentStudent.Faculty + "\n");
        }

        private void ShowDepartment_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            ShowMessage("Кафедра выбранного студента: \n" + currentStudent.Department + "\n");
        }

        private void ShowNumbAbsent_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }

            ShowMessage("Количество прогулов выбранного студента:\n " + currentStudent.NumbOfAbsent + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowMessage("Лабораторная работа #1: Класс. Статические члены класса. Обработка исключений.\n" +
                "Группа 23ВП1, состав бригады: Сазонов А. Н., Зимин Е. А.\n");
        }

        private void ShowAllInfo_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                return;
            }
            ShowMessage(currentStudent.ToString());
        }
    }
}
