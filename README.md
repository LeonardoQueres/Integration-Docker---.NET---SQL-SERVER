## Thunders Project Documentation
### Docker - .NET 8 - C# - SQL SERVER

### Project Description
 - Application created to demonstrate the knowledge acquired in the `Docker course: creating and managing containers`.
 - .NET 8 was used with SQL SERVER database and Docker.
 - The docker-compose file was configured to download the SQL Server image, configure and create the container to be used by the application. 
	It is also configured to generate the application image and container. 

### System Requirements
 - .NET SDK: .NET Core 8 or higher
 - Editor/IDE: Visual Studio or Visual Studio Code
 - Docker Desktop
 - Windows PowerShell Terminal

### Project Structure
 - The basic structure of the project is as follows:
```
Thunders/
├── Thunders_Api
├── Thunders_Borders
├── Thunders_Repositories
├── Thunders_Tests
└── Thunders_UseCases
```

### Configuration
1. After downloading the project.

2. Run the command docker-compose up -d --build in the terminal.

NOTE: The docker-compose file is configured to download the SQL Server image and run the application.

NOTE: The application is running on port 3001 - https://localhost:3001/swagger/index.html

------------------------------------------------------------------------------------------------------------------------------------------------------------------


## Documentação do Projeto Thunders
### Docker - .NET 8 - C# - SQL SERVER

### Descrição do Projeto
 - Aplicação criada para demonstrar os conhecimentos adiquiridos no curso `Docker: criando e gerenciando containers`.
 - Foi utilizado .NET 8 com banco de dados SQL SERVER e Docker.
 - O arquivo docker-compose foi configurado para baixar a imagem do sql server, configurar e criar o container para se utilizado pela aplicação.
	Tambem esta configurado para gerar a imagem e container da aplicação.

## Requisitos do Sistema
 - .NET SDK: .NET Core 8 ou superior
 - Editor/IDE: Visual Studio ou Visual Studio Code
 - Docker Desktop
 - Terminal Windows PowerShell 

## Estrutura do Projeto
 - A estrutura básica do projeto é a seguinte:
```
Thunders/
├── Thunders_Api
├── Thunders_Borders
├── Thunders_Repositories
├── Thunders_Tests
└── Thunders_UseCases
```

## Configuração
1. Após baixar o projeto.

2. Execute o comando `docker-compose up -d --build` no terminal.

OBS.: O arquivo docker-compose esta configurado para baixar a imagem do sql server e executar a aplicação.

OBS.1: A aplicação esta rodando na porta 3001 - `https://localhost:3001/swagger/index.html`


   



