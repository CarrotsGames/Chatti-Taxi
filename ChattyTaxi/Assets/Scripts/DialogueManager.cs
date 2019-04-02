using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public float TipAmount;
    public GameObject TextBox;
    public GameObject[] Events;
    private int EventSteps = 0;
    public int Val;
    private Events EventScript;
    public string[] CustomerDialogue;
    public string[] CustomerDialogueNegative;
    public string[] CustomerDialogueComedy;
    int Progress;
    public Text TestText;
    private CurrencyScript Store;
    private void Start()
    {
        Store = GetComponent<CurrencyScript>();
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
                    Store.Tip += 0;
                    //   CustomerBox.GetComponentInChildren<Text>().text = 
                    // Changes Customers text to a negative responce at this array
                    // Progress is added by 3 to continue through the list
                    TestText.text = CustomerDialogueNegative[0 + Progress];
                }
                else if (EventScript.ComedicChange)
                {
                    Store.Tip += 0;
                    //   CustomerBox.GetComponentInChildren<Text>().text = 
                    // Changes Customers text to a negative responce at this array
                    // Progress is added by 3 to continue through the list
                    TestText.text = CustomerDialogueComedy[0 + Progress];
                }
                else
                {
                    // Changes customers text to a nutural response at this array
                    // Progress is added by 3 to continue through the list
                    Store.Tip += TipAmount;
                    TestText.text = CustomerDialogue[0 + Progress];

                }

                break;
            case 2:

                if (EventScript.NegativeChange)
                {
                    Store.Tip += 0;
                    // Changes Customers text to a negative responce at this array
                    // Progress is added by 3 to continue through the list
                    TestText.text = CustomerDialogueNegative[1 + Progress];

                }
                else if (EventScript.ComedicChange)
                {
                    Store.Tip += 0;
                    //   CustomerBox.GetComponentInChildren<Text>().text = 
                    // Changes Customers text to a negative responce at this array
                    // Progress is added by 3 to continue through the list
                    TestText.text = CustomerDialogueComedy[0 + Progress];
                }
                else
                {  // Changes customers text to a nutural response at this array
                    // Progress is added by 3 to continue through the list
                    Store.Tip += TipAmount / 2;               
                    TestText.text = CustomerDialogue[1 + Progress];

                }
                break;
            case 3:
                if (EventScript.NegativeChange)
                {
                    // Changes Customers text to a negative responce at this array
                    // Progress is added by 3 to continue through the list
                    Store.Tip += TipAmount / TipAmount - 2;
                    TestText.text = CustomerDialogueNegative[2 + Progress];

                }
                else if (EventScript.ComedicChange)
                {
                    Store.Tip += 0;
                    //   CustomerBox.GetComponentInChildren<Text>().text = 
                    // Changes Customers text to a negative responce at this array
                    // Progress is added by 3 to continue through the list
                    TestText.text = CustomerDialogueComedy[0 + Progress];
                }
                else
                {
                    // Changes customers text to a nutural response at this array
                    // Progress is added by 3 to continue through the list
                    Store.Tip += TipAmount / TipAmount;
                    TestText.text = CustomerDialogue[2 + Progress];

                }
                break;

        }
    
        Events[EventSteps].SetActive(false);
        EventSteps += 1;
        if (Val < 4)
        {
            Events[EventSteps].SetActive(true);
        }
        else
        {
            Debug.Log("NO MORE");
            // Go to next scene or store
            // make player jump out
            // make player leave
        }
            Val += 1;
        // Adds by 3 to continue the array
        Progress += 3;

    }
}
