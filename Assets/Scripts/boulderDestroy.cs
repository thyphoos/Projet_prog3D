using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulderDestroy : MonoBehaviour
{
    public PlayerLife boulderDamage = new PlayerLife();

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("boulderActivator").GetComponent<boulderTrap>().trigger == true)
        {
            StartCoroutine(Destroy3seconds());
        }
    }
    
    private void OnTriggerEnter(Collider other)
    { 
        boulderDamage.TakeDamage(50);
    }

    private IEnumerator Destroy3seconds()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
