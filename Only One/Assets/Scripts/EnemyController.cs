
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Fighter
{
   
    [SerializeField] ActionGroup[] actionGroups;
    
    private Action activeAction;
    
    // Start is called before the first frame update
    void Start()
    {
        Name = "Enemy";

        stats = new FighterStats();
        stats.DrawStats();

        StartCoroutine(DoAction());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DoAction()
    {
        while (true)
        {
            QueueAction();
            yield return new WaitForSeconds(2f + Random.Range(-1f, 1f));
            float damageDealtModifier = stats.GetDamageDealtModifier(activeAction);
            activeAction.SetDamageDealt(damageDealtModifier);
            Act(activeAction);
        }
    }

    private void QueueAction()
    {
        ActionGroup ag = actionGroups[Random.Range(0, actionGroups.Length)];
        Action[] actions = ag.Actions;
        activeAction = actions[Random.Range(0, actions.Length)];

        attackText.text = activeAction.Slogan;
        Debug.Log(Name + " picked " + activeAction.Name + " as next attack!");
    }
}

