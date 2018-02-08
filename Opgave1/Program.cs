using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            var opgaveAntal = 20;
            var topId = 1;
            var containerTotalId = 1;

            Ark ark1 = new Ark();
            var by1 = "Pladsholder1";
            ark1.ByListe.Add(by1);
            Kunde kunde1 = new Kunde();
            kunde1.Id = 1;
            kunde1.KundeNr = 213212;
            kunde1.Navn = "L. Hansen";
            ark1.KundeListe.Add(kunde1);

            var a = ark1.SætOpgaverPåArk(opgaveAntal, topId, containerTotalId);
            foreach (var opg in a)
            {
                Console.WriteLine("Opgave id: " + opg.Id);
                Console.WriteLine("Dato: " + opg.Dato);
                Console.WriteLine("´Container id: " + opg.ContainerId);
                Console.WriteLine("Opgave id: " );
                var pos = opg.NuværendePosition ?? String.Empty;
                Console.WriteLine("Position: " + pos);   
            }

            ExcelHelper.CreateExcel(a);
            Console.ReadKey();
        }
    }
}
