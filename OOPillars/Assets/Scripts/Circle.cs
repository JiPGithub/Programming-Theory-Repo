using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : FiguresGeometriques
{
    public void ClickMe()
    {
        FigureName = "Circle";
        Rotate45();
        texte.text = "I inherit FiguresGeometriques. My figure name is fixed as " + FigureName + " and cannot be modified outside mySelf. " +
            "I use my parent method for the rotation (45 deg). I used my own version of the method (overload) " +
            "to calculate my perimeter, which is " + CalculatePerimeter(2);
    }

    protected float CalculatePerimeter(int R)
    {
        return (3.1415f * 2) * 2;
    }
}
