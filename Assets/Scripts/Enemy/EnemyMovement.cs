using UnityEngine.AI;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent _agent;
   [SerializeField] private bool _isAtTarget = true;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {        
        GoToSound();
    }

    private void GoToSound()
    {
        if (_agent.pathStatus == NavMeshPathStatus.PathComplete)
        {
            _isAtTarget = true;
        }        
    }

    public void Listen(GameObject t)
    {
            _isAtTarget = false;
            _agent.SetDestination(t.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AudibleObject")
        {
            Listen(other.GetComponentInParent<Collider>().gameObject);
        }
    }

}
