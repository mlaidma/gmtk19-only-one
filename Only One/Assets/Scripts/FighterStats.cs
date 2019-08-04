using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterStats
{
    public float health = 100f;
    
    public float GetDamageDealtModifier(Action _action)
    { 
        float randomModifier = Random.Range(1f, 3f);
        return randomModifier;
    }

    public float GetDamageTakenModifier(Action _action)
    {
        float randomModifier = Random.Range(1f, 3f);
        return randomModifier;
    }

    public void DrawStats()
    {
        
    }
}