using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadWire : MonoBehaviour
{
    public bool inReach;
    public GameObject[] Timers;

    void Start()
    {
        inReach = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;


        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;


        }
    }




    void Update()
    {
        Timers = GameObject.FindGameObjectsWithTag("timer");

        if (Input.GetButtonDown("Interact") && inReach)
        {
            for (int i = 0; i < Timers.Length; i++)
            {
                Timers[i].GetComponent<Timer>().downTime();
            }
            gameObject.SetActive(false);
        }


    }
}
