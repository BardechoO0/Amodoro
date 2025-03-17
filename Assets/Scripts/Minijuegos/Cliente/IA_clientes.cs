using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class IA_clientes : MonoBehaviour
{
    public Transform objetivo;
    public Transform objetivo2;
    private NavMeshAgent agent;
    
    //private Animator animator;

    bool lugar1;

    public bool lugar2;

    private Coroutine detectionCoroutine;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //animator = GetComponent<Animator>();
        lugar1 = true;
        lugar2 = false;
    }

    void Update()
    {
        if (lugar1 && !lugar2)
        {
            agent.SetDestination(objetivo.position);

        }else if (!lugar1 && !lugar2) 
        {
            
        }
        else if (lugar1 && lugar2)
        {
            agent.SetDestination(objetivo2.position);
        }

        //animator.SetFloat("Speed", agent.velocity.magnitude);
    }

}
