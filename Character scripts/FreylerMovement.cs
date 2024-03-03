using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class FreylerMovement : MonoBehaviour
{
    public float MovementTime = 0.2f;
    public int MovementChance;
    int Jumpscaretime;

    public AudioSource JumpscareSound;
    public GameObject CamManager;
    public GameObject DoorManager;
    public GameObject OfficeUI;
    public GameObject CamsUI;
    public GameObject AnimtionUI;
    public GameObject SheetUI;
    public GameObject JumpscareUI;
    public GameObject WindowsUI;
    public AudioSource FREylerLeaving1;
    public AudioSource FREylerLeaving2;
    public AudioSource FREylerLeaving3;
    public int NextFreylerPos;
    int Leaving = 1;
    public increaseSaturation increaseSaturation;
    // Start is called before the first frame update
    void Start()
    {
        JumpscareUI.SetActive(false);
        StartCoroutine(Movement());
    }
    IEnumerator Movement()
    {
        yield return new WaitForSeconds(2.5f);
        while(Freyler.FreylerPos <= 10)
        {
            MovementTime = Random.Range(3.5f, 6f);
            yield return new WaitForSeconds(MovementTime);
            if(Killstreaks.StreakPlaying == false && Killstreaks.FreylerSniped == false)
            {
                if(Freyler.FreylerPos == 9)
                {
                    Jumpscaretime = Random.Range(10, 16);
                    yield return new WaitForSeconds(Jumpscaretime);
                    if(PublicVariables.DoorClosed == false)
                    {
                        //Jumpscare
                        if(Freyler.FreylerAI > 0 && Killstreaks.StreakPlaying == false)
                        {
                            Jumpscare();
                            Debug.Log("Jumpscare");
                        }
                        
                    }
                    else
                    {
                        //Freyler sent back
                        Freyler.FreylerPos = 1;
                        Debug.Log("Position = " + Freyler.FreylerPos);
                        Leaving = Random.Range(1, 4);
                        switch (Leaving)
                        {
                            case 1:
                            FREylerLeaving1.Play();
                            yield return new WaitForSeconds(5f);
                            break;
                            case 2:
                            FREylerLeaving2.Play();
                            yield return new WaitForSeconds(5f);
                            break;
                            case 3:
                            FREylerLeaving3.Play();
                            yield return new WaitForSeconds(5f);
                            break;
                        }    
                    } 
                    
                }

                MovementChance = Random.Range(1, 21);
                if (MovementChance <= Freyler.FreylerAI + FreylerStreakOffset.StreakOffset)
                {
                    if(FreylerImages.LookingAtFreyler == true){increaseSaturation.ChangeTransparency();}
                    Freyler.FreylerPos++;
                    yield return new WaitForSeconds(0.01f);
                    if(FreylerImages.LookingAtFreyler == true){increaseSaturation.ChangeTransparency();}
                    Debug.Log("Position = " + Freyler.FreylerPos);
                }
            }
        }
    }

    public void Jumpscare()
    {
        Killstreaks.StreakPlaying = true;
        CamManager.SetActive(false);
        DoorManager.SetActive(false);
        JumpscareSound.Play();
        DontDestroyOnLoad(JumpscareSound);
        MathSheetScript.Streak = 0;
        OfficeUI.SetActive(false);
        CamsUI.SetActive(false);
        AnimtionUI.SetActive(false);
        SheetUI.SetActive(false);
        JumpscareUI.SetActive(true);
        WindowsUI.SetActive(false);
        StartCoroutine(GameOver());
    }
    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("GameOver");
    }
    // Update is called once per frame
    void Update()
    {
        NextFreylerPos = Freyler.FreylerPos + 1;
        if(Freyler.FreylerPos == 8)
        {NextFreylerPos = 1;}
    }
}
