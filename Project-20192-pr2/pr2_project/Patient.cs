using System;
using System.Collections.Generic;
using System.Text;
namespace pr2_project
{
    class Patient : hospital
    {
        private int id;
        private string name;
        private int births;
        private DateTime date_of_admission;
        Doctor doc;
        string diagnosis;
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Births
        {
            get { return births; }
        }
        public DateTime Date_of_admission
        {
            get { return date_of_admission; }
        }
        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }
        public Doctor Doc 
        {
            get { return doc; }
        }
        public Patient()
        {
            id = 0;
            name = "";
            births = 0;
            date_of_admission = new DateTime();
            ID++;
        }
        public Patient(int id, string name, int births, int y, int m, int d)
        {
            this.id = id;
            this.name = name;
            this.births = births;
            date_of_admission = new DateTime(y, m, d);
            ID++;
        }
        public virtual void AddDiagnosis(string d) 
        {
            diagnosis = d;
        }
        public virtual new void AddDoctor(Doctor d) 
        {
            doc = d;
        }
    }
}
