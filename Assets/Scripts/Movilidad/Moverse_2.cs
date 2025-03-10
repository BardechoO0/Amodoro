using UnityEngine;

public class Moverse_2 : MonoBehaviour
{
    private CharacterController ch;

    [SerializeField] float moveSpeed, gravity, fallVelocity;

    private Vector3 axis, movePlayer;
    
    void Start()
    {
        ch = GetComponent<CharacterController>();

    }

    
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

        axis = new Vector3(-Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (axis.magnitude > 1)
        {
            axis = transform.InverseTransformDirection(axis).normalized;
        }
        else
        { 
            axis = transform.InverseTransformDirection(axis); 
        }
       

        ch.Move(axis * moveSpeed*Time.deltaTime);
    }
}
