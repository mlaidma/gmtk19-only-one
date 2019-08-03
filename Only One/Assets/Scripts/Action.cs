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
}
