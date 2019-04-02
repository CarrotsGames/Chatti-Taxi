using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

    public Text gameText;
    public Button FirstButton;
    public Button SecondButton;
    public Button ThirdButton;

    public bool Option1;
    public bool Option2;
    public bool Option3;

    private enum States
    {
        Question,
        FirstStatement,
        SecondStatement
    };

    private States myState;

    // Use this for initialization
    void Start ()
    {
        myState = States.Question;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(myState == States.Question)
        {
            Question();
        }
        else if(myState == States.FirstStatement)
        {
            FirstStatement();
        }
        else if (myState == States.SecondStatement)
        {
            SecondStatement();
        }
    }

    private void OnEnable()
    {
        FirstButton.onClick.AddListener(delegate { Option1 = true; });
        SecondButton.onClick.AddListener(delegate { Option2 = true; });

    }

    void Question()
    {
        gameText.text = "Test My text";

        if(Option1)
        {
            myState = States.FirstStatement;
        }
        else if (Option2)
        {
            myState = States.SecondStatement;
        }
    }

    void FirstStatement()
    {
        gameText.text = "This is the first";
        // Go into positive Choices 
    }
    void SecondStatement()
    {
        gameText.text = "This is the second";
        // Go into Negative Choices 

    }
}
