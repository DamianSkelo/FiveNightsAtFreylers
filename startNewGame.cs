using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startNewGame : MonoBehaviour
{
    public void StartNewGame()
    {
        Killstreaks.NukeUsed = 0;
        Killstreaks.SniperUsed = 0;
        Killstreaks.UAVUsed = 0;
        GoofyBufferScript.BuffersUsed = 0;
        CurrentNightScript.CurrentNight = 1;
        SaveGame.GameFinished = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SaveGame.SaveCurrentGame();
    }
    public void ContinueGame()
    {
        SaveGame.LoadCurrentNight();
        if(CurrentNightScript.CurrentNight == 0)
        {
            CurrentNightScript.CurrentNight = 1;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
