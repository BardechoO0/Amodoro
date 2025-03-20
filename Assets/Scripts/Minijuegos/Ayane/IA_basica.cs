using UnityEngine;
using UnityEngine.AI;

public class IA_basica : MonoBehaviour
{
    public Transform objetivo;
  private NavMeshAgent agent;

    public Transform Usagi;

    [SerializeField] Animator anmin;
    void Start()
    {
        anmin.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(objetivo.position);
        anmin.SetFloat("Speed", agent.velocity.magnitude);
    }


    public void Look()
    {
        transform.LookAt(Usagi.position);
    }
}
