# ConCentraApp

#BACKEND 
Migracion de Datos:
1. dotnet ef migrations add InitialMigration -p Infrastructure -s Web.API -o Persistence/Migrations
2. dotnet ef database update -p Infrastructure -s Web.API

PATRONES UTILIZADOS:
Patron Clean Arquitecture
Patron DDD(Domain Driven Desing)
Patron CQRS (segregacion de responsabilidades de comandos y consultas)(separacion de modelos)

Version .Net Core 7
Seguridad por token JWT
CRUD con SQL Server


#FRONTEND

Version Angular 16+
Estilos de framework : Angular Material, Bootstrap y diseño
Interceptor (Observable)
Modelos (Usuarios, Placas)
Servicio DbContext
Multiples componentes
