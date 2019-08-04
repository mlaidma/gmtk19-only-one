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
    [SerializeField] Fighter target;

    protected FighterStats stats;
    [SerializeField] ActionVisualizer actionVisualizer;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void TakeDamage(Action action)
    {
        float damageTakenModifier = stats.GetDamageTakenModifier(action);
        float damageTaken = action.GetDamageTaken(damageTakenModifier);

        float newHealth = Mathf.Clamp(health - damageTaken, 0f, 100f);

        health = newHealth;

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

    public void Act(Action _action)
    {
        VisualizeAction(_action);

        if (_action.ActionType == ActionType.Attack)
        {
            float damageDealtModifier = stats.GetDamageDealtModifier(_action);
            _action.SetDamageDealt(damageDealtModifier);

            target.TakeDamage(_action);
        }
        else //ActionType.Defense
        {   
            //TODO: Refactor naming
            //Bad function naming generates confusion, this is actually healing itself,
            //not attacking the enemy.
            float healthGainedModifier = stats.GetDamageDealtModifier(_action);
            _action.SetDamageDealt(healthGainedModifier);

            this.TakeDamage(_action);
        }
    }

    private void VisualizeAction(Action _action)
    {
        Debug.Log(Name + " used " + _action.Name);
        attackText.text = _action.Slogan;
        if(actionVisualizer != null)
        {
            actionVisualizer.SetSprite(_action.Sprite);
        }
        else
        {
            Debug.LogError(Name + " has no actionVisualizer");
        }
    }
}
