using System;

public class ArticleTableau
{
    private Article[] Articles;

    public ArticleTableau()
    {
        Articles = new Article[]
        {
            new Livre("Livre A", 12.99, 5, "123-456", 200),
            new Disque("Disque B", 9.99, 3, "Label B"),
            new Video("Vidéo C", 19.99, 2, 120)
        };
    }

    public void AfficherTableau()
    {
        Console.WriteLine("Liste des articles :");
        foreach (var article in Articles)
        {
            article.Afficher();
            Console.WriteLine();
        }
    }
}
