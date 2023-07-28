using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Selector : Unit
{
    public GameObject[] selection;
    private int index = 0;
    public Component selectedUnit;
    private string unitName;

    private void Start()
    {
        GetScript();   
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump")==true)
        {
                if (index < selection.Length -1) { index++; } else { index = 0; }    
                GetScript();            
        }
    }
    private void GetScript()
    {
        unitName = selection[index].name;
        selectedUnit = selection[index].GetComponent(unitName);
    }
    
}
