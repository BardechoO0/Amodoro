using JetBrains.Annotations;
using UnityEngine;

public class Moverse : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(MoveX, 0, MoveZ);

      transform.Translate(move*Time.deltaTime*speed); 

    }
      

    }
