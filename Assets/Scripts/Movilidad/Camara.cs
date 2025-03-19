using UnityEngine;

public class Camara : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -Input.GetAxis("Mouse Y") * 2);

        

        
    }
}
