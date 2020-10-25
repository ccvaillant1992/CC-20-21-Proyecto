# Arquitectura del proyecto

Las piezas de funcionalidad como parte de la aplicación son:

- Catálogo de eventos
- Carrito de compra
- Servicio de pago

Cada una de las características anteriores se administra con un microservicio distinto. Cada microservicio es autónomo, se puede implementar de forma independiente y es responsable de sus propios datos.

Por tanto, existen requerimientos no funcionales para esta aplicación que justifican la elección de esta arquitectura basada en microservicios: 
- Escalabilidad flexible: Los eventos se van ordenando en el catálogo de servicios conforme se esté acercando la fecha de celebración, ciertos combos de disfraces son enormemente demandados, especialmente durante estas fechas. Esta es la razón por la cual UniTradicional necesita poder ser escalada de forma flexible.
Además, no se quiere pagar por recursos de cómputo en un día lento, pero se necesita alta disponibilidad en en día ocupado y una parte de la aplicación que recibe la carga alta debería poder se escalada cuando sea necesario.
- Implementación de entrega continua de forma independiente, equipos separados y fácil de expandir: Cada parte de la aplicación debería poder ser implementada de forma independiente del resto de las partes usando despliegue continuo. Una de las razones es que cada parte pueda ser separada en equipos con diferentes localizaciones trabajando cada parte a su medida. Debe proporcionar la facilidad para añadir funcionalidades nuevas.
- De confianza: Es una aplicación debe generar confianza y motivación a los clientes. Se busca la felicidad en los clientes. Por tanto, cuando accedan a la compra de algún combo de disfraz debe de haber la menos posibilidad de perder alguna información.

