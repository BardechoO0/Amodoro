using UnityEngine;

public class Instaciador : MonoBehaviour
{
    public bool ocupado;

    [SerializeField] GameObject[] bandejas = new GameObject[0];

    public int N_orden;

    private void OnTriggerEnter(Collider other)
    {
        
        if( ocupado && Input.GetKey(KeyCode.E) && other.gameObject.CompareTag("Player"))
        {
            print("j");
            Instantiate(bandejas[N_orden], transform.position, Quaternion.identity);
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
        Instantiate(bandejas[N_orden], transform.position, Quaternion.identity);
    }
    void Update()
    {
        
    }
}
