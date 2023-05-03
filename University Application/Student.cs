using System;
using System.Collections.Generic;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using University_Application;
using System.Data.OleDb;

namespace University_Application
{
    public class Student : Person, Login
    {
        public string major;
        public int studentID;
        public List<string> courses = new List<string>();

        string[] path = Environment.CurrentDirectory.Split(new string[] { "bin" }, StringSplitOptions.None);
        
        static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database_University.mdb";


        public int StudentID { set => studentID = value; get => studentID; }

        public string Major { set => major = value; get => major; }

        public List<string> Courses { set => courses = value; get => courses; }

        public Student()
        {

        }

        public Student(int studentID, string name, string surname, string username, string password,  string major, List<String> courses) : base(studentID, name, surname, username, password)
        {
            this.StudentID = studentID;
            this.Major = major;
            this.Courses = courses;
        }

        public Student(int studentID, string name, string surname, string username, string password,  string major) : base(studentID, name, surname, username, password)
        {
            this.StudentID = studentID;
            this.Major = major;
        }

        public Student(string username, string password)
        {
            if (isUsernameAndPasswordValid(username, password))
            {
                Username = username;
                Password = password;

                foreach (Student stud in readStudent())
                {
                    if (stud.Username.Equals(username) && stud.Password.Equals(password))
                    {
                        this.Name = stud.Name;
                        this.Surname = stud.Surname;
                        this.Username = stud.Username;
                        this.Password = stud.Password;
                        this.StudentID = stud.studentID;
                        this.Major = stud.Major;
                        this.Courses = stud.Courses;
                        break;
                    }
                }
            }
        }

        // Method to check the username and password
        public bool isUsernameAndPasswordValid(string username, string password)
        {
            List<Student> student = readStudent();

            foreach (Student stud in student)
            {
                if (stud.Username.Equals(username) && stud.Password.Equals(password))
                {
                    StudentID = stud.studentID;
                    return true;
                }
            }
            throw new InvalidLoginInfoException("Username and Password do not match!");
        }

        // DONE Method to read the Student File
        public List<Student> readStudent()
        {
            List<Student> studentList = new List<Student>();
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            OleDbCommand studentsTable = new OleDbCommand("SELECT * FROM Students", connection);
            OleDbDataReader readerStudentsTable = studentsTable.ExecuteReader();

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
                ("SELECT Course_ID FROM Students_Courses WHERE Student_ID=" + table_studentID , connection);
                OleDbDataReader readerStudentsCoursesTable = studentsCoursesTable.ExecuteReader();

                int table_courseID;
                while (readerStudentsCoursesTable.Read())
                {
                    table_courseID = Convert.ToInt32(readerStudentsTable["Course_ID"]);
                    
                    OleDbCommand coursesTable = new OleDbCommand("SELECT Course_Name FROM Courses WHERE Course_ID = @ID", connection);
                    coursesTable.Parameters.AddWithValue("@ID", table_courseID);
                    OleDbDataReader readerCoursesTable = studentsTable.ExecuteReader();

                    student.Courses.Add(readerCoursesTable.GetString(0));
                    readerCoursesTable.Close();
                }
                readerStudentsCoursesTable.Close();
                studentList.Add(student);
            }

            readerStudentsTable.Close();
            connection.Close();

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
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            
            foreach (Grades grades in new Grades().readGradesForAStudent(this.studentID))
            {
                OleDbCommand coursesTable = new OleDbCommand("SELECT Course_Name FROM Courses WHERE Course_ID=@ID", connection);
                coursesTable.Parameters.AddWithValue("@ID", grades.CourseID);
                OleDbDataReader readerCoursesTable = coursesTable.ExecuteReader();
                
                myGrades.Add(readerCoursesTable.GetString(0) + " " + grades.Score);

=               readerCoursesTable.Close();
            }
            connection.Close();
            return myGrades;
        }

        // Write the course in the file
        public void enroll(string courseName, int studID)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            OleDbCommand coursesTable = new OleDbCommand("SELECT Course_ID from Courses WHERE Course_Name=@CourseName)", connection);
            coursesTable.Parameters.AddWithValue("@Student_ID", "John");


