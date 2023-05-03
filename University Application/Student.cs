using System;
using System.Collections.Generic;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using University_Application;

namespace University_Application
{
    public class Student : Person, Login
    {
        public string major;
        public string studentID;
        public List<string> courses = new List<string>();

        string[] path = Environment.CurrentDirectory.Split(new string[] { "bin" }, StringSplitOptions.None);


        public string StudentID { set => studentID = value; get => studentID; }

        public string Major { set => major = value; get => major; }

        public List<string> Courses { set => courses = value; get => courses; }

        public Student()
        {

        }

        public Student(string name, string surname, string username, string password, string studentID, string major, List<String> courses) : base(name, surname, username, password)
        {
            this.StudentID = studentID;
            this.Major = major;
            this.Courses = courses;
        }

        public Student(string name, string surname, string username, string password, string studentID, string major) : base(name, surname, username, password)
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

                foreach (Student stud in readStudentFile())
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
            List<Student> student = readStudentFile();

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

        // Method to read the Student File
        public List<Student> readStudentFile()
        {
            List<Student> student = new List<Student>();
            StreamReader input = new StreamReader(path[0] + "StudentFile.txt");

            string line;

            while ((line = input.ReadLine()) != null)
            {
                string[] entries = line.Split(',');
                Student s = new Student(entries[0], entries[1], entries[2], entries[3], entries[4], entries[5]);

                if (entries.Length > 5)
                {
                    for (int i = 6; i < entries.Length; i++)
                    {
                        s.Courses.Add(entries[i]);
                    }
                }
                student.Add(s);
            }
            input.Close();
            return student;
        }

        // Method to show all the university courses
        public List<string> showAllCourses()
        {
            List<string> allCourses = new List<string>();

            foreach (Courses course in new Courses().readCoursesFromFile())
            {
                allCourses.Add(course.Subject);
            }
            return allCourses;
        }

        // Method to show the grades for the student
        public List<string> showGrades()
        {
            List<string> yourGrades = new List<string>();

            foreach (Grades grades in new Grades().readGrades())
            {
                if (StudentID.Equals(grades.StudentID))
                {
                    yourGrades.Add(grades.Subject + " " + grades.Grade);
                }
            }

            return yourGrades;
        }

        // Write the course in the file
        public void enroll(string text, string studID)
        {
            List<Student> student = readStudentFile();

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
            }
        }

        // Drop a course
        public void drop(string text, string studid)
        {
            List<Student> student = readStudentFile();

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

            foreach (Courses course in new Courses().readCoursesFromFile())
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
            List<string> myCourses = new List<string>();

            foreach (string course in Courses)
            {
                myCourses.Add(course);
            }

            return myCourses;
        }

        public List<string> showStudentCredits()
        {
            List<string> credits = new List<string>();

            foreach (Courses course in new Courses().readCoursesFromFile())
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

            foreach (Courses course in new Courses().readCoursesFromFile())
            {
                allCourses.Add(course.Subject + " - " + course.Credits + " credits");
            }
            return allCourses;
        }

        public string showGPA()
        {
            double gpa = 0;
            double token = 0;

            foreach (Courses course in new Courses().readCoursesFromFile())
            {
                foreach (Grades grade in new Grades().readGrades())
                {
                    if (grade.StudentID.Equals(StudentID))
                    {
                        gpa += grade.Grade * course.Credits;
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