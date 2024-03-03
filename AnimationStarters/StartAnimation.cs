using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Sprites;

public class StartAnimation : MonoBehaviour
{
    public VideoPlayer LookAtCams;
    public VideoPlayer LookOffCams;
    public VideoPlayer LookAtSheet;
    public VideoPlayer LookOffSheet;
    public VideoPlayer RunToWindows;
    public VideoPlayer Window1Vid;
    public VideoPlayer Window2Vid;
    public VideoPlayer Window3Vid;
    public VideoPlayer Cam_Noise;

    // Start is called before the first frame update
    void Start()
    {
        /*****************************
        Preloading Videos
        *****************************/
        LookAtCams.Prepare();
        LookOffCams.Prepare();
        LookAtSheet.Prepare();
        LookOffSheet.Prepare();
        RunToWindows.Prepare();
        Window1Vid.Prepare();
        Window2Vid.Prepare();
        Window3Vid.Prepare();  
        Cam_Noise.Prepare();      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*****************************
    Cameras
    *****************************/
    public void StartLookAtCams()
    {
        StartCoroutine(AnimLookAtCams());
    }
    IEnumerator AnimLookAtCams()
    {
        LookAtCams.Play();
        yield return new WaitForSeconds(1.5f);
        LookAtCams.frame = 0;
        LookAtCams.Prepare();

    }

    public void StartLookOffCams()
    {
        StartCoroutine(AnimLookOffCams());
    }
    IEnumerator AnimLookOffCams()
    {
        LookOffCams.Play();
        yield return new WaitForSeconds(1.5f);
        LookOffCams.frame = 0;
        LookOffCams.Prepare();
    }

    /*****************************
    Sheet
    *****************************/
    public void StartLookAtSheet()
    {
        StartCoroutine(AnimLookAtSheet());
    }
    IEnumerator AnimLookAtSheet()
    {
        LookAtSheet.Play();
        yield return new WaitForSeconds(2f);
        LookAtSheet.frame = 0;
        LookAtSheet.Prepare();
    }
    public void StartLookOffSheet()
    {
        StartCoroutine(AnimLookOffSheet());
    }
    IEnumerator AnimLookOffSheet()
    {
        LookOffSheet.Play();
        yield return new WaitForSeconds(1.6f);
        LookOffSheet.frame = 0;
        LookOffSheet.Prepare();
    }
    /*****************************
    Windows
    *****************************/
    public void StartRunToWindows()
    {
        StartCoroutine(AnimRunToWindows());
    }
    IEnumerator AnimRunToWindows()
    {
        RunToWindows.Play();
        yield return new WaitForSeconds(4.5f);
        RunToWindows.frame = 0;
        RunToWindows.Prepare();
    }
    public void StartWindow1()
    {
        StartCoroutine(AnimWindow1());
    }
    IEnumerator AnimWindow1()
    {
        Window1Vid.Play();
        yield return new WaitForSeconds(7f);
        Window1Vid.frame = 0;
        Window1Vid.Prepare();
    }
    public void StartWindow2()
    {
        StartCoroutine(AnimWindow2());
    }
    IEnumerator AnimWindow2()
    {
        Window2Vid.Play();
        yield return new WaitForSeconds(8.5f);
        Window2Vid.frame = 0;
        Window2Vid.Prepare();
    }
    public void StartWindow3()
    {
        StartCoroutine(AnimWindow3());
    }
    IEnumerator AnimWindow3()
    {
        Window3Vid.Play();
        yield return new WaitForSeconds(7.5f);
        Window3Vid.frame = 0;
        Window3Vid.Prepare();
    }
}
