/*
		 * (Santiago Garcia II)
		 * (PickupAK.cs)
		 * (Assignment)
		 * (The concrete class of the main superclass)
	*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAK : PickupSuperClass
{
    public GameObject arrowMarker;
    public AudioClip akpickupfx;


    public override void DestroyObject()
    {
        Destroy(gameObject);
        arrowMarker.SetActive(false);
        Debug.Log("Quest 3 complete");
       

    }

    public override void PlaySoundFX()
    {
        AudioManager.Instance.PlaySFX(akpickupfx, 3.0f);
    }
    public override void ShowText()
    {

    }
}
