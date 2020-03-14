/*
		 * (Santiago Garcia II)
		 * (PickupSuperClass.cs)
		 * (Assignment)
		 * (The main abstract superclass to define the temp method)
	*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupSuperClass : MonoBehaviour
{
    public GameObject pickedupgun;
    public GameObject oldgun;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PickupGun();
        }

    }


   public void PickupGun() //tempmethod
    {
        Debug.Log("trigger");

        oldgun.SetActive(false);


        Debug.Log("picked up gun");
        pickedupgun.SetActive(true);
        DestroyObject();
        PlaySoundFX();
        ShowText();



    }

    public abstract void PlaySoundFX();

    public abstract void ShowText();


    public abstract void DestroyObject();
    





}
