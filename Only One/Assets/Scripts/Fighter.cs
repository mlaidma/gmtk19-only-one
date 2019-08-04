using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fighter : MonoBehaviour
{
     public float health
    {
        get
        {
            return stats.health;
        }
        set
        {
            stats.health = value;
        }
    }
    
    virtual protected string Name { get; set; }

    [SerializeField] HealthBar healthbar;
    [SerializeField] protected TextMeshProUGUI attackText;

    protected FighterStats stats;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void TakeDamage(Action action)
    {
        float damageTakenModifier = stats.GetDamageTakenModifier(action);
        float damageTaken = action.GetDamageTaken(damageTakenModifier);

        health -= damageTaken;

        Debug.Log(Name + " took damage " + damageTaken + " from " + action.Name);
        Debug.Log(Name + "health now: " + health);

        healthbar.updateHealth(health);

        if (health <= 0)
        {
            Debug.Log("Game over!");
            PlayerPrefs.SetString("loser", Name);
            FindObjectOfType<GameController>().LoadEndScene();
        }
    }

}
