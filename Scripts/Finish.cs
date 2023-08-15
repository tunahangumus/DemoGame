using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public GameObject timer;
    public GameObject assault;
    public GameObject gameoverscene;
    public GameObject timescene;
    public Text currenttime;
    public Text lasttime;
    public string score;
    bool next_level;
    public float mytime;
    void Start()
    {
        mytime = 0;
        timer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (next_level)
        {
            if(assault.GetComponent<Silah>().ammo == 0)
            {
                gameoverscene.SetActive(true);
                lasttime.text = score;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        mytime = Time.time;
        score = currenttime.text;
        next_level = true;
        timer.SetActive(false);
        timescene.SetActive(false);
    }
}
