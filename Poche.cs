public class Poche : Livre
{
    private string Categorie;

    public Poche(string designation, double prix, int quantite, string isbn, int nbPages, string categorie)
        : base(designation, prix, quantite, isbn, nbPages)
    {
        Categorie = categorie;
    }

    public new void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Catégorie: {Categorie}");
    }
}
