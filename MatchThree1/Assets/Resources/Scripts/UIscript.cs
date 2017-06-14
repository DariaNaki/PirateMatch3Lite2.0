using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIscript : MonoBehaviour {

    public GameObject game;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width/2-80,Screen.height/2,160,30),"Blaaaaah"))
        {
            GameObject g = Instantiate(game) as GameObject;
            Destroy(gameObject);
        }
    }
}
