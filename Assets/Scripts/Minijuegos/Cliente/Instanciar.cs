using UnityEngine;

public class Instanciar : MonoBehaviour
{
    [SerializeField] GameObject[] Cliente;

    [SerializeField] GameObject[] Asientos;

    public bool[] ocupado;

    int W;

    int R;

    [SerializeField] GameObject[] Clientes2;

    private void OnTriggerEnter(Collider other)
    {
        
    }


    void Start()
    {

        ocupado = new bool[Asientos.Length];

        Entran();

        

        
    }

    public void Entran() 
    {
        for (int i = 0; i < Asientos.Length; i++)
        {
            
            R = Random.Range(0, Cliente.Length);
            W = i;
            
            if (!ocupado[W])
            {
                
                ocupado[W] = true;
                
                Clientes2[W] = Instantiate(Cliente[R], transform.position,Quaternion.identity);
                Clientes2[W].GetComponent<IA_clientes>().objetivo = Asientos[W].transform;


            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
