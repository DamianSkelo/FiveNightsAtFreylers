using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatoMoveBack : MonoBehaviour
{
    public static int PreviousKatoAI;
    public static bool LookingAtKato = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(LookingAtKato == true && PublicVariables.PlayerInCams == true)
        {
            KatoRoutine.KatoAI = -1;
        }
        else
        {
            KatoRoutine.KatoAI = PreviousKatoAI;
        }
    }
}
