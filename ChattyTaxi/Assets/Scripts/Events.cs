using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour {
    public bool ComedicChange;
    public bool NegativeChange;
    public bool SmartChange;

    private DialogueManager Dm;
    public string[] ComedicDialogue;
    public string[] NegativeDialogue;

    public string[] NormalDialogue;
    public string[] SmartDialogue;
    // Use this for initialization
    void Start()
    {
        Dm = GetComponent<DialogueManager>();
        ChaneEvent();
    }
 
	
	// Update is called once per frame
	void Update ()
    {
        ChaneEvent();

    }

    void ChaneEvent()
    {
       Dm.Events[Dm.Val].SetActive(true);
        Button one = Dm.Events[Dm.Val].transform.GetChild(0).GetComponentInChildren<Button>();
        Button two = Dm.Events[Dm.Val].transform.GetChild(1).GetComponentInChildren<Button>();
        Button three = Dm.Events[Dm.Val].transform.GetChild(2).GetComponentInChildren<Button>();

        // Events[EventSteps].SetActive(true);
        switch (Dm.Val)
        {
            case 0:
                // Changes dialogue to comedy
                if (ComedicChange)
                {
                    one.GetComponentInChildren<Text>().text = ComedicDialogue[0];
                    two.GetComponentInChildren<Text>().text = ComedicDialogue[1];
                    three.GetComponentInChildren<Text>().text = ComedicDialogue[2];
                }
                // Changes dialogue to Negative responses which give you no tip
                else if (NegativeChange)
                {
                    one.GetComponentInChildren<Text>().text = NegativeDialogue[0];
                    two.GetComponentInChildren<Text>().text = NegativeDialogue[1];
                    three.GetComponentInChildren<Text>().text = NegativeDialogue[2];
                }
                // Changes dialogue to overly explained stuff
                else if (SmartChange)
                {
                    one.GetComponentInChildren<Text>().text = SmartDialogue[0];
                    two.GetComponentInChildren<Text>().text = SmartDialogue[1];
                    three.GetComponentInChildren<Text>().text = SmartDialogue[2];
                }
                else              
                {
                    one.GetComponentInChildren<Text>().text = NormalDialogue[0];
                    two.GetComponentInChildren<Text>().text = NormalDialogue[1];
                    three.GetComponentInChildren<Text>().text = NormalDialogue[2];
          
                }
                break;
            case 1:

                if (ComedicChange)
                {
                    one.GetComponentInChildren<Text>().text = ComedicDialogue[3];
                    two.GetComponentInChildren<Text>().text = ComedicDialogue[4];
                    three.GetComponentInChildren<Text>().text = ComedicDialogue[5];
                }
                else if (NegativeChange)
                {
                    one.GetComponentInChildren<Text>().text = NegativeDialogue[3];
                    two.GetComponentInChildren<Text>().text = NegativeDialogue[4];
                    three.GetComponentInChildren<Text>().text = NegativeDialogue[5];
                }
                else if (SmartChange)
                {
                    one.GetComponentInChildren<Text>().text = SmartDialogue[3];
                    two.GetComponentInChildren<Text>().text = SmartDialogue[4];
                    three.GetComponentInChildren<Text>().text = SmartDialogue[5];
                }
                else
                {
                    one.GetComponentInChildren<Text>().text = NormalDialogue[3];
                    two.GetComponentInChildren<Text>().text = NormalDialogue[4];
                    three.GetComponentInChildren<Text>().text = NormalDialogue[5];

                }
                break;
            case 2:

                if (ComedicChange)
                {
                    one.GetComponentInChildren<Text>().text = ComedicDialogue[6];
                    two.GetComponentInChildren<Text>().text = ComedicDialogue[7];
                    three.GetComponentInChildren<Text>().text = ComedicDialogue[8];
                }
                else if (NegativeChange)
                {
                    one.GetComponentInChildren<Text>().text = NegativeDialogue[6];
                    two.GetComponentInChildren<Text>().text = NegativeDialogue[7];
                    three.GetComponentInChildren<Text>().text = NegativeDialogue[8];
                }
                else if (SmartChange)
                {
                    one.GetComponentInChildren<Text>().text = SmartDialogue[6];
                    two.GetComponentInChildren<Text>().text = SmartDialogue[7];
                    three.GetComponentInChildren<Text>().text = SmartDialogue[8];
                }
                else
                {
                    one.GetComponentInChildren<Text>().text = NormalDialogue[6];
                    two.GetComponentInChildren<Text>().text = NormalDialogue[7];
                    three.GetComponentInChildren<Text>().text = NormalDialogue[8];

                }
                break;
            case 3:
                if (ComedicChange)
                {
                    one.GetComponentInChildren<Text>().text = ComedicDialogue[9];
                    two.GetComponentInChildren<Text>().text = ComedicDialogue[10];
                    three.GetComponentInChildren<Text>().text = ComedicDialogue[11];
                }
                else if (NegativeChange)
                {
                    one.GetComponentInChildren<Text>().text = NegativeDialogue[9];
                    two.GetComponentInChildren<Text>().text = NegativeDialogue[10];
                    three.GetComponentInChildren<Text>().text = NegativeDialogue[11];
                }
                else if (SmartChange)
                {
                    one.GetComponentInChildren<Text>().text = SmartDialogue[9];
                    two.GetComponentInChildren<Text>().text = SmartDialogue[10];
                    three.GetComponentInChildren<Text>().text = SmartDialogue[11];
                }
                else
                {
                    one.GetComponentInChildren<Text>().text = NormalDialogue[9];
                    two.GetComponentInChildren<Text>().text = NormalDialogue[10];
                    three.GetComponentInChildren<Text>().text = NormalDialogue[11];

                }
                break;
            case 4:
                if (ComedicChange)
                {
                    one.GetComponentInChildren<Text>().text = ComedicDialogue[12];
                    two.GetComponentInChildren<Text>().text = ComedicDialogue[13];
                    three.GetComponentInChildren<Text>().text = ComedicDialogue[14];
                }
                else if (NegativeChange)
                {
                    one.GetComponentInChildren<Text>().text = NegativeDialogue[12];
                    two.GetComponentInChildren<Text>().text = NegativeDialogue[13];
                    three.GetComponentInChildren<Text>().text = NegativeDialogue[14];
                }
                else if (SmartChange)
                {
                    one.GetComponentInChildren<Text>().text = SmartDialogue[12];
                    two.GetComponentInChildren<Text>().text = SmartDialogue[13];
                    three.GetComponentInChildren<Text>().text = SmartDialogue[14];
                }
                else
                {
                    one.GetComponentInChildren<Text>().text = NormalDialogue[12];
                    two.GetComponentInChildren<Text>().text = NormalDialogue[13];
                    three.GetComponentInChildren<Text>().text = NormalDialogue[14];

                }
                break;

        }
    }
}
