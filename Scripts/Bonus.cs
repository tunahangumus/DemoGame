using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    public GameObject shootingrange;
    public float myspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myspeed = shootingrange.GetComponent<ShootingRangeMove>().speed-2;
        if (myspeed == 0)
        {
            gameObject.GetComponent<Text>().text = "00 : 00";
        }
        else 
        {
            gameObject.GetComponent<Text>().text = string.Format("00 : {0:00}", (myspeed * 1.5f));
        }
    }
}
