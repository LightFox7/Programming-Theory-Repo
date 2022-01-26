using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    // POLYMORPHISM
    public override string GetShapeName() {
        return ("Cylinder");
    }
}