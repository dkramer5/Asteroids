using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Continue tutorial on damage here:
// https://www.youtube.com/watch?v=THnivyG0Mvo
//
// Need to implement projectile damage from "missile"
public class TargetHealth : MonoBehaviour
{
    public float initialHealth = 100f;
    public ParticleSystem deathParticleEffect;
    public float damagedThreshold;
    public ParticleSystem damagedParticleEffect;
    public void TakeDamage (float ammount)
    {
        initialHealth -= ammount;
        if (initialHealth <= damagedThreshold)
        {
            Instantiate (damagedParticleEffect, transform.position, transform.rotation);
        }
        if (initialHealth <= 0f)
        {
            die();
        }
    }
    void die()
    {
        Instantiate (deathParticleEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    //Example on how to cleanup easily with destroy
    //GameObject explosioneffects = Instantiate (ParticleS , Transform.position, Transform.rotation);
    //Destroy (explosioneffects, 2f);

}
