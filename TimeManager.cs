using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public string Time = "";
    public static float HourDuration = 50f;
    public Text _title;
    // Start is called before the first frame update
    void Start()
    {
        SaveGame.LoadCurrentNight();
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.5f);
        Time = "12 AM";
        _title.text = Time;
        yield return new WaitForSeconds(HourDuration);
        PublicVariables.CurrentTime++;
        Time = "1 AM";
        _title.text = Time;
        yield return new WaitForSeconds(HourDuration);
        PublicVariables.CurrentTime++;
        Time = "2 AM";
        _title.text = Time;
        yield return new WaitForSeconds(HourDuration);
        PublicVariables.CurrentTime++;
        Time = "3 AM";
        _title.text = Time;
        yield return new WaitForSeconds(HourDuration);
        PublicVariables.CurrentTime++;
        Time = "4 AM";
        _title.text = Time;
        yield return new WaitForSeconds(HourDuration);
        PublicVariables.CurrentTime++;
        Time = "5 AM";
        _title.text = Time;
        yield return new WaitForSeconds(HourDuration);
        PublicVariables.CurrentTime++;
        Time = "6 AM";
        _title.text = Time;
        yield return new WaitForSeconds(HourDuration);
        PublicVariables.CurrentTime++;
        Time = "7 AM";
        _title.text = Time;
        yield return new WaitForSeconds(HourDuration);
        PublicVariables.CurrentTime++;
        Time = "8AM";
        _title.text = Time;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
