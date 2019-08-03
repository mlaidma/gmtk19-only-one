using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IDamageable
{
    [SerializeField] WheelController actionWheel;
    [SerializeField] EnemyController enemy;

    private bool mShiftPressed = false;
    private ActionGroup mActiveActionGroup;
    private Traits traits;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageInput();
    }

    void ManageInput()
    {

        KeyCode keyPressed = KeyCode.None;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            actionWheel.setActive(true);
            mShiftPressed = true;
        }
  
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            actionWheel.setActive(false);
            mShiftPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            keyPressed = KeyCode.W;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            keyPressed = KeyCode.A;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            keyPressed = KeyCode.S;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            keyPressed = KeyCode.D;
        }

        if(keyPressed != KeyCode.None)
        {
            if(mShiftPressed)
            {
                mActiveActionGroup = actionWheel.getActionGroup(keyPressed);
                Debug.Log("New active action group: " + mActiveActionGroup);
            }
            else
            {
                Action(keyPressed);
            }
        }
    }

    void Action(KeyCode key)
    {
        if (mActiveActionGroup != null)
        {
            foreach (Action action in mActiveActionGroup.Actions)
            {
                if(key == action.Key)
                {
                    Debug.Log("Player used " + action.Name);
                    enemy.TakeDamage(action);
                }
            }
        }
        else
        {
            Debug.LogError("No active actiongroup");
        }
    }

    public void TakeDamage(Action action)
    {
        Debug.Log("Player took damage from " + action.Name);
    }
}
