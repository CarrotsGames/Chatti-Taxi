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
  
    // Tips for actions
    // 0 is start of convo 
    // 1,2,3 are the tip you get for each response
    // EG reponse 1 gives you 50C while repsonse 2 gives 10C  

    public float[] GoodTips;
    public float[] BadTips;
    public float[] NeutralTips;
    public float[] ComedyTips;



    public Button GoodButton;
    public Button NeutralButton;
    public Button BadButton;

    public string[] NeuturalResponse;
    public string[] GoodResponse;
    public string[] ComedyRespond;

    public string[] BadResponse;
    public string[] CustomerResponse;

    private GameObject ConvoManagerGameObj;
    private GameObject StoreGameObj;
    private StoreScript Store;
    private ConvoManager ConvoManagerScript;
    private bool Good;
    private bool Bad;
    private bool Neutral;
    public bool ComedyBook;

    int ComedyChange;
     // Use this for initialization
    void Start()
    {
        ConvoManagerGameObj = GameObject.FindGameObjectWithTag("ConvoManager");
        ConvoManagerScript = ConvoManagerGameObj.GetComponent<ConvoManager>();
        StoreGameObj = GameObject.FindGameObjectWithTag("Store");
        Store = StoreGameObj.GetComponent<StoreScript>();
    }

 
    public void DialogueManager(int ButtonsPress)
    {
        //   Button CustomerBox = Events[Val].transform.GetChild(3).GetComponentInChildren<Button>();

        switch (ButtonsPress)
        {
            case 1:
                if (Good)
                {
                    Store.Tip += GoodTips[1];
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();
                }
                else if (Neutral)
                {
                    Store.Tip += NeutralTips[1];
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();

                }
                else if (Bad)
                {
                    Store.Tip += BadTips[1];
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();

                }
                else if (ComedyBook && ComedyChange > 0)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();
                    Store.Tip += ComedyTips[1];
                }
                else
                {
                   
                     Store.Tip += GoodTips[0];
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
                    Store.Tip += NeutralTips[2];

                }
                else if(Good)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();
                    Store.Tip += GoodTips[2];

                }
                else if (Bad)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();
                    Store.Tip += BadTips[2];

                }
                else if (ComedyBook && ComedyChange > 0)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();
                    Store.Tip += ComedyTips[2];
                }
                else
                {
                   
                        Store.Tip += NeutralTips[0];

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
                    Store.Tip += BadTips[3];

                }
                else if (Good)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();
                    Store.Tip += GoodTips[3];

                }
                else if (Neutral)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();
                    Store.Tip += NeutralTips[3];

                }
                else if (ComedyBook && ComedyChange > 0)
                {
                    Debug.Log("GET TIP CUSTOMER LEAVES");
                    ConvoManagerScript.Events();
                    Store.Tip += ComedyTips[3];
                }
                else
                {
                    if (ComedyBook)
                    {
                        ComedyChange += 1;
                        Store.Tip += BadTips[0];

                        Text1.text = ComedyRespond[0];
                        Text2.text = ComedyRespond[1];
                        Text3.text = ComedyRespond[2];
                        CustomerText.text = CustomerResponse[2];
                        ComedyBook = true;
                    }
                    else
                    {
                        Store.Tip += BadTips[0];

                        Text1.text = BadResponse[0];
                        Text2.text = BadResponse[1];
                        Text3.text = BadResponse[2];
                        CustomerText.text = CustomerResponse[2];
                        Bad = true;
                    }
                }
                break;


        }
    }
  
}