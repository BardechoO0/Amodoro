using UnityEngine;

public class Empezar : MonoBehaviour
{
    [SerializeField] Instanciar IS;

    public bool dentro;

    [SerializeField] GameObject IMG;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dentro = true;
            IMG.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dentro = false;
            IMG.SetActive(false);
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
