using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Pacjent : Osoba
    {
        private int wiek;
        private string choroba;

        public Pacjent() { }

        public Pacjent(string imieNazwisko, int wiek, string choroba)
            : base(imieNazwisko)
        {
            this.wiek = wiek;
            this.choroba = choroba;
        }
        public void ToString()
        {
            Console.WriteLine("Pacjent, imię i nazwisko: {0}", this.imieNazwisko);
            Console.WriteLine("Wiek {0}", this.wiek);
            Console.WriteLine("choroba: {0}", this.choroba);

        }

    }
}
