using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkipNights : MonoBehaviour
{
    public Text StreakPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.LeftControl)== true)
        {
            if(CurrentNightScript.CurrentNight < 5)
            {
                CurrentNightScript.CurrentNight = CurrentNightScript.CurrentNight + 1;
                SaveGame.GameFinished = false;
            }
            else if(CurrentNightScript.CurrentNight == 5)
            {
                SaveGame.GameFinished = true;
            }
            SaveGame.SaveCurrentGame();
            MathSheetScript.Streak = 0;
            SceneManager.LoadScene("GameWin");
        }
        
        if(Input.GetKeyDown(KeyCode.LeftShift)== true)
        {
            Killstreaks.KillstreakStreak = 80;
            StreakPoints.text = "Streak Points: " + Killstreaks.KillstreakStreak;
        }
    }
}
