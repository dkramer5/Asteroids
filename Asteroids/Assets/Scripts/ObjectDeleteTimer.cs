using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDeleteTimer : MonoBehaviour
{
    public float voidTimer;
    // Start is called before the first frame update
    void Start()
    {
        Destroy (gameObject, voidTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
