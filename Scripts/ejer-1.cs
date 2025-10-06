using UnityEngine;


public class ejerColor : MonoBehaviour
{
    public Vector3 randomVector;   
    public int numberFrames = 120; 
    private int countFrames = 0;

    void Start()
    {
        randomVector = new Vector3(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );

        Color randomColor = new Color(randomVector.x, randomVector.y, randomVector.z);
        GetComponent<Renderer>().material.color = randomColor;
    }

    void Update()
    {
        countFrames++;

        if (countFrames >= numberFrames)
        {
            countFrames = 0;
            int index = Random.Range(0, 3);
            if (index == 0)
                randomVector.x = Random.Range(0f, 1f);
            else if (index == 1)
                randomVector.y = Random.Range(0f, 1f);
            else
                randomVector.z = Random.Range(0f, 1f);
                
            Color newColor = new Color(randomVector.x, randomVector.y, randomVector.z);
            GetComponent<Renderer>().material.color = newColor;
        }
    }
}
