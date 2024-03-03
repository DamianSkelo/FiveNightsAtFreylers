using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreylerStreakOffset : MonoBehaviour
{
    public static int StreakOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GoofyBufferScript.BuffActive == true)
        {
            StreakOffset = 8;
        }
            else
            {
            if (MathSheetScript.Streak == 0)
            {
                StreakOffset = 0;
            }
            if (MathSheetScript.Streak >= 5)
            {
                StreakOffset = -5;
            }
            else if (MathSheetScript.Streak >= 4)
            {
                StreakOffset = -4;
            }
            else if (MathSheetScript.Streak >= 3)
            {
                StreakOffset = -3;
            }
            else if (MathSheetScript.Streak <= -3)
            {
                StreakOffset = 5;
            }
            else if (MathSheetScript.Streak <= -2)
            {
                StreakOffset = 3;
            }
            else if (MathSheetScript.Streak < 0)
            {
                StreakOffset = 1;
            }
        }
        
    }
}
