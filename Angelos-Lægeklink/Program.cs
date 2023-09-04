
using Angelos_Lægeklink.Objects;
using System.Numerics;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

Læge peter = new("Peter Hansen", "øjenlæge", 11111111, 0);
Læge martin = new("Martin Jensen", "Radiologi", 22222222, 0);
Læge Thomas = new("Thomas Olsen", "Kirurgi", 33333333, 0);
Læge ole = new("Ole Nielsen", "Onkologi", 44444444, 0);

List<Patient> patientListe = new List<Patient>
{

};

while (true)
{
    Patient patient = new();         //Skulle bruge et instance af Patient og læge class for at køre mine 2 abstact methods on den ene virtual.
    Læge læge = new("", "", 0, 0); ;//ved godt det er lidt dumt men det virker. Kunne være rart med noget feedback om hvad jeg ellers kunne have gjordt her. (Vis du har tid, ved du har mange du skal rette)

    Console.Clear();
    patient.Velkommen();
    læge.Velkommen();
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Registrer ny patient");
    Console.WriteLine("2. Hvem arbejder her");
    Console.WriteLine("3. Se Patienter");
    Console.WriteLine("4. Afslut program");

    ConsoleKeyInfo valg = Console.ReadKey();
    Console.Clear();

    switch (valg.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("ny patient");
            NyPatient();
            break;

        case ConsoleKey.D2:
            Console.WriteLine("Her er Lægern der Arbjder på Kliniken");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine($"1. {peter.Navn}, Specialisering: {peter.Specialisering}, Telefon: {peter.Telefonnummer}, Antal Patienter: {peter.TildelPatient}");
            Console.WriteLine($"2. {martin.Navn}, Specialisering: {martin.Specialisering}, Telefon: {martin.Telefonnummer}, Antal Patienter: {martin.TildelPatient}");
            Console.WriteLine($"3. {Thomas.Navn}, Specialisering: {Thomas.Specialisering}, Telefon: {Thomas.Telefonnummer}, Antal Patienter: {Thomas.TildelPatient}");
            Console.WriteLine($"4. {ole.Navn}, Specialisering: {ole.Specialisering}, Telefon: {ole.Telefonnummer}, Antal Patienter: {ole.TildelPatient}");
            Console.WriteLine("------------------------------------------------------------------------------------");
            break;

        case ConsoleKey.D3:
            Console.WriteLine("Se Patienter");
            patient.VisInfo(patientListe);
            break;

        case ConsoleKey.D4:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Ugyldigt valg. Prøv igen.");
            break;
    }

    void NyPatient()
    {
        Patient leNyPatient = new Patient();

 
        Console.Write("Indtast Patients Fulde Navn: ");
        leNyPatient.Navn = Console.ReadLine();

        Console.Write("Indtast Patients Telefonnummer: ");
        int Num = Convert.ToInt32(Console.ReadLine());
        leNyPatient.Telefonnummer = Num;

        VælgLæge();

        Console.Clear();

        patientListe.Add(leNyPatient);
    }

    void VælgLæge()
    {
        bool forkertValg = true;

        Console.WriteLine("\nTilVælg en læge");
        Console.WriteLine("------------------------------------------------------------------------------------");
        Console.WriteLine($"Tryk 1 for: {peter.Navn}, Specialisering: {peter.Specialisering}, Telefon: {peter.Telefonnummer}, Antal Patienter: {peter.TildelPatient}");
        Console.WriteLine($"Tryk 2 for: {martin.Navn}, Specialisering: {martin.Specialisering}, Telefon: {martin.Telefonnummer}, Antal Patienter: {martin.TildelPatient}");
        Console.WriteLine($"Tryk 3 for: {Thomas.Navn}, Specialisering: {Thomas.Specialisering}, Telefon: {Thomas.Telefonnummer}, Antal Patienter: {Thomas.TildelPatient}");
        Console.WriteLine($"Tryk 4 for: {ole.Navn}, Specialisering: {ole.Specialisering}, Telefon: {ole.Telefonnummer}, Antal Patienter: {ole.TildelPatient}");
        Console.WriteLine("------------------------------------------------------------------------------------");
        while (forkertValg)
        {

            ConsoleKeyInfo valg = Console.ReadKey();

            switch (valg.Key)
            {
                case ConsoleKey.D1:
                    if (peter.TildelPatient >= 3)
                        throw new InvalidOperationException("En læge kan ikke have mere end 3 patienter.");

                    Console.WriteLine($"Du har valgt: {peter.Navn}");
                    peter.TildelPatient++;
                    forkertValg = false;
                    break;
                case ConsoleKey.D2:
                    if (martin.TildelPatient >= 3)
                        throw new InvalidOperationException("En læge kan ikke have mere end 3 patienter.");

                    Console.WriteLine($"Du har valgt: {martin.Navn}");
                    martin.TildelPatient++;
                    forkertValg = false;
                    break;
                case ConsoleKey.D3:
                    if (Thomas.TildelPatient >= 3)
                        throw new InvalidOperationException("En læge kan ikke have mere end 3 patienter.");

                    Console.WriteLine($"Du har valgt: {Thomas.Navn}");
                    Thomas.TildelPatient++;
                    forkertValg = false;
                    break;
                case ConsoleKey.D4:
                    if (ole.TildelPatient >= 3)
                        throw new InvalidOperationException("En læge kan ikke have mere end 3 patienter.");

                    Console.WriteLine($"Du har valgt: {ole.Navn}");
                    ole.TildelPatient++;
                    forkertValg = false;
                    break;
                default:
                    Console.WriteLine("Du har Trykket på en forket knap prøv igen.");
                    break;
            }
        }
    }
    Console.WriteLine("Tryk på en tast for at Vende tilbage til Hovedmenuen...");
    Console.ReadKey();
}
    