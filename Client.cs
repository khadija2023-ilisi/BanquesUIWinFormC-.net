using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banques
{
    public class Client
    {
        public int id;
        public String nom { get; }
        public String prenom { get; }
        public String CIN { get; }
        public String login { get; }
        public String motDePasse { get; }
        public List<Compte> mesComptes { get; }
        public Client(int id,String n, String p, String cin, String L, String m)
        {
            this.id = id;
            this.nom = n;
            this.prenom = p;
            this.CIN = cin;
            this.login = L;
            this.motDePasse = m;
            this.mesComptes = new List<Compte>();
        }
        public void addCompte(Compte compte)
        {
            foreach(Compte c in this.mesComptes)
            {
                if (c == compte) return;
            }
            this.mesComptes.Add(compte);
        }
        public void removeCompte(Compte compte)
        {
            foreach (Compte c in this.mesComptes)
            {
                if (c == compte)
                {
                    this.mesComptes.Remove(compte);
                }
            }
        }
        public String afficher()
        {
            String s = "";
            // Console.WriteLine("Nom : " +
            s += this.nom + "\n";
            //Console.WriteLine("Prenom : " +
            s += this.prenom + "\n";
            //Console.WriteLine("Cin : " +
            s += this.CIN + "\n";
            //Console.WriteLine("Login : " +
            s += this.login;
            return s;
        }
    }
}
