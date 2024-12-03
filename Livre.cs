public class Livre : Article
{
    protected string ISBN;
    protected int NbPages;

    public Livre(string designation, double prix, int quantite, string isbn, int nbPages)
        : base(designation, prix, quantite)
    {
        ISBN = isbn;
        NbPages = nbPages;
    }

    public new void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"ISBN: {ISBN}, Nombre de pages: {NbPages}");
    }
}
