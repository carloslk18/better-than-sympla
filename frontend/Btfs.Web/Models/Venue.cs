namespace Btfs.Models;

public class Venue
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string ZipCode { get; set; } = "";

    /// <summary>Retorna "Cidade, Estado" formatado para exibição nos cards.</summary>
    public string DisplayLocation => $"{City}, {State}";
}
