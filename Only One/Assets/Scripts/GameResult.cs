using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameResult : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI resultText;

    private void Start()
    {
        resultText.text = "";
    }

    public void SetText(string _text)
    {
        resultText.text = _text;
    }
}
