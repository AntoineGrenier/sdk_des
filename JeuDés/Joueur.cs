using JeuDés.Dés;

namespace JeuDés
{
    public class Joueur
    {
        public string Prenom {  get; set; }
        public string Nom { get; set; }
        public int Score { get; set; }

        public Joueur()
        {
            Nom = "";
            Prenom = "";
            Score = 0;
        }

        public Joueur(string nom, string prenom) 
        {
            Nom = nom;
            Prenom = prenom;
            Score = 0;
        }

        public void Jouer(List<Dé> dés)
        {
            var iValeur = 0;
            for (int i = 0; i < dés.Count; i++) 
            {
                iValeur = iValeur + dés[i].Lancer();
            }
            Score = iValeur;
        }
    }
}
