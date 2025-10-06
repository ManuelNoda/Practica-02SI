using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    //direccion respecto al eje x
    public Vector3 movimeinto = Vector3.right;
    public float speed = 2f;
    void Start()
    {
        Vector3 position_aux = transform.position;
        position_aux.y = 0f;
        transform.position = position_aux;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movimeinto * speed *  Time.deltaTime, Space.World);
    }
}
