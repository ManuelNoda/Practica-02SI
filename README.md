# Practica-02SI

**Asignar un color al Cubo**
Este script lo que hace es cambiar el color de un objeto en Unity de forma aleatoria cada cierto número de frames. Primero genera un color inicial usando un **Vector3** con posiciones (x, y, z).
Usando la clase **Random** mos permite calcular los valores de los ejes de manera aleatoria y con ello asignar un color a al figura.
Usamos la clase **Color** para generar dicho color, esta tambien es un vector (x,y,z).Este color se aplica al material del objeto accediendo a su Renderer con GetComponent<Renderer>(). 
Después, en cada actualización del juego (Update()), el script va contando frames con un contador, y cuando llega al número definido en frames maximos, cambia solo una de las tres componentes del color (x, y ,z) por un nuevo valor aleatorio. 
Esto lo conseguimos gracias a selegcionar uno de los ejes de manera aleatoria
