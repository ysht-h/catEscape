using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
        if( Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1.0f, 0.0f, 0.0f);
        }

        if( Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1.0f, 0.0f, 0.0f);
        }
    }


    public void pushLButton()
    {
        transform.Translate(-1.0f, 0.0f, 0.0f);
    }

    public void pushRButton()
    {
        transform.Translate(1.0f, 0.0f, 0.0f);
    }
}
