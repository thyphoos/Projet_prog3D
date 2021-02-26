using UnityEngine;

public class target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Vector3 position= transform.position+new Vector3(0,1.5f,0);
            Die();
            if (GameObject.Find("player first person").GetComponent<playerMovement>().cptsquelette == 6)
            {
                float a = Random.Range(0, 360);
                float b = Random.Range(0, 360);
                float c = Random.Range(0, 360);
                
                Instantiate(Resources.Load("key"), position, Quaternion.Euler(a,b,c));
                
            }
        }
    }

    void Die()
    {
        GameObject.Find("player first person").GetComponent<playerMovement>().cptsquelette += 1;
        Destroy(gameObject);
    }

}
