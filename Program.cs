class Program
{
    static void Main(string[] args)
    {
        // Exercice 1: Création d'articles
        var article1 = new Article("Clé USB", 15.99, 10);
        var article2 = new Article("Câble HDMI", 5.5, 20);
        var article3 = new Article("Savon", 1.99, 50);

        article1.Afficher();
        article2.Afficher();
        article3.Afficher();

        // Modification des quantités
        article1.Ajouter(5);
        article2.Retirer(3);

        Console.WriteLine("\nAprès modification :");
        article1.Afficher();
        article2.Afficher();
        article3.Afficher();

        // Exercice 2: Création d'articles typés
        var disque = new Disque("CD de musique", 9.99, 5, "Label X");
        disque.Afficher();

        // Exercice 3: Saisie utilisateur
        Console.WriteLine("\nCréation d'un article personnalisé :");
        Console.Write("Nom : ");
        string nom = Console.ReadLine();
        Console.Write("Prix : ");
        double prix = Convert.ToDouble(Console.ReadLine());
        Console.Write("Quantité : ");
        int quantite = Convert.ToInt32(Console.ReadLine());

        var articleSaisi = new Article(nom, prix, quantite);
        articleSaisi.Afficher();

        // Exercice 4: Tableau d'articles
        Console.WriteLine("\nGestion d'un tableau d'articles :");
        var tableau = new ArticleTableau();
        tableau.AfficherTableau();
    }
}
