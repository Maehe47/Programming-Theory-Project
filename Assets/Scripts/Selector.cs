using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Selector : Unit
{
    public GameObject[] selection;
    public int index = 0;
    public Component selectedUnit;
    //public Unit unit;
    public string Unitname;
    //public Sphere sphere;
    
    private void Start()
    {
       // unit = gameObject.GetComponent<Unit>();
        
        GetScript();
        
    }
    private void Update()
    {
        
        if (Input.GetButtonDown("Jump")==true)
        {
           
            
                Debug.Log("space");
                Deselect();
                if (index < selection.Length -1) { index++; } else { index = 0; }    
                GetScript();
                Select();
            
        }
    }
    private void GetScript()
    {
        Unitname = selection[index].name;
        selectedUnit = selection[index].GetComponent(Unitname);
    }
}
