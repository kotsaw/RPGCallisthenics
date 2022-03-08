namespace RPGCallisthenics
{
    internal class Statut
    {
        bool Valeur;

        public Statut( )
        {
            Valeur = true;
        }
        public static void StatutMort(Statut Personne)
        {
            Personne.Valeur = false;
        }
    }
}