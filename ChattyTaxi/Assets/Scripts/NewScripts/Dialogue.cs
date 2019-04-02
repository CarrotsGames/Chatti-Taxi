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

    // tips amount  for each decision 
    public float[] GoodTips;
    public float[] BadTips;
    public float[] NeutralTips;
    public float[] ComedyTips;

    // Interactive buttons
    public Button GoodButton;
    public Button NeutralButton;
    public Button BadButton;
    
    // Responses from the player
    public string[] NeuturalResponse;
    public string[] GoodResponse;
    public string[] ComedyRespond;
    public string[] BadResponse;
    
    // Responses from the customer
    public string[] CustomerResponse;

    // Changes the bad responses to comedic responses
    public bool ComedyBook;

    // refrences the conversationManager
    private GameObject ConvoManagerGameObj;
    private ConvoManager ConvoManagerScript;

    // refrences the store
    private GameObject CurrencyGameObj;
    private CurrencyScript Currency;
   
    // checks which decision is being made
    public bool Good;
    private bool Bad;
    private bool Neutral;
  
    // holds states of the conversation
     private enum States
    {
        Question,
        Good,
        Neutral,
        Bad,
        Stop
    }
    private States myState;

      // Use this for initialization
    void Start()
    {
        myState = States.Question;
        Good = false;
        Bad = false;
         ConvoManagerGameObj = GameObject.FindGameObjectWithTag("ConvoManager");
        ConvoManagerScript = ConvoManagerGameObj.GetComponent<ConvoManager>();
        CurrencyGameObj = GameObject.FindGameObjectWithTag("Currency");
        Currency = CurrencyGameObj.GetComponent<CurrencyScript>();
    }

    // Changes the buttons focus to the desired voids
    private void OnEnable()
    {
         GoodButton.onClick.AddListener(delegate { Good = true; });
        NeutralButton.onClick.AddListener(delegate { Neutral = true; });
        BadButton.onClick.AddListener(delegate { Bad = true; });
    }
    private void Update()
    {
        // Changes the states when called
        if (myState == States.Question)
        {
            Question();
        }
        else if (myState == States.Good)
        {

            GoodVoid();
        }
        else if (myState == States.Neutral)
        {

            NeutralVoid();
        }
        else if(myState == States.Bad)
        {

            BadVoid();
        }
    }
    // Checks for a response to the initial question
    void Question()
    {
        //CustomerText.text = CustomerResponse[0];
        // chooses what to change the state to
        if(Good)
        {
            Currency.Tip += GoodTips[0];

            myState = States.Good;
         }
        else if (Bad)
        {
            Currency.Tip += BadTips[0];

            myState = States.Bad;
         }
        else if(Neutral)
        {
            Currency.Tip += NeutralTips[0];

            myState = States.Neutral;
         }

    }

    // handles good Responses
    void GoodVoid()
    {
        // Changes the text to the Good responses 
        Text1.text = GoodResponse[0];
        Text2.text = GoodResponse[1];
        Text3.text = GoodResponse[2];
        CustomerText.text = CustomerResponse[0];
        GoodButton.GetComponent<Button>().onClick.RemoveAllListeners();
    
        // First button
        GoodButton.onClick.AddListener
            (
            delegate {
                ConvoManagerScript.Events();
                Currency.Tip += GoodTips[1];

             });
        NeutralButton.GetComponent<Button>().onClick.RemoveAllListeners();
    
        // Second button
        NeutralButton.onClick.AddListener(
            delegate
            {
                ConvoManagerScript.Events();
                Currency.Tip += GoodTips[2];

             });
        BadButton.GetComponent<Button>().onClick.RemoveAllListeners();

        // Third button
        BadButton.onClick.AddListener(delegate
        {
            ConvoManagerScript.Events();
            Currency.Tip += GoodTips[3];

         });
     
    }
  
    // handles neutral Responses
    void NeutralVoid()
    {
        // Changes the text to the Neutral responses 
        Text1.text = NeuturalResponse[0];
        Text2.text = NeuturalResponse[1];
        Text3.text = NeuturalResponse[2];
        CustomerText.text = CustomerResponse[1];
        GoodButton.GetComponent<Button>().onClick.RemoveAllListeners();
     
        // First button
        GoodButton.onClick.AddListener
            (
            delegate {
                ConvoManagerScript.Events();
                Currency.Tip += NeutralTips[1];

             });
        NeutralButton.GetComponent<Button>().onClick.RemoveAllListeners();

        // Second button
        NeutralButton.onClick.AddListener(
            delegate
            {
                ConvoManagerScript.Events();
                Currency.Tip += NeutralTips[2];

             });
        BadButton.GetComponent<Button>().onClick.RemoveAllListeners();

        // third button
        BadButton.onClick.AddListener(delegate
        {
            ConvoManagerScript.Events();
            Currency.Tip += NeutralTips[3];

         });
      
    }    
    
    // handles bad Responses
    void BadVoid()
    {
        // Changes the text to the Bad responses 
        Text1.text = BadResponse[0];
        Text2.text = BadResponse[1];
        Text3.text = BadResponse[2];
        CustomerText.text = CustomerResponse[2];
        GoodButton.GetComponent<Button>().onClick.RemoveAllListeners();

        // first button
        GoodButton.onClick.AddListener
            (
            delegate {
                ConvoManagerScript.Events();
                Currency.Tip += BadTips[3];

             });
        NeutralButton.GetComponent<Button>().onClick.RemoveAllListeners();

        // Second button
        NeutralButton.onClick.AddListener(
            delegate
            {
                ConvoManagerScript.Events();
                Currency.Tip += BadTips[3];

             });
        BadButton.GetComponent<Button>().onClick.RemoveAllListeners();

        // Third button
        BadButton.onClick.AddListener(delegate
        {
            ConvoManagerScript.Events();
            Currency.Tip += BadTips[3];

         });
        
    }

}