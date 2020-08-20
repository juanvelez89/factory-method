# factory-method
Este es el ejemplo práctico del patrón de diseño factory method en c# y una corta explicación para entender en lo que consiste. 


Basado en el libro:
#### Design Patterns Elements of reusable Object-Oriented Software de Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides.

## Definición
Es un patrón de diseño creacional el cual define una interfaz para crear un objeto, pero deja decidir a las subclases que clase instanciar. Factory method permite diferir la instanciación de una clase a subclases.

## Aplicabilidad
El patrón factory method debería usarse cuando una clase no puede anticipar la clase del objeto que debe crear, cuando una clase quiere que sus subclases especifiquen los objetos que crean y cuando las clases delegan responsabilidad en una o muchas subclases de ayuda y quieren saber cual es la subclase delegada.

## Participantes en el patrón

### Product
Define una interfaz de objetos que crea el factory method

### ConcreteProduct
Implementa la interfaz product

### Creator
Declara el factory method el cual retorna un objeto de tipo product.

### ConcreteCreator
Sobre escribe el factory method y retorna una instancia de un concreteproduct.

### Client
El cliente crea el objeto creator y lo configura con el objeto product deseado.

