using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement2
{
    internal class Utilisateur
    {
        public string Nom {  get; set; }
        public List<Paiement> List_Paiement{ get; set; }

        public Utilisateur (string nom)
        {
            Nom = nom;
            List_Paiement = new List<Paiement>();
        }
        public void AjouterPaiement(Paiement paiement)
        {
            List_Paiement.Add(paiement);
        }
        public void AfficherInfos()
        {
            Console.WriteLine($" Utilisateur: {Nom}");
            Console.WriteLine("Liste des paiements:");

            foreach (var Paiement in List_Paiement)
            {
                Paiement.AfficherDetails();
            }
        }
    }
}
