# ClientsServicesAPI
El objetivo del ejercicio es evaluar las habilidades técnicas requeridas para el desarrollo de aplicaciones .net y manejo de Bases
de datos.

## Tecnologías
- .NET 8.0
- Docker
- Microsoft SQL Server

## Ejecución
1. Clonar el repositorio.
2. En la Terminal, ir a la ubicación de docker-compose.yaml:
- cd ClientsServicesAPI
3. Levantar la base de datos:
- docker-compose up -d
4. Esperar hasta que se inicie la base de datos por completo.
5. Abrir Herramientas > Administrador de paquetes NuGet > Consola del Administrador de paquetes
6. Ejecutar en la Consola del Administrador de paquetes:
- Update-database
7. Iniciar el proyecto utilizando IIS Express.