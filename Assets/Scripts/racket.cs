using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public abstract class racket : MonoBehaviour
{
    protected Rigidbody2D rb2 { get { return gameObject.GetComponent<Rigidbody2D>(); } }
    public float movespeed = 15;
    public string playerName;
    bool paused = false;

    float score =10;
    public Text scoreText;
    public Text winner;
    public Button againBtn;

    void Update()
    {
        Move();
        //if (score < 1)
        //{
        //    winner.gameObject.SetActive(true);
        //    againBtn.gameObject.SetActive(true);
        //    winner.text = "You win";
        //    paused = togglePause();
        //}
    }

    public void MakeScore()
    {
        score--;
        scoreText.text = score.ToString();
        if (score < 1)
        {

            winner.gameObject.SetActive(true);
            againBtn.gameObject.SetActive(true);
            if (playerName == "Left")
                winner.text = "Left Player Win";
            else
                winner.text = "Right Player Win";

            paused = togglePause();
        }
    }
    protected abstract void Move();

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }
}
