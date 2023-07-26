using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Unit
{

    protected override void Turn()
    {
        turnSpeed = 2;
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
