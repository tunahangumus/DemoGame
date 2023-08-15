using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRangeMove : MonoBehaviour
{
    public float speed;
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
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("right"))
        {
            goright = true;
        }
        if (collision.gameObject.CompareTag("left"))
        {
            goright = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            Debug.Log("asdasd");
            speed++;
        }
    }
}
