# UniTradicional  
Este repositorio contiene toda la documentación relacionada a la realización del proyecto de la asignatura Cloud Computing para el despliegue del mismo a través de las diferentes prácticas planteadas a lo largo del desarrollo de las mismas. 

## Acerca del proyecto
La aplicación UniTradicional es una tienda online que vende combos de disfraces asociados a eventos relacionados con las fiestas de mayor tradición e historia en algún país elegido por el cliente.

- En el sitio web de la tienda los clientes pueden ver los diferentes eventos en el catálogo y acceder a los combos de disfraces ofertados filtrando por categorías (hombre, mujer, niño)
- Los clientes pueden chequear los detalles de los eventos, seleccionar el combo de disfraz deseado para cada evento y ordenar la compra.
- Los combos de disfraces son colocados en un carrito de compra y cuando es realizada la compra los usuarios pueden pagar por el combo seleccionado en el carrito.

## Historias de Usuario

A continuación, las historias de usuario descritas como parte de cada una de las funcionalidades que contendrá la aplicación UniTradicional:

- [Como cliente, necesito poder ver combos disponibles para un evento específico](https://github.com/ccvaillant1992/UniTradicional/issues/14)
- [Como cliente, necesito poder visualizar el listado de los eventos disponibles en el sistema](https://github.com/ccvaillant1992/UniTradicional/issues/15)
- [Como cliente, necesito poder visualizar los elementos añadidos al carrito de compra](https://github.com/ccvaillant1992/UniTradicional/issues/16)
- [Como Administrador de la aplicación, necesito poder añadir un evento nuevo al sistema](https://github.com/ccvaillant1992/UniTradicional/issues/17)
- [Como Administrador de la aplicación, necesito añadir un nuevo combo a un evento determinado](https://github.com/ccvaillant1992/UniTradicional/issues/18)
- [Como cliente, necesito poder ver el detalle de un combo de disfraz](https://github.com/ccvaillant1992/UniTradicional/issues/19)
- [Como cliente, necesito poder filtrar los combos por categoría](https://github.com/ccvaillant1992/UniTradicional/issues/20)
- [Como cliente, necesito poder añadir un combo al carrito de compra](https://github.com/ccvaillant1992/UniTradicional/issues/21)
- [Como cliente, necesito poder realizar el pago de un combo determinado](https://github.com/ccvaillant1992/UniTradicional/issues/22)

## Desarrollo y Avance del proyecto en las siguientes fases 
- [Planificación del Proyecto](https://github.com/ccvaillant1992/UniTradicional/milestone/5)
- [Diseño de la Arquitectura del Proyecto](https://github.com/ccvaillant1992/UniTradicional/milestone/12)
- [Desarrollo de Microservicios-Catálogo](https://github.com/ccvaillant1992/UniTradicional/milestone/10)
- [Desarrollo de Microservicios- Órdenes de compra](https://github.com/ccvaillant1992/UniTradicional/milestone/7)
- [Desarrollo de Microservicios-Gestión de Pagos](https://github.com/ccvaillant1992/UniTradicional/milestone/11)
- [Integración de servicios](https://github.com/ccvaillant1992/UniTradicional/milestone/14)
- [Despliegue de Infraestructura](https://github.com/ccvaillant1992/UniTradicional/milestone/13)

## Estructura del proyecto

- [Modelo de clase Evento](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Models/Evento.cs) :Entidad principal
- [Modelo de clase Combo](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Models/Combo.cs)
- [Modelo de clase Catálogo]() : Controladora que contendrá las funciones del Microservicio Catálogo
- [Modelo de clase CatálogoTest]() : Test unitarios que se realizarán a las funciones del Microservicio Catálogo

## Arquitectura del proyecto

La Tienda utiliza una arquitectura de microservicios basada en ASP.NET Core. [Ver una descripción más detallada de la Arquitectura](https://github.com/ccvaillant1992/UniTradicional/blob/master/docs/ArquitecturaProyecto.md)

## Herramientas a emplear

- Lenguajes: Para el desarrollo de los microservicios se empleará lenguage c# y como framework ASP NetCore 3.1
- Almacenamiento: Para el almacenamiento de los datos en el microservico de catálogo se usuará una base de datos SQL y para el microservicio de orden, la base de datos en memoria redis
- Comunicación: Los microservicios se comunicarán mediante envío de mensajes empleando el Azure Service Bus.
- Test: Para el desarrollo basado en test se implementarán distintas pruebas para todos los microservicios usando la herramienta xUnit y ejecutando las mismas mediante el comando `` dotnet test ``
- Servicios: Se usará el servicio Azure Log Analytics Workspace como centralizador de log de los microservicios.
- Infraestructura de nube pública: Microsoft Azure 
- Gestor de Tareas: Para la automatización y despliegue de los servicios definidos en la arquitectura del proyecto, mediante un pipeline de Azure Devops empleando la sintaxis yaml file y tareas de scripts de powershell y azcli desplegar recursos definidos en ARM(Azure Resource Manager Templates)


## Accesso a cada referencia de esta sección:

- R1 [Configuración correcta del gestor de tareas y jutificación de la misma](https://github.com/ccvaillant1992/UniTradicional/blob/master/docs/GestordeTareas.md)
- R2 [Elección y justificación de la biblioteca de aserciones usada](https://github.com/ccvaillant1992/UniTradicional/blob/master/docs/BibliotecaAsercionesUsada.md)
- R3 [Elección y justificación del marco de pruebas usado](https://github.com/ccvaillant1992/UniTradicional/blob/master/docs/MarcodePruebaUsado.md)
- R4 [Correcta relación entre avance de código (incluyendo los test) e HUs]()
- R5 [Test significativos y/o avance del proyecto en sí más allá de lo básico, incluyendo sugerencias hechas en las correcciones y evaluaciones de hitos anteriores](https://github.com/ccvaillant1992/UniTradicional/blob/master/docs/HerramientasEmpleadas.md)

## Licencia a utilizar en el proyecto

- GNU General Public License v3.0

