using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerContol : MonoBehaviour
{
    public Text textscore;
    public int currentscore;
    void Update()
    {

    }
    public void PressButton()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void UpdateScore(int points)
    {
        currentscore = currentscore + points;
        textscore.text = "Score: " + currentscore;
    }
}
