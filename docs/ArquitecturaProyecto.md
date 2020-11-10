# Arquitectura del proyecto

La Tienda utiliza una arquitectura basada en ASP.NET Core microservicios. Las solicitudes HTTP de los clientes a la aplicación web de la tienda para que puedan acceder a los microservicios se enrutan a través de una puerta de enlace API, que es una implementación de Backens-For-Frontends. Las puertas de enlace API mejoran la seguridad y desacoplan los servicios backend de los clientes individuales. 

Las piezas de funcionalidad como parte de la aplicación son:

- Catálogo de eventos
- Orden de compra
- Servicio de pago

Cada una de las características anteriores se administra con un microservicio distinto. Cada microservicio es autónomo, se puede implementar de forma independiente y es responsable de sus propios datos.

Esta arquitectura permite que cada microservicio implemente el almacén de datos que esté mejor optimizado para su carga de trabajo, necesidades de almacenamiento y patrones de lectura-escritura. Las opciones de almacenamiento de datos incluyen relacional y clave-valor. No existe un único almacén de datos con el que interactúen todos los servicios.

Entonces, Con el objetivo de minimizar costes en recursos de infraestructura en la nube, minimizar la complejidad de la aplicación antes propuesta, no emplear arquitecturas genéricas propuestas por tutoriales de Microsoft y innovar en el empleo de servicios en la plataforma de Azure que facilitan el despliegue de aplicaciones de microservicios en la nube; se plantea un nuevo modelo de arquitectura. A continuación, se explica cada uno de los servicios que integrarán y las principales funciones que realizará, así como enlaces de bibliografía que explican con más detalle dichos servicios y como instalarlos y configurarlos. 

Como punto de entrada para recibir y responder las solicitudes de los clientes, una aplicación web ASP NET Blazor. A través de cada componente de esta aplicación web pages-razor se realizará la comunicación mediante una API Gateway como punto intermedio de seguridad, con cada microservicio correspondiente a la solicitud a tramitar. Cada microservicio estará desarrollado con el servicio de computación en la nube AzureFunctions, cada una con su almacén de datos correspondiente. para el intercambio de mensajes entre cada microservicio, el servicio Azure Service Bus. Además, como centralizador de logs, el Azure Log Analytics Workspace. 

A continuación más detalle de cada servicio que se plantea en el diseño de la arquitectura del proyecto. 

## ASP NET Blazor (HTML) 
Con el objetivo de crear la interfaz de usuario de la tienda UniTradicional. Blazor es una alternativa a MVC, es un marco de aplicación de una sola página (SPA) que simplemente usa C # en lugar de JavaScript. Las aplicaciones Blazor pueden ejecutarse en el servidor o en el navegador gracias a Web Assembly. Emplean la interfaz de usuario como HTML y CSS para una amplia compatibilidad con navegadores. Permiten la integración con plataformas de alojamiento modernas, como Docker.

[Referencia Documentación Microsoft Empleada](https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/run)

[Referencia Documentación Microsoft Empleada](https://docs.microsoft.com/es-es/aspnet/core/blazor/?view=aspnetcore-3.1)

## Azure Front Door as the API Gateway. 

Front Door dirige el tráfico web a recursos específicos en un grupo de backend. Azure Front Door es una red de entrega de aplicaciones (ADN) como servicio, que ofrece varias capacidades de equilibrio de carga de capa 7 para sus aplicaciones. Proporciona equilibrio de carga global con conmutación por error casi en tiempo real. Es un servicio escalable y de alta disponibilidad, completamente administrado por Azure.

[Referencia Documentación Microsoft Empleada](https://docs.microsoft.com/en-us/azure/frontdoor/front-door-faq#how-do-i-lock-down-the-access-to-my-backend-to-only-azure-front-door)

[Referencia Documentación Microsoft Empleada](https://docs.microsoft.com/en-us/azure/frontdoor/quickstart-create-front-door-cli)

## Azure Functions

Para cada microservicio (Catálogo, Ventas y Orden). Me permite ejecutar pequeños fragmentos de código (llamados "funciones") sin preocuparse por la infraestructura de la aplicación. Con Azure Functions, la infraestructura de la nube proporciona todos los servidores actualizados que necesita para mantener su aplicación funcionando a escala.

[Referencia Documentación Microsoft Empleada](https://docs.microsoft.com/es-es/azure/azure-functions/functions-overview)

## Microsoft Azure Service Bus 

Como plataforma confiable y segura para la transferencia asincrónica de datos y estado en UniTradicional. Los datos se transfieren entre las diferentes aplicaciones de los microservicios mediante mensajes. Un mensaje está en formato binario y puede contener JSON, XML o solo texto. Es empleado en escenarios comunes de mensajería como transferencia de datos comerciales, pedidos de compra o ventas, diarios o movimientos de inventario.

[Referencia Documentación Microsoft Empleada](https://docs.microsoft.com/es-es/azure/service-bus-messaging/service-bus-messaging-overview)

## Log Analytics Workspace(centralizado)

Con el objetivo de registrar mensajes generados por cada componente que integra la arquitectura de la Tienda UniTradicional, obtener información de seguimiento detallada sobre fallos en los servicios.

[Referencia Documentación Microsoft Empleada](https://docs.microsoft.com/en-us/azure/azure-monitor/learn/quick-create-workspace)


También, entre los requerimientos no funcionales que justifican por qué la elección de esta arquitectura basada en microservicios:

- Escalabilidad flexible: Los eventos se van ordenando en el catálogo de servicios conforme se esté acercando la fecha de celebración, ciertos combos de disfraces son enormemente demandados, especialmente durante estas fechas. Esta es la razón por la cual UniTradicional necesita poder ser escalada de forma flexible. Además, no se quiere pagar por recursos de cómputo en un día lento, pero se necesita alta disponibilidad en en día ocupado y una parte de la aplicación que recibe la carga alta debería poder se escalada cuando sea necesario.
- Implementación de entrega continua de forma independiente. Cada parte de la aplicación debería poder ser implementada de forma independiente del resto de las partes usando despliegue continuo. 

