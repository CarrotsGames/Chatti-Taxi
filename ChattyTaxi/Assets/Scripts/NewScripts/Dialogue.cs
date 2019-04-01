using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{

    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text CustomerText;
 
    public Button GoodButton;
    public Button NeutralButton;
    public Button BadButton;

    public string[] NeuturalResponse;
    public string[] GoodResponse;
    public string[] BadResponse;
    public string[] CustomerResponse;

    private GameObject ConvoManagerGameObj;
    ConvoManager ConvoManagerScript;

    private bool Good;
    private bool Bad;
    private bool Neutral;
     // Use this for initialization
    void Start()
    {
        ConvoManagerGameObj = GameObject.FindGameObjectWithTag("ConvoManager");
           ConvoManagerScript = ConvoManagerGameObj.GetComponent<ConvoManager>();
    }

 
    public void DialogueManager(int ButtonsPress)
    {
        //   Button CustomerBox = Events[Val].transform.GetChild(3).GetComponentInChildren<Button>();

        switch (ButtonsPress)
        {
            case 1:
                if (Good)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();
                }
                else if (Neutral)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();

                }
                else if (Bad)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();

                }
                else
                {
                    Text1.text = GoodResponse[0];
                    Text2.text = GoodResponse[1];
                    Text3.text = GoodResponse[2];
                    CustomerText.text = CustomerResponse[0];
                    Good = true;
                }
                break;
            case 2:
                if (Neutral)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();

                }
                else if(Good)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();

                }
                else if (Bad)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();

                }
                else
                {
                    Text1.text = NeuturalResponse[0];
                    Text2.text = NeuturalResponse[1];
                    Text3.text = NeuturalResponse[2];
                    CustomerText.text = CustomerResponse[1];
                    Neutral = true;
                }
                break;

            case 3:
                if (Bad)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();

                }
                else if (Good)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();

                }
                else if (Neutral)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();

                }
                else
                {
                    Text1.text = BadResponse[0];
                    Text2.text = BadResponse[1];
                    Text3.text = BadResponse[2];
                    CustomerText.text = CustomerResponse[2];
                    Bad = true;
                }
                break;


        }
    }
  
}