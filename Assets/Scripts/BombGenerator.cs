using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject bomb_prefab;
    public Vector3 ThrowDirection;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject bomb = Instantiate<GameObject>(bomb_prefab);
            bomb.transform.position = transform.position + offset;


            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            rb.AddForce(ThrowDirection, ForceMode.Impulse);
        }
    }
}
