using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptHealthManager : MonoBehaviour
{
    public Image healthBar;

    public int maxHealth = 25;

    public float healthAmount = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        */
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamage(20);
        }

        /*
        if (Input.GetKeyDown(KeyCode.Space)) {
            Heal(5);
        }
        */
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100;
    }

    public void UpdateHealthBar(int currentHealth)
    {
        healthBar.fillAmount = (float)currentHealth / maxHealth;
    }

    /*
        public void Heal(float healingAmount)
        {
            healthAmount += healingAmount;
            healthAmount = Mathf.Clamp(healthAmount, 0, 100);
            healthBar.fillAmount = healthAmount / 100f;
        }
    */

}
