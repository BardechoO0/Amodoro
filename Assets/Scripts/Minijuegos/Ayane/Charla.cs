using UnityEngine;

public class Charla : MonoBehaviour
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
    void Update()
    {
        if (dentro)
        {
            dg.Convers_3 = true;
        }
    }
}
