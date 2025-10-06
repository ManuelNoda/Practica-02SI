using UnityEngine;

public class Velocidad : MonoBehaviour
{
    public float velocidad;

    void Update()
    {
        // Calculamos los ejes al inicio del Update para que estén en alcance
        // Input.GetAxisRaw devuelve -1, 0 o 1 sin suavizado (recomendado si usas GetKeyDown)
        float ejeVertical = Input.GetAxisRaw("Vertical");
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Flecha Arriba: " + (velocidad * ejeVertical));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Flecha Abajo: " + (velocidad * ejeVertical));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Flecha Izquierda: " + (velocidad * ejeHorizontal));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Flecha Derecha: " + (velocidad * ejeHorizontal));
        }
    }
}
    

