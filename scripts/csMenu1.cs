using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csMenu1 : MonoBehaviour
{
    
    public GameObject[] m_poMenu = new GameObject[5]; //메뉴창
    public Sprite[] m_poMenuSpritesSelect = new Sprite[5]; //활성화 이미지
    public Sprite[] m_poMenuSprites = new Sprite[5]; //off이미지

    public GameObject m_oExplain;

    void Start()
    {
        
         
    }

    void OnEnable()
    {
        for (int i = 0; i < 5; i++)
        {
            m_poMenu[i].GetComponent<Image>().sprite = m_poMenuSprites[i];
        }
        m_poMenu[0].GetComponent<Image>().sprite = m_poMenuSpritesSelect[0];
        
    }
    

    void Update()
    {
        
    }

    public void MenuSelect(int nNo)
    {
        for (int i = 0; i < 5; i++)
        {
            m_poMenu[i].GetComponent<Image>().sprite = m_poMenuSprites[i];
           
        }    
        
        m_poMenu[nNo].GetComponent<Image>().sprite = m_poMenuSpritesSelect[nNo];
        switch(nNo)
        {
            case 0:
                {                
                    m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLAIN_MENU1_PRACTICE);
                }
                break;
            case 1:
                {
                    m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLAIN_MENU1_01GAME);
                }
                break;
            case 2:
                {
                    m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLAIN_MENU1_CRICKET);
                }
                break;
            case 3:
                {
                    m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLAIN_MENU1_PARTYGAME);
                }
                break;
            case 4:
                {
                    m_oExplain.GetComponent<csExplain>().SetExplain(csSingleton.getInstance._EXPLAIN_MENU1_EVENTGAME);
                }
                break;
        }


    }
}
