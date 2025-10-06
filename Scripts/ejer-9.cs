using UnityEngine;

public class WASD : MonoBehaviour
{
    public float movHorizontal = 0f;
    public float movVertical = 0f;
    public float speed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)) {
            movHorizontal = -1f;
        }

        if(Input.GetKey(KeyCode.D)) {
            movHorizontal = 1f;
        }

        if(Input.GetKey(KeyCode.W)) {
            movVertical = 1f;
        }

        if(Input.GetKey(KeyCode.S)) {
            movVertical = -1f;
        }

        Vector3 movimiento = new Vector3(movHorizontal, 0f, movVertical);
        transform.Translate(movimiento * speed *  Time.deltaTime, Space.World);
    }
}
