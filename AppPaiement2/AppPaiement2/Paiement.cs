using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement2
{
    internal class Paiement
    {
        public double Montant { get; set; }
        public string Description {  get; set; }

        public Paiement(double montant, string description) 
        {
            Montant = montant; Description = description; 
        }
        public virtual void AfficherDetails() 
        {
            Console.WriteLine($"le solde de votre carte est de : Montant {Montant}, Description {Description}");
        }
    }
}
