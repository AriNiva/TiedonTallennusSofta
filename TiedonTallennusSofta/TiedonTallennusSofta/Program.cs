using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennusSofta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muuttujien luonnit ja alustukset
            string tiedosto = "C:\\Temp\\Lampotila.txt";//Tiedostonimeen viittaus tapa1
            string tiedosto2 = @"C:\Temp\Lampotila.txt";//Tiedostonimeen viittaus tapa2 @-merkillä
            string aikaisempiArvo, uusiArvo;
            //Luetaan tiedostosta aikaisempi lämpötila-arvo
            if (File.Exists(tiedosto))
            {
                aikaisempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Lämpötila on: {0} astetta", aikaisempiArvo);
            }
            else 
            {
                Console.WriteLine("Tervetuloa!");
            }
            Console.Write("Anna uusi lämpötila: ");
            uusiArvo = Console.ReadLine();
            //Tiedostoon kirjoittaminen
            File.WriteAllText(tiedosto, uusiArvo);
            Console.WriteLine("Uusi arvo talletettu!");
            Console.ReadLine();
        }
    }
}
