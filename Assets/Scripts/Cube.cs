using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Unit
{

    protected override void Move()
    {
        speed = 0.5f;
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
