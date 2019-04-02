using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    // ARRAY OF GAMEOBJECTS 
    public GameObject[] ConvoStates;
    int i;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Events()
    {
        //GAMEOBJECT ARRAY PLUS 1
        ConvoStates[i].SetActive(false);
        i++;
        ConvoStates[i].SetActive(true);

    }
}
