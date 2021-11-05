using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;


public class EnemyWalking : MonoBehaviour
{
    public Vector3 OriginalPosition;


    public GameObject player;

    public float range;

    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position - transform.position).magnitude < range)
        {
            Vector3 Dir = player.transform.position - transform.position;
            transform.position += Dir.normalized * 3f * Time.deltaTime;
            transform.forward = Dir.normalized;
        }

    }
}
