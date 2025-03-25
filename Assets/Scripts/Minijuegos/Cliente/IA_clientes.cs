using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class IA_clientes : MonoBehaviour
{
    public Transform objetivo;
    public Transform objetivo2;
    public Transform Mirar;
    private NavMeshAgent agent;

    [SerializeField] Animator anim;

    
    //private Animator animator;

    public bool lugar1;

    public bool lugar2;

    public bool lugar3;

    private Coroutine detectionCoroutine;

    void Start()
    {
        anim.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        
        lugar1 = true;
        lugar2 = false;
        lugar3 = false;
    }

    void Update()
    {
        if (lugar1 && !lugar2)
        {
            if (!lugar3)
            {
                agent.SetDestination(objetivo.position);
               
                lugar3 = true;
            }
        

        }
        else if (!lugar1 && !lugar2)
        {
            transform.LookAt(new Vector3(Mirar.position.x, Mirar.position.y, 0));
        }
        else if (!lugar1 && lugar2)
        {
            agent.SetDestination(objetivo2.position);
            anim.SetBool("Sit", false);

        }
        else
        {
            agent.SetDestination(objetivo.position);
            anim.SetBool("Sit", false);

        }

        if (new Vector3(objetivo.position.x,0,objetivo.position.z) == new Vector3(transform.position.x, 0, transform.position.z))
        {
            lugar1 = false;
        }

        //animator.SetFloat("Speed", agent.velocity.magnitude);
    }

}
