using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider theObject)
    {
      
        Debug.Log("wilk  moze zabija cie �aaaa");
        if (theObject.gameObject.tag == "Player")
        {
            Debug.Log("wilk zabija cie �aaaa");
            SceneManager.LoadScene("SampleScene");
        }
    }

}
