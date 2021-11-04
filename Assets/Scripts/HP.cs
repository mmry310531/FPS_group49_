using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public float hpnow;
    public float hpmax = 100;
    public Image hpimage;
    // Start is called before the first frame update
    void Start()
    {
        hpnow = hpmax;
    }

    // Update is called once per frame
    void Update()
    {
        if (hpnow <= 0) {
            Destroy(this.gameObject);
        }
        hpimage.fillAmount = hpnow / hpmax;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            hpnow -= 40;
        } // if

        if (collision.gameObject.tag == "Bullet")
        {
            hpnow -= 20;
        } // if
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            hpnow -= 20;
        } // if

    }

}
