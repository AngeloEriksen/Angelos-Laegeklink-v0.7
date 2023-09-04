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

        //constructer er opsat sådan her, så jeg kan create en Patient object uden at tildele den argumenter (Der er sikkert en bedre måde haha)
        public Patient(string tildeltlæge = "", string specialisering = "", string navn = "", int telefonnummer = 0) : base(navn, specialisering, telefonnummer)
        {
            TildeltLæge = tildeltlæge;
        }
        public override void VisInfo(List<Patient> patientListe)
        {

            Console.WriteLine("Her er en liste af alle Patinter");
            Console.WriteLine("--------------------------------");
            foreach (Patient patient in patientListe)
            {
                Console.WriteLine($"{patient.Navn}");
            }
            Console.WriteLine("--------------------------------");
        }

        //
        public override void Velkommen()
        {
            Console.WriteLine("Velkommen til Angelos Læge-Klinik");
        }

    }
}
