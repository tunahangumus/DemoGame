using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject edge;
    public float RotSpeed;
    bool goright;
    // Start is called before the first frame update
    void Start()
    {
        goright = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (goright)
        {
            transform.RotateAround(edge.transform.position, Vector3.forward, RotSpeed * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(edge.transform.position, Vector3.back, RotSpeed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "left")
        {
            goright = true;
        }
        if (other.transform.name == "Right")
        {
            goright = false;
        }
    }
}
