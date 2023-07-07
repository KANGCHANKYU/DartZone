using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class H_CGameManager : MonoBehaviour
{
    public int meun2 = 0;
    public int meun3 = 0;
    public int Teams = 0;
    public int Players = 0;
    public int RoundStop = 15;
    public int[] RandomValue = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 25 };

    public string player1;
    public string player2;
    public string player3;
    public string player4;
    public string player5;
    public string player6;
    public string player7;
    public string player8;
    public string player9;
    public string player10;
    public string player11;
    public string player12;

    public bool isOpen = false;
    public bool isAni = false;

    public GameObject g_save;
    public GameObject[] g_Playerbar = new GameObject[3];
    public GameObject[] g_Teambar = new GameObject[3];
    public GameObject[] g_DartAni = new GameObject[4];
    public GameObject[] g_Dart = new GameObject[3];
    public GameObject[] g_BlueDartScore = new GameObject[3];
    public GameObject[] g_OrangDartScore = new GameObject[3];
    public GameObject[] g_BlackDartScore = new GameObject[3];
    public GameObject[] g_MPRScore = new GameObject[12];
    public GameObject[] g_RoundScore = new GameObject[12];
    public GameObject[] g_Movie = new GameObject[7];
    public GameObject[] g_Winner = new GameObject[4];
    public GameObject[] g_Scorebar = new GameObject[3];
    public GameObject[] g_T20Line = new GameObject[21];
    public GameObject[] g_T19Line = new GameObject[21];
    public GameObject[] g_T18Line = new GameObject[21];
    public GameObject[] g_T17Line = new GameObject[21];
    public GameObject[] g_T16Line = new GameObject[21];
    public GameObject[] g_T15Line = new GameObject[21];
    public GameObject[] g_TBullLine = new GameObject[21];
    public GameObject[] g_TAni = new GameObject[6];
    public GameObject[] g_Tr20Line = new GameObject[21];
    public GameObject[] g_Tr19Line = new GameObject[21];
    public GameObject[] g_Tr18Line = new GameObject[21];
    public GameObject[] g_Tr17Line = new GameObject[21];
    public GameObject[] g_Tr16Line = new GameObject[21];
    public GameObject[] g_Tr15Line = new GameObject[21];
    public GameObject[] g_TrBullLine = new GameObject[21];
    public GameObject[] g_TrAni = new GameObject[6];
    public GameObject[] g_F20Line = new GameObject[21];
    public GameObject[] g_F19Line = new GameObject[21];
    public GameObject[] g_F18Line = new GameObject[21];
    public GameObject[] g_F17Line = new GameObject[21];
    public GameObject[] g_F16Line = new GameObject[21];
    public GameObject[] g_F15Line = new GameObject[21];
    public GameObject[] g_FBullLine = new GameObject[21];
    public GameObject[] g_FAni = new GameObject[6];
    public GameObject g_DAniOn;
    public GameObject g_MoveOn;
    public GameObject g_Meun;

    public Sprite[] i_Score = new Sprite[5];

    public Save sc_save;
    public _01Meun meun;

    public TwoPlayers two;
    public H_ThreePlayer three;
    public H_FourPlayers four;

    public H_dou22 dou22;
    public H_dou222 dou222;
    public H_dou2222 dou2222;

    public H_tir33 tir33;
    public H_tir333 tir333;
    public H_tir3333 tir3333;

    public H_four44 four44;
    public H_four444 four444;

    public H_five55 five55;
    public H_hexa66 hexa66;

    void Awake()
    {
        g_save = GameObject.FindWithTag("Save");
        sc_save = g_save.GetComponent<Save>();

        meun2 = sc_save.meun2;
        meun3 = sc_save.meun3;
        Players = sc_save.Players;
        Teams = sc_save.Teams;

        player1 = sc_save.player1;
        player2 = sc_save.player2;
        player3 = sc_save.player3;
        player4 = sc_save.player4;
        player5 = sc_save.player5;
        player6 = sc_save.player6;
        player7 = sc_save.player7;
        player8 = sc_save.player8;
        player9 = sc_save.player9;
        player10 = sc_save.player10;
        player11 = sc_save.player11;
        player12 = sc_save.player12;

        two = g_Playerbar[0].GetComponent<TwoPlayers>();
        three = g_Playerbar[1].GetComponent<H_ThreePlayer>();
        four = g_Playerbar[2].GetComponent<H_FourPlayers>();

        dou22 = g_Teambar[0].GetComponent<H_dou22>();
        dou222 = g_Teambar[1].GetComponent<H_dou222>();
        dou2222 = g_Teambar[2].GetComponent<H_dou2222>();

        tir33 = g_Teambar[0].GetComponent<H_tir33>();
        tir333 = g_Teambar[1].GetComponent<H_tir333>();
        tir3333 = g_Teambar[2].GetComponent<H_tir3333>();

        four44 = g_Teambar[0].GetComponent<H_four44>();
        four444 = g_Teambar[1].GetComponent<H_four444>();

        five55 = g_Teambar[0].GetComponent<H_five55>();
        hexa66 = g_Teambar[0].GetComponent<H_hexa66>();

        for(int i=0;i<g_T20Line.Length;i++)
        {
            g_T20Line[i].SetActive(false);
            g_T19Line[i].SetActive(false);
            g_T18Line[i].SetActive(false);
            g_T17Line[i].SetActive(false);
            g_T16Line[i].SetActive(false);
            g_T15Line[i].SetActive(false);
            g_TBullLine[i].SetActive(false);
            g_Tr20Line[i].SetActive(false);
            g_Tr19Line[i].SetActive(false);
            g_Tr18Line[i].SetActive(false);
            g_Tr17Line[i].SetActive(false);
            g_Tr16Line[i].SetActive(false);
            g_Tr15Line[i].SetActive(false);
            g_TrBullLine[i].SetActive(false);
            g_F20Line[i].SetActive(false);
            g_F19Line[i].SetActive(false);
            g_F18Line[i].SetActive(false);
            g_F17Line[i].SetActive(false);
            g_F16Line[i].SetActive(false);
            g_F15Line[i].SetActive(false);
            g_FBullLine[i].SetActive(false);
        }

        for (int i = 0; i < g_Playerbar.Length; i++)
        {
            g_Playerbar[i].SetActive(false);
            g_Teambar[i].SetActive(false);
        }

        for (int i = 0; i < g_Scorebar.Length; i++)
            g_Scorebar[i].SetActive(false);

        for (int i = 0; i < g_BlackDartScore.Length; i++)
        {
            g_BlackDartScore[i].GetComponent<csNumber>().CreateNumber(2, 65, 1f, 0);
            g_BlueDartScore[i].GetComponent<csNumber>().CreateNumber(2, 65, 1f, 0);
            g_OrangDartScore[i].GetComponent<csNumber>().CreateNumber(2, 65, 1f, 0);
            g_BlackDartScore[i].GetComponent<csNumber>().SetNumber(-1);
            g_BlueDartScore[i].GetComponent<csNumber>().SetNumber(-1);
            g_OrangDartScore[i].GetComponent<csNumber>().SetNumber(-1);
        }
        g_Meun.SetActive(false);

        for (int i = 0; i < g_DartAni.Length; i++)
            g_DartAni[i].SetActive(false);
        for (int i = 0; i < g_MPRScore.Length; i++)
        {
            g_MPRScore[i].SetActive(false);
            g_RoundScore[i].SetActive(false);
        }

        for (int i = 0; i < g_Movie.Length; i++)
            g_Movie[i].SetActive(false);
        for (int i = 0; i < g_Winner.Length; i++)
            g_Winner[i].SetActive(false);

        for (int i = 0; i < 6; ++i)
        {
            int ranIdx = Random.Range(1,RandomValue.Length) ;

            int tmp = RandomValue[ranIdx];
            RandomValue[ranIdx] = RandomValue[i];
            RandomValue[i] = tmp;
        }


        NumberAction(meun2, meun3);
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad6) && !isOpen || (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1004) && !isOpen)
        {
            isOpen = true;
            g_Meun.SetActive(true);
            csSingleton.getInstance.g_bSwitch = false;
        }
        if (Input.GetKeyDown(KeyCode.Keypad6) && isOpen && meun.m_nMeunSelect <= 0 ||
            (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1004) && isOpen && meun.m_nMeunSelect <= 0)
        {
            meun.m_nMeunSelect = -1;
            meun.Expain.enabled = true;
            meun.RuleExpaln.SetActive(true);
            csSingleton.getInstance.g_bSwitch = false;
        }
        if (Input.GetKeyDown(KeyCode.Keypad6) && isOpen && meun.m_nMeunSelect == -1 ||
    (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1004) && isOpen && meun.m_nMeunSelect == -1)
        {
            isOpen = false;
            g_Meun.SetActive(false);
            meun.m_nMeunSelect = 0;
            csSingleton.getInstance.g_bSwitch = false;
        }
        if (Input.GetKeyDown(KeyCode.Keypad7) && isOpen || (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1005) && isOpen)
        {
            meun.GetComponent<_01Meun>().ArrowButton(100);
            csSingleton.getInstance.g_bSwitch = false;
        }
        if (Input.GetKeyDown(KeyCode.Keypad8) && isOpen || (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1000) && isOpen)
        {
            meun.GetComponent<_01Meun>().ArrowButton(0);
            csSingleton.getInstance.g_bSwitch = false;
        }
        if (Input.GetKeyDown(KeyCode.Keypad9) && isOpen || (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1001) && isOpen)
        {
            meun.GetComponent<_01Meun>().ArrowButton(1);
            csSingleton.getInstance.g_bSwitch = false;
        }

    }

    public void NumberAction(int meun2, int meun3)
    {
        switch (meun2)
        {
            case 2:
                {
                    switch (meun3)
                    {
                        case 0: //2mono
                            {
                                two.RoundStop = RoundStop;
                                two.playername[0] = player1;
                                two.playername[1] = player2;
                                two._20Line = RandomValue[0];
                                two._19Line = RandomValue[1];
                                two._18Line = RandomValue[2];
                                two._17Line = RandomValue[3];
                                two._16Line = RandomValue[4];
                                two._15Line = RandomValue[5];
                                two._BullLine = RandomValue[6];

                                g_Playerbar[0].SetActive(true);
                                g_Scorebar[0].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                            }
                            break;
                        case 1: //3mono
                            {
                                g_Playerbar[1].SetActive(true);
                                g_Scorebar[1].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                three.RoundStop = RoundStop;
                                three.playername[0] = player1;
                                three.playername[1] = player2;
                                three.playername[2] = player3;

                                three._20Line = RandomValue[0];
                                three._19Line = RandomValue[1];
                                three._18Line = RandomValue[2];
                                three._17Line = RandomValue[3];
                                three._16Line = RandomValue[4];
                                three._15Line = RandomValue[5];
                                three._BullLine = RandomValue[6];
                            }
                            break;
                        case 2:
                            {
                                g_Playerbar[2].SetActive(true);
                                g_Scorebar[2].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                four.RoundStop = RoundStop;

                                four.playername[0] = player1;
                                four.playername[1] = player2;
                                four.playername[2] = player3;
                                four.playername[3] = player4;

                                four._20Line = RandomValue[0];
                                four._19Line = RandomValue[1];
                                four._18Line = RandomValue[2];
                                four._17Line = RandomValue[3];
                                four._16Line = RandomValue[4];
                                four._15Line = RandomValue[5];
                                four._BullLine = RandomValue[6];

                            }
                            break;
                        case 3:
                            {
                                dou22.enabled = true;
                                tir33.enabled = false;
                                four44.enabled = false;
                                five55.enabled = false;
                                hexa66.enabled = false;

                                g_Teambar[0].SetActive(true);
                                g_Scorebar[0].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                dou22.RoundStop = RoundStop;

                                dou22.playername[0] = player1;
                                dou22.playername[1] = player2;
                                dou22.playername[2] = player3;
                                dou22.playername[2] = player4;

                                dou22._20Line = RandomValue[0];
                                dou22._19Line = RandomValue[1];
                                dou22._18Line = RandomValue[2];
                                dou22._17Line = RandomValue[3];
                                dou22._16Line = RandomValue[4];
                                dou22._15Line = RandomValue[5];
                                dou22._BullLine = RandomValue[6];


                            }
                            break;
                        case 4:
                            {
                                dou222.enabled = true;
                                tir333.enabled = false;
                                four444.enabled = false;

                                g_Teambar[1].SetActive(true);
                                g_Scorebar[1].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                dou222.RoundStop = RoundStop;

                                dou222.playername[0] = player1;
                                dou222.playername[1] = player2;
                                dou222.playername[2] = player3;
                                dou222.playername[3] = player4;
                                dou222.playername[4] = player5;
                                dou222.playername[5] = player6;

                                dou222._20Line = RandomValue[0];
                                dou222._19Line = RandomValue[1];
                                dou222._18Line = RandomValue[2];
                                dou222._17Line = RandomValue[3];
                                dou222._16Line = RandomValue[4];
                                dou222._15Line = RandomValue[5];
                                dou222._BullLine = RandomValue[6];

                            }
                            break;
                        case 5:
                            {
                                dou2222.enabled = true;
                                tir3333.enabled = false;

                                g_Teambar[2].SetActive(true);
                                g_Scorebar[2].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                dou2222.RoundStop = RoundStop;

                                dou2222.playername[0] = player1;
                                dou2222.playername[1] = player2;
                                dou2222.playername[2] = player3;
                                dou2222.playername[3] = player4;
                                dou2222.playername[4] = player5;
                                dou2222.playername[5] = player6;
                                dou2222.playername[6] = player7;
                                dou2222.playername[7] = player8;

                                dou2222._20Line = RandomValue[0];
                                dou2222._19Line = RandomValue[1];
                                dou2222._18Line = RandomValue[2];
                                dou2222._17Line = RandomValue[3];
                                dou2222._16Line = RandomValue[4];
                                dou2222._15Line = RandomValue[5];
                                dou2222._BullLine = RandomValue[6];

                            }
                            break;
                        case 6:
                            {
                                dou22.enabled = false;
                                tir33.enabled = true;
                                four44.enabled = false;
                                five55.enabled = false;
                                hexa66.enabled = false;

                                g_Teambar[0].SetActive(true);
                                g_Scorebar[0].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                tir33.RoundStop = RoundStop;

                                tir33.playername[0] = player1;
                                tir33.playername[1] = player2;
                                tir33.playername[2] = player3;
                                tir33.playername[3] = player4;
                                tir33.playername[4] = player5;
                                tir33.playername[5] = player6;

                                tir33._20Line = RandomValue[0];
                                tir33._19Line = RandomValue[1];
                                tir33._18Line = RandomValue[2];
                                tir33._17Line = RandomValue[3];
                                tir33._16Line = RandomValue[4];
                                tir33._15Line = RandomValue[5];
                                tir33._BullLine = RandomValue[6];


                            }
                            break;
                        case 7:
                            {
                                dou222.enabled = false;
                                tir333.enabled = true;
                                four444.enabled = false;

                                g_Teambar[1].SetActive(true);
                                g_Scorebar[1].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                tir333.RoundStop = RoundStop;

                                tir333.playername[0] = player1;
                                tir333.playername[1] = player2;
                                tir333.playername[2] = player3;
                                tir333.playername[3] = player4;
                                tir333.playername[4] = player5;
                                tir333.playername[5] = player6;
                                tir333.playername[6] = player7;
                                tir333.playername[7] = player8;
                                tir333.playername[8] = player9;

                                tir333._20Line = RandomValue[0];
                                tir333._19Line = RandomValue[1];
                                tir333._18Line = RandomValue[2];
                                tir333._17Line = RandomValue[3];
                                tir333._16Line = RandomValue[4];
                                tir333._15Line = RandomValue[5];
                                tir333._BullLine = RandomValue[6];


                            }
                            break;
                        case 8:
                            {
                                dou2222.enabled = false;
                                tir3333.enabled = true;

                                g_Teambar[2].SetActive(true);
                                g_Scorebar[2].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                tir3333.RoundStop = RoundStop;

                                tir3333.playername[0] = player1;
                                tir3333.playername[1] = player2;
                                tir3333.playername[2] = player3;
                                tir3333.playername[3] = player4;
                                tir3333.playername[4] = player5;
                                tir3333.playername[5] = player6;
                                tir3333.playername[6] = player7;
                                tir3333.playername[7] = player8;
                                tir3333.playername[8] = player9;
                                tir3333.playername[9] = player10;
                                tir3333.playername[10] = player11;
                                tir3333.playername[11] = player12;

                                tir3333._20Line = RandomValue[0];
                                tir3333._19Line = RandomValue[1];
                                tir3333._18Line = RandomValue[2];
                                tir3333._17Line = RandomValue[3];
                                tir3333._16Line = RandomValue[4];
                                tir3333._15Line = RandomValue[5];
                                tir3333._BullLine = RandomValue[6];


                            }
                            break;
                        case 9:
                            {
                                dou22.enabled = false;
                                tir33.enabled = false;
                                four44.enabled = true;
                                five55.enabled = false;
                                hexa66.enabled = false;

                                g_Teambar[0].SetActive(true);
                                g_Scorebar[0].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                four44.RoundStop = RoundStop;

                                four44.playername[0] = player1;
                                four44.playername[1] = player2;
                                four44.playername[2] = player3;
                                four44.playername[3] = player4;
                                four44.playername[4] = player5;
                                four44.playername[5] = player6;
                                four44.playername[6] = player7;
                                four44.playername[7] = player8;

                                four44._20Line = RandomValue[0];
                                four44._19Line = RandomValue[1];
                                four44._18Line = RandomValue[2];
                                four44._17Line = RandomValue[3];
                                four44._16Line = RandomValue[4];
                                four44._15Line = RandomValue[5];
                                four44._BullLine = RandomValue[6];
                            }
                            break;
                        case 10:
                            {
                                dou222.enabled = false;
                                tir333.enabled = false;
                                four444.enabled = true;

                                g_Teambar[1].SetActive(true);
                                g_Scorebar[1].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                four444.RoundStop = RoundStop;

                                four444.playername[0] = player1;
                                four444.playername[1] = player2;
                                four444.playername[2] = player3;
                                four444.playername[3] = player4;
                                four444.playername[4] = player5;
                                four444.playername[5] = player6;
                                four444.playername[6] = player7;
                                four444.playername[7] = player8;
                                four444.playername[8] = player9;
                                four444.playername[9] = player10;
                                four444.playername[10] = player11;
                                four444.playername[11] = player12;


                                four444._20Line = RandomValue[0];
                                four444._19Line = RandomValue[1];
                                four444._18Line = RandomValue[2];
                                four444._17Line = RandomValue[3];
                                four444._16Line = RandomValue[4];
                                four444._15Line = RandomValue[5];
                                four444._BullLine = RandomValue[6];

                            }
                            break;
                        case 11:
                            {
                                dou22.enabled = false;
                                tir33.enabled = false;
                                four44.enabled = false;
                                five55.enabled = true;
                                hexa66.enabled = false;

                                g_Teambar[0].SetActive(true);
                                g_Scorebar[0].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                five55.RoundStop = RoundStop;

                                five55.playername[0] = player1;
                                five55.playername[1] = player2;
                                five55.playername[2] = player3;
                                five55.playername[3] = player4;
                                five55.playername[4] = player5;
                                five55.playername[5] = player6;
                                five55.playername[6] = player7;
                                five55.playername[7] = player8;
                                five55.playername[8] = player9;
                                five55.playername[9] = player10;

                                five55._20Line = RandomValue[0];
                                five55._19Line = RandomValue[1];
                                five55._18Line = RandomValue[2];
                                five55._17Line = RandomValue[3];
                                five55._16Line = RandomValue[4];
                                five55._15Line = RandomValue[5];
                                five55._BullLine = RandomValue[6];
                            }
                            break;
                        case 12:
                            {
                                dou22.enabled = false;
                                tir33.enabled = false;
                                four44.enabled = false;
                                five55.enabled = false;
                                hexa66.enabled = true;

                                g_Teambar[0].SetActive(true);
                                g_Scorebar[0].SetActive(true);
                                g_MPRScore[0].SetActive(true);
                                g_RoundScore[0].SetActive(true);

                                hexa66.RoundStop = RoundStop;

                                hexa66.playername[0] = player1;
                                hexa66.playername[1] = player2;
                                hexa66.playername[2] = player3;
                                hexa66.playername[3] = player4;
                                hexa66.playername[4] = player5;
                                hexa66.playername[5] = player6;
                                hexa66.playername[6] = player7;
                                hexa66.playername[7] = player8;
                                hexa66.playername[8] = player9;
                                hexa66.playername[9] = player10;
                                hexa66.playername[10] = player11;
                                hexa66.playername[11] = player12;

                                hexa66._20Line = RandomValue[0];
                                hexa66._19Line = RandomValue[1];
                                hexa66._18Line = RandomValue[2];
                                hexa66._17Line = RandomValue[3];
                                hexa66._16Line = RandomValue[4];
                                hexa66._15Line = RandomValue[5];
                                hexa66._BullLine = RandomValue[6];

                            }
                            break;
                    }
                }
                break;
        }
    }

    public void DartScoreActor(int nDartLine, int nDartScore, int DartCount)
    {
        switch (nDartScore)
        {
            case 25:
                {
                    if (1 == nDartLine)
                    {
                        g_DartAni[2].SetActive(true);
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[3];
                    }
                    else if (2 == nDartLine)
                    {
                        g_DartAni[3].SetActive(true);
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[4];
                    }
                    else
                    {
                    }
                }
                break;
            case 20:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(20);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(20);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(20);
                    }
                    else
                    {
                    }
                }
                break;
            case 19:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(19);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(19);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(19);
                    }
                    else
                    {
                    }
                }
                break;
            case 18:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(18);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(18);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(18);
                    }
                    else
                    {
                    }
                }
                break;
            case 17:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(17);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(17);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(17);
                    }
                    else
                    {
                    }
                }
                break;
            case 16:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(16);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(16);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(16);
                    }
                    else
                    {
                    }
                }
                break;
            case 15:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(15);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(15);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(15);
                    }
                    else
                    {
                    }
                }
                break;
            case 14:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(14);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(14);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(14);
                    }
                    else
                    {
                    }
                }
                break;
            case 13:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(13);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(13);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(13);
                    }
                    else
                    {
                    }
                }
                break;
            case 12:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(12);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(12);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(12);
                    }
                    else
                    {
                    }
                }
                break;
            case 11:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(11);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(11);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(11);
                    }
                    else
                    {
                    }
                }
                break;
            case 10:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(10);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(10);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(10);
                    }
                    else
                    {
                    }
                }
                break;
            case 9:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(9);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(9);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(9);
                    }
                    else
                    {
                    }
                }
                break;
            case 8:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(8);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(8);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(8);
                    }
                    else
                    {
                    }
                }
                break;
            case 7:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(7);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(7);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(7);
                    }
                    else
                    {
                    }
                }
                break;
            case 6:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(6);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(6);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(6);
                    }
                    else
                    {
                    }
                }
                break;
            case 5:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(5);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(5);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(5);
                    }
                    else
                    {
                    }
                }
                break;
            case 4:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(4);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(4);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(4);
                    }
                    else
                    {
                    }
                }
                break;
            case 3:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(3);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(3);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(3);
                    }
                    else
                    {
                    }
                }
                break;
            case 2:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(2);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(2);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(2);
                    }
                    else
                    {
                    }
                }
                break;
            case 1:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(1);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(1);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(1);
                    }
                    else
                    {
                    }
                }
                break;
        }

        if (nDartLine == 3 && nDartScore != 25 && nDartScore != 50)
        {
            g_DartAni[1].SetActive(true);
            g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[2];
        }
        else if (nDartLine == 2 && nDartScore != 25 && nDartScore != 50)
        {
            g_DartAni[0].SetActive(true);
            g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[1];
        }
        else if (nDartLine == 1 && nDartScore != 25 && nDartScore != 50)
        {
            g_Dart[DartCount].GetComponent<Image>().sprite = i_Score[0];
        }
        else
        {
        }
        Invoke("AniStop", 1.5f);
    }

    void AniStop()
    {
        for (int i = 0; i < g_DartAni.Length; i++)
            g_DartAni[i].SetActive(false);
    }

    public void DartScoreReSet()
    {
        for (int i = 0; i < g_BlackDartScore.Length; i++)
        {
            g_BlackDartScore[i].GetComponent<csNumber>().SetNumber(-1);
            g_BlueDartScore[i].GetComponent<csNumber>().SetNumber(-1);
            g_OrangDartScore[i].GetComponent<csNumber>().SetNumber(-1);
        }
    }

    public void MoviePlay(int nNo)
    {
        isAni = true;
        g_MoveOn.SetActive(true);
        g_Movie[nNo].SetActive(true);
        if (nNo == 1) //DeadEye
            Invoke("MovieStop", 16f);
        else if (nNo == 2) //Hattrick
            Invoke("MovieStop", 10f);
        else if (nNo == 3) //hightton
            Invoke("MovieStop", 9f);
        else if (nNo == 4) //lowton
            Invoke("MovieStop", 16f);
        else if (nNo == 5) //threeinabed
            Invoke("MovieStop", 14f);
        else if (nNo == 6) //wihitehore
            Invoke("MovieStop", 9f);
        else
        {
        }
    }

    void TestTeamScore()
    {
        for (int i = 0; i < g_Winner.Length; i++)
            g_Winner[i].SetActive(false);
        isAni = false;
    }

    void MovieStop()
    {
        for (int i = 0; i < g_Movie.Length; i++)
            g_Movie[i].SetActive(false);
        isAni = false;
    }

    public void GameEndRead(int win)
    {
        switch (meun2)
        {
            case 2:
                {
                    switch (meun3)
                    {
                        case 0: //2mo
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = two.playername[0];
                                sc_save.player2 = two.playername[1];

                                sc_save.MPR1 = two.Average1;
                                sc_save.MPR2 = two.Average2;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 1: //3mo
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = three.playername[0];
                                sc_save.player2 = three.playername[1];
                                sc_save.player3 = three.playername[2];

                                sc_save.MPR1 = three.Average1;
                                sc_save.MPR2 = three.Average2;
                                sc_save.MPR3 = three.Average3;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 2:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = four.playername[0];
                                sc_save.player2 = four.playername[1];
                                sc_save.player3 = four.playername[2];
                                sc_save.player4 = four.playername[3];

                                sc_save.MPR1 = four.Average1;
                                sc_save.MPR2 = four.Average2;
                                sc_save.MPR3 = four.Average3;
                                sc_save.MPR4 = four.Average4;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 3:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = dou22.playername[0];
                                sc_save.player2 = dou22.playername[1];
                                sc_save.player3 = dou22.playername[2];
                                sc_save.player4 = dou22.playername[3];

                                sc_save.MPR1 = dou22.AverageA1;
                                sc_save.MPR2 = dou22.AverageA2;
                                sc_save.MPR3 = dou22.AverageB1;
                                sc_save.MPR4 = dou22.AverageB2;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 4:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = dou222.playername[0];
                                sc_save.player2 = dou222.playername[1];
                                sc_save.player3 = dou222.playername[2];
                                sc_save.player4 = dou222.playername[3];
                                sc_save.player5 = dou222.playername[4];
                                sc_save.player6 = dou222.playername[5];

                                sc_save.MPR1 = dou222.AverageA1;
                                sc_save.MPR2 = dou222.AverageA2;
                                sc_save.MPR3 = dou222.AverageB1;
                                sc_save.MPR4 = dou222.AverageB2;
                                sc_save.MPR5 = dou222.AverageC1;
                                sc_save.MPR6 = dou222.AverageC2;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 5:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = dou2222.playername[0];
                                sc_save.player2 = dou2222.playername[1];
                                sc_save.player3 = dou2222.playername[2];
                                sc_save.player4 = dou2222.playername[3];
                                sc_save.player5 = dou2222.playername[4];
                                sc_save.player6 = dou2222.playername[5];
                                sc_save.player7 = dou2222.playername[6];
                                sc_save.player8 = dou2222.playername[7];

                                sc_save.MPR1 = dou2222.AverageA1;
                                sc_save.MPR2 = dou2222.AverageA2;
                                sc_save.MPR3 = dou2222.AverageB1;
                                sc_save.MPR4 = dou2222.AverageB2;
                                sc_save.MPR5 = dou2222.AverageC1;
                                sc_save.MPR6 = dou2222.AverageC2;
                                sc_save.MPR7 = dou2222.AverageD1;
                                sc_save.MPR8 = dou2222.AverageD2;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 6:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = tir33.playername[0];
                                sc_save.player2 = tir33.playername[1];
                                sc_save.player3 = tir33.playername[2];
                                sc_save.player4 = tir33.playername[3];
                                sc_save.player5 = tir33.playername[4];
                                sc_save.player6 = tir33.playername[5];

                                sc_save.MPR1 = tir33.AverageA1;
                                sc_save.MPR2 = tir33.AverageA2;
                                sc_save.MPR3 = tir33.AverageA3;
                                sc_save.MPR4 = tir33.AverageB1;
                                sc_save.MPR5 = tir33.AverageB2;
                                sc_save.MPR6 = tir33.AverageB3;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 7:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = tir333.playername[0];
                                sc_save.player2 = tir333.playername[1];
                                sc_save.player3 = tir333.playername[2];
                                sc_save.player4 = tir333.playername[3];
                                sc_save.player5 = tir333.playername[4];
                                sc_save.player6 = tir333.playername[5];
                                sc_save.player7 = tir333.playername[6];
                                sc_save.player8 = tir333.playername[7];
                                sc_save.player9 = tir333.playername[8];

                                sc_save.MPR1 = tir333.AverageA1;
                                sc_save.MPR2 = tir333.AverageA2;
                                sc_save.MPR3 = tir333.AverageA3;
                                sc_save.MPR4 = tir333.AverageB1;
                                sc_save.MPR5 = tir333.AverageB2;
                                sc_save.MPR6 = tir333.AverageB3;
                                sc_save.MPR7 = tir333.AverageC1;
                                sc_save.MPR8 = tir333.AverageC2;
                                sc_save.MPR9 = tir333.AverageC3;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 8:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = tir3333.playername[0];
                                sc_save.player2 = tir3333.playername[1];
                                sc_save.player3 = tir3333.playername[2];
                                sc_save.player4 = tir3333.playername[3];
                                sc_save.player5 = tir3333.playername[4];
                                sc_save.player6 = tir3333.playername[5];
                                sc_save.player7 = tir3333.playername[6];
                                sc_save.player8 = tir3333.playername[7];
                                sc_save.player9 = tir3333.playername[8];
                                sc_save.player10 = tir3333.playername[9];
                                sc_save.player11 = tir3333.playername[10];
                                sc_save.player12 = tir3333.playername[11];

                                sc_save.MPR1 = tir3333.AverageA1;
                                sc_save.MPR2 = tir3333.AverageA2;
                                sc_save.MPR3 = tir3333.AverageA3;
                                sc_save.MPR4 = tir3333.AverageB1;
                                sc_save.MPR5 = tir3333.AverageB2;
                                sc_save.MPR6 = tir3333.AverageB3;
                                sc_save.MPR7 = tir3333.AverageC1;
                                sc_save.MPR8 = tir3333.AverageC2;
                                sc_save.MPR9 = tir3333.AverageC3;
                                sc_save.MPR10 = tir3333.AverageD1;
                                sc_save.MPR11 = tir3333.AverageD2;
                                sc_save.MPR12 = tir3333.AverageD3;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 9:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = four44.playername[0];
                                sc_save.player1 = four44.playername[1];
                                sc_save.player1 = four44.playername[2];
                                sc_save.player1 = four44.playername[3];
                                sc_save.player1 = four44.playername[4];
                                sc_save.player1 = four44.playername[5];
                                sc_save.player1 = four44.playername[6];
                                sc_save.player1 = four44.playername[7];

                                sc_save.MPR1 = four44.AverageA1;
                                sc_save.MPR2 = four44.AverageA2;
                                sc_save.MPR3 = four44.AverageA3;
                                sc_save.MPR4 = four44.AverageA4;
                                sc_save.MPR5 = four44.AverageB1;
                                sc_save.MPR6 = four44.AverageB2;
                                sc_save.MPR7 = four44.AverageB3;
                                sc_save.MPR8 = four44.AverageB4;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 10:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = four444.playername[0];
                                sc_save.player2 = four444.playername[1];
                                sc_save.player3 = four444.playername[2];
                                sc_save.player4 = four444.playername[3];
                                sc_save.player5 = four444.playername[4];
                                sc_save.player6 = four444.playername[5];
                                sc_save.player7 = four444.playername[6];
                                sc_save.player8 = four444.playername[7];
                                sc_save.player9 = four444.playername[8];
                                sc_save.player10 = four444.playername[9];
                                sc_save.player11 = four444.playername[10];
                                sc_save.player12 = four444.playername[11];

                                sc_save.MPR1 = four444.AverageA1;
                                sc_save.MPR2 = four444.AverageA2;
                                sc_save.MPR3 = four444.AverageA3;
                                sc_save.MPR4 = four444.AverageA4;
                                sc_save.MPR5 = four444.AverageB1;
                                sc_save.MPR6 = four444.AverageB2;
                                sc_save.MPR7 = four444.AverageB3;
                                sc_save.MPR8 = four444.AverageB4;
                                sc_save.MPR9 = four444.AverageC1;
                                sc_save.MPR10 = four444.AverageC2;
                                sc_save.MPR11 = four444.AverageC3;
                                sc_save.MPR12 = four444.AverageC4;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 11:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = five55.playername[0];
                                sc_save.player2 = five55.playername[1];
                                sc_save.player3 = five55.playername[2];
                                sc_save.player4 = five55.playername[3];
                                sc_save.player5 = five55.playername[4];
                                sc_save.player6 = five55.playername[5];
                                sc_save.player7 = five55.playername[6];
                                sc_save.player8 = five55.playername[7];
                                sc_save.player9 = five55.playername[8];
                                sc_save.player10 = five55.playername[9];

                                sc_save.MPR1 = five55.AverageA1;
                                sc_save.MPR2 = five55.AverageA2;
                                sc_save.MPR3 = five55.AverageA3;
                                sc_save.MPR4 = five55.AverageA4;
                                sc_save.MPR5 = five55.AverageA5;
                                sc_save.MPR6 = five55.AverageB1;
                                sc_save.MPR7 = five55.AverageB2;
                                sc_save.MPR8 = five55.AverageB3;
                                sc_save.MPR9 = five55.AverageB4;
                                sc_save.MPR10 = five55.AverageB5;

                                sc_save.MPR1 = five55.AverageA1;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                        case 12:
                            {
                                g_Winner[win].SetActive(true);

                                sc_save.player1 = hexa66.playername[0];
                                sc_save.player2 = hexa66.playername[1];
                                sc_save.player3 = hexa66.playername[2];
                                sc_save.player4 = hexa66.playername[3];
                                sc_save.player5 = hexa66.playername[4];
                                sc_save.player6 = hexa66.playername[5];
                                sc_save.player7 = hexa66.playername[6];
                                sc_save.player8 = hexa66.playername[7];
                                sc_save.player9 = hexa66.playername[8];
                                sc_save.player10 = hexa66.playername[9];
                                sc_save.player11 = hexa66.playername[10];
                                sc_save.player12 = hexa66.playername[11];

                                sc_save.MPR1 = hexa66.AverageA1;
                                sc_save.MPR2 = hexa66.AverageA2;
                                sc_save.MPR3 = hexa66.AverageA3;
                                sc_save.MPR4 = hexa66.AverageA4;
                                sc_save.MPR5 = hexa66.AverageA5;
                                sc_save.MPR6 = hexa66.AverageA6;
                                sc_save.MPR7 = hexa66.AverageB1;
                                sc_save.MPR8 = hexa66.AverageB2;
                                sc_save.MPR9 = hexa66.AverageB3;
                                sc_save.MPR10 = hexa66.AverageB4;
                                sc_save.MPR11 = hexa66.AverageB5;
                                sc_save.MPR12 = hexa66.AverageB6;

                                Invoke("GameEnd", 16f);
                            }
                            break;
                    }
                }
                break;
        }
    }

    void GameEnd()
    {
        SceneManager.LoadScene("Fish");
    }
}
