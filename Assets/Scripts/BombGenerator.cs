using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{

    public GameObject bomb_prefab;
    public float Height;
    public float timer;
    public bool reload;
    // Update is called once per frame
    private void Start()
    {
        reload = false;
        timer = 1f;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.E) && timer < 0f)
        {
            GameObject bomb = Instantiate<GameObject>(bomb_prefab);
            bomb.transform.position = transform.position + transform.forward + new Vector3( 0, 0.5f, 0 );


            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward*4 + new Vector3(0,Height,0), ForceMode.Impulse);;
            rb.velocity += transform.GetComponent<Rigidbody>().velocity;
            timer = 1f;
        }
    }
}
