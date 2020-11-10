# Más detalle sobre las herramientas empleadas en el proyecto

## Paquetería empleada en el proyecto hasta ahora:

- System.Data.SqlClient: Proporciona el proveedor de datos para SQL Server. Estas clases brindan acceso a versiones de SQL Server y encapsulan protocolos específicos de la base de datos, incluido el flujo de datos tabulares (TDS)
- Microsoft.Extensions.Logging: Implementación predeterminada de la infraestructura de registro para Microsoft.Extensions.Logging.
- Microsoft.Azure.WebJobs: Este paquete contiene los ensamblados en tiempo de ejecución para Microsoft.Azure.WebJobs.Host. También agrega capacidades de diagnóstico completas que facilitan el monitoreo de WebJobs.
- System.Threading.Tasks: Proporciona tipos que simplifican el trabajo de escribir código concurrente y asincrónico.
- Microsoft.AspNetCore.Http
- Microsoft.AspNetCore.Mvc: ASP.NET Core MVC is a web framework that gives you a powerful, patterns-based way to build dynamic websites and web APIs. ASP.NET Core MVC enables a clean separation of concerns and gives you full control over markup.

## Avance Microservicio Catálogo las siguientes HU:

- [Como Administrador de la aplicación, necesito poder añadir un evento nuevo al sistema](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Catalogo.cs)
- [Como Administrador de la aplicación, necesito añadir un nuevo combo a un evento determinado](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Catalogo.cs)

## Marco de pruebas usado
xUnit.net  es un marco de prueba creado para admitir el desarrollo basado en pruebas, con un objetivo de diseño de extrema simplicidad. Es una herramienta de prueba unitaria gratuita, de código abierto y centrada en la comunidad para .NET.

[Referencia documentación empleada](https://xunit.net/)

## Tests Unitarios realizados hasta ahora para las historias de usuarios avanzadas:

- [Como Administrador de la aplicación, necesito poder añadir un evento nuevo al sistema](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions.Test/UnitTest1.cs)
- [Como Administrador de la aplicación, necesito añadir un nuevo combo a un evento determinado](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions.Test/UnitTest1.cs)

## Gestor de tareas
Azure Pipelines es un servicio en la nube que puede usar para compilar y probar automáticamente su proyecto de código y ponerlo a disposición de otros usuarios. Funciona con casi cualquier idioma o tipo de proyecto. Azure Pipelines combina la integración continua (CI) y la entrega continua (CD) para probar y compilar su código de manera constante y uniforme y enviarlo a cualquier destino.
- Ayuda a garantizar un código consistente y de calidad que esté disponible para los usuarios.
- Proporciona una forma rápida, fácil y segura de automatizar la creación de sus proyectos y ponerlos a disposición de los usuarios.
- Funciona con cualquier idioma o plataforma
- Se implementa en diferentes tipos de objetivos al mismo tiempo (Puedo usar tareas basadas en scripts de Power Shell, az cli, también, tareas dotnet para desplegar código de mi proyecto en una azure function)
- Se integra con implementaciones de Azure 
- Se basa en máquinas Windows, Linux o Mac 
- Se integra con GitHub Funciona con proyectos de código abierto

[Referencia documentación empleada](https://docs.microsoft.com/en-us/azure/devops/pipelines/?view=azure-devops)
 



