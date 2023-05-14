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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public Professor()
        {

        }

        public Professor(string name, string surname, string username, string password) {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
        }
        public Professor(int id, string name, string surname, string username, string password) : base(id, name, surname, username, password) { }

        public Professor(string username, string password)
        {
            this.Username = username;
            this.Password = password;

            OleDbDataReader reader = isUsernameAndPasswordValid(username, password);
            
            reader.Read();
                  
            this.Id = Convert.ToInt32(reader["Professor_ID"].ToString());
            this.Name = reader["First_Name"].ToString();
            this.Surname = reader["Last_Name"].ToString();

            OleDbConnection con = new OleDbConnection(connection);

            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            string sql = "SELECT * FROM Courses WHERE Course_ID IN (SELECT Course_ID from Professors_Courses WHERE Professor_ID = ?)";

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameterCollection paramCollection = cmd.Parameters;
            paramCollection.Add(new OleDbParameter("Professor_ID", this.Id));

            using (OleDbDataReader courseReader = cmd.ExecuteReader())
            {


                if (courseReader.HasRows)
                {
                    while (courseReader.Read())
                    {
                        coursesIds.Add(courseReader["Course_ID"].ToString());
                        courses.Add(courseReader["Course_Name"].ToString());
                    }

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

            String sql = "SELECT * FROM Professors WHERE Username = ? AND Password = ?";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameterCollection paramCollection = cmd.Parameters;
            paramCollection.Add(new OleDbParameter("Username", username));
            paramCollection.Add(new OleDbParameter("Password", password));

            OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
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

            foreach (Student stud in student.readStudents())
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
        public List<int> getScores()
        {
            List<int> gradeList = new List<int>();

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

                if (inputs.Length != 2)
                        throw new InvalidInputException("The input given was not correctly written!\nThe format is: STUDENTID,GRADE");

                 if (getStudentFromID(Convert.ToInt32(inputs[0])) == null)
                        throw new InvalidInputException("The student whose ID you entered is not enrolled in the course!");

                using (OleDbConnection con = new OleDbConnection(connection))
                {

                    if (con.State != System.Data.ConnectionState.Open)
                    {
                        con.Open();
                    }
                    OleDbCommand command = new OleDbCommand("select count(*) from Grades where Student_ID = ? AND Course_ID = ?", con);

                    OleDbParameterCollection paramCollection = command.Parameters;
                    paramCollection.Add(new OleDbParameter("Student_ID", inputs[0]));
                    paramCollection.Add(new OleDbParameter("Course_ID", activeCourseId));
                    int result = Convert.ToInt32(command.ExecuteScalar());

                    string sql;
                    if (result == 0)
                    {
                        sql = "INSERT INTO Grades (Grade_Score, Student_ID, Course_ID) VALUES (?, ?, ?)";
                    }
                    else
                    {
                        sql = "UPDATE Grades SET Grade_Score = ? WHERE Student_ID = ? AND Course_ID = ?";
                    }

                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Grade_Score", inputs[1]);
                    cmd.Parameters.AddWithValue("@Student_ID", inputs[0]);
                    cmd.Parameters.AddWithValue("@Course_ID", activeCourseId);
                    cmd.ExecuteNonQuery();
                }
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
            List<int> gradeList = getScores();

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
            List<int> gradeList = getScores();

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
            List<int> gradeList = getScores();

            double total = 0.0;
            if (gradeList.Count == 0)
                return total;

            foreach (int grade in gradeList)
                total += grade;

            return total / gradeList.Count;
        }

        public void setActiveCourseId()
        {
            if (ActiveCourse != null)
            {
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    if (con.State != System.Data.ConnectionState.Open)
                    {
                        con.Open();
                    }

                    String sql = "SELECT * FROM Courses WHERE Course_Name = ?";


                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    OleDbParameterCollection paramCollection = cmd.Parameters;
                    paramCollection.Add(new OleDbParameter("Course_Name", activeCourse));
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                activeCourseId = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
        }

        public List<Professor> readProfessors()
        {
            List<Professor> professors = new List<Professor>();

            using (OleDbConnection con = new OleDbConnection(connection))
            {

                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                String sql = "SELECT * FROM Professors";

                OleDbCommand cmd = new OleDbCommand(sql, con);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.HasRows)

                        while (reader.Read())
                        {
                            int professorId = Convert.ToInt32(reader["Professor_ID"]);
                            string table_firstName = reader["First_Name"].ToString();
                            string table_lastName = reader["Last_Name"].ToString();
                            string table_username = reader["Username"].ToString();
                            string table_password = reader["Password"].ToString(); ;

                            Professor prof = new Professor(professorId, table_firstName, table_lastName, table_username,
                                table_password);

                            OleDbCommand professorCoursesTable = new OleDbCommand
                            ("SELECT Course_ID FROM Professors_Courses WHERE Professor_ID = ?", con);

                            OleDbParameterCollection paramCollection = professorCoursesTable.Parameters;
                            paramCollection.Add(new OleDbParameter("Professor_ID", professorId));
                            using (OleDbDataReader readerProfessorCoursesTable = professorCoursesTable.ExecuteReader())
                            {

                                while (readerProfessorCoursesTable.Read())
                                {
                                    int table_courseID = Convert.ToInt32(readerProfessorCoursesTable["Course_ID"]);

                                    OleDbCommand coursesTable = new OleDbCommand("SELECT Course_Name FROM Courses WHERE Course_ID = ?", con);
                                    OleDbParameterCollection coursesParamCollection = coursesTable.Parameters;
                                    coursesParamCollection.Add(new OleDbParameter("Course_ID", table_courseID));
                                    using (OleDbDataReader readerCoursesTable = coursesTable.ExecuteReader())
                                    {
                                        readerCoursesTable.Read();
                                        prof.Courses.Add(readerCoursesTable["Course_Name"].ToString());
                                    }
                                }
                            }
                            professors.Add(prof);
                        }

                }
            }
            return professors;
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