using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HumanRacket : racket
{
    public string axisname;

    protected override void Move()
    {
        float moveAxis = Input.GetAxis(axisname);
        rb2.velocity = new Vector2(0, moveAxis) * movespeed;
    }
}
