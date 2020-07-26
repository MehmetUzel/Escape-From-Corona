using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb2;
    public racket rigthRacket, leftRacket;
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(1, 0) * moveSpeed;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        tagmanager tm = collision.gameObject.GetComponent<tagmanager>();


        if (tm != null)
        {
            if(tm.tagger == Tagger.LEFT_RACKET || tm.tagger == Tagger.LEFT_RACKETB)
            {
                GetComponent<AudioSource>().Play();

                rigthRacket.MakeScore();
            }
            else if(tm.tagger == Tagger.RİGHT_RACKET || tm.tagger == Tagger.RİGHT_RACKETB)
            {
                GetComponent<AudioSource>().Play();

                leftRacket.MakeScore();
            }
            if (tm.tagger.Equals(Tagger.LEFT_RACKET) || tm.tagger.Equals(Tagger.RİGHT_RACKETB))
            {
                computereturn(1, collision);
            }
            else if (tm.tagger.Equals(Tagger.RİGHT_RACKET) || tm.tagger.Equals(Tagger.LEFT_RACKETB))
            {
                computereturn(-1, collision);
            }
        }
    }
    private void computereturn(float x, Collision2D collision)
    {
        Vector2 contact = collision.GetContact(0).point;

        float b = collision.collider.bounds.size.y;
        float a = (contact.y - collision.transform.position.y);
        float y = a / b;
        rb2.velocity = new Vector2(x, y) * moveSpeed;
    }
}
