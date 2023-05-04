using System;
using System.Collections.Generic;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using University_Application;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace University_Application
{
    public class Student : Person, Login
    {
        public string major;
        public List<string> courses = new List<string>();

        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Utente\\Documents\\GitHub\\Software_Engineering-University_Application\\University Application\\Database_University.mdb";

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
                {/*
                    reader.Read();
                    this.id = Convert.ToInt32(reader["Student_ID"].ToString());
                    this.Name = reader["First_Name"].ToString();
                    this.Surname = reader["Last_Name"].ToString();
                    */return reader;
                }
                else
                {
                    throw new InvalidLoginInfoException("Username and Password do not match!");
                }
            
        }

        // DONE Method to read the Student File
        public List<Student> readStudents()
        {
            /*
            List<Student> studentList = new List<Student>();
            int table_studentID = 0;
            string table_firstName = "";
            string table_lastName = "";
            string table_username = "";
            string table_password = "";
            string table_major = "";
            string table_courseName = "";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(
                    "SELECT Students.Student_ID, First_Name, Last_Name, Username, Password, Major, Course_Name FROM Students " +
                    "INNER JOIN Students_Courses ON Students.Student_ID = Students_Courses.Student_ID " +
                    "INNER JOIN Courses ON Students_Courses.Course_ID = Courses.Course_ID", connection);

                Dictionary<int, List<string>> coursesByStudentId = new Dictionary<int, List<string>>();

               
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        table_studentID = Convert.ToInt32(reader["Student_ID"]);
                        table_firstName = reader["First_Name"].ToString();
                        table_lastName = reader["Last_Name"].ToString();
                        table_username = reader["Username"].ToString();
                        table_password = reader["Password"].ToString();
                        table_major = reader["Major"].ToString();
                        table_courseName = reader["Course_Name"].ToString();

                        if (!coursesByStudentId.ContainsKey(table_studentID))
                        {
                            coursesByStudentId[table_studentID] = new List<string>();
                        }

                        coursesByStudentId[table_studentID].Add(table_courseName);
                    }
                }

                foreach (KeyValuePair<int, List<string>> pair in coursesByStudentId)
                {
                    int studentID = pair.Key;
                    List<string> courseNames = pair.Value;

                    Student student = new Student(studentID, table_firstName, table_lastName, table_username,
                        table_password, table_major);
                    student.Courses = courseNames;
                    studentList.Add(student);
                }
            }

            return studentList;
            */

            List<Student> studentList = new List<Student>();
            
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand studentsTable = new OleDbCommand("SELECT * FROM Students", connection);
                
                using (OleDbDataReader readerStudentsTable = studentsTable.ExecuteReader())
                {
                    while (readerStudentsTable.Read())
                    {
                        int table_studentID = Convert.ToInt32(readerStudentsTable["Student_ID"]);
                        string table_firstName = readerStudentsTable["First_Name"].ToString();
                        string table_lastName = readerStudentsTable["Last_Name"].ToString();
                        string table_username = readerStudentsTable["Username"].ToString();
                        string table_password = readerStudentsTable["Password"].ToString();
                        string table_major = readerStudentsTable["Major"].ToString();

                        Student student = new Student(table_studentID, table_firstName, table_lastName, table_username,
                            table_password, table_major);

                        OleDbCommand studentsCoursesTable = new OleDbCommand
                        ("SELECT Course_ID FROM Students_Courses WHERE Student_ID=" + table_studentID, connection);
                        
                        using (OleDbDataReader readerStudentsCoursesTable = studentsCoursesTable.ExecuteReader())
                        {
                            int table_courseID;
                            while (readerStudentsCoursesTable.Read())
                            {
                                table_courseID = Convert.ToInt32(readerStudentsCoursesTable["Course_ID"]);

                                OleDbCommand coursesTable = new OleDbCommand("SELECT Course_Name FROM Courses WHERE Course_ID = @ID", connection);
                                coursesTable.Parameters.AddWithValue("@ID", table_courseID);
                                
                                using (OleDbDataReader readerCoursesTable = coursesTable.ExecuteReader())
                                {
                                    if (readerCoursesTable.Read())
                                    {
                                        student.Courses.Add(readerCoursesTable.GetString(0));
                                    }

                                }
                            }
                        }
                        studentList.Add(student);
                    }

                }
            }
            return studentList;
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
                OleDbCommand coursesTable = new OleDbCommand("SELECT Course_Name FROM Courses WHERE Course_Name NOT IN ({excludedCourseNameString})", connection);
                
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

        // Method to check all student courses
        public List<string> showStudentCourses()
        {
            return Courses;
        }

        // DONE
        public List<string> showStudentCredits()
        {
            List<string> credits = new List<string>();

            foreach (Courses course in new Courses().readCourses())
            {
                foreach (string mycourse in Courses)
                {
                    if (course.CourseName.Equals(mycourse))
                        credits.Add(course.CourseName + " - " + course.Credits + " credits");
                }
            }
            return credits;
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
        public string showGPA()
        {
            int[] creditsOfGradedCoursesAndScore = new int[2];
            double gpa;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                foreach (Grades grade in new Grades().readGradesForAStudent(Id))
                {
                    OleDbCommand coursesTable = new OleDbCommand("SELECT Credits from Courses WHERE Course_ID = @CourseID", connection);
                    coursesTable.Parameters.AddWithValue("@CourseID", grade.CourseID);
                    
                    using (OleDbDataReader readerCoursesTable = coursesTable.ExecuteReader())
                    {
                        readerCoursesTable.Read();
                        creditsOfGradedCoursesAndScore[0] += Convert.ToInt32(readerCoursesTable["Credits"].ToString());
                        creditsOfGradedCoursesAndScore[1] += Convert.ToInt32(grade.Score);
                    }
                }
            }

            if (creditsOfGradedCoursesAndScore[0] == 0)
            {
                return "No GPA";
            }
            gpa = creditsOfGradedCoursesAndScore[1] / creditsOfGradedCoursesAndScore[0];

            return "My GPA is: " + Math.Round(gpa, 2);
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