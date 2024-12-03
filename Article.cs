public class Article
{
    protected string Designation;
    protected double Prix;
    protected int Quantite;

    public Article(string designation, double prix, int quantite)
    {
        Designation = designation;
        Prix = prix;
        Quantite = quantite;
    }

    public void Afficher()
    {
        Console.WriteLine($"Nom: {Designation}, Prix: {Prix}€, Quantité: {Quantite}");
    }

    public void Ajouter(int quantite)
    {
        if (quantite > 0)
            Quantite += quantite;
    }

    public void Retirer(int quantite)
    {
        if (quantite > 0 && Quantite >= quantite)
            Quantite -= quantite;
    }
}
