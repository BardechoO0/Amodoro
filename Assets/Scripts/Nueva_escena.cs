using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Nueva_escena : MonoBehaviour
{
    [SerializeField] dialogos dg;

    bool dentro;
    void Start()
    {
        
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

    }
    // Update is called once per frame
    void Update()
    {
        if (dentro && dg.Salir == true) {

            print("adio Unity");
        
        }
    }
}
