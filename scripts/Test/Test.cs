using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Test : MonoBehaviour
{

	void Start ()
    {
		
	}
	

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            SceneManager.LoadScene("SampleScene");
	}
}
