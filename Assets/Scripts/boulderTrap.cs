using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulderTrap : MonoBehaviour
{
    [SerializeField] private Animator BoulderAnimation;
    public bool trigger = false;

    private void OnTriggerEnter(Collider other)
    {
        BoulderAnimation.SetBool("New Bool", true);
        trigger = true;
        StartCoroutine(Destroy3seconds());
    }
    
    private IEnumerator Destroy3seconds()
    {
        yield return new WaitForSeconds(3.1f);
        Destroy(gameObject);
    }
}

