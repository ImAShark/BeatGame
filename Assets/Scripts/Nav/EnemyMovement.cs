using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject Player;
    private Vector3 target;
   [SerializeField] private bool isAtTarget = true, heardSound;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player");
        Listen();
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
            heardSound = false;

        }
        if (!isAtTarget)
        {
            agent.SetDestination(target);
        }        
    }

    public void Listen()
    {
        if (!heardSound)
        {
            target = Player.transform.position;
            heardSound = true;
            isAtTarget = false;
            agent.SetDestination(target);
        }
    }

}
