using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{

    [SerializeField] WheelIconController[] wheelIcons;

    private bool mActive = false;

    // Start is called before the first frame update
    void Start()
    {
        setActive(mActive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setActive(bool active)
    {
        mActive = active;
        this.transform.gameObject.SetActive(mActive);

        if(!active)
        {
            setWheelIconsActive(false);
        }
    }

    public ActionGroup getActionGroup(KeyCode key)
    {
        setWheelIconsActive(false);

        foreach (WheelIconController wheelIcon in wheelIcons)
        {
            wheelIcon.setActive(false);

            if (wheelIcon.actionGroup.Key == key)
            {
                wheelIcon.setActive(true);
                return wheelIcon.actionGroup;
            }
        }
        return null;
    }

    private void setWheelIconsActive(bool active)
    {
        foreach (WheelIconController wheelIcon in wheelIcons)
        {
            wheelIcon.setActive(active);
        }
    }
}
