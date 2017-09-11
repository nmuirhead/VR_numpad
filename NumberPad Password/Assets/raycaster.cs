using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycaster : MonoBehaviour {

	// Use this for initialization
	void Start () {
        RaycastHit hitInfo;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo)) {
            Debug.Log("mouse is over object " + hitInfo.collider.name);
        }
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hitInfo;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo)) {
            Debug.Log("mouse is over object " + hitInfo.collider.name);
        }
    }
}
