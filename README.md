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
1. Certifique-se de verificar se os dados da ConnectionStrings no arquivo `appsettings.Development.json` são os mesmo utilizados na criação do banco de dados no docker

## Criação do Banco de Dados
Para baixar a imagem do banco de dados, use o seguinte comando no terminal:
```
docker pull mcr.microsoft.com/mssql/server:2022-latest
```
Para subir o container do banco de dados, use o seguinte comando no terminal:
```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=123456' -p 1433:1433 --name MDNsqlserver -d mcr.microsoft.com/mssql/server:2022-latest 
```
- Execute o Projeto utilizando Visual studio ou vs code


