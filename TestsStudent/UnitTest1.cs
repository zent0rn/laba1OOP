using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_labs.src;


namespace TestsStudent
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void FirstConstructorWorksFine()
        {
            string university = "ПГУ";
            string faculty = "ФВТ";
            string department = "МОиПЭВМ";
            EducationForm educationForm = (EducationForm) 1;
            string name = "Алексей";
            double averageScore = 3.4;
            int graduationYear = 2027;
            int numbOfAbsent = 33;


            Student student = new Student(university, faculty, department, educationForm,
             name, averageScore, graduationYear, numbOfAbsent);


            Assert.AreEqual(name, student.Name);
            Assert.AreEqual(averageScore, student.AverageScore);
            Assert.AreEqual(graduationYear, student.YearOfGraduation);
            Assert.AreEqual(university, student.University);
            Assert.AreEqual(faculty, student.Faculty);
            Assert.AreEqual(department, student.Department);
            Assert.AreEqual(numbOfAbsent, student.NumbOfAbsent);
            Assert.AreEqual(educationForm, student.EduForm);
        }

        [TestMethod]
        public void SecondConstructorWorksFine()
        {
            Student student = new Student();

            Assert.IsNotNull(student);

        }

        [TestMethod]
        public void ThirdConstructorWorksFine()
        {
            string name = "Алексей";

            Student student = new Student(name);

            Assert.AreEqual(name, student.Name);
        }

        [TestMethod]
        public void FourthConstructorWorksFine()
        {

            string name = "Алексей";
            string university = "ФВТ";

            Student student = new Student(name, university);

            Assert.AreEqual(name, student.Name);
            Assert.AreEqual(university, student.University);
        }

        [TestMethod]
        public void ToStringMethodWorksFine()
        {
            string university = "ПГУ";
            string faculty = "ФВТ";
            string department = "МОиПЭВМ";
            EducationForm educationForm = (EducationForm)1;
            string name = "Алексей";
            double averageScore = 3.4;
            int graduationYear = 2027;
            int numbOfAbsent = 33;

            string expected = $"Студент {name} №1.\n" +
                $"Университет: {university}, факультет: {faculty}, кафедра: {department}, форма обучения: {educationForm.ToString()}.\n" +
                $"Год выпуска: {graduationYear}, средний балл: {averageScore}, количество прогулов: {numbOfAbsent}";

            Student student = new Student(university, faculty, department, educationForm,
             name, averageScore, graduationYear, numbOfAbsent);

            
            Assert.AreEqual(expected, student.ToString());
            
        }

        [TestMethod]
        public void GetYearOfGraduationInHexWorksFine()
        {
            string university = "ПГУ";
            string faculty = "ФВТ";
            string department = "МОиПЭВМ";
            EducationForm educationForm = (EducationForm)1;
            string name = "Алексей";
            double averageScore = 3.4;
            int graduationYear = 2027;
            int numbOfAbsent = 33;

            string expected = "0x7EB";

            Student student = new Student(university, faculty, department, educationForm,
             name, averageScore, graduationYear, numbOfAbsent);

            Assert.AreEqual(student.getYearOfGraduationInHex(), expected);
        }

        


    }
}
