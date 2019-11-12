using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject Player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        agent.SetDestination(Player.transform.position);
    }

    private void CreatePath()
    {
        NavMeshPath path = new NavMeshPath();
        agent.CalculatePath(Player.transform.position,path);
    }
}
