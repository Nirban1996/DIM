using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChangeControl : MonoBehaviour {

    public int sceneToLoad;
    public int sceneToReturn;
    public GameObject LevelCompleteUI;
    private void Start()
    {
        LevelCompleteUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            LevelCompleteUI.SetActive(true);
            CustomPlayerPrefs.LevelUpdate(CustomPlayerPrefs.LevelPotence() + 1);
            if (CustomPlayerPrefs.LevelPotence() == 4)
            {
                CustomPlayerPrefs.LevelUpdate(0);
            }
            Time.timeScale = 0f;

            //SceneManager.LoadScene(sceneToLoad);
        }
    }
}
