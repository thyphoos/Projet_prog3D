using UnityEditor;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce;
    public GameObject impactEffect;

    public Camera FpsCam;
    public ParticleSystem muzzleFlash;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(FpsCam.transform.position, FpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "cible(Clone)")
            {
                GameObject.Find("cible(Clone)").GetComponent<cibleBehavior>().gethit = true;
            }

            target Target = hit.transform.GetComponent<target>();
            if (Target != null)
            {
                Target.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
}
