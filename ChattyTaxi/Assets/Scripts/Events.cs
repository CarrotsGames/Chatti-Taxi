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
        if (Dm.Val < 5)
        {
            Dm.Events[Dm.Val].SetActive(true);

            Button one = Dm.Events[Dm.Val].transform.GetChild(0).GetComponentInChildren<Button>();
            Button two = Dm.Events[Dm.Val].transform.GetChild(1).GetComponentInChildren<Button>();
            Button three = Dm.Events[Dm.Val].transform.GetChild(2).GetComponentInChildren<Button>();

            // Events[EventSteps].SetActive(true);
            switch (Dm.Val)
            {
                case 0:
                    
                     
                    break;
                case 1:
             
                    break;
                case 2:

                  
                    break;
                case 3:
                  
                    break;
                case 4:
                   
                    break;
            }
        }
    }
}
