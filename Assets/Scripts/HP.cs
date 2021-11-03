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
        // hpnow -= 1;
        hpimage.fillAmount = hpnow / hpmax;
    }
}
