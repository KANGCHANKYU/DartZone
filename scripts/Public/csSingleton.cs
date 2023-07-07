using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csSingleton : MonoBehaviour
{
    private static csSingleton instance;
    
    public static csSingleton getInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(csSingleton)) as csSingleton;
            }

            if (instance == null)
            {
                GameObject obj = new GameObject("obj");
                instance = obj.AddComponent(typeof(csSingleton)) as csSingleton;
            }

            return instance;
        }
    }

    public int _MENU2_NUM_PRACTICE = 3;
    public int _MENU2_NUM_01GAME = 6; 
    public int _MENU2_NUM_CRICKET = 3;
    public int _MENU2_NUM_PARTYGAME = 6;
    public int _MENU2_NUM_EVENTGAME = 7;

    public int _EXPLAIN_MENU1_PRACTICE = 0; //PRACTICE 첫번쨰 메뉴
    public int _EXPLAIN_MENU1_01GAME = 1; //01Game첫번쨰 메뉴
    public int _EXPLAIN_MENU1_CRICKET = 2; //CRICKET 첫번째 메뉴
    public int _EXPLAIN_MENU1_PARTYGAME = 3; //PARTY GAME첫번쨰 메뉴
    public int _EXPLAIN_MENU1_EVENTGAME = 4; //EVENT GAME첫번쨰 메뉴

    public int _EXPLAIN_MENU2_COUNTUP = 5; //PRACTICE 두번째 메뉴중 첫번쨰
    public int _EXPLAIN_MENU2_KINGOFBULL = 6; //PRACTICE 두번쨰 메뉴중 두번쨰
    public int _EXPLAIN_MENU2_TAKESCORE = 7; //PRACTICE 두번쨰 메뉴중 세번쨰

    public int _EXPLAIN_MENU2_301 = 8; //01GAME 두번쨰 메뉴중 첫번쨰
    public int _EXPLAIN_MENU2_501 = 9; //01GANE 두번쨰 메뉴중 두번쨰
    public int _EXPLAIN_MENU2_701 = 10; //01GANE 두번쨰 메뉴중 세번쨰
    public int _EXPLAIN_MENU2_901 = 11; //01GAME 두번쨰 메뉴중 네번쨰
    public int _EXPLAIN_MENU2_1101 = 12; //01GAME 두번쨰 메뉴중 다섯번쨰
    public int _EXPLAIN_MENU2_1501 = 13; //01GAME 두번쨰 메뉴중 여섯번쨰

    public int _EXPLAIN_MENU2_STANDARDCR = 14; //CRLCKET 두번쨰 메뉴중 첫번쨰
    public int _EXPLAIN_MENU2_CUTTHROATCR = 15; //CRLCKT 두번째 메뉴중 두번째
    public int _EXPLAIN_MENU2_HIDDENCR = 16; // CRLCKT 두번쨰 메뉴중 세번째 

    public int _EXPLAIN_MENU2_PT301 = 17; //PARTY GAME 두번쟤 메뉴중 첫번쨰
    public int _EXPLAIN_MENU2_PT501 = 18; //PARTY GAME 두번째 메뉴중 두번째
    public int _EXPLAIN_MENU2_PTCOUNTUP = 19; //PARTY GAME 두번쨰 메뉴중 세번쨰
    public int _EXPLAIN_MENU2_PTKINGOFBULL = 20; //PARTY GAME 두번째 메뉴중 네번쨰
    public int _EXPLAIN_MENU2_PTTAKESCORE = 21; //PARTY GAME 두번쨰 메뉴중 다섯번쨰
    public int _EXPLAIN_MENU2_PTSTANDARDCR = 22; //PARTY GAME 두번째 메뉴중 여섯번쨰

    public int _EXPLAIN_MENU2_BINGGO33 = 23; //ENENT GAME 두번쨰 메뉴중 첫번쨰
    public int _EXPLAIN_MENU2_BINGGO44 = 24; //ENENT GAME 두번쨰 메뉴중 두번쟤
    public int _EXPLAIN_MENU2_BINGGO55 = 25; //ENET GAME 두번쨰 메뉴중 세번쨰
    public int _EXPLAIN_MENU2_billbingo33 = 26;
    public int _EXPLAIN_MENU2_billbingo44 = 27;
    public int _EXPLAIN_MENU2_billbingo55 = 28;
    public int _EXPLAIN_MENU2_FITNUMBER = 29; //ENET GAME 두번쨰 메뉴중 네번쨰  
    public int _EXPLANIN_MENU3_1MONO = 30;
    public int _EXPLANIN_MENU3_2MONO = 31;
    public int _EXPLANIN_MENU3_3MONO = 32;
    public int _EXPLANIN_MENU3_4MONO = 33;
    public int _EXPLANIN_MENU3_DOU22 = 34;
    public int _EXPLANIN_MENU3_DOU222 = 35;
    public int _EXPLANIN_MENU3_DOU2222 = 36;    
    public int _EXPLANIN_MENU3_TRI33 = 37;
    public int _EXPLANIN_MENU3_TRI333 = 38;
    public int _EXPLANIN_MENU3_TRI3333 = 39;
    public int _EXPLANIN_MENU3_TETRA44 = 40;
    public int _EXPLANIN_MENU3_TETRA444 = 41;
    public int _EXPLANIN_MENU3_TETRA4444 = 42;
    public int _EXPLANIN_MENU3_PENTA55= 43;
    public int _EXPLANIN_MENU3_HEAXA = 44;   
    public int _EXPLAIN_NUM = 45; //배열의 길이의 마지막 위에 이미지 저장용도

    // 방향키, 옵션, 시작
    public bool g_bSwitch = false;
    public int g_nSwitch = -1;

    // 타겟
    public bool g_bTarget = false;
    public int g_nTargetScore = -1;
    public int g_nTargetBasicScore = -1;
    public int g_nTargetLine = -1;

    public ENUM_TARGET_SCORE g_enumSignal;

}
