using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowZone : MonoBehaviour
{

    public RawImage crosshair;
    // Start is called before the first frame update
    void Start()
    {
        crosshair.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            CoconutThrower.canThrow = true;
            crosshair.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CoconutThrower.canThrow = false;
            crosshair.enabled = false;
        }
    }
}
