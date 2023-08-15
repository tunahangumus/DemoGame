using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class silah2 : MonoBehaviour
{
    public int ammo;
    public GameObject bullet;
    public GameObject bulletspawnpoint;
    public Text remainingammo;
    void Start()
    {
        ammo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && ammo > 0)
        {
            ammo--;
            Instantiate(bullet, bulletspawnpoint.transform.position, bulletspawnpoint.transform.rotation);
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.transform.gameObject.GetComponent<ShootingRangeMove>())
            {
                hit.transform.gameObject.GetComponent<ShootingRangeMove>().speed += 2;
            }

        }
    }
}