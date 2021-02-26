using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasers : MonoBehaviour
{
    public PlayerLife laserDamage = new PlayerLife();

    private void OnTriggerEnter(Collider other)
    {
        laserDamage.TakeDamage(10);
    }
}

