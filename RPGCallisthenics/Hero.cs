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
                Console.WriteLine(Personne.SePresente(Initiateur) + " Attaque ! Sa cible est :"+ Personne.SePresente(Cible));
                Cible.Vie = VieEnMoins(Cible.Vie, Initiateur.Niveau);
                Console.WriteLine(Personne.SePresente(Cible) + " perd " + NiveauDePuissance(Initiateur.Niveau) + " point de vie !") ;
            }
            if (Sante.EstMort(Cible.Vie) && EstTuable)
            {
                Personne.TuerPersonne(Cible);
                Initiateur.Niveau = GainDeNiveau(Initiateur.Niveau);
                Console.WriteLine(Personne.SePresente(Initiateur) + " Gagne en puissance !");
            }
        }
        public static Sante VieEnMoins (Sante CibleVie,Level Montant)
        {
            CibleVie.DamageDown(Montant);
            return CibleVie;
        }


        public static void Soigne (Hero Cible,Hero Initiateur)
        {
            bool EstSoignable = Sante.EstSoignable(Cible.Vie) && !Sante.EstMort(Cible.Vie);
            if (EstSoignable)
            {
                Console.WriteLine(Personne.SePresente(Initiateur) + " invoque un sort de soin ! Sa cible est :" + Personne.SePresente(Cible));
                Cible.Vie = VieEnPlus(Cible.Vie, Initiateur.Niveau);
                Console.WriteLine(Personne.SePresente(Cible) + " se sent revigoré !");
            }
        }
        public static Sante VieEnPlus(Sante CibleVie,Level Montant)
        {
            CibleVie.HealUp(Montant);
            return CibleVie;
        }
        public static Level GainDeNiveau(Level LevelHero)
        {
            LevelHero.LevelUP();
            return LevelHero;
        }

        public static int NiveauDePuissance(Level NiveauHero)
        {
            return NiveauHero.Valeur;
        }
       

    }
}
