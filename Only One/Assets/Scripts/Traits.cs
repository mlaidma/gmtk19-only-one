using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Traits")]
public class Traits : ScriptableObject
{
    public float Health;

    public float WeaponDamage;
    public float MagicDamage;
    public float ElementalDamage;

    public float WeaponResist;
    public float MagicResist;
    public float ElementalResist;


}
