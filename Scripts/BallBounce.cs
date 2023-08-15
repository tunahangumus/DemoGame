using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    Vector3 distance;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        distance = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        collision.rigidbody.AddForce(Vector3.up * force);
    }
    
}
