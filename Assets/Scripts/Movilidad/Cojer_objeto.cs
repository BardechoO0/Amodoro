using UnityEngine;

public class Cojer_objeto : MonoBehaviour
{
    public Transform mano;
    public GameObject x;

    public bool activo;

    public bool inHand=false;

    public KeyCode Tecla = KeyCode.E;

    public Vector2 h;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Plato" && inHand==false)
        {
            activo = true;

            x = collision.gameObject;

            x.GetComponent<Rigidbody>();

        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Plato" && inHand == false)
        {
            activo = false;

            x = null;
        }

        

    }
    void Update()
    {
        h = transform.position;
        if (activo) {

            if (Input.GetKeyDown(Tecla) && inHand == false)
            {
                
                x.GetComponent<Collider>().isTrigger = true;
                x.GetComponent<Rigidbody>().useGravity = false;
                x.transform.SetParent(mano);

                inHand = true;

                

            }
            else if (Input.GetKeyDown(Tecla) && inHand == true) 
            
            {
                x.GetComponent<Collider>().isTrigger = false;
                x.GetComponent<Rigidbody>().useGravity = true;
                x.transform.SetParent(null);

                inHand = false;

            }

            if (inHand == true) 
            {
                x.transform.position = mano.position;
            }

            
        
        }
        
    }

    public void ckeker() 
    {

        activo = false;
        inHand = false;


    }
}
