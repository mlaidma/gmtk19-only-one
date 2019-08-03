using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Fighter
{

    [SerializeField] PlayerController player;

    [SerializeField] Action fire;
    

    // Start is called before the first frame update
    void Start()
    {
        Name = "Enemy";
        StartCoroutine(DealDamage());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DealDamage()
    {
        while (true)
        {
            player.TakeDamage(fire);
            yield return new WaitForSeconds(2f);
        }
    }

}

