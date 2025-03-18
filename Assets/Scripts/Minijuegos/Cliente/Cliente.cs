using System.Collections;
using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEditor.ShaderGraph.Drawing.Inspector.PropertyDrawers;
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

    //IA_cliente

    [SerializeField] IA_clientes IC;

    //dialogos

    [SerializeField] dialogos dg;

    void Start()
    {
        IC = GetComponent<IA_clientes>();
        Servido = false;
        IMG.SetActive(false);
        sentado = false;

        N_batido = 1;
        N_R_3 = Random.Range(0, 5);

        if (N_R_3 == 0) {

            comida = true;
            BatidoCafe = true;
            Agua = true;

        } else if (N_R_3 == 1) {
            comida = true;
            BatidoCafe = true;
            Agua = false;
        }
        else if (N_R_3 == 2)
        {
            comida = true;
            BatidoCafe = false;
            Agua = false;

        } else if (N_R_3 == 3) {

            comida = true;
            BatidoCafe = false;
            Agua = false;

        } else if (N_R_3 == 4) {

            comida = false;
            BatidoCafe = true;
            Agua = true;

        } 
        
    }

    public void llegar()
    {
        IMG.SetActive(true);
        print("j");
        if (comida)
        {
            if (IT[0].ocupado == false && IT[0] != null )
            {
                IT[0].nombreTag = X;
                dg.X = X;
                IT[0].Intanciador();
                R++;
            }
            else if (IT[1] != null && IT[1].ocupado == false )
            {
                IT[1].nombreTag = X;
                dg.X = X;
                IT[1].Intanciador();
                R++;
            }
            else if (IT[2] != null && IT[2].ocupado == false)
            {
                IT[2].nombreTag = X;
                dg.X = X;
                IT[2].Intanciador();
                R++;
            }
            else
            {
                print("pues ok");
            }
        }
        print("j");
        if (BatidoCafe)
        {
            N_R_1 = Random.Range(0, 3);

            if (N_R_1 == 0) 
            {
                Y = "Batido de fresa";
                dg.Y = Y;
                N_batido = 15;

            } else if (N_R_1 == 1) 
            {
                Y = "Batido de chocolate";
                dg.Y = Y;
                N_batido = 17;

            } else if (N_R_1 == 2)
            {
                Y = "Batido de Macha";
                dg.Y = Y;
                N_batido = 16;

            }


        }

        if (Agua)
        {

            Z = "Agua";
            dg.Z = Z;
        }

        dg.Clin();
    }


    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == X && Servido && comida) {

            cj.x.transform.SetParent(null);

            cj.ckeker();

            cj.GG();

            comida =false;

            Destroy(other.gameObject);

        }

        if (other.gameObject.layer == N_batido && Servido && BatidoCafe)
        {

            cj.x.transform.SetParent(null);

            cj.ckeker();

            BatidoCafe = false;

            Destroy(other.gameObject);
        }

        if (other.gameObject.layer == 7 && Z == "Agua" && Servido && Agua)
        {

            cj.x.transform.SetParent(null);

            cj.ckeker();

            Agua = false;

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Player" && sentado)
        {
            Dentro = true;
        }
        if (other.gameObject.tag == "Porta" && IC.lugar2 == true)
        {
            Destroy(gameObject);
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

        if (!comida && !BatidoCafe && !Agua)
        {
            print("j");
            StartCoroutine(comer(1));
        }

        if(IC.lugar2 == false && IC.lugar1 == false)
        {
            sentado = true;
            IMG.SetActive(true);
        }
    }

    IEnumerator comer(int t)
    {
        yield return new WaitForSeconds(t);
        IC.lugar2 = true;
    }
}
