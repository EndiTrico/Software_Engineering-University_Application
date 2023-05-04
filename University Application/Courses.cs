using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Application
{
    public class Courses
    {
        private String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database_University.mdb";

        int id;
        string courseName;
        int credits;
        int hours;

        public int Id { get => id; set => id = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public int Credits { get => credits; set => credits = value; }
        public int Hours { get => hours; set => hours = value; }

        public Courses()
        {

        }
        public Courses(int id, string courseName, int credits, int hours)
        {
            this.Id = id;
            this.CourseName = courseName;
            this.Credits = credits;
            this.Hours = hours;
        }

        public Courses(string courseName, int credits, int hours)
        {
            this.CourseName = courseName;
            this.Credits = credits;
            this.Hours = hours;
        }

        // DONE
        public List<Courses> readCourses()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            OleDbCommand coursesTable = new OleDbCommand("SELECT * FROM Courses", connection);
            OleDbDataReader readerCoursesTable = coursesTable.ExecuteReader();

            List<Courses> coursesList = new List<Courses>();

            while (readerCoursesTable.Read())
            {
                Courses course = new Courses(Convert.ToInt32(readerCoursesTable["Course_ID"]),
                    readerCoursesTable["Course_Name"].ToString(), Convert.ToInt32(readerCoursesTable["Credits"]),
                    Convert.ToInt32(readerCoursesTable["Hours"]));

                coursesList.Add(course);
            }

            readerCoursesTable.Close();
            connection.Close();

            return coursesList;
            /*List<Courses> list = new List<Courses>();

            string[] path1 = Environment.CurrentDirectory.Split(new string[] { "bin" }, StringSplitOptions.None);

            StreamReader reader = new StreamReader(path1[0] + "CoursesFile.txt");

            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();
                var data = line.Split(',');

                Courses course = new Courses(data[0], data[1], Convert.ToDouble(data[2]), data[3]);

                list.Add(course);
            }

            reader.Close();

            return list;
            */
        }

        public override string ToString()
        {
            return this.Id + "," + this.CourseName + "," + this.Credits + "," + this.Hours;
        }
    }
}