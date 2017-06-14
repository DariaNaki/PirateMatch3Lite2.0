using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public static GameManager gm;
	public float score=0;
	public Text mainScoreDisplay;
    public Text bestScoreDisplay;
   // public int highScore=0;

    void Start () {
		if (gm == null) 
			gm = gameObject.GetComponent<GameManager>();		
		Collect (0);
        PlayerPrefs.GetFloat("HighScore");
        
    
	}
    void Update()
    {
        PlayerPrefs.GetFloat("HighScore");
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", score);
            PlayerPrefs.Save();
           
        }
       
        bestScoreDisplay.text = PlayerPrefs.GetFloat("HighScore").ToString();
        mainScoreDisplay.text = score.ToString();
    }
    public void Collect(int amount) {
		score += amount;
     }
}
