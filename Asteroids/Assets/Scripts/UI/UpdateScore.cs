using UnityEngine.UI;
using UnityEngine;


public class UpdateScore : MonoBehaviour
{
    public float scoreChange;
    public static int currentScore = 0; 
    public Text Scoretext;

    



    void Update(){

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
