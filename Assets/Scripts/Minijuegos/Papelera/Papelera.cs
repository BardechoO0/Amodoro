using System.Collections;
using UnityEngine;

public class Papelera : MonoBehaviour
{

    [SerializeField] Cojer_objeto Cj;

    private GameObject c;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7 || other.gameObject.layer == 8 || other.gameObject.layer == 9 || other.gameObject.layer == 10 || other.gameObject.layer == 11 || other.gameObject.layer == 12 || other.gameObject.layer == 14 || other.gameObject.layer == 15 || other.gameObject.layer == 16 || other.gameObject.layer == 17)
        {

            Destroy(other.gameObject);

            Cj.ckeker();


        }
    }

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
