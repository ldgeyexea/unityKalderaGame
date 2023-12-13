using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class TargetCollision : MonoBehaviour
{

    bool beenHit = false;
    Animation targetRoot;
    public AudioClip hitSound;
    public AudioClip resetSound;
    public float resetTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        targetRoot = transform.parent.transform.parent.GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("nazwa:"+collision.gameObject.name);
        Debug.Log("czy dobra nazwa:"+(collision.gameObject.name == "Coconut(Clone)"));
        Debug.Log("czy nietrafione:"+(beenHit == false));
        Debug.Log("zlozenie:"+(beenHit == false && collision.gameObject.name == "Coconut(clone)"));
        if (beenHit == false )//colision.gameObject.name=="Coconut" nie dziala bo  niewiem co 
        {
            Debug.Log( "right colision");
            StartCoroutine("targetHit");
        }
    }
    IEnumerator targetHit()
    {
        GetComponent<AudioSource>().PlayOneShot(hitSound);
        targetRoot.Play("down");
        beenHit = true;
        CoconutWin.targets++;
        yield return new WaitForSeconds(resetTime);
        GetComponent<AudioSource>().PlayOneShot(resetSound);
        targetRoot.Play("up");
        beenHit = false;
        CoconutWin.targets--;
    }
}
