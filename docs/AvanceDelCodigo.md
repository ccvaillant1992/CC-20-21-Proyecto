# Avance Microservicio Catálogo las siguientes HUs:

- Como Administrador de la aplicación, necesito poder añadir un evento nuevo al sistema
- Como Administrador de la aplicación, necesito añadir un nuevo combo a un evento determinado

Usando los modelos de Clases siguientes y con el respectivo almacén de datos(sql database) referenciado en la arquitectura del proyecto para este microservicio:
- [Modelo de clase Evento](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Models/Evento.cs) :Entidad principal
- [Modelo de clase Combo](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Models/Combo.cs)
- [Tabla Evento](https://github.com/ccvaillant1992/UniTradicional/blob/master/CatalogDatabase/dbo/Tables/Evento.sql)
- [Tabla Combo](https://github.com/ccvaillant1992/UniTradicional/blob/master/CatalogDatabase/dbo/Tables/Combo.sql)

La siguiente clase controladora, es una azure function HTTP Triguer, contiene el código para estas Historias de Usuario. 
- [Catalogo.cs](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions/Catalogo.cs)

## Tests Unitarios realizados hasta ahora para las historias de usuarios avanzadas:

- [CatalogoTests](https://github.com/ccvaillant1992/UniTradicional/blob/master/Functions.Test/CatalogoTests.cs)



