using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppPaiement2
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte {  get; set; }

        public CarteCredit(double montant, string description, int numeroCarte) : base (montant ,description)
        {
            NumeroCarte = numeroCarte;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"carte de credit : Montant {Montant}, Description: {Description}, NumeroCarte: {NumeroCarte}");
        }
    }
}
