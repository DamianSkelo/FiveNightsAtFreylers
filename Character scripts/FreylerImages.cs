using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class FreylerImages : MonoBehaviour
{
    public static bool LookingAtFreyler;
    
    public GameObject FreylerImgs;
    public GameObject FREPos1;
    public GameObject FREPos2;
    public GameObject FREPos3;
    public GameObject FREPos4;
    public GameObject FREPos5;
    public GameObject FREPos6;
    public GameObject FREPos7;
    public GameObject FREPos8;
    public GameObject FREPos9;

    public GameObject Uavf1;
    public GameObject Uavf2;
    public GameObject Uavf3;
    public GameObject Uavf4;
    public GameObject Uavf5;
    public GameObject Uavf6;
    public GameObject Uavf7;
    public GameObject Uavf8;
    public GameObject Uavf9;

    public Camera Cam1;
    // Start is called before the first frame update
    void Start()
    {
        FREPos1.SetActive(false);
        FREPos2.SetActive(false);
        FREPos3.SetActive(false);
        FREPos4.SetActive(false);
        FREPos5.SetActive(false);
        FREPos6.SetActive(false);
        FREPos7.SetActive(false);
        FREPos8.SetActive(false);
        FREPos9.SetActive(false);

        Uavf1.SetActive(false);
        Uavf2.SetActive(false);
        Uavf3.SetActive(false);
        Uavf4.SetActive(false);
        Uavf5.SetActive(false);
        Uavf6.SetActive(false);
        Uavf7.SetActive(false);
        Uavf8.SetActive(false);
        Uavf9.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Freyler.FreylerPos == 1 && Cameras.CurrentCam == 2)
        {
            LookingAtFreyler = true;
            FREPos1.SetActive(true);
            FREPos2.SetActive(false);
            FREPos3.SetActive(false);
            FREPos4.SetActive(false);
            FREPos5.SetActive(false);
            FREPos6.SetActive(false);
            FREPos7.SetActive(false);
            FREPos8.SetActive(false);
            FREPos9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 2 && Cameras.CurrentCam == 3)
        {
            LookingAtFreyler = true;
            FREPos1.SetActive(false);
            FREPos2.SetActive(false);
            FREPos3.SetActive(false);
            FREPos4.SetActive(false);
            FREPos5.SetActive(false);
            FREPos6.SetActive(false);
            FREPos7.SetActive(false);
            FREPos8.SetActive(false);
            FREPos9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 3 && Cameras.CurrentCam == 4)
        {
            LookingAtFreyler = true;
            FREPos1.SetActive(false);
            FREPos2.SetActive(false);
            FREPos3.SetActive(true);
            FREPos4.SetActive(false);
            FREPos5.SetActive(false);
            FREPos6.SetActive(false);
            FREPos7.SetActive(false);
            FREPos8.SetActive(false);
            FREPos9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 4 && Cameras.CurrentCam == 5)
        {
            LookingAtFreyler = true;
            FREPos1.SetActive(false);
            FREPos2.SetActive(false);
            FREPos3.SetActive(false);
            FREPos4.SetActive(true);
            FREPos5.SetActive(false);
            FREPos6.SetActive(false);
            FREPos7.SetActive(false);
            FREPos8.SetActive(false);
            FREPos9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 5 && Cameras.CurrentCam == 6)
        {
            LookingAtFreyler = true;
            FREPos1.SetActive(false);
            FREPos2.SetActive(false);
            FREPos3.SetActive(false);
            FREPos4.SetActive(false);
            FREPos5.SetActive(true);
            FREPos6.SetActive(false);
            FREPos7.SetActive(false);
            FREPos8.SetActive(false);
            FREPos9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 6 && Cameras.CurrentCam == 7)
        {
            LookingAtFreyler = true;
            FREPos1.SetActive(false);
            FREPos2.SetActive(false);
            FREPos3.SetActive(false);
            FREPos4.SetActive(false);
            FREPos5.SetActive(false);
            FREPos6.SetActive(true);
            FREPos7.SetActive(false);
            FREPos8.SetActive(false);
            FREPos9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 7 && Cameras.CurrentCam == 8)
        {
            LookingAtFreyler = true;
            FREPos1.SetActive(false);
            FREPos2.SetActive(false);
            FREPos3.SetActive(false);
            FREPos4.SetActive(false);
            FREPos5.SetActive(false);
            FREPos6.SetActive(false);
            FREPos7.SetActive(true);
            FREPos8.SetActive(false);
            FREPos9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 8 && Cameras.CurrentCam == 1)
        {
            LookingAtFreyler = true;
            FREPos1.SetActive(false);
            FREPos2.SetActive(false);
            FREPos3.SetActive(false);
            FREPos4.SetActive(false);
            FREPos5.SetActive(false);
            FREPos6.SetActive(false);
            FREPos7.SetActive(false);
            FREPos8.SetActive(true);
            FREPos9.SetActive(false);
        }
        else
        {
            LookingAtFreyler = false;
            FREPos1.SetActive(false);
            FREPos2.SetActive(false);
            FREPos3.SetActive(false);
            FREPos4.SetActive(false);
            FREPos5.SetActive(false);
            FREPos6.SetActive(false);
            FREPos7.SetActive(false);
            FREPos8.SetActive(false);
            FREPos9.SetActive(false);
        }






        if (Freyler.FreylerPos == 1)
        {
            Uavf1.SetActive(true);
            Uavf2.SetActive(false);
            Uavf3.SetActive(false);
            Uavf4.SetActive(false);
            Uavf5.SetActive(false);
            Uavf6.SetActive(false);
            Uavf7.SetActive(false);
            Uavf8.SetActive(false);
            Uavf9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 2)
        {
            Uavf1.SetActive(false);
            Uavf2.SetActive(true);
            Uavf3.SetActive(false);
            Uavf4.SetActive(false);
            Uavf5.SetActive(false);
            Uavf6.SetActive(false);
            Uavf7.SetActive(false);
            Uavf8.SetActive(false);
            Uavf9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 3)
        {
            Uavf1.SetActive(false);
            Uavf2.SetActive(false);
            Uavf3.SetActive(true);
            Uavf4.SetActive(false);
            Uavf5.SetActive(false);
            Uavf6.SetActive(false);
            Uavf7.SetActive(false);
            Uavf8.SetActive(false);
            Uavf9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 4)
        {
            Uavf1.SetActive(false);
            Uavf2.SetActive(false);
            Uavf3.SetActive(false);
            Uavf4.SetActive(true);
            Uavf5.SetActive(false);
            Uavf6.SetActive(false);
            Uavf7.SetActive(false);
            Uavf8.SetActive(false);
            Uavf9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 5)
        {
            Uavf1.SetActive(false);
            Uavf2.SetActive(false);
            Uavf3.SetActive(false);
            Uavf4.SetActive(false);
            Uavf5.SetActive(true);
            Uavf6.SetActive(false);
            Uavf7.SetActive(false);
            Uavf8.SetActive(false);
            Uavf9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 6)
        {
            Uavf1.SetActive(false);
            Uavf2.SetActive(false);
            Uavf3.SetActive(false);
            Uavf4.SetActive(false);
            Uavf5.SetActive(false);
            Uavf6.SetActive(true);
            Uavf7.SetActive(false);
            Uavf8.SetActive(false);
            Uavf9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 7)
        {
            Uavf1.SetActive(false);
            Uavf2.SetActive(false);
            Uavf3.SetActive(false);
            Uavf4.SetActive(false);
            Uavf5.SetActive(false);
            Uavf6.SetActive(false);
            Uavf7.SetActive(true);
            Uavf8.SetActive(false);
            Uavf9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 8)
        {
            Uavf1.SetActive(false);
            Uavf2.SetActive(false);
            Uavf3.SetActive(false);
            Uavf4.SetActive(false);
            Uavf5.SetActive(false);
            Uavf6.SetActive(false);
            Uavf7.SetActive(false);
            Uavf8.SetActive(true);
            Uavf9.SetActive(false);
        }
        else if (Freyler.FreylerPos == 9)
        {
            Uavf1.SetActive(false);
            Uavf2.SetActive(false);
            Uavf3.SetActive(false);
            Uavf4.SetActive(false);
            Uavf5.SetActive(false);
            Uavf6.SetActive(false);
            Uavf7.SetActive(false);
            Uavf8.SetActive(false);
            Uavf9.SetActive(true);
        }
    }
}

