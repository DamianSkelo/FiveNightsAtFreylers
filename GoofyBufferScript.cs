using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.Audio;


public class GoofyBufferScript : MonoBehaviour
{
    public VideoPlayer Buffer1;
    public VideoPlayer Buffer2;

    public GameObject UIs;
    public GameObject RawBuffer1;
    public GameObject RawBuffer2;

    public AudioSource Phone1;
    public AudioSource Phone2;
    public AudioSource Phone3;
    public AudioSource Phone4;
    public AudioSource Phone5;
    public GameObject PhoneManager;

    public static int BuffersUsed = 0;
    public static bool BuffActive = false;
    // Start is called before the first frame update
    void Start()
    {
        BuffActive = false;
        Buffer1.Prepare();
        Buffer2.Prepare();
        RawBuffer1.SetActive(false);
        RawBuffer2.SetActive(false);
    }
    IEnumerator ActivateBuffer()
    {
        if(BuffersUsed == 0)
        {
            Phone1.Pause();
            Phone2.Pause();
            Phone3.Pause();
            Phone4.Pause();
            Phone5.Pause();
            PhoneManager.SetActive(false);

            BuffersUsed ++;
            Buffer1.Play();
            UIs.SetActive(false);
            BuffActive = true;
            Killstreaks.StreakPlaying = true;
            RawBuffer1.SetActive(true);
            yield return new WaitForSeconds(26f);
            RawBuffer1.SetActive(false);
            UIs.SetActive(true);
            Killstreaks.StreakPlaying = false;
        }
        else if(BuffersUsed == 1)
        {
            Phone1.Pause();
            Phone2.Pause();
            Phone3.Pause();
            Phone4.Pause();
            Phone5.Pause();
            PhoneManager.SetActive(false);
            
            BuffersUsed ++;
            Buffer2.Play();
            UIs.SetActive(false);
            BuffActive = false;
            Killstreaks.StreakPlaying = true;
            RawBuffer2.SetActive(true);
            yield return new WaitForSeconds(30f);
            RawBuffer2.SetActive(false);
            UIs.SetActive(true);
            Killstreaks.StreakPlaying = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            StartCoroutine(ActivateBuffer());
        }
    }
}
