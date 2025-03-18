using System.Collections;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    [SerializeField] GameObject[] Cliente;

    [SerializeField] GameObject[] Asientos;

    [SerializeField] GameObject[] Mirar;

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


    IEnumerator ZaWardo()
    {

        for (int i = 0; i < Asientos.Length; i++)
        {
            yield return new WaitForSeconds(Random.Range(0.5f,10f));
            R = Random.Range(0, Cliente.Length);
            W = i;

            if (!ocupado[W])
            {

                ocupado[W] = true;

                Clientes2[W] = Instantiate(Cliente[R], transform.position, Quaternion.identity);
                Clientes2[W].GetComponent<IA_clientes>().objetivo = Asientos[W].transform;
                Clientes2[W].GetComponent<IA_clientes>().Mirar = Mirar[W].transform;


            }

        }

    }
    public void Entran() 
    {
        StartCoroutine(ZaWardo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
