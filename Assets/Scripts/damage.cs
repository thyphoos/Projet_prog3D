using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public PlayerLife TrapDamage = new PlayerLife();
    private void OnTriggerEnter(Collider other)
    {
        TrapDamage.TakeDamage(25);
    }
}
