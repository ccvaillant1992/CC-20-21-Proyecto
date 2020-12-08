# Arquitectura del proyecto

La Tienda utiliza una arquitectura basada en microservicios ASP.NET Core. Las solicitudes HTTP de los clientes a la aplicación web de la tienda para que puedan acceder a los microservicios se enrutan a través de una puerta de enlace API, que es una implementación de Backens-For-Frontends. Las puertas de enlace API mejoran la seguridad y desacoplan los servicios backend de los clientes individuales. 

## Las piezas de funcionalidad como parte de la aplicación son:

- Catálogo de eventos (sql db)
- Orden de compra (sql db)
- Servicio de pago (redis in-memory db)

Cada una de las características anteriores se administra con un microservicio distinto. Cada microservicio es autónomo, se puede implementar de forma independiente y es responsable de sus propios datos, por lo que implementan el almacén de datos que esté mejor optimizado para su carga de trabajo. Las opciones de almacenamiento de datos a emplear incluyen base de datos relacional y base de datos no relacional clave-valor. No existe un único almacén de datos con el que interactúen todos los servicios.

## Descripción de los servicios que integrará la aplicación y las principales funciones que realizará cada uno:

Como punto de entrada para recibir y responder las solicitudes de los clientes, una aplicación web ASP NET Blazor. Esta es una alternativa a MVC. A través de cada componente de esta aplicación web pages-razor, se realizará la comunicación mediante una API Gateway como punto intermedio de seguridad con cada microservicio correspondiente a la solicitud a tramitar. Cada microservicio estará desarrollado con el servicio de computación en la nube Azure Functions, cada una con su almacén de datos correspondiente. Para la transferencia asincrónica de datos e intercambio de mensajes en UniTradicional, el servicio Azure Service Bus. Además, como centralizador de logs, Azure Log Analytics Workspace, con el objetivo de registrar mensajes generados por cada componente que integra la arquitectura de la Tienda UniTradicional y obtener información de seguimiento detallada sobre fallos en los servicios.

## Entre los requerimientos no funcionales que justifican por qué la elección de esta arquitectura basada en microservicios:

- Escalabilidad flexible: Los eventos se van ordenando en el catálogo de servicios conforme se esté acercando la fecha de celebración, ciertos combos de disfraces son enormemente demandados, especialmente durante estas fechas. Esta es la razón por la cual UniTradicional necesita poder ser escalada de forma flexible. Se necesita alta disponibilidad en día ocupado y una parte de la aplicación que recibe la carga alta debería poder se escalada cuando sea necesario.
- Implementación de entrega continua de forma independiente. Cada parte de la aplicación debería poder ser implementada de forma independiente del resto de las partes usando despliegue continuo.

