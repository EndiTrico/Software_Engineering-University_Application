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
        private String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database_University.mdb";

        public List<Professor> professorList = new List<Professor>();
        public List<Student> studentList = new List<Student>();
        public List<Courses> coursesList = new List<Courses>();

        string[] path = Environment.CurrentDirectory.Split(new string[] { "bin" }, StringSplitOptions.None);

        public Admin()
        {
            this.readDatabase();
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        //check the validity of the username and the password of the admin
        public bool isUsernameAndPasswordValid(string username, string password)
        {
            if (username.Equals(this.getUsername()) && password.Equals(this.getPassword()))
                return true;
            throw new InvalidLoginInfoException("Username and Password do not match!");
        }

        public void addProfessor(Professor professor)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand professorTable = new OleDbCommand("INSERT INTO Professors (First_Name, Last_Name, Username, Password) VALUES (?, ?, ?, ?)", connection))
                {
                    professorTable.Parameters.AddWithValue("?", professor.Name);
                    professorTable.Parameters.AddWithValue("?", professor.Surname);
                    professorTable.Parameters.AddWithValue("?", professor.Username);
                    professorTable.Parameters.AddWithValue("?", professor.Password);

                    connection.Open();
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
                using (OleDbCommand professorsTable = new OleDbCommand("DELETE FROM Professors WHERE Professor_ID = @id", connection))
                {
                    professorsTable.Parameters.AddWithValue("@id", professor.Id);
                    int rowsAffected = professorsTable.ExecuteNonQuery();
                }
            }


            /*string name = prof.Name;
            string surname = prof.Surname;
            for (int i = 0; i < professorList.Count; i++)
            {
                if (prof.Equals(professorList.ElementAt(i)))
                {
                    professorList.RemoveAt(i);
                }
            }
            for (int j = 0; j < coursesList.Count; j++)
            {
                if (coursesList.ElementAt(j).Professor.Equals(name + " " + surname))
                {
                    for (int k = 0; k < studentList.Count; k++)
                    {
                        if (studentList.ElementAt(k).Courses.Count > 0)
                        {
                            for (int x = 0; x < studentList.ElementAt(k).Courses.Count; x++)
                            {
                                if (coursesList.ElementAt(j).Subject.Equals(studentList.ElementAt(k).Courses[x]))
                                    studentList.ElementAt(k).Courses.RemoveAt(x);
                            }
                        }
                    }
                    coursesList.RemoveAt(j);
                    j--;
                }
            }*/
        }

        // DONE
        public void addStudent(Student student)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand studentsTable = new OleDbCommand("INSERT INTO Students(First_Name, Last_Name, Username, Password, Major) VALUES (?, ?, ?, ?, ?)", connection))
                {
                    studentsTable.Parameters.AddWithValue("?", student.Name);
                    studentsTable.Parameters.AddWithValue("?", student.Surname);
                    studentsTable.Parameters.AddWithValue("?", student.Username);
                    studentsTable.Parameters.AddWithValue("?", student.Password);
                    studentsTable.Parameters.AddWithValue("?", student.Major);

                    connection.Open();
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
                using (OleDbCommand studentsTable = new OleDbCommand("DELETE FROM Students WHERE Student_ID = @id", connection))
                {
                    studentsTable.Parameters.AddWithValue("@id", student.Id);
                    connection.Open();
                    int rowsAffected = studentsTable.ExecuteNonQuery();
                }
            }

            /*for (int i = 0; i < studentList.Count; i++)
            {
                if (student.Equals(studentList.ElementAt(i)))
                {
                    studentList.RemoveAt(i);
                    break;
                }
            }*/
        }


        public void addCourse(Courses course, String professorUsername)
        {
            int courseId;
            int professorId;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand coursesTable = new OleDbCommand("INSERT INTO Courses(Course_Name, Credits, Hours) VALUES (?, ?, ?)", connection))
                {
                    coursesTable.Parameters.AddWithValue("?", course.CourseName);
                    coursesTable.Parameters.AddWithValue("?", course.Credits);
                    coursesTable.Parameters.AddWithValue("?", course.Hours);
                    connection.Open();
                    int rowsAffected = coursesTable.ExecuteNonQuery();
                }

                using (OleDbCommand coursesTable1 = new OleDbCommand("SELECT Course_ID from Courses WHERE Course_Name=@CourseName", connection))
                {
                    coursesTable1.Parameters.AddWithValue("@CourseName", course.CourseName);
                    connection.Open();

                    using (OleDbDataReader reader = coursesTable1.ExecuteReader())
                    {
                        courseId = reader.GetInt32(0);
                    }
                }

                using (OleDbCommand professorsTable = new OleDbCommand("SELECT Professor_ID from Professors WHERE Username=@Username", connection))
                {
                    professorsTable.Parameters.AddWithValue("@Username", professorUsername);
                    connection.Open();

                    using (OleDbDataReader reader = professorsTable.ExecuteReader())
                    {
                        professorId = reader.GetInt32(0);
                    }
                }

                using (OleDbCommand professorsStudentsTable = new OleDbCommand("INSERT INTO Professors_Courses Values (?, ?)", connection))
                {
                    professorsStudentsTable.Parameters.AddWithValue("?", professorId);
                    professorsStudentsTable.Parameters.AddWithValue("?", courseId);
                    connection.Open();

                    int rowsAffected = professorsStudentsTable.ExecuteNonQuery();
                }
            }

            readDatabase();
            /*
            for (int i = 0; i < professorList.Count; i++)
            {
                if (course.Professor.Equals(professorList.ElementAt(i).Name + " " + professorList.ElementAt(i).Surname))
                    professorList.ElementAt(i).Courses.Add(course.Subject);
            }
            */
        }

        public void removeCourse(Courses course)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand coursesTable = new OleDbCommand("DELETE FROM Courses WHERE Courses_ID = @id", connection))
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
            /*

            string ProffesorInput, StudentInput, CoursesInput;
            



            StreamReader ProfessorFile = new StreamReader(path[0] + "ProfessorFile.txt");

            while ((ProffesorInput = ProfessorFile.ReadLine()) != null)
            {
                string[] data = ProffesorInput.Split(',');

                Professor prof = new Professor(data[0], data[1], data[2], data[3]);

                if (data.Length > 4)
                {
                    for (int i = 4; i < data.Length; i++)
                        prof.Courses.Add(data[i]);
                }

                professorList.Add(prof);
            }

            StreamReader StudentFile = new StreamReader(path[0] + "StudentFile.txt");
            while ((StudentInput = StudentFile.ReadLine()) != null)
            {
                string[] data = StudentInput.Split(',');

                Student stud = new Student(data[0], data[1], data[2], data[3], data[4], data[5]);

                if (data.Length > 6)
                {
                    for (int i = 6; i < data.Length; i++)
                        stud.Courses.Add(data[i]);
                }
                studentList.Add(stud);
            }

            StreamReader CoursesFile = new StreamReader(path[0] + "CoursesFile.txt");
            while ((CoursesInput = CoursesFile.ReadLine()) != null)
            {
                string[] data = CoursesInput.Split(',');
                Course course = new Courses(data[0], data[1], Convert.ToDouble(data[2]), data[3]);
                coursesList.Add(course);
            }

            ProfessorFile.Close();
            StudentFile.Close();
            CoursesFile.Close();
            */
        }
        public void writeFiles()
        {
            using (StreamWriter ProfessorFile = new StreamWriter(path[0] + "ProfessorFile.txt", false))
            {

                for (int i = 0; i < professorList.Count; i++)
                {
                    string profData = professorList.ElementAt(i).ToString();
                    ProfessorFile.WriteLine(profData);
                }
            }

            using (StreamWriter StudentFile = new StreamWriter(path[0] + "StudentFile.txt", false))
            {
                for (int i = 0; i < studentList.Count; i++)
                {
                    StudentFile.WriteLine(studentList.ElementAt(i).ToString());
                }
            }

            using (StreamWriter CoursesFile = new StreamWriter(path[0] + "CoursesFile.txt", false))
            {
                for (int i = 0; i < coursesList.Count; i++)
                {
                    CoursesFile.WriteLine(coursesList.ElementAt(i).ToString());
                }
            }
        }
    }
}