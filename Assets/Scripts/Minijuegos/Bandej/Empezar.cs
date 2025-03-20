using UnityEngine;

public class Empezar : MonoBehaviour
{
    [SerializeField] Instanciar IS;

    public bool dentro;
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
        if (dentro && Input.GetKeyDown(KeyCode.E))
        {

            IS.Entran();

        }
    }
}
