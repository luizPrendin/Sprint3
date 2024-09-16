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

Antes de rodar a API, certifique-se de ter os seguintes itens instalados:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Postman](https://www.postman.com/downloads/) (para testar os endpoints)

### Configuração do Banco de Dados e Deploy

1. **Configure o Banco de Dados:**
   - Siga as instruções fornecidas para configurar o banco de dados localmente.

2. **Atualize a String de Conexão:**
   - Abra o arquivo `appsettings.json` localizado na raiz do projeto.
   - Atualize o valor da chave `SqlSeverAzure` em `ConnectionStrings` com as informações de conexão do seu banco de dados Oracle. Exemplo:
     ```json
     "ConnectionStrings": {
       "SqlSeverAzure": "Data Source=seu_host:1521/seu_serviço;User ID=seu_usuario;Password=sua_senha;"
     }
     ```
   -Após a alteração da String de conexão, realize o commit para iniciar o deploy da aplicação via github Actions
### Instalação

1. **Clone o Repositório:**
   - Clone o repositório para o seu ambiente local usando o seguinte comando:
     ```bash
     git clone https://github.com/luizPrendin/Sprint3.git
     ```
   - Navegue para o diretório do projeto:
     ```bash
     cd Sprint3
     ```

2. **Restaure as Dependências:**
   - Execute o comando para restaurar as dependências do projeto:
     ```bash
     dotnet restore
     ```

### Execução

1. **Rodar a API Localmente:**
   - Para rodar a API localmente, use o seguinte comando:
     ```bash
     dotnet run --project Sprint3.API/Sprint3.API.csproj
     ```
   - A API estará disponível em `https://localhost:5001` por padrão.

2. **Acessar a API Localmente:**
   - A documentação Swagger pode ser acessada localmente navegando para:
     ```markdown
     https://localhost:7035/swagger/index.html
     ```

3. **Publicar e Acessar a API via Azure App Service:**
   - Caso tenha publicado a API no **Azure App Service**, você poderá acessá-la remotamente utilizando a URL do serviço fornecida pelo Azure. O padrão de URL será algo como `https://<nome-do-seu-app>.azurewebsites.net`.
   - Para acessar a documentação Swagger remotamente, navegue para a seguinte URL (substitua `<nome-do-seu-app>` pelo nome do seu aplicativo no Azure):
     ```markdown
     https://<nome-do-seu-app>.azurewebsites.net/swagger/index.html
     ```

4. **Script JSON para Operações CRUD:**
   - Para realizar operações CRUD (Create, Read, Update, Delete) na API, você pode utilizar o seguinte formato de script JSON para requisições via **Postman** ou **cURL**:

     - **Exemplo de Requisição POST (Criar um novo usuário)**:
       ```json
       {          
         "nome": "João da Silva",
         "email": "joao.silva@example.com"
       }
       ```

     - **Exemplo de Requisição GET (Obter um usuário específico)**:
       ```bash
       curl -X GET "https://adoptimize.azurewebsites.net/Services/getValue?value=3" -H "accept: application/json"
       ```

     - **Exemplo de Requisição PUT (Atualizar um usuário existente)**:
       ```json
       {
         "id": 1,
         "name": "João da Silva Atualizado",
         "email": "joao.silva@example.com"
       }
       ```

     - **Exemplo de Requisição DELETE (Remover um usuário)**:
       ```bash
       curl -X DELETE "https://adoptimize.azurewebsites.net/api/users/1"
       ```

### Testes

1. **Executar Testes Automatizados:**
   - Para rodar os testes automatizados, use o comando:
     ```bash
     dotnet test
     ```

### Exemplos de Uso

#### Requisição GET para `api/users`

```bash
curl -X GET "https://localhost:5001/api/users" -H "accept: application/json"
```



## Integrantes do Grupo
Tomaz de Oliveira Pecoraro – RM98499

Rennan Ferreira da Cruz – RM99364

Jaisy Cibele Alves – RM552269

Luiz Felipe Camargo Prendin – RM552475

Gabriel Amâncio - RM97936


