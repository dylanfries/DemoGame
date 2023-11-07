using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreBox;

    public int currentScore = 0;

    public void AddScore() {
        currentScore++;
        scoreBox.text = currentScore.ToString();
    }

}
