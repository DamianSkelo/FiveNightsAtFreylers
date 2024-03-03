using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Udoroutine : MonoBehaviour
{
    public static int UroAI;
    public GameObject TrashElements;
    public GameObject TrashButtons;
    // Start is called before the first frame update
    void Start()
    {
        TrashElements.SetActive(false);
        TrashButtons.SetActive(false);
        UroAI = 0;
        if(CurrentNightScript.CurrentNight == 1)
        {StartCoroutine(UroNight1());}
        else if(CurrentNightScript.CurrentNight == 2)
        {StartCoroutine(UroNight2());}
        else if(CurrentNightScript.CurrentNight == 3)
        {StartCoroutine(UroNight3());}
        else if(CurrentNightScript.CurrentNight == 4)
        {StartCoroutine(UroNight4());}
        else if(CurrentNightScript.CurrentNight == 5)
        {StartCoroutine(UroNight5());}
    }
    IEnumerator UroNight1()
    {
        yield return new WaitForSeconds(1.5f);
        UroAI = 0;
    }
    IEnumerator UroNight2()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        UroAI = 0;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        UroAI = 5;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        UroAI = 5;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        UroAI = 5;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        UroAI = 5;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        UroAI = 6;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        UroAI = 6;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        UroAI = 6;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }
    IEnumerator UroNight3()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        UroAI = 5;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        UroAI = 5;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        UroAI = 5;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        UroAI = 5;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        UroAI = 5;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        UroAI = 7;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        UroAI = 7;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        UroAI = 7;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }
    IEnumerator UroNight4()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        UroAI = 8;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        UroAI = 8;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        UroAI = 8;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }
    IEnumerator UroNight5()
    {
        yield return new WaitForSeconds(2.5f);
        //12AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //1AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //2AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //3AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //4AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //5AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //6AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
        //7AM
        UroAI = 10;
        Debug.Log("Uro AI = " + UroAI);
        yield return new WaitForSeconds(TimeManager.HourDuration);
    }

    // Update is called once per frame
    void Update()
    {
        if(Cameras.CurrentCam == 14)
        {
            TrashElements.SetActive(true);
            TrashButtons.SetActive(true);
        }
        else
        {
            TrashElements.SetActive(false);
            TrashButtons.SetActive(false);
        }
    }
}
