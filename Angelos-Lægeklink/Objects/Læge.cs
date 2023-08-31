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
        public List<Patient> TildeltePatienter { get; } = new List<Patient>();

        public int TildelPatient { get; set; }
        public Læge(string navn, string specialisering, int telefonnummer, int tildelPatient) : base(navn, specialisering, telefonnummer)
        {
            TildelPatient = tildelPatient;
        }
        public override void MinAbstractTest(string test)
        {

            try
            {
                // starter en try-catch, hvor jeg vil forsøge at udføre nogle operationer, der kan kaste undtagelser.

                if (TildeltePatienter.Count >= 3)
                {
                    throw new Exception("En læge kan ikke have mere end 3 patienter.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl: {ex.Message}");
            }
        }
    }
}
