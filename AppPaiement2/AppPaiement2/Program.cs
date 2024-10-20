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




    }
}