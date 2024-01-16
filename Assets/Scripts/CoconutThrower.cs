using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class CoconutThrower : MonoBehaviour
{
    public Rigidbody Coconut;
    public AudioClip throwSound;
    public float throwSpeed = 20.0f;
    public static bool canThrow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")/*&&canThrow*/)
        {
     

                GetComponent<AudioSource>().PlayOneShot(throwSound);
                Rigidbody newCoconut = Instantiate(Coconut, gameObject.transform.position, gameObject.transform.rotation) as Rigidbody;
                newCoconut.velocity = transform.forward * throwSpeed;
                //Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newCoconut.GetComponent<Collider>(), true);
  
            
        }
    }
}
