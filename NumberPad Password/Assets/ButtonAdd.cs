using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRStandardAssets.Utils;

public class ButtonAdd : MonoBehaviour {
    
    public Text CodeText;
    public string buttonnum;
    
    public void OnMouseDown()
    {
        Debug.Log("Clicked");
        if(KeypadNumber.maxDigits < 5)
        {
       
            CodeText.text += buttonnum;
            KeypadNumber.maxDigits++;
        }
    }
    
}
