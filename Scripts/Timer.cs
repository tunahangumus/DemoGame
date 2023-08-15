using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    public float mytime;
    // Start is called before the first frame update
    void Start()
    {
        mytime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        mytime += Time.deltaTime;
        float minutes = Mathf.FloorToInt(mytime / 60);
        float seconds = Mathf.FloorToInt(mytime % 60);
        timer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
