using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class total : MonoBehaviour
{
    public GameObject currtime;
    public GameObject speed;
    float totaltime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = (float)(currtime.GetComponent<Timer>().mytime - (speed.GetComponent<Bonus>().myspeed * 1.5));
        totaltime = v;
        gameObject.GetComponent<Text>().text = string.Format("{0:00} : {1:00}", Mathf.FloorToInt(totaltime / 60),Mathf.FloorToInt(totaltime % 60));

    }
}
