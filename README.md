# ejercicio_patrones_de_diseno
 
Patrón seleccionado
Factory Method

Descripción del proyecto
El proyecto es un juego en Unity en el que un necromancer invoca esqueletos. El necromancer tiene un método de fábrica que genera esqueletos en el juego, y estos caminan hacia adelante.

¿Cuál es la problemática con la que nos encontraríamos en el ejercicio si no aplicamos el patrón?
Si no aplicamos el patrón Factory Method, el proceso de creación de los esqueletos estaría directamente ligado al código de la clase NecromancerController. Esto implicaría que cualquier cambio en la manera de crear los esqueletos o si decidimos cambiar el tipo de esqueleto (por ejemplo, agregar variantes con diferentes comportamientos), requeriría modificaciones directas en el controlador. Esto haría que el código se volviera más difícil de mantener y extender. Además, si tuviéramos que agregar más tipos de esqueletos en el futuro (por ejemplo, esqueletos con poderes especiales o de diferentes clases), tendríamos que modificar el código de creación en múltiples lugares, lo que sería propenso a errores.

¿Por qué el patrón soluciona esa problemática? ¿De qué forma lo hace?
El patrón Factory Method resuelve este problema al centralizar la creación de los esqueletos en una clase separada (SkeletonFactory) que tiene un método abstracto CreateSkeleton. Esto permite que el controlador (NecromancerController) no dependa de los detalles específicos de cómo se crean los esqueletos, sino que simplemente llame al método de la fábrica para obtener una instancia del esqueleto. Si necesitamos cambiar el tipo de esqueleto o agregar nuevos tipos en el futuro, solo debemos modificar o añadir nuevas clases de fábrica (por ejemplo, BasicSkeletonFactory, AdvancedSkeletonFactory, etc.) sin cambiar el código del controlador.

¿Qué ventajas y desventajas tiene el patrón seleccionado?
Ventajas:
- Desacoplamiento: La creación de los esqueletos está separada de la lógica del necromancer. Esto facilita la modificación de cómo se crean los esqueletos sin afectar el código que usa los esqueletos.
- Escalabilidad: Si más adelante deseas agregar diferentes tipos de esqueletos (por ejemplo, esqueletos con poderes especiales o más complejos), se pueden crear nuevas fábricas sin modificar el controlador. Esto facilita la ampliación del sistema.
- Mantenimiento: Si hay un cambio en la forma en que los esqueletos son creados, como un cambio en su prefab o comportamiento, solo necesitas modificar la fábrica correspondiente y no todo el código que utiliza los esqueletos.

Desventajas:
- Mayor complejidad inicial:  Introducir una capa de abstracción (en este caso, la fábrica) puede agregar algo de complejidad al sistema, especialmente si el proyecto es pequeño y no necesita mucha variabilidad en la creación de objetos.
- Puede generar más clases: El patrón puede aumentar el número de clases en el proyecto, lo que puede llevar a una sobrecarga si no es necesario tener tantas fábricas.
