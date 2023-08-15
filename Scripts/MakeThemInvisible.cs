using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeThemInvisible : MonoBehaviour
{
    public GameObject[] Objects;
    GameObject CurrentObject;
    int RandomIndex;
    float CollideTime;
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (character.transform.position.y < -3)
        {
            foreach(GameObject obj in Objects)
            {
                obj.GetComponentsInChildren<BoxCollider>()[0].enabled = false;
                obj.GetComponentsInChildren<BoxCollider>()[1].enabled = false;
                obj.GetComponentsInChildren<BoxCollider>()[2].enabled = false;
            }
        }
        if(Time.time - CollideTime> 0.65f)
        {
            foreach (GameObject obj in Objects)
            {
                obj.GetComponentsInChildren<MeshRenderer>()[0].enabled = true;
                obj.GetComponentsInChildren<MeshRenderer>()[1].enabled = true;
                obj.GetComponentsInChildren<MeshRenderer>()[2].enabled = true;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Character")
        {
            CollideTime = Time.time;
            for (int i = 0; i < 6; i++)
            {
                RandomIndex = Random.Range(0, 3);
                CurrentObject = Objects[i].transform.GetChild(RandomIndex).gameObject;
                CurrentObject.transform.GetComponent<BoxCollider>().enabled = true;
                CurrentObject.transform.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
