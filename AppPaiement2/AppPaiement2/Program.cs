using AppPaiement2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        CarteCredit Paiement1 = new CarteCredit(100.20, "achat de chaussure", 854453258);
        CarteCredit Paiement2 = new CarteCredit(200.50, "achat de livres", 985412032);
        CarteCredit Paiement3 = new CarteCredit(80.60, "achat de nourriture", 547896521);

        Paiement1.AfficherDetails();
        Paiement2.AfficherDetails();
        Paiement3.AfficherDetails();

        Paypal paiementpaypal1 = new Paypal(500.50, "tranfert d'achat", "hugoloic@gmail.com");
        Paypal paiementpaypal2 = new Paypal(1000.00, "achat des chaussures", "nanaloic@gmail.com");

        paiementpaypal1.AfficherDetails();
        paiementpaypal2.AfficherDetails();


        Utilisateur utilisateur = new Utilisateur("HUGO LOIC");

        utilisateur.AjouterPaiement(Paiement1);
        utilisateur.AjouterPaiement(Paiement2);
        utilisateur.AjouterPaiement(Paiement3);
        utilisateur.AjouterPaiement(paiementpaypal1);
        utilisateur.AjouterPaiement(paiementpaypal2);


        utilisateur.AfficherInfos();






    }
}