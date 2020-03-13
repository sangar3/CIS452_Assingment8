using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerUI : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 100;
    public Text HealthText;

    void Start()
    {

        currentHealth = maxHealth;


        HealthText.text = currentHealth.ToString();
    }


}
