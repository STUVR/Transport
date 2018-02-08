using System;
using System.Collections.Generic;

namespace Opgave1
{
    class Ark
    {
        private int Id { get; set; }
        public List<string> ByListe = new List<string>();
        public List<Kunde> KundeListe = new List<Kunde>();

        

        public List<Opgave> SætOpgaverPåArk (int opgaveAntal, int totalId, int containerTotal)
        {
            var opgaveListe = new List<Opgave>();

            for (var i = 0; i < opgaveAntal; i++)
            {
                var id = totalId + i;
                var tekst = "";
                var dato = DateTime.Today;
                var container = SkabContainer(containerTotal, i);
                var pos = SkabPos();
                var des = SkabDes();
                var kunde = SkabKunde();

                var opgave = new Opgave(id, tekst, dato, container, pos, des, kunde);
                opgaveListe.Add(opgave);

            }

            return opgaveListe; 
        }

        public int SkabContainer(int højesteContainerId, int i)
        {
            var rnd = new Random();
            var id = højesteContainerId + rnd.Next(1, 200) + (4 * i + rnd.Next(1, 88));

            return (int)id;
        }

        public string SkabPos()
        {
            var rnd = new Random();
            string addresse = ByListe[rnd.Next(0, ByListe.Count-1)];

            return addresse;
        }

        public string SkabDes()
        {
            var rnd = new Random();
            string addresse = ByListe[rnd.Next(0, ByListe.Count-1)];

            return addresse;
        }

        public Kunde SkabKunde()
        {
            var rnd = new Random();
            var kunde = KundeListe[rnd.Next(0, KundeListe.Count-1)];

            return kunde;
        }
    }
}
