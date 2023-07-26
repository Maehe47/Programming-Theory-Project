using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public float speed = 1;
    public float turnSpeed = 1;
    public bool isSelected = false;

    protected virtual void Move()
    {
        float verticalInput = Input.GetAxis("Vertical");
        speed = 1;
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
    }
    protected virtual void Turn()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        turnSpeed = 1;
        transform.Rotate(Vector3.left * turnSpeed * horizontalInput * Time.deltaTime);
    }
    public bool Select()
    {
        isSelected = true;
        return isSelected;
    }
    public bool Deselect()
    {
        isSelected = false;
        return isSelected;
    }
}
