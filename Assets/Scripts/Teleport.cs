using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportArea;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.Find("player first person").GetComponent<playerMovement>().cptkey == 3)
        player.transform.position = teleportArea.transform.position;
    }
}
