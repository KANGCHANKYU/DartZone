using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class csMenu2 : MonoBehaviour
{
    public GameObject[] m_poMenu = new GameObject[5];//첫번쨰 메뉴

    public GameObject[] m_poMenuPractice = new GameObject[3];//두번째 메뉴
    public GameObject[] m_poMenu01Game = new GameObject[6];
    public GameObject[] m_poMenuCricket = new GameObject[3];
    public GameObject[] m_poMenuPartyGame = new GameObject[6];
    public GameObject[] m_poMenuEventGame = new GameObject[7];

    public Sprite[] m_poMenuPracticeSpriteSelect = new Sprite[3];//활성화 이미지
    public Sprite[] m_poMenu01GameSpriteSelect = new Sprite[6];
    public Sprite[] m_poMenuCricketSpriteSelect = new Sprite[3];
    public Sprite[] m_poMenuPartyGameSpriteSelect = new Sprite[6];
    public Sprite[] m_poMenuEventGameSpriteSelect = new Sprite[7];

    public Sprite[] m_poMenuPracticeSprite = new Sprite[3];//비활성 이미지
    public Sprite[] m_poMenu01GameSprite = new Sprite[6];
    public Sprite[] m_poMenuCricketSprite = new Sprite[3];
    public Sprite[] m_poMenuPartyGameSprite = new Sprite[6];
    public Sprite[] m_poMenuEventGameSprite = new Sprite[7];

    public GameObject[] m_poExplainPractice = new GameObject[3];//설명칸
    public GameObject[] m_poExplain01Game = new GameObject[6];
    public GameObject[] m_poExplainCricket = new GameObject[3];
    public GameObject[] m_poExplainPartyGame = new GameObject[6];
    public GameObject[] m_poExplainEventGame = new GameObject[7];

    public GameObject m_oExplain;
   
    

    void Start()
    {
        
    }


    void Update()
    {
        
    }
                                //1Select,2Select
    public void MenuSelect(int nMenu1, int nNo)
    {
        for (int i = 0; i < 5; i++)
        {  
            m_poMenu[i].SetActive(false);
        }
        if (nNo == -1) return;// -1이면 menu2를 그리지 않는다.

        m_poMenu[nMenu1].SetActive(true);//첫번쨰 메뉴

        
        switch (nMenu1)
        {
            case 0:
                {
                    for (int i=0; i<3; i++)
                        m_poMenuPractice[i].GetComponent<Image>().sprite = m_poMenuPracticeSprite[i];

                    m_poMenuPractice[nNo].GetComponent<Image>().sprite = m_poMenuPracticeSpriteSelect[nNo];
                    m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLAIN_MENU2_COUNTUP+nNo);
                   
                }
                break;
            case 1:
                {
                    for (int i = 0; i < 6; i++)
                        m_poMenu01Game[i].GetComponent<Image>().sprite = m_poMenu01GameSprite[i];

                    m_poMenu01Game[nNo].GetComponent<Image>().sprite = m_poMenu01GameSpriteSelect[nNo];
                    m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLAIN_MENU2_301+nNo);
                }
                break;
            case 2:
                {
                    for (int i = 0; i < 3; i++)
                        m_poMenuCricket[i].GetComponent<Image>().sprite = m_poMenuCricketSprite[i];
                    
                    m_poMenuCricket[nNo].GetComponent<Image>().sprite = m_poMenuCricketSpriteSelect[nNo];
                    m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLAIN_MENU2_STANDARDCR + nNo);   
                }
                break;
            case 3:
                {
                    for (int i = 0; i < 6; i++)
                        m_poMenuPartyGame[i].GetComponent<Image>().sprite = m_poMenuPartyGameSprite[i];

                    m_poMenuPartyGame[nNo].GetComponent<Image>().sprite = m_poMenuPartyGameSpriteSelect[nNo];
                    m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLAIN_MENU2_PT301+nNo);
                }
                break;
            case 4:
                {
                    for (int i = 0; i < 7; i++)
                        m_poMenuEventGame[i].GetComponent<Image>().sprite = m_poMenuEventGameSprite[i];

                    m_poMenuEventGame[nNo].GetComponent<Image>().sprite = m_poMenuEventGameSpriteSelect[nNo];
                    m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLAIN_MENU2_BINGGO33+nNo);
                }
                break;
        }
        
        
    }
    
}
