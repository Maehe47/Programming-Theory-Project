using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Selector : Unit
{
    public GameObject[] selection;
    private int index = 0;
    public Component selectedUnit;
    private string unitName;
    public TextMeshProUGUI selectorText;

    private void Start()
    {
        GetScript();
        ScreenSelected();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump")==true)
        {
                if (index < selection.Length -1) { index++; } else { index = 0; }    
                GetScript();
                ScreenSelected();
        }

    }
    private void GetScript()
    {
        unitName = selection[index].name;
        selectedUnit = selection[index].GetComponent(unitName);
    }
    private void ScreenSelected()
    {
        selectorText.text = ("Selected: " + unitName);
    }
}
