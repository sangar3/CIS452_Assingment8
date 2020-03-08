using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject pickedupgun;
    public GameObject oldgun;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("trigger");
            pickedupgun.SetActive(true);
            Debug.Log("picked up AK");
            oldgun.SetActive(false);
            Destroy(gameObject);
        }

    }
}
