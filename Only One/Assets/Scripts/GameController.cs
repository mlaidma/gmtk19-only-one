using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    private int startSceneIndex = 0;
    private int gameSceneIndex = 1;
    private int endSceneIndex = 2;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == endSceneIndex)
        {
            SetGameOverText();
        }
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(startSceneIndex);
    }
    
    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameSceneIndex);
    }

    public void LoadEndScene()
    {
        SceneManager.LoadScene(endSceneIndex);
    }

    private void SetGameOverText()
    {
        const string youWonText = "Congratulations! \n You have slain the fearsome beast!";
        const string youLostText = "ha ha ha ha! \n The mighty beast got the better of you!";

        GameResult result = FindObjectOfType<GameResult>();

        bool playerWon = (PlayerPrefs.GetString("loser") == "Enemy" ? true : false );

        if(playerWon)
        {
            result.SetText(youWonText);
        }
        else
        {
            result.SetText(youLostText);
        }
    }
}
