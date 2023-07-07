using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class csMenu3 : MonoBehaviour
{
    public GameObject[] m_poMenu1 = new GameObject[5];//첫번쨰 메뉴
    public GameObject[] m_poMenu2 = new GameObject[24];//두번째메뉴 
    public GameObject[] m_poMenu3 = new GameObject[14];//세번쨰 메뉴

    public Sprite[] m_poMenuSpriteSelect=new Sprite[14];
    public Sprite[] m_poMenuSprit = new Sprite[14];
    public GameObject[] PlayerList = new GameObject[14];
    public GameObject m_oExplain;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
                            //1Select,  2Select,  3Select
    public void MenuSelect(int nMenu1,int nMenu2,int nNo)
    {   
       
        if (nNo == -1)
            return;
        m_poMenu1[nMenu1].SetActive(true);
        m_poMenu2[nMenu2].SetActive(true);
       
        switch(nMenu1)
        {
            case 0:
                {
                    
                    switch(nMenu2)
                    {
                        case 0: //nNo 코드 0~10까지
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 1:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 2:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;                            
                    }

                }
                break;
            case 1:
                {
                    switch(nMenu2)
                    {
                        case 0:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);

                            }
                            break;
                        case 1:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);

                            }
                            break;
                        case 2:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);

                            }
                            break;
                        case 3:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 4:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 5:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                    }
                }
                break;
            case 2:
                {
                    switch(nMenu2)
                    {
                        case 0:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 1:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 2:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                    }
                }
                break;
            case 3:
                {
                    switch (nMenu2)
                    {
                        case 0:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 1:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 2:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 3:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 4:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 5:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                    }

                }
                break;
            case 4:
                {
                    switch(nMenu2)
                    {
                        case 0:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 1:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 2:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 3:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 4:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 5:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                        case 6:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                             case 7:
                            {
                                for (int i = 0; i < 14; i++)
                                    m_poMenu3[i].GetComponent<Image>().sprite = m_poMenuSprit[i];

                                m_poMenu3[nNo].GetComponent<Image>().sprite = m_poMenuSpriteSelect[nNo];
                                m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLANIN_MENU3_1MONO + nNo);
                            }
                            break;
                    }
                }break;
        }
        
        
        
    }
}
