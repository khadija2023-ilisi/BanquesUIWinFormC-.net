using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banques
{
    public class Transaction
    {
        public int id { get; }
        public String type { get; }
        public double montant { get; }
        public String time { get; }
        public Compte compt { get; }
        public Transaction(int id,String type, double montant, String time,Compte c)
        {
            this.id = id;
            this.time = time;
            this.type = type;
            this.montant = montant;
            this.compt = c;
        }
        public String toString()
        {
            return "Transaction id :" + id + " Type : " + type + " Montant :" + montant + "dh  time: " + time;
        }
    }
}
