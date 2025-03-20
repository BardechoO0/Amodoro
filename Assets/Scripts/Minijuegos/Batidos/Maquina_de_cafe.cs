using System.Collections;
using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEngine;

public class Maquina_de_cafe : MonoBehaviour
{
    public bool personaDentro;

    public bool vasoDentro;

    public bool vasoColocado;

    public bool cacoDentro;

    [SerializeField] GameObject Vaso;

    [SerializeField] GameObject Caoa;

    [SerializeField] GameObject Cafe_;

    [SerializeField] Transform zona;

    [SerializeField] Cojer_objeto Cj;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            personaDentro = true;
        }
        if (other.gameObject.layer == 18 && !vasoColocado) 
        {
         vasoDentro = true;

          Vaso = other.gameObject;    
        }
        if (other.gameObject.layer == 9)
        {
            cacoDentro = true;

            Caoa = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            personaDentro = false;
        }
        if (other.gameObject.layer == 8)
        {
            vasoDentro = false;
        }
        if (other.gameObject.layer == 9)
        {
            cacoDentro = false;
        }
        if (other.gameObject.layer == 14)
        {
            vasoColocado = false;
        }
    }

    IEnumerator Time()
    {
        yield return new WaitForSeconds(0.1f);
        Vaso.transform.SetParent(zona);
        Vaso.gameObject.layer = 13;
        Cj.x = null;
        Vaso.transform.position = zona.position;
        vasoDentro = false;
    }

    IEnumerator Cafe()
    {
        Cj.ckeker();
        Cj.x.transform.SetParent(null);
        Cj.x = null;

        Destroy(Caoa);
        yield return new WaitForSeconds(3f);
        Destroy(Vaso);
        Instantiate(Cafe_, zona.position, Quaternion.identity);
        cacoDentro = false ;
    }
    void Update()
    {
        if (personaDentro && vasoDentro && !vasoColocado && Input.GetKeyDown(KeyCode.E)){

            StartCoroutine(Time());
            vasoColocado = true;

        }

        if (personaDentro && vasoColocado && cacoDentro && Input.GetKeyDown(KeyCode.E)) 
        { 
        
         StartCoroutine(Cafe());    
        
        }
        
    }
}
