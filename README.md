# ConCentraApp

#BACKEND 
## Migracion de Datos:
1. dotnet ef migrations add InitialMigration -p Infrastructure -s Web.API -o Persistence/Migrations
2. dotnet ef database update -p Infrastructure -s Web.API

PATRONES Y ELEMENTOS UTILIZADOS:
1. Patron Clean Arquitecture
2. Patron DDD(Domain Driven Desing)
3. Patron CQRS (segregacion de responsabilidades de comandos y consultas)(separacion de modelos)
4 .Version .Net Core 7
5. Seguridad por token JWT
6. CRUD con SQL Server

#FRONTEND

Version Angular 16+
1. Estilos de framework : Angular Material, Bootstrap y diseño
2. Interceptor (Observable)
3. Modelos (Usuarios, Placas)
4. Servicio DbContext
5. Multiples componentes
