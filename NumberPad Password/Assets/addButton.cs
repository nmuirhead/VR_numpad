using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addButton : MonoBehaviour
{

    public Material button;
    //public Texture button;
    public TextMesh NumberField;
    public Color Hover;
    public Color Original;


    public string addNumber;


    private void OnMouseOver()
    {
        Debug.Log("Mouse Entered");
        button.color = Hover;
    }

    private void OnMouseExit()
    {
        button.color = Original;
    }

    public void OnMouseDown()
    {
        if (NumPadSystem.maxNumbers < 5)
        {
            NumberField.text += addNumber;
            NumPadSystem.maxNumbers++;
        }
    }

}
