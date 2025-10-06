using UnityEngine;
public class Movermarcador : MonoBehaviour
{
    public Marcador marcador;   // referencia al objeto Marcador
    public int indice;

    private Vector3 posicionOriginal;

    void Start()
    {
        posicionOriginal = transform.position;
    }
    void Update()
    {
        // Con el sistema antiguo usamos Input.GetKey
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 desplazamiento = Vector3.zero;

            if (indice == 1) desplazamiento = marcador.desplazamiento1;
            else if (indice == 2) desplazamiento = marcador.desplazamiento2;
            else if (indice == 3) desplazamiento = marcador.desplazamiento3;

            transform.position = posicionOriginal + desplazamiento;
        }
        else
        {
            // Si sueltas la barra espaciadora, vuelve a su posición original
            transform.position = posicionOriginal;
        }
    }
}
