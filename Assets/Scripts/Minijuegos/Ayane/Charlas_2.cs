using UnityEngine;

public class Charlas_2 : MonoBehaviour
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
        if (dentro && dg.W)
        {
            dg.W2 = true;
        }
    }
}
