using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Fin_demo : MonoBehaviour
{
    [SerializeField] dialogos dg;
    public bool dentro;
    [SerializeField] AudioSource SC;
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
            SC.Play();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            dg.Fin_Demo.SetActive(true);
            Destroy(gameObject);
        }
    }
}
