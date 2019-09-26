using UnityEngine.UI;
using UnityEngine;


public class UpdateScore : MonoBehaviour
{
    float scoreChange;
    public static int currentScore = 0; 
    public Text Scoretext;

    void Update(){
        // This script is for updating the score real time and can be placed anywhere within the game.
        // 'ObjectStats' Passes the score change to this script.


        if (Scoretext != null){
            Scoretext.text = "Score: " + currentScore.ToString("0"); 
        }else{
            Debug.LogWarning("UpdateScore is missing a textbox.");
        }

    }
    public void Score(int scoreChange){
        currentScore += scoreChange;
    }
}