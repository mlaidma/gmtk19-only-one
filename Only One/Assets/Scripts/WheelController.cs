using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] ActionGroup[] actionGroups;

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
    }

    public ActionGroup getActionGroup(KeyCode key)
    {
        foreach (ActionGroup actionGroup in actionGroups)
        {
            if (actionGroup.Key == key) return actionGroup;
        }
        return null;
    }
}
