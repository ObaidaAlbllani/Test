using System;
using System.Collections.Generic;
namespace pr2_project
{
    class Program
    {
        static void Main(string[] args)
        {
            hospital h1 = new hospital("clinics", 1);
            hospital h2 = new hospital("eyes", 2);
            //////////////////////////////////////////////////////
            Doctor d1 = new Doctor(1, "D1", "x1", 2019, 5, 3);
            Doctor d2 = new Doctor(2, "D2", "x2", 2018, 4, 2);
            Doctor d3 = new Doctor(3, "D3", "x3", 2017, 7, 8);
            //////////////////////////////////////////////////////
            List<Patient> patients = new List<Patient>();
            DateTime day1 = new DateTime(2020, 1, 11);
            DateTime day2 = new DateTime(2020, 2, 12);
            DateTime day3 = new DateTime(2020, 3, 13);
            //Sampling
            patients[0] = new Sampling(h1, d1, "z1", 6, "P1", 15, 2017, 5, 4);
            patients.Add(patients[0]);
            patients[1] = new Sampling(h2, d2, "z2", 7, "P2", 17, 2012, 5, 4);
            patients.Add(patients[1]);
            //Inmate
            patients[2] = new Inmate("z4", h1, day1, 6, 20, "P4", 20, 2019, 5, 3);
            patients.Add(patients[2]);
            patients[3] = new Inmate("z5", h2, day1, 3, 21, "P5", 27, 2019, 3, 3);
            patients.Add(patients[3]);
            //intensive_care
            patients[4] = new intensive_care(day2, day3, "z7", h1, day1, 50, 42, "P7", 30, 2018, 8, 4);
            patients.Add(patients[4]);
            patients[5] = new intensive_care(day2, day3, "z8", h2, day1, 51, 43, "P8", 33, 2013, 5, 1);
            patients.Add(patients[5]);

            //////new
            patients[6] = new qu("+", 42, "P7", 30, 2018, 8, 4);
            patients[7] = new qu("-", 42, "P7", 30, 2018, 8, 4);



            //Find 
            int numberofin=0;
            for (int i = 0; i < (patients.Count); i++)
            {
                if(patients[i] is Inmate)
                {
                    numberofin++;
                }
            }
            ////////
            Console.WriteLine(numberofin);
            string SearchDiagno = "z4";
            for (int i = 0;i < (patients.Count); i++){
                if(patients[i].Diagnosis == SearchDiagno)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("doctor Name:");
            string SearchDoctor = Console.ReadLine();
            /////////
            for(int i = 0; i < (patients.Count); i++)
            {
                if(patients[i].Doc.Name == SearchDoctor)
                {
                    Console.WriteLine("Found", SearchDoctor, i);
                }
            }
            intensive_care pto = new intensive_care();
            for (int i = 0; i < (patients.Count); i++)
            {
                if (patients[i] is intensive_care)
                {
                    pto = (intensive_care)patients[i];
                    if((pto.Exit.Day)-(pto.Enter.Day) == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            //new
            string find = "+";
            qu oo = new qu();
            for (int i = 0; i < (patients.Count); i++)
            {
                if (patients[i] is qu)
                {
                    if (oo.sh==find)
                    {
                        Console.WriteLine("+++");
                    }
                    else
                        Console.WriteLine("---");
                }
            }
        }
    }
}

