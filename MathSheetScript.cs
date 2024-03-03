using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MathSheetScript : MonoBehaviour
{
    public Text MathProblem;
    public Text Answer1;
    public Text Answer2;
    public Text Answer3;
    public Text Answer4;
    public Text StreakCounter;
    
    int ChosenSound;
    public AudioSource Writing1;
    public AudioSource Writing2;
    public AudioSource Writing3;
    public AudioSource Writing4;
    int CorrectAnswer;
    bool AnsweredCorrect;
    int Number1;
    int Number2;
    int NumForCal;
    int MaxNumber;
    float Solution;
    float RandomAnswers = 30f;
    float x1 = 0;
    float x2 = 0;
    float x3 = 0;

    public Toggle Toggle1;
    public Toggle Toggle2;
    public Toggle Toggle3;
    public Toggle Toggle4;
    
    public static int Streak = 0;
    // Start is called before the first frame update
    void Start()
    {
        StreakCounter.text = "Answer streak: " + Streak;
        AufgabenStellen();
    }
    public void AufgabenStellen()
    {
        /****************************************************
        Schwierigkeit der Aufgaben anhand der nacht festlegen
        ****************************************************/
        switch(CurrentNightScript.CurrentNight)
        {
            case 1:
                MaxNumber = 51;
                Number1 = Random.Range(1, MaxNumber);
                Number2 = Random.Range(1, MaxNumber);
                NumForCal = Random.Range(1, 3);
                switch(NumForCal)
                {
                    case 1:
                        MathProblem.text = Number1 + " + "+  Number2;
                        Solution = Number1 + Number2;
                    break;
                    case 2:
                        MathProblem.text = Number1 + " - " + Number2;
                        Solution = Number1 - Number2;
                    break;
                }
            break;

            case 2:
                MaxNumber = 51;
                Number1 = Random.Range(1, MaxNumber);
                Number2 = Random.Range(1, MaxNumber);
                NumForCal = Random.Range(1, 3);
                switch(NumForCal)
                {
                    case 1:
                        MathProblem.text = Number1 + " + " + Number2;
                        Solution = Number1 + Number2;
                    break;
                    case 2:
                        MathProblem.text = Number1 + " - " + Number2;
                        Solution = Number1 - Number2;
                    break;
                }
            break;

            case 3:
                MaxNumber = 101;
                Number1 = Random.Range(1, MaxNumber);
                Number2 = Random.Range(1, MaxNumber);
                NumForCal = Random.Range(1, 4);
                switch(NumForCal)
                {
                    case 1:
                        MathProblem.text = Number1 +  " + " + Number2;
                        Solution = Number1 + Number2;
                    break;
                    case 2:
                        MathProblem.text = Number1 + " - " + Number2;
                        Solution = Number1 - Number2;
                    break;
                    case 3:
                        Number1 = Random.Range(1,20);
                        Number2 = Random.Range(1,10);
                        MathProblem.text = Number1 + " x "+  Number2;
                        Solution = Number1 * Number2;
                    break;
                }
            break;

            case 4:
                MaxNumber = 101;
                Number1 = Random.Range(1, MaxNumber);
                Number2 = Random.Range(1, MaxNumber);
                NumForCal = Random.Range(1, 4);
                switch(NumForCal)
                {
                    case 1:
                        MathProblem.text = Number1 +  " + " + Number2;
                        Solution = Number1 + Number2;
                    break;
                    case 2:
                        MathProblem.text = Number1 + " - " + Number2;
                        Solution = Number1 - Number2;
                    break;
                    case 3:
                        Number1 = Random.Range(1,20);
                        Number2 = Random.Range(1,10);
                        MathProblem.text = Number1 + " x " + Number2;
                        Solution = Number1 * Number2;
                    break;
                }
            break;

            case 5:
                MaxNumber = 101;
                Number1 = Random.Range(1, MaxNumber);
                Number2 = Random.Range(1, MaxNumber);
                NumForCal = Random.Range(1, 5);
                switch(NumForCal)
                {
                    case 1:
                        MathProblem.text = Number1 + " + " + Number2;
                        Solution = Number1 + Number2;
                    break;
                    case 2:
                        MathProblem.text = Number1 + " - " + Number2;
                        Solution = Number1 - Number2;
                    break;
                    case 3:
                        Number1 = Random.Range(1,20);
                        Number2 = Random.Range(1,10);
                        MathProblem.text = Number1 +" x " + Number2;
                        Solution = Number1 * Number2;
                    break;
                    case 4:
                        Number2 = Random.Range(1, 10);
                        MathProblem.text = Number1 +  " / " + Number2;
                        Solution = Number1 / Number2;
                    break;
                }
            break;

        }
        CorrectAnswer = Random.Range(1, 5);
        switch(CorrectAnswer)
        {
                case 1:
                    do
                    {
                        x1 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                        x2 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                        x3 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                        if(NumForCal != 4)
                        {
                            x1 = Mathf.Round(x1 * 1.0f);
                            x2 = Mathf.Round(x2 * 1.0f);
                            x3 = Mathf.Round(x3 * 1.0f);
                        }
                        else
                        {
                            Solution = Mathf.Round(Solution * 100.0f) * 0.01f;
                            x1 = Mathf.Round(x1 * 100.0f) * 0.01f;
                            x2 = Mathf.Round(x2 * 100.0f) * 0.01f;
                            x3 = Mathf.Round(x3 * 100.0f) * 0.01f;
                        }
                    }
                    while(x1 == Solution || x2 == Solution || x3 == Solution);
                    Answer1.text = "" + Solution;
                    Answer2.text = "" + x1;
                    Answer3.text = "" + x2;
                    Answer4.text = "" + x3;
                break;
                case 2:
                do
                {
                    x1 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                    x2 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                    x3 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                    if(NumForCal != 4)
                    {
                        x1 = Mathf.Round(x1 * 1.0f);
                        x2 = Mathf.Round(x2 * 1.0f);
                        x3 = Mathf.Round(x3 * 1.0f);
                    }
                    else
                    {
                        Solution = Mathf.Round(Solution * 100.0f) * 0.01f;
                        x1 = Mathf.Round(x1 * 100.0f) * 0.01f;
                        x2 = Mathf.Round(x2 * 100.0f) * 0.01f;
                        x3 = Mathf.Round(x3 * 100.0f) * 0.01f;
                    }
                    Answer1.text = "" + x1;
                    Answer2.text = "" + Solution;
                    Answer3.text = "" + x2;
                    Answer4.text = "" + x3;
                } while(x1 == Solution || x2 == Solution || x3 == Solution);
                break;
                case 3:
                do
                {
                    x1 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                    x2 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                    x3 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                    if(NumForCal != 4)
                    {
                        x1 = Mathf.Round(x1 * 1.0f);
                        x2 = Mathf.Round(x2 * 1.0f);
                        x3 = Mathf.Round(x3 * 1.0f);
                    }
                    else
                    {
                        Solution = Mathf.Round(Solution * 100.0f) * 0.01f;
                        x1 = Mathf.Round(x1 * 100.0f) * 0.01f;
                        x2 = Mathf.Round(x2 * 100.0f) * 0.01f;
                        x3 = Mathf.Round(x3 * 100.0f) * 0.01f;
                    }
                    Answer1.text = "" + x1;
                    Answer2.text = "" + x2;
                    Answer3.text = "" + Solution;
                    Answer4.text = "" + x3;
                } while(x1 == Solution || x2 == Solution || x3 == Solution);
                break;
                case 4:
                do
                {
                    x1 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                    x2 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                    x3 = Random.Range(Solution - RandomAnswers, Solution + RandomAnswers);
                    if(NumForCal != 4)
                    {
                        x1 = Mathf.Round(x1);
                        x2 = Mathf.Round(x2);
                        x3 = Mathf.Round(x3);
                    }
                    else
                    {
                        Solution = Mathf.Round(Solution * 100.0f) * 0.01f;
                        x1 = Mathf.Round(x1 * 100.0f) * 0.01f;
                        x2 = Mathf.Round(x2 * 100.0f) * 0.01f;
                        x3 = Mathf.Round(x3 * 100.0f) * 0.01f;
                    }
                    Answer1.text = "" + x1;
                    Answer2.text = "" + x2;
                    Answer3.text = "" + x3;
                    Answer4.text = "" + Solution;
                } while(x1 == Solution || x2 == Solution || x3 == Solution);
                break;
        }
    }

    /*****************************************************
    Antwort des Spielers auf ihre Richtigkeit ueberpruefen
    *****************************************************/
    public void AntwortChecken()
    {
        ChosenSound = Random.Range(1, 5);
            switch (ChosenSound)
            {
                case 1:
                Writing1.Play();
                break;
                case 2:
                Writing2.Play();
                break;
                case 3:
                Writing3.Play();
                break;
                case 4:
                Writing4.Play();
                break;
            }
        switch (CorrectAnswer)
        {
            case 1:
            if(Toggle1.isOn == true)
            {
                AnsweredCorrect = true;
            }
            else
            {
                AnsweredCorrect = false;
            }
            break;
            case 2:
            if(Toggle2.isOn == true)
            {
                AnsweredCorrect = true;
            }
            else
            {
                AnsweredCorrect = false;
            }
            break;
            case 3:
            if(Toggle3.isOn == true)
            {
                AnsweredCorrect = true;
            }
            else
            {
                AnsweredCorrect = false;
            }
            break;
            case 4:
            if(Toggle4.isOn == true)
            {
                AnsweredCorrect = true;
            }
            else
            {
                AnsweredCorrect = false;
            }
            break;
        }
        Debug.Log(AnsweredCorrect);
        if(AnsweredCorrect == true)
        {
            if(CurrentNightScript.CurrentNight != 1 && CurrentNightScript.CurrentNight != 2){Killstreaks.KillstreakStreak ++;}
            if(Streak < 0)
            {
                Streak = 0;
            }
            else
            {
                if (Streak <5)
                {Streak++;}
            }
        }
        else
        {
            Killstreaks.KillstreakStreak = 0;
            if(Streak > 0)
            {
                Streak = 0;
            }
            else
            {
                Streak --;
            }
        }
        AufgabenStellen();
    }

    void Update()
    {
        StreakCounter.text = "Answer streak: " + Streak + "/5";
    }
}

