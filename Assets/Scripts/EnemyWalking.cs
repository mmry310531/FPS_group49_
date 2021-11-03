using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;


public class EnemyWalking : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        // float destination = (transform.position - player.position).magnitude;
        // if (destination < 10) 
            agent.SetDestination(player.position);

    }
}
