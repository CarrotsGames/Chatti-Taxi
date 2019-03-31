using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DialogueManager : MonoBehaviour {

    public float TipAmount;
    public float Tip;
    public GameObject[] Events;
    private int EventSteps = 0;
    public int Val;
    private Events EventScript;

    private void Start()
    {
        EventScript = GetComponent<Events>();
    }
    public void Dialogue(int ButtonsPress)
    {

        switch (ButtonsPress)
        {
            case  1:
                 
                 if (EventScript.NegativeChange)
                 {
                    Tip += 0;

                }
                else
                {
                    Tip += TipAmount;
                }
                 
                break;
            case 2:

                if (EventScript.NegativeChange)
                {
                    Tip += 0;

                }
                else
                {
                    Tip += TipAmount / 2;
                }
                break;
            case 3:
                if (EventScript.NegativeChange)
                {
                    Tip += TipAmount / TipAmount - 2;
                }
                else
                {
                    Tip += TipAmount / TipAmount;
                }
                break;

        }

        Events[EventSteps].SetActive(false);
        EventSteps += 1;
        Events[EventSteps].SetActive(true);
        Val += 1;


    }
}
