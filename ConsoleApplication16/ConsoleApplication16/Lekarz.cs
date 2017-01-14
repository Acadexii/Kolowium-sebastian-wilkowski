using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Lekarz : Osoba 
    {
        private string specjalnosc;
        

  
        public Lekarz(string imieNazwisko, string specjalnosc) : base(imieNazwisko)
        {
            this.specjalnosc = specjalnosc;
        }

        public void ToString()
        {
            Console.WriteLine("Lekarz, imię i nazwisko: {0}", this.imieNazwisko);
            Console.WriteLine("Specjalnosc : {0}", this.specjalnosc);
        }

       
    }
}