            OleDbCommand command = new OleDbCommand("INSERT INTO Students_Courses (Student_ID, Student_ID) VALUES (@StudentID, @Course_ID)", connection);
            command.Parameters.AddWithValue("@Student_ID", "John");
            command.Parameters.AddWithValue("@Student_ID", "Doe");
            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();



            /*List<Student> student = readStudent();

            using (StreamWriter writer1 = new StreamWriter(path[0] + "StudentFile.txt"))
            {
                foreach (Student stud in student)
                {
                    writer1.Write(stud.Name + "," + stud.Surname + "," + stud.Username + "," + stud.Password + "," + stud.StudentID + "," + stud.Major);

                    if (stud.StudentID.Equals(studID) == true)
                    {
                        stud.Courses.Add(text);
                    }

                    foreach (String cour in stud.Courses)
                    {
                        writer1.Write("," + cour);
                    }
                    writer1.WriteLine();
                }
                writer1.Flush();
                writer1.Close();
            } */
        }

        // Drop a course
        public void drop(string text, string studid)
        {
            List<Student> student = readStudent();

            using (StreamWriter writer1 = new StreamWriter(path[0] + "StudentFile.txt", false))
            {
                foreach (Student stud in student)
                {
                    writer1.Write(stud.Name + "," + stud.Surname + "," + stud.Username + "," + stud.Password + "," + stud.StudentID + "," + stud.Major);

                    if (stud.studentID.Equals(studid) == true)
                    {
                        stud.Courses.Remove(text);
                    }

                    foreach (String cour in stud.Courses)
                    {
                        writer1.Write("," + cour);
                    }
                    writer1.WriteLine();
                }
                writer1.Flush();
                writer1.Close();
            }
        }

        // Method to show all courses, except the courses that he is in
        public List<string> allCoursesExcludingStudentCourses()
        {
            List<string> availableCourses = new List<string>();
            int token = 0;

            foreach (Course course in new Course().readCourses())
            {
                token = 0;

                foreach (string mycourse in Courses)
                {
                    if (mycourse.Equals(course.Subject))
                    {
                        token++;
                    }
                }

                if (token == 0)
                    availableCourses.Add(course.Subject);
            }
            return availableCourses;
        }

        // Method to check all student courses
        public List<string> showStudentCourses()
        {
            return Courses;
        }

        public List<string> showStudentCredits()
        {
            List<string> credits = new List<string>();

            foreach (Course course in new Course().readCourses())
            {
                foreach (string mycourse in Courses)
                {
                    if (course.Subject.Equals(mycourse))
                        credits.Add(course.Subject + " - " + course.Credits + " credits");
                }
            }
            return credits;
        }

        public List<string> showAllCredits()
        {
            List<string> allCourses = new List<string>();

            foreach (Course course in new Course().readCourses())
            {
                allCourses.Add(course.Subject + " - " + course.Credits + " credits");
            }
            return allCourses;
        }

        public string showGPA()
        {
            double gpa = 0;
            double token = 0;

            foreach (Course course in new Course().readCourses())
            {
                foreach (Grades grade in new Grades().readGradesFile())
                {
                    if (grade.StudentID.Equals(StudentID))
                    {
                        gpa += grade.GradeID * course.Credits;
                        token += course.Credits;
                    }
                }
            }

            if (token == 0)
            {
                return "No GPA";
            }
            gpa = gpa / token;

            return "My GPA is: " + Math.Round(gpa, 2);
        }

        public override string ToString()
        {
            if (this.Courses == null)
                return this.Name + "," + this.Surname + "," + this.Username + "," + this.Password + "," +
                this.StudentID + "," + this.Major;
            else
            {
                string result = "";
                result = this.Name + "," + this.Surname + "," + this.Username + "," + this.Password + "," +
                this.StudentID + "," + this.Major;
                for (int j = 0; j < this.Courses.Count; j++)
                {
                    result += "," + this.Courses[j];
                }
                return result;
            }
        }
    }
}