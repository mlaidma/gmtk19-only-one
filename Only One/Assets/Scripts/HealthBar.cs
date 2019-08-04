using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Image healthbar;

    private const float minHealth = 0f;
    private const float maxHealth = 100f;

    private float currentHealth = 100f;
    private float currentHealthPercent = 100f;

    public void updateHealth(float health)
    {
        if(health != currentHealth)
        {
            currentHealth = health;
            currentHealthPercent = currentHealth / maxHealth;

            healthbar.fillAmount = currentHealthPercent;
        }
    }
}
