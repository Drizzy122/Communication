using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodWire : MonoBehaviour
{
    public bool inReach;

    private GameObject wireBomb;

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
        wireBomb = GameObject.FindWithTag("wireBomb");

        if (Input.GetButtonDown("Interact") && inReach)
        {
            wireBomb.GetComponent<wireBomb>().wireCut += 1;
            gameObject.SetActive(false);
        }


    }
}
