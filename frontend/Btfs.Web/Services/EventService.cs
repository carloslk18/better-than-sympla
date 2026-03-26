using Btfs.Models;

namespace Btfs.Services;

/// <summary>
/// Fonte de dados mock para eventos alinhada com o contrato da API (UUIDs).
/// </summary>
public class EventService
{
    private readonly List<Category> _categories;
    private readonly List<Event> _events;

    public EventService()
    {
        // Categorias com IDs fixos para o mock
        var catShows = new Category { Id = "c111", Name = "Shows" };
        var catFest = new Category { Id = "c222", Name = "Festivais" };
        var catEsporte = new Category { Id = "c333", Name = "Esportes" };
        var catTeatro = new Category { Id = "c444", Name = "Teatro" };
        var catTech = new Category { Id = "c555", Name = "Tecnologia" };
        var catGastro = new Category { Id = "c666", Name = "Gastronomia" };
        var catArte = new Category { Id = "c777", Name = "Arte" };

        _categories = [catShows, catFest, catEsporte, catTeatro, catTech, catGastro, catArte];

        _events =
        [
            new()
            {
                Id = "e111",
                Title = "Lollapalooza Brasil 2025",
                Description = "O maior festival de música do Brasil retorna ao Autódromo de Interlagos.",
                CoverImageUrl = "https://images.unsplash.com/photo-1470229722913-7c0e2dbbafd3?w=800&q=80",
                StartDate = new DateTime(2025, 3, 28, 12, 0, 0),
                EndDate   = new DateTime(2025, 3, 30, 23, 59, 0),
                CreatedAt = new DateTime(2025, 1, 1),
                IsOnline  = false,
                Status    = "publicado",
                Location  = new Venue { Id = "v111", Name = "Autódromo de Interlagos", City = "São Paulo", State = "SP" },
                Categories = [catFest],
                TicketTypes =
                [
                    new() { Id = "t1", EventId = "e111", Name = "Pista", Price = 490m, QuantityAvailable = 500, SalesStartDate = DateTime.Now.AddDays(-30), SalesEndDate = new DateTime(2025, 3, 27) },
                    new() { Id = "t2", EventId = "e111", Name = "VIP", Price = 980m, QuantityAvailable = 100, SalesStartDate = DateTime.Now.AddDays(-30), SalesEndDate = new DateTime(2025, 3, 27) },
                ]
            },
            new()
            {
                Id = "e222",
                Title = "The Weeknd – After Hours Tour",
                Description = "The Weeknd (também pesquisado como The Weekend) traz sua icônica After Hours Tour para o Brasil.",
                CoverImageUrl = "https://images.unsplash.com/photo-1493225457124-a3eb161ffa5f?w=800&q=80",
                StartDate = new DateTime(2025, 5, 10, 21, 0, 0),
                EndDate   = new DateTime(2025, 5, 10, 23, 30, 0),
                CreatedAt = new DateTime(2025, 1, 10),
                IsOnline  = false,
                Status    = "publicado",
                Location  = new Venue { Id = "v222", Name = "Allianz Parque", City = "São Paulo", State = "SP" },
                Categories = [catShows],
                TicketTypes =
                [
                    new() { Id = "t3", EventId = "e222", Name = "Pista", Price = 320m, QuantityAvailable = 800, SalesStartDate = DateTime.Now.AddDays(-15), SalesEndDate = new DateTime(2025, 5, 9) },
                    new() { Id = "t4", EventId = "e222", Name = "Cadeira Inferior", Price = 580m, QuantityAvailable = 200, SalesStartDate = DateTime.Now.AddDays(-15), SalesEndDate = new DateTime(2025, 5, 9) },
                ]
            },
            new()
            {
                Id = "e333",
                Title = "TechConf 2025 – IA & Web",
                Description = "A maior conferência de tecnologia do Brasil. Palestras sobre IA, Web3 e Cloud.",
                CoverImageUrl = "https://images.unsplash.com/photo-1540575467063-178a50c2df87?w=800&q=80",
                StartDate = new DateTime(2025, 6, 14, 9, 0, 0),
                EndDate   = new DateTime(2025, 6, 15, 18, 0, 0),
                CreatedAt = new DateTime(2025, 2, 5),
                IsOnline  = false,
                Status    = "publicado",
                Location  = new Venue { Id = "v333", Name = "Expo Center Norte", City = "São Paulo", State = "SP" },
                Categories = [catTech],
                TicketTypes =
                [
                    new() { Id = "t5", EventId = "e333", Name = "Profissional", Price = 249m, QuantityAvailable = 400, SalesStartDate = DateTime.Now.AddDays(-60), SalesEndDate = new DateTime(2025, 6, 13) },
                ]
            },
            new()
            {
                Id = "e444",
                Title = "Sabores do Brasil – Festival Gastronômico",
                Description = "Reúne os melhores chefs do país em um festival de 4 dias.",
                CoverImageUrl = "https://images.unsplash.com/photo-1414235077428-338989a2e8c0?w=800&q=80",
                StartDate = new DateTime(2025, 7, 18, 11, 0, 0),
                EndDate   = new DateTime(2025, 7, 21, 22, 0, 0),
                CreatedAt = new DateTime(2025, 3, 1),
                IsOnline  = false,
                Status    = "publicado",
                Location  = new Venue { Id = "v444", Name = "Parque do Ibirapuera", City = "São Paulo", State = "SP" },
                Categories = [catGastro],
                TicketTypes = [new() { Id = "t6", EventId = "e444", Name = "Geral", Price = 45m, QuantityAvailable = 1000 }]
            },
            new()
            {
                Id = "e555",
                Title = "Maratona do Rio de Janeiro",
                Description = "A maratona mais linda do Brasil! 42km pela Zona Sul carioca.",
                CoverImageUrl = "https://images.unsplash.com/photo-1461896836934-ffe607ba8211?w=800&q=80",
                StartDate = new DateTime(2025, 6, 22, 6, 0, 0),
                EndDate   = new DateTime(2025, 6, 22, 14, 0, 0),
                CreatedAt = new DateTime(2025, 1, 15),
                IsOnline  = false,
                Status    = "publicado",
                Location  = new Venue { Id = "v555", Name = "Aterro do Flamengo", City = "Rio de Janeiro", State = "RJ" },
                Categories = [catEsporte],
                TicketTypes = [new() { Id = "t7", EventId = "e555", Name = "Inscrição", Price = 180m, QuantityAvailable = 3000 }]
            },
            new()
            {
                Id = "e666",
                Title = "Hamlet – Companhia Brasileira de Teatro",
                Description = "Uma releitura contemporânea de Shakespeare com elenco premiado.",
                CoverImageUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?w=800&q=80",
                StartDate = new DateTime(2025, 8, 5, 20, 0, 0),
                EndDate   = new DateTime(2025, 8, 5, 22, 30, 0),
                CreatedAt = new DateTime(2025, 4, 10),
                IsOnline  = false,
                Status    = "publicado",
                Location  = new Venue { Id = "v666", Name = "Teatro Municipal", City = "Curitiba", State = "PR" },
                Categories = [catTeatro],
                TicketTypes = [new() { Id = "t8", EventId = "e666", Name = "Plateia", Price = 60m, QuantityAvailable = 150 }]
            },
            new()
            {
                Id = "e777",
                Title = "Bienal de Arte Urbana SP",
                Description = "Uma semana celebrando a arte urbana brasileira.",
                CoverImageUrl = "https://images.unsplash.com/photo-1547036967-23d11aacaee0?w=800&q=80",
                StartDate = new DateTime(2025, 9, 12, 10, 0, 0),
                EndDate   = new DateTime(2025, 9, 19, 20, 0, 0),
                CreatedAt = new DateTime(2025, 5, 1),
                IsOnline  = false,
                Status    = "publicado",
                Location  = new Venue { Id = "v777", Name = "Vila Madalena", City = "São Paulo", State = "SP" },
                Categories = [catArte],
                TicketTypes = [new() { Id = "t9", EventId = "e777", Name = "Grátis", Price = 0m, QuantityAvailable = 5000 }]
            },
            new()
            {
                Id = "e888",
                Title = "Rock in Rio 2026 – Warm Up Online",
                Description = "Entrevistas exclusivas e behind-the-scenes do Rock in Rio 2026.",
                CoverImageUrl = "https://images.unsplash.com/photo-1524368535928-5b5e00ddc76b?w=800&q=80",
                StartDate = new DateTime(2025, 12, 1, 19, 0, 0),
                EndDate   = new DateTime(2025, 12, 1, 22, 0, 0),
                CreatedAt = new DateTime(2025, 6, 20),
                IsOnline  = true,
                Status    = "publicado",
                Location  = null,
                Categories = [catShows, catFest],
                TicketTypes = [new() { Id = "t10", EventId = "e888", Name = "Online", Price = 0m, QuantityAvailable = 99999 }]
            }
        ];
    }

