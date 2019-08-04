using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelIconController : MonoBehaviour
{
    [SerializeField] public ActionGroup actionGroup;

    SpriteRenderer spriteRenderer;

    private void Awake()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void setActive(bool _active)
    {
        if (_active) spriteRenderer.sprite = actionGroup.activeSprite;
        else spriteRenderer.sprite = actionGroup.inactiveSprite;
    }
    

}
