using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyScript : MonoBehaviour {

    public float Tip;
    public bool ResetTip;
	// Use this for initialization
	void Start ()
    {
        Tip = PlayerPrefs.GetFloat("TipAmount"); 
	}
	
	// Update is called once per frame
	void Update ()
    {
 
        if (ResetTip)
        {
            Tip = 0;
            PlayerPrefs.SetFloat("TipAmount", Tip);

        }
      
	}
}
