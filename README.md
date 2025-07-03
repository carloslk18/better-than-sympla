# 🧠 Kernel Blog

Collaborative tech blog built by passionate devs space to share knowledge about **Development**, **CyberSec**, **DevOps**, **GameDev**, and more!

---

## 📌 About

**KernelPanic** is a collaborative technical blog made for learning and sharing. Each author has their own admin account and can publish, edit, or delete articles.  
This project is built incrementally, showcasing practical implementation:

- ASP.NET Core Web API
- React + Next.js
- JavaScript / TypeScript
- Entity Framework Core (Code First)
- Organized folder structure: Models, Controllers, Data.
- SQLite as a lightweight development database
- Git flow, branching and pull requests

---

## 🚀 Stack

| Layer         | Tech                                       |
|---------------|--------------------------------------------|
| Frontend      | Next.js + TypeScript                       |
| Backend       | ASP.NET Core (Web API)                     |
| ORM           | EF Core + Dapper                           |
| Database      | SQLite                                     |
| Version Ctrl. | Git + GitHub                               |

---

## 📂 Project Sctructure

```bash
KernelBlog.sln
│
├── KernelBlog.API/              
│   ├── Controllers/             
│   ├── Data/                    
│   ├── Models/                  
│   ├── Program.cs               
│   ├── appsettings.json
|   └── Migrations/         
│                  
├── kernelblog.db                
└── README.md                    
```
---

## ⚙️ Getting Started Locally

```bash
# Clone the repo
git clone https://github.com/carloslk18/kernel-panic-blog.git

cd kernel-panic-blog/KernelBlog.API

# Restore dependencies
dotnet restore

# Run the API
dotnet run
```
---

## 🧪 Database Setup

```bash
dotnet ef migrations add SomeMigrationName
dotnet ef database update
```
