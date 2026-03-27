namespace Btfs.Models;

/// <summary>
/// Espelha a tabela `categorie` do banco.
/// O nome da tabela no DB tem typo ("categorie"), mas no código usamos o inglês correto "Category".
/// </summary>
public class Category
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = "";

    // Mapeamento auxiliar: ícone por categoria (sem dependência de lib externa)
    public string Icon => Name.ToLower() switch
    {
        "shows"     => "🎵",
        "festivais" => "🎪",
        "esportes"  => "⚽",
        "teatro"    => "🎭",
        "tecnologia"=> "💻",
        "gastronomia"=> "🍽️",
        "arte"      => "🎨",
        _           => "📅"
    };
}
