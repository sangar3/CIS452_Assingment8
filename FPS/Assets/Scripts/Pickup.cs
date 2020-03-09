using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject pickedupgun;
    public GameObject oldgun1;
    public GameObject oldgun2;
    public GameObject oldgun3;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("trigger");
            
            oldgun1.SetActive(false);
            oldgun2.SetActive(false);
            oldgun3.SetActive(false);
            Debug.Log("picked up AK-47");
            pickedupgun.SetActive(true);
            
            Destroy(gameObject);
        }

    }
}
