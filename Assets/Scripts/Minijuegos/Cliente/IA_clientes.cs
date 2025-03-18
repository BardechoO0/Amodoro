using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class IA_clientes : MonoBehaviour
{
    public Transform objetivo;
    public Transform objetivo2;
    public Transform Mirar;
    private NavMeshAgent agent;

    
    //private Animator animator;

    public bool lugar1;

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
            transform.LookAt(new Vector3(Mirar.position.x,Mirar.position.y,0));
        }
        else if (!lugar1 && lugar2)
        {
            agent.SetDestination(objetivo2.position);
        }

        if (new Vector3(objetivo.position.x,0,objetivo.position.z) == new Vector3(transform.position.x, 0, transform.position.z))
        {
            lugar1 = false;
        }

        //animator.SetFloat("Speed", agent.velocity.magnitude);
    }

}
