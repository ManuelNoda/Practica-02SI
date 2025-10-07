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

**Movimiento con flechas con el Cubo**

Lo que hace es detectar la presión de las flechas del teclado y calcular la velocidad del objeto en Unity en función de esas teclas. Primero definimos una variable pública velocidad que nos permite ajustar desde el inspector qué tan rápido se mueve el objeto.
Dentro del método **Update()**, obtenemos los valores de los ejes de movimiento usando **Input.GetAxisRaw("Vertical")** y **Input.GetAxisRaw("Horizontal")**. Estos valores devuelven -1, 0 o 1 dependiendo de si se presiona la flecha correspondiente, y nos permiten calcular el desplazamiento del objeto sin suavizado.

Después, comprobamos si se presionan las teclas específicas de flecha con **Input.GetKeyDown()**. Si se presiona la flecha arriba o abajo, multiplicamos velocidad por el eje vertical (ejeVertical) y mostramos el resultado en la consola. Si se presiona la flecha izquierda o derecha, hacemos lo mismo pero usando el eje horizontal (ejeHorizontal).

**Disparador letra H**

Primero, para crear el disparador, abrimos el **Input Manager**  (Edit,Project Settings,Input Manager) y añadimos un nuevo Input llamado **"Disparador"**, asignándole la tecla **H** como botón. 
Esto le dice a Unity que cada vez que se presione H, el input "Disparador" se activará.

Dentro del método **Update()**, que se ejecuta una vez por frame, usamos **Input.GetButtonDown("Disparador")** para detectar cuándo se presiona la tecla asignada. Esto nos permite ejecutar acciones exactamente en el frame en que se pulsa la tecla, sin repetir la acción mientras se mantiene presionada.

**Movimiento de un Cubo**

Definimos una variable pública movimeinto usando un **Vector3**, que indica la dirección del movimiento respecto a los ejes (en este caso por defecto **Vector3.right**, es decir, hacia la derecha). También definimos speed, que nos permite ajustar la velocidad del movimiento desde el inspector.En el método **Start()**, que se ejecuta al iniciar la escena, creamos una variable auxiliar **position_aux** con la posición inicial del cubo. 

Luego, fijamos la coordenada y en 0 para asegurarnos de que el cubo siempre se mantenga sobre el plano horizontal, y asignamos esa posición de vuelta al transform del cubo.

Dentro del método **Update()**, que se ejecuta una vez por frame, usamos **transform.Translate()** para mover el cubo en la dirección definida por movimeinto, multiplicada por la velocidad y por **Time.deltaTime.** Esto asegura que el movimiento sea suave y consistente, independientemente de los frames por segundo. El parámetro **Space.World** indica que el movimiento se hace respecto al mundo y no a la orientación local del objeto.

**Movimiento del Cubo con WASD**

Usamos las teclas W, A, S y D para controlar el desplazamiento en los ejes horizontal y vertical. Primero definimos las variables **movHorizontal** y **movVertical**, que almacenan la dirección del movimiento en cada eje, y speed, que determina qué tan rápido se moverá el objeto.

Dentro del método **Update()**, que se ejecuta una vez por frame, el script comprueba si se presionan las teclas correspondientes usando **Input.GetKey()**. Si se presiona la tecla A, el valor del eje horizontal se establece en -1, indicando movimiento hacia la izquierda; si se presiona D, se establece en 1, indicando movimiento hacia la derecha. De manera similar con W (movimiento hacia adelante y S (movimiento hacia atrás).

Después, se crea un **Vector3** llamado movimiento que combina estos valores en los ejes X y Z, dejando Y en 0 para que el objeto no se mueva verticalmente. Este vector se multiplica por **speed** y por **Time.deltaTime** dentro de **transform.Translate()**, lo que asegura que el movimiento sea suave y consistente, sin depender de la cantidad de frames por segundo. Se usa **Space.World** para que el desplazamiento se haga respecto al mundo y no a la orientación local del objeto.

**Movimiento del Cubo hacia la Esfera**

Este script lo que hace es adaptar el movimiento de un cubo para que se desplace hacia la posición de una esfera, sin importar qué tan lejos o cerca estén los dos objetos. Primero declaramos una variable pública **esfera** de tipo **Transform**, que sirve para indicar el objeto al que el cubo debe dirigirse, y la variable **speed** que controla la velocidad de avance.

Dentro del método **Update()**, lo primero que hace el script es comprobar si la esfera está asignada; si no lo está, el código se detiene con return. Luego usamos **transform.LookAt(esfera)** para que el cubo siempre mire en dirección a la esfera.

Después, calculamos un vector direccion restando la posición del cubo a la posición de la esfera **(esfera.position - transform.position)**. Para que el cubo no cambie de altura, se fuerza el valor de direccion.y a 0. Posteriormente, normalizamos el vector **(direccion.normalized)** para que su magnitud siempre sea 1. Esto es importante porque asegura que la velocidad del cubo no dependa de la distancia entre los dos objetos, tal como pide el enunciado.

Finalmente, el cubo se mueve en dirección a la esfera usando **transform.Translate()**, multiplicando el vector normalizado por la velocidad y por **Time.deltaTime**, garantizando un movimiento uniforme en cualquier situación. Usamos **Space.World** para que el desplazamiento sea en el espacio global y no en relación a la orientación del cubo.
