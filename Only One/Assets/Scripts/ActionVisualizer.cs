using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionVisualizer : MonoBehaviour
{

    SpriteRenderer spriteRenderer;

    private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (sprite != null && !Input.GetKey(KeyCode.LeftShift))
        {
            spriteRenderer.sprite = sprite;
        }
        else
        {
            spriteRenderer.sprite = null;
            Debug.LogWarning("Can't Visualize attack!");
        }
    }

    public void SetSprite(Sprite _sprite)
    {
        sprite = _sprite;
    }

    public void Reset()
    {
        if(spriteRenderer != null)
        {
            spriteRenderer.sprite = null;
        }
    }
}
