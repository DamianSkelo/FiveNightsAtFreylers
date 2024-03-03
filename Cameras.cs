using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.Audio;

public class Cameras : MonoBehaviour
{
    //Cameras
    public Camera office;
    public Camera math_sheet;
    public Camera Window_Cam;

    public AudioSource ChangeCam;
    public AudioSource CamBeep;
    public AudioSource CamStatic;
    public AudioSource CamGlitch;
    public AudioSource Walking;
    public AudioSource ClosingCurtains;

    public Camera OG_CAM1_Cam;
    public Camera OG_CAM2_Cam;
    public Camera OG_CAM3_Cam;
    public Camera OG_CAM4_Cam;
    public Camera OG_CAM5A_Cam;
    public Camera OG_CAM5B_Cam;
    public Camera OG_CAM6_Cam;
    public Camera OG_CAM7A_Cam;
    public Camera OG_CAM7B_Cam;
    public Camera OG_CAM8_Cam;

    public Camera UG_CAM1_Cam;
    public Camera UG_CAM2A_Cam;
    public Camera UG_CAM2B_Cam;
    public Camera UG_CAM3_Cam;
    public Camera UG_CAM4_Cam;
    public Camera UG_CAM5_Cam;

    public GameObject Map_OG;
    public GameObject Map_UG;

    //User interfaces
    public GameObject camUp;
    public GameObject camDown;
    public GameObject LookAtCams_UI;
    public GameObject LookOffCams_UI;
    public GameObject Sheet_UI;
    public GameObject LookAtSheet_UI;
    public GameObject LookOffSheet_UI;
    public GameObject Windows_UI;
    public GameObject RunToWindows_UI;
    public GameObject Window1_UI;
    public GameObject Window2_UI;
    public GameObject Window3_UI;
    public GameObject ToDoor_UI;
    public GameObject OffDoor_UI;
    public GameObject Loading_UI;

    //other variables
    public static int CurrentCam = 1;
    int CurrentOG = 1;
    int CurrentUG = 11;

