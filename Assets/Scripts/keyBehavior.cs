using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(2, 5, 2);

    }

    private void OnTriggerEnter(Collider collision)
    {
        GameObject.Find("player first person").GetComponent<playerMovement>().cptkey += 1;
        Destroy(this.gameObject);
    }
}