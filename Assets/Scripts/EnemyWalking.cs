using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;


public class EnemyWalking : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public Vector3 Destination;
    public float range;
    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position - transform.position).magnitude < range)
            Destination = player.position;
        else
            Destination = transform.position;

        agent.SetDestination(Destination);

    }
}
