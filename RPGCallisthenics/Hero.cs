using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCallisthenics
{
    internal class Hero : Personne
    {
        private Sante Vie;
        private Level Niveau;

        public Hero(String Prenom):base(Prenom)
        {
            Vie = new Sante();
            Niveau = new Level();
        }


        public static void Attaque (Hero Cible,Hero Initiateur)
        {
            bool EstTuable = Sante.EstVivant(Cible.Vie);
            bool EstEnEtatDAttaquer = Sante.EstVivant(Initiateur.Vie);
            if (EstTuable && EstEnEtatDAttaquer)
            {
                Console.WriteLine(Initiateur.ToString() + " Attaque ! Sa cible est :"+ Cible.ToString());
                Cible.Vie = VieEnMoins(Cible.Vie, Initiateur.Niveau);
                Console.WriteLine(Cible.ToString() + " perd " + NiveauDePuissance(Initiateur.Niveau) + " point de vie !") ;
            }
            if (Sante.EstMort(Cible.Vie) && EstTuable)
            {
                Personne.TuerPersonne(Cible);
                Initiateur.Niveau = GainDeNiveau(Initiateur.Niveau);
                Console.WriteLine(Initiateur.ToString() + " Gagne en puissance !");
            }
        }
        private static Sante VieEnMoins (Sante CibleVie,Level Montant)
        {
            CibleVie.DamageDown(Montant);
            return CibleVie;
        }


        public static void Soigne (Hero Cible,Hero Initiateur)
        {
            bool EstSoignable = Sante.EstSoignable(Cible.Vie) && !Sante.EstMort(Cible.Vie);
            if (EstSoignable)
            {
                Console.WriteLine(Initiateur.ToString() + " invoque un sort de soin ! Sa cible est :" + Cible.ToString());
                Cible.Vie = VieEnPlus(Cible.Vie, Initiateur.Niveau);
                Console.WriteLine(Cible.ToString() + " se sent revigoré !");
            }
        }
        private static Sante VieEnPlus(Sante CibleVie,Level Montant)
        {
            CibleVie.HealUp(Montant);
            return CibleVie;
        }
        private static Level GainDeNiveau(Level LevelHero)
        {
            LevelHero.LevelUP();
            return LevelHero;
        }

        private static int NiveauDePuissance(Level NiveauHero)
        {
            return NiveauHero.Valeur;
        }
        public bool Victoire()
        {
            return Sante.EstVivant(this.Vie);
        }

        
    }
}
