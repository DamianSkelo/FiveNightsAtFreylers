using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public static bool GameFinished = false;
    public static void SaveCurrentGame()
    {
        PlayerPrefs.SetInt("CurrentSavedNight", CurrentNightScript.CurrentNight);
        PlayerPrefs.SetInt("KillstreakPoints", Killstreaks.KillstreakStreak);
        PlayerPrefs.SetInt("SavedNukeUsed", Killstreaks.NukeUsed);
        PlayerPrefs.SetInt("SavedSniperUsed", Killstreaks.SniperUsed);
        PlayerPrefs.SetInt("SavedUAVUsed", Killstreaks.UAVUsed);
        PlayerPrefs.SetInt("SavedBuffer", GoofyBufferScript.BuffersUsed);
    }
    public static void LoadCurrentNight()
    {
        CurrentNightScript.CurrentNight = PlayerPrefs.GetInt("CurrentSavedNight");
        Killstreaks.KillstreakStreak = PlayerPrefs.GetInt("KillstreakPoints");
        Killstreaks.NukeUsed = PlayerPrefs.GetInt("SavedNukeUsed");
        Killstreaks.SniperUsed = PlayerPrefs.GetInt("SavedSniperUsed");
        Killstreaks.UAVUsed = PlayerPrefs.GetInt("SavedUAVUsed");
        GoofyBufferScript.BuffersUsed = PlayerPrefs.GetInt("SavedBuffer");
        if(CurrentNightScript.CurrentNight == 0)
        {
            CurrentNightScript.CurrentNight = 1;
        }
        if(CurrentNightScript.CurrentNight == 6)
        {
            CurrentNightScript.CurrentNight = 5;
        }

    }
}
