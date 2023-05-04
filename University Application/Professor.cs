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
using System.Data.OleDb;

namespace University_Application
{
    public class Professor : Person, Login
    {
        // data fields
        private String connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database_University.mdb";
        private List<string> courses = new List<string>();
        private List<string> coursesIds = new List<string>();
        private string activeCourse;
        private int activeCourseId;
        private static List<Professor> loggedProfessors = new List<Professor>();


        // attributes
        public List<string> Courses { get => courses; set => courses = value; }
        public string ActiveCourse { get => activeCourse; set => activeCourse = value; }
        public static List<Professor> LoggedProfessors { get => loggedProfessors; set => loggedProfessors = value; }

        // constructors
        public Professor(int id, string name, string surname, string username, string password) : base(id, name, surname, username, password) { }

        public Professor(string username, string password)
        {
            this.Username = username;
            this.Password = password;

            OleDbDataReader reader = isUsernameAndPasswordValid(username, password);
            reader.Read();
                  
            this.id = Convert.ToInt32(reader["Professor_ID"].ToString());
            this.Name = reader["First_Name"].ToString();
            this.Surname = reader["Last_Name"].ToString();

            OleDbConnection con = new OleDbConnection(connection);

            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            String sql = "SELECT * FROM Courses WHERE Course_Id = (SELECT Course_Id from Professors_Courses WHERE Professor_Id="+this.ID+")";

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader courseReader = cmd.ExecuteReader();


            if (courseReader.HasRows)
            {
               while(courseReader.Read())
                {
                    coursesIds.Add(courseReader["Course_Id"].ToString());
                    courses.Add(courseReader["Course_Name"].ToString());
                }

            }

        }
           

        // method to determine if the login info is valid
        public OleDbDataReader isUsernameAndPasswordValid(string username, string password)
        {
            OleDbConnection con = new OleDbConnection(connection);

            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            String sql = "SELECT * FROM Professors WHERE Username =" + username + " AND Password=" + password + "'";

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                con.Close();
                return reader;

            }
            else
            {
                throw new InvalidLoginInfoException("Username and Password do not match!");
            }
        }

        // method to get the most recently logged professor
        public static Professor getRecentProfessor()
        {
            return LoggedProfessors.Last();
        }

        // method to show the students of a professor's course
        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();
            Student student = new Student();

            foreach (Student stud in student.readStudent())
            {
                if (stud.Courses.Contains(ActiveCourse))
                    students.Add(stud);
            }

            return students;
        }

        // method to get student who is in the course from given ID
        public Student getStudentFromID(int Id)
        {
            foreach (Student student in getStudents())
            {
                if (student.Id.Equals(Id))
                    return student;
            }
            return null;
        }

        // method to get grades of course
        public List<Grades> getGrades()
        {
            List<Grades> gradeList = new List<Grades>();
            Grades grade = new Grades();

            foreach (Grades grades in grade.readGrades())
            {
                if (grades.CourseID.Equals(activeCourseId))
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
                gradeList.Add(grades.Score);
            }
            return gradeList;
        }

        // method to add grades of a professor's course
        public void AddGrades(string[] data)
        {
            if (data.Length == 0)
                throw new InvalidInputException("You did not enter any grades!\nThe format is: STUDENTID,GRADE");

         

                foreach (string grade in data)
                {
                    var inputs = grade.Split(',');

                OleDbConnection con = new OleDbConnection(connection);
               
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }


                if (inputs.Length != 2)
                        throw new InvalidInputException("The input given was not correctly written!\nThe format is: STUDENTID,GRADE");

                    if (getStudentFromID(Convert.ToInt32(inputs[0])) == null)
                        throw new InvalidInputException("The student whose ID you entered is not enrolled in the course!");

                String sql = "INSERT INTO TABLE Grades(Student_ID, Course_ID, Grade_Score) VALUES ("+inputs[0]+","+activeCourseId+","+ inputs[1]+")";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataReader reader = cmd.ExecuteReader();
            }

        }

        // method to show passing students
        public List<Student> showPassingStudents()
        {
            List<Student> studentList = new List<Student>();
            List<int> studentIds = new List<int>();

            foreach (Grades grade in getGrades())
            {
                if (grade.Score > 59)
                    studentIds.Add(grade.StudentID);
            }

            foreach (int Id in studentIds)
            {
                studentList.Add(getStudentFromID(Id));
            }

            return studentList;
        }

        // method to show failing students
        public List<Student> showFailingStudents()
        {
            List<Student> studentList = new List<Student>();
            List<int> studentIds = new List<int>();

            foreach (Grades grade in getGrades())
            {

                if (grade.Score <= 59)
                    studentIds.Add(grade.StudentID);
            }

            foreach (int Id in studentIds)
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
                if (grade.Score == showMinGrade())
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
                if (grade.Score == showMaxGrade())
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

        private void setActiveCourseId()
        {
            if (ActiveCourse != null)
            {
                OleDbConnection con = new OleDbConnection(connection);
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }

                String sql = "SELECT * FROM Courses WHERE Course_Name=" + ActiveCourse;

                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        activeCourseId = reader.GetInt32(0);
                    }
                }
            }

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