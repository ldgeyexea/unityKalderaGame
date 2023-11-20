using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMenager : MonoBehaviour
{
    GameObject currentDoor;
    private bool doorIsOpen = false;
    private float doorTimer = 0;
    public float doorOpenTime = 3;
    public AudioClip doorOpenSound, doorShutSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void DoorCheck()
    {
        if (!doorIsOpen)
        {
            door(doorOpenSound, true, "dooropen");
        }
        else if(doorIsOpen)
        {
            door(doorShutSound, false, "doorshut");
        }
    }

    void door(AudioClip sound, bool dOpen, string animName)
    {
        GameObject door = gameObject;
        doorIsOpen = dOpen;
        door.GetComponent<AudioSource>().PlayOneShot(sound);
        door.transform.parent.GetComponent<Animation>().Play(animName);
    }
}



//void OnControllerColliderHit(ControllerColliderHit hit)
//{


//    if (hit.gameObject.tag=="playerDoor"&&this.doorIsOpen==false)
//    {
//        currentDoor = hit.gameObject;
//        Debug.Log("zderzenie");
//        door(currentDoor, doorOpenSound, true, "dooropen");

//    }

//}