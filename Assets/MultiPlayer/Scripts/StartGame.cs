using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class StartGame : MonoBehaviour
{
    public float timeLift = 3.0f;
    public Text startext;
    private void GameOver()
    {

    }

    void Update()
    {
        timeLift -= Time.deltaTime;
        startext.text = (timeLift).ToString ("0");
        if (timeLift < 0)
        {
            GameOver();
        }
    }
}
