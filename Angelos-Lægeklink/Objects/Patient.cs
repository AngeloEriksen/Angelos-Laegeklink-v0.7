using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angelos_Lægeklink.Objects
{
    internal class Patient : Person
    {

        public string TildeltLæge { get; set; }

        //constructer er opsat sådan her, så jeg kan create en Patient object uden at tildele den argumenter
        public Patient(string tildeltlæge = "", string specialisering = "", string navn = "", int telefonnummer = 0) : base(navn, specialisering, telefonnummer)
        {
            TildeltLæge = tildeltlæge;
        }

        public override void MinAbstractTest(string test)
        {
            if (TildeltLæge == "Kirurgi" && TildeltLæge == "Onkologi")
            {
                throw new Exception("Ugyldig kombination af læger for patienten.");
            }
        }

    }
}
