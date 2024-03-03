using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public GameObject BGFreyler;
    public GameObject BGSchatto;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(backgrounds());
        BGFreyler.SetActive(true);
        BGSchatto.SetActive(false);
    }
    
    IEnumerator backgrounds()
    {
        BGFreyler.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        BGSchatto.SetActive(true);
        BGFreyler.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        BGFreyler.SetActive(true);
        BGSchatto.SetActive(false);
        yield return new WaitForSeconds(3f);
        BGSchatto.SetActive(true);
        BGFreyler.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        BGFreyler.SetActive(true);
        BGSchatto.SetActive(false);
        yield return new WaitForSeconds(1.1f);
        BGFreyler.SetActive(false);
        BGSchatto.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        BGFreyler.SetActive(true);
        BGSchatto.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(backgrounds());
    }
}
