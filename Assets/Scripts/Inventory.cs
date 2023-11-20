using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private bool haveMatches = false;
    public RawImage matchHudGUI;
    public Text textHints;
    private bool campfireStarted = false;

    public static int charge = 0;
    public AudioClip collectSound;
    //HuD
    public Texture2D[] hudCharge;
    public RawImage hudChargeGui;
    public Texture2D[] chargeMeter;
    public Renderer meter;


    // Start is called before the first frame update
    void Start()
    {
        charge = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CellPickup()
    {
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        charge++;
        hudChargeGui.texture = hudCharge[charge];
        meter.material.mainTexture = chargeMeter[charge];
        HUDon();
    }

    void HUDon()
    {
        //Debug.Log("hudon");
        if (!hudChargeGui.enabled)
        {
            hudChargeGui.enabled = true;
        }
    }

    void MatchPickup()
    {
        haveMatches = true;
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        matchHudGUI.enabled = true;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.name=="campfire")
        {
            if (haveMatches)
            {
                LightFire(hit.gameObject);
            }
            else if (!campfireStarted)
            {
                textHints.SendMessage("ShowHint", "Móg³bym rozpalic ognisko do wezwania pomocy.\nTylko czym....");
            }

        }
    }

    private void LightFire(GameObject campfire)
    {
        ParticleSystem[] fireEmitters;
        fireEmitters = campfire.GetComponentsInChildren<ParticleSystem>();
        foreach(ParticleSystem emitter in fireEmitters)
        {
            emitter.Play();
        }
        campfireStarted = true;
        campfire.GetComponent<AudioSource>().Play();
        matchHudGUI.enabled = false;
        haveMatches = false;

    }
}
