namespace JeuDés.Dés
{
    public abstract class Dé
    {
        public List<int> Faces { get; set; }

        public Dé(int iNbrFaces)
        {
            Faces = new List<int>();
            for (int i = 1; i <= iNbrFaces; i++)
            {
                Faces.Add(i);
            }
        }

        public virtual int Lancer()
        {
            int nbr = Faces.Count;
            var rad = new Random();
            var index = rad.Next(nbr - 1);
            return Faces[index];
        }
    }
}
