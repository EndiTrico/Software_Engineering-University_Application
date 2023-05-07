using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Application
{
    public class Admin
    {
        private static string username = "admin";
        private static string password = "admin123";
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database_University.mdb";

        public List<Professor> professorList = new List<Professor>();
        public List<Student> studentList = new List<Student>();
        public List<Courses> coursesList = new List<Courses>();

        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }

        public Admin()
        {
            this.readDatabase();
        }

        //check the validity of the username and the password of the admin
        public bool isUsernameAndPasswordValid(string username, string password)
        {
            if (username.Equals(Username) && password.Equals(Password))
                return true;
            throw new InvalidLoginInfoException("Username and Password do not match!");
        }

        public void addProfessor(Professor professor)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                using (OleDbCommand professorTable = new OleDbCommand("INSERT INTO Professors ([First_Name], [Last_Name], [Username], [Password]) VALUES (?, ?, ?, ?)", connection))
                {
                    professorTable.Parameters.AddWithValue("@a", professor.Name);
                    professorTable.Parameters.AddWithValue("@b", professor.Surname);
                    professorTable.Parameters.AddWithValue("@c", professor.Username);
                    professorTable.Parameters.AddWithValue("@d", professor.Password);

                    int rowsAffected = professorTable.ExecuteNonQuery();
                }
            }
            readDatabase();
        }

        // DONE
        public void removeProfessor(Professor professor)
        {
            professorList.RemoveAt(professorList.IndexOf(professor));

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                using (OleDbCommand professorsTable = new OleDbCommand("DELETE FROM Professors WHERE Professor_ID = ?", connection))
                {
                    professorsTable.Parameters.AddWithValue("@id", professor.Id);
                    int rowsAffected = professorsTable.ExecuteNonQuery();
                }
            }
        }

        // DONE
        public void addStudent(Student student)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                using (OleDbCommand studentsTable = new OleDbCommand("INSERT INTO Students ([First_Name], [Last_Name], [Username], [Password], [Major]) VALUES (@FirstName, @LastName, @Username, @Password, @Major)", connection))
                {
                    studentsTable.Parameters.AddWithValue("@FirstName", student.Name);
                    studentsTable.Parameters.AddWithValue("@LastName", student.Surname);
                    studentsTable.Parameters.AddWithValue("@Username", student.Username);
                    studentsTable.Parameters.AddWithValue("@Password", student.Password);
                    studentsTable.Parameters.AddWithValue("@Major", student.Major);

                    int rowsAffected = studentsTable.ExecuteNonQuery();
                }
            }
            
            readDatabase();
        }

        // DONE
        public void removeStudent(Student student)
        {
            studentList.RemoveAt(studentList.IndexOf(student));

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                using (OleDbCommand studentsTable = new OleDbCommand("DELETE FROM Students WHERE Student_ID = @id", connection))
                {
                    studentsTable.Parameters.AddWithValue("@id", student.Id);
                    int rowsAffected = studentsTable.ExecuteNonQuery();
                }
            }
        }

        public void addCourse(Courses course, int professorID)
        {
            int courseId;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                using (OleDbCommand coursesTable = new OleDbCommand("INSERT INTO Courses (Course_Name, Credits, Hours) VALUES (?, ?, ?)", connection))
                {
                    coursesTable.Parameters.AddWithValue("@a", course.CourseName);
                    coursesTable.Parameters.AddWithValue("@b", course.Credits);
                    coursesTable.Parameters.AddWithValue("@c", course.Hours);

                    int row = coursesTable.ExecuteNonQuery();
                }

                using (OleDbCommand coursesTable1 = new OleDbCommand("SELECT Course_ID from Courses WHERE Course_Name = ?", connection))
                {
                    coursesTable1.Parameters.AddWithValue("@CourseName", course.CourseName);

                    using (OleDbDataReader reader = coursesTable1.ExecuteReader())
                    {
                        reader.Read();
                        courseId = Convert.ToInt32(reader["Course_ID"].ToString());
                    }
                }

                using (OleDbCommand professorsStudentsTable = new OleDbCommand("INSERT INTO Professors_Courses Values (?, ?)", connection))
                {
                    professorsStudentsTable.Parameters.AddWithValue("@a", professorID);
                    professorsStudentsTable.Parameters.AddWithValue("@b", courseId);

                    int rowsAffected = professorsStudentsTable.ExecuteNonQuery();
                }
            }

            readDatabase();
        }

        public void removeCourse(Courses course)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                using (OleDbCommand coursesTable = new OleDbCommand("DELETE FROM Courses WHERE Course_ID = ?", connection))
                {
                    coursesTable.Parameters.AddWithValue("@id", course.Id);
                    int rowsAffected = coursesTable.ExecuteNonQuery();
                }
            }
        }

        private void readDatabase()
        {
            studentList = new Student().readStudents();
            professorList = new Professor().readProfessors();
            coursesList = new Courses().readCourses();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}