using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatoImages : MonoBehaviour
{
    public GameObject KatoPos1;
    public GameObject KatoPos2;
    public GameObject KatoPos3;
    public GameObject KatoPos4;
    public GameObject KatoPos5;

    public GameObject Uavk1;
    public GameObject Uavk2;
    public GameObject Uavk3;
    public GameObject Uavk4;
    public GameObject Uavk5;
    // Start is called before the first frame update
    void Start()
    {
        KatoMoveBack.LookingAtKato = false;
        KatoPos1.SetActive(false);
        KatoPos2.SetActive(false);
        KatoPos3.SetActive(false);
        KatoPos4.SetActive(false);
        KatoPos5.SetActive(false);

        Uavk1.SetActive(false);
        Uavk2.SetActive(false);
        Uavk3.SetActive(false);
        Uavk4.SetActive(false);
        Uavk5.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(KatoMoveBack.PreviousKatoAI > 0)
        {
            if (KatoMovement.KatoPos == 1 && Cameras.CurrentCam == 11)
            {
                KatoMoveBack.LookingAtKato = true;
                KatoPos1.SetActive(true);
                KatoPos2.SetActive(false);
                KatoPos3.SetActive(false);
                KatoPos4.SetActive(false);
                KatoPos5.SetActive(false);
            }
            else if (KatoMovement.KatoPos == 2 && Cameras.CurrentCam == 12)
            {
                KatoMoveBack.LookingAtKato = true;
                KatoPos1.SetActive(false);
                KatoPos2.SetActive(true);
                KatoPos3.SetActive(false);
                KatoPos4.SetActive(false);
                KatoPos5.SetActive(false);
            }
            else if (KatoMovement.KatoPos == 3 && Cameras.CurrentCam == 13)
            {
                KatoMoveBack.LookingAtKato = true;
                KatoPos1.SetActive(false);
                KatoPos2.SetActive(false);
                KatoPos3.SetActive(true);
                KatoPos4.SetActive(false);
                KatoPos5.SetActive(false);
            }
            else if (KatoMovement.KatoPos == 4 && Cameras.CurrentCam == 15)
            {
                KatoMoveBack.LookingAtKato = true;
                KatoPos1.SetActive(false);
                KatoPos2.SetActive(false);
                KatoPos3.SetActive(false);
                KatoPos4.SetActive(true);
                KatoPos5.SetActive(false);
            }
            else if (KatoMovement.KatoPos == 5 && Cameras.CurrentCam == 10)
            {
                KatoMoveBack.LookingAtKato = true;
                KatoPos1.SetActive(false);
                KatoPos2.SetActive(false);
                KatoPos3.SetActive(false);
                KatoPos4.SetActive(false);
                KatoPos5.SetActive(true);
            }
            else
            {
                KatoMoveBack.LookingAtKato = false;
                KatoPos1.SetActive(false);
                KatoPos2.SetActive(false);
                KatoPos3.SetActive(false);
                KatoPos4.SetActive(false);
                KatoPos5.SetActive(false);
            }
        }
        else
        {
            KatoMoveBack.LookingAtKato = false;
            KatoPos1.SetActive(false);
            KatoPos2.SetActive(false);
            KatoPos3.SetActive(false);
            KatoPos4.SetActive(false);
            KatoPos5.SetActive(false);
        }
        
        if(KatoMoveBack.PreviousKatoAI > 0)
        {
            if (KatoMovement.KatoPos == 1)
            {
                Uavk1.SetActive(true);
                Uavk2.SetActive(false);
                Uavk3.SetActive(false);
                Uavk4.SetActive(false);
                Uavk5.SetActive(false);
            }
            else if (KatoMovement.KatoPos == 2)
            {
                Uavk1.SetActive(false);
                Uavk2.SetActive(true);
                Uavk3.SetActive(false);
                Uavk4.SetActive(false);
                Uavk5.SetActive(false);
            }
            else if (KatoMovement.KatoPos == 3)
            {
                Uavk1.SetActive(false);
                Uavk2.SetActive(false);
                Uavk3.SetActive(true);
                Uavk4.SetActive(false);
                Uavk5.SetActive(false);
            }
            else if (KatoMovement.KatoPos == 4)
            {
                Uavk1.SetActive(false);
                Uavk2.SetActive(false);
                Uavk3.SetActive(false);
                Uavk4.SetActive(true);
                Uavk5.SetActive(false);
            }
            else if (KatoMovement.KatoPos == 5)
            {
                Uavk1.SetActive(false);
                Uavk2.SetActive(false);
                Uavk3.SetActive(false);
                Uavk4.SetActive(false);
                Uavk5.SetActive(true);
            }
            else
            {
                Uavk1.SetActive(false);
                Uavk2.SetActive(false);
                Uavk3.SetActive(false);
                Uavk4.SetActive(false);
                Uavk5.SetActive(false);
            }
        }

    }
}
