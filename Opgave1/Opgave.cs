using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class Opgave
    {
        public int Id { get; set; }
        public string Tekst { get; set; }
        public DateTime Dato { get; set; }
        public int ContainerId { get; set; }
        public string NuværendePosition { get; set; }
        public string Destination { get; set; }
        public Kunde KundeObject { get; set; }

        public Opgave(int id, string tekst, DateTime dato, int containerId, string nuværendePosition, string destination,Kunde kunde)
        {
            Id = id;
            Tekst = tekst;
            Dato = dato;
            ContainerId = containerId;
            NuværendePosition = nuværendePosition;
            Destination = destination;
            KundeObject = kunde;

        }

        
      
    }
}
