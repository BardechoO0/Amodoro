using UnityEngine;

public class Chasla_3 : MonoBehaviour
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
        if (dentro && dg.U2)
        {
            dg.W3 = true;
        }
    }
}
