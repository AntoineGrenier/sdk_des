using JeuDés.Dés.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDés.Dés
{
    public class FabriqueDés
    {
        public List<Dé> Fabrique(int nbrDés, int nbrFace)
        {
            var liste = new List<Dé>();
            switch (nbrFace)
            {
                case 6:
                    for(int i = 0; i < nbrDés; i++)
                    {
                        liste.Add(new DéSixFaces());
                    }
                    break;
                case 8:
                    for (int i = 0; i < nbrDés; i++)
                    {
                        liste.Add(new DéHuitFaces());
                    }
                    break;
                case 100:
                    for (int i = 0; i < nbrDés; i++)
                    {
                        liste.Add(new DéCentFaces());
                    }
                    break;
                default:
                    for (int i = 0; i < nbrDés; i++)
                    {
                        liste.Add(new DéSixFaces());
                    }
                    break;
            }
            return liste;
        }
    }
}
