using System.Runtime.InteropServices;

namespace Authentification
{
	public class Livre
	{
        //attributs 
        public string Nom { get; set; }
        public int LivreID { get; set; }

        public Livre()
        {
        }

        //methodes
        public Livre(int id)
		{
			this.LivreID = id;
		}
		public Livre(string nom)
		{
			this.Nom = nom;
		}

	}

}
