using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Explode : MonoBehaviour
{
    public float time;
    public float deltaTime;
    float range = 5.0f;
    public Rigidbody rb;
    public GameObject ps;
    SphereCollider sc;
    public bool damage_bool;

    void Start()
    {
        damage_bool = false;
        sc = this.gameObject.GetComponent<SphereCollider>();
    }

    void Update()
    {
        
        time -= Time.deltaTime * deltaTime;
        if (time <= 0 && !damage_bool)
        {
            // sc.radius = 20;
            GOT_Explode();
            //rb.AddExplosionForce(200f, this.transform.position, 200f);
            GameObject ps_o = Instantiate(ps, transform.position, transform.rotation);
            damage_bool = true;
            Destroy(this.gameObject);
            Destroy(ps_o, 3f);
        }
            


    }

    void GOT_Explode()
    {
        
        Collider[] colliders = Physics.OverlapSphere(transform.position, range);
        foreach(Collider c in colliders)
        {
            //Debug.Log(c.name);
            if (c.gameObject.tag == "Enemy")
            {
                
                Damage(c.transform);
            }
        }
    }
    void Damage(Transform transform)
    {
        transform.GetComponent<HP>().hpnow -= 40;
    }



}