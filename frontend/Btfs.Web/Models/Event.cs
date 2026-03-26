namespace Btfs.Models;

/// <summary>
/// Espelha a tabela `event` do banco.
/// Inclui propriedades de navegação para Venue, Categories e TicketTypes —
/// que serão preenchidas pelo EventService (mock) ou pela API futura.
/// </summary>
public class Event
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? OrganizerId { get; set; }
    public string? LocationId { get; set; }

    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsOnline { get; set; }

    /// <summary>Status do evento: "publicado", "cancelado", "rascunho", "encerrado"</summary>
    public string Status { get; set; } = "publicado";

    public DateTime CreatedAt { get; set; }

    // URL da imagem de capa (mockada; virá da API no futuro)
    public string CoverImageUrl { get; set; } = "";

    // Propriedades de navegação (preenchidas pelo serviço)
    public Venue? Location { get; set; }
    public List<Category> Categories { get; set; } = [];
    public List<TicketType> TicketTypes { get; set; } = [];

    // ── Helpers de apresentação ──────────────────────────────────────────────

    /// <summary>Menor preço entre os lotes disponíveis, ou null se não houver lotes.</summary>
    public decimal? MinPrice => TicketTypes.Any()
        ? TicketTypes.Min(t => t.Price)
        : null;

    public string PriceDisplay => MinPrice switch
    {
        null    => "Consulte",
        0       => "Gratuito",
        decimal p => $"A partir de R$ {p:N2}"
    };

    public bool IsUpcoming => StartDate > DateTime.Now;
    public bool IsCancelled => Status == "cancelado";

    /// <summary>Ex: "Sáb, 12 Jul · 20h"</summary>
    public string DateDisplay =>
        StartDate.ToString("ddd, dd MMM · HH'h'", new System.Globalization.CultureInfo("pt-BR"));
}
