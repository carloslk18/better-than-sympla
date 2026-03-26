namespace Btfs.Models;

/// <summary>
/// Espelha a tabela `ticket_type` — representa um lote/tipo de ingresso de um evento.
/// Ex: "Pista", "Meia Entrada", "VIP", "Camarote".
/// </summary>
public class TicketType
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string EventId { get; set; } = "";       // FK -> event.id
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Price { get; set; }
    public int QuantityAvailable { get; set; }
    public DateTime SalesStartDate { get; set; }
    public DateTime SalesEndDate { get; set; }

    // Helpers de apresentação
    public bool IsSoldOut => QuantityAvailable <= 0;
    public bool IsSalesOpen => DateTime.Now >= SalesStartDate && DateTime.Now <= SalesEndDate;
    public string PriceDisplay => Price == 0 ? "Gratuito" : $"R$ {Price:N2}";
}
