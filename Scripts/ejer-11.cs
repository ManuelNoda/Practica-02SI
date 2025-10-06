using UnityEngine;

public class CuboAEsfera : MonoBehaviour
{
    public Transform esfera;
    public float speed = 2f;
    // Update is called once per frame
    void Update()
    {
        if(esfera == null) return;
        transform.LookAt(esfera);
        Vector3 direccion = esfera.position - transform.position;
        direccion.y = 0f; // no alterar la altura
        direccion = direccion.normalized;
        transform.Translate(direccion * speed *  Time.deltaTime, Space.World);
    }
}
