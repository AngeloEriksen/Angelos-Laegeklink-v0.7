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

        //Den skulle nok bare have ligget i patient class.
        public virtual void VisInfo(List<Patient> patientListe) { }

        // Kunne ikke få min method over til at virke som abstact, så nu lavet jeg bare en easy en her haha.
        public abstract void Velkommen();
    }
}
