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
        player.transform.position = teleportArea.transform.position;
    }
}
