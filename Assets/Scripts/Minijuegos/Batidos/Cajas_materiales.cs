using System.Collections;
using UnityEngine;

public class Cajas_materiales : MonoBehaviour
{
    public bool dentro;

    public bool espera;

    public int capa_recurso;

    [SerializeField] GameObject recurso;
    void Start()
    {
        Instantiate(recurso,transform.position,Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
         dentro = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dentro = false;
        }
        if (other.gameObject.layer == capa_recurso) 
        {
            if (espera)
            {
                Instantiate(recurso, transform.position, Quaternion.identity);
                espera = false;
            }

            
        }
    }

    IEnumerator Espera()
    {
        yield return new WaitForSeconds(5f);
        espera = false;
    }
    void Update()
    {
        if (dentro && Input.GetKeyDown(KeyCode.E)&&!espera) 
        {
            
            espera = true;
           
        }
    }
}
