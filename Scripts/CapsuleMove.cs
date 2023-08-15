using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMove : MonoBehaviour
{
    public float speed;
    public float zaman;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, zaman);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x+90,transform.eulerAngles.y, transform.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name== "Character")
        {
            collision.transform.position = collision.gameObject.GetComponent<Respawn>().SpawnPosition;
        }
    }
}
