using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHints : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text guiText = GetComponent<Text>();
        if (guiText.enabled)
        {
            timer += Time.deltaTime;
            if (timer > 4.0f)
            {
                guiText.enabled = false;
                timer = 0.0f;
            }
        }
        
    }
    void ShowHint(string message)
    {
        Text guiText = GetComponent<Text>();
        guiText.text = message;
        if(!guiText.enabled)
        {
            guiText.enabled = true;
        }
    }
}
