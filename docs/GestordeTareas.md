Para este proyecto, como gestor de tareas he empleado Azure Pipelines.  Este constituye un servicio en la nube que se puede usar para compilar y probar automáticamente mi proyecto de código y ponerlo a disposición de otros usuarios. Funciona con casi cualquier idioma o tipo de proyecto. Azure Pipelines combina la integración continua (CI) y la entrega continua (CD) para probar y compilar mi código de manera constante y uniforme y enviarlo a cualquier destino.

He usado para el despliegue automático de tareas mediante la sintaxis YAML el siguiente [pipeline](https://github.com/ccvaillant1992/UniTradicional/blob/master/deployInfrastructure.yml) que despliega las tareas especificadas hasta ahora, apoyandose en este [script](https://github.com/ccvaillant1992/UniTradicional/blob/master/deployResources.ps1) de power shell que a su vez, emplea la [template](https://github.com/ccvaillant1992/UniTradicional/blob/master/resources.json) definida para cada recurso y sus propiedades específicas.

También, como características que justifican su elección, Azure Pipelines:

- Ayuda a garantizar un código consistente y de calidad que esté disponible para los usuarios.
- Proporciona una forma rápida, fácil y segura de automatizar la creación de los proyectos y ponerlos a disposición de los usuarios.
- Funciona con cualquier idioma o plataforma
- Se implementa en diferentes tipos de objetivos al mismo tiempo (Puedo usar tareas basadas en scripts de Power Shell, az cli, también, tareas dotnet para desplegar código de mi proyecto en una azure function)
- Se integra con implementaciones de Azure 
- Se basa en máquinas Windows, Linux o Mac 
- Se integra con GitHub Funciona con proyectos de código abierto

[Referencia documentación empleada](https://docs.microsoft.com/en-us/azure/devops/pipelines/?view=azure-devops)
 