    public increaseSaturation increaseSaturation;
    public KatoMoveBack KatoMoveBack;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartGame());
        
    }
    IEnumerator StartGame()
    {
        Loading_UI.SetActive(true);
        //Office Cameras
        CurrentCam = 1;
        CurrentUG = 11;
        office.gameObject.SetActive(true);
        math_sheet.gameObject.SetActive(false);
        Window_Cam.gameObject.SetActive(false);

        //School Cameras
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);

        //User Interfaces
        Map_OG.SetActive(true);
        Map_UG.SetActive(false);
        camUp.SetActive(false);
        camDown.SetActive(false);
        LookAtCams_UI.SetActive(false);
        LookOffCams_UI.SetActive(false);
        Sheet_UI.SetActive(false);
        LookAtSheet_UI.SetActive(false);
        LookOffSheet_UI.SetActive(false);
        Windows_UI.SetActive(false);
        RunToWindows_UI.SetActive(false);
        Window1_UI.SetActive(false);
        Window2_UI.SetActive(false);
        Window3_UI.SetActive(false);
        ToDoor_UI.SetActive(false);
        OffDoor_UI.SetActive(false);

        UG_CAM1_Cam.gameObject.SetActive(false);
        UG_CAM2A_Cam.gameObject.SetActive(false);
        UG_CAM2B_Cam.gameObject.SetActive(false);
        UG_CAM3_Cam.gameObject.SetActive(false);
        UG_CAM4_Cam.gameObject.SetActive(false);
        UG_CAM5_Cam.gameObject.SetActive(false);

        yield return new WaitForSeconds(2.5f);
        Loading_UI.SetActive(false);
        camUp.SetActive(true);

    }
    /*****************************************
    Sheet UI + Cam + Animation
    *****************************************/
    public void SheetUp()
    {
        StartCoroutine(WaitForLookAtSheet());
    }
    IEnumerator WaitForLookAtSheet()
    {
        
        camUp.SetActive(false);
        LookAtSheet_UI.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        LookAtSheet_UI.SetActive(false);
        office.gameObject.SetActive(false);
        math_sheet.gameObject.SetActive(true);
        Sheet_UI.SetActive(true);
    }
    public void SheetDown()
    {
        StartCoroutine(WaitForLookOffSheet());
    }
    IEnumerator WaitForLookOffSheet()
    {
        Sheet_UI.SetActive(false);
        LookOffSheet_UI.SetActive(true);
        yield return new WaitForSeconds(1f);
        LookOffSheet_UI.SetActive(false);
        math_sheet.gameObject.SetActive(false);
        office.gameObject.SetActive(true);
        camUp.SetActive(true);
    }

    /*****************************************
    Windows
    *****************************************/
    public void GoToWindows()
    {
        StartCoroutine(WaitForGoToWindows());
    }
    IEnumerator WaitForGoToWindows()
    {
        PublicVariables.PlayerAtWindows = true;
        PublicVariables.Window1Closed = false;
        PublicVariables.Window2Closed = false;
        PublicVariables.Window3Closed = false;
        camUp.SetActive(false);
        RunToWindows_UI.SetActive(true);
        Walking.Play();
        yield return new WaitForSeconds(2.5f);
        Walking.Pause();
        yield return new WaitForSeconds(0.5f);
        RunToWindows_UI.SetActive(false);
        office.gameObject.SetActive(false);
        Window_Cam.gameObject.SetActive(true);
        Windows_UI.SetActive(true);
    }
    public void Window1()
    {
        StartCoroutine(WaitForWindow1());
    }
    IEnumerator WaitForWindow1()
    {
        PublicVariables.Window1Closed = true;
        Windows_UI.SetActive(false);
        Window1_UI.SetActive(true);
        Walking.Play();
        yield return new WaitForSeconds(1.5f);
        Walking.Pause();
        yield return new WaitForSeconds(0.9f);
        ClosingCurtains.Play();
        yield return new WaitForSeconds(0.6f);
        Walking.Play();
        yield return new WaitForSeconds(3.0f);
        Walking.Pause();
        yield return new WaitForSeconds(0.5f);
        Window1_UI.SetActive(false);
        Window_Cam.gameObject.SetActive(false);
        office.gameObject.SetActive(true);
        camUp.SetActive(true);
        PublicVariables.PlayerAtWindows = false;
    }
    public void Window2()
    {
        StartCoroutine(WaitForWindow2());
    }
    IEnumerator WaitForWindow2()
    {
        PublicVariables.Window2Closed = true;
        Windows_UI.SetActive(false);
        Window2_UI.SetActive(true);
        Walking.Play();
        yield return new WaitForSeconds(1.5f);
        Walking.Pause();
        yield return new WaitForSeconds(0.5f);
        ClosingCurtains.Play();
        yield return new WaitForSeconds(1f);
        Walking.Play();
        yield return new WaitForSeconds(3.0f);
        Walking.Pause();
        yield return new WaitForSeconds(1f);
        Walking.Pause();
        Window2_UI.SetActive(false);
        Window_Cam.gameObject.SetActive(false);
        office.gameObject.SetActive(true);
        camUp.SetActive(true);
        PublicVariables.PlayerAtWindows = false;
    }
    public void Window3()
    {
        StartCoroutine(WaitForWindow3());
    }
    IEnumerator WaitForWindow3()
    {
        PublicVariables.Window3Closed = true;
        Windows_UI.SetActive(false);
        Window3_UI.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Walking.Play();
        yield return new WaitForSeconds(2f);
        Walking.Pause();
        yield return new WaitForSeconds(0.5f);
        ClosingCurtains.Play();
        yield return new WaitForSeconds(1f);
        Walking.Play();
        yield return new WaitForSeconds(2.5f);
        Walking.Pause();
        Window3_UI.SetActive(false);
        Window_Cam.gameObject.SetActive(false);
        office.gameObject.SetActive(true);
        camUp.SetActive(true);
        PublicVariables.PlayerAtWindows = false;
    }
    /*****************************************
    Switch From Office To Cams
    *****************************************/
    public void CamUp()
    {
        StartCoroutine(WaitForLookAtCams());
    }
    IEnumerator WaitForLookAtCams()
    {
        PublicVariables.PlayerInCams = true;
        camUp.SetActive(false);
        LookAtCams_UI.SetActive(true);
        
        yield return new WaitForSeconds(1f);
        CamStatic.Play();
        switch(CurrentCam)
        {
            case 1:
            //Cam 1
            Cam1OG();
            break;

            case 2:
            //Cam 2
            Cam2OG();
            break;

            case 3:
            //Cam 3
            Cam3OG();
            break;

            case 4:
            //Cam 4
            Cam4OG();
            break;

            case 5:
            //Cam 5A
            Cam5AOG();
            break;

            case 6:
            //Cam 5B
            Cam5BOG();
            break;

            case 7:
            //Cam 6
            Cam6OG();
            break;

            case 8:
            //Cam 7A
            Cam7AOG();
            break;

            case 9:
            //Cam 7B
            Cam7BOG();
            break;

            case 10:
            //Cam 8
            Cam8OG();
            break;

            case 11:
            //Cam1UG
            Cam1UG();
            break;

            case 12:
            //Cam2AUG
            Cam2AUG();
            break;

            case 13:
            //Cam2BUG
            Cam2BUG();
            break;

            case 14:
            //Cam3UG
            Cam3UG();
            break;

            case 15:
            //Cam4UG
            Cam4UG();
            break;

            case 16:
            //Cam5UG
            Cam5UG();
            break;
        }
        LookAtCams_UI.SetActive(false);
        camDown.SetActive(true);
    }
    /******************************************
    Switch From Cams To Office
    ******************************************/
    public void CamDown()
    {
        CamStatic.Pause();
        ChangeCam.Play();
        CamGlitch.Pause();
        StartCoroutine(WaitForLookOffCams());

        office.gameObject.SetActive(true);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);
        UG_CAM1_Cam.gameObject.SetActive(false);
        UG_CAM2A_Cam.gameObject.SetActive(false);
        UG_CAM2B_Cam.gameObject.SetActive(false);
        UG_CAM3_Cam.gameObject.SetActive(false);
        UG_CAM4_Cam.gameObject.SetActive(false);
        UG_CAM5_Cam.gameObject.SetActive(false);
        PublicVariables.PlayerInCams = false;

    }
    IEnumerator WaitForLookOffCams()
    {
        camDown.SetActive(false);
        LookOffCams_UI.SetActive(true);
        
        yield return new WaitForSeconds(1f);

        LookOffCams_UI.SetActive(false);
        camUp.SetActive(true);
    }

    public void MapToggleToUG()
    {
        Map_OG.SetActive(false);
        Map_UG.SetActive(true);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);
        switch(CurrentUG)
        {
            case 11:
            //Cam1UG
            Cam1UG();
            break;

            case 12:
            //Cam2AUG
            Cam2AUG();
            break;

            case 13:
            //Cam2BUG
            Cam2BUG();
            break;

            case 14:
            //Cam3UG
            Cam3UG();
            break;

            case 15:
            //Cam4UG
            Cam4UG();
            break;

            case 16:
            //Cam5UG
            Cam5UG();
            break;
        }
    }
    public void MapToggleToOG()
    {
        Map_UG.SetActive(false);
        Map_OG.SetActive(true);
        UG_CAM1_Cam.gameObject.SetActive(false);
        UG_CAM2A_Cam.gameObject.SetActive(false);
        UG_CAM2B_Cam.gameObject.SetActive(false);
        UG_CAM3_Cam.gameObject.SetActive(false);
        UG_CAM4_Cam.gameObject.SetActive(false);
        UG_CAM5_Cam.gameObject.SetActive(false);
        switch(CurrentOG)
        {
            case 1:
            //Cam 1
            Cam1OG();
            break;

            case 2:
            //Cam 2
            Cam2OG();
            break;

            case 3:
            //Cam 3
            Cam3OG();
            break;

            case 4:
            //Cam 4
            Cam4OG();
            break;

            case 5:
            //Cam 5A
            Cam5AOG();
            break;

            case 6:
            //Cam 5B
            Cam5BOG();
            break;

            case 7:
            //Cam 6
            Cam6OG();
            break;

            case 8:
            //Cam 7A
            Cam7AOG();
            break;

            case 9:
            //Cam 7B
            Cam7BOG();
            break;

            case 10:
            //Cam 8
            Cam8OG();
            break;
        }
    }
    /**********************************************************
        Cams OG
    **********************************************************/
    public void Cam1OG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentCam = 1;
        CurrentOG = 1;
        office.gameObject.SetActive(false);
        OG_CAM1_Cam.gameObject.SetActive(true);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);
    }
    public void Cam2OG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentCam = 2;
        CurrentOG = 2;
        office.gameObject.SetActive(false);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(true);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);
    }
    public void Cam3OG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentCam = 3;
        CurrentOG = 3;
        office.gameObject.SetActive(false);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(true);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);
    }
    public void Cam4OG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentCam = 4;
        CurrentOG = 4;
        office.gameObject.SetActive(false);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(true);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);
    }
    public void Cam5AOG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentCam = 5;
        CurrentOG = 5;
        office.gameObject.SetActive(false);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(true);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);
    }
    public void Cam5BOG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentCam = 6;
        CurrentOG = 6;
        office.gameObject.SetActive(false);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(true);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);
    }
    public void Cam6OG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentCam = 7;
        CurrentOG = 7;
        office.gameObject.SetActive(false);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(true);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);
    }
    public void Cam7AOG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentCam = 8;
        CurrentOG = 8;
        office.gameObject.SetActive(false);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(true);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(false);
    }
    public void Cam7BOG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentCam = 9;
        CurrentOG = 9;
        office.gameObject.SetActive(false);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(true);
        OG_CAM8_Cam.gameObject.SetActive(false);
    }
    public void Cam8OG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentCam = 10;
        CurrentOG = 10;
        office.gameObject.SetActive(false);
        OG_CAM1_Cam.gameObject.SetActive(false);
        OG_CAM2_Cam.gameObject.SetActive(false);
        OG_CAM3_Cam.gameObject.SetActive(false);
        OG_CAM4_Cam.gameObject.SetActive(false);
        OG_CAM5A_Cam.gameObject.SetActive(false);
        OG_CAM5B_Cam.gameObject.SetActive(false);
        OG_CAM6_Cam.gameObject.SetActive(false);
        OG_CAM7A_Cam.gameObject.SetActive(false);
        OG_CAM7B_Cam.gameObject.SetActive(false);
        OG_CAM8_Cam.gameObject.SetActive(true);
    }
    /*********************************************
    Cams UG
    *********************************************/
    public void Cam1UG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentUG = 11;
        CurrentCam = 11;
        UG_CAM1_Cam.gameObject.SetActive(true);
        UG_CAM2A_Cam.gameObject.SetActive(false);
        UG_CAM2B_Cam.gameObject.SetActive(false);
        UG_CAM3_Cam.gameObject.SetActive(false);
        UG_CAM4_Cam.gameObject.SetActive(false);
        UG_CAM5_Cam.gameObject.SetActive(false);
    }
    public void Cam2AUG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentUG = 12;
        CurrentCam = 12;
        UG_CAM1_Cam.gameObject.SetActive(false);
        UG_CAM2A_Cam.gameObject.SetActive(true);
        UG_CAM2B_Cam.gameObject.SetActive(false);
        UG_CAM3_Cam.gameObject.SetActive(false);
        UG_CAM4_Cam.gameObject.SetActive(false);
        UG_CAM5_Cam.gameObject.SetActive(false);
    }
    public void Cam2BUG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentUG = 13;
        CurrentCam = 13;
        UG_CAM1_Cam.gameObject.SetActive(false);
        UG_CAM2A_Cam.gameObject.SetActive(false);
        UG_CAM2B_Cam.gameObject.SetActive(true);
        UG_CAM3_Cam.gameObject.SetActive(false);
        UG_CAM4_Cam.gameObject.SetActive(false);
        UG_CAM5_Cam.gameObject.SetActive(false);
    }
    public void Cam3UG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentUG = 14;
        CurrentCam = 14;
        UG_CAM1_Cam.gameObject.SetActive(false);
        UG_CAM2A_Cam.gameObject.SetActive(false);
        UG_CAM2B_Cam.gameObject.SetActive(false);
        UG_CAM3_Cam.gameObject.SetActive(true);
        UG_CAM4_Cam.gameObject.SetActive(false);
        UG_CAM5_Cam.gameObject.SetActive(false);
    }
    public void Cam4UG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentUG = 15;
        CurrentCam = 15;
        UG_CAM1_Cam.gameObject.SetActive(false);
        UG_CAM2A_Cam.gameObject.SetActive(false);
        UG_CAM2B_Cam.gameObject.SetActive(false);
        UG_CAM3_Cam.gameObject.SetActive(false);
        UG_CAM4_Cam.gameObject.SetActive(true);
        UG_CAM5_Cam.gameObject.SetActive(false);
    }
    public void Cam5UG()
    {
        CamBeep.Play();
        ChangeCam.Play();
        increaseSaturation.ChangeTransparencyshort();
        CurrentUG = 16;
        CurrentCam = 16;
        UG_CAM1_Cam.gameObject.SetActive(false);
        UG_CAM2A_Cam.gameObject.SetActive(false);
        UG_CAM2B_Cam.gameObject.SetActive(false);
        UG_CAM3_Cam.gameObject.SetActive(false);
        UG_CAM4_Cam.gameObject.SetActive(false);
        UG_CAM5_Cam.gameObject.SetActive(true);
    }
     // Update is called once per frame
    void Update()
    {
        
    }
}

