using System;
using System.Collections.Generic;
using System.Text;
namespace pr2_project
{
    class Inmate : Patient
    {
        hospital station;
        List<Doctor> dc = new List<Doctor>();
        List<string> medicine = new List<string>();
        List<string> tests = new List<string>();
        DateTime date_of_operation;
        int period_of_stay;
        public DateTime Doo
        {
            get { return date_of_operation; }
        }
        public int Pos
        {
            get { return period_of_stay; }
        }
        public Inmate()
        {
        }
        public Inmate(string Diagnosis, hospital station, DateTime date_of_operation, int period_of_stay, int id, string name, int births, int y, int m, int d) : base(id, name, births, y, m, d)
        {
            this.station = station;
            this.Diagnosis = Diagnosis;
            this.date_of_operation = date_of_operation;
            this.period_of_stay = period_of_stay;
        }
        public override void AddDoctor(Doctor d)
        {
            dc.Add(d);
        }
        public void AddTest(string t)
        {
            tests.Add(t);
        }
    }
}
