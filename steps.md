1. dotnet --version
   Fase1: ------------ Web API --------------
1. dotnet new webapi --name web_api_1
1. cd web_api_1
1. dotnet restore
1. dotnet build
1. dotnet run

Fase2: --- Mysql --- Web API 6. dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.22 7. dotnet restore 8. dotnet build

/_Adicional _/
-- Generar Certificado
dotnet dev-certs https --clean
dotnet dev-certs https --trust
