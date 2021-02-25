using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cibleBehavior : MonoBehaviour


{

    public bool gethit = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gethit == true)
        {
            GameObject.Find("player first person").GetComponent<playerMovement>().isciblepresent = false;
            GameObject.Find("player first person").GetComponent<playerMovement>().cptcible +=1;
            Destroy(gameObject);
        }
    }
}