using System.Collections;
using UnityEngine;

public class Instaciador : MonoBehaviour
{
    public bool ocupado;

    [SerializeField] GameObject[] bandejas = new GameObject[0];

    public int N_orden;

    public bool dentro;

    public bool badeja;

    public string nombreTag;
    private void OnTriggerEnter(Collider other)
    {
        

        if(other.gameObject.CompareTag("Player"))
        {
            dentro = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dentro = false;
        }

        if (other.gameObject.layer == 6)
        {

            ocupado = false;

        }
    }
    void Start()
    {
        ocupado = false;

    
    }
    public void Intanciador() {

        if (!ocupado)
        {

            

            ocupado = true;

        }
        else
        {
            print("Yo le digo hola y ella me dice godbye");
        }
    }

    public void fallaste()
    {
        ocupado = true;
        badeja = false;
        pedio();
    }

    IEnumerator pedio() 
    {

        badeja = true;

        yield return new WaitForSeconds(3);

        Instantiate(bandejas[N_orden], transform.position, Quaternion.identity);
        

    }

    
    void Update()
    {
        if (ocupado && Input.GetKeyDown(KeyCode.E) && dentro&& !badeja)
        {
            
            StartCoroutine(pedio());
        }
    }
}
