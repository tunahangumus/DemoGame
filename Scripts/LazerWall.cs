using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerWall : MonoBehaviour
{
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, 3f))
        {
            if ("Character" == hit.transform.name)
            {
                character.GetComponent<Silah>().ammo+=6;
                enabled = false;
            }
        }

    }
}
