using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructable : MonoBehaviour
{
    public GameObject destroyedversion;

    void OnMouseDown ()
    {
        Instantiate(destroyedversion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
