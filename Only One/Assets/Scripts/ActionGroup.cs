using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ActionGroup")]
public class ActionGroup : ScriptableObject
{
    public ActionClass type;
    public KeyCode Key;
    public Action[] Actions;

    public Sprite inactiveSprite;
    public Sprite activeSprite;
}
