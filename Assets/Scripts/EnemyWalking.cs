using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyWalking : MonoBehaviour
{
    public Vector3 OriginalPosition;

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
        {
            Vector3 direction = (player.transform.position - transform.position).normalized;
            transform.position +=  direction * 3f * Time.deltaTime;
            transform.forward = direction;
        }
            

    }
}
