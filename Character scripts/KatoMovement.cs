using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class KatoMovement : MonoBehaviour
{
    public float MovementTime = 0.2f;
    public int MovementChance;
    int Jumpscaretime;
    int AtWindow = 0;
    public GameObject CamManager;
    public GameObject DoorManager;
    public AudioSource JumpscareSound;
    public AudioSource KatoknockingAtWindows;
    public GameObject OfficeUI;
    public GameObject CamsUI;
    public GameObject AnimtionUI;
    public GameObject SheetUI;
    public GameObject JumpscareUI;
    public AudioSource KatoKnocking;
    public GameObject WindowsUI;
    public GameObject KatoWindow1;
    public GameObject KatoWindow2;
    public GameObject KatoWindow3;
    public int NextKatoPos;
    public static int KatoPos;
    public increaseSaturation increaseSaturation;

    // Start is called before the first frame update
    //Pos 1 - 4 = UG
    //Pos 5 = Outside
    //Pos 6 = Window
    void Start()
    {
        KatoWindow1.SetActive(false);
        KatoWindow2.SetActive(false);
        KatoWindow3.SetActive(false);
        KatoPos = 1;
        JumpscareUI.SetActive(false);
        StartCoroutine(Movement());
    }
    IEnumerator Movement()
    {
        yield return new WaitForSeconds(2.5f);
        while (KatoMoveBack.PreviousKatoAI > 0 )
        {
            MovementTime = Random.Range(5f, 10f);
            yield return new WaitForSeconds(MovementTime);
            if(Killstreaks.StreakPlaying == false)
            { 
                if(KatoPos == 6)
                {
                    AtWindow = Random.Range(1, 4);
                    KatoknockingAtWindows.Play();
                    //PlayAudio
                    switch (AtWindow)
                    {
                        case 1:
                            KatoWindow1.SetActive(true);
                            yield return new WaitForSeconds(12f);
                            if(PublicVariables.Window1Closed == true)
                            {
                                KatoWindow1.SetActive(false);
                                AtWindow = 0;
                                KatoPos = 1;
                            }
                            else
                            {
                                KatoWindow1.SetActive(false);
                                Jumpscare();
                            }   
                        break;
                        case 2:
                            KatoWindow2.SetActive(true);
                            yield return new WaitForSeconds(12f);
                            if(PublicVariables.Window2Closed == true)
                            {
                                KatoWindow2.SetActive(false);
                                AtWindow = 0;
                                KatoPos = 1;
                            }
                            else
                            {
                                KatoWindow2.SetActive(false);
                                Jumpscare();
                            }
                        break;
                        case 3:
                            KatoWindow3.SetActive(true);
                            yield return new WaitForSeconds(12f);
                            if(PublicVariables.Window3Closed == true)
                            {
                                KatoWindow3.SetActive(false);
                                AtWindow = 0;
                                KatoPos = 1;
                            }
                            else
                            {
                                Jumpscare();
                            }
                        break;
                    }
                }
                else
                {
                    MovementChance = Random.Range(1, 21);
                    if (KatoRoutine.KatoAI < 0)
                    {
                        if(KatoPos > 1)
                        {
                            if(KatoMoveBack.LookingAtKato == true){increaseSaturation.ChangeTransparency();}
                            KatoPos--;
                            yield return new WaitForSeconds(0.01f);
                            if(KatoMoveBack.LookingAtKato == true){increaseSaturation.ChangeTransparency();}
                        }
                    }
                    else if(KatoRoutine.KatoAI >= MovementChance)
                    {
                        KatoPos++;
                        if(KatoMoveBack.LookingAtKato == true){increaseSaturation.ChangeTransparency();}
                        Debug.Log("Kato Position = " + KatoPos);
                        yield return new WaitForSeconds(0.01f);
                        if(KatoMoveBack.LookingAtKato == true){increaseSaturation.ChangeTransparency();}
                    }
                }
            }
        } 
    }
    
    public void Jumpscare()
    {
        if(Killstreaks.StreakPlaying == false)
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
            WindowsUI.SetActive(false);
            JumpscareUI.SetActive(true);
            StartCoroutine(GameOver());
        }
    }
    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("GameOver");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
