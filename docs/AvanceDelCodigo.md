# Avance Microservicio Catálogo las siguientes HU:

- Como Administrador de la aplicación, necesito poder añadir un evento nuevo al sistema
- Como Administrador de la aplicación, necesito añadir un nuevo combo a un evento determinad

Usando los modelos de Clases siguientes y con el respectivo almacén de datos(sql database) referenciado en la arquitectura del proyecto para este microservicio:
- [Modelo de clase Evento](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Models/Evento.cs) :Entidad principal
- [Modelo de clase Combo](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Models/Combo.cs)
- [Tabla Evento](https://github.com/ccvaillant1992/UniTradicional/blob/master/CatalogDatabase/dbo/Tables/Evento.sql)
- [Tabla Combo](https://github.com/ccvaillant1992/UniTradicional/blob/master/CatalogDatabase/dbo/Tables/Combo.sql)

Usando los modelos de Clases siguientes y con el respectivo almacén de datos referenciado en la arquitectura del proyecto para este microservicio:
La siguiente clase controladora, es una azure function HTTP Triguer, a continuación el avance del código para estas Historias de Usuario. [Catalogo.cs](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Catalogo.cs)

## Tests Unitarios realizados hasta ahora para las historias de usuarios avanzadas:

- [CatalogoTest](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions.Test/CatalogoTest.cs)



