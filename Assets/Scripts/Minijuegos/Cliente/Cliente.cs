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


    void Start()
    {
        IMG.SetActive(false);

        llegar();

        
    }

    public void llegar()
    {
        IMG.SetActive(true);

        if (IT[0].ocupado == false)
        {
            IT[R].Intanciador();
            R++;
        }
        else if (IT[1].ocupado == false)
        {
            IT[1].Intanciador();
            R++;
        }
        else if (IT[2].ocupado == false)
        {
            IT[2].Intanciador();
            R++;
        }
        else {
            print("pues ok");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Plato") {
        



          Destroy(other.gameObject);

            cj.x.transform.SetParent(null);
            
            cj.inHand = false;

        }
    }
    void Update()
    {
        
    }
}
