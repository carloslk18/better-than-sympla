using Btfs.Models;

namespace Btfs.Services;

/// <summary>
/// Serviço de carrinho compartilhado via DI (Scoped).
/// Registrado em Program.cs como Scoped para que o estado persista
/// durante a sessão do navegador — será limpo ao recarregar a página.
/// Quando houver API, este serviço chamará o endpoint de criação de pedido.
/// </summary>
public class CartService
{
    // Dicionário: TicketTypeId -> (TicketType, Quantidade)
    private readonly Dictionary<string, (TicketType Ticket, int Quantity)> _items = [];

    public event Action? OnChange;

    public IReadOnlyList<(TicketType Ticket, int Quantity)> Items =>
        _items.Values.ToList().AsReadOnly();

    public int TotalItems => _items.Values.Sum(i => i.Quantity);

    public decimal TotalPrice => _items.Values.Sum(i => i.Ticket.Price * i.Quantity);

    public string TotalPriceDisplay => $"R$ {TotalPrice:N2}";

    // ─── Mutações ────────────────────────────────────────────────────────────

    public void AddOrUpdate(TicketType ticket, int quantity)
    {
        if (quantity <= 0)
        {
            _items.Remove(ticket.Id);
        }
        else
        {
            _items[ticket.Id] = (ticket, quantity);
        }
        NotifyChange();
    }

    public void Remove(string ticketTypeId)
    {
        _items.Remove(ticketTypeId);
        NotifyChange();
    }

    public void Clear()
    {
        _items.Clear();
        NotifyChange();
    }

    public int GetQuantity(string ticketTypeId) =>
        _items.TryGetValue(ticketTypeId, out var item) ? item.Quantity : 0;

    private void NotifyChange() => OnChange?.Invoke();
}
