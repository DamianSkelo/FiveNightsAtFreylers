using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UroTrashSpawner : MonoBehaviour
{
    public int UroSpawnChance;
    public float UroSpawnTime;

    public AudioSource UroLeaving;
    public AudioSource JumpscareSound;
    public AudioSource PickUpSFX;

    public GameObject CamManager;
    public GameObject DoorManager;
    public RawImage UroInCam;
    public GameObject Trash1;
    public GameObject Trash2;
    public GameObject Trash3;
    public GameObject Trash4;
    public GameObject Trash5;
    
    public GameObject ButtonTrash1;
    public GameObject ButtonTrash2;
    public GameObject ButtonTrash3;
    public GameObject ButtonTrash4;
    public GameObject ButtonTrash5;

    public GameObject OfficeUI;
    public GameObject CamsUI;
    public GameObject AnimtionUI;
    public GameObject SheetUI;
    public GameObject JumpscareUI;
    public GameObject WindowsUI;



    bool Trash1Active = false;
    bool Trash2Active = false;
    bool Trash3Active = false;
    bool Trash4Active = false;
    bool Trash5Active = false;

    bool UroActive = false;

    public increaseSaturation increaseSaturation;

    int x = 15;
    // Start is called before the first frame update
    void Start()
    {
        UroActive = false;
        JumpscareUI.SetActive(false);
        Trash1Active = false;
        Trash2Active = false;
        Trash3Active = false;
        Trash4Active = false;
        Trash5Active = false;

        Trash1.SetActive(false);
        Trash2.SetActive(false);
        Trash3.SetActive(false);
        Trash4.SetActive(false);
        Trash5.SetActive(false);

        ButtonTrash1.SetActive(false);
        ButtonTrash2.SetActive(false);
        ButtonTrash3.SetActive(false);
        ButtonTrash4.SetActive(false);
        ButtonTrash5.SetActive(false);
        StartCoroutine(UroSpawner());
    }
    IEnumerator UroSpawner()
    {
        yield return new WaitForSeconds(2.5f);
        while(x == 15)
        {
            UroSpawnTime = Random.Range(5f, 8f);
            yield return new WaitForSeconds(UroSpawnTime);
            if(Killstreaks.StreakPlaying == false)
            {
                if(Udoroutine.UroAI > 0)
                {
                    if(Cameras.CurrentCam == 14 && UroActive == false){increaseSaturation.ChangeTransparency();}
                    UroInCam.gameObject.SetActive(true);
                    UroActive = true;
                }
                else
                {
                    UroInCam.gameObject.SetActive(false);
                }
                
                if(Trash1Active == true && Trash2Active == true && Trash3Active == true && Trash4Active == true && Trash5Active == true)
                {
                    if(Cameras.CurrentCam == 14){increaseSaturation.ChangeTransparency();}
                    UroInCam.gameObject.SetActive(false);
                    UroLeaving.Play();
                    yield return new WaitForSeconds(Random.Range(5f, 10f));
                    x = 1;
                    if(Udoroutine.UroAI > 0 && Killstreaks.StreakPlaying == false)
                    {
                        Debug.Log("JumpscareByUro");
                        JumpscareUdo();
                        //Jumpscare
                    }
                }
                else
                {
                    UroSpawnChance = Random.Range(1, 21);
                    if(UroSpawnChance <= Udoroutine.UroAI)
                    {
                        if(Trash1Active == false)
                        {
                            if(Cameras.CurrentCam == 14){increaseSaturation.ChangeTransparencyshort();}
                            Trash1.gameObject.SetActive(true);
                            Trash1Active = true;
                            ButtonTrash1.SetActive(true);
                        }
                        else if(Trash2Active == false)
                        {
                            if(Cameras.CurrentCam == 14){increaseSaturation.ChangeTransparencyshort();}
                            Trash2.gameObject.SetActive(true);
                            Trash2Active = true;
                            ButtonTrash2.SetActive(true);
                        }
                        else if(Trash3Active == false)
                        {
                            if(Cameras.CurrentCam == 14){increaseSaturation.ChangeTransparencyshort();}
                            Trash3.gameObject.SetActive(true);
                            Trash3Active = true;
                            ButtonTrash3.SetActive(true);
                        }
                        else if(Trash4Active == false)
                        {
                            if(Cameras.CurrentCam == 14){increaseSaturation.ChangeTransparencyshort();}
                            Trash4.gameObject.SetActive(true);
                            Trash4Active = true;
                            ButtonTrash4.SetActive(true);
                        }
                        else if(Trash5Active == false)
                        {
                            if(Cameras.CurrentCam == 14){increaseSaturation.ChangeTransparencyshort();}
                            Trash5.gameObject.SetActive(true);
                            Trash5Active = true;
                            ButtonTrash5.SetActive(true);
                        }
                    }
                }
            }
        }
    }
    public void disableTrash1()
    {
        PickUpSFX.Play();
        Trash1.SetActive(false);
        Trash1Active = false;
        ButtonTrash1.SetActive(false);
    }
    public void disableTrash2()
    {
        PickUpSFX.Play();
        Trash2.SetActive(false);
        Trash2Active = false;
        ButtonTrash2.SetActive(false);
    }
    public void disableTrash3()
    {
        PickUpSFX.Play();
        Trash3.SetActive(false);
        Trash3Active = false;
        ButtonTrash3.SetActive(false);
    }
    public void disableTrash4()
    {
        PickUpSFX.Play();
        Trash4.SetActive(false);
        Trash4Active = false;
        ButtonTrash4.SetActive(false);
    }
    public void disableTrash5()
    {
        PickUpSFX.Play();
        Trash5.SetActive(false);
        Trash5Active = false;
        ButtonTrash5.SetActive(false);
    }
    public void JumpscareUdo()
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

    }
}
