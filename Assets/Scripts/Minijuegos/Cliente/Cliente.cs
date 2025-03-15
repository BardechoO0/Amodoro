using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEngine;
using UnityEngine.XR;

public class Cliente : MonoBehaviour
{
    public GameObject IMG;
    [SerializeField] Instaciador[] IT = new Instaciador[0];
    [SerializeField] Cojer_objeto cj;
    public int R;
    
    bool Dentro;
    bool Servido;
    bool sentado;

    //Nombre de las objetos a recibir
    public string X;
    public string Y;
    public string Z;

    //Capcidad de pedir algo.
    public bool comida;
    public bool BatidoCafe;
    public bool Agua;

    int N_batido;

    int N_R_1;
    int N_R_2;
    int N_R_3;

    void Start()
    {
        Servido = false;
        IMG.SetActive(true);
        sentado = true;


        N_R_3 = Random.Range(0,6);

        if (N_R_3 == 0) {

            comida = true;
            BatidoCafe = true;
            Agua = true;

        } else if (N_R_3 == 1) {
            comida = true;
            BatidoCafe= true;
            Agua = false;
        }
        else if (N_R_3 == 2)
        {
            comida = true;
            BatidoCafe= false;
            Agua = false;

        } else if (N_R_3 == 3){

            comida = true;
            BatidoCafe = false;
            Agua = false;

        } else if (N_R_3 == 4){

        } else if (N_R_3 == 5){

        }else if (N_R_3 == 6) {
        }
    }

    public void llegar()
    {
        IMG.SetActive(true);

        if (comida)
        {
            if (IT[0].ocupado == false)
            {
                IT[0].nombreTag = X;
                IT[0].Intanciador();
                R++;
            }
            else if (IT[1].ocupado == false)
            {
                IT[1].nombreTag = X;
                IT[1].Intanciador();
                R++;
            }
            else if (IT[2].ocupado == false)
            {
                IT[2].nombreTag = X;
                IT[2].Intanciador();
                R++;
            }
            else
            {
                print("pues ok");
            }
        }

        if (BatidoCafe)
        {
            N_R_1 = Random.Range(0, 3);

            if (N_R_1 == 0) 
            {
                Y = "Vaso_fresa";

                N_batido = 15;

            } else if (N_R_1 == 1) 
            {
                Y = "Vaso_Chocolate";

                N_batido = 17;

            } else if (N_R_1 == 2)
            {
                Y = "Vaso_Macha";

                N_batido = 16;

            }


        }
    }


    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == X) {

            cj.x.transform.SetParent(null);

            cj.ckeker();

            cj.GG();

            Destroy(other.gameObject);

        }

        if (other.gameObject.layer == N_batido)
        {

            cj.x.transform.SetParent(null);

            cj.ckeker();

            cj.GG();

            Destroy(other.gameObject);

        }

        if (other.gameObject.tag == "Player")
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
