using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public float force;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Character")
        {
            if (collision.transform.position.x - transform.position.x > 0)
            {
                collision.rigidbody.AddForce(Vector3.right * force);
            }
            else
            {
                collision.rigidbody.AddForce(Vector3.left * force);
            }
        }
    }
}
