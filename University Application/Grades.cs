using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Application
{
    public class Grades
    {
        private string subject;
        private string studentID;
        private double grade;

        string[] path = Environment.CurrentDirectory.Split(new string[] { "bin" }, StringSplitOptions.None);

        public string Subject { get => subject; set => subject = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public double Grade { get => grade; set => grade = value; }

        public Grades(string subject, string studentID, double grade)
        {
            Subject = subject;
            StudentID = studentID;
            Grade = grade;
        }

        public Grades(string subject, string studentID)
        {
            Subject = subject;
            StudentID = studentID;
        }

        public Grades() { }

        public List<Grades> readGradesFile()
        {
            List<Grades> list = new List<Grades>();
            StreamReader reader = new StreamReader(path[0] + "GradesFile.txt");

            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();
                var data = line.Split(',');

                Grades grade = new Grades(data[0], data[1], Convert.ToDouble(data[2]));
                list.Add(grade);
            }
            reader.Close();
            return list;
        }

        public override string ToString()
        {
            return this.Subject + ", " + this.StudentID + ", " + this.Grade;
        }
    }
}