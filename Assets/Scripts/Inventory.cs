using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
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
}
