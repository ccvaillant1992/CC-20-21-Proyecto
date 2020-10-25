# UniTradicional  

Este repositorio contiene toda la documentación relacionada a la realización del proyecto de la asignatura Cloud Computing para el despliegue del mismo a través de las diferentes prácticas planteados a lo largo del desarrollo de las mismas. 

## Acerca del proyecto

La aplicación UniTradicional es una tienda online que vende combos de disfraces asociados a eventos relacionados con las fiestas de mayor tradición e historia en algún país elegido por el cliente.

- En el sitio web de la tienda los clientes pueden ver los diferentes eventos ofrecidos en el catálogo y filtrar por categorías (hombre, mujer, niño)
- Los clientes pueden chequear los detalles de los eventos, seleccionar el combo de disfraz deseado para cada evento y ordenar la compra.
- Los combos de disfraces son colocados en una cesta de compra y cuando es realizada la compra los usuarios pueden pagar por el combo deseado en la cesta.

[Historias de Usuario](https://github.com/ccvaillant1992/CC-20-21-Proyecto/blob/master/docs/HistoriasUsuario.md)

## Arquitectura del proyecto

La Tienda utiliza una arquitectura de microservicios basada en ASP.NET Core. Las solicitudes HTTP de los clientes a la aplicación web de la tienda para que pueden acceder a los microservicios se enrutan a través de una puerta de enlace API, que es una implementación de Backens-For-Frontends. Las puertas de enlace API mejoran la seguridad y desacoplan los servicios backend de los clientes individuales.

[Descripción más detallada Arquitectura](https://github.com/ccvaillant1992/CC-20-21-Proyecto/blob/master/docs/ArquitecturaProyecto.md)

