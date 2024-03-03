using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToOffice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadOffice());
    }
    IEnumerator LoadOffice()
    {
        yield return new WaitForSeconds(8.5f);
        SceneManager.LoadScene("Office");
    }
}
