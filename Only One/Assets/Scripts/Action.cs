using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionClass
{
    Elemental,
    Weapon,
    Magic,
    Consumable
}

public enum ActionType
{
    Attack,
    Defense
}

[CreateAssetMenu(menuName = "Action")]
public class Action : ScriptableObject
{
    public KeyCode Key;
    public ActionClass ActionClass;
    public ActionType ActionType;
    public string Name;
    public string Slogan;
    public Sprite Sprite;

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
