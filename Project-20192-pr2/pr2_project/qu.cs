using System;
using System.Collections.Generic;
using System.Text;

namespace pr2_project
{
    class qu : Patient
    {
        public string sh;
        public string Sh
        {
            get { return sh; }
        }
        public qu()
        {
            sh = "";
        }
        public qu(string sh , int id, string name, int births, int y, int m, int d) : base(id, name, births, y, m, d)
        {
            this.sh = sh;
        }
    }
}
