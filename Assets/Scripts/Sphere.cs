using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Sphere : Unit
{
    // POLYMORPHISM
    private Selector selector;
    protected override void Move()
    {
        speed = 5;
        base.Move();
    }

    protected override void Turn()
    {
        turnSpeed = 50f;
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
