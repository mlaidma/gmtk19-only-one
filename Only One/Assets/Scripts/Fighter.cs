using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    private float health = 100f;
    
    virtual protected string Name { get; set; }

    [SerializeField] HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void TakeDamage(Action action)
    {
        health -= action.damage;
        Debug.Log(Name + " took damage " + action.damage + " from " + action.Name);
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
