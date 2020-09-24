using System;

namespace Numeropeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Random arvottu = new Random();
            int numero  = arvottu.Next(1, 20);

            // Console.WriteLine(numero);

            for (int kerta = 0; kerta < 3; kerta++)
            {
                Console.WriteLine("Arvaa luku numeroiden 1 ja 20 välillä! Sinulla on " + (3-kerta) + " arvausta jäljellä.");
                int arvaus = int.Parse(Console.ReadLine());
            
                // om fel meddela            

                if (arvaus < numero)
                {
                    Console.WriteLine("Arvasit väärin. Luku on suurempi kuin arvaamasi numero.");
                }

                else if (arvaus > numero)
                {
                    Console.WriteLine("Arvasit väärin. Luku on pienempi kuin arvaamasi numero.");
                }

                // on numret rätt meddela

                else 
                {
                    Console.WriteLine("Arvasit oikein!");
                    break;

                }
            }
            
            // Kör gissning max tre ggr, sedan

            Console.WriteLine("-=::Game over::=-");


        }
    }
}

/*
Harjoitus 2. Koodaa C#-kielellä konsolipohjainen peli nimeltä "Arvaa luku". 
Pelissä tietokone arpoo salaisen luvun välillä 1-20, jonka jälkeen pelaajalla 
on kolme arvauskertaa arvata tuo luku.

Joka arvauskerran jälkeen kone kertoo, onko oikea luku suurempi vai pienempi 
kuin oikea salainen luku.

 - Vinkki: if, for/while, Random
 */