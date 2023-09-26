using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Török_Levente_BejegyzesProjekt
{
    internal class _2feladat
    {
        private List<Bejegyzes> list1;
        private List<Bejegyzes> list2;

        public _2feladat()
        {
            list1 = new List<Bejegyzes>();
            list2 = new List<Bejegyzes>();

            darabszam();
            beolvasa();
        }

        public void darabszam()
        {

            Console.WriteLine("Adjon meg egy darabszámot:");
            int darab = int.Parse(Console.ReadLine());
            int bejegyzes = darab;
            for (int i = 0; i < darab; i++)
            {
                if (darab < 0)
                {
                    Console.WriteLine("Egész számot adjon meg");
                }
                else
                {
                    Console.WriteLine($"Hozzon létre egy {darab} új bejegyzés");
                    Bejegyzes b = new Bejegyzes(Console.ReadLine(), Console.ReadLine());
                    bejegyzes--;
                    list1.Add(b);

                }
            }

        }

        public void beolvasa()
        {
            StreamReader sr = new StreamReader("bejegyzesek.csv");
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(';');
                string szerzo = adatok[0];
                string tartalm = adatok[1];
                Bejegyzes b = new Bejegyzes(szerzo, tartalm);
                list2.Add(b);
            }
            sr.Close();

            foreach (var item in list2)
            {
                Console.WriteLine("\n");
                Console.WriteLine(item);
            }
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }

        public void veletlenLike()
        {
            int listaszam = (list1.Count() + list2.Count()) * 20;
            Random random = new Random();
            foreach (var item in list1)
            {
                
            }

        }

    }
}

