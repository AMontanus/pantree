namespace PanTree.Gumbo;

public record struct BigJankos(string Aya, double Oof, bool Dank)
{
    public static implicit operator BigJankos(string _) => new(_, 50d, false);
}

public static class Janky
{
    public static void MapJankyJanks(this WebApplication app)
    {
        var group = app.MapGroup("api/jankyjanks").WithOpenApi();
        
        group.MapGet("ohboy", async () => new BigJankos($"{Guid.NewGuid()}", Random.Shared.NextDouble(), Random.Shared.Next(1, 10) == 1)).WithName("Ooooooooooohboyo").Produces<BigJankos>();
    }
}