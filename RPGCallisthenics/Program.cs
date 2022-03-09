using static System.Net.Mime.MediaTypeNames;

namespace RPGCallisthenics
{
    class main
    {
        
        static void Main(string[] args)
        {
            bool FinPartie= false; 
            Hero hero1 = new Hero("Hercules");
            Hero ennemi1 = new Hero("Hades, roi des Enfers");
            Hero ennemi2 = new Hero("l'Infame Hydre");

            Console.WriteLine("test");
            Hero.Attaque(ennemi1, hero1);
            Hero.Attaque(ennemi1, hero1);
            Hero.Attaque(ennemi1, hero1);
            Hero.Attaque(ennemi1, hero1);
            Hero.Attaque(ennemi1, hero1);
          
            int i = 1;
            int j = 1;
            while (i<1000)
            {
                Hero.Attaque(ennemi1, hero1);
                Hero.Attaque(ennemi1, hero1);
                Hero.Soigne(ennemi1, ennemi2);

                i++;
            }
            while (j<550)
            {
                Hero.Attaque(ennemi2, hero1);
                Hero.Attaque(hero1, ennemi2);

                j++;
            }
            while (true)
            {
                if (hero1.Victoire() && !FinPartie)
                {
                    FinPartie = true;
                    Console.WriteLine("           /\\                                                 /\\           ");
                    Console.WriteLine(" _         )( ______________________   ______________________ )(         _ ");
                    Console.WriteLine("(_)///////(**)______________________> <______________________(**)\\\\\\\\(_)");
                    Console.WriteLine("           )(                                                 )(           ");
                    Console.WriteLine("           \\/          "+ hero1.ToString() + " Remporte la partie !          \\/           ");
                }
            }




          
        }
    }
}