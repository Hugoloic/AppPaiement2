﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement2
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; }

        public Paypal(double montant, string description, string courriel) : base(montant, description)

        {
            Courriel = courriel;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"compte paypal : Montant {Montant}, Description: {Description}, Courriel: {Courriel}");

        }
    }
}
