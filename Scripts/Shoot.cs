using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    float controltime;
    public GameObject ball;
    public GameObject spawnpoint;
    void Start()
    {
        controltime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - controltime > 0.6)
        {
            controltime = Time.time;
            Instantiate(ball,spawnpoint.transform.position,spawnpoint.transform.rotation);
        }
    }
}
