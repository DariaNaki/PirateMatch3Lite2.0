using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    public GameObject gameMeat;
    public GameObject button;
    public void LoadGame()
    {
        GameObject startGame = Instantiate(gameMeat) as GameObject;
        
    }       
    public void PureDestruction()
    {

        Destroy(button);
    }
    
}
