using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject Player;
   [SerializeField] private bool isAtTarget = true;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player");
    }

    void Update()
    {        
        GoToSound();
    }

    private void GoToSound()
    {
        if (agent.pathStatus == NavMeshPathStatus.PathComplete)
        {
            isAtTarget = true;
        }        
    }

    public void Listen(GameObject t)
    {
            isAtTarget = false;
            agent.SetDestination(t.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AudibleObject")
        {
            Listen(other.GetComponentInParent<Collider>().gameObject);
        }
    }

}
