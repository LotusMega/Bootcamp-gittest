using System;

namespace OlioOhjelmointi
{
    class Neuletyö 
    {
        public string Malli { get; set; }
        public string Neulos { get; set; }
        public string Lanka { get; set; }  
        public double Puikkokoko { get; set; }        
        public int Tiheys { get; set; }  // silmukkaa per 10 cm      
        public int Silmukkamäärä { get; set; }        
        public bool TyönAlla { get; set; }
        public void Neulo() 
        {            
            TyönAlla = true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neuletyö");

            Neuletyö oma = new Neuletyö();
            Neuletyö Annalle = new Neuletyö();
            Neuletyö Siirille = new Neuletyö();
            Neuletyö Martalle = new Neuletyö();

            oma.Malli = "villasukka";
            oma.Neulos = "Palmikkojoustin";
            oma.Lanka = "Kaupunki vaalenpinainen";
            oma.Puikkokoko = 3.5;
            oma.Silmukkamäärä = 54;

            oma.Neulo();

        }
    }
}
