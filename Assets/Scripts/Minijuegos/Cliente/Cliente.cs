using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEngine;
using UnityEngine.XR;

public class Cliente : MonoBehaviour
{
    public GameObject IMG;

    [SerializeField] Instaciador[] IT = new Instaciador[0];

    [SerializeField] Cojer_objeto cj;

    public int R;

    public string X;

    bool Dentro;

    bool Servido;

    bool sentado;
    void Start()
    {
        Servido = false;
        IMG.SetActive(true);
        sentado = true;

        

        
    }

    public void llegar()
    {
        IMG.SetActive(true);

        if (IT[0].ocupado == false)
        {
            IT[0].nombreTag = X;
            IT[0].Intanciador();
            R++;
        }
        else if (IT[1].ocupado == false)
        {
            IT[0].nombreTag = X;
            IT[1].Intanciador();
            R++;
        }
        else if (IT[2].ocupado == false)
        {
            IT[0].nombreTag = X;
            IT[2].Intanciador();
            R++;
        }
        else {
            print("pues ok");
        }
    }


    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == X) {

            cj.x.transform.SetParent(null);

            cj.ckeker();




            Destroy(other.gameObject);

            

        }

        if(other.gameObject.tag == "Player")
        {
            Dentro = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Dentro = false;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&& Dentro && !Servido && sentado) 
        {
            llegar();
            Servido = true;
        }
    }
}
