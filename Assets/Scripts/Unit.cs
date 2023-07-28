using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    // INHERITANCE
    // ENCAPSULATION
    public float speed { get { return m_speed; }
                         set { if (value < 0) { Debug.Log("you cant insert a negative number"); }
                               else { m_speed = value; }
                         }
                       }
    public float turnSpeed { get { return m_turnSpeed; } 
                             set { if (value < 0) { Debug.Log("you cant insert a negative number"); }
                                   else { m_turnSpeed = value; } 
                             }
                       } 
    private float m_turnSpeed = 20;
    private float m_speed = 1;

    // ABSTRACTION
    protected virtual void Move()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
    }
    protected virtual void Turn()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
        
    }
}
