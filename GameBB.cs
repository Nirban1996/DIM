using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBB : MonoBehaviour {

    public static string LevelPassed = "LevelPassed";
    public static string itemNo = "itemNo";

    public static void LevelUpdate(int i)
    {
        PlayerPrefs.SetInt(LevelPassed, i);
    }

    public static int LevelPotence()
    {
        return PlayerPrefs.GetInt(LevelPassed);
    }

    public static void ItemUpdate(int i)
    {
        PlayerPrefs.SetInt(itemNo, i);
    }
    public static int ItemAvailable()
    {
        return PlayerPrefs.GetInt(itemNo);
    }



}
