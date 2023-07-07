using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thagda : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
        {

            TwentyLine(1);

        }
        if (Input.GetKeyDown(KeyCode.X) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
        {

            TwentyLine(2);

        }
        if (Input.GetKeyDown(KeyCode.C) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
        {

            TwentyLine(3);

        }
    }

    void TwentyLine(int Line)
    {
        if (Line == 1)
        {
            Debug.Log("H2");
        }
        else if (Line == 2)
        {
            Debug.Log("Sex");
        }
        if (Line == 3)
        {
            Debug.Log("Rabasex");
        }
    }
}
