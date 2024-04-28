# Sistema CRUD Básico MVC

Este é um sistema CRUD básico implementado usando ASP.NET Core MVC e Entity Framework Core 8.0.4. Ele configura e gerencia o banco de dados automaticamente através de migrations ao iniciar a aplicação.

## Tecnologias Utilizadas

- .NET Core (ASP.NET Core MVC)
- Entity Framework Core 8.0.4

## Configuração Inicial

Para executar este projeto, é necessário ter o ambiente .NET configurado e uma instância de SQL Server disponível. Siga as instruções abaixo para configurar e iniciar seu projeto.

### Pré-requisitos

- .NET SDK (verifique a versão compatível com Entity Framework Core 8.0.4)
- SQL Server

### Configuração do Banco de Dados

1. Modifique a string de conexão conforme seu ambiente SQL Server no arquivo `Program.cs`:

   ```csharp
   builder.Services.AddDbContext<MyDbContext>(options =>
       options.UseSqlServer("Server=SEU_SERVIDOR;Database=TaskListDB;Integrated Security=True;Encrypt=true;TrustServerCertificate=true;"));

## Aplicando Migrations Automaticamente
O sistema está configurado para aplicar automaticamente as migrations ao iniciar, usando o seguinte bloco de código em Program.cs:
   ```csharp
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<MyDbContext>();
    dbContext.Database.Migrate();
}
```
Este bloco garante que o banco de dados esteja sempre atualizado com as últimas migrations sem intervenção manual.

