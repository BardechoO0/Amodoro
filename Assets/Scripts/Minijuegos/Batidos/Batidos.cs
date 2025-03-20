using System.Collections;

using UnityEngine;

public class Batidos : MonoBehaviour
{
    public bool personaDentro;

    public bool vasoDentro;

    public bool vasoColocado;

    public bool IngredienteDentro;

    [SerializeField] GameObject Vaso;

    [SerializeField] GameObject Ingrediente;

    [SerializeField] GameObject[] Batido_final;

    [SerializeField] Transform zona;

    [SerializeField] Cojer_objeto Cj;

    public int R;

    public float batir;
    bool Ingrediente_metido;
    void Start()
    {
        batir = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            personaDentro = true;
        }
        if (other.gameObject.layer == 8 && !vasoColocado)
        {
            vasoDentro = true;

            Vaso = other.gameObject;
        }
        if (other.gameObject.layer == 10|| other.gameObject.layer == 11 || other.gameObject.layer == 12 )
        {
            IngredienteDentro = true;

            Ingrediente = other.gameObject;
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
        if (other.gameObject.layer == 10 || other.gameObject.layer == 11 || other.gameObject.layer == 12)
        {
            IngredienteDentro = false;
        }
        if (other.gameObject.layer == 15 || other.gameObject.layer == 16 || other.gameObject.layer == 17)
        {
            vasoColocado = false;
        }
    }

    IEnumerator Times()
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
        R = Ingrediente.layer -10;
        Destroy(Ingrediente);

        yield return new WaitForSeconds(3f);

        Destroy(Vaso);
        Instantiate(Batido_final[R], zona.position, Quaternion.identity);
        IngredienteDentro = false;
    }
    void Update()
    {
        if (personaDentro && vasoDentro && !vasoColocado && Input.GetKeyDown(KeyCode.E))
        {

            StartCoroutine(Times());
            vasoColocado = true;

        }

        if (personaDentro && vasoColocado && IngredienteDentro && Input.GetKeyDown(KeyCode.E)&&!Ingrediente_metido)
        {

            

            Cj.ckeker();
            Cj.x.transform.SetParent(null);
            Cj.x = null;
            R = Ingrediente.layer - 10;
            Destroy(Ingrediente);
            Ingrediente_metido = true;

        }

        if (Input.GetMouseButton(1)&&Ingrediente_metido&&personaDentro) 
        {

            batir += 1*Time.deltaTime;

            if (batir > 4) 
            {
                Destroy(Vaso);
                Instantiate(Batido_final[R], zona.position, Quaternion.identity);
                IngredienteDentro = false;
                Ingrediente_metido = false;
                batir = 0;
            }
        
        }
    }
}
