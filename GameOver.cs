using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject ContinueButton;
    public AudioSource GameOverSound;
    // Start is called before the first frame update
    void Start()
    {
        ContinueButton.SetActive(false);
        StartCoroutine(SwitchScene());
    }
    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(3f);
        ContinueButton.SetActive(true);
        yield return new WaitForSeconds(53f);
        SceneManager.LoadScene("MainMenu");
    }
    public void NextScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
