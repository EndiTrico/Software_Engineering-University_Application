using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Application
{
    public class Courses
    {
        string subject;
        string time;
        double credits;
        string professor;

        public string Subject { get => subject; set => subject = value; }
        public string Time { get => time; set => time = value; }
        public double Credits { get => credits; set => credits = value; }
        public string Professor { get => professor; set => professor = value; }

        public Courses()
        {

        }
        public Courses(string subject, string time, double credits, string professor)
        {
            this.Subject = subject;
            this.Time = time;
            this.Credits = credits;
            this.Professor = professor;
        }
        public List<Courses> readCoursesFromFile()
        {
            List<Courses> list = new List<Courses>();

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

        }

        public override string ToString()
        {
            return this.Subject + "," + this.Time + "," + this.Credits + "," + this.Professor;
        }
    }
}