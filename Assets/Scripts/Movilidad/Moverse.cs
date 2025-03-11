using JetBrains.Annotations;
using UnityEngine;

public class Moverse : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        transform.Rotate(0,Input.GetAxis("Mouse X")*2,0);

        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(MoveX, 0, MoveZ);

      transform.Translate(move*Time.deltaTime*speed); 

    }
      

    }
