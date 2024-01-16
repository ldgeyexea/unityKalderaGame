using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision theObject)
    {
        Debug.Log("hit by smth of a name:"+theObject.gameObject.name);
        if(theObject.gameObject.name == "Coconut(Clone)") {
            Debug.Log("hit by coconut!");
            GetComponent<Animator>().SetTrigger("hit");
        }
        
        if (theObject.gameObject.tag == "Player")
        {
            Debug.Log("wilk zabija cie ³aaaa");
        }
    }

}
