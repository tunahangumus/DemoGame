using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public float speed;
    public float rotspeed;
    float horizontal;
    public float jumpspeed;
    float vertical;
    bool isgrounded;
    Animator anim; 
    // Start is called before the first frame update
    void Start()
    {
        isgrounded = true;
    }

    // Update is called once per frame
    void Update()
    {   anim=GetComponent<Animator>();
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3 (horizontal, 0, vertical);
        transform.Translate(direction*Time.deltaTime*speed,Space.World);
        if(direction != Vector3.zero)
        {
            anim.SetBool("Run", true);
            Quaternion Rotate = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Rotate, rotspeed*Time.deltaTime);
        }
        else
        {
            anim.SetBool("Run", false);
        }
        if (isgrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
            anim.SetTrigger("New Trigger");
        }
        else
        {
            anim.SetBool("Jump", false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isgrounded = true;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isgrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isgrounded = false;
        }
    }
}
