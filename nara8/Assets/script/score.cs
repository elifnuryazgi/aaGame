using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Text scoreText;
    private int scores;
    void Start()
    {
        scores = 0;
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        scores++;
        scoreText.text = scores.ToString();
    }
}
