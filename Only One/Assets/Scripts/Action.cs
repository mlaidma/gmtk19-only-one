using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionType
{
    Elemental,
    Weapon,
    Magic,
    Consumable
}

[CreateAssetMenu(menuName = "Action")]
public class Action : ScriptableObject
{
    public KeyCode Key;
    public ActionType Type;
    public string Name;
    public string Slogan;

    [SerializeField] float baseDamage;

    private float damage;
    
    public Action() => baseDamage = 10f;

    public float GetDamageTaken(float modifier)
    {
        return damage / modifier;
    }

    public void SetDamageDealt(float modifier)
    {
        damage = baseDamage * modifier;
    }
}
