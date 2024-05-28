using System;
using System.Collections.Generic;
using System.Text;
namespace pr2_project
{
    class Sampling : Patient
    {
        hospital station;
        Doctor doctor;
        string last;
        public hospital Station
        {
            get { return station; }
        }
        public Doctor Doctor
        {
            get { return doctor; }
        }
        List<string> medicine = new List<string>();
        public Sampling(hospital station, Doctor doctor, string last, int id, string name, int births, int y, int m, int d) : base(id, name, births, y, m, d)
        {
            this.station = station;
            this.doctor = doctor;
            this.last = last;
        }
        public void Addmedicine(string d1)
        {
            medicine.Add(d1);
        }
    }
}
