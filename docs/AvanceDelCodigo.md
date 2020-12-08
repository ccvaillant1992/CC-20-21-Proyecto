# Avance Microservicio Catálogo las siguientes HUs:

- Como Administrador de la aplicación, necesito poder añadir un evento nuevo al sistema
- Como Administrador de la aplicación, necesito añadir un nuevo combo a un evento determinado

Usando los modelos de Clases siguientes y con el respectivo almacén de datos(sql database) referenciado en la arquitectura del proyecto para este microservicio:
- [Modelo de clase Evento](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Models/Evento.cs) :Entidad principal
- [Modelo de clase Combo](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Models/Combo.cs)
- [Tabla Evento](https://github.com/ccvaillant1992/UniTradicional/blob/master/CatalogDatabase/dbo/Tables/Evento.sql)
- [Tabla Combo](https://github.com/ccvaillant1992/UniTradicional/blob/master/CatalogDatabase/dbo/Tables/Combo.sql)

La siguiente clase controladora, es una azure function HTTP Triguer, contiene el código para estas Historias de Usuario. 
- [Catalogo.cs](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Catalogo.cs)

## Tests Unitarios realizados hasta ahora para las historias de usuarios avanzadas:

- [CatalogoTests](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions.Test/CatalogoTests.cs)

## Paquetería empleada en el desarrollo del proyecto hasta ahora:
- System.Collections.Generic: para la manipulación de la lista definida en el modelo de clase Evento. 
- System.Data.SqlClient: Proporciona el proveedor de datos para SQL Server para el manejo con la base de datos sqlserver del microservicio Catálogo
- Microsoft.Extensions.Logging: Implementa la infraestructura de registro que emplea la azure function para registrar los logs de la aplicación. Ayuda la trazabilidad del código. 
- Microsoft.Azure.WebJobs: Este paquete contiene los ensamblados en tiempo de ejecución. También agrega capacidades de diagnóstico completas que facilitan el monitoreo de WebJobs.
- System.Threading.Tasks: Simplifican el trabajo de escribir código concurrente y asincrónico.
- Microsoft.AspNetCore: framework empleado mediante la azure function para construir sitios web y APIs web 
- Newtonsoft.Json: framework JSON para el manejo de archivos en formato json


