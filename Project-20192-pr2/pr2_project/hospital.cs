using System;
using System.Collections.Generic;
using System.Text;
namespace pr2_project
{
    class hospital
    {
        int id;
        string hosname;
        List<Doctor> ds = new List<Doctor>();
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public hospital()
        {
            id = 0;
            hosname = "";
        }
        public hospital(string departname,int id)
        {
            this.id = id;
            this.hosname = departname;
        }
        public string Hosname
        {
            get { return hosname; }
        }
        public void AddDoctor(Doctor d)
        {
            ds.Add(d);
        }

    }
}
