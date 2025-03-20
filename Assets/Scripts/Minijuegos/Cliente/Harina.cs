using UnityEngine;


public class Harina : MonoBehaviour
{
    [SerializeField] dialogos dg;

    [SerializeField] GameObject X;
    [SerializeField] GameObject Y;

    [SerializeField] Cojer_objeto Cj;

    public bool dentro;

    public bool dentro_h;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dentro = true;
        }

        if (other.gameObject.layer == 21)
        {
            Y = other.gameObject;
            dentro_h = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dentro_h = false;
        }

        if (other.gameObject.layer == 21)
        {
            X = null;
            dentro = false;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dg.S == true && dentro) 
        {
         dg.T = true;
         dg.S = false;
         X.GetComponent<Collider>().isTrigger = false;
        }

        if (X.GetComponent<Collider>().isTrigger == false && dentro && dentro_h && Input.GetKeyDown(KeyCode.E))
        {
            X.GetComponent<Collider>().isTrigger = true;
            Destroy(Y);
            Cj.ckeker();
            dentro_h = false;
        }
    }
}
