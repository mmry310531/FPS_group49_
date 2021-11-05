using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;


public class EnemyWalking : MonoBehaviour
{
    public Vector3 OriginalPosition;

    public NavMeshAgent agent;
    public GameObject player;
    public GameObject Target;
    public float range;

    private void Start()
    {
        
        OriginalPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position - transform.position).magnitude < range)
            Target = player;
        else
            Target = null;

        if (Target != null)
        {
            agent.SetDestination(Target.transform.position);
        }
        else
        {
            agent.SetDestination(OriginalPosition);
        }

    }
}
