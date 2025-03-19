using UnityEngine;
using UnityEngine.AI;

public class IA_basica : MonoBehaviour
{
    public Transform objetivo;
  private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(objetivo.position);
    }
}
