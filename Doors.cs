using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;

public class Doors : MonoBehaviour
{
    public VideoPlayer Door1;
    public VideoPlayer Door2;
    public AudioSource DoorClosing;
    public AudioSource DoorOpening;
    public Camera Office;
    public GameObject camUp;
    public GameObject Door1_UI;
    public GameObject Door2_UI;
    public AudioSource Walking;
    // Start is called before the first frame update
    void Start()
    {
        /*****************************
        Preloading Videos
        *****************************/
        Door1.Prepare();
        Door2.Prepare();
    }
    public void StartDoor1()
    {
        StartCoroutine(AnimDoors());
    }
    IEnumerator AnimDoors()
    {
        camUp.SetActive(false);
        Door1_UI.SetActive(true);
        Door1.Play();
        Walking.Play();
        yield return new WaitForSeconds(2.5f);
        Walking.Pause();
        yield return new WaitForSeconds(0.8f);
        DoorClosing.Play();
        yield return new WaitForSeconds(0.7f);
        while(Input.GetMouseButton(0))
        {
            PublicVariables.DoorClosed = true;
            yield return new WaitForSeconds(0.1f);
        }
        PublicVariables.DoorClosed = false;
        Door1_UI.SetActive(false);
        Door2.Play();
        Door2_UI.SetActive(true);
        DoorOpening.Play();
        yield return new WaitForSeconds(0.8f);
        Walking.Play();
        yield return new WaitForSeconds(2.2f);
        Walking.Pause();
        yield return new WaitForSeconds(1f);
        Door2_UI.SetActive(false);
        camUp.SetActive(true);
        Door1.frame = 0;
        Door2.frame = 0;
        Door1.Prepare();
        Door2.Prepare();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
