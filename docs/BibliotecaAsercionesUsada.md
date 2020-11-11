# Biblioteca de Aserciones Usada, Metodología y Herramientas de Prueba

En el estudio que he realizado he apreciado que se pueden usar diferentes tipos de pruebas para validar el código y también hay varias herramientas disponibles para probar las aplicaciones .NET. Todo esto teniendo en consideración una metodología de prueba usada.

Un breve resumen de lo aprendido, para posteriormente justificar mi elección.

Tipos de prueba:

- Pruebas unitarias

Una prueba de unidad es una prueba que ejercita componentes o métodos de software individuales, también conocida como "unidad de trabajo". 

- Pruebas de integración

Una prueba de integración se diferencia de una prueba unitaria en que ejercita la capacidad de dos o más componentes de software para funcionar juntos, también conocida como su "integración". Las pruebas de integración incluyen problemas de infraestructura.

- Pruebas de carga

Una prueba de carga tiene como objetivo determinar si un sistema puede manejar una carga específica, por ejemplo, la cantidad de usuarios simultáneos que usan una aplicación y la capacidad de la aplicación para manejar interacciones de manera receptiva.

## Consideraciones que tuve en cuenta para la prueba

Test Driven Development (TDD) es cuando se escribe una prueba unitaria antes del código que debe verificar. Está destinado a ayudar a escribir código más simple, más legible y eficiente. Esta metodología establece que debo comenzar escribiendo una prueba unitaria fallida. Luego, escribir el código de producción, pero solo lo necesario para aprobar la prueba. La principal ventaja de usar TDD, y por la cual me inclino al uso de esta metodología, es aumentar la confianza del desarrollador en su código, ya que al desarrollar un pequeño paso a la vez, no podré equivocarme mucho, ya que estoy haciendo muy poco.

## Herramientas de prueba

.NET es una plataforma de desarrollo en varios idiomas y puede elegir entre varios marcos de prueba.

- xUnidad (Este es el marco elegido en la realización de mi proyecto)

Es el marco elegido en la realización de mi proyecto, porque es una herramienta de prueba unitaria gratuita, de código abierto y centrada en la comunidad para .NET.
Usando esta herramienta, el atributo [Fact] en cada prueba, declara un método de prueba que ejecuta el ejecutor de la prueba. Desde la carpeta Functions.Tests, ejecutando ``` dotnet test ```  Estoy utilizando el método de aserción "Assert.True", en las pruebas, ya estoy asertando que puedo insertar un evento y  que checkeo que el evento existe, antes de insertar un combo.

- NUnit

NUnit es un marco de pruebas unitarias para todos los lenguajes .NET. 

- MSTest

MSTest es el marco de prueba de Microsoft para todos los lenguajes .NET.

- .NET CLI

Puede ejecutar pruebas unitarias de soluciones desde la CLI de .NET, con el comando dotnet test. La CLI de .NET expone la mayoría de las funciones que los entornos de desarrollo integrados (IDE) ponen a disposición a través de las interfaces de usuario. 

## IDE

Para el desarrollo de mi proyecto (Visual Studio, Visual Studio Code)

[Enlace Documentación Microsoft Empleada](https://docs.microsoft.com/es-es/dotnet/core/testing/)
