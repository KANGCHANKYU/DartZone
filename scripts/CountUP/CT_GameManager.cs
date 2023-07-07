using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CT_GameManager : MonoBehaviour
{
    public int meun2 = 0;
    public int meun3 = 0;

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

    public GameObject g_save;
    public GameObject[] g_Playerbar = new GameObject[4];
    public GameObject[] g_Teambar = new GameObject[3];
    public GameObject[] g_Move = new GameObject[7];
    public GameObject[] g_WMove = new GameObject[4];
    public GameObject[] g_DAni = new GameObject[4];
    public GameObject[] g_Dart = new GameObject[3];
    public GameObject[] g_BlueDartScore = new GameObject[3];
    public GameObject[] g_OrangDartScore = new GameObject[3];
    public GameObject[] g_BlackDartScore = new GameObject[3];
    public GameObject[] g_RScore = new GameObject[12];
    public GameObject g_MoveOn;

    public Text[] t_PPD = new Text[12];

    public Sprite[] s_DartScore= new Sprite[5];

    public bool isAni = false;

    public Save sc_save;
    public CT_SingPlayer sing;
    public CT_TwoPlayer Two;
    public CT_ThreePlayer three;
    public CT_FourPlayer four;

    public CT_dou22 dou22;
    public CT_dou222 dou222;
    public CT_dou2222 dou2222;

    public CT_Tri33 tir33;
    public CT_Tri333 tir333;
    public CT_Tri3333 tir3333;

    public CT_Four44 four44;
    public CT_Four444 four444;

    public CT_Five55 five55;
    public CT_Hexa66 hexa66;

    void Awake ()
    {
        g_save = GameObject.FindWithTag("Save");
        sc_save = g_save.GetComponent<Save>();

        meun2 = sc_save.meun2;
        meun3 = sc_save.meun3;

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

        for (int i = 0; i < g_Playerbar.Length; i++)
            g_Playerbar[i].SetActive(false);
        for (int i = 0; i < g_Teambar.Length; i++)
            g_Teambar[i].SetActive(false);

        for(int i=0;i<t_PPD.Length;i++)
        {
            t_PPD[i].enabled = false;
            g_RScore[i].SetActive(false);
        }

        for(int i=0;i<g_BlackDartScore.Length;i++)
        {
            g_BlackDartScore[i].GetComponent<csNumber>().CreateNumber(2, 65, 1f, 0);
            g_BlueDartScore[i].GetComponent<csNumber>().CreateNumber(2, 65, 1f, 0);
            g_OrangDartScore[i].GetComponent<csNumber>().CreateNumber(2,65,1f,0);
            g_BlackDartScore[i].GetComponent<csNumber>().SetNumber(-1);
            g_BlueDartScore[i].GetComponent<csNumber>().SetNumber(-1);
            g_OrangDartScore[i].GetComponent<csNumber>().SetNumber(-1);
        }

        for (int i = 0; i < g_DAni.Length; i++)
            g_DAni[i].SetActive(false);
        for (int i = 0; i < g_WMove.Length; i++)
            g_WMove[i].SetActive(false);


        sing = g_Playerbar[0].GetComponent<CT_SingPlayer>();
        Two = g_Playerbar[1].GetComponent<CT_TwoPlayer>();
        three = g_Playerbar[2].GetComponent<CT_ThreePlayer>();
        four = g_Playerbar[3].GetComponent<CT_FourPlayer>();

        dou22 = g_Teambar[0].GetComponent<CT_dou22>();
        dou222 = g_Teambar[1].GetComponent<CT_dou222>();
        dou2222 = g_Teambar[2].GetComponent<CT_dou2222>();

        tir33 = g_Teambar[0].GetComponent<CT_Tri33>();
        tir333 = g_Teambar[1].GetComponent<CT_Tri333>();
        tir3333 = g_Teambar[2].GetComponent<CT_Tri3333>();

        four44 = g_Teambar[0].GetComponent<CT_Four44>();
        four444 = g_Teambar[1].GetComponent<CT_Four444>();

        five55 = g_Teambar[0].GetComponent<CT_Five55>();
        hexa66 = g_Teambar[0].GetComponent<CT_Hexa66>();

        GameNumber(meun2, meun3);
    }


    void Update()
    {

    }

    void GameNumber(int meun2,int meun3)
    {
        switch(meun2)
        {
            case 0:
                {
                    switch(meun3)
                    {
                        case 0:
                            {
                                g_Playerbar[0].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;
                                sing.player1 = player1;

                            }break;
                        case 1:
                            {
                                g_Playerbar[1].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;
                                Two.playerName[0] = player1;
                                Two.playerName[1] = player2;

                            }
                            break;
                        case 2:
                            {
                                g_Playerbar[2].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;
                                three.playerName[0] = player1;
                                three.playerName[1] = player2;
                                three.playerName[2] = player3;

                            }
                            break;
                        case 3:
                            {
                                g_Playerbar[3].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;
                                four.playerName[0] = player1;
                                four.playerName[1] = player2;
                                four.playerName[2] = player3;
                                four.playerName[3] = player4;
                            }
                            break;
                        case 4:
                            {
                                dou22.enabled = true;
                                tir33.enabled = false;
                                four44.enabled = false;
                                five55.enabled = false;
                                hexa66.enabled = false;

                                g_Teambar[0].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;

                                dou22.playerName[0] = player1;
                                dou22.playerName[1] = player2;
                                dou22.playerName[2] = player3;
                                dou22.playerName[3] = player4;
                            }
                            break;
                        case 5:
                            {
                                dou222.enabled = true;
                                tir333.enabled = false;
                                four444.enabled = false;

                                g_Teambar[1].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;

                                dou222.playerName[0] = player1;
                                dou222.playerName[1] = player2;
                                dou222.playerName[2] = player3;
                                dou222.playerName[3] = player4;
                                dou222.playerName[4] = player5;
                                dou222.playerName[5] = player6;
                            }
                            break;
                        case 6:
                            {
                                dou2222.enabled = true;
                                tir3333.enabled = false;

                                g_Teambar[2].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;

                                dou2222.playerName[0] = player1;
                                dou2222.playerName[1] = player2;
                                dou2222.playerName[2] = player3;
                                dou2222.playerName[3] = player4;
                                dou2222.playerName[4] = player5;
                                dou2222.playerName[5] = player6;
                                dou2222.playerName[6] = player7;
                                dou2222.playerName[7] = player8;
                            }
                            break;
                        case 7:
                            {
                                dou22.enabled = false;
                                tir33.enabled = true;
                                four44.enabled = false;
                                five55.enabled = false;
                                hexa66.enabled = false;

                                g_Teambar[0].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;

                                tir33.playerName[0] = player1;
                                tir33.playerName[1] = player2;
                                tir33.playerName[2] = player3;
                                tir33.playerName[3] = player4;
                                tir33.playerName[4] = player5;
                                tir33.playerName[5] = player6;

                            }
                            break;
                        case 8:
                            {
                                dou222.enabled = false;
                                tir333.enabled = true;
                                four444.enabled = false;

                                g_Teambar[1].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;

                                tir333.playerName[0] = player1;
                                tir333.playerName[1] = player2;
                                tir333.playerName[2] = player3;
                                tir333.playerName[3] = player4;
                                tir333.playerName[4] = player5;
                                tir333.playerName[5] = player6;
                                tir333.playerName[6] = player7;
                                tir333.playerName[7] = player8;
                                tir333.playerName[8] = player9;
                            }
                            break;
                        case 9:
                            {
                                dou2222.enabled = false;
                                tir3333.enabled = true;

                                g_Teambar[2].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;

                                tir3333.playerName[0] = player1;
                                tir3333.playerName[1] = player2;
                                tir3333.playerName[2] = player3;
                                tir3333.playerName[3] = player4;
                                tir3333.playerName[4] = player5;
                                tir3333.playerName[5] = player6;
                                tir3333.playerName[6] = player7;
                                tir3333.playerName[7] = player8;
                                tir3333.playerName[8] = player9;
                                tir3333.playerName[9] = player10;
                                tir3333.playerName[10] = player11;
                                tir3333.playerName[11] = player12;
                            }
                            break;
                        case 10:
                            {
                                dou22.enabled = false;
                                tir33.enabled = false;
                                four44.enabled = true;
                                five55.enabled = false;
                                hexa66.enabled = false;

                                g_Teambar[0].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;

                                four44.playerName[0] = player1;
                                four44.playerName[1] = player2;
                                four44.playerName[2] = player3;
                                four44.playerName[3] = player4;
                                four44.playerName[4] = player5;
                                four44.playerName[5] = player6;
                                four44.playerName[6] = player7;
                                four44.playerName[7] = player8;
                            }
                            break;
                        case 11:
                            {
                                dou222.enabled = false;
                                tir333.enabled = false;
                                four444.enabled = true;

                                g_Teambar[1].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;

                                four444.playerName[0] = player1;
                                four444.playerName[1] = player2;
                                four444.playerName[2] = player3;
                                four444.playerName[3] = player4;
                                four444.playerName[4] = player5;
                                four444.playerName[5] = player6;
                                four444.playerName[6] = player7;
                                four444.playerName[7] = player8;
                                four444.playerName[8] = player9;
                                four444.playerName[9] = player10;
                                four444.playerName[10] = player11;
                                four444.playerName[11] = player12;
                            }
                            break;
                        case 12:
                            {
                                dou22.enabled = false;
                                tir33.enabled = false;
                                four44.enabled = false;
                                five55.enabled = true;
                                hexa66.enabled = false;

                                g_Teambar[0].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;

                                five55.playerName[0] = player1;
                                five55.playerName[1] = player2;
                                five55.playerName[2] = player3;
                                five55.playerName[3] = player4;
                                five55.playerName[4] = player5;
                                five55.playerName[5] = player6;
                                five55.playerName[6] = player7;
                                five55.playerName[7] = player8;
                                five55.playerName[8] = player9;
                                five55.playerName[9] = player10;
                            }
                            break;
                        case 13:
                            {
                                dou22.enabled = false;
                                tir33.enabled = false;
                                four44.enabled = false;
                                five55.enabled = false;
                                hexa66.enabled = true;

                                g_Teambar[0].SetActive(true);
                                g_RScore[0].SetActive(true);
                                t_PPD[0].enabled = true;

                                hexa66.playerName[0] = player1;
                                hexa66.playerName[1] = player2;
                                hexa66.playerName[2] = player3;
                                hexa66.playerName[3] = player4;
                                hexa66.playerName[4] = player5;
                                hexa66.playerName[5] = player6;
                                hexa66.playerName[6] = player7;
                                hexa66.playerName[7] = player8;
                                hexa66.playerName[8] = player9;
                                hexa66.playerName[9] = player10;
                                hexa66.playerName[10] = player11;
                                hexa66.playerName[11] = player12;
                            }
                            break;
                    }
                }break;
        }
    }

    public void GameEnd(int n)
    {
        switch (meun3)
        {
            case 0:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = sing.player1;
                    sc_save.PPD1 = sing.Average;

                    Invoke("End", 16f);
                }
                break;
            case 1:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = Two.playerName[0];
                    sc_save.player2 = Two.playerName[1];

                    sc_save.PPD1 = Two.P1_Average;
                    sc_save.PPD2 = Two.P2_Average;

                    Invoke("End", 16f);
                }
                break;
            case 2:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = three.playerName[0];
                    sc_save.player2 = three.playerName[1];
                    sc_save.player3 = three.playerName[2];

                    sc_save.PPD1 = three.P1_Average;
                    sc_save.PPD2 = three.P2_Average;
                    sc_save.PPD3 = three.P3_Average;

                    Invoke("End", 16f);
                }
                break;
            case 3:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = four.playerName[0];
                    sc_save.player2 = four.playerName[1];
                    sc_save.player3 = four.playerName[2];
                    sc_save.player4 = four.playerName[3];

                    sc_save.PPD1 = four.P1_Average;
                    sc_save.PPD2 = four.P2_Average;
                    sc_save.PPD3 = four.P3_Average;
                    sc_save.PPD4 = four.P4_Average;

                    Invoke("End", 16f);
                }
                break;
            case 4:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = dou22.playerName[0];
                    sc_save.player2 = dou22.playerName[1];
                    sc_save.player3 = dou22.playerName[2];
                    sc_save.player4 = dou22.playerName[3];

                    sc_save.PPD1 = dou22.A1_Average;
                    sc_save.PPD2 = dou22.A1_Average;
                    sc_save.PPD3 = dou22.B1_Average;
                    sc_save.PPD4 = dou22.B2_Average;

                    Invoke("End", 16f);
                }
                break;
            case 5:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = dou222.playerName[0];
                    sc_save.player2 = dou222.playerName[1];
                    sc_save.player3 = dou222.playerName[2];
                    sc_save.player4 = dou222.playerName[3];
                    sc_save.player5 = dou222.playerName[4];
                    sc_save.player6 = dou222.playerName[5];

                    sc_save.PPD1 = dou222.A1_Average;
                    sc_save.PPD2 = dou222.A2_Average;
                    sc_save.PPD3 = dou222.B1_Average;
                    sc_save.PPD4 = dou222.B2_Average;
                    sc_save.PPD5 = dou222.C1_Average;
                    sc_save.PPD6 = dou222.C2_Average;

                    Invoke("End", 16f);
                }
                break;
            case 6:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = dou2222.playerName[0];
                    sc_save.player2 = dou2222.playerName[1];
                    sc_save.player3 = dou2222.playerName[2];
                    sc_save.player4 = dou2222.playerName[3];
                    sc_save.player5 = dou2222.playerName[4];
                    sc_save.player6 = dou2222.playerName[5];
                    sc_save.player7 = dou2222.playerName[6];
                    sc_save.player8 = dou2222.playerName[7];

                    sc_save.PPD1 = dou2222.A1_Average;
                    sc_save.PPD2 = dou2222.A2_Average;
                    sc_save.PPD3 = dou2222.B1_Average;
                    sc_save.PPD4 = dou2222.B2_Average;
                    sc_save.PPD5 = dou2222.C1_Average;
                    sc_save.PPD6 = dou2222.C2_Average;
                    sc_save.PPD7 = dou2222.D1_Average;
                    sc_save.PPD8 = dou2222.D2_Average;

                    Invoke("End", 16f);
                }
                break;
            case 7:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = tir33.playerName[0];
                    sc_save.player2 = tir33.playerName[1];
                    sc_save.player3 = tir33.playerName[2];
                    sc_save.player4 = tir33.playerName[3];
                    sc_save.player5 = tir33.playerName[4];
                    sc_save.player6 = tir33.playerName[5];

                    sc_save.PPD1 = tir33.A1_Average;
                    sc_save.PPD2 = tir33.A2_Average;
                    sc_save.PPD3 = tir33.A3_Average;
                    sc_save.PPD4 = tir33.B1_Average;
                    sc_save.PPD5 = tir33.B2_Average;
                    sc_save.PPD6 = tir33.B3_Average;

                    Invoke("End", 16f);
                }
                break;
            case 8:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = tir333.playerName[0];
                    sc_save.player2 = tir333.playerName[1];
                    sc_save.player3 = tir333.playerName[2];
                    sc_save.player4 = tir333.playerName[3];
                    sc_save.player5 = tir333.playerName[4];
                    sc_save.player6 = tir333.playerName[5];
                    sc_save.player7 = tir333.playerName[6];
                    sc_save.player8 = tir333.playerName[7];
                    sc_save.player9 = tir333.playerName[8];

                    sc_save.PPD1 = tir333.A1_Average;
                    sc_save.PPD2 = tir333.A2_Average;
                    sc_save.PPD3 = tir333.A3_Average;
                    sc_save.PPD4 = tir333.B1_Average;
                    sc_save.PPD5 = tir333.B2_Average;
                    sc_save.PPD6 = tir333.B3_Average;
                    sc_save.PPD7 = tir333.C1_Average;
                    sc_save.PPD8 = tir333.C2_Average;
                    sc_save.PPD9 = tir333.C3_Average;

                    Invoke("End", 16f);
                }
                break;
            case 9:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = tir3333.playerName[0];
                    sc_save.player2 = tir3333.playerName[1];
                    sc_save.player3 = tir3333.playerName[2];
                    sc_save.player4 = tir3333.playerName[3];
                    sc_save.player5 = tir3333.playerName[4];
                    sc_save.player6 = tir3333.playerName[5];
                    sc_save.player7 = tir3333.playerName[6];
                    sc_save.player8 = tir3333.playerName[7];
                    sc_save.player9 = tir3333.playerName[8];
                    sc_save.player10 = tir3333.playerName[9];
                    sc_save.player11 = tir3333.playerName[10];
                    sc_save.player12 = tir3333.playerName[11];

                    sc_save.PPD1 = tir3333.A1_Average;
                    sc_save.PPD2 = tir3333.A2_Average;
                    sc_save.PPD3 = tir3333.A3_Average;
                    sc_save.PPD4 = tir3333.B1_Average;
                    sc_save.PPD5 = tir3333.B2_Average;
                    sc_save.PPD6 = tir3333.B3_Average;
                    sc_save.PPD7 = tir3333.C1_Average;
                    sc_save.PPD8 = tir3333.C2_Average;
                    sc_save.PPD9 = tir3333.C3_Average;
                    sc_save.PPD10 = tir3333.D1_Average;
                    sc_save.PPD11 = tir3333.D2_Average;
                    sc_save.PPD12 = tir3333.D3_Average;

                    Invoke("End", 16f);
                }
                break;
            case 10:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = four44.playerName[0];
                    sc_save.player2 = four44.playerName[1];
                    sc_save.player3 = four44.playerName[2];
                    sc_save.player4 = four44.playerName[3];
                    sc_save.player5 = four44.playerName[4];
                    sc_save.player6 = four44.playerName[5];
                    sc_save.player7 = four44.playerName[6];
                    sc_save.player8 = four44.playerName[7];

                    sc_save.PPD1 = four44.A1_Average;
                    sc_save.PPD2 = four44.A2_Average;
                    sc_save.PPD3 = four44.A3_Average;
                    sc_save.PPD4 = four44.A4_Average;
                    sc_save.PPD5 = four44.B1_Average;
                    sc_save.PPD6 = four44.B2_Average;
                    sc_save.PPD7 = four44.B3_Average;
                    sc_save.PPD8 = four44.B4_Average;

                    Invoke("End", 16f);
                }
                break;
            case 11:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = four444.playerName[0];
                    sc_save.player2 = four444.playerName[1];
                    sc_save.player3 = four444.playerName[2];
                    sc_save.player4 = four444.playerName[3];
                    sc_save.player5 = four444.playerName[4];
                    sc_save.player6 = four444.playerName[5];
                    sc_save.player7 = four444.playerName[6];
                    sc_save.player8 = four444.playerName[7];
                    sc_save.player9 = four444.playerName[8];
                    sc_save.player10 = four444.playerName[9];
                    sc_save.player11 = four444.playerName[10];
                    sc_save.player12 = four444.playerName[11];

                    sc_save.PPD1 = four444.A1_Average;
                    sc_save.PPD2 = four444.A2_Average;
                    sc_save.PPD3 = four444.A3_Average;
                    sc_save.PPD4 = four444.A4_Average;
                    sc_save.PPD5 = four444.B1_Average;
                    sc_save.PPD6 = four444.B2_Average;
                    sc_save.PPD7 = four444.B3_Average;
                    sc_save.PPD8 = four444.B4_Average;
                    sc_save.PPD9 = four444.C1_Average;
                    sc_save.PPD10 = four444.C2_Average;
                    sc_save.PPD11 = four444.C3_Average;
                    sc_save.PPD11 = four444.C4_Average;

                    Invoke("End", 16f);
                }
                break;
            case 12:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = five55.playerName[0];
                    sc_save.player2 = five55.playerName[1];
                    sc_save.player3 = five55.playerName[2];
                    sc_save.player4 = five55.playerName[3];
                    sc_save.player5 = five55.playerName[4];
                    sc_save.player6 = five55.playerName[5];
                    sc_save.player7 = five55.playerName[6];
                    sc_save.player8 = five55.playerName[7];
                    sc_save.player9 = five55.playerName[8];
                    sc_save.player10 = five55.playerName[9];

                    sc_save.PPD1 = five55.A1_Average;
                    sc_save.PPD2 = five55.A2_Average;
                    sc_save.PPD3 = five55.A3_Average;
                    sc_save.PPD4 = five55.A4_Average;
                    sc_save.PPD5 = five55.A5_Average;
                    sc_save.PPD6 = five55.B1_Average;
                    sc_save.PPD7 = five55.B2_Average;
                    sc_save.PPD8 = five55.B3_Average;
                    sc_save.PPD9 = five55.B4_Average;
                    sc_save.PPD10 = five55.B5_Average;

                    Invoke("End", 16f);
                }
                break;
            case 13:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    sc_save.player1 = hexa66.playerName[0];
                    sc_save.player2 = hexa66.playerName[1];
                    sc_save.player3 = hexa66.playerName[2];
                    sc_save.player4 = hexa66.playerName[3];
                    sc_save.player5 = hexa66.playerName[4];
                    sc_save.player6 = hexa66.playerName[5];
                    sc_save.player7 = hexa66.playerName[6];
                    sc_save.player8 = hexa66.playerName[7];
                    sc_save.player9 = hexa66.playerName[8];
                    sc_save.player10 = hexa66.playerName[9];
                    sc_save.player11 = hexa66.playerName[10];
                    sc_save.player12 = hexa66.playerName[11];

                    sc_save.PPD1 = hexa66.A1_Average;
                    sc_save.PPD2 = hexa66.A2_Average;
                    sc_save.PPD3 = hexa66.A3_Average;
                    sc_save.PPD4 = hexa66.A4_Average;
                    sc_save.PPD5 = hexa66.A5_Average;
                    sc_save.PPD6 = hexa66.A6_Average;
                    sc_save.PPD7 = hexa66.B1_Average;
                    sc_save.PPD8 = hexa66.B2_Average;
                    sc_save.PPD9 = hexa66.B3_Average;
                    sc_save.PPD10 = hexa66.B4_Average;
                    sc_save.PPD11 = hexa66.B5_Average;
                    sc_save.PPD12 = hexa66.B6_Average;

                    Invoke("End", 16f);
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
                        g_DAni[2].SetActive(true);
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[3];
                    }
                    else if(2==nDartLine)
                    {
                        g_DAni[3].SetActive(true);
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[4];
                    }
                    else
                    { }
                }
                break;
            case 20:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(20);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(20);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(19);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(19);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(18);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(18);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(17);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(17);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(16);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(16);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(15);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(15);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(14);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(14);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(13);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(13);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(12);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(12);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(11);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(11);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(10);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(10);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(9);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(9);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(8);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(8);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(7);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(7);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(6);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(6);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(5);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(5);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(4);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(4);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(3);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(3);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(2);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(2);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(1);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(1);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
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
            g_DAni[1].SetActive(true);
            g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
        }
        else if (nDartLine == 2 && nDartScore != 25 && nDartScore != 50)
        {
            g_DAni[0].SetActive(true);
            g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
        }
        else if (nDartLine == 1 && nDartScore != 25 && nDartScore != 50)
        {
            g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
        }
        else
        {
        }
        Invoke("AniStop", 1.5f);
    }

    void AniStop()
    {
        for (int i = 0; i < g_DAni.Length; i++)
            g_DAni[i].SetActive(false);
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

    public void MoviePlay(int nNo/*int Dart1,int Dart2,int Dart3*/)
    {
        isAni = true;
        g_MoveOn.SetActive(true);
        g_Move[nNo].SetActive(true);
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
            MovieStop();
    }

    void MovieStop()
    {
        for (int i = 0; i < g_Move.Length; i++)
            g_Move[i].SetActive(false);
        g_MoveOn.SetActive(false);
        isAni = false;

    }

    void End()
    {
        g_MoveOn.SetActive(false);
        SceneManager.LoadScene("Fish");
    }
}
