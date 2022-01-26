using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Plane : Shape
{
    // POLYMORPHISM
    public override string GetShapeName() {
        return ("Plane");
    }
}