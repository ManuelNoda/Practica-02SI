using UnityEngine;

public class VectorSphere : MonoBehaviour
{
    public Vector3 vectorUno;
    public Vector3 vectorDos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float mag1 = vectorUno.magnitude;
        float mag2 = vectorDos.magnitude;
        Debug.Log("Magnitud vectorUno:" + mag1);
        Debug.Log("Magnitud vectorDos:" + mag2);
        float angle = Vector3.Angle(vectorUno, vectorDos);
        Debug.Log("Ángulo entre dos vectores:" + angle);
        float distan = Vector3.Distance(vectorUno, vectorDos);
        Debug.Log("Distancia entre dos vectores:" + distan);
        if (vectorUno.y > vectorDos.y)
        {
            Debug.Log("El vectorUno esta a mayor altura.");
        }
        else if (vectorUno.y < vectorDos.y)
        {
            Debug.Log("El vectorDos esta a mayor altura.");
        }
        else
        {
            Debug.Log("Estan a la misma altura");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
