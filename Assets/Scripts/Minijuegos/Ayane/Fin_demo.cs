using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Fin_demo : MonoBehaviour
{
    [SerializeField] dialogos dg;
    public bool dentro;
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

    private void Update()
    {
        if (dentro)
        {
            
            dg.Fin_Demo.SetActive(true);
            Destroy(gameObject);
        }
    }
}
