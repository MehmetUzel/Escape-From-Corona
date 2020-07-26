using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public abstract class racket : MonoBehaviour
{
    protected Rigidbody2D rb2 { get { return gameObject.GetComponent<Rigidbody2D>(); } }
    public float movespeed = 15;


    float score=5;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void MakeScore()
    {
        score--;
        scoreText.text = score.ToString();
    }
    protected abstract void Move();

}
