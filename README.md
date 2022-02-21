# TuyaPagos
Prueba Tecnica para TUYa

Realizacion de proyecto con Clean / Architectrure Clean y algo de DDD
Utilizando Patrones de Diseño
- Repositorio
- Injección de Dependencias
- MVC entre otros


Se Realizaron los siguientes entidades/Tablas

**Producto**

**OrdenCompra**

**Cliente**

**Logistica**

Para la Base de datos se utilizo SQL server 2016 Utilizando Entity Framework Core 6.0 y Code First .Net 5.0

La estructura de los proyectos de clases y UI son las siguientes:

**Application**

**Domain.Core**

**Domain.Entities**

**Infraestructura.Data**

**UI.WebApi**


para ejecutar la solucion despues de descargarla/Clonar del repeositorio de github:

**1-Borrar los archivos de migración en la Carpeta migrations del proyeto co.Tuya.Infrastructure.Data,**

**2- ejecutar la migracion de code first para que los datos queden en la instancia de SQL que se crea en la instalación de Visual Studio 2019**

en el Package Console Manager escribir:

**add-migration firstMigration -OutputDir Migrations -Context TuyaContext -Project co.Tuya.Infrastructure.Data dar enter**

**3- Luego en la misma consola de package Manager... ejecutar Update-DataBase -verbose**
**Debe mostrar algo así:**

--Applying migration '20220121162047_firstMigration'.
--Opening connection to database 'tuyaDB' on server '(localdb)\MSSQLLocalDB'.
--Opened connection to database 'tuyaDB' on server '(localdb)\MSSQLLocalDB'.
--Beginning transaction with isolation level 'Unspecified'.
--Began transaction with isolation level 'ReadCommitted'.
--Creating DbCommand for 'ExecuteNonQuery'.
--Created DbCommand for 'ExecuteNonQuery' (0ms).
--Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
..................
Closing connection to database 'tuyaDB' on server '(localdb)\MSSQLLocalDB'.
Closed connection to database 'tuyaDB' on server '(localdb)\MSSQLLocalDB'.
'TuyaContext' disposed.
Done.


compilar, y ejecutar la solucion.

**3- llamar apis desde postman**
