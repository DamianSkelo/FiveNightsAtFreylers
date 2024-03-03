using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Audio;

public class KatoRoutine : MonoBehaviour
{
    public static int KatoAI = 0;
    // Start is called before the first frame update
    void Start()
    {
        KatoAI = 0;
        if(CurrentNightScript.CurrentNight == 1)
        {StartCoroutine(KatoRoutine1());}
        else if(CurrentNightScript.CurrentNight == 2)
        {StartCoroutine(KatoRoutine2());}
        else if(CurrentNightScript.CurrentNight == 3)
        {StartCoroutine(KatoRoutine3());}
        else if(CurrentNightScript.CurrentNight == 4)
        {StartCoroutine(KatoRoutine4());}
        else if(CurrentNightScript.CurrentNight == 5)
        {StartCoroutine(KatoRoutine5());}
    }
    IEnumerator KatoRoutine1()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        KatoAI = 0;
        KatoMoveBack.PreviousKatoAI = 0;
        
    }
     IEnumerator KatoRoutine2()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        KatoAI = 0;
        KatoMoveBack.PreviousKatoAI = 0;
    }

    IEnumerator KatoRoutine3()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        KatoAI = 3;
        KatoMoveBack.PreviousKatoAI = 6;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        KatoAI = 3;
        KatoMoveBack.PreviousKatoAI = 6;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        KatoAI = 4;
        KatoMoveBack.PreviousKatoAI = 7;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        KatoAI = 4;
        KatoMoveBack.PreviousKatoAI = 7;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        KatoAI = 5;
        KatoMoveBack.PreviousKatoAI = 7;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        KatoAI = 5;
        KatoMoveBack.PreviousKatoAI = 7;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        KatoAI = 5;
        KatoMoveBack.PreviousKatoAI = 7;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        KatoAI = 6;
        KatoMoveBack.PreviousKatoAI = 7;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }
    IEnumerator KatoRoutine4()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        KatoAI = 20;
        KatoMoveBack.PreviousKatoAI = 10;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        KatoAI = 20;
        KatoMoveBack.PreviousKatoAI = 10;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        KatoAI = 20;
        KatoMoveBack.PreviousKatoAI = 10;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        KatoAI = 20;
        KatoMoveBack.PreviousKatoAI = 10;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        KatoAI = 20;
        KatoMoveBack.PreviousKatoAI = 10;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        KatoAI = 20;
        KatoMoveBack.PreviousKatoAI = 10;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        KatoAI = 20;
        KatoMoveBack.PreviousKatoAI = 12;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        KatoAI = 20;
        KatoMoveBack.PreviousKatoAI = 12;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }
    IEnumerator KatoRoutine5()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        KatoAI = 3;
        KatoMoveBack.PreviousKatoAI = 12;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        KatoAI = 3;
        KatoMoveBack.PreviousKatoAI = 12;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        KatoAI = 4;
        KatoMoveBack.PreviousKatoAI = 12;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        KatoAI = 4;
        KatoMoveBack.PreviousKatoAI = 12;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        KatoAI = 5;
        KatoMoveBack.PreviousKatoAI = 14;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        KatoAI = 5;
        KatoMoveBack.PreviousKatoAI = 14;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        KatoAI = 5;
        KatoMoveBack.PreviousKatoAI = 14;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        KatoAI = 6;
        KatoMoveBack.PreviousKatoAI = 14;
        Debug.Log("Kato AI = " + KatoAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
