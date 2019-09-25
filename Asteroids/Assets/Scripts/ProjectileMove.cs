using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public float speed; //Determine projectile speed
    public float fireRate; //Determine the rate of fire
    public GameObject muzzlePrefab;
    public GameObject hitPrefab;
    public float lifetime;
    void Start()
    {
        if (muzzlePrefab != null){
            var muzzelVFX = Instantiate (muzzlePrefab, transform.position, Quaternion.identity);
            muzzelVFX.transform.forward = gameObject.transform.forward;
            var psMuzzle = muzzelVFX.GetComponent<ParticleSystem> ();
            if (psMuzzle != null)
                Destroy (muzzelVFX, psMuzzle.main.duration);
        else {
            var psChild = muzzelVFX.transform.GetChild(0).GetComponent<ParticleSystem> ();
            Destroy (muzzelVFX, psChild.main.duration);
        }

        }
        Destroy (gameObject, lifetime);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (speed != 0){
            transform.position += transform.forward * (speed * Time.deltaTime);
        }else{
            Debug.Log("Projectile has no speed.");
        }

    }

    void OnCollisionEnter(Collision co) {
        speed = 0;

        ContactPoint contact = co.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;


        if (hitPrefab != null){
            var hitVFX = Instantiate (hitPrefab, pos, rot);
            var psHit = hitVFX.GetComponent<ParticleSystem> ();
            if (psHit != null)
                Destroy (hitVFX, psHit.main.duration);
            else {
                var psChild = hitVFX.transform.GetChild(0).GetComponent<ParticleSystem> ();
                Destroy (hitVFX, psChild.main.duration);
            }
        }
        Destroy (gameObject);

    }


}
