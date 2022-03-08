namespace RPGCallisthenics
{
    internal class Sante
    {
        public int Valeur;
        public Sante(int Montant)
        {
            Valeur = Montant;
        }
        public Sante()
        {
            Valeur = 1000;
        }
        public void HealUp (Level Montant)
        {
            this.Valeur = (int)this.Valeur + Montant.Valeur;
        }
        public void DamageDown (Level Montant)
        {
            this.Valeur = (int)this.Valeur - Montant.Valeur;
            if ( this.Valeur < 0)
            {
                this.Valeur = 0;
            }
        }
        public static bool EstMort (Sante Montant)
        {
            return (Montant.Valeur <= 0);
                
        }
        public static bool EstVivant (Sante Montant)
        {
            return (Montant.Valeur > 0);
        }
        public static bool EstSoignable (Sante Montant)
        {
            return (Montant.Valeur <= 1000);
        }
    }
}