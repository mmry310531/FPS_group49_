using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxController : MonoBehaviour
{
    int random_step;
    int now_step;
    int direction;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        direction = UnityEngine.Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(0, direction, 0);
        now_step = 0;
        speed = 2.0f;
        random_step = UnityEngine.Random.Range(20, 40);
    }

    // Update is called once per frame
    void Update()
    {
        if (now_step == random_step) {
            direction = UnityEngine.Random.Range(0, 360);
            random_step = UnityEngine.Random.Range(20, 4);
            now_step = 0;
        } // if
        
        transform.rotation = Quaternion.Euler(0, direction, 0);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        now_step++;
    }
}
