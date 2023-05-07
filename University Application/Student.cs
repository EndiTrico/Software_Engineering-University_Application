using System;
using System.Collections.Generic;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using University_Application;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace University_Application
{
    public class Student : Person, Login
    {
        public string major;
        public List<string> courses = new List<string>();

        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database_University.mdb";

        public string Major { set => major = value; get => major; }

        public List<string> Courses { set => courses = value; get => courses; }

        public Student()
        {

        }

        public Student(int studentID, string name, string surname, string username, string password, string major, List<String> courses) : base(studentID, name, surname, username, password)
        {
            this.Major = major;
            this.Courses = courses;
        }

        public Student(int studentID, string name, string surname, string username, string password, string major) : base(studentID, name, surname, username, password)
        {
            this.Major = major;
        }

        public Student(string name, string surname, string username, string password, string major)

        {
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.Major = major;
        }

        public Student(string username, string password)
        {
            this.Username = username;
            this.Password = password;

            OleDbConnection con = new OleDbConnection(connectionString);
            con.Open();

            OleDbDataReader reader = isUsernameAndPasswordValid(username, password);
            reader.Read();
            this.id = Convert.ToInt32(reader["Student_ID"].ToString());
            this.Name = reader["First_Name"].ToString();
            this.Surname = reader["Last_Name"].ToString();

            String sql = "SELECT * FROM Courses WHERE Course_Id IN (SELECT Course_Id from Students_Courses WHERE Student_Id=" + this.Id + ")";

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader courseReader = cmd.ExecuteReader();

            if (courseReader.HasRows)
            {
                while (courseReader.Read())
                {
                    courses.Add(courseReader["Course_Name"].ToString());
                }

            }
            courseReader.Close();
            con.Close();
        }

        // Method to check the username and password
        public OleDbDataReader isUsernameAndPasswordValid(string username, string password)
        {
            OleDbConnection con = new OleDbConnection(connectionString);

            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Students WHERE Username = ? AND Password = ?", con);
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

        // DONE Method to read the Student File
        public List<Student> readStudents()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string sql = @"
                SELECT s.Student_ID, s.First_Name, s.Last_Name, s.Username, s.Password, s.Major, c.Course_Name
                FROM (Students s LEFT JOIN Students_Courses sc ON s.Student_ID = sc.Student_ID)
                LEFT JOIN Courses c ON sc.Course_ID = c.Course_ID";

                var students = new Dictionary<int, Student>();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int studentID = Convert.ToInt32(reader["Student_ID"].ToString());

                            if (!students.TryGetValue(studentID, out var student))
                            {
                                student = new Student
                                {
                                    Id = studentID,
                                    Name = reader["First_Name"].ToString(),
                                    Surname = reader["Last_Name"].ToString(),
                                    Username = reader["Username"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    Major = reader["Major"].ToString(),
                                    Courses = new List<string>()
                                };

                                students.Add(studentID, student);
                            }

                            student.Courses.Add(reader["Course_Name"].ToString());
                        }
                    }
                }
                return students.Values.ToList();
            }
        }

        // DONE Method to show all the university courses
        public List<string> showAllCourses()
        {
            List<string> allCourses = new List<string>();

            foreach (Courses course in new Courses().readCourses())
            {
                allCourses.Add(course.CourseName);
            }
            return allCourses;
        }

        // DONE
        // Method to show the grades for the student
        public List<string> showGrades()
        {
            List<string> myGrades = new List<string>();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                foreach (Grades grades in new Grades().readGradesForAStudent(this.Id))
                {
                    OleDbCommand coursesTable = new OleDbCommand("SELECT Course_Name FROM Courses WHERE Course_ID = ?", connection);
                    OleDbParameterCollection paramCollection = coursesTable.Parameters;
                    paramCollection.Add(new OleDbParameter("Course_ID", grades.CourseID));

                    using (OleDbDataReader readerCoursesTable = coursesTable.ExecuteReader())
                    {
                        readerCoursesTable.Read();
                        myGrades.Add(readerCoursesTable["Course_Name"].ToString() + " " + grades.Score);
                    }
                }
            }
            return myGrades;
        }

        // DONE Write the course in the file
        public void enroll(string courseName, int studID)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                OleDbCommand coursesTable = new OleDbCommand("SELECT Course_ID from Courses WHERE Course_Name = @CourseName", connection);
                coursesTable.Parameters.AddWithValue("@Student_ID", courseName);

                using (OleDbDataReader readerCoursesTable = coursesTable.ExecuteReader())
                {
                    readerCoursesTable.Read();
                    OleDbCommand studentsCoursesTable = new OleDbCommand("INSERT INTO Students_Courses VALUES (@StudentID, @CourseID)", connection);
                    studentsCoursesTable.Parameters.AddWithValue("@StudentID", studID);
                    studentsCoursesTable.Parameters.AddWithValue("@CourseID", Convert.ToInt32(readerCoursesTable["Course_ID"].ToString()));
                    int rowsAffected = studentsCoursesTable.ExecuteNonQuery();
                }
            }
        }

        // DONE Drop a course
        public void drop(string courseName, int studid)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                OleDbCommand coursesTable = new OleDbCommand("SELECT Course_ID from Courses WHERE Course_Name = @CourseName", connection);
                coursesTable.Parameters.AddWithValue("@CourseName", courseName);

                using (OleDbDataReader readerCoursesTable = coursesTable.ExecuteReader())
                {
                    readerCoursesTable.Read();
                    OleDbCommand studentsCoursesTable = new OleDbCommand("DELETE FROM Students_Courses WHERE Student_ID = @StudentID AND Course_ID = @CourseID", connection);
                    studentsCoursesTable.Parameters.AddWithValue("@StudentID", studid);
                    studentsCoursesTable.Parameters.AddWithValue("@CourseID", Convert.ToInt32(readerCoursesTable["Course_ID"].ToString()));
                    int rowsAffected = studentsCoursesTable.ExecuteNonQuery();
                }
            }
        }

        // DONE Method to show all courses, except the courses that he is in
        public List<string> allCoursesExcludingStudentCourses()
        {
            List<string> availableCourses = new List<string>();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string excludedCourseNameString = string.Join(",", Courses.Select(x => $"'{x}'"));
                OleDbCommand coursesTable = new OleDbCommand($"SELECT Course_Name FROM Courses WHERE Course_Name NOT IN ({excludedCourseNameString})", connection);

                using (OleDbDataReader readerCoursesTable = coursesTable.ExecuteReader())
                {

                    while (readerCoursesTable.Read())
                    {
                        availableCourses.Add(readerCoursesTable.GetString(0));
                    }
                }
            }
            return availableCourses;
        }

        // DONE
        public List<string> showStudentCredits()
        {
            List<string> myCredits = new List<string>();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand(@"SELECT c.Course_Name, c.Credits FROM Courses c 
                INNER JOIN Students_Courses sc ON c.Course_ID = sc.Course_ID WHERE sc.Student_ID = @StudentID", connection);
                command.Parameters.AddWithValue("@StudentID", Id);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        myCredits.Add(reader["Course_Name"].ToString() + " - " + reader["Credits"].ToString() + " credits");
                    }
                }
            }
            return myCredits;
        }

        // DONE
        public List<string> showAllCredits()
        {    
            List<string> allCourses = new List<string>();

            foreach (Courses course in new Courses().readCourses())
            {
                allCourses.Add(course.CourseName + " - " + course.Credits + " credits");
            }
            return allCourses;
        }


        // DONE
        public double showGPA()
        {
            double[] gradeCredits = new double[2];

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand(
                    @"SELECT g.Grade_Score, c.Credits FROM Grades g
                    INNER JOIN Courses c ON g.Course_ID = c.Course_ID
                    WHERE g.Student_ID = @StudentID", connection);

                command.Parameters.AddWithValue("@StudentID", Id);
                OleDbDataReader gradesReader = command.ExecuteReader();
                double grade = 0.00;

                if (gradesReader.HasRows)
                {
                    while (gradesReader.Read())
                    {
                        grade = Convert.ToInt32(gradesReader["Grade_Score"].ToString());

                        if (grade < 59.5)
                        {
                            grade = 0.00;
                        }
                        else if (grade < 62.5)
                        {
                            grade = 0.67;
                        }
                        else if (grade < 66.5)
                        {
                            grade = 1.00;
                        }
                        else if (grade < 69.5)
                        {
                            grade = 1.33;
                        }
                        else if (grade < 72.5)
                        {
                            grade = 1.67;
                        }
                        else if (grade < 76.5)
                        {
                            grade = 2.00;
                        }
                        else if (grade < 79.5)
                        {
                            grade = 2.33;
                        }
                        else if (grade < 82.5)
                        {
                            grade = 2.67;
                        }
                        else if (grade < 86.5)
                        {
                            grade = 3.00;
                        }
                        else if (grade < 89.5)
                        {
                            grade = 3.33;
                        }
                        else if (grade < 95.5)
                        {
                            grade = 3.67;
                        }
                        else
                        {
                            grade = 4.00;
                        }

                        gradeCredits[0] += grade * Convert.ToInt32(gradesReader["Credits"].ToString());
                        gradeCredits[1] += Convert.ToInt32(gradesReader["Credits"].ToString());
                    }
                }

                gradesReader.Close();

                if (gradeCredits[1] != 0)
                {
                    return Math.Round(gradeCredits[0] / gradeCredits[1], 2);
                }

                return -1;
            }
        }

        public override string ToString()
        {
            if (this.Courses == null)
                return this.Name + "," + this.Surname + "," + this.Username + "," + this.Password + "," +
                this.Id + "," + this.Major;
            else
            {
                string result = this.Name + "," + this.Surname + "," + this.Username + "," + this.Password + "," +
                this.Id + "," + this.Major;
                for (int j = 0; j < this.Courses.Count; j++)
                {
                    result += "," + this.Courses[j];
                }
                return result;
            }
        }
    }
}