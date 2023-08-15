using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 SpawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -4.5)
        {
            transform.position = SpawnPosition;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("red"))
        {
            transform.position = SpawnPosition;
        }
    }
}
