using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] WheelController actionWheel;

    private bool mShiftPressed = false;
    private ActionGroup mActionGroup;

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
                mActionGroup = actionWheel.getActionGroup(keyPressed);
            }
            else
            {
                
            }
        }
    }
}
