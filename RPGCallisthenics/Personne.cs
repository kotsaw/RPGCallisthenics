namespace RPGCallisthenics
{
    internal class Personne
    {
        Statut EtatDeVie;

        //Hors du sujet : utile pour la console 
        readonly String Prenom; 

        public Personne(String PrenomPersonne)
        {
            EtatDeVie = new Statut();
            Prenom = PrenomPersonne;
        }
        override public String ToString()
        {
            return Prenom;
        }
        public static void TuerPersonne(Hero Sujet)
        {
            Console.WriteLine(Sujet.ToString() + " est décédé");
            Statut.StatutMort(Sujet.EtatDeVie);
        }

    }
}