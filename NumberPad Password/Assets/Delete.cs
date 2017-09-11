using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRStandardAssets.Utils;

public class Delete : MonoBehaviour {

    public Text CodeText;

    public void OnMouseDown()
    {
       
            CodeText.text = "";
            KeypadNumber.maxDigits = 0;
    }
}
