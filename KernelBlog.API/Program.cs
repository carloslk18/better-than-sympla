using KernelBlog.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); // Cria o builder do app

// Add suporte a Controllers (API)
builder.Services.AddControllers();

// Add o DbContext e config com SQLite
builder.Services.AddDbContext<KernelBlogContext>(options =>
    options.UseSqlite("Data Source=kernelblog.db"));

// Add o Swagger (documentacão)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build(); // Constroi o app com as configs acima

app.UseSwagger(); // Middleware do Swagger
app.UseSwaggerUI(); // UI do Swagger
app.UseHttpsRedirection(); // Redireciona HTTP -> HTTPS
app.UseAuthorization(); // Ativa o sistema de Autorização
app.MapControllers(); // Liga os EndPoints

app.Run(); // Roda o serv da API