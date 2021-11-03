using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject bomb_prefab;
    public float Height;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject bomb = Instantiate<GameObject>(bomb_prefab);
            bomb.transform.position = transform.position + transform.forward + new Vector3( 0, 0.5f, 0 );


            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward*4 + new Vector3(0,Height,0), ForceMode.Impulse);;
            
        }
    }
}
