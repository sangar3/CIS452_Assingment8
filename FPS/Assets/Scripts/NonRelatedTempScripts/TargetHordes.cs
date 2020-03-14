using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TargetHordes : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 100;
    public Text HealthText;
    public int Damage = 5;
    
    void Start()
    {

        currentHealth = maxHealth;


        HealthText.text = currentHealth.ToString();
    }
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {

            Die();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            currentHealth--;
            Debug.Log("touch player");
            currentHealth -= Damage;
            Debug.Log(currentHealth);
            HealthText.text = currentHealth.ToString();
        }

    }
    void Die()
    {
        
        Destroy(gameObject);
        

    }


    void Update()
    {
        if (currentHealth == 0)
        {
            Debug.Log("GameOver");
        }
    }
}
