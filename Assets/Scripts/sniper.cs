using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniper : MonoBehaviour
{
    float zoomLevel = 8.0f;
    float zoomInSpeed = 100.0f;
    float zoomOutSpeed = 100.0f;

    private float initFOV;
    public GameObject near;
    public GameObject[] far;
    bool check;
    void Start()
    {
        //獲取當前攝像機的視野範圍 unity預設值60
        initFOV = Camera.main.fieldOfView;
        check = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            check = !check;
        if(check)
        {
            ZoomInView();
            //啟用ui視窗
            far[0].SetActive(true);
            far[1].SetActive(true);
            near.SetActive(false);
        }
        else
        {
            ZoomOutView();
            //失活ui視窗
            far[0].SetActive(false);
            far[1].SetActive(false);
            near.SetActive(true);
        }
    }

    //放大攝像機的視野區域
    void ZoomInView()
    {
        if (Mathf.Abs(Camera.main.fieldOfView - (initFOV / zoomLevel)) < 0f)
        {
            Camera.main.fieldOfView = initFOV / zoomLevel;
        }
        else if (Camera.main.fieldOfView - (Time.deltaTime * zoomInSpeed) >= (initFOV / zoomLevel))
        {
            Camera.main.fieldOfView -= (Time.deltaTime * zoomInSpeed);
        }
    }

    //縮小攝像機的視野區域
    void ZoomOutView()
    {
        if (Mathf.Abs(Camera.main.fieldOfView - initFOV) < 0f)
        {
            Camera.main.fieldOfView = initFOV;
        }
        else if (Camera.main.fieldOfView + (Time.deltaTime * zoomOutSpeed) <= initFOV)
        {
            Camera.main.fieldOfView += (Time.deltaTime * zoomOutSpeed);
        }
    }
}
