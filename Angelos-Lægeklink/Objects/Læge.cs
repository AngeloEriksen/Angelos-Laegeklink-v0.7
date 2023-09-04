using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angelos_Lægeklink.Objects
{
    internal class Læge : Person
    {

        // Den her liste bliver brugt til at gemme patienter, der er tildelt til lægen.
        public List<Patient> TildeltePatienter { get; } = new List<Patient>(); // Den er på standby den her liste ved ikke helt om jeg skal bruge den.

        public int TildelPatient { get; set; }
        public Læge(string navn, string specialisering, int telefonnummer, int tildelPatient) : base(navn, specialisering, telefonnummer)
        {
            TildelPatient = tildelPatient;
        }


        public override void Velkommen()
        {
            Console.WriteLine("Du vil nu få nogle Valgmuligheder\n");
        }
    }
}
