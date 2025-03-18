using UnityEngine;

public class Cojer_objeto : MonoBehaviour
{
    public Transform mano;
    public GameObject x;

    public bool activo;

    public bool inHand=false;

    public KeyCode Tecla = KeyCode.E;

    public Vector2 h;

    [SerializeField] Bandeja bj;

    public bool Minijuego;
    void Start()
    {
        Minijuego = false;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 6  && inHand==false)
        {
            activo = true;
            Minijuego = true;
            x = collision.gameObject;

            bj = x.GetComponent<Bandeja>();

            x.GetComponent<Rigidbody>();

        }

        if (inHand == false)
        {
            if (collision.gameObject.layer == 7 || collision.gameObject.layer == 8 || collision.gameObject.layer == 9 || collision.gameObject.layer == 10 || collision.gameObject.layer == 11 || collision.gameObject.layer == 12 || collision.gameObject.layer ==14 || collision.gameObject.layer == 15 || collision.gameObject.layer == 16 || collision.gameObject.layer == 17)
            {
                activo = true;

                x = collision.gameObject;

                x.GetComponent<Rigidbody>();
            }
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.layer == 6 && inHand == false)
        {
            activo = false;
            Minijuego = false;
            x = null;

            bj = null;
        }

        if (inHand == false)
        {
            if (collision.gameObject.layer == 7|| collision.gameObject.layer == 8|| collision.gameObject.layer == 9 || collision.gameObject.layer == 10 || collision.gameObject.layer == 11 || collision.gameObject.layer == 12 || collision.gameObject.layer == 14 || collision.gameObject.layer == 15 || collision.gameObject.layer == 16 || collision.gameObject.layer == 17)
            {
                activo = false;

                x = null;

            }
        }

    }
    void Update()
    {
        h = transform.position;
        if (activo) {

            if (Input.GetKeyDown(Tecla) && inHand == false)
            {
                if(bj != null) { bj.Activ(); }
                

                x.GetComponent<Collider>().isTrigger = true;
                x.GetComponent<Rigidbody>().useGravity = false;
                x.transform.SetParent(mano);

                inHand = true;

                

            }
            else if (Input.GetKeyDown(Tecla) && inHand == true && Minijuego == false) 
            
            {
                if (bj != null) { bj.DesActiv(); }
                

                x.GetComponent<Collider>().isTrigger= false;
                x.GetComponent<Rigidbody>().useGravity = true;
                x.transform.SetParent(null);
                bj = null;
                inHand = false;

            }


            if (bj != null)
            {
                if (bj.x.value == 1 || bj.x.value == -1)
                {


                    x.GetComponent<Collider>().isTrigger = false;
                    x.GetComponent<Rigidbody>().useGravity = true;
                    Minijuego = false;
                    x.transform.SetParent(null);

                    bj.Errar();
                    x.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 1 * bj.x.value) * 5, ForceMode.Impulse);


                    bj.DesActiv();
                    bj = null;
                    x.gameObject.tag = "Fallo";
                    ckeker();
                    inHand = false;
                }

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
        Minijuego = false;

    }

    public void GG()
    {
        bj.Fin();
    }
}
