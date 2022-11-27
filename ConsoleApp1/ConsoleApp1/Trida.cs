using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Trida
    {
        private string nazev;
        List<Student> list = new List<Student>();
        HashSet<Student> hash = new HashSet<Student>();

        public Trida ( string nazev)
        {
            this.list = new List<Student>();
            this.hash = new HashSet<Student>();
            this.nazev = nazev;
        }
        public void addStudent(string jmeno, string prijmeni)
        {
            Student s = new Student(jmeno, prijmeni, 15, 85, true);
            list.Add(s);
            hash.Add(s);

    }
        public override string ToString()
        {
            string vypis = "trida " + nazev;
            for (int i = 0; i < list.Count; i++)
            {
                vypis += list[i].ToString();
            }
            return vypis;




        }

    }
