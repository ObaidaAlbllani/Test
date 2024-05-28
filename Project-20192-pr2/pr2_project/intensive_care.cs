using System;
using System.Collections.Generic;
using System.Text;
namespace pr2_project
{
    class intensive_care : Inmate
    {
        DateTime enter;
        DateTime exit;
        public DateTime Enter
        {
            get { return enter; }
        }
        public DateTime Exit
        {
            get { return exit; }
        }
        public intensive_care()
        {
        }
        public intensive_care(DateTime enter, DateTime exit, string Diagnosis, hospital station, DateTime date_of_operation, int period_of_stay, int id, string name, int births, int y, int m, int d) : base(Diagnosis, station, date_of_operation, period_of_stay, id, name, births, y, m, d)
        {
            this.enter = enter;
            this.exit = exit;
        }
    }
}
