using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Target : MonoBehaviour
{
    [Header("Stats")]
    public int currentHealth;
    public int maxHealth = 100;
    public Text HealthText;
    public int Damage = 5;
    public int Enemycount; 
    [Header("Fields")]
    public GameObject Quest4;
    public GameObject Quest5;
    public GameObject gun2;
    public bool Quest4Comp = false;
    
    void Start()
    {
        Enemycount = 5;
        currentHealth = maxHealth;


        HealthText.text = currentHealth.ToString();
    }
    public float health = 50f;

    public void TakeDamage(float amount )
    {
        health -= amount;
        if( health <=0f)
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
            currentHealth-= Damage;
            if (currentHealth == 0)
            {
                Debug.Log("GameOver");
                SceneManager.LoadScene("Youwin");

            }
            Debug.Log(currentHealth);
            HealthText.text = currentHealth.ToString();
        }

    }
    void Die()
    {
        Quest4Comp = true;
        Destroy(gameObject);
        if (Quest4Comp == true)
        {
            Debug.Log("Quest 4 Complete");
            Quest4.SetActive(false);
            Quest5.SetActive(true);
            gun2.SetActive(true);
            --Enemycount;
            Debug.Log("enemy count: " + Enemycount);
        }
        --Enemycount;
        if (Enemycount == 0)
        {
            Debug.Log("You Win!");
            SceneManager.LoadScene("Youwin");

        }
        Debug.Log("enemy count: " + Enemycount);
    }


    
}
