using JetBrains.Annotations;
using UnityEditor.Timeline;
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
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(MoveX, 0, MoveZ);

      transform.Translate(move*Time.deltaTime*speed);

        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

        //transform.Translate(move, Space.World);

        //transform.rotation = Quaternion.Euler(transform.rotation.x,Camera.main.transform.rotation.y,transform.rotation.z);

    }
      

    }
