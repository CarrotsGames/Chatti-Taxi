using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public float TipAmount;
    public float Tip;
    public GameObject[] Events;
    private int EventSteps = 0;
    public int Val;
    private Events EventScript;
    public string[] CustomerDialogue;
    public string[] CustomerDialogueNegative;
    public string[] CustomerDialogueComedy;
    int Progress;
    public Text TestText;

    private void Start()
    {
        EventScript = GetComponent<Events>();
    }
    public void Dialogue(int ButtonsPress)
    {
     //   Button CustomerBox = Events[Val].transform.GetChild(3).GetComponentInChildren<Button>();

        switch (ButtonsPress)
        {
            case 1:

                if (EventScript.NegativeChange)
                {
                    Tip += 0;
                 //   CustomerBox.GetComponentInChildren<Text>().text = 
                    TestText.text = CustomerDialogueNegative[0 + Progress];
                }
                else
                {
                    Tip += TipAmount;
                    TestText.text = CustomerDialogue[0 + Progress];

                }

                break;
            case 2:

                if (EventScript.NegativeChange)
                {
                    Tip += 0;
                    TestText.text = CustomerDialogueNegative[1 + Progress];

                }
                else
                {
                    Tip += TipAmount / 2;
                    TestText.text = CustomerDialogue[1 + Progress];

                }
                break;
            case 3:
                if (EventScript.NegativeChange)
                {
                    Tip += TipAmount / TipAmount - 2;
                    TestText.text = CustomerDialogueNegative[2 + Progress];

                }
                else
                {
                    Tip += TipAmount / TipAmount;
                    TestText.text = CustomerDialogue[2 + Progress];

                }
                break;

        }
    
        Events[EventSteps].SetActive(false);
        EventSteps += 1;
        Events[EventSteps].SetActive(true);
        Val += 1;
        Progress += 3;

    }
}
