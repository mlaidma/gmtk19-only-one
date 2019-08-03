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
}
