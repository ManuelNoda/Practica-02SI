using UnityEngine;

public class PosicionEsfera : MonoBehaviour
{
    private GameObject esfera;
    private GameObject cilindro;
    private GameObject cubo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        esfera = GameObject.FindWithTag("esfera");
        cilindro = GameObject.FindWithTag("cilindro");
        cubo = GameObject.FindWithTag("cubo");
        Vector3 position1 = esfera.transform.position;
        Vector3 position2 = cilindro.transform.position;
        Vector3 position3 = cubo.transform.position;
        float distancia = Vector3.Distance(position1, position2);
        float distancia2 = Vector3.Distance(position1, position3);
        Debug.Log("Distancia entre la esfera y el cilindro: " + distancia);
        Debug.Log("Distancia entre la esfera y el cubo: " + distancia2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
