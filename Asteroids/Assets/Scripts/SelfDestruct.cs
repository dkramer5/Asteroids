using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float lifetime;
    public bool voidEffects;
    public GameObject voidParticleEffect;

    float effecttimer;
    bool effectcomplete = false;


    // Start is called before the first frame update
    void Start()
    {
        effecttimer = lifetime - 1;
        Destroy(gameObject, lifetime);
    }
    // Update is called once per frame
    void Update()
    {  

        if (voidEffects && !effectcomplete)
        {
            if (effecttimer <= .1f)
            {
                Instantiate (voidParticleEffect, transform.position, transform.rotation);
                effectcomplete = true;
            }else{
                effecttimer = (effecttimer - Time.deltaTime);
            }
        }
    }
}
