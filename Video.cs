public class Video : Article
{
    protected int Duree; // en minutes

    public Video(string designation, double prix, int quantite, int duree)
        : base(designation, prix, quantite)
    {
        Duree = duree;
    }

    public void AfficherVideo()
    {
        Console.WriteLine($"Vous regardez la vidéo: {Designation} ({Duree} minutes)");
    }

    public new void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Durée: {Duree} minutes");
    }
}
