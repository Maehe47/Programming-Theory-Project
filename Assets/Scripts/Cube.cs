using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Unit
{
    private Selector selector;
    // POLYMORPHISM
    protected override void Move()
    {
        speed = 0.5f;
        base.Move();
    }

    protected override void Turn()
    {
        turnSpeed = 10;
        base.Turn();
    }

    private void Start()
    {
        selector = GameObject.Find("Selector").GetComponent<Selector>();
    }

    private void Update()
    {
        if (selector.selectedUnit.Equals(this))
        {
            Move();
            Turn();
        }
    }
}
