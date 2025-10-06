# Practica-02SI

**Asignar un color al Cubo**

Este script lo que hace es cambiar el color de un objeto en Unity de forma aleatoria cada cierto número de frames. Primero genera un color inicial usando un **Vector3** con posiciones (x, y, z).
Usando la clase **Random** mos permite calcular los valores de los ejes de manera aleatoria y con ello asignar un color a al figura.
Usamos la clase **Color** para generar dicho color, esta tambien es un vector (x,y,z).Este color se aplica al material del objeto accediendo a su Renderer con GetComponent<Renderer>(). 
Después, en cada actualización del juego (Update()), el script va contando frames con un contador, y cuando llega al número definido en frames maximos, cambia solo una de las tres componentes del color (x, y ,z) por un nuevo valor aleatorio. 
Esto lo conseguimos gracias a selegcionar uno de los ejes de manera aleatoria.

**Compara dos vectores**

 Utilizando diferentes operaciones que nos proporciona la clase **Vector3**. Al inicio (Start()), se calcula la magnitud de cada vector con la propiedad **.magnitude**, la cual representa la longitud del vector. Luego se calcula el ángulo entre ambos usando **Vector3.Angle**, que devuelve el valor en grados, y la distancia que los separa con **Vector3.Distance**. Estos resultados se muestran en consola con Debug.Log(). Además, el script compara la posición en el eje Y de ambos vectores para determinar cuál de los dos está a mayor altura.

**Posicion esfera**

Para ello utilizamos el componente **Transform**, que es el encargado de almacenar la información de posición, rotación y escala de cualquier objeto en Unity. En el método **Start()**, se accede a la propiedad **.position** del Transform mediante **GetComponent<Transform>()** y se guarda en un **Vector3**. el script muestra el evctor de coordenadas de la esfera por consola.

**Distancia entre Cubo, Esfera y Cilindro**

Este script se encarga de calcular y mostrar en consola la distancia entre una esfera y otros objetos de la escena, en este caso un cilindro y un cubo. Para localizar cada objeto dentro de Unity se utilizan etiquetas **tags**, y mediante **GameObject.FindWithTag()** se asignan a las variables correspondientes. 

Luego, en el método **Start()**, se obtiene la posición de cada objeto a través de su componente **Transform** y se guardan en vectores. Con la función **Vector3.Distance()**, el script calcula la distancia en el espacio 3D entre la esfera y el cilindro, así como entre la esfera y el cubo.

**Movimiento con Marcadores**

Este conjunto de scripts permite mover un objeto en Unity a distintas posiciones predefinidas cuando se mantiene presionada la barra espaciadora. 
El script **Marcador** funciona como un contenedor de tres **Vector3** llamados desplazamiento1, desplazamiento2 y desplazamiento3, que representan diferentes posiciones relativas respecto a la original. 

Por otro lado, el script Movermarcador hace referencia a este Marcador y utiliza una variable indice para elegir cuál de los tres desplazamientos aplicar. Al iniciar el juego, se guarda la posición original del objeto, y en cada actualización **(Update())** se detecta si la tecla espacio está presionada usando **Input.GetKey()**. Si lo está, el objeto se mueve sumando a su posición original el desplazamiento correspondiente según el índice. En cambio, si se suelta la tecla, el objeto regresa automáticamente a su posición inicial.
