/*
		 * (Santiago Garcia II)
		 * (PickupGlock.cs)
		 * (Assignment)
		 * (The concrete class of the main superclass)
	*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGlock : PickupSuperClass
{
    public GameObject arrowMarker;
    public GameObject Quest3;
    public GameObject Quest4;
    public AudioClip glockpickupfx;

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
        AudioManager.Instance.PlaySFX(glockpickupfx, 3.0f);
    }
    public override void ShowText()
    {

    }
    
}