    public Task<List<Event>> GetEventsAsync(string? categoryFilter = null, string? searchTerm = null, string? sortBy = null)
    {
        var query = _events.AsEnumerable();

        if (!string.IsNullOrWhiteSpace(categoryFilter) && categoryFilter != "Todos")
            query = query.Where(e => e.Categories.Any(c => c.Name == categoryFilter));

        if (!string.IsNullOrWhiteSpace(searchTerm))
            query = query.Where(e => e.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                                  || e.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                                  || e.Location?.City.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) == true);

        query = sortBy switch
        {
            "price_asc" => query.OrderBy(e => e.TicketTypes.Any() ? e.TicketTypes.Min(t => t.Price) : 0),
            "price_desc" => query.OrderByDescending(e => e.TicketTypes.Any() ? e.TicketTypes.Min(t => t.Price) : 0),
            "name_asc" => query.OrderBy(e => e.Title),
            "name_desc" => query.OrderByDescending(e => e.Title),
            "newest" => query.OrderByDescending(e => e.CreatedAt),
            _ => query.OrderByDescending(e => e.CreatedAt)
        };

        return Task.FromResult(query.ToList());
    }

    public Task<Event?> GetEventByIdAsync(string id) =>
        Task.FromResult(_events.FirstOrDefault(e => e.Id == id));

    public Task<List<Category>> GetCategoriesAsync() =>
        Task.FromResult(_categories);
}
