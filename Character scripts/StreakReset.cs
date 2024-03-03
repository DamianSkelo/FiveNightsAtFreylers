using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StreakReset : MonoBehaviour
{
    public static int TimeSinceStreak;
    public Text StreakResetText;
    public int TimeTillStreakReset;

    // Start is called before the first frame update
    void Start()
    {
        StreakResetText.gameObject.SetActive(false);
    }
    public void ResetTimer()
    {
        if (MathSheetScript.Streak > 0)
        {
            if(TimeSinceStreak > 0)
            {TimeSinceStreak = 0;}
            else
            {
            TimeSinceStreak = 0;
            StartCoroutine(Count());
            }

        }
        else if (MathSheetScript.Streak <= 0)
        {
            StreakResetText.gameObject.SetActive(false);
        }
    }
    IEnumerator Count()
    {
        while (TimeSinceStreak <=30)
        {
            if(30 - TimeSinceStreak > 0 && MathSheetScript.Streak > 0)
            
            {
                StreakResetText.gameObject.SetActive(true);
                StreakResetText.text = "Streak Reset in " + (30 - TimeSinceStreak);
            }
            else
            {
                StreakResetText.gameObject.SetActive(false);
            }
            yield return new WaitForSeconds(1f);
            TimeSinceStreak++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (TimeSinceStreak >= 30)
        {
            MathSheetScript.Streak = 0;
        }
    }
}
