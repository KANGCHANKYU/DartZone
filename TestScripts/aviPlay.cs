using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class aviPlay : MonoBehaviour
{
    public VideoPlayer vp;


    void Start ()
    {

	}

	void Update ()
    {
        vp.Play();
    }
}
