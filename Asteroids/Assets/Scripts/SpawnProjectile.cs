using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public GameObject firepoint;
    public List<GameObject> vfx = new List<GameObject> ();
    public RotateToMouse RotateToMouse;
    private GameObject effectToSpawn;
    private float timeToFire = 0;


    // Start is called before the first frame update
    void Start()
    {
        effectToSpawn = vfx[0];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Determine if the left mouse button is selected (0)
        if(Input.GetMouseButton (0) && Time.time >= timeToFire){
            timeToFire = Time.time + 1 / effectToSpawn.GetComponent<ProjectileMove>().fireRate;
            SpawnVFX ();
        }
        
    }

    void SpawnVFX(){
        GameObject vfx;

        //Determine if the firepoint exists
        if (firepoint != null){
            vfx = Instantiate (effectToSpawn, firepoint.transform.position, Quaternion.identity);
            if (RotateToMouse != null){
                vfx.transform.localRotation = RotateToMouse.GetRotation();
            }
        } else {
        Debug.Log("No Fire Point found");
        }
    }






}
