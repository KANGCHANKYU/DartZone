using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Fish : MonoBehaviour
{
    public AudioSource source;
    public AudioClip button;
    public AudioClip winner;

    public GameObject G_save;
    public Save save;
	void Start ()
    {
        G_save = GameObject.FindWithTag("Save");
        save = G_save.GetComponent<Save>();
        source.PlayOneShot(winner, 1.0f);
    }
	

	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Q)|| (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1005))
        {
            source.PlayOneShot(button, 1.0f);
            save.defaultNum();
            csSingleton.getInstance.g_bSwitch = false;
            SceneManager.LoadScene("SampleScene");
        }
	}
}
