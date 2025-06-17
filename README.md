# 🧠 KernelBlog

Blog colaborativo feito por devs apaixonados por tecnologia — um espaço onde compartilhamos tudo sobre **Development**, **Cyber Security**, **Game Developer** e muito mais!

---

## 📌 Sobre o projeto

O **KernelBlog** é um blog de artigos técnicos construído com foco em na prática e colaboração entre amigos desenvolvedores. Cada autor tem uma conta de administrador e pode publicar, editar ou remover seus artigos.

Este projeto está sendo desenvolvido de forma puramente **prática e incremental**, com o objetivo de colocar absorver conceitos de:

- ASP.NET Core (Web API)
- Blazor (Interface Web)
- Entity Framework (ORM)
- SQLite
- Estrutura organizada por responsabilidade (MVC)
- Padrão REST
- Code First

---

## 🚀 Tecnologias usadas

| Camada         | Stack                                 |
|----------------|----------------------------------------|
| Frontend       | Blazor WebAssembly                     |
| Backend        | ASP.NET Core + EF Core                 |
| Banco de Dados | SQLite                                 |
| Controle de Versão | Git + GitHub                       |

---

## 📂 Estrutura do projeto

```bash
KernelBlog.sln
│
├── KernelBlog.API/              
│   ├── Controllers/             
│   ├── Data/                    
│   ├── Models/                  
│   ├── Program.cs               
│   └── appsettings.json          
│
├── Migrations/                   
├── kernelblog.db                
└── README.md                    
```
---

## ⚙️ Como rodar o projeto localmente

```bash
# Clonar o repositório
git clone https://github.com/carloslk18/kernel-panic-blog.git

cd kernel-panic-blog/KernelBlog.API

# Restaurar os pacotes
dotnet restore

# Rodar a aplicação
dotnet run
```
---
## 📢 Em construção...
Este repositório está em desenvolvimento constante. Fique à vontade para acompanhar, sugerir melhorias ou contribuir!