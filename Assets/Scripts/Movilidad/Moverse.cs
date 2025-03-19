using JetBrains.Annotations;
using UnityEditor.Build.Pipeline.Utilities;
using UnityEngine;

public class Moverse : MonoBehaviour
{
    public float speed;
    public bool Stop;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Stop = false;
    }

    void Update()
    {
        transform.Rotate(0,Input.GetAxis("Mouse X")*2,0);

        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(MoveX, 0, MoveZ);
        if (!Stop)
        {
            transform.Translate(move * Time.deltaTime * speed);
        }
    }
      

    }
