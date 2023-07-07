using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class csGameManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip button;
    
    int m_nGameMode = 0;// 메뉴 선택 단계
    public GameObject m_oMenu;
    public csSingleton csSingleton;

    void Start()
    {
        
    }

    
    void Update()
    {  
        if (Input.GetKeyDown(KeyCode.W)|| (csSingleton.getInstance.g_bSwitch&& csSingleton.getInstance.g_nSwitch==1000))//상
        {   
            m_oMenu.GetComponent<csMenu>().ArrowButton(0);
            csSingleton.getInstance.g_bSwitch = false;
            source.PlayOneShot(button, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.S)||(csSingleton.getInstance.g_bSwitch&&csSingleton.getInstance.g_nSwitch==1001))//하
        {            
            m_oMenu.GetComponent<csMenu>().ArrowButton(1);
            csSingleton.getInstance.g_bSwitch = false;
            source.PlayOneShot(button, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.A)||(csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1002))//좌
        {           
            m_oMenu.GetComponent<csMenu>().ArrowButton(2);
             csSingleton.getInstance.g_bSwitch = false;
            source.PlayOneShot(button, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.D) || (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1003))//우
        {           
            m_oMenu.GetComponent<csMenu>().ArrowButton(3);
            csSingleton.getInstance.g_bSwitch = false;
            source.PlayOneShot(button, 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.Q) || (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1005))//선택
        {          
            m_oMenu.GetComponent<csMenu>().ArrowButton(100);
            csSingleton.getInstance.g_bSwitch = false;
            source.PlayOneShot(button, 1.0f);
        }
    }
}
