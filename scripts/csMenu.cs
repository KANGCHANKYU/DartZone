using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class csMenu : MonoBehaviour
{
    int m_nMenuTab = 0;
   public int m_nMenu1Select = 0;
   public int m_nMenu2Select = -1;
   public int m_nMenu3Select = -1;
    public GameObject[] m_poMenu = new GameObject[3];
    public GameObject m_oExplain;
    public GameObject G_save;
    public Save save;
    void Start()
    {
        G_save = GameObject.FindWithTag("Save");
        save = G_save.GetComponent<Save>();
    }


    void Update()
    {
     

    }

    public void ArrowButton(int nDir)
    {
        switch (nDir)
        {
            case 0://상
                {
                    if (m_nMenuTab == 0)//기초 메뉴
                    {
                        
                        m_nMenu1Select--;
                        m_nMenu2Select = 0;

                        if (m_nMenu1Select < 0)
                            m_nMenu1Select = 4;

                        m_poMenu[m_nMenuTab].GetComponent<csMenu1>().MenuSelect(m_nMenu1Select);
                        
                    }
                    else if (m_nMenuTab == 1)//두번쨰 메뉴
                    {
                        m_nMenu2Select--;
                        m_nMenu3Select = 0;
                        if (m_nMenu1Select == 0)// Practice
                        {
                            if (m_nMenu2Select < 0)
                                m_nMenu2Select = csSingleton.getInstance._MENU2_NUM_PRACTICE-1;

                            m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        }
                        else if (m_nMenu1Select == 1)// 01Game
                        {
                            if (m_nMenu2Select < 0)
                                m_nMenu2Select = csSingleton.getInstance._MENU2_NUM_01GAME - 1;

                            m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        }
                        else if (m_nMenu1Select == 2)// cricket
                        {
                            if (m_nMenu2Select < 0)
                                m_nMenu2Select = csSingleton.getInstance._MENU2_NUM_CRICKET-1;

                            m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        }
                        else if (m_nMenu1Select == 3)// party game
                        {
                            if (m_nMenu2Select < 0)
                                m_nMenu2Select = csSingleton.getInstance._MENU2_NUM_PARTYGAME - 1;

                            m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        }
                        else if (m_nMenu1Select == 4)// event game
                        {
                            if (m_nMenu2Select < 0)
                                m_nMenu2Select = csSingleton.getInstance._MENU2_NUM_EVENTGAME - 1;
                                

                            m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        }
                    }
                    //3단계
                    else if(m_nMenuTab==2)
                    {
                        m_nMenu3Select--;
                        if (m_nMenu3Select < 0)
                            m_nMenu3Select = 13;

                        m_poMenu[m_nMenuTab].GetComponent<csMenu3>().MenuSelect(m_nMenu1Select, m_nMenu2Select, m_nMenu3Select);
                    }
                }
                break;
            case 1://하
                {
                    if (m_nMenuTab == 0)
                    {
                     
                        m_nMenu1Select++;
                        m_nMenu2Select = 0;
                        if (m_nMenu1Select >=5)
                            m_nMenu1Select = 0;

                        m_poMenu[m_nMenuTab].GetComponent<csMenu1>().MenuSelect(m_nMenu1Select);
                        //m_poMenu[m_nMenuTab + 1].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                    }
                    else if (m_nMenuTab == 1)
                    {
                        m_nMenu2Select++;
                        m_nMenu3Select = 0;
                        if (m_nMenu1Select == 0)// Practice
                        {
                            if (m_nMenu2Select >= csSingleton.getInstance._MENU2_NUM_PRACTICE)
                                m_nMenu2Select = 0;

                            m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        }
                        else if (m_nMenu1Select == 1)// 01Game
                        {
                            if (m_nMenu2Select >= csSingleton.getInstance._MENU2_NUM_01GAME)
                                m_nMenu2Select = 0;

                            m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        }
                        else if (m_nMenu1Select == 2)// cricket
                        {
                            if (m_nMenu2Select >= csSingleton.getInstance._MENU2_NUM_CRICKET)                     
                                m_nMenu2Select = 0;
                            

                            m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        }
                        else if (m_nMenu1Select == 3)// party game
                        {
                            if (m_nMenu2Select >= csSingleton.getInstance._MENU2_NUM_PARTYGAME)
                                m_nMenu2Select = 0;

                            m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        }
                        else if (m_nMenu1Select == 4)// event game
                        {
                            if (m_nMenu2Select >= csSingleton.getInstance._MENU2_NUM_EVENTGAME)
                                m_nMenu2Select = 0;

                            m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        }
                    }
                    //3단계
                    else if(m_nMenuTab==2)
                    {
                        m_nMenu3Select++;
                        if (m_nMenu3Select >= 14)//버튼 개수 
                            m_nMenu3Select = 0;

                        m_poMenu[m_nMenuTab].GetComponent<csMenu3>().MenuSelect(m_nMenu1Select, m_nMenu2Select,
                            m_nMenu3Select);

                    }
                }
                break;
            case 2://좌
                if(m_nMenuTab==0)
                {
                    save.meun1 = m_nMenu1Select;
                }
               else if(m_nMenuTab==1)//2단계
                {
                    m_poMenu[m_nMenuTab].SetActive(false);
                    m_nMenuTab -= 1;
                    m_nMenu2Select = -1;
                    m_poMenu[m_nMenuTab].GetComponent<csMenu1>().MenuSelect(m_nMenu1Select);
                    save.meun2 = m_nMenu2Select;

                }
                else if(m_nMenuTab==2)//3단계
                {
                    m_poMenu[m_nMenuTab].SetActive(false);                 
                    m_nMenuTab -= 1;
                    m_nMenu3Select = -1;
                    m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                    save.meun3 = m_nMenu3Select;

                }
                break;
            case 3://우
                {
                    if(m_nMenuTab==0)//2단계
                    {
                        m_nMenuTab = 1;
                        m_poMenu[m_nMenuTab].SetActive(true);
                        m_nMenu2Select = 0;
                        m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        save.meun1 = m_nMenu1Select;
                    }
                    else if (m_nMenuTab == 1)//3단계
                    {

                        m_nMenuTab = 2;
                        m_poMenu[m_nMenuTab].SetActive(true);
                        m_nMenu3Select = 0;
                        m_poMenu[m_nMenuTab].GetComponent<csMenu3>().MenuSelect(m_nMenu1Select, m_nMenu2Select
                            , m_nMenu3Select);
                        save.meun2 = m_nMenu2Select;
                    }
                }
                break;
            case 100://선택
                {
                    if (m_nMenuTab == 0)
                    {
                        m_nMenuTab = 1;
                        m_poMenu[m_nMenuTab].SetActive(true);
                        m_nMenu2Select = 0;
                        m_poMenu[m_nMenuTab].GetComponent<csMenu2>().MenuSelect(m_nMenu1Select, m_nMenu2Select);
                        save.meun1 = m_nMenu1Select;
                        
                    }
                    else if(m_nMenuTab==1)
                    {
                        m_nMenuTab = 2;
                        m_poMenu[m_nMenuTab].SetActive(true);
                        m_nMenu3Select = 0;
                        m_poMenu[m_nMenuTab].GetComponent<csMenu3>().MenuSelect(m_nMenu1Select, m_nMenu2Select
                            , m_nMenu3Select);
                        save.meun2 = m_nMenu2Select;
                  
                    }
                    else if(m_nMenuTab==2)
                    {
                        save.meun3 = m_nMenu3Select;
                        if (Input.GetKeyDown(KeyCode.Q) || 
                            (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1005))
                        {
                            SceneManager.LoadScene("CardScene");

                        }
                    }
                   
                   
                }
                break;
        }

    }
}
