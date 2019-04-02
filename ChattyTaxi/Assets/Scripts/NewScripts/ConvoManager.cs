using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConvoManager : MonoBehaviour
{
    // ARRAY OF GAMEOBJECTS 
    public GameObject[] ConvoStates;
    int i;
    public int NumOfEvents;
    private GameObject CurrencyGameObj;
    private CurrencyScript Currency;
 
    private void Start()
    {
        CurrencyGameObj = GameObject.FindGameObjectWithTag("Currency");
        Currency = CurrencyGameObj.GetComponent<CurrencyScript>();
      
    }
    public void Events()
    {
            NumOfEvents += 1;
        if (NumOfEvents >= ConvoStates.Length)
        {
            SceneManager.LoadScene("StoreScene");
            PlayerPrefs.SetFloat("TipAmount", Currency.Tip); 
            ConvoStates[i].SetActive(false);
            Debug.Log("End");
        }
        else
        {
        
            ConvoStates[i].SetActive(false);
            i++;
            ConvoStates[i].SetActive(true);
         }
    }
}
