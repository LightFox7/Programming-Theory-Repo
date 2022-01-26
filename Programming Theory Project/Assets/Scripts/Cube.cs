using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    // POLYMORPHISM
    public override string GetShapeName() {
        return ("Cube");
    }
}