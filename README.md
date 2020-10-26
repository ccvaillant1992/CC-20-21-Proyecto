# UniTradicional  

Este repositorio contiene toda la documentación relacionada a la realización del proyecto de la asignatura Cloud Computing para el despliegue del mismo a través de las diferentes prácticas planteados a lo largo del desarrollo de las mismas. 

## Acerca del proyecto
La aplicación UniTradicional es una tienda online que vende combos de disfraces asociados a eventos relacionados con las fiestas de mayor tradición e historia en algún país elegido por el cliente.

- En el sitio web de la tienda los clientes pueden ver los diferentes eventos en el catálogo y acceder a los combos de disfraces ofertados filtrando por categorías (hombre, mujer, niño)
- Los clientes pueden chequear los detalles de los eventos, seleccionar el combo de disfraz deseado para cada evento y ordenar la compra.
- Los combos de disfraces son colocados en un carrito de compra y cuando es realizada la compra los usuarios pueden pagar por el combo seleccionado en el carrito.

## Historias de Usuario

Las Historias de Usuario definidas:

- [Como cliente, quiero ver los eventos disponibles en el Catálogo de eventos para obtener detalle de los combos de disfraces suministrándole al sistema la categoría (hombre, mujer o niño) a filtrar](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/11)
- [Como cliente, quiero seleccionar un combo de disfraz para añadir una orden de compra a la cesta de compra](https://github.com/ccvaillant1992/CC-20-21-Proyecto/issues/13)
- [Como cliente, quiero visualizar mi cesta de compra para realizar el pago de los combos de disfraces ordenados por mi]()
- [Como Administrador del sitio quiero actualizar el catálogo de eventos]()
- [Como Administrador del sitio quiero añadir combos de disfraces en venta a los eventos disponibles]()

## Arquitectura del proyecto
La Tienda utiliza una arquitectura de microservicios basada en ASP.NET Core. Las solicitudes HTTP de los clientes a la aplicación web de la tienda para que pueden acceder a los microservicios se enrutan a través de una puerta de enlace API, que es una implementación de Backens-For-Frontends. Las puertas de enlace API mejoran la seguridad y desacoplan los servicios backend de los clientes individuales.

[Descripción más detallada Arquitectura](https://github.com/ccvaillant1992/CC-20-21-Proyecto/blob/master/docs/ArquitecturaProyecto.md)

## Herramientas a emplear

- Lenguajes: Para el desarrollo de los microservicios se empleará lenguage c# y como framework ASP NetCore 3.1
- Almacenamiento: Para el almacenamiento de los datos en el microservico de catálogo se usuará una base de datos SQL y para el microservicio de orden, la base de datos en memoria redis
- Comunicación: Los microservicios se comunicarán mediante envío de mensajes empleando el servicio Event Hub con RabbitMQ.
- Test: Para el desarrollo basado en test se implementarán distintas pruebas para todos los microservicios usando la herramienta dotnet test and xUnit 
- Servicios: Se usará el servicio de Log Analytics Workspace como centralizador de log de los microservicios.

## Licencia a utilizar en el proyecto

- GNU General Public License v3.0

