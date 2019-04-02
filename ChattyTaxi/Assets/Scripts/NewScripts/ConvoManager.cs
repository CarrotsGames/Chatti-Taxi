using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ConvoManager : MonoBehaviour
{
    // ARRAY OF GAMEOBJECTS 
    public GameObject[] ConvoStates;
    int i;
    public int NumOfEvents;
    private GameObject StoreGameObj;
    private StoreScript Store;
    private void Start()
    {
        StoreGameObj = GameObject.FindGameObjectWithTag("Store");
        Store = StoreGameObj.GetComponent<StoreScript>();
    }
    public void Events()
    {
            NumOfEvents += 1;
        if (NumOfEvents >= ConvoStates.Length)
        {
            SceneManager.LoadScene("StoreScene");
            PlayerPrefs.SetFloat("TipAmount", Store.Tip); 
            ConvoStates[i].SetActive(false);
            Debug.Log("End");
        }
        else
        {
            //GAMEOBJECT ARRAY PLUS 1
            ConvoStates[i].SetActive(false);
            i++;
            ConvoStates[i].SetActive(true);
        }
    }
}
