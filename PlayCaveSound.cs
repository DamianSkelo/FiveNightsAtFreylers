using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCaveSound : MonoBehaviour
{
    float WaitingTime;
    public AudioSource CaveSound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayCaveSoos());
    }
    IEnumerator PlayCaveSoos()
    {
        WaitingTime = Random.Range(180f, 380f);
        yield return new WaitForSeconds(WaitingTime);
        CaveSound.Play();
        WaitingTime = Random.Range(180f, 380f);
        yield return new WaitForSeconds(WaitingTime);
        CaveSound.Play();
        WaitingTime = Random.Range(180f, 380f);
        yield return new WaitForSeconds(WaitingTime);
        CaveSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
