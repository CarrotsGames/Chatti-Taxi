using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoreScript : MonoBehaviour
{
    private GameObject CurrencyGameObj;
    private CurrencyScript Currency;
    public float ComedyBookAmount;
    public Text CurrencyText;
     // Use this for initialization
    void Start()
    {
        CurrencyGameObj = GameObject.FindGameObjectWithTag("Currency");
        Currency = CurrencyGameObj.GetComponent<CurrencyScript>();
     }
    private void Update()
    {
        CurrencyText.text = "" + Currency.Tip;
        PlayerPrefs.SetFloat("TipAmount", Currency.Tip);

    }
    // Update is called once per frame
    public void Shop(int ButtonsPress)
    {

        switch (ButtonsPress)
        {
            case 1:
                if (Currency.Tip < ComedyBookAmount)
                {
                    Currency.Tip -= ComedyBookAmount;
                    PlayerPrefs.SetInt("Comedy", 1);
                }
                else
                {
                    Debug.Log("GET MORE MONEY NERD");
                }
                break;

            case 2:
                Currency.Tip -= ComedyBookAmount;
 
                break;

            case 3:
                SceneManager.LoadScene("SampleScene");
                break;

        }

    }

}