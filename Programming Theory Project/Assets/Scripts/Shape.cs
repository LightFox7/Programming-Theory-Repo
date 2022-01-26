using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    // ENCAPSULATION
    protected string color {
        get;
        private set;
    }
    [SerializeField] protected Text shapeText;
    [SerializeField] protected Text colorText;
    [SerializeField] protected Text positionText;

    private void Start() {
        color = GetComponent<Renderer>().material.name;
    }

    protected void OnMouseDown() {
        ChangeInfoText();
    }

    // POLYMORPHISM
    public virtual string GetShapeName() {
        return ("Generic shape");
    }

    // ABSTRACTION
    protected void ChangeInfoText() {
        shapeText.text = "Shape: " + GetShapeName();
        colorText.text = "Color: " + color.Split('(')[0];
        positionText.text = "Position: " + transform.position.ToString();
    }
}