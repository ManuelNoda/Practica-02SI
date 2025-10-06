using UnityEngine;

public class VectorEsfera: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 vectorposition = GetComponent<Transform>().transform.position;
        Debug.Log("Posicion de la esfera:" + vectorposition.x + " " + vectorposition.y + " " + vectorposition.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
