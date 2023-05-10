using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Application
{
    public abstract class Person
    {
        private int id;
        private string name;
        private string surname;
        private string username;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public Person(int id,string name, string surname, string username, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
        }

        public Person() { }

        public override string ToString()
        {
            return this.Name + ", " + this.Surname + ", " + this.Username + ", " + this.Password;
        }
    }
}