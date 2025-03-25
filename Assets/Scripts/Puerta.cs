using System.Collections;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField] GameObject puerta;

    [SerializeField] GameObject IMG;

    public bool dentro;

    public bool act;

    public bool act_2;
    void Start()
    {
        GetComponent<Collider>();

        IMG.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            dentro = true;
            IMG.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dentro = false;
            IMG.SetActive(false);
        }
    }
    void Update()
    {
        if (dentro && Input.GetKeyUp(KeyCode.E) && !act && !act_2)
        {
            act = true;
            StartCoroutine(Abrir());
        }

        if (act) 
        {
            puerta.transform.Rotate(0, 180*Time.deltaTime, 0);

            
        }

        if (act_2)
        {
            puerta.transform.Rotate(0, -180 * Time.deltaTime, 0);
        }
    }

    IEnumerator Abrir()
    {    
        yield return new WaitForSeconds(0.5f);
        act = false;
        
        yield return new WaitForSeconds(5f);
        act_2 = true;
        StartCoroutine(Cerrar());
    }

    IEnumerator Cerrar() 
    {
        
        yield return new WaitForSeconds(0.5f);

        act_2 = false;
        
    }
}
