using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Audio;

public class Freyler : MonoBehaviour
{
    public static int FreylerPos;
    public static int FreylerAI = 0; 
    // Start is called before the first frame update
    void Start()
    {
        FreylerAI = 0; 
        FreylerPos = 1;
        //Set Freylers difficutly depending on Night
        if(CurrentNightScript.CurrentNight == 1)
        {StartCoroutine(FreylerRoutine1());}
        else if(CurrentNightScript.CurrentNight == 2)
        {StartCoroutine(FreylerRoutine2());}
        else if(CurrentNightScript.CurrentNight == 3)
        {StartCoroutine(FreylerRoutine3());}
        else if(CurrentNightScript.CurrentNight == 4)
        {StartCoroutine(FreylerRoutine4());}
        else if(CurrentNightScript.CurrentNight == 5)
        {StartCoroutine(FreylerRoutine5());}
    }

    IEnumerator FreylerRoutine1()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        FreylerAI = 4;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        FreylerAI = 5;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        FreylerAI = 5;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        FreylerAI = 7;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        FreylerAI = 7;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        FreylerAI = 7;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        FreylerAI = 7;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        FreylerAI = 7;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }
    IEnumerator FreylerRoutine2()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        FreylerAI = 0;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        FreylerAI = 3;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        FreylerAI = 4;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        FreylerAI = 4;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        FreylerAI = 4;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        FreylerAI = 4;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        FreylerAI = 6;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        FreylerAI = 6;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }
    IEnumerator FreylerRoutine3()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        FreylerAI = 6;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        FreylerAI = 6;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        FreylerAI = 7;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        FreylerAI = 7;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        FreylerAI = 8;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        FreylerAI = 8;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        FreylerAI = 9;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        FreylerAI = 9;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }
    IEnumerator FreylerRoutine4()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        FreylerAI = 9;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        FreylerAI = 9;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        FreylerAI = 9;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        FreylerAI = 9;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        FreylerAI = 9;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        FreylerAI = 9;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        FreylerAI = 9;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        FreylerAI = 9;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }
    IEnumerator FreylerRoutine5()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        FreylerAI = 0;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        FreylerAI = 12;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        FreylerAI = 12;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        FreylerAI = 12;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        FreylerAI = 13;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        FreylerAI = 13;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        FreylerAI = 13;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        FreylerAI = 13;
        Debug.Log(FreylerAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}

