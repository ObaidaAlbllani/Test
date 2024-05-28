using System;
using System.Collections.Generic;
using System.Text;
namespace pr2_project
{
    class Doctor
    {
        private int id;
        private string name;
        private DateTime date_work;
        private string specialty;
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public DateTime Date_Work
        {
            get { return Date_Work; }
        }
        public string Specialty
        {
            get { return specialty; }
        }
        public Doctor()
        {
            id = 0;
            name = " ";
            date_work = new DateTime();
            specialty = " ";
        }
        public Doctor(int id, string name, string specialty, int y, int m, int d)
        {
            this.id = id;
            this.name = name;
            this.specialty = specialty;
            date_work = new DateTime(y, m, d);
        }
    }
}

