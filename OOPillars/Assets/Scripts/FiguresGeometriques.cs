using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiguresGeometriques : MonoBehaviour
{
    protected string FigureName; /* { 
        get {return FigureName; } 
        set { FigureName = value; } 
    } */
    public Text texte;

    public void Awake()
    {
        FigureName = "parent";
        texte = GameObject.FindGameObjectWithTag("description").GetComponent<Text>();
    }
    protected void Rotate45()
    {
        Debug.Log("  Parent rotation routine activated from child ");
        transform.Rotate(0, 45, 0);
    }

    protected int CalculatePerimeter()
    {
        return -1;
    }
}
