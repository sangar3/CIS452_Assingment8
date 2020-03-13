using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGlock : PickupSuperClass
{
    public GameObject arrowMarker;
    public GameObject Quest3;
    public GameObject Quest4;


    public override void DestroyObject()
    {
        Destroy(gameObject);
        arrowMarker.SetActive(false);
        Debug.Log("Quest 3 complete");
        Quest3.SetActive(false);
        Quest4.SetActive(true);

    }

    public override void PlaySoundFX()
    {

    }
    public override void ShowText()
    {

    }
    
}
