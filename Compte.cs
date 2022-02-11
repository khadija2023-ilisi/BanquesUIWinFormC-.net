using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banques
{
    
    public class Compte
    {
        public int id;
        public static  double plafond = 1000;
        public static  double decouverte = 100;
        private static int nbCmpt=0;
        public int numcompte;
        private Client titulaire;
        public double solde;
        private List<Transaction> transaction;
        public Compte(int id,Client client,double sld, int numc)
        {
            this.id = id;
            this.numcompte = numc;
            this.titulaire = client;
            this.solde = sld;
        }
        public void crediter(double montant)
        {
            
            this.solde += montant;

        }
        public void debiter(double montant)
        {
           
            
            this.solde -= montant;
            
        }


        public String printCompte()
        {
            return "Compte : "+this.numcompte+"\n"+"Solde : "+this.solde+" DH\n"+this.titulaire.afficher()+"\n";
        }

    }
}
