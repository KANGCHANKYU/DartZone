using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class csMenu_2 : MonoBehaviour
{
    public GameObject m_logle;

	void Awake ()
    {
        
	}
	
	
	void Update ()
    {
        
    }

    public void SelectMeun(int meun1,int meun2,int meun3,int nNo)
    {

        switch (meun1)
        {
            case 0: //Practice
                {
                    m_logle.GetComponent<csPractice>().LogleMeun(meun2, meun3, nNo);
                }
                break;
            case 1: //01Game
                {
                    switch (meun2)
                    {
                        case 0: //301
                            {
                                m_logle.GetComponent<cs01Game_1>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 1: //501
                            {
                                m_logle.GetComponent<cs01Game_1>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 2: //701
                            {
                                m_logle.GetComponent<cs01Game_1>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;//3이후로 _2로
                        case 3:  //901
                            {
                                m_logle.GetComponent<cs01Game_2>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 4:  //1101
                            {
                                m_logle.GetComponent<cs01Game_2>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 5: //1501
                            {
                                m_logle.GetComponent<cs01Game_2>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                    }
                }
                break;
            case 2: //Cricket
                {
                    m_logle.GetComponent<csCricket>().LogleMeun(meun2, meun3, nNo);
                }
                break;
            case 3: //Party Game
                {
                    switch(meun2)
                    {
                        case 0:
                            {
                                m_logle.GetComponent<csPartygame_1>().LogleMeun(meun2, meun3, nNo);
                            }break;
                        case 1:
                            {
                                m_logle.GetComponent<csPartygame_1>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 2:
                            {
                                m_logle.GetComponent<csPartygame_1>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 3:
                            {
                                m_logle.GetComponent<csPartygame_2>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 4:
                            {
                                m_logle.GetComponent<csPartygame_2>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 5:
                            {
                                m_logle.GetComponent<csPartygame_2>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                    }
                }
                break;
            case 4: //Event Game
                {
                    switch(meun2)
                    {
                        case 0:
                            {
                                m_logle.GetComponent<csEventgame_1>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 1:
                            {
                                m_logle.GetComponent<csEventgame_1>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 2:
                            {
                                m_logle.GetComponent<csEventgame_1>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 3:
                            {
                                m_logle.GetComponent<csEvnetgame_2>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 4:
                            {
                                m_logle.GetComponent<csEvnetgame_2>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 5:
                            {
                                m_logle.GetComponent<csEvnetgame_2>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                        case 6:
                            {
                                m_logle.GetComponent<csEvnetgame_2>().LogleMeun(meun2, meun3, nNo);
                            }
                            break;
                    }
                    
                }
                break;
           
        

        }

    }
}

