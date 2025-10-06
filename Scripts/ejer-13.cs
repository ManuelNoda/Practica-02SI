
using UnityEngine;

public class MovimientoObjetivo : MonoBehaviour
{
    public float velocidad = 5f;       
    public float velocidadGiro = 100f;

    void Update()
    {
        float giro = Input.GetAxis("Horizontal");
        transform.Rotate(0f, giro * velocidadGiro * Time.deltaTime, 0f);
        transform.position += transform.forward * velocidad * Time.deltaTime;
        Debug.DrawRay(transform.position, transform.forward * 2f, Color.red);
    }
}
