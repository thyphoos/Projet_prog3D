using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth((maxHealth));
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            StartCoroutine(changeScene());
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    
    private IEnumerator changeScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("SceneLoose");
        while (!operation.isDone)
        {
            yield return null;
        }
    }
}


