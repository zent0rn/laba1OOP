using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_labs.src
{
    public class Student
    {
        private static long _objectCounter = 0;
        public static long ObjectCounter { 
            get { return _objectCounter; }
        }

        private static int MEMORY_LIMIT = 7;

        private long _id;
        public long Id {
            get => _id;
        }

        private string _university;
        public string University {
            get => _university;
            set => _university = value;
        }

        private string _faculty;
        public string Faculty {
            get => _faculty;
            set => _faculty = value;
        }

        private string _department;
        public string Department {
            get => _department;
            set => _department = value;
        }

        private EducationForm _educationForm;
        public EducationForm EduForm {
            get => _educationForm;
            set => _educationForm = value;
        }

        private string _name;
        public string Name {
            get => _name;
            set => _name = value;
        }

        private double _averageScore;
        public double AverageScore {
            get => _averageScore;
            set => _averageScore = value;
        }

        private int _yearOfGraduation;
        public int YearOfGraduation {
            get => _yearOfGraduation;
            set => _yearOfGraduation = value;
        }

        private int _numbOfAbsent;
        public int NumbOfAbsent
        {
            get => _numbOfAbsent;
            set => _numbOfAbsent = value;
        }

        

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="university">Университет студента</param>
        /// <param name="faculty">Факультет студента</param>
        /// <param name="department">Кафедра студента</param>
        /// <param name="educationForm">Форма обучения студента</param>
        /// <param name="name">Имя студента</param>
        /// <param name="averageScore">Средний балл студента</param>
        /// <param name="graduationYear">Год выпуска студента</param>
        /// <param name="numbOfAbsent">Количество пропусков студента</param>
        /// <exception cref="TooManyObjectsException">Исключение при превышении максимального числа объектов класса</exception>
        public Student(
            string university, string faculty, string department, EducationForm educationForm, 
            string name, double averageScore, int graduationYear, int numbOfAbsent
        ) 
        {
            if (ObjectCounter + 1 == MEMORY_LIMIT) { 
                throw new TooManyObjectsException("Превышено максимальное количество объектов", MEMORY_LIMIT);
            }
            _id = ++_objectCounter;
            University = university;
            Faculty = faculty;
            Department = department;
            EduForm = educationForm;
            _name = name;
            _averageScore = averageScore;
            _yearOfGraduation = graduationYear;
            _numbOfAbsent = numbOfAbsent;
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        /// <exception cref="TooManyObjectsException">Исключение при превышении максимального числа объектов класса</exception>
        public Student()
        {
            if (ObjectCounter + 1 == MEMORY_LIMIT)
            {
                throw new TooManyObjectsException("Превышено максимальное количество объектов", MEMORY_LIMIT);
            }
            _id = ++_objectCounter;
        }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="university">Университет студента</param>
        /// <exception cref="TooManyObjectsException">Исключение при превышении максимального числа объектов класса</exception>
        public Student(string name)
        {
            if (ObjectCounter + 1 == MEMORY_LIMIT)
            {
                throw new TooManyObjectsException("Превышено максимальное количество объектов", MEMORY_LIMIT);
            }
            _id = ++_objectCounter;
            _name = name;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="university">Университет студента</param>
        /// <exception cref="TooManyObjectsException">Исключение при превышении максимального числа объектов класса</exception>
        public Student(string name, string university)
        {
            if (ObjectCounter + 1 == MEMORY_LIMIT)
            {
                throw new TooManyObjectsException("Превышено максимальное количество объектов", MEMORY_LIMIT);
            }
            _id = ++_objectCounter;
            _name = name;
            University = university;
            
        }

        /// <summary>
        /// Метод для вывода всех данных о студенте
        /// </summary>
        /// <returns>Строка с данными о студенте</returns>
        public override string ToString()
        {
            return $"Студент {Name}.\n" +
                $"Университет: {University}, факультет: {Faculty}, кафедра: {Department}, форма обучения: {EduForm.ToString()}.\n" +
                $"Год выпуска: {YearOfGraduation}, средний балл: {AverageScore}, количество прогулов: {NumbOfAbsent}\n";
        }

        /// <summary>
        /// Метод для вывода год выпуска студента в шеснадцатеричной форме
        /// </summary>
        /// <returns>Строка с годом выпуска студента в шеснадцатеричной форме</returns>
        public string getYearOfGraduationInHex() {
            return $"0x{YearOfGraduation:X}";
        }

        /// <summary>
        /// Метод для вывода имени студента
        /// </summary>
        /// <returns>Строка с именем студента</returns>
        public string getNameString()
        {
            return $"Имя студента: {Name}\n";
        }

        /// <summary>
        /// Метод для вывода университета студента
        /// </summary>
        /// <returns>Строка с названием университета студента</returns>
        public string getUniversityString()
        {
            return $"Университет студента: {University}\n";
        }

        /// <summary>
        /// Метод для вывода факультета студента
        /// </summary>
        /// <returns>Строка с названием факультета студента</returns>
        public string getFacultyString()
        {
            return $"Факультет студента: {Faculty}\n";
        }

        /// <summary>
        /// Метод для вывода кафедры студента
        /// </summary>
        /// <returns>Строка с названием кафедры студента</returns>
        public string getDepartmentString()
        {
            return $"Кафедра студента: {Department}\n";
        }

        /// <summary>
        /// Метод для вывода формы обучения студента
        /// </summary>
        /// <returns>Строка с формой обучения студента</returns>
        public string getEduFormString()
        {
            return $"Форма обучения студента: {EduForm.ToString()}\n";
        }

        /// <summary>
        /// Метод для вывода года выпуска студента
        /// </summary>
        /// <returns>Строка с годом выпуска студента</returns>
        public string getYearOfGraduationString()
        {
            return $"Год выпуска студента: {YearOfGraduation}\n";
        }

        /// <summary>
        /// Метод для вывода среднего балла студента
        /// </summary>
        /// <returns>Строка со средним баллом студента</returns>
        public string getAverageScoreString()
        {
            return $"Средний балл студента: {AverageScore}\n";
        }

        /// <summary>
        /// Метод для вывода количества пропусков студента
        /// </summary>
        /// <returns>Строка с количеством пропусков студента</returns>
        public string getNumbOfAbsentString()
        {
            return $"Количество прогулов студента: {NumbOfAbsent}\n";
        }




    }

    public enum EducationForm {
        Undefined = -1,
        FullTimeEducation,
        FullTimeAndPartTimeEducation,
        CorrespondenceEducation
    }
}
