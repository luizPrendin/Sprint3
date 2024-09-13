# Sprint3-.NET

## Descrição da Arquitetura
A API segue a arquitetura **monolítica**, implementada com **ASP.NET Core Web API**, organizando as responsabilidades em camadas:

- **Controllers**: Gerenciam requisições HTTP e respostas.
- **Services**: Contêm a lógica de negócios.
- **Repository**: Acessa o banco de dados para CRUD.
- **Models**: Define as entidades e DTOs.
- **Database**: Configuração do Entity Framework com Oracle.

## Design Patterns Utilizados
1. **Repository Pattern**: Encapsula o acesso ao banco de dados.
2. **Dependency Injection**: Reduz acoplamento e facilita testes.
3. **Singleton Pattern**: Garante uma única instância para serviços.

## Instruções para Rodar a API

### Pré-requisitos
- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [Oracle Database](https://www.oracle.com/database/)
- [Postman](https://www.postman.com/downloads/)

### Configuração do Banco de Dados
1. Configure o banco de dados Oracle localmente.
2. Atualize a string de conexão no arquivo `appsettings.json` se necessário

## Integrantes do Grupo
Tomaz de Oliveira Pecoraro – RM98499

Rennan Ferreira da Cruz – RM99364

Jaisy Cibele Alves – RM552269

Luiz Felipe Camargo Prendin – RM552475

Gabriel Amâncio - RM97936


