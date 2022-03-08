namespace RPGCallisthenics
{
    internal class Personne
    {
        Statut EtatDeVie;
        String Prenom; 

        public Personne(String PrenomPersonne)
        {
            EtatDeVie = new Statut();
            Prenom = PrenomPersonne;
        }
        public static String SePresente(Hero Sujet)
        {
            return Sujet.Prenom;
        }
        public static void TuerPersonne(Hero Sujet)
        {
            Console.WriteLine(Personne.SePresente(Sujet) + " est décédé");
            Statut.StatutMort(Sujet.EtatDeVie);
        }

    }
}