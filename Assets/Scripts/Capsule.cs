using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Unit
{
    private Selector selector;
    // POLYMORPHISM
    protected override void Turn()
    {
        turnSpeed = 2;
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
