using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pacjent> pacjenci = new List<Pacjent>();
            pacjenci.Add(new Pacjent("Jan naj", 33, "Rak"));
            pacjenci.Add(new Pacjent("Waldek ziom", 33, "Rak"));
            pacjenci.Add(new Pacjent("Mirek czub", 33, "Rak"));
            pacjenci.Add(new Pacjent("marcel szpak", 33, "Rak"));
            pacjenci.Add(new Pacjent("Jan dab", 33, "Rak"));
            

            Console.WriteLine("sebo");
            Console.ReadKey();
        }
    }
}
