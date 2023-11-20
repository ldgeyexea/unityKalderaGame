using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    public AudioClip lockedSound;
    public Light[] doorLight;
    public Text textHints;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Inventory.charge >= 4)
            {
                transform.Find("door").SendMessage("DoorCheck");
                if(GameObject.Find("PowerGUI")){
                    Destroy(GameObject.Find("PowerGUI"));
                    foreach(Light light in doorLight)
                    {
                        light.color = Color.green;
                    }
                }
            }
            else if(Inventory.charge>0 && Inventory.charge<4)
            {
                textHints.SendMessage("ShowHint", "Drzwi ani drgn¹ … \n pewnie potrzebuj¹ wiêcej mocy...");
                transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
              
            }
            else
            {
                textHints.SendMessage("ShowHint", "Te drzwi wygl¹daj¹ na zamkniête, \n byæ mo¿e generator wymaga  odpowiedniego zasilania...");
                transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                col.gameObject.SendMessage("HUDon");
            }

        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Inventory.charge >= 4)
            {
                transform.Find("door").SendMessage("DoorCheck");
            }
        }
    }


}
