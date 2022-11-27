using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        private string jmeno;
        private string prijmeni;
        private int vek;
        private int id;
        private bool pohlavi;


        public Student(string jmeno ,string prijmeni,int vek,int id, bool pohlavi)
        {
            jmeno = jmeno;
            prijmeni = prijmeni;
            pohlavi = pohlavi;
            vek = vek;
            id = id;

        }


        public override string ToString()
        {
            string pohlavi = "zena";
            if(this.pohlavi== true)
            {
                pohlavi = "muz";
        }
            return this.jmeno;

    }
}
