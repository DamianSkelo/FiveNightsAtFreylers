using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NightText12AM : MonoBehaviour
{
    public Text NightText;
    // Start is called before the first frame update
    void Start()
    {
        NightText.text = "Night " + CurrentNightScript.CurrentNight;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
