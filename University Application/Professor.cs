using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using University_Application;

namespace University_Application
{
    public class Professor : Person, Login
    {
        // data fields
        private List<string> courses = new List<string>();
        private string activeCourse;
        private static List<Professor> loggedProfessors = new List<Professor>();

        string[] path = Environment.CurrentDirectory.Split(new string[] { "bin" }, StringSplitOptions.None);


        // attributes
        public List<string> Courses { get => courses; set => courses = value; }
        public string ActiveCourse { get => activeCourse; set => activeCourse = value; }
        public static List<Professor> LoggedProfessors { get => loggedProfessors; set => loggedProfessors = value; }

        // constructors
        public Professor(string name, string surname, string username, string password) : base(name, surname, username, password) { }

        public Professor(string username, string password)
        {
            this.Username = username;
            this.Password = password;

            if (isUsernameAndPasswordValid(Username, Password))
            {
                foreach (Professor prof in readProfessorFile())
                {
                    if (prof.Username.Equals(username) && prof.Password.Equals(password))
                    {
                        this.Name = prof.Name;
                        this.Surname = prof.Surname;
                        this.Courses = prof.Courses;
                        break;
                    }
                }
            }
        }

        // method to determine if the login info is valid
        public bool isUsernameAndPasswordValid(string username, string password)
        {
            List<Professor> list = readProfessorFile();

            foreach (Professor prof in list)
            {
                if (prof.Username.Equals(username) && prof.Password.Equals(password))
                    return true;
            }
            throw new InvalidLoginInfoException("Username and Password do not match!");
        }

        // method to get the most recently logged professor
        public static Professor getRecentProfessor()
        {
            return LoggedProfessors.Last();
        }

        // method to read data from Professor File
        public List<Professor> readProfessorFile()
        {

            List<Professor> list = new List<Professor>();

            using (StreamReader reader = new StreamReader(path[0] + "ProfessorFile.txt"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');

                    Professor prof = new Professor(data[0], data[1], data[2], data[3]);

                    for (int i = 4; i < data.Length; i++)
                        prof.Courses.Add(data[i]);

                    list.Add(prof);
                }
                reader.Close();
            }
            return list;
        }

        // method to show the students of a professor's course

        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();
            Student student = new Student();

            foreach (Student stud in student.readStudentFile())
            {
                if (stud.Courses.Contains(ActiveCourse))
                    students.Add(stud);
            }

            return students;
        }

        // method to get student who is in the course from given ID
        public Student getStudentFromID(string Id)
        {
            foreach (Student student in getStudents())
            {
                if (student.StudentID.Equals(Id))
                    return student;
            }
            return null;
        }

        // method to get grades of course
        public List<Grades> getGrades()
        {
            List<Grades> gradeList = new List<Grades>();
            Grades grade = new Grades();

            foreach (Grades grades in grade.readGradesFile())
            {
                if (grades.Subject.Equals(ActiveCourse))
                    gradeList.Add(grades);
            }

            return gradeList;
        }


        // method to get all the scores of a professor's course
        public List<Double> getScores()
        {
            List<Double> gradeList = new List<Double>();

            foreach (Grades grades in getGrades())
            {
                gradeList.Add(grades.Grade);
            }
            return gradeList;
        }

        // method to add grades of a professor's course
        public void AddGrades(string[] data)
        {
            if (data.Length == 0)
                throw new InvalidInputException("You did not enter any grades!\nThe format is: STUDENTID,GRADE");

            using (StreamWriter writer = new StreamWriter(path[0] + "GradesFile.txt", true))
            {

                foreach (string grade in data)
                {
                    var inputs = grade.Split(',');

                    if (inputs.Length != 2)
                        throw new InvalidInputException("The input given was not correctly written!\nThe format is: STUDENTID,GRADE");

                    if (getStudentFromID(inputs[0]) == null)
                        throw new InvalidInputException("The student whose ID you entered is not enrolled in the course!");

                    writer.Write("\n" + Professor.getRecentProfessor().ActiveCourse + "," + grade);
                }

                writer.Close();
            }
        }

        // method to show passing students
        public List<Student> showPassingStudents()
        {
            List<Student> studentList = new List<Student>();
            List<string> studentIds = new List<string>();

            foreach (Grades grade in getGrades())
            {
                if (grade.Grade > 59)
                    studentIds.Add(grade.StudentID);
            }

            foreach (string Id in studentIds)
            {
                studentList.Add(getStudentFromID(Id));
            }

            return studentList;
        }

        // method to show failing students
        public List<Student> showFailingStudents()
        {
            List<Student> studentList = new List<Student>();
            List<string> studentIds = new List<string>();

            foreach (Grades grade in getGrades())
            {
                if (grade.Grade <= 59)
                    studentIds.Add(grade.StudentID);
            }

            foreach (string Id in studentIds)
            {
                studentList.Add(getStudentFromID(Id));
            }

            return studentList;
        }

        // method to get the name of the lowest scoring student
        public string showLowestScoringStudent()
        {
            Student lowestScoring = new Student();

            foreach (Grades grade in getGrades())
            {
                if (grade.Grade == showMinGrade())
                {
                    lowestScoring = getStudentFromID(grade.StudentID);
                    break;
                }
            }

            return lowestScoring.Name + " " + lowestScoring.Surname;
        }

        // method to get the name of the highest scoring student
        public string showHighestScoringStudent()
        {
            Student highestScoring = new Student();

            foreach (Grades grade in getGrades())
            {
                if (grade.Grade == showMaxGrade())
                {
                    highestScoring = getStudentFromID(grade.StudentID);
                    break;
                }
            }

            return highestScoring.Name + " " + highestScoring.Surname;
        }


        // method to get the minimum grade of a professor's course
        public double showMinGrade()
        {
            List<Double> gradeList = getScores();

            double min = gradeList.ElementAt(0);

            for (int i = 1; i < gradeList.Count; i++)
            {
                if (gradeList.ElementAt(i) < min)
                {
                    min = gradeList.ElementAt(i);
                }
            }

            return min;
        }

        // method to get the maximum grade of a professor's course

        public double showMaxGrade()
        {
            List<Double> gradeList = getScores();

            double max = gradeList.ElementAt(0);
            for (int i = 1; i < gradeList.Count; i++)
            {
                if (gradeList.ElementAt(i) > max)
                {
                    max = gradeList.ElementAt(i);
                }
            }
            return max;
        }


        // method to get the average grade of a professor's course

        public double showAverage()
        {
            List<Double> gradeList = getScores();

            double total = 0.0;
            if (gradeList.Count == 0)
                return total;

            foreach (Double grade in gradeList)
                total += grade;

            return total / gradeList.Count;
        }


        // method to get a string representation of Professor
        public override string ToString()
        {
            if (this.Courses == null)
                return this.Name + "," + this.Surname + "," + this.Username + "," + this.Password;
            else
            {

                string result = this.Name + "," + this.Surname + "," + this.Username + "," + this.Password;
                for (int i = 0; i < this.Courses.Count; i++)
                {
                    result += "," + this.Courses[i];
                }
                return result;
            }
        }
    }
}