using UnityEngine;
using System.Collections;

public class ConvoManager : MonoBehaviour
{
    // ARRAY OF GAMEOBJECTS 
    public GameObject[] ConvoStates;
    int i;

  
   public void Events()
    {
        //GAMEOBJECT ARRAY PLUS 1
        ConvoStates[i].SetActive(false);
        i++;
        ConvoStates[i].SetActive(true);

    }
}
