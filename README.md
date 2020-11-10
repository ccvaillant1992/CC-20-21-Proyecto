# UniTradicional  

Este repositorio contiene toda la documentación relacionada a la realización del proyecto de la asignatura Cloud Computing para el despliegue del mismo a través de las diferentes prácticas planteadas a lo largo del desarrollo de las mismas. 

## Acerca del proyecto
La aplicación UniTradicional es una tienda online que vende combos de disfraces asociados a eventos relacionados con las fiestas de mayor tradición e historia en algún país elegido por el cliente.

- En el sitio web de la tienda los clientes pueden ver los diferentes eventos en el catálogo y acceder a los combos de disfraces ofertados filtrando por categorías (hombre, mujer, niño)
- Los clientes pueden chequear los detalles de los eventos, seleccionar el combo de disfraz deseado para cada evento y ordenar la compra.
- Los combos de disfraces son colocados en un carrito de compra y cuando es realizada la compra los usuarios pueden pagar por el combo seleccionado en el carrito.

## Historias de Usuario

A continuación, las historias de usuario descritas como parte de cada una de las funcionalidades que contendrá la aplicación UniTradicional:

- [Como cliente, necesito poder ver combos disponibles para un evento específico](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/14)
- [Como cliente, necesito poder visualizar el listado de los eventos disponibles en el sistema](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/15)
- [Como cliente, necesito poder visualizar los elementos añadidos al carrito de compra](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/16)
- [Como Administrador de la aplicación, necesito poder añadir un evento nuevo al sistema](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/17)
- [Como Administrador de la aplicación, necesito añadir un nuevo combo a un evento determinado](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/18)
- [Como cliente, necesito poder ver el detalle de un combo de disfraz](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/19)
- [Como cliente, necesito poder filtrar los combos por categoría](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/20)
- [Como cliente, necesito poder añadir un combo al carrito de compra](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/21)
- [Como cliente, necesito poder realizar el pago de un combo determinado](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/22)

## Desarrollo y Avance del proyecto en las siguientes fases 
- [Planificación del Proyecto](https://github.com/ccvaillant1992/CC-20-21-Proyecto/milestone/5)
- [Diseño de la Arquitectura del Proyecto](https://github.com/ccvaillant1992/CC-20-21-Proyecto/milestone/12)
- [Desarrollo de Microservicios-Catálogo](https://github.com/ccvaillant1992/CC-20-21-Proyecto/milestone/10)
- [Desarrollo de Microservicios- Órdenes de compra](https://github.com/ccvaillant1992/CC-20-21-Proyecto/milestone/7)
- [Desarrollo de Microservicios-Gestión de Pagos](https://github.com/ccvaillant1992/CC-20-21-Proyecto/milestone/11)
- [Integración de servicios](https://github.com/ccvaillant1992/CC-20-21-Proyecto/milestone/14)
- [Despliegue de Infraestructura](https://github.com/ccvaillant1992/CC-20-21-Proyecto/milestone/13)

## Los Modelos de las clases a utilizar en el proyecto

[Evento](https://github.com/ccvaillant1992/CC-20-21-Proyecto/blob/master/UniTradicional/Functions/Models/Evento.cs) :Entidad principal

- EventId
- Descripción
- País
- Nombre
- Date 
- Combos 

[Combo](https://github.com/ccvaillant1992/CC-20-21-Proyecto/blob/master/UniTradicional/Functions/Models/Combo.cs)

- ComboId
- IdEvento
- Precio
- Categoría
- Nombre


## Arquitectura del proyecto
La Tienda utiliza una arquitectura de microservicios basada en ASP.NET Core. Las solicitudes HTTP de los clientes a la aplicación web de la tienda para que pueden acceder a los microservicios se enrutan a través de una puerta de enlace API, que es una implementación de Backens-For-Frontends. Las puertas de enlace API mejoran la seguridad y desacoplan los servicios backend de los clientes individuales.

[Ver una descripción más detallada de la Arquitectura](https://github.com/ccvaillant1992/CC-20-21-Proyecto/blob/master/docs/ArquitecturaProyecto.md)

## Herramientas a emplear

- Lenguajes: Para el desarrollo de los microservicios se empleará lenguage c# y como framework ASP NetCore 3.1
- Almacenamiento: Para el almacenamiento de los datos en el microservico de catálogo se usuará una base de datos SQL y para el microservicio de orden, la base de datos en memoria redis
- Comunicación: Los microservicios se comunicarán mediante envío de mensajes empleando el Azure Service Bus.
- Test: Para el desarrollo basado en test se implementarán distintas pruebas para todos los microservicios usando la herramienta xUnit y ejecutando las mismas mediante el comando `` dotnet test ``
- Servicios: Se usará el servicio Azure Log Analytics Workspace como centralizador de log de los microservicios.
- Infraestructura de nube pública: Microsoft Azure 
- Gestor de Tareas: Para la automatización y despliegue de los servicios definidos en la arquitectura del proyecto, mediante un pipeline de Azure Devops empleando la sintaxis yaml file y tareas de scripts de powershell y azcli desplegar recursos definidos en ARM(Azure Resource Manager Templates)


## Licencia a utilizar en el proyecto

- GNU General Public License v3.0

