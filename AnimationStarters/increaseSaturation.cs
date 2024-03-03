using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class increaseSaturation : MonoBehaviour
{
    public RawImage CameraStatic;
    public AudioSource CameraGlitch;

    // Start is called before the first frame update
    void Start()
    {
        CameraStatic.gameObject.SetActive(false);
    }
    public void ChangeTransparency()
    {
        StartCoroutine(StaticSaturation());
    }
    IEnumerator StaticSaturation()
    {
        if (PublicVariables.PlayerInCams == true) {CameraGlitch.Play();}
        Debug.Log("Changed Transparency");
        CameraStatic.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        CameraStatic.gameObject.SetActive(false);
        Debug.Log("Changed back Transparency");
        CameraGlitch.Pause();
    }

    public void ChangeTransparencyshort()
    {
        StartCoroutine(Activate());
    }
    IEnumerator Activate()
    {
        CameraStatic.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        CameraStatic.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
