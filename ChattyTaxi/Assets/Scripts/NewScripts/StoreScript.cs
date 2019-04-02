using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StoreScript : MonoBehaviour
{
    private GameObject CurrencyGameObj;
    private CurrencyScript Currency;
    public float ComedyBookAmount;
     // Use this for initialization
    void Start()
    {
        CurrencyGameObj = GameObject.FindGameObjectWithTag("Currency");
        Currency = CurrencyGameObj.GetComponent<CurrencyScript>();
    }
    private void Update()
    {
        PlayerPrefs.SetFloat("TipAmount", Currency.Tip);

    }
    // Update is called once per frame
    public void Shop(int ButtonsPress)
    {

        switch (ButtonsPress)
        {
            case 1:
                Currency.Tip -= ComedyBookAmount;
 
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