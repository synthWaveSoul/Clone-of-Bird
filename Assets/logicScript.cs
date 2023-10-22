using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    public void addScore(){
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
}
