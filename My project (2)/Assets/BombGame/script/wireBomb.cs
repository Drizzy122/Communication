using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class wireBomb : MonoBehaviour
{
    public float wireCut;

    public GameObject keypadBomb;
    public Animator ANI;

    public void Update()
    {
        if (wireCut >= 3) 
        {
            ANI.SetBool("animate", true);
            keypadBomb.GetComponent<OpenKeyPad>().wireDefused = true;
        }
    }
}
