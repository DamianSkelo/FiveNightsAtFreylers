using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Killstreaks : MonoBehaviour
{
    public VideoPlayer NukeVid;
    public VideoPlayer SniperVid;
    public VideoPlayer UAVid;

    public GameObject NukeRaw;
    public GameObject SniperRaw;
    public GameObject UAVRaw;

    public GameObject PhoneGuyManager;

    public Text StreakPoints;
    public GameObject Buttons;
    public GameObject NukeButton;
    public GameObject NotEnoughPoints;
    public GameObject AlreadyUsed;

    public AudioSource PhoneCall1;
    public AudioSource PhoneCall2;
    public AudioSource PhoneCall3;
    public AudioSource Ambiance;

    public GameObject SheetUI;
    public RawImage Transition;
    public GameObject DotsOG;
    public GameObject DotsUG;

    public VideoPlayer TransitionVid;
    public static int NukeUsed = 0;
    public static int SniperUsed = 0;
    public static int UAVUsed = 0;
    public static bool FreylerSniped = false;
    public static bool StreakPlaying = false;
    public static int KillstreakStreak = 0;
    // Start is called before the first frame update
    void Start()
    {
        Transition.gameObject.SetActive(false);
        DotsOG.SetActive(false);
        DotsUG.SetActive(false);
        FreylerSniped = false;
        StreakPlaying = false;
        NukeRaw.SetActive(false);
        SniperRaw.SetActive(false);
        UAVRaw.SetActive(false);
        NotEnoughPoints.SetActive(false);
        AlreadyUsed.SetActive(false);
        NukeVid.Prepare();
        SniperVid.Prepare();
        UAVid.Prepare();
        switch(CurrentNightScript.CurrentNight)
        {
            case 1:
            Buttons.SetActive(false);
            NewGameReset();
            break;
            case 2:
            Buttons.SetActive(false);
            break;
            case 3:
            Buttons.SetActive(true);
            NukeButton.SetActive(false);
            break;
            case 4:
            Buttons.SetActive(true);
            NukeButton.SetActive(true);
            break;
            case 5:
            Buttons.SetActive(true);
            NukeButton.SetActive(true);
            break;
        }

        /*if(NukeUsed == 1)
        {
            NukeButton.SetActive(false);
        }*/
    }
    /***********************************************************************

    Sniper

    ***********************************************************************/
    public void StartSniper()
    {
        if(KillstreakStreak >= 40 && SniperUsed == 0)
        {
            StreakPlaying = true;
            SheetUI.SetActive(false);
            SniperUsed = 1;
            PhoneCall1.Pause();
            PhoneCall2.Pause();
            PhoneCall3.Pause();
            Ambiance.Pause();
            PhoneGuyManager.SetActive(false);
            StartCoroutine(PlaySniper());
        }
        else if(SniperUsed ==1)
        {
            StartCoroutine(ShowRedText2());
        }
        else
        {
            StartCoroutine(ShowRedText());
        }
    }
    IEnumerator PlaySniper()
    {
        Transition.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        Transition.gameObject.SetActive(false);
        SniperRaw.SetActive(true);
        SniperVid.Play();
        FreylerSniped = true;
        yield return new WaitForSeconds(15f);
        SniperRaw.SetActive(false);
        Ambiance.Play();
        StreakPlaying = false;
        SheetUI.SetActive(true);
    }
    /***********************************************************************

    UAV

    ***********************************************************************/
    public void StartUAV()
    {
        if(KillstreakStreak >= 60 && UAVUsed == 0)
        {
            StreakPlaying = true;
            SheetUI.SetActive(false);
            UAVUsed = 1;
            PhoneCall1.Pause();
            PhoneCall2.Pause();
            PhoneCall3.Pause();
            Ambiance.Pause();
            PhoneGuyManager.SetActive(false);
            StartCoroutine(PlayUAV());
        }
        else if(UAVUsed == 1)
        {
            StartCoroutine(ShowRedText2());
        }
        else
        {
            StartCoroutine(ShowRedText());
        }
    }
    IEnumerator PlayUAV()
    {
        Transition.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        Transition.gameObject.SetActive(false);
        UAVRaw.SetActive(true);
        UAVid.Play();
        DotsOG.SetActive(true);
        DotsUG.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        UAVRaw.SetActive(false);
        Ambiance.Play();
        StreakPlaying = false;
        SheetUI.SetActive(true);
        yield return new WaitForSeconds(100f);
        DotsOG.SetActive(false);
        DotsUG.SetActive(false);
    }
    /***********************************************************************

    NUKE

    ***********************************************************************/
    public void StartNuke()
    {
        if(KillstreakStreak >= 80 && NukeUsed == 0)
        {
            StreakPlaying = true;
            SheetUI.SetActive(false);
            NukeUsed = 1;
            Debug.Log("SOOS NUKEEE");
            PhoneCall2.Pause();
            PhoneCall3.Pause();
            Ambiance.Pause();
            PhoneGuyManager.SetActive(false);
            
            StartCoroutine(PlayNuke());
        }
        else if(NukeUsed == 1)
        {
            StartCoroutine(ShowRedText2());
        }
        else
        {
            StartCoroutine(ShowRedText());
        }
    }
    IEnumerator PlayNuke()
    {
        Transition.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        Transition.gameObject.SetActive(false);
        NukeRaw.SetActive(true);
        NukeVid.Play();
        yield return new WaitForSeconds(36f);
        StreakPlaying = false;
        NukeRaw.SetActive(false);
        SheetUI.SetActive(true);
        yield return new WaitForSeconds(29f);
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
    /***********************************************************************

    RED TEXT

    ***********************************************************************/
    IEnumerator ShowRedText()
    {
        NotEnoughPoints.SetActive(true);
        yield return new WaitForSeconds(3f);
        NotEnoughPoints.SetActive(false);
    }
    IEnumerator ShowRedText2()
    {
        AlreadyUsed.SetActive(true);
        yield return new WaitForSeconds(3f);
        AlreadyUsed.SetActive(false);
    }
    public void NewGameReset()
    {
        NukeUsed = 0;
        KillstreakStreak = 0;
    }
    // Update is called once per frame
    void Update()
    {
        StreakPoints.text = "Streak points: " + KillstreakStreak;
    }
}
