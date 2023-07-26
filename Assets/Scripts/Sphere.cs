using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Sphere : Unit
{

    protected override void Move()
    {
        speed = 2;
        base.Move();
    }

    protected override void Turn()
    {
        turnSpeed = 0.5f;
        base.Turn();
    }

    private void Update()
    {
    if (isSelected)
        {
            Move();
            Turn();
        }    
    }
}
