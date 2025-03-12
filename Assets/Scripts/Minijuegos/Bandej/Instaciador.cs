using UnityEngine;

public class Instaciador : MonoBehaviour
{
    public bool ocupado;

    [SerializeField] GameObject[] bandejas = new GameObject[0];

    public int N_orden;

    public bool dentro;

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
        Instantiate(bandejas[N_orden], transform.position, Quaternion.identity);
    }
    void Update()
    {
        if (ocupado && Input.GetKey(KeyCode.E) && dentro)
        {
            print("j");
            
            Instantiate(bandejas[N_orden], transform.position, Quaternion.identity);
            ocupado = false;
        }
    }
}
