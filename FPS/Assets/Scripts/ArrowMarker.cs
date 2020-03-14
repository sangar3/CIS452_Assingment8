using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMarker : MonoBehaviour
{
    public GameObject arrowMarker;
    public GameObject Quest1;
    public GameObject Quest2;
    public GameObject Quest3;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Quest 1 complete");



            arrowMarker.SetActive(false);
            Quest1.SetActive(false);
            Quest2.SetActive(true);
            Quest3.SetActive(true);

        }

    }
}
