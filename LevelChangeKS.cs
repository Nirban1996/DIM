using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeKS : MonoBehaviour {
    public int sceneToLoad;
    public int sceneToReturn;
    public GameObject LevelCompleteUI;
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToReturn);
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }


    public void LoadLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToLoad);
    }
}
