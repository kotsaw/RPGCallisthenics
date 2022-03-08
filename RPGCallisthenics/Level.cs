namespace RPGCallisthenics
{
    internal class Level
    {
        public int Valeur;
        public Level()
        {
            Valeur = 1;
        }
        public void LevelUP ()
        {
            Valeur = Valeur + 1;
        }

    }
}