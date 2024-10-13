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

2. Criação do Banco de Dados

3. Para baixar a imagem do banco de dados, use o seguinte comando no terminal:
```
docker pull mcr.microsoft.com/mssql/server:2022-latest
```
4. Para subir o container do banco de dados, use o seguinte comando no terminal:
```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=leoQueres123' -p 1433:1433 --name MDNsqlserver -d mcr.microsoft.com/mssql/server:2022-latest 
```
5. Execute o Projeto utilizando Visual studio ou vs code

6. Antes de executar o update-migration verificar no arquivo `appsettings.Development.json` se o Server na ConnectionStrings esta `localhost`, altere caso necessário.
![image](https://github.com/user-attachments/assets/19fdbf75-84e3-4b26-9c4f-ef5811e7e249)
   
7. Abra o Console do Gerenciador de Pacotes e execute o comando `update-database`

8. Altere o host da ConnectionStrings de `localhost` para `host.docker.internal` no arquivo `appsettings.Development.json`
![image](https://github.com/user-attachments/assets/7e4f3d83-53b5-40c4-a631-4df6ac609d77)

9. Execute o projeto com o tipo de execução Container (Dockerfile).
![image](https://github.com/user-attachments/assets/a90e8c59-cca5-4495-abb7-c9430854a6a3)

   



