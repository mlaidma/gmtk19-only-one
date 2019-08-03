
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Fighter
{

    [SerializeField] PlayerController player;
    [SerializeField] ActionGroup[] actionGroups;

    private Action activeAction;
    
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
            QueueAction();
            yield return new WaitForSeconds(2f);
            player.TakeDamage(activeAction);
        }
    }

    private void QueueAction()
    {
        ActionGroup ag = actionGroups[Random.Range(0, actionGroups.Length)];
        Action[] actions = ag.Actions;
        activeAction = actions[Random.Range(0, actions.Length)];

        Debug.Log(Name + " picked " + activeAction.Name + " as next attack!");
    }
}

