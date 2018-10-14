using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvent : MonoBehaviour {

    public bool isLocked = false;
    public Camera camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocked)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Input.GetMouseButtonDown(0))
                { 
                    Ray ray = camera.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit ;
                    if (Physics.Raycast(ray, out hit))
                    {
                        Debug.Log("Pressed");
                    }
                }
            }
        }
            else if (Input.GetMouseButtonUp(0))
                print("Released");

        }
    }
