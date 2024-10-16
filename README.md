## Documentação do Projeto Thunders
### Docker - .NET - C# - SQL SERVER

### Descrição do Projeto
 - Desenvolver um CRUD utilizando API REST, seguindo boas práticas de programação. O objeto do CRUD será uma lista de tarefas.

## Requisitos do Sistema
 - .NET SDK: .NET Core 8 ou superior
 - Editor/IDE: Visual Studio ou Visual Studio Code

## Estrutura do Projeto

A estrutura básica do projeto é a seguinte:
```
Thunders/
├── Thunders_Api
├── Thunders_Borders
├── Thunders_Repositories
├── Thunders_Tests
└── Thunders_UseCases
```
## Configuração
1. Após baixar o projeto. Execute o comando `docker-compose up --build` no terminal.

OBS.: O arquivo docker-compose esta configurado para baixar a imagem do sql server e a aplicação.
OBS.2: O arquivo Program.cs esta configurado para rodar o migration quando subir a aplicação em desenvolvimento.
OBS.3: A aplicação esta rodando na porta 3001 - `https://localhost:3001/swagger/index.html`


   



