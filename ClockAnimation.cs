using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClockAnimation : MonoBehaviour
{
    public string Time = "7:59";
    public float TimeSwapDuration = 5f;
    public Text Clock;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchTime());
    }
    IEnumerator SwitchTime()
    {
        Clock.text = Time;
        yield return new WaitForSeconds(0.5f);
        Time = "7:5";
        Clock.text = Time;
        yield return new WaitForSeconds(TimeSwapDuration);
        Time = "7:";
        Clock.text = Time;
        yield return new WaitForSeconds(TimeSwapDuration);
        Time = "7";
        Clock.text = Time;
        yield return new WaitForSeconds(TimeSwapDuration);
        Time = "";
        Clock.text = Time;

        yield return new WaitForSeconds(1f);
        Time = "8";
        Clock.text = Time;
        yield return new WaitForSeconds(TimeSwapDuration);
        Time = "8:";
        Clock.text = Time;
        yield return new WaitForSeconds(TimeSwapDuration);
        Time = "8:0";
        Clock.text = Time;
        yield return new WaitForSeconds(TimeSwapDuration);
        Time = "8:00";
        Clock.text = Time;
        yield return new WaitForSeconds(2.5f);
        if(SaveGame.GameFinished == false)
        {
            SceneManager.LoadScene("NightStart");
        }
        else if(SaveGame.GameFinished == true)
        {
            SceneManager.LoadScene("Ending");
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
