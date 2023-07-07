using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GMG : MonoBehaviour
{
    public int meun1 = 0;
    public int meun2 = 0;
    public int meun3 = 0;
    public GameObject G_Meun;
    public csMenu_2 S_Meun;
    public GameObject G_Save;
    public Save save;

    public AudioSource source;
    public AudioClip S_card;
    public AudioClip S_back;

    public bool isMeunOn = false;

	void Start ()
    {
        G_Meun = GameObject.Find("CradKinds");     
        G_Save = GameObject.FindWithTag("Save");
        S_Meun = G_Meun.GetComponent<csMenu_2>();
        save = G_Save.GetComponent<Save>();
        meun1 = save.meun1;
        meun2 = save.meun2;
        meun3 = save.meun3;
        ValusPass(-1);
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)&&!isMeunOn)//카드
        {
            ValusPass(100);
            csSingleton.getInstance.g_bSwitch = false;
            source.PlayOneShot(S_card, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.E)&&!isMeunOn)//게스트
        {
            ValusPass(50);
            source.PlayOneShot(S_card, 1.0f);
        }
        if ((csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1005)&&!isMeunOn)
        {
            ValusPass(50);
            csSingleton.getInstance.g_bSwitch = false;
            source.PlayOneShot(S_card, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.C))//메인화면으로 돌아가기
        {
            MainMeun();
            isMeunOn = true;
            source.PlayOneShot(S_back, 1.0f);
        }
        if ((csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1004))
        {
            MainMeun();
            isMeunOn = true;
            csSingleton.getInstance.g_bSwitch = false;
            source.PlayOneShot(S_back, 1.0f);
        }
        
    }
    public void ValusPass(int nNo)
    {
        S_Meun.SelectMeun(meun1, meun2, meun3,nNo);
    }

    public void MainMeun()
    {
        isMeunOn = false;
        save.defaultNum();
        SceneManager.LoadScene("SampleScene");
    }


}
