using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angelos_Lægeklink.Objects
{
    internal abstract class Person
    {
        public string Navn { get; set; }
        public int Telefonnummer { get; set; }
        public string Specialisering { get; set; }

        public Person(string navn, string specialisering, int telefonnummer)
        {
            Navn = navn;
            Specialisering = specialisering;
            Telefonnummer = telefonnummer;          
        }

        // jeg ved ikke helt hvorfor jeg gør det, Men jeg blev bedt om det så nu har jeg gjordt det.
        public abstract void MinAbstractTest(string test);
    }
}
