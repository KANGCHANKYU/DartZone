﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class H_hexa66 : MonoBehaviour
{
    public Text t_RoundText;
    public Text t_MPRText1;
    public Text t_MPRText2;
    public Text t_MPRText3;
    public Text t_MPRText4;
    public Text t_MPRText5;
    public Text t_MPRText6;
    public Text t_MPRText7;
    public Text t_MPRText8;
    public Text t_MPRText9;
    public Text t_MPRText10;
    public Text t_MPRText11;
    public Text t_MPRText12;

    public GameObject[] g_HAni = new GameObject[7];
    public GameObject[] g_AT1RMark1 = new GameObject[3];
    public GameObject[] g_AT1RMark2 = new GameObject[3];
    public GameObject[] g_AT1RMark3 = new GameObject[3];
    public GameObject[] g_AT1RMark4 = new GameObject[3];
    public GameObject[] g_AT1RMark5 = new GameObject[3];
    public GameObject[] g_AT2RMark1 = new GameObject[3];
    public GameObject[] g_AT2RMark2 = new GameObject[3];
    public GameObject[] g_AT2RMark3 = new GameObject[3];
    public GameObject[] g_AT2RMark4 = new GameObject[3];
    public GameObject[] g_AT2RMark5 = new GameObject[3];
    public GameObject[] g_AT3RMark1 = new GameObject[3];
    public GameObject[] g_AT3RMark2 = new GameObject[3];
    public GameObject[] g_AT3RMark3 = new GameObject[3];
    public GameObject[] g_AT3RMark4 = new GameObject[3];
    public GameObject[] g_AT3RMark5 = new GameObject[3];
    public GameObject[] g_AT4RMark1 = new GameObject[3];
    public GameObject[] g_AT4RMark2 = new GameObject[3];
    public GameObject[] g_AT4RMark3 = new GameObject[3];
    public GameObject[] g_AT4RMark4 = new GameObject[3];
    public GameObject[] g_AT4RMark5 = new GameObject[3];
    public GameObject[] g_AT5RMark1 = new GameObject[3];
    public GameObject[] g_AT5RMark2 = new GameObject[3];
    public GameObject[] g_AT5RMark3 = new GameObject[3];
    public GameObject[] g_AT5RMark4 = new GameObject[3];
    public GameObject[] g_AT5RMark5 = new GameObject[3];
    public GameObject[] g_AT6RMark1 = new GameObject[3];
    public GameObject[] g_AT6RMark2 = new GameObject[3];
    public GameObject[] g_AT6RMark3 = new GameObject[3];
    public GameObject[] g_AT6RMark4 = new GameObject[3];
    public GameObject[] g_AT6RMark5 = new GameObject[3];

    public GameObject[] g_BT1RMark1 = new GameObject[3];
    public GameObject[] g_BT1RMark2 = new GameObject[3];
    public GameObject[] g_BT1RMark3 = new GameObject[3];
    public GameObject[] g_BT1RMark4 = new GameObject[3];
    public GameObject[] g_BT1RMark5 = new GameObject[3];
    public GameObject[] g_BT2RMark1 = new GameObject[3];
    public GameObject[] g_BT2RMark2 = new GameObject[3];
    public GameObject[] g_BT2RMark3 = new GameObject[3];
    public GameObject[] g_BT2RMark4 = new GameObject[3];
    public GameObject[] g_BT2RMark5 = new GameObject[3];
    public GameObject[] g_BT3RMark1 = new GameObject[3];
    public GameObject[] g_BT3RMark2 = new GameObject[3];
    public GameObject[] g_BT3RMark3 = new GameObject[3];
    public GameObject[] g_BT3RMark4 = new GameObject[3];
    public GameObject[] g_BT3RMark5 = new GameObject[3];
    public GameObject[] g_BT4RMark1 = new GameObject[3];
    public GameObject[] g_BT4RMark2 = new GameObject[3];
    public GameObject[] g_BT4RMark3 = new GameObject[3];
    public GameObject[] g_BT4RMark4 = new GameObject[3];
    public GameObject[] g_BT4RMark5 = new GameObject[3];
    public GameObject[] g_BT5RMark1 = new GameObject[3];
    public GameObject[] g_BT5RMark2 = new GameObject[3];
    public GameObject[] g_BT5RMark3 = new GameObject[3];
    public GameObject[] g_BT5RMark4 = new GameObject[3];
    public GameObject[] g_BT5RMark5 = new GameObject[3];
    public GameObject[] g_BT6RMark1 = new GameObject[3];
    public GameObject[] g_BT6RMark2 = new GameObject[3];
    public GameObject[] g_BT6RMark3 = new GameObject[3];
    public GameObject[] g_BT6RMark4 = new GameObject[3];
    public GameObject[] g_BT6RMark5 = new GameObject[3];

    public GameObject[] g_ATMainMark = new GameObject[7];
    public GameObject[] g_BTMainMark = new GameObject[7];
    public GameObject[] g_i_Player = new GameObject[2];
    public GameObject[] g_Teambar = new GameObject[2];
    public GameObject[] g_Dart = new GameObject[3];
    public GameObject[] g_RoundScore = new GameObject[12];
    public GameObject[] g_MRPScore = new GameObject[12];
    public GameObject[] g_RoundNum = new GameObject[15];
    public GameObject[] g_P_Score = new GameObject[2];
    public GameObject[] g_OffScore = new GameObject[2];
    public GameObject[] g_Fishbar = new GameObject[7];
    public GameObject[] g_20Line = new GameObject[21];
    public GameObject[] g_19Line = new GameObject[21];
    public GameObject[] g_18Line = new GameObject[21];
    public GameObject[] g_17Line = new GameObject[21];
    public GameObject[] g_16Line = new GameObject[21];
    public GameObject[] g_15Line = new GameObject[21];
    public GameObject[] g_BullLine = new GameObject[21];
    public GameObject g_AT;
    public GameObject g_BT;
    public GameObject g_ScorePlate;
    public GameObject g_D_Ani;
    public GameObject g_C_Ani;
    public GameObject g_R_Ani;
    public GameObject g_P_Ani;
    public GameObject g_RoundOn;
    public GameObject g_RoundR;

    public Sprite s_OnDart;
    public Sprite s_OffDart;
    public Sprite[] s_RScore = new Sprite[15];
    public Sprite[] s_PlayerOn = new Sprite[6];
    public Sprite[] s_PlayerOff = new Sprite[6];
    public Sprite[] s_TeambarOn = new Sprite[2];
    public Sprite[] s_TeambarOff = new Sprite[2];
    public Sprite[] s_ATMark = new Sprite[4];
    public Sprite[] s_BTMark = new Sprite[4];
    public Sprite s_OffMark;

    public Image[] i_RScoreA1 = new Image[5];
    public Image[] i_RScoreA2 = new Image[5];
    public Image[] i_RScoreA3 = new Image[5];
    public Image[] i_RScoreA4 = new Image[5];
    public Image[] i_RScoreA5 = new Image[5];
    public Image[] i_RScoreA6 = new Image[5];
    public Image[] i_RScoreB1 = new Image[5];
    public Image[] i_RScoreB2 = new Image[5];
    public Image[] i_RScoreB3 = new Image[5];
    public Image[] i_RScoreB4 = new Image[5];
    public Image[] i_RScoreB5 = new Image[5];
    public Image[] i_RScoreB6 = new Image[5];

    public Animator A_20Line;
    public Animator A_19Line;
    public Animator A_18Line;
    public Animator A_17Line;
    public Animator A_16Line;
    public Animator A_15Line;
    public Animator A_BullLine;

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int RoundStop;

    public int[] TeamScore = new int[12];
    public int[] MarkSaveAT1 = new int[45];
    public int[] MarkSaveAT2 = new int[45];
    public int[] MarkSaveAT3 = new int[45];
    public int[] MarkSaveAT4 = new int[45];
    public int[] MarkSaveAT5 = new int[45];
    public int[] MarkSaveAT6 = new int[45];
    public int[] MarkSaveBT1 = new int[45];
    public int[] MarkSaveBT2 = new int[45];
    public int[] MarkSaveBT3 = new int[45];
    public int[] MarkSaveBT4 = new int[45];
    public int[] MarkSaveBT5 = new int[45];
    public int[] MarkSaveBT6 = new int[45];
    public int[] DartBasicScore = new int[3];

    public int AT1MarkCounting = 0;
    public int AT2MarkCounting = 0;
    public int AT3MarkCounting = 0;
    public int AT4MarkCounting = 0;
    public int AT5MarkCounting = 0;
    public int AT6MarkCounting = 0;
    public int BT1MarkCounting = 0;
    public int BT2MarkCounting = 0;
    public int BT3MarkCounting = 0;
    public int BT4MarkCounting = 0;
    public int BT5MarkCounting = 0;
    public int BT6MarkCounting = 0;
    public int Counting = 0;
    public int Round = 0;
    public int RoundCountingA1 = 0;
    public int RoundCountingA2 = 0;
    public int RoundCountingA3 = 0;
    public int RoundCountingA4 = 0;
    public int RoundCountingA5 = 0;
    public int RoundCountingA6 = 0;
    public int RoundCountingB1 = 0;
    public int RoundCountingB2 = 0;
    public int RoundCountingB3 = 0;
    public int RoundCountingB4 = 0;
    public int RoundCountingB5 = 0;
    public int RoundCountingB6 = 0;
    public int TotalA1 = 0;
    public int TotalA2 = 0;
    public int TotalA3 = 0;
    public int TotalA4 = 0;
    public int TotalA5 = 0;
    public int TotalA6 = 0;
    public int TotalB1 = 0;
    public int TotalB2 = 0;
    public int TotalB3 = 0;
    public int TotalB4 = 0;
    public int TotalB5 = 0;
    public int TotalB6 = 0;
    public int RScore = 0;
    public int Players = 0;
    public int Teams = 0;
    public int win = 0;

    public int AT_20LMark = 0;
    public int AT_19LMark = 0;
    public int AT_18LMark = 0;
    public int AT_17LMark = 0;
    public int AT_16LMark = 0;
    public int AT_15LMark = 0;
    public int AT_BullLMark = 0;

    public int BT_20LMark = 0;
    public int BT_19LMark = 0;
    public int BT_18LMark = 0;
    public int BT_17LMark = 0;
    public int BT_16LMark = 0;
    public int BT_15LMark = 0;
    public int BT_BullLMark = 0;

    public int[] RandomValue = new int[20];
    public int _20Line = 0;
    public int _19Line = 0;
    public int _18Line = 0;
    public int _17Line = 0;
    public int _16Line = 0;
    public int _15Line = 0;
    public int _BullLine = 0;

    public float AverageA1 = 0;
    public float AverageA2 = 0;
    public float AverageA3 = 0;
    public float AverageA4 = 0;
    public float AverageA5 = 0;
    public float AverageA6 = 0;
    public float AverageB1 = 0;
    public float AverageB2 = 0;
    public float AverageB3 = 0;
    public float AverageB4 = 0;
    public float AverageB5 = 0;
    public float AverageB6 = 0;
    public float AverageATotla = 0;
    public float AverageBTotla = 0;

    public string[] playername = new string[12];

    public bool isAT_20Line = false;
    public bool isAT_19Line = false;
    public bool isAT_18Line = false;
    public bool isAT_17Line = false;
    public bool isAT_16Line = false;
    public bool isAT_15Line = false;
    public bool isAT_BullLine = false;

    public bool isBT_20Line = false;
    public bool isBT_19Line = false;
    public bool isBT_18Line = false;
    public bool isBT_17Line = false;
    public bool isBT_16Line = false;
    public bool isBT_15Line = false;
    public bool isBT_BullLine = false;
    /*여기 까지*/
    public bool is20AllLine = false;
    public bool is19AllLine = false;
    public bool is18AllLine = false;
    public bool is17AllLine = false;
    public bool is16AllLine = false;
    public bool is15AllLine = false;
    public bool isBullAllLine = false;
    public bool isATAllLine = false;
    public bool isBTAllLine = false;

    public bool is20ALine = false;
    public bool is19ALine = false;
    public bool is18ALine = false;
    public bool is17ALine = false;
    public bool is16ALine = false;
    public bool is15ALine = false;
    public bool isBullALine = false;
    /*여기 까지*/
    public bool isAT = true;
    public bool isBT = false;
    public bool isRead = false;
    public bool isSpace = false;
    public bool isWin = false;
    public bool is20Line = false;
    public bool is19Line = false;
    public bool is18Line = false;
    public bool is17Line = false;
    public bool is16Line = false;
    public bool is15Line = false;
    public bool isBullLine = false;

    public H_CGameManager gmg;
    public _TARGET_INFO[] m_oDartInfo = new _TARGET_INFO[3];

    void Start()
    {
        Players = 0;
        for (int i = 0; i < g_20Line.Length; i++)
        {
            g_20Line[i].SetActive(false);
            g_19Line[i].SetActive(false);
            g_18Line[i].SetActive(false);
            g_17Line[i].SetActive(false);
            g_16Line[i].SetActive(false);
            g_15Line[i].SetActive(false);
            g_BullLine[i].SetActive(false);
        }
        for (int i = 0; i < g_RoundNum.Length; i++)
            g_RoundNum[i].SetActive(false);
        for (int i = 0; i < g_Fishbar.Length; i++)
            g_Fishbar[i].SetActive(false);
        for (int i = 0; i < g_P_Score.Length; i++)
        {
            g_P_Score[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.75f, 0);
            g_OffScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.75f, 0);
            g_P_Score[i].GetComponent<csNumber>().SetNumber(TeamScore[i]);
            g_OffScore[i].GetComponent<csNumber>().SetNumber(TeamScore[i]);
        }

        AT_20LMark = _20Line * 3;
        AT_19LMark = _19Line * 3;
        AT_18LMark = _18Line * 3;
        AT_17LMark = _17Line * 3;
        AT_16LMark = _16Line * 3;
        AT_15LMark = _15Line * 3;
        AT_BullLMark = _BullLine * 3;

        BT_20LMark = _20Line * 3;
        BT_19LMark = _19Line * 3;
        BT_18LMark = _18Line * 3;
        BT_17LMark = _17Line * 3;
        BT_16LMark = _16Line * 3;
        BT_15LMark = _15Line * 3;
        BT_BullLMark = _BullLine * 3;

        g_P_Ani.SetActive(false);
        g_C_Ani.SetActive(false);

        FirstStart();
        MyTurn();
    }


    void Update()
    {
        MyTurn();
        ImageUp();
        /*========================20========================================*/
        if (csSingleton.getInstance.g_bTarget)
        {
            csSingleton.getInstance.g_bTarget = false;

            if (csSingleton.getInstance.g_nTargetBasicScore == _BullLine || csSingleton.getInstance.g_nTargetBasicScore == _20Line || csSingleton.getInstance.g_nTargetBasicScore == _19Line || csSingleton.getInstance.g_nTargetBasicScore == _18Line ||
            csSingleton.getInstance.g_nTargetBasicScore == _17Line || csSingleton.getInstance.g_nTargetBasicScore == _16Line || csSingleton.getInstance.g_nTargetBasicScore == _15Line && gmg.isAni == false)
            {
                if (Round <= RoundStop && gmg.isAni == false && !isSpace && !isRead && !isWin)
                {
                    if (is20AllLine || is19AllLine || is18AllLine || is17AllLine || is16AllLine || is15AllLine || isBullAllLine)
                        MarkAll();

                    if (csSingleton.getInstance.g_nTargetBasicScore == _20Line && !is20ALine)
                    {
                        is20ALine = true;
                        if (is20ALine)
                        {
                            A_20Line.SetBool("Hit", true);
                            g_20Line[_20Line].SetActive(true);

                        }
                    }
                    else if (csSingleton.getInstance.g_nTargetBasicScore == _19Line && !is19ALine)
                    {
                        is19ALine = true;
                        if (is19ALine)
                        {
                            A_19Line.SetBool("Hit", true);
                            g_19Line[_19Line].SetActive(true);

                        }
                    }
                    else if (csSingleton.getInstance.g_nTargetBasicScore == _18Line && !is18ALine)
                    {
                        is18ALine = true;
                        if (is18ALine)
                        {
                            A_18Line.SetBool("Hit", true);
                            g_18Line[_18Line].SetActive(true);

                        }
                    }
                    else if (csSingleton.getInstance.g_nTargetBasicScore == _17Line && !is17ALine)
                    {
                        is17ALine = true;

                        if (is17ALine)
                        {
                            A_17Line.SetBool("Hit", true);
                            g_17Line[_17Line].SetActive(true);

                        }
                    }
                    else if (csSingleton.getInstance.g_nTargetBasicScore == _16Line && !is16ALine)
                    {
                        is16ALine = true;
                        if (is16ALine)
                        {
                            A_16Line.SetBool("Hit", true);
                            g_16Line[_16Line].SetActive(true);

                        }
                    }
                    else if (csSingleton.getInstance.g_nTargetBasicScore == _15Line && !is15ALine)
                    {
                        is15ALine = true;
                        if (is15ALine)
                        {
                            A_15Line.SetBool("Hit", true);
                            g_15Line[_15Line].SetActive(true);

                        }
                    }
                    else if (csSingleton.getInstance.g_nTargetBasicScore == _BullLine && !isBullALine)
                    {
                        isBullALine = true;
                        if (isBullALine)
                        {
                            A_BullLine.SetBool("Hit", true);
                            g_BullLine[_BullLine].SetActive(true);
                            A_BullLine.enabled = false;
                        }
                    }

                    if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_20Line && !is20AllLine && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_19Line && !is19AllLine && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_18Line && !is18AllLine && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_17Line && !is17AllLine && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_16Line && !is16AllLine && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_15Line && !is15AllLine && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_BullLine && !isBullAllLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
                            else if (Players == 2)
                                AT3MarkCounting++;
                            else if (Players == 3)
                                AT4MarkCounting++;
                            else if (Players == 4)
                                AT5MarkCounting++;
                            else if (Players == 5)
                                AT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }

                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_20Line && !is20AllLine && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_19Line && !is19AllLine && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_18Line && !is18AllLine && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_17Line && !is17AllLine && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_16Line && !is16AllLine && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_15Line && !is15AllLine && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_BullLine && !isBullAllLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
                            else if (Players == 2)
                                BT3MarkCounting++;
                            else if (Players == 3)
                                BT4MarkCounting++;
                            else if (Players == 4)
                                BT5MarkCounting++;
                            else if (Players == 5)
                                BT6MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }

                    }

                    if (Counting != 3)
                        LineScore();

                }
                else
                {
                }
            }
            else
            {
                if (csSingleton.getInstance.g_nTargetBasicScore != _20Line && csSingleton.getInstance.g_nTargetBasicScore != _19Line && csSingleton.getInstance.g_nTargetBasicScore != _18Line &&
                    csSingleton.getInstance.g_nTargetBasicScore != _17Line && csSingleton.getInstance.g_nTargetBasicScore != _16Line && csSingleton.getInstance.g_nTargetBasicScore != _15Line &&
                    csSingleton.getInstance.g_nTargetBasicScore != _BullLine && Counting != 3 && !isSpace && !isRead && !isWin)
                {
                    if (Teams == 0 && Players == 0)
                        AT1MarkCounting++;
                    else if (Teams == 0 && Players == 1)
                        AT2MarkCounting++;
                    else if (Teams == 0 && Players == 2)
                        AT3MarkCounting++;
                    else if (Teams == 0 && Players == 3)
                        AT4MarkCounting++;
                    else if (Teams == 0 && Players == 4)
                        AT5MarkCounting++;
                    else if (Teams == 0 && Players == 5)
                        AT6MarkCounting++;
                    else if (Teams == 1 && Players == 0)
                        BT1MarkCounting++;
                    else if (Teams == 1 && Players == 1)
                        BT2MarkCounting++;
                    else if (Teams == 1 && Players == 2)
                        BT3MarkCounting++;
                    else if (Teams == 1 && Players == 3)
                        BT4MarkCounting++;
                    else if (Teams == 1 && Players == 4)
                        BT5MarkCounting++;
                    else if (Teams == 1 && Players == 5)
                        BT6MarkCounting++;
                    a_source.PlayOneShot(ac_shoot1, 1.0f);
                    MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                    RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                    g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                    g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                    DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                    m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                    m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                    gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                    Counting++;
                }
            }
            if (Counting == 3 && !isRead && !isSpace && !isWin)
            {
                GetMovie();
                g_P_Ani.SetActive(true);
                isSpace = true;
                isRead = true;
                Counting = 4;
            }
        }
        MainMark();
        /*==================================================================================================*/
        if (Input.GetKeyDown(KeyCode.Space) && Counting == 4 && !isWin && gmg.isAni != true && isSpace || (csSingleton.getInstance.g_bSwitch
            && csSingleton.getInstance.g_nSwitch == 1005) && Counting == 4 && !isWin && gmg.isAni != true && isSpace)
        {

            if (is20ALine && g_HAni[0].activeSelf == true)
            {
                A_20Line.enabled = false;
                g_20Line[_20Line].SetActive(true);
                g_HAni[0].SetActive(false);
            }
            if (is19ALine && g_HAni[1].activeSelf == true)
            {
                A_19Line.enabled = false;
                g_19Line[_19Line].SetActive(true);
                g_HAni[1].SetActive(false);
            }
            if (is18ALine && g_HAni[2].activeSelf == true)
            {
                A_18Line.enabled = false;
                g_18Line[_18Line].SetActive(true);
                g_HAni[2].SetActive(false);
            }
            if (is17ALine && g_HAni[3].activeSelf == true)
            {
                A_17Line.enabled = false;
                g_17Line[_17Line].SetActive(true);
                g_HAni[3].SetActive(false);
            }
            if (is16ALine && g_HAni[4].activeSelf == true)
            {
                A_16Line.enabled = false;
                g_16Line[_16Line].SetActive(true);
                g_HAni[4].SetActive(false);
            }
            if (is15ALine && g_HAni[5].activeSelf == true)
            {
                A_15Line.enabled = false;
                g_15Line[_15Line].SetActive(true);
                g_HAni[5].SetActive(false);
            }
            if (isBullALine && g_HAni[6].activeSelf == true)
            {
                A_BullLine.enabled = false;
                g_BullLine[_BullLine].SetActive(true);
                g_HAni[6].SetActive(false);
            }

            if (Players == 0 && isAT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                isSpace = false;
                RoundCountingA1++;
                gmg.DartScoreReSet();
                Invoke("TeamNumberPlus", 5f);
            }

            if (Players == 1 && isAT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingA2++;
                isSpace = false;
                gmg.DartScoreReSet();
                Invoke("TeamNumberPlus", 5f);
            }

            if (Players == 2 && isAT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingA3++;
                isSpace = false;
                gmg.DartScoreReSet();
                Invoke("TeamNumberPlus", 5f);
            }

            if (Players == 3 && isAT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingA4++;
                isSpace = false;
                gmg.DartScoreReSet();
                Invoke("TeamNumberPlus", 5f);
            }

            if (Players == 4 && isAT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingA5++;
                isSpace = false;
                gmg.DartScoreReSet();
                Invoke("TeamNumberPlus", 5f);
            }

            if (Players == 5 && isAT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingA6++;
                isSpace = false;
                gmg.DartScoreReSet();
                Invoke("TeamNumberPlus", 5f);
            }

            if (Players == 0 && isBT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingB1++;
                isSpace = false;
                gmg.DartScoreReSet();
                RoundRead();
                Invoke("TeamNumberMinus", 5f);
                Invoke("PlayerNumberPlus", 5f);
            }

            if (Players == 1 && isBT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingB2++;
                isSpace = false;
                gmg.DartScoreReSet();
                RoundRead();
                Invoke("TeamNumberMinus", 5f);
                Invoke("PlayerNumberPlus", 5f);
            }

            if (Players == 2 && isBT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingB3++;
                isSpace = false;
                gmg.DartScoreReSet();
                RoundRead();
                Invoke("TeamNumberMinus", 5f);
                Invoke("PlayerNumberPlus", 5f);
            }

            if (Players == 3 && isBT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingB4++;
                isSpace = false;
                gmg.DartScoreReSet();
                RoundRead();
                Invoke("TeamNumberMinus", 5f);
                Invoke("PlayerNumberPlus", 5f);
            }

            if (Players == 4 && isBT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingB5++;
                isSpace = false;
                gmg.DartScoreReSet();
                RoundRead();
                Invoke("TeamNumberMinus", 5f);
                Invoke("PlayerNumberPlus", 5f);
            }

            if (Players == 5 && isBT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RScore += 1;
                RoundCountingB6++;
                isSpace = false;
                gmg.DartScoreReSet();
                RoundRead();
                Invoke("PlayerNumberMinus", 5f);
                Invoke("TeamNumberMinus", 5f);

            }
        }
        if (Round == RoundStop && isBT && Counting == 4)
            GameEndRead();
        if (isATAllLine)
        {
            win = 0;
            isWin = true;
            isAT = true;
            isBT = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isBTAllLine)
        {
            win = 1;
            isWin = true;
            isAT = false;
            isBT = true;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
    }
    /*================================*/
    void RoundRead()
    {
        isRead = true;
        g_P_Ani.SetActive(false);
        g_C_Ani.SetActive(true);
        g_ScorePlate.SetActive(false);
        Invoke("RoundStart", 4f);
    }

    void RoundStart()
    {
        g_C_Ani.SetActive(false);
        g_RoundOn.SetActive(true);
        g_RoundNum[Round].SetActive(true);
        g_RoundR.SetActive(true);
        g_R_Ani.SetActive(true);
        Invoke("GameStart", 1f);
    }

    void GameStart()
    {
        Counting = 0;
        g_RoundNum[Round].SetActive(false);
        g_RoundR.SetActive(false);
        g_R_Ani.SetActive(false);
        g_RoundOn.SetActive(false);
        g_ScorePlate.SetActive(true);
        Round += 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void GameEndRead()
    {
        if (TeamScore[0] < TeamScore[1])
        {
            isAT = false;
            isBT = true;
            isWin = true;
            WinRead();
        }
        if (TeamScore[1] < TeamScore[0])
        {
            isAT = true;
            isBT = false;
            isWin = true;
            WinRead();
        }
        if (TeamScore[0] == TeamScore[1])
        {
            if (AverageATotla < AverageBTotla)
            {
                isBT = true;
                isAT = false;
                isWin = true;
                WinRead();
            }
            if (AverageATotla > AverageBTotla)
            {
                isAT = true;
                isBT = false;
                isWin = true;
                WinRead();
            }
            if (AverageATotla == AverageBTotla)
            {
                isAT = true;
                isBT = false;
                isWin = true;
                WinRead();
            }
        }
    }

    void WinRead()
    {
        if (isAT && !isBT)
        {
            win = 0;
            isWin = true;
            isAT = true;
            isBT = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isBT && !isAT)
        {
            win = 1;
            isWin = true;
            isAT = false;
            isBT = true;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
    }

    void MyTurn()
    {
        if (isAT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[0];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_P_Score[0].SetActive(true);
            g_P_Score[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_MRPScore[0].SetActive(true);
            g_RoundScore[0].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = true;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isAT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[1];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[1];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_P_Score[0].SetActive(true);
            g_P_Score[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[1].SetActive(true);
            g_MRPScore[1].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = true;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isAT && Players == 2)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[2];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[2];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_P_Score[0].SetActive(true);
            g_P_Score[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[2].SetActive(true);
            g_MRPScore[2].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = true;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isAT && Players == 3)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[3];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[3];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_P_Score[0].SetActive(true);
            g_P_Score[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[3].SetActive(true);
            g_MRPScore[3].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = true;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isAT && Players == 4)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[4];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[4];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_P_Score[0].SetActive(true);
            g_P_Score[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[4].SetActive(true);
            g_MRPScore[4].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = true;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isAT && Players == 5)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[5];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[5];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_P_Score[0].SetActive(true);
            g_P_Score[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[5].SetActive(true);
            g_MRPScore[5].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = true;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isBT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOn[0];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[0];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_P_Score[1].SetActive(true);
            g_P_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[6].SetActive(true);
            g_MRPScore[6].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = true;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isBT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOn[1];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[1];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_P_Score[1].SetActive(true);
            g_P_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[7].SetActive(true);
            g_MRPScore[7].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = true;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isBT && Players == 2)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOn[2];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[2];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_P_Score[1].SetActive(true);
            g_P_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[8].SetActive(true);
            g_MRPScore[8].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = true;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isBT && Players == 3)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOn[3];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[3];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_P_Score[1].SetActive(true);
            g_P_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[9].SetActive(true);
            g_MRPScore[9].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = true;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isBT && Players == 4)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOn[4];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[4];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_P_Score[1].SetActive(true);
            g_P_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[10].SetActive(true);
            g_MRPScore[10].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = true;
                i_RScoreB6[i].enabled = false;
            }
        }

        if (isBT && Players == 5)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOn[5];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[5];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_P_Score[1].SetActive(true);
            g_P_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            for (int i = 0; i < g_RoundScore.Length; i++)
                g_RoundScore[i].SetActive(false);
            for (int i = 0; i < g_MRPScore.Length; i++)
                g_MRPScore[i].SetActive(false);

            g_RoundScore[11].SetActive(true);
            g_MRPScore[11].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreA6[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
                i_RScoreB6[i].enabled = true;
            }
        }
    }
    /*============서브적인 기능========================*/
    void ImageUp()
    {
        if (isAT && !isBT && Players == 0)
        {

            if (RScore == 5)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[5];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[4]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[5]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[6]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[7]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[8]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[9]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
            }

            if (RScore == 6)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[6];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[7]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[8]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[9]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
            }

            if (RScore == 7)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[7];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
            }

            if (RScore == 8)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[8];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
            }

            if (RScore == 9)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[9];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
            }

            if (RScore == 10)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[10];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];
            }

            if (RScore == 11)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[11];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];
            }

            if (RScore == 12)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[12];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[39]];
            }

            if (RScore == 13)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[13];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[39]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[40]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[41]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[42]];
            }

            if (RScore == 14)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[14];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[39]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[40]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[41]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[42]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[43]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[44]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[45]];
            }
        }

        else if (isAT && !isBT && Players == 1)
        {
            if (RScore == 5)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[5];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[4]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[5]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[6]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[7]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[8]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[9]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
            }

            if (RScore == 6)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[6];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[7]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[8]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[9]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
            }

            if (RScore == 7)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[7];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
            }

            if (RScore == 8)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[8];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
            }

            if (RScore == 9)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[9];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
            }

            if (RScore == 10)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[10];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];
            }

            if (RScore == 11)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[11];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];
            }

            if (RScore == 12)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[12];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[39]];
            }

            if (RScore == 13)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[13];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[39]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[40]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[41]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[42]];
            }

            if (RScore == 14)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[14];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[39]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[40]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[41]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[42]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[43]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[44]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[45]];
            }
        }

        else if (isAT && !isBT && Players == 2)
        {
            if (RScore == 5)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[5];

                g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[4]];
                g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[5]];
                g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[6]];

                g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[7]];
                g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[8]];
                g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[9]];

                g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[10]];
                g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[11]];
                g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[12]];

                g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[13]];
                g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[14]];
                g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[15]];

                g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[16]];
                g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[17]];
                g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[18]];
            }

            if (RScore == 6)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[6];

                g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[7]];
                g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[8]];
                g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[9]];

                g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[10]];
                g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[11]];
                g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[12]];

                g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[13]];
                g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[14]];
                g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[15]];

                g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[16]];
                g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[17]];
                g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[18]];

                g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[19]];
                g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[20]];
                g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[21]];
            }

            if (RScore == 7)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[7];

                g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[10]];
                g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[11]];
                g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[12]];

                g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[13]];
                g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[14]];
                g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[15]];

                g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[16]];
                g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[17]];
                g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[18]];

                g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[19]];
                g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[20]];
                g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[21]];

                g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[22]];
                g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[23]];
                g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[24]];
            }

            if (RScore == 8)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[8];

                g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[13]];
                g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[14]];
                g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[15]];

                g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[16]];
                g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[17]];
                g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[18]];

                g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[19]];
                g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[20]];
                g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[21]];

                g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[22]];
                g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[23]];
                g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[24]];

                g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[25]];
                g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[26]];
                g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[27]];
            }

            if (RScore == 9)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[9];

                g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[16]];
                g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[17]];
                g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[18]];

                g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[19]];
                g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[20]];
                g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[21]];

                g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[22]];
                g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[23]];
                g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[24]];

                g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[25]];
                g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[26]];
                g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[27]];

                g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[28]];
                g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[29]];
                g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[30]];
            }

            if (RScore == 10)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[10];

                g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[19]];
                g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[20]];
                g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[21]];

                g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[22]];
                g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[23]];
                g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[24]];

                g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[25]];
                g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[26]];
                g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[27]];

                g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[28]];
                g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[29]];
                g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[30]];

                g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[31]];
                g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[32]];
                g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[33]];
            }

            if (RScore == 11)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[11];

                g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[22]];
                g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[23]];
                g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[24]];

                g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[25]];
                g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[26]];
                g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[27]];

                g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[28]];
                g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[29]];
                g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[30]];

                g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[31]];
                g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[32]];
                g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[33]];

                g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[34]];
                g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[35]];
                g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[36]];
            }

            if (RScore == 12)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[12];

                g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[25]];
                g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[26]];
                g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[27]];

                g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[28]];
                g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[29]];
                g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[30]];

                g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[31]];
                g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[32]];
                g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[33]];

                g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[34]];
                g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[35]];
                g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[36]];

                g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[37]];
                g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[38]];
                g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[39]];
            }

            if (RScore == 13)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[13];

                g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[28]];
                g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[29]];
                g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[30]];

                g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[31]];
                g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[32]];
                g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[33]];

                g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[34]];
                g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[35]];
                g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[36]];

                g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[37]];
                g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[38]];
                g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[39]];

                g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[40]];
                g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[41]];
                g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[42]];
            }

            if (RScore == 14)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[14];

                g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[31]];
                g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[32]];
                g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[33]];

                g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[34]];
                g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[35]];
                g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[36]];

                g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[37]];
                g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[38]];
                g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[39]];

                g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[40]];
                g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[41]];
                g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[42]];

                g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[43]];
                g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[44]];
                g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[45]];
            }
        }

        else if (isAT && !isBT && Players == 3)
        {
            if (RScore == 5)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[5];

                g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[4]];
                g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[5]];
                g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[6]];

                g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[7]];
                g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[8]];
                g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[9]];

                g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[10]];
                g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[11]];
                g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[12]];

                g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[13]];
                g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[14]];
                g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[15]];

                g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[16]];
                g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[17]];
                g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[18]];
            }

            if (RScore == 6)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[6];

                g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[7]];
                g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[8]];
                g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[9]];

                g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[10]];
                g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[11]];
                g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[12]];

                g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[13]];
                g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[14]];
                g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[15]];

                g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[16]];
                g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[17]];
                g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[18]];

                g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[19]];
                g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[20]];
                g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[21]];
            }

            if (RScore == 7)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[7];

                g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[10]];
                g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[11]];
                g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[12]];

                g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[13]];
                g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[14]];
                g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[15]];

                g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[16]];
                g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[17]];
                g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[18]];

                g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[19]];
                g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[20]];
                g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[21]];

                g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[22]];
                g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[23]];
                g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[24]];
            }

            if (RScore == 8)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[8];

                g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[13]];
                g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[14]];
                g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[15]];

                g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[16]];
                g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[17]];
                g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[18]];

                g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[19]];
                g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[20]];
                g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[21]];

                g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[22]];
                g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[23]];
                g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[24]];

                g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[25]];
                g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[26]];
                g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[27]];
            }

            if (RScore == 9)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[9];

                g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[16]];
                g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[17]];
                g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[18]];

                g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[19]];
                g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[20]];
                g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[21]];

                g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[22]];
                g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[23]];
                g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[24]];

                g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[25]];
                g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[26]];
                g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[27]];

                g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[28]];
                g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[29]];
                g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[30]];
            }

            if (RScore == 10)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[10];

                g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[19]];
                g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[20]];
                g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[21]];

                g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[22]];
                g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[23]];
                g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[24]];

                g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[25]];
                g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[26]];
                g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[27]];

                g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[28]];
                g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[29]];
                g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[30]];

                g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[31]];
                g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[32]];
                g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[33]];
            }

            if (RScore == 11)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[11];

                g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[22]];
                g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[23]];
                g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[24]];

                g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[25]];
                g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[26]];
                g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[27]];

                g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[28]];
                g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[29]];
                g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[30]];

                g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[31]];
                g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[32]];
                g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[33]];

                g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[34]];
                g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[35]];
                g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[36]];
            }

            if (RScore == 12)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[12];

                g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[25]];
                g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[26]];
                g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[27]];

                g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[28]];
                g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[29]];
                g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[30]];

                g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[31]];
                g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[32]];
                g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[33]];

                g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[34]];
                g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[35]];
                g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[36]];

                g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[37]];
                g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[38]];
                g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[39]];
            }

            if (RScore == 13)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[13];

                g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[28]];
                g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[29]];
                g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[30]];

                g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[31]];
                g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[32]];
                g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[33]];

                g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[34]];
                g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[35]];
                g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[36]];

                g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[37]];
                g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[38]];
                g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[39]];

                g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[40]];
                g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[41]];
                g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[42]];
            }

            if (RScore == 14)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[14];

                g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[31]];
                g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[32]];
                g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[33]];

                g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[34]];
                g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[35]];
                g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[36]];

                g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[37]];
                g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[38]];
                g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[39]];

                g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[40]];
                g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[41]];
                g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[42]];

                g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[43]];
                g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[44]];
                g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[45]];
            }
        }

        else if (isAT && !isBT && Players == 4)
        {
            if (RScore == 5)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[5];

                g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[4]];
                g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[5]];
                g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[6]];

                g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[7]];
                g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[8]];
                g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[9]];

                g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[10]];
                g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[11]];
                g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[12]];

                g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[13]];
                g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[14]];
                g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[15]];

                g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[16]];
                g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[17]];
                g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[18]];
            }

            if (RScore == 6)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[6];

                g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[7]];
                g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[8]];
                g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[9]];

                g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[10]];
                g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[11]];
                g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[12]];

                g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[13]];
                g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[14]];
                g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[15]];

                g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[16]];
                g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[17]];
                g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[18]];

                g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[19]];
                g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[20]];
                g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[21]];
            }

            if (RScore == 7)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[7];

                g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[10]];
                g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[11]];
                g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[12]];

                g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[13]];
                g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[14]];
                g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[15]];

                g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[16]];
                g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[17]];
                g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[18]];

                g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[19]];
                g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[20]];
                g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[21]];

                g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[22]];
                g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[23]];
                g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[24]];
            }

            if (RScore == 8)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[8];

                g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[13]];
                g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[14]];
                g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[15]];

                g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[16]];
                g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[17]];
                g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[18]];

                g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[19]];
                g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[20]];
                g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[21]];

                g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[22]];
                g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[23]];
                g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[24]];

                g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[25]];
                g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[26]];
                g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[27]];
            }

            if (RScore == 9)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[9];

                g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[16]];
                g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[17]];
                g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[18]];

                g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[19]];
                g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[20]];
                g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[21]];

                g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[22]];
                g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[23]];
                g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[24]];

                g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[25]];
                g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[26]];
                g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[27]];

                g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[28]];
                g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[29]];
                g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[30]];
            }

            if (RScore == 10)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[10];

                g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[19]];
                g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[20]];
                g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[21]];

                g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[22]];
                g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[23]];
                g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[24]];

                g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[25]];
                g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[26]];
                g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[27]];

                g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[28]];
                g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[29]];
                g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[30]];

                g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[31]];
                g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[32]];
                g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[33]];
            }

            if (RScore == 11)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[11];

                g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[22]];
                g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[23]];
                g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[24]];

                g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[25]];
                g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[26]];
                g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[27]];

                g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[28]];
                g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[29]];
                g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[30]];

                g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[31]];
                g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[32]];
                g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[33]];

                g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[34]];
                g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[35]];
                g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[36]];
            }

            if (RScore == 12)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[12];

                g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[25]];
                g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[26]];
                g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[27]];

                g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[28]];
                g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[29]];
                g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[30]];

                g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[31]];
                g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[32]];
                g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[33]];

                g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[34]];
                g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[35]];
                g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[36]];

                g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[37]];
                g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[38]];
                g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[39]];
            }

            if (RScore == 13)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[13];

                g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[28]];
                g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[29]];
                g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[30]];

                g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[31]];
                g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[32]];
                g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[33]];

                g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[34]];
                g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[35]];
                g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[36]];

                g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[37]];
                g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[38]];
                g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[39]];

                g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[40]];
                g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[41]];
                g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[42]];
            }

            if (RScore == 14)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[14];

                g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[31]];
                g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[32]];
                g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[33]];

                g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[34]];
                g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[35]];
                g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[36]];

                g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[37]];
                g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[38]];
                g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[39]];

                g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[40]];
                g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[41]];
                g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[42]];

                g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[43]];
                g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[44]];
                g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[45]];
            }
        }

        else if (isAT && !isBT && Players == 5)
        {
            if (RScore == 5)
            {
                i_RScoreA6[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA6[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA6[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA6[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA6[4].GetComponent<Image>().sprite = s_RScore[5];

                g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[4]];
                g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[5]];
                g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[6]];

                g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[7]];
                g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[8]];
                g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[9]];

                g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[10]];
                g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[11]];
                g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[12]];

                g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[13]];
                g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[14]];
                g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[15]];

                g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[16]];
                g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[17]];
                g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[18]];
            }

            if (RScore == 6)
            {
                i_RScoreA6[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA6[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA6[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA6[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA6[4].GetComponent<Image>().sprite = s_RScore[6];

                g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[7]];
                g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[8]];
                g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[9]];

                g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[10]];
                g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[11]];
                g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[12]];

                g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[13]];
                g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[14]];
                g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[15]];

                g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[16]];
                g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[17]];
                g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[18]];

                g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[19]];
                g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[20]];
                g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[21]];
            }

            if (RScore == 7)
            {
                i_RScoreA6[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA6[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA6[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA6[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA6[4].GetComponent<Image>().sprite = s_RScore[7];

                g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[10]];
                g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[11]];
                g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[12]];

                g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[13]];
                g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[14]];
                g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[15]];

                g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[16]];
                g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[17]];
                g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[18]];

                g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[19]];
                g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[20]];
                g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[21]];

                g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[22]];
                g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[23]];
                g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[24]];
            }

            if (RScore == 8)
            {
                i_RScoreA6[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA6[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA6[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA6[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA6[4].GetComponent<Image>().sprite = s_RScore[8];

                g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[13]];
                g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[14]];
                g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[15]];

                g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[16]];
                g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[17]];
                g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[18]];

                g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[19]];
                g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[20]];
                g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[21]];

                g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[22]];
                g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[23]];
                g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[24]];

                g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[25]];
                g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[26]];
                g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[27]];
            }

            if (RScore == 9)
            {
                i_RScoreA6[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA6[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA6[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA6[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA6[4].GetComponent<Image>().sprite = s_RScore[9];

                g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[16]];
                g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[17]];
                g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[18]];

                g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[19]];
                g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[20]];
                g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[21]];

                g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[22]];
                g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[23]];
                g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[24]];

                g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[25]];
                g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[26]];
                g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[27]];

                g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[28]];
                g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[29]];
                g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[30]];
            }

            if (RScore == 10)
            {
                i_RScoreA6[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA6[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA6[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA6[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA6[4].GetComponent<Image>().sprite = s_RScore[10];

                g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[19]];
                g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[20]];
                g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[21]];

                g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[22]];
                g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[23]];
                g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[24]];

                g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[25]];
                g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[26]];
                g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[27]];

                g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[28]];
                g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[29]];
                g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[30]];

                g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[31]];
                g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[32]];
                g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[33]];
            }

            if (RScore == 11)
            {
                i_RScoreA6[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA6[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA6[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA6[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA6[4].GetComponent<Image>().sprite = s_RScore[11];

                g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[22]];
                g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[23]];
                g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[24]];

                g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[25]];
                g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[26]];
                g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[27]];

                g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[28]];
                g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[29]];
                g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[30]];

                g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[31]];
                g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[32]];
                g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[33]];

                g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[34]];
                g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[35]];
                g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[36]];
            }

            if (RScore == 12)
            {
                i_RScoreA6[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA6[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA6[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA6[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA6[4].GetComponent<Image>().sprite = s_RScore[12];

                g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[25]];
                g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[26]];
                g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[27]];

                g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[28]];
                g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[29]];
                g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[30]];

                g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[31]];
                g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[32]];
                g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[33]];

                g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[34]];
                g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[35]];
                g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[36]];

                g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[37]];
                g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[38]];
                g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[39]];
            }

            if (RScore == 13)
            {
                i_RScoreA6[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA6[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA6[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA6[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA6[4].GetComponent<Image>().sprite = s_RScore[13];

                g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[28]];
                g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[29]];
                g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[30]];

                g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[31]];
                g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[32]];
                g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[33]];

                g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[34]];
                g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[35]];
                g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[36]];

                g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[37]];
                g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[38]];
                g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[39]];

                g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[40]];
                g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[41]];
                g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[42]];
            }

            if (RScore == 14)
            {
                i_RScoreA6[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA6[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA6[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA6[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA6[4].GetComponent<Image>().sprite = s_RScore[14];

                g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[31]];
                g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[32]];
                g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[33]];

                g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[34]];
                g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[35]];
                g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[36]];

                g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[37]];
                g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[38]];
                g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[39]];

                g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[40]];
                g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[41]];
                g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[42]];

                g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[43]];
                g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[44]];
                g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[45]];
            }
        }

        else if (isBT && !isAT && Players == 0)
        {

            if (RScore == 5)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[5];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[4]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[5]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[6]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[7]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[8]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[9]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
            }

            if (RScore == 6)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[6];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[7]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[8]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[9]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
            }

            if (RScore == 7)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[7];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
            }

            if (RScore == 8)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[8];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
            }

            if (RScore == 9)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[9];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
            }

            if (RScore == 10)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[10];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];
            }

            if (RScore == 11)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[11];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];
            }

            if (RScore == 12)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[12];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[39]];
            }

            if (RScore == 13)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[13];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[39]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[40]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[41]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[42]];
            }

            if (RScore == 14)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[14];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[39]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[40]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[41]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[42]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[43]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[44]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[45]];
            }
        }

        else if (isBT && !isAT && Players == 1)
        {
            if (RScore == 5)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[5];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[4]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[5]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[6]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[7]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[8]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[9]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
            }

            if (RScore == 6)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[6];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[7]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[8]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[9]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
            }

            if (RScore == 7)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[7];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
            }

            if (RScore == 8)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[8];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
            }

            if (RScore == 9)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[9];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
            }

            if (RScore == 10)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[10];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];
            }

            if (RScore == 11)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[11];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];
            }

            if (RScore == 12)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[12];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[39]];
            }

            if (RScore == 13)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[13];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[39]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[40]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[41]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[42]];
            }

            if (RScore == 14)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[14];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[39]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[40]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[41]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[42]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[43]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[44]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[45]];
            }
        }

        else if (isBT && !isAT && Players == 2)
        {
            if (RScore == 5)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[5];

                g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[4]];
                g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[5]];
                g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[6]];

                g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[7]];
                g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[8]];
                g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[9]];

                g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[10]];
                g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[11]];
                g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[12]];

                g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[13]];
                g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[14]];
                g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[15]];

                g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[16]];
                g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[17]];
                g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[18]];
            }

            if (RScore == 6)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[6];

                g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[7]];
                g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[8]];
                g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[9]];

                g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[10]];
                g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[11]];
                g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[12]];

                g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[13]];
                g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[14]];
                g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[15]];

                g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[16]];
                g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[17]];
                g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[18]];

                g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[19]];
                g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[20]];
                g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[21]];
            }

            if (RScore == 7)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[7];

                g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[10]];
                g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[11]];
                g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[12]];

                g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[13]];
                g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[14]];
                g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[15]];

                g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[16]];
                g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[17]];
                g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[18]];

                g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[19]];
                g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[20]];
                g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[21]];

                g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[22]];
                g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[23]];
                g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[24]];
            }

            if (RScore == 8)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[8];

                g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[13]];
                g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[14]];
                g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[15]];

                g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[16]];
                g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[17]];
                g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[18]];

                g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[19]];
                g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[20]];
                g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[21]];

                g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[22]];
                g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[23]];
                g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[24]];

                g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[25]];
                g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[26]];
                g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[27]];
            }

            if (RScore == 9)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[9];

                g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[16]];
                g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[17]];
                g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[18]];

                g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[19]];
                g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[20]];
                g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[21]];

                g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[22]];
                g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[23]];
                g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[24]];

                g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[25]];
                g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[26]];
                g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[27]];

                g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[28]];
                g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[29]];
                g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[30]];
            }

            if (RScore == 10)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[10];

                g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[19]];
                g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[20]];
                g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[21]];

                g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[22]];
                g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[23]];
                g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[24]];

                g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[25]];
                g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[26]];
                g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[27]];

                g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[28]];
                g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[29]];
                g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[30]];

                g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[31]];
                g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[32]];
                g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[33]];
            }

            if (RScore == 11)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[11];

                g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[22]];
                g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[23]];
                g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[24]];

                g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[25]];
                g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[26]];
                g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[27]];

                g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[28]];
                g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[29]];
                g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[30]];

                g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[31]];
                g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[32]];
                g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[33]];

                g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[34]];
                g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[35]];
                g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[36]];
            }

            if (RScore == 12)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[12];

                g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[25]];
                g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[26]];
                g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[27]];

                g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[28]];
                g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[29]];
                g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[30]];

                g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[31]];
                g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[32]];
                g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[33]];

                g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[34]];
                g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[35]];
                g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[36]];

                g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[37]];
                g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[38]];
                g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[39]];
            }

            if (RScore == 13)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[13];

                g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[28]];
                g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[29]];
                g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[30]];

                g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[31]];
                g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[32]];
                g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[33]];

                g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[34]];
                g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[35]];
                g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[36]];

                g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[37]];
                g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[38]];
                g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[39]];

                g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[40]];
                g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[41]];
                g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[42]];
            }

            if (RScore == 14)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[14];

                g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[31]];
                g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[32]];
                g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[33]];

                g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[34]];
                g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[35]];
                g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[36]];

                g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[37]];
                g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[38]];
                g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[39]];

                g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[40]];
                g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[41]];
                g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[42]];

                g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[43]];
                g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[44]];
                g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[45]];
            }
        }

        else if (isBT && !isAT && Players == 3)
        {
            if (RScore == 5)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[5];

                g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[4]];
                g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[5]];
                g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[6]];

                g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[7]];
                g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[8]];
                g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[9]];

                g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[10]];
                g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[11]];
                g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[12]];

                g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[13]];
                g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[14]];
                g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[15]];

                g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[16]];
                g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[17]];
                g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[18]];
            }

            if (RScore == 6)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[6];

                g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[7]];
                g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[8]];
                g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[9]];

                g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[10]];
                g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[11]];
                g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[12]];

                g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[13]];
                g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[14]];
                g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[15]];

                g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[16]];
                g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[17]];
                g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[18]];

                g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[19]];
                g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[20]];
                g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[21]];
            }

            if (RScore == 7)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[7];

                g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[10]];
                g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[11]];
                g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[12]];

                g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[13]];
                g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[14]];
                g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[15]];

                g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[16]];
                g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[17]];
                g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[18]];

                g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[19]];
                g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[20]];
                g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[21]];

                g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[22]];
                g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[23]];
                g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[24]];
            }

            if (RScore == 8)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[8];

                g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[13]];
                g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[14]];
                g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[15]];

                g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[16]];
                g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[17]];
                g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[18]];

                g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[19]];
                g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[20]];
                g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[21]];

                g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[22]];
                g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[23]];
                g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[24]];

                g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[25]];
                g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[26]];
                g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[27]];
            }

            if (RScore == 9)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[9];

                g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[16]];
                g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[17]];
                g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[18]];

                g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[19]];
                g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[20]];
                g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[21]];

                g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[22]];
                g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[23]];
                g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[24]];

                g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[25]];
                g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[26]];
                g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[27]];

                g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[28]];
                g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[29]];
                g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[30]];
            }

            if (RScore == 10)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[10];

                g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[19]];
                g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[20]];
                g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[21]];

                g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[22]];
                g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[23]];
                g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[24]];

                g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[25]];
                g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[26]];
                g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[27]];

                g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[28]];
                g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[29]];
                g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[30]];

                g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[31]];
                g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[32]];
                g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[33]];
            }

            if (RScore == 11)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[11];

                g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[22]];
                g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[23]];
                g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[24]];

                g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[25]];
                g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[26]];
                g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[27]];

                g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[28]];
                g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[29]];
                g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[30]];

                g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[31]];
                g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[32]];
                g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[33]];

                g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[34]];
                g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[35]];
                g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[36]];
            }

            if (RScore == 12)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[12];

                g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[25]];
                g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[26]];
                g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[27]];

                g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[28]];
                g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[29]];
                g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[30]];

                g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[31]];
                g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[32]];
                g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[33]];

                g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[34]];
                g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[35]];
                g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[36]];

                g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[37]];
                g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[38]];
                g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[39]];
            }

            if (RScore == 13)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[13];

                g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[28]];
                g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[29]];
                g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[30]];

                g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[31]];
                g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[32]];
                g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[33]];

                g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[34]];
                g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[35]];
                g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[36]];

                g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[37]];
                g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[38]];
                g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[39]];

                g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[40]];
                g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[41]];
                g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[42]];
            }

            if (RScore == 14)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[14];

                g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[31]];
                g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[32]];
                g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[33]];

                g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[34]];
                g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[35]];
                g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[36]];

                g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[37]];
                g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[38]];
                g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[39]];

                g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[40]];
                g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[41]];
                g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[42]];

                g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[43]];
                g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[44]];
                g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[45]];
            }
        }

        else if (isBT && !isAT && Players == 4)
        {
            if (RScore == 5)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[5];

                g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[4]];
                g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[5]];
                g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[6]];

                g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[7]];
                g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[8]];
                g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[9]];

                g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[10]];
                g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[11]];
                g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[12]];

                g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[13]];
                g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[14]];
                g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[15]];

                g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[16]];
                g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[17]];
                g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[18]];
            }

            if (RScore == 6)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[6];

                g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[7]];
                g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[8]];
                g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[9]];

                g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[10]];
                g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[11]];
                g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[12]];

                g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[13]];
                g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[14]];
                g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[15]];

                g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[16]];
                g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[17]];
                g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[18]];

                g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[19]];
                g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[20]];
                g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[21]];
            }

            if (RScore == 7)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[7];

                g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[10]];
                g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[11]];
                g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[12]];

                g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[13]];
                g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[14]];
                g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[15]];

                g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[16]];
                g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[17]];
                g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[18]];

                g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[19]];
                g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[20]];
                g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[21]];

                g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[22]];
                g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[23]];
                g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[24]];
            }

            if (RScore == 8)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[8];

                g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[13]];
                g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[14]];
                g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[15]];

                g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[16]];
                g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[17]];
                g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[18]];

                g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[19]];
                g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[20]];
                g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[21]];

                g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[22]];
                g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[23]];
                g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[24]];

                g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[25]];
                g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[26]];
                g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[27]];
            }

            if (RScore == 9)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[9];

                g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[16]];
                g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[17]];
                g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[18]];

                g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[19]];
                g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[20]];
                g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[21]];

                g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[22]];
                g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[23]];
                g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[24]];

                g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[25]];
                g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[26]];
                g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[27]];

                g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[28]];
                g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[29]];
                g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[30]];
            }

            if (RScore == 10)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[10];

                g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[19]];
                g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[20]];
                g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[21]];

                g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[22]];
                g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[23]];
                g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[24]];

                g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[25]];
                g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[26]];
                g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[27]];

                g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[28]];
                g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[29]];
                g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[30]];

                g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[31]];
                g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[32]];
                g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[33]];
            }

            if (RScore == 11)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[11];

                g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[22]];
                g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[23]];
                g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[24]];

                g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[25]];
                g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[26]];
                g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[27]];

                g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[28]];
                g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[29]];
                g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[30]];

                g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[31]];
                g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[32]];
                g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[33]];

                g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[34]];
                g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[35]];
                g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[36]];
            }

            if (RScore == 12)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[12];

                g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[25]];
                g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[26]];
                g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[27]];

                g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[28]];
                g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[29]];
                g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[30]];

                g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[31]];
                g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[32]];
                g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[33]];

                g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[34]];
                g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[35]];
                g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[36]];

                g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[37]];
                g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[38]];
                g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[39]];
            }

            if (RScore == 13)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[13];

                g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[28]];
                g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[29]];
                g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[30]];

                g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[31]];
                g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[32]];
                g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[33]];

                g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[34]];
                g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[35]];
                g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[36]];

                g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[37]];
                g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[38]];
                g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[39]];

                g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[40]];
                g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[41]];
                g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[42]];
            }

            if (RScore == 14)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[14];

                g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[31]];
                g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[32]];
                g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[33]];

                g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[34]];
                g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[35]];
                g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[36]];

                g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[37]];
                g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[38]];
                g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[39]];

                g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[40]];
                g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[41]];
                g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[42]];

                g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[43]];
                g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[44]];
                g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[45]];
            }
        }

        else if (isBT && !isAT && Players == 5)
        {
            if (RScore == 5)
            {
                i_RScoreB6[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB6[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB6[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB6[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB6[4].GetComponent<Image>().sprite = s_RScore[5];

                g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[4]];
                g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[5]];
                g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[6]];

                g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[7]];
                g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[8]];
                g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[9]];

                g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[10]];
                g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[11]];
                g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[12]];

                g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[13]];
                g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[14]];
                g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[15]];

                g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[16]];
                g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[17]];
                g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[18]];
            }

            if (RScore == 6)
            {
                i_RScoreB6[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB6[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB6[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB6[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB6[4].GetComponent<Image>().sprite = s_RScore[6];

                g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[7]];
                g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[8]];
                g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[9]];

                g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[10]];
                g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[11]];
                g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[12]];

                g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[13]];
                g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[14]];
                g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[15]];

                g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[16]];
                g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[17]];
                g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[18]];

                g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[19]];
                g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[20]];
                g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[21]];
            }

            if (RScore == 7)
            {
                i_RScoreB6[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB6[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB6[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB6[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB6[4].GetComponent<Image>().sprite = s_RScore[7];

                g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[10]];
                g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[11]];
                g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[12]];

                g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[13]];
                g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[14]];
                g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[15]];

                g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[16]];
                g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[17]];
                g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[18]];

                g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[19]];
                g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[20]];
                g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[21]];

                g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[22]];
                g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[23]];
                g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[24]];
            }

            if (RScore == 8)
            {
                i_RScoreB6[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB6[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB6[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB6[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB6[4].GetComponent<Image>().sprite = s_RScore[8];

                g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[13]];
                g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[14]];
                g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[15]];

                g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[16]];
                g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[17]];
                g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[18]];

                g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[19]];
                g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[20]];
                g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[21]];

                g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[22]];
                g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[23]];
                g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[24]];

                g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[25]];
                g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[26]];
                g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[27]];
            }

            if (RScore == 9)
            {
                i_RScoreB6[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB6[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB6[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB6[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB6[4].GetComponent<Image>().sprite = s_RScore[9];

                g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[16]];
                g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[17]];
                g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[18]];

                g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[19]];
                g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[20]];
                g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[21]];

                g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[22]];
                g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[23]];
                g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[24]];

                g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[25]];
                g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[26]];
                g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[27]];

                g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[28]];
                g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[29]];
                g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[30]];
            }

            if (RScore == 10)
            {
                i_RScoreB6[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB6[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB6[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB6[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB6[4].GetComponent<Image>().sprite = s_RScore[10];

                g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[19]];
                g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[20]];
                g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[21]];

                g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[22]];
                g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[23]];
                g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[24]];

                g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[25]];
                g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[26]];
                g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[27]];

                g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[28]];
                g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[29]];
                g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[30]];

                g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[31]];
                g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[32]];
                g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[33]];
            }

            if (RScore == 11)
            {
                i_RScoreB6[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB6[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB6[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB6[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB6[4].GetComponent<Image>().sprite = s_RScore[11];

                g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[22]];
                g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[23]];
                g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[24]];

                g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[25]];
                g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[26]];
                g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[27]];

                g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[28]];
                g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[29]];
                g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[30]];

                g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[31]];
                g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[32]];
                g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[33]];

                g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[34]];
                g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[35]];
                g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[36]];
            }

            if (RScore == 12)
            {
                i_RScoreB6[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB6[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB6[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB6[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB6[4].GetComponent<Image>().sprite = s_RScore[12];

                g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[25]];
                g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[26]];
                g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[27]];

                g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[28]];
                g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[29]];
                g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[30]];

                g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[31]];
                g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[32]];
                g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[33]];

                g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[34]];
                g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[35]];
                g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[36]];

                g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[37]];
                g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[38]];
                g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[39]];
            }

            if (RScore == 13)
            {
                i_RScoreB6[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB6[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB6[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB6[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB6[4].GetComponent<Image>().sprite = s_RScore[13];

                g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[28]];
                g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[29]];
                g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[30]];

                g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[31]];
                g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[32]];
                g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[33]];

                g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[34]];
                g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[35]];
                g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[36]];

                g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[37]];
                g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[38]];
                g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[39]];

                g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[40]];
                g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[41]];
                g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[42]];
            }

            if (RScore == 14)
            {
                i_RScoreB6[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB6[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB6[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB6[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB6[4].GetComponent<Image>().sprite = s_RScore[14];

                g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[31]];
                g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[32]];
                g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[33]];

                g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[34]];
                g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[35]];
                g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[36]];

                g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[37]];
                g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[38]];
                g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[39]];

                g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[40]];
                g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[41]];
                g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[42]];

                g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[43]];
                g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[44]];
                g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[45]];
            }
        }
    }
    void RoundScore(int MarkScore)
    {
        if (isAT && !isBT && Players == 0)
        {
            MarkSaveAT1[AT1MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_AT1RMark1[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[AT1MarkCounting]];

                if (RScore == 1)
                    g_AT1RMark2[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[AT1MarkCounting]];

                if (RScore == 2)
                    g_AT1RMark3[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[AT1MarkCounting]];

                if (RScore == 3)
                    g_AT1RMark4[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[AT1MarkCounting]];

                if (RScore == 4)
                    g_AT1RMark5[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[AT1MarkCounting]];

                if (RScore == 5)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[4]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[5]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[6]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[7]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[8]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[9]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                }

                if (RScore == 6)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[7]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[8]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[9]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                }

                if (RScore == 7)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                }

                if (RScore == 8)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];

                }
                if (RScore == 9)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                }

                if (RScore == 10)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];
                }

                if (RScore == 11)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];
                }

                if (RScore == 12)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[39]];
                }

                if (RScore == 13)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[39]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[40]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[41]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[42]];
                }
                if (RScore == 14)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[39]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[40]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[41]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[42]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[43]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[44]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[45]];
                }
            }
        }

        else if (isAT && !isBT && Players == 1)
        {
            MarkSaveAT2[AT2MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_AT2RMark1[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[AT2MarkCounting]];

                if (RScore == 1)
                    g_AT2RMark2[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[AT2MarkCounting]];

                if (RScore == 2)
                    g_AT2RMark3[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[AT2MarkCounting]];

                if (RScore == 3)
                    g_AT2RMark4[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[AT2MarkCounting]];

                if (RScore == 4)
                    g_AT2RMark5[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[AT2MarkCounting]];

                if (RScore == 5)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[4]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[5]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[6]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[7]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[8]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[9]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                }

                if (RScore == 6)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[7]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[8]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[9]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                }

                if (RScore == 7)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                }

                if (RScore == 8)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                }

                if (RScore == 9)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                }

                if (RScore == 10)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                }

                if (RScore == 11)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];
                }

                if (RScore == 12)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[39]];
                }

                if (RScore == 13)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[39]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[40]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[41]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[42]];
                }

                if (RScore == 14)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[39]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[40]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[41]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[42]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[43]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[44]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[45]];
                }
            }
        }

        else if (isAT && !isBT && Players == 2)
        {
            MarkSaveAT3[AT3MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_AT3RMark1[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[AT3MarkCounting]];

                if (RScore == 1)
                    g_AT3RMark2[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[AT3MarkCounting]];

                if (RScore == 2)
                    g_AT3RMark3[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[AT3MarkCounting]];

                if (RScore == 3)
                    g_AT3RMark4[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[AT3MarkCounting]];

                if (RScore == 4)
                    g_AT3RMark5[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[AT3MarkCounting]];

                if (RScore == 5)
                {
                    g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[4]];
                    g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[5]];
                    g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[6]];

                    g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[7]];
                    g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[8]];
                    g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[9]];

                    g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[10]];
                    g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[11]];
                    g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[12]];

                    g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[13]];
                    g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[14]];
                    g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[15]];

                    g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[16]];
                    g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[17]];
                    g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[18]];
                }

                if (RScore == 6)
                {
                    g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[7]];
                    g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[8]];
                    g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[9]];

                    g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[10]];
                    g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[11]];
                    g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[12]];

                    g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[13]];
                    g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[14]];
                    g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[15]];

                    g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[16]];
                    g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[17]];
                    g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[18]];

                    g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[19]];
                    g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[20]];
                    g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[21]];
                }

                if (RScore == 7)
                {
                    g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[10]];
                    g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[11]];
                    g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[12]];

                    g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[13]];
                    g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[14]];
                    g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[15]];

                    g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[16]];
                    g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[17]];
                    g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[18]];

                    g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[19]];
                    g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[20]];
                    g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[21]];

                    g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[22]];
                    g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[23]];
                    g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[24]];
                }

                if (RScore == 8)
                {
                    g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[13]];
                    g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[14]];
                    g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[15]];

                    g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[16]];
                    g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[17]];
                    g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[18]];

                    g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[19]];
                    g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[20]];
                    g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[21]];

                    g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[22]];
                    g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[23]];
                    g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[24]];

                    g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[25]];
                    g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[26]];
                    g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[27]];
                }

                if (RScore == 9)
                {
                    g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[16]];
                    g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[17]];
                    g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[18]];

                    g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[19]];
                    g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[20]];
                    g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[21]];

                    g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[22]];
                    g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[23]];
                    g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[24]];

                    g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[25]];
                    g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[26]];
                    g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[27]];

                    g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[28]];
                    g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[29]];
                    g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[30]];
                }

                if (RScore == 10)
                {
                    g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[19]];
                    g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[20]];
                    g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[21]];

                    g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[22]];
                    g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[23]];
                    g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[24]];

                    g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[25]];
                    g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[26]];
                    g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[27]];

                    g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[28]];
                    g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[29]];
                    g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[30]];

                    g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[31]];
                    g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[32]];
                    g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[33]];
                }

                if (RScore == 11)
                {
                    g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[22]];
                    g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[23]];
                    g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[24]];

                    g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[25]];
                    g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[26]];
                    g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[27]];

                    g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[28]];
                    g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[29]];
                    g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[30]];

                    g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[31]];
                    g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[32]];
                    g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[33]];

                    g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[34]];
                    g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[35]];
                    g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[36]];
                }

                if (RScore == 12)
                {
                    g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[25]];
                    g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[26]];
                    g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[27]];

                    g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[28]];
                    g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[29]];
                    g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[30]];

                    g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[31]];
                    g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[32]];
                    g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[33]];

                    g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[34]];
                    g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[35]];
                    g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[36]];

                    g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[37]];
                    g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[38]];
                    g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[39]];
                }

                if (RScore == 13)
                {
                    g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[28]];
                    g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[29]];
                    g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[30]];

                    g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[31]];
                    g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[32]];
                    g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[33]];

                    g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[34]];
                    g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[35]];
                    g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[36]];

                    g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[37]];
                    g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[38]];
                    g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[39]];

                    g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[40]];
                    g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[41]];
                    g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[42]];
                }

                if (RScore == 14)
                {
                    g_AT3RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[31]];
                    g_AT3RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[32]];
                    g_AT3RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[33]];

                    g_AT3RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[34]];
                    g_AT3RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[35]];
                    g_AT3RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[36]];

                    g_AT3RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[37]];
                    g_AT3RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[38]];
                    g_AT3RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[39]];

                    g_AT3RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[40]];
                    g_AT3RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[41]];
                    g_AT3RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[42]];

                    g_AT3RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[43]];
                    g_AT3RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[44]];
                    g_AT3RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT3[45]];
                }
            }
        }

        else if (isAT && !isBT && Players == 3)
        {
            MarkSaveAT4[AT4MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_AT4RMark1[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[AT4MarkCounting]];

                if (RScore == 1)
                    g_AT4RMark2[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[AT4MarkCounting]];

                if (RScore == 2)
                    g_AT4RMark3[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[AT4MarkCounting]];

                if (RScore == 3)
                    g_AT4RMark4[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[AT4MarkCounting]];

                if (RScore == 4)
                    g_AT4RMark5[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[AT4MarkCounting]];

                if (RScore == 5)
                {
                    g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[4]];
                    g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[5]];
                    g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[6]];

                    g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[7]];
                    g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[8]];
                    g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[9]];

                    g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[10]];
                    g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[11]];
                    g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[12]];

                    g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[13]];
                    g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[14]];
                    g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[15]];

                    g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[16]];
                    g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[17]];
                    g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[18]];
                }

                if (RScore == 6)
                {
                    g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[7]];
                    g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[8]];
                    g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[9]];

                    g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[10]];
                    g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[11]];
                    g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[12]];

                    g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[13]];
                    g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[14]];
                    g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[15]];

                    g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[16]];
                    g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[17]];
                    g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[18]];

                    g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[19]];
                    g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[20]];
                    g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[21]];
                }

                if (RScore == 7)
                {
                    g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[10]];
                    g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[11]];
                    g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[12]];

                    g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[13]];
                    g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[14]];
                    g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[15]];

                    g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[16]];
                    g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[17]];
                    g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[18]];

                    g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[19]];
                    g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[20]];
                    g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[21]];

                    g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[22]];
                    g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[23]];
                    g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[24]];
                }

                if (RScore == 8)
                {
                    g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[13]];
                    g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[14]];
                    g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[15]];

                    g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[16]];
                    g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[17]];
                    g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[18]];

                    g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[19]];
                    g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[20]];
                    g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[21]];

                    g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[22]];
                    g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[23]];
                    g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[24]];

                    g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[25]];
                    g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[26]];
                    g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[27]];
                }

                if (RScore == 9)
                {
                    g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[16]];
                    g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[17]];
                    g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[18]];

                    g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[19]];
                    g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[20]];
                    g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[21]];

                    g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[22]];
                    g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[23]];
                    g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[24]];

                    g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[25]];
                    g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[26]];
                    g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[27]];

                    g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[28]];
                    g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[29]];
                    g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[30]];
                }

                if (RScore == 10)
                {
                    g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[19]];
                    g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[20]];
                    g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[21]];

                    g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[22]];
                    g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[23]];
                    g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[24]];

                    g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[25]];
                    g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[26]];
                    g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[27]];

                    g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[28]];
                    g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[29]];
                    g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[30]];

                    g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[31]];
                    g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[32]];
                    g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[33]];
                }

                if (RScore == 11)
                {
                    g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[22]];
                    g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[23]];
                    g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[24]];

                    g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[25]];
                    g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[26]];
                    g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[27]];

                    g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[28]];
                    g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[29]];
                    g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[30]];

                    g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[31]];
                    g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[32]];
                    g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[33]];

                    g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[34]];
                    g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[35]];
                    g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[36]];
                }

                if (RScore == 12)
                {
                    g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[25]];
                    g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[26]];
                    g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[27]];

                    g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[28]];
                    g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[29]];
                    g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[30]];

                    g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[31]];
                    g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[32]];
                    g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[33]];

                    g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[34]];
                    g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[35]];
                    g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[36]];

                    g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[37]];
                    g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[38]];
                    g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[39]];
                }

                if (RScore == 13)
                {
                    g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[28]];
                    g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[29]];
                    g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[30]];

                    g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[31]];
                    g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[32]];
                    g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[33]];

                    g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[34]];
                    g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[35]];
                    g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[36]];

                    g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[37]];
                    g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[38]];
                    g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[39]];

                    g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[40]];
                    g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[41]];
                    g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[42]];
                }

                if (RScore == 14)
                {
                    g_AT4RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[31]];
                    g_AT4RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[32]];
                    g_AT4RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[33]];

                    g_AT4RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[34]];
                    g_AT4RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[35]];
                    g_AT4RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[36]];

                    g_AT4RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[37]];
                    g_AT4RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[38]];
                    g_AT4RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[39]];

                    g_AT4RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[40]];
                    g_AT4RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[41]];
                    g_AT4RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[42]];

                    g_AT4RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[43]];
                    g_AT4RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[44]];
                    g_AT4RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT4[45]];
                }
            }
        }

        else if (isAT && !isBT && Players == 4)
        {
            MarkSaveAT5[AT5MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_AT5RMark1[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[AT5MarkCounting]];

                if (RScore == 1)
                    g_AT5RMark2[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[AT5MarkCounting]];

                if (RScore == 2)
                    g_AT5RMark3[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[AT5MarkCounting]];

                if (RScore == 3)
                    g_AT5RMark4[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[AT5MarkCounting]];

                if (RScore == 4)
                    g_AT5RMark5[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[AT5MarkCounting]];

                if (RScore == 5)
                {
                    g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[4]];
                    g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[5]];
                    g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[6]];

                    g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[7]];
                    g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[8]];
                    g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[9]];

                    g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[10]];
                    g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[11]];
                    g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[12]];

                    g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[13]];
                    g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[14]];
                    g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[15]];

                    g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[16]];
                    g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[17]];
                    g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[18]];
                }

                if (RScore == 6)
                {
                    g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[7]];
                    g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[8]];
                    g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[9]];

                    g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[10]];
                    g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[11]];
                    g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[12]];

                    g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[13]];
                    g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[14]];
                    g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[15]];

                    g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[16]];
                    g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[17]];
                    g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[18]];

                    g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[19]];
                    g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[20]];
                    g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[21]];
                }

                if (RScore == 7)
                {
                    g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[10]];
                    g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[11]];
                    g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[12]];

                    g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[13]];
                    g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[14]];
                    g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[15]];

                    g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[16]];
                    g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[17]];
                    g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[18]];

                    g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[19]];
                    g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[20]];
                    g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[21]];

                    g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[22]];
                    g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[23]];
                    g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[24]];
                }

                if (RScore == 8)
                {
                    g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[13]];
                    g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[14]];
                    g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[15]];

                    g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[16]];
                    g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[17]];
                    g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[18]];

                    g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[19]];
                    g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[20]];
                    g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[21]];

                    g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[22]];
                    g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[23]];
                    g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[24]];

                    g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[25]];
                    g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[26]];
                    g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[27]];
                }

                if (RScore == 9)
                {
                    g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[16]];
                    g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[17]];
                    g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[18]];

                    g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[19]];
                    g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[20]];
                    g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[21]];

                    g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[22]];
                    g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[23]];
                    g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[24]];

                    g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[25]];
                    g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[26]];
                    g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[27]];

                    g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[28]];
                    g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[29]];
                    g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[30]];
                }

                if (RScore == 10)
                {
                    g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[19]];
                    g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[20]];
                    g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[21]];

                    g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[22]];
                    g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[23]];
                    g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[24]];

                    g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[25]];
                    g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[26]];
                    g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[27]];

                    g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[28]];
                    g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[29]];
                    g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[30]];

                    g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[31]];
                    g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[32]];
                    g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[33]];
                }

                if (RScore == 11)
                {
                    g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[22]];
                    g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[23]];
                    g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[24]];

                    g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[25]];
                    g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[26]];
                    g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[27]];

                    g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[28]];
                    g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[29]];
                    g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[30]];

                    g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[31]];
                    g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[32]];
                    g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[33]];

                    g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[34]];
                    g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[35]];
                    g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[36]];
                }

                if (RScore == 12)
                {
                    g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[25]];
                    g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[26]];
                    g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[27]];

                    g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[28]];
                    g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[29]];
                    g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[30]];

                    g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[31]];
                    g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[32]];
                    g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[33]];

                    g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[34]];
                    g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[35]];
                    g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[36]];

                    g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[37]];
                    g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[38]];
                    g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[39]];
                }

                if (RScore == 13)
                {
                    g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[28]];
                    g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[29]];
                    g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[30]];

                    g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[31]];
                    g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[32]];
                    g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[33]];

                    g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[34]];
                    g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[35]];
                    g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[36]];

                    g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[37]];
                    g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[38]];
                    g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[39]];

                    g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[40]];
                    g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[41]];
                    g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[42]];
                }

                if (RScore == 14)
                {
                    g_AT5RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[31]];
                    g_AT5RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[32]];
                    g_AT5RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[33]];

                    g_AT5RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[34]];
                    g_AT5RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[35]];
                    g_AT5RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[36]];

                    g_AT5RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[37]];
                    g_AT5RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[38]];
                    g_AT5RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[39]];

                    g_AT5RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[40]];
                    g_AT5RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[41]];
                    g_AT5RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[42]];

                    g_AT5RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[43]];
                    g_AT5RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[44]];
                    g_AT5RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT5[45]];
                }
            }
        }

        else if (isAT && !isBT && Players == 5)
        {
            MarkSaveAT6[AT6MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_AT6RMark1[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[AT6MarkCounting]];

                if (RScore == 1)
                    g_AT6RMark2[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[AT6MarkCounting]];

                if (RScore == 2)
                    g_AT6RMark3[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[AT6MarkCounting]];

                if (RScore == 3)
                    g_AT6RMark4[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[AT6MarkCounting]];

                if (RScore == 4)
                    g_AT6RMark5[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[AT6MarkCounting]];

                if (RScore == 5)
                {
                    g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[4]];
                    g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[5]];
                    g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[6]];

                    g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[7]];
                    g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[8]];
                    g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[9]];

                    g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[10]];
                    g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[11]];
                    g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[12]];

                    g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[13]];
                    g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[14]];
                    g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[15]];

                    g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[16]];
                    g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[17]];
                    g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[18]];
                }

                if (RScore == 6)
                {
                    g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[7]];
                    g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[8]];
                    g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[9]];

                    g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[10]];
                    g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[11]];
                    g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[12]];

                    g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[13]];
                    g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[14]];
                    g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[15]];

                    g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[16]];
                    g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[17]];
                    g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[18]];

                    g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[19]];
                    g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[20]];
                    g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[21]];
                }

                if (RScore == 7)
                {
                    g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[10]];
                    g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[11]];
                    g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[12]];

                    g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[13]];
                    g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[14]];
                    g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[15]];

                    g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[16]];
                    g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[17]];
                    g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[18]];

                    g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[19]];
                    g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[20]];
                    g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[21]];

                    g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[22]];
                    g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[23]];
                    g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[24]];
                }

                if (RScore == 8)
                {
                    g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[13]];
                    g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[14]];
                    g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[15]];

                    g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[16]];
                    g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[17]];
                    g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[18]];

                    g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[19]];
                    g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[20]];
                    g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[21]];

                    g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[22]];
                    g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[23]];
                    g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[24]];

                    g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[25]];
                    g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[26]];
                    g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[27]];
                }

                if (RScore == 9)
                {
                    g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[16]];
                    g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[17]];
                    g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[18]];

                    g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[19]];
                    g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[20]];
                    g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[21]];

                    g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[22]];
                    g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[23]];
                    g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[24]];

                    g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[25]];
                    g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[26]];
                    g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[27]];

                    g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[28]];
                    g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[29]];
                    g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[30]];
                }

                if (RScore == 10)
                {
                    g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[19]];
                    g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[20]];
                    g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[21]];

                    g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[22]];
                    g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[23]];
                    g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[24]];

                    g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[25]];
                    g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[26]];
                    g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[27]];

                    g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[28]];
                    g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[29]];
                    g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[30]];

                    g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[31]];
                    g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[32]];
                    g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[33]];
                }

                if (RScore == 11)
                {
                    g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[22]];
                    g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[23]];
                    g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[24]];

                    g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[25]];
                    g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[26]];
                    g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[27]];

                    g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[28]];
                    g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[29]];
                    g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[30]];

                    g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[31]];
                    g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[32]];
                    g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[33]];

                    g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[34]];
                    g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[35]];
                    g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[36]];
                }

                if (RScore == 12)
                {
                    g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[25]];
                    g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[26]];
                    g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[27]];

                    g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[28]];
                    g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[29]];
                    g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[30]];

                    g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[31]];
                    g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[32]];
                    g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[33]];

                    g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[34]];
                    g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[35]];
                    g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[36]];

                    g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[37]];
                    g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[38]];
                    g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[39]];
                }

                if (RScore == 13)
                {
                    g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[28]];
                    g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[29]];
                    g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[30]];

                    g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[31]];
                    g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[32]];
                    g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[33]];

                    g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[34]];
                    g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[35]];
                    g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[36]];

                    g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[37]];
                    g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[38]];
                    g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[39]];

                    g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[40]];
                    g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[41]];
                    g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[42]];
                }

                if (RScore == 14)
                {
                    g_AT6RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[31]];
                    g_AT6RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[32]];
                    g_AT6RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[33]];

                    g_AT6RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[34]];
                    g_AT6RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[35]];
                    g_AT6RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[36]];

                    g_AT6RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[37]];
                    g_AT6RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[38]];
                    g_AT6RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[39]];

                    g_AT6RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[40]];
                    g_AT6RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[41]];
                    g_AT6RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[42]];

                    g_AT6RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[43]];
                    g_AT6RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[44]];
                    g_AT6RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT6[45]];
                }
            }
        }

        else if (isBT && !isAT && Players == 0)
        {
            MarkSaveBT1[BT1MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_BT1RMark1[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[BT1MarkCounting]];

                if (RScore == 1)
                    g_BT1RMark2[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[BT1MarkCounting]];

                if (RScore == 2)
                    g_BT1RMark3[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[BT1MarkCounting]];

                if (RScore == 3)
                    g_BT1RMark4[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[BT1MarkCounting]];

                if (RScore == 4)
                    g_BT1RMark5[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[BT1MarkCounting]];

                if (RScore == 5)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[4]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[5]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[6]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[7]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[8]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[9]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                }

                if (RScore == 6)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[7]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[8]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[9]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                }

                if (RScore == 7)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                }

                if (RScore == 8)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];

                }
                if (RScore == 9)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                }

                if (RScore == 10)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];
                }

                if (RScore == 11)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];
                }

                if (RScore == 12)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[39]];
                }

                if (RScore == 13)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[39]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[40]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[41]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[42]];
                }
                if (RScore == 14)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[39]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[40]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[41]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[42]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[43]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[44]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[45]];
                }
            }
        }

        else if (isBT && !isAT && Players == 1)
        {
            MarkSaveBT2[BT2MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_BT2RMark1[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[BT2MarkCounting]];

                if (RScore == 1)
                    g_BT2RMark2[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[BT2MarkCounting]];

                if (RScore == 2)
                    g_BT2RMark3[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[BT2MarkCounting]];

                if (RScore == 3)
                    g_BT2RMark4[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[BT2MarkCounting]];

                if (RScore == 4)
                    g_BT2RMark5[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[BT2MarkCounting]];

                if (RScore == 5)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[4]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[5]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[6]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[7]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[8]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[9]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                }

                if (RScore == 6)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[7]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[8]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[9]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                }

                if (RScore == 7)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                }

                if (RScore == 8)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];

                }
                if (RScore == 9)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                }

                if (RScore == 10)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];
                }

                if (RScore == 11)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];
                }

                if (RScore == 12)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[39]];
                }

                if (RScore == 13)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[39]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[40]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[41]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[42]];
                }
                if (RScore == 14)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[39]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[40]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[41]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[42]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[43]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[44]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[45]];
                }
            }
        }

        else if (isBT && !isAT && Players == 2)
        {
            MarkSaveBT3[BT3MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_BT3RMark1[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[BT3MarkCounting]];

                if (RScore == 1)
                    g_BT3RMark2[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[BT3MarkCounting]];

                if (RScore == 2)
                    g_BT3RMark3[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[BT3MarkCounting]];

                if (RScore == 3)
                    g_BT3RMark4[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[BT3MarkCounting]];

                if (RScore == 4)
                    g_BT3RMark5[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[BT3MarkCounting]];

                if (RScore == 5)
                {
                    g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[4]];
                    g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[5]];
                    g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[6]];

                    g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[7]];
                    g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[8]];
                    g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[9]];

                    g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[10]];
                    g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[11]];
                    g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[12]];

                    g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[13]];
                    g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[14]];
                    g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[15]];

                    g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[16]];
                    g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[17]];
                    g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[18]];
                }

                if (RScore == 6)
                {
                    g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[7]];
                    g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[8]];
                    g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[9]];

                    g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[10]];
                    g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[11]];
                    g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[12]];

                    g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[13]];
                    g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[14]];
                    g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[15]];

                    g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[16]];
                    g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[17]];
                    g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[18]];

                    g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[19]];
                    g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[20]];
                    g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[21]];
                }

                if (RScore == 7)
                {
                    g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[10]];
                    g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[11]];
                    g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[12]];

                    g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[13]];
                    g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[14]];
                    g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[15]];

                    g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[16]];
                    g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[17]];
                    g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[18]];

                    g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[19]];
                    g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[20]];
                    g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[21]];

                    g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[22]];
                    g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[23]];
                    g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[24]];
                }

                if (RScore == 8)
                {
                    g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[13]];
                    g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[14]];
                    g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[15]];

                    g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[16]];
                    g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[17]];
                    g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[18]];

                    g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[19]];
                    g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[20]];
                    g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[21]];

                    g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[22]];
                    g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[23]];
                    g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[24]];

                    g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[25]];
                    g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[26]];
                    g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[27]];

                }
                if (RScore == 9)
                {
                    g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[16]];
                    g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[17]];
                    g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[18]];

                    g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[19]];
                    g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[20]];
                    g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[21]];

                    g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[22]];
                    g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[23]];
                    g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[24]];

                    g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[25]];
                    g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[26]];
                    g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[27]];

                    g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[28]];
                    g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[29]];
                    g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[30]];
                }

                if (RScore == 10)
                {
                    g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[19]];
                    g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[20]];
                    g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[21]];

                    g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[22]];
                    g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[23]];
                    g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[24]];

                    g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[25]];
                    g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[26]];
                    g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[27]];

                    g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[28]];
                    g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[29]];
                    g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[30]];

                    g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[31]];
                    g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[32]];
                    g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[33]];
                }

                if (RScore == 11)
                {
                    g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[22]];
                    g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[23]];
                    g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[24]];

                    g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[25]];
                    g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[26]];
                    g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[27]];

                    g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[28]];
                    g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[29]];
                    g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[30]];

                    g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[31]];
                    g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[32]];
                    g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[33]];

                    g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[34]];
                    g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[35]];
                    g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[36]];
                }

                if (RScore == 12)
                {
                    g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[25]];
                    g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[26]];
                    g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[27]];

                    g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[28]];
                    g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[29]];
                    g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[30]];

                    g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[31]];
                    g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[32]];
                    g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[33]];

                    g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[34]];
                    g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[35]];
                    g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[36]];

                    g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[37]];
                    g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[38]];
                    g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[39]];
                }

                if (RScore == 13)
                {
                    g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[28]];
                    g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[29]];
                    g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[30]];

                    g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[31]];
                    g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[32]];
                    g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[33]];

                    g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[34]];
                    g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[35]];
                    g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[36]];

                    g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[37]];
                    g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[38]];
                    g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[39]];

                    g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[40]];
                    g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[41]];
                    g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[42]];
                }
                if (RScore == 14)
                {
                    g_BT3RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[31]];
                    g_BT3RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[32]];
                    g_BT3RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[33]];

                    g_BT3RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[34]];
                    g_BT3RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[35]];
                    g_BT3RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[36]];

                    g_BT3RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[37]];
                    g_BT3RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[38]];
                    g_BT3RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[39]];

                    g_BT3RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[40]];
                    g_BT3RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[41]];
                    g_BT3RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[42]];

                    g_BT3RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[43]];
                    g_BT3RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[44]];
                    g_BT3RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[45]];
                }
            }
        }

        else if (isBT && !isAT && Players == 3)
        {
            MarkSaveBT4[BT4MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_BT4RMark1[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[BT4MarkCounting]];

                if (RScore == 1)
                    g_BT4RMark2[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[BT4MarkCounting]];

                if (RScore == 2)
                    g_BT4RMark3[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[BT4MarkCounting]];

                if (RScore == 3)
                    g_BT4RMark4[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[BT4MarkCounting]];

                if (RScore == 4)
                    g_BT4RMark5[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[BT4MarkCounting]];

                if (RScore == 5)
                {
                    g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[4]];
                    g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[5]];
                    g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[6]];

                    g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[7]];
                    g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[8]];
                    g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[9]];

                    g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[10]];
                    g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[11]];
                    g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[12]];

                    g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[13]];
                    g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[14]];
                    g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[15]];

                    g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[16]];
                    g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[17]];
                    g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[18]];
                }

                if (RScore == 6)
                {
                    g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[7]];
                    g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[8]];
                    g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[9]];

                    g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[10]];
                    g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[11]];
                    g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[12]];

                    g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[13]];
                    g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[14]];
                    g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[15]];

                    g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[16]];
                    g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[17]];
                    g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[18]];

                    g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[19]];
                    g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[20]];
                    g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[21]];
                }

                if (RScore == 7)
                {
                    g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[10]];
                    g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[11]];
                    g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[12]];

                    g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[13]];
                    g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[14]];
                    g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[15]];

                    g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[16]];
                    g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[17]];
                    g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[18]];

                    g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[19]];
                    g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[20]];
                    g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[21]];

                    g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[22]];
                    g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[23]];
                    g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[24]];
                }

                if (RScore == 8)
                {
                    g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[13]];
                    g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[14]];
                    g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[15]];

                    g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[16]];
                    g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[17]];
                    g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[18]];

                    g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[19]];
                    g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[20]];
                    g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[21]];

                    g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[22]];
                    g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[23]];
                    g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[24]];

                    g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[25]];
                    g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[26]];
                    g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[27]];

                }
                if (RScore == 9)
                {
                    g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[16]];
                    g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[17]];
                    g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[18]];

                    g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[19]];
                    g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[20]];
                    g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[21]];

                    g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[22]];
                    g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[23]];
                    g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[24]];

                    g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[25]];
                    g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[26]];
                    g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[27]];

                    g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[28]];
                    g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[29]];
                    g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[30]];
                }

                if (RScore == 10)
                {
                    g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[19]];
                    g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[20]];
                    g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[21]];

                    g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[22]];
                    g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[23]];
                    g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[24]];

                    g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[25]];
                    g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[26]];
                    g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[27]];

                    g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[28]];
                    g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[29]];
                    g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[30]];

                    g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[31]];
                    g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[32]];
                    g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[33]];
                }

                if (RScore == 11)
                {
                    g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[22]];
                    g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[23]];
                    g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[24]];

                    g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[25]];
                    g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[26]];
                    g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[27]];

                    g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[28]];
                    g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[29]];
                    g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[30]];

                    g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[31]];
                    g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[32]];
                    g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[33]];

                    g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[34]];
                    g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[35]];
                    g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[36]];
                }

                if (RScore == 12)
                {
                    g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[25]];
                    g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[26]];
                    g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[27]];

                    g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[28]];
                    g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[29]];
                    g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[30]];

                    g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[31]];
                    g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[32]];
                    g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[33]];

                    g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[34]];
                    g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[35]];
                    g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[36]];

                    g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[37]];
                    g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[38]];
                    g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[39]];
                }

                if (RScore == 13)
                {
                    g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[28]];
                    g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[29]];
                    g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[30]];

                    g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[31]];
                    g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[32]];
                    g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[33]];

                    g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[34]];
                    g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[35]];
                    g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[36]];

                    g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[37]];
                    g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[38]];
                    g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[39]];

                    g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[40]];
                    g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[41]];
                    g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[42]];
                }
                if (RScore == 14)
                {
                    g_BT4RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[31]];
                    g_BT4RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[32]];
                    g_BT4RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[33]];

                    g_BT4RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[34]];
                    g_BT4RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[35]];
                    g_BT4RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[36]];

                    g_BT4RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[37]];
                    g_BT4RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[38]];
                    g_BT4RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[39]];

                    g_BT4RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[40]];
                    g_BT4RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[41]];
                    g_BT4RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[42]];

                    g_BT4RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[43]];
                    g_BT4RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT4[44]];
                    g_BT4RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT3[45]];
                }
            }
        }

        else if (isBT && !isAT && Players == 4)
        {
            MarkSaveBT5[BT5MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_BT5RMark1[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[BT5MarkCounting]];

                if (RScore == 1)
                    g_BT5RMark2[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[BT5MarkCounting]];

                if (RScore == 2)
                    g_BT5RMark3[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[BT5MarkCounting]];

                if (RScore == 3)
                    g_BT5RMark4[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[BT5MarkCounting]];

                if (RScore == 4)
                    g_BT5RMark5[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[BT5MarkCounting]];

                if (RScore == 5)
                {
                    g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[4]];
                    g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[5]];
                    g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[6]];

                    g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[7]];
                    g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[8]];
                    g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[9]];

                    g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[10]];
                    g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[11]];
                    g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[12]];

                    g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[13]];
                    g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[14]];
                    g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[15]];

                    g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[16]];
                    g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[17]];
                    g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[18]];
                }

                if (RScore == 6)
                {
                    g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[7]];
                    g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[8]];
                    g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[9]];

                    g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[10]];
                    g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[11]];
                    g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[12]];

                    g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[13]];
                    g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[14]];
                    g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[15]];

                    g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[16]];
                    g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[17]];
                    g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[18]];

                    g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[19]];
                    g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[20]];
                    g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[21]];
                }

                if (RScore == 7)
                {
                    g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[10]];
                    g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[11]];
                    g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[12]];

                    g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[13]];
                    g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[14]];
                    g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[15]];

                    g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[16]];
                    g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[17]];
                    g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[18]];

                    g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[19]];
                    g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[20]];
                    g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[21]];

                    g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[22]];
                    g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[23]];
                    g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[24]];
                }

                if (RScore == 8)
                {
                    g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[13]];
                    g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[14]];
                    g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[15]];

                    g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[16]];
                    g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[17]];
                    g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[18]];

                    g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[19]];
                    g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[20]];
                    g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[21]];

                    g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[22]];
                    g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[23]];
                    g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[24]];

                    g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[25]];
                    g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[26]];
                    g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[27]];

                }
                if (RScore == 9)
                {
                    g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[16]];
                    g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[17]];
                    g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[18]];

                    g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[19]];
                    g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[20]];
                    g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[21]];

                    g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[22]];
                    g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[23]];
                    g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[24]];

                    g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[25]];
                    g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[26]];
                    g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[27]];

                    g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[28]];
                    g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[29]];
                    g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[30]];
                }

                if (RScore == 10)
                {
                    g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[19]];
                    g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[20]];
                    g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[21]];

                    g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[22]];
                    g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[23]];
                    g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[24]];

                    g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[25]];
                    g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[26]];
                    g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[27]];

                    g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[28]];
                    g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[29]];
                    g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[30]];

                    g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[31]];
                    g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[32]];
                    g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[33]];
                }

                if (RScore == 11)
                {
                    g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[22]];
                    g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[23]];
                    g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[24]];

                    g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[25]];
                    g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[26]];
                    g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[27]];

                    g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[28]];
                    g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[29]];
                    g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[30]];

                    g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[31]];
                    g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[32]];
                    g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[33]];

                    g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[34]];
                    g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[35]];
                    g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[36]];
                }

                if (RScore == 12)
                {
                    g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[25]];
                    g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[26]];
                    g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[27]];

                    g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[28]];
                    g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[29]];
                    g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[30]];

                    g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[31]];
                    g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[32]];
                    g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[33]];

                    g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[34]];
                    g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[35]];
                    g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[36]];

                    g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[37]];
                    g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[38]];
                    g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[39]];
                }

                if (RScore == 13)
                {
                    g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[28]];
                    g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[29]];
                    g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[30]];

                    g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[31]];
                    g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[32]];
                    g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[33]];

                    g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[34]];
                    g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[35]];
                    g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[36]];

                    g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[37]];
                    g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[38]];
                    g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[39]];

                    g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[40]];
                    g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[41]];
                    g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[42]];
                }
                if (RScore == 14)
                {
                    g_BT5RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[31]];
                    g_BT5RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[32]];
                    g_BT5RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[33]];

                    g_BT5RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[34]];
                    g_BT5RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[35]];
                    g_BT5RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[36]];

                    g_BT5RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[37]];
                    g_BT5RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[38]];
                    g_BT5RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[39]];

                    g_BT5RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[40]];
                    g_BT5RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[41]];
                    g_BT5RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[42]];

                    g_BT5RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[43]];
                    g_BT5RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[44]];
                    g_BT5RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT5[45]];
                }
            }
        }

        else if (isBT && !isAT && Players == 5)
        {
            MarkSaveBT6[BT6MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_BT6RMark1[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[BT6MarkCounting]];

                if (RScore == 1)
                    g_BT6RMark2[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[BT6MarkCounting]];

                if (RScore == 2)
                    g_BT6RMark3[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[BT6MarkCounting]];

                if (RScore == 3)
                    g_BT6RMark4[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[BT6MarkCounting]];

                if (RScore == 4)
                    g_BT6RMark5[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[BT6MarkCounting]];

                if (RScore == 5)
                {
                    g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[4]];
                    g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[5]];
                    g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[6]];

                    g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[7]];
                    g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[8]];
                    g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[9]];

                    g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[10]];
                    g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[11]];
                    g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[12]];

                    g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[13]];
                    g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[14]];
                    g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[15]];

                    g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[16]];
                    g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[17]];
                    g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[18]];
                }

                if (RScore == 6)
                {
                    g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[7]];
                    g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[8]];
                    g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[9]];

                    g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[10]];
                    g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[11]];
                    g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[12]];

                    g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[13]];
                    g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[14]];
                    g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[15]];

                    g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[16]];
                    g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[17]];
                    g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[18]];

                    g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[19]];
                    g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[20]];
                    g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[21]];
                }

                if (RScore == 7)
                {
                    g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[10]];
                    g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[11]];
                    g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[12]];

                    g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[13]];
                    g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[14]];
                    g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[15]];

                    g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[16]];
                    g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[17]];
                    g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[18]];

                    g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[19]];
                    g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[20]];
                    g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[21]];

                    g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[22]];
                    g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[23]];
                    g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[24]];
                }

                if (RScore == 8)
                {
                    g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[13]];
                    g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[14]];
                    g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[15]];

                    g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[16]];
                    g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[17]];
                    g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[18]];

                    g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[19]];
                    g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[20]];
                    g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[21]];

                    g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[22]];
                    g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[23]];
                    g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[24]];

                    g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[25]];
                    g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[26]];
                    g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[27]];

                }
                if (RScore == 9)
                {
                    g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[16]];
                    g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[17]];
                    g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[18]];

                    g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[19]];
                    g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[20]];
                    g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[21]];

                    g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[22]];
                    g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[23]];
                    g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[24]];

                    g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[25]];
                    g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[26]];
                    g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[27]];

                    g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[28]];
                    g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[29]];
                    g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[30]];
                }

                if (RScore == 10)
                {
                    g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[19]];
                    g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[20]];
                    g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[21]];

                    g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[22]];
                    g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[23]];
                    g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[24]];

                    g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[25]];
                    g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[26]];
                    g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[27]];

                    g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[28]];
                    g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[29]];
                    g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[30]];

                    g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[31]];
                    g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[32]];
                    g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[33]];
                }

                if (RScore == 11)
                {
                    g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[22]];
                    g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[23]];
                    g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[24]];

                    g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[25]];
                    g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[26]];
                    g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[27]];

                    g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[28]];
                    g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[29]];
                    g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[30]];

                    g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[31]];
                    g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[32]];
                    g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[33]];

                    g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[34]];
                    g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[35]];
                    g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[36]];
                }

                if (RScore == 12)
                {
                    g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[25]];
                    g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[26]];
                    g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[27]];

                    g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[28]];
                    g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[29]];
                    g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[30]];

                    g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[31]];
                    g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[32]];
                    g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[33]];

                    g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[34]];
                    g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[35]];
                    g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[36]];

                    g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[37]];
                    g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[38]];
                    g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[39]];
                }

                if (RScore == 13)
                {
                    g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[28]];
                    g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[29]];
                    g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[30]];

                    g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[31]];
                    g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[32]];
                    g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[33]];

                    g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[34]];
                    g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[35]];
                    g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[36]];

                    g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[37]];
                    g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[38]];
                    g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[39]];

                    g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[40]];
                    g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[41]];
                    g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[42]];
                }
                if (RScore == 14)
                {
                    g_BT6RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[31]];
                    g_BT6RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[32]];
                    g_BT6RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[33]];

                    g_BT6RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[34]];
                    g_BT6RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[35]];
                    g_BT6RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[36]];

                    g_BT6RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[37]];
                    g_BT6RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[38]];
                    g_BT6RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[39]];

                    g_BT6RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[40]];
                    g_BT6RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[41]];
                    g_BT6RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[42]];

                    g_BT6RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[43]];
                    g_BT6RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[44]];
                    g_BT6RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT6[45]];
                }
            }
        }
    }

    void MainMark()
    {
        if (isAT && !isAT_20Line && AT_20LMark == _20Line * 2)
            g_ATMainMark[0].GetComponent<Image>().sprite = s_ATMark[1];
        else if (isAT && !isAT_20Line && AT_20LMark == _20Line)
            g_ATMainMark[0].GetComponent<Image>().sprite = s_ATMark[2];
        else if (isAT && !isAT_20Line && AT_20LMark <= 0)
        {
            isAT_20Line = true;
            g_ATMainMark[0].GetComponent<Image>().sprite = s_ATMark[3];
        }

        if (isAT && !isAT_19Line && AT_19LMark == _19Line * 2)
            g_ATMainMark[1].GetComponent<Image>().sprite = s_ATMark[1];
        else if (isAT && !isAT_19Line && AT_19LMark == _19Line)
            g_ATMainMark[1].GetComponent<Image>().sprite = s_ATMark[2];
        else if (isAT && !isAT_19Line && AT_19LMark <= 0)
        {
            isAT_19Line = true;
            g_ATMainMark[1].GetComponent<Image>().sprite = s_ATMark[3];
        }

        if (isAT && !isAT_18Line && AT_18LMark == _18Line * 2)
            g_ATMainMark[2].GetComponent<Image>().sprite = s_ATMark[1];
        else if (isAT && !isAT_18Line && AT_18LMark == _18Line)
            g_ATMainMark[2].GetComponent<Image>().sprite = s_ATMark[2];
        else if (isAT && !isAT_18Line && AT_18LMark <= 0)
        {
            isAT_18Line = true;
            g_ATMainMark[2].GetComponent<Image>().sprite = s_ATMark[3];
        }

        if (isAT && !isAT_17Line && AT_17LMark == _17Line * 2)
            g_ATMainMark[3].GetComponent<Image>().sprite = s_ATMark[1];
        else if (isAT && !isAT_17Line && AT_17LMark == _17Line)
            g_ATMainMark[3].GetComponent<Image>().sprite = s_ATMark[2];
        else if (isAT && !isAT_17Line && AT_17LMark <= 0)
        {
            isAT_17Line = true;
            g_ATMainMark[3].GetComponent<Image>().sprite = s_ATMark[3];
        }

        if (isAT && !isAT_16Line && AT_16LMark == _16Line * 2)
            g_ATMainMark[4].GetComponent<Image>().sprite = s_ATMark[1];
        else if (isAT && !isAT_16Line && AT_16LMark == _16Line)
            g_ATMainMark[4].GetComponent<Image>().sprite = s_ATMark[2];
        else if (isAT && !isAT_16Line && AT_16LMark <= 0)
        {
            isAT_16Line = true;
            g_ATMainMark[4].GetComponent<Image>().sprite = s_ATMark[3];
        }

        if (isAT && !isAT_15Line && AT_15LMark == _15Line * 2)
            g_ATMainMark[5].GetComponent<Image>().sprite = s_ATMark[1];
        else if (isAT && !isAT_15Line && AT_15LMark == _15Line)
            g_ATMainMark[5].GetComponent<Image>().sprite = s_ATMark[2];
        else if (isAT && !isAT_15Line && AT_15LMark <= 0)
        {
            isAT_15Line = true;
            g_ATMainMark[5].GetComponent<Image>().sprite = s_ATMark[3];
        }

        if (isAT && !isAT_BullLine && AT_BullLMark == _BullLine * 2)
            g_ATMainMark[6].GetComponent<Image>().sprite = s_ATMark[1];
        else if (isAT && !isAT_BullLine && AT_BullLMark == _BullLine)
            g_ATMainMark[6].GetComponent<Image>().sprite = s_ATMark[2];
        else if (isAT && !isAT_BullLine && AT_BullLMark <= 0)
        {
            isAT_BullLine = true;
            g_ATMainMark[6].GetComponent<Image>().sprite = s_ATMark[3];
        }
        /*-------------------------------------------------------------*/
        if (isBT && !isBT_20Line && BT_20LMark == _20Line * 2)
            g_BTMainMark[0].GetComponent<Image>().sprite = s_BTMark[1];
        else if (isBT && !isBT_20Line && BT_20LMark == _20Line)
            g_BTMainMark[0].GetComponent<Image>().sprite = s_BTMark[2];
        else if (isBT && !isBT_20Line && BT_20LMark <= 0)
        {
            isBT_20Line = true;
            g_BTMainMark[0].GetComponent<Image>().sprite = s_BTMark[3];
        }

        if (isBT && !isBT_19Line && BT_19LMark == _19Line * 2)
            g_BTMainMark[1].GetComponent<Image>().sprite = s_BTMark[1];
        else if (isBT && !isBT_19Line && BT_19LMark == _19Line)
            g_BTMainMark[1].GetComponent<Image>().sprite = s_BTMark[2];
        else if (isBT && !isBT_19Line && BT_19LMark <= 0)
        {
            isBT_19Line = true;
            g_BTMainMark[1].GetComponent<Image>().sprite = s_BTMark[3];
        }

        if (isBT && !isBT_18Line && BT_18LMark == _18Line * 2)
            g_BTMainMark[2].GetComponent<Image>().sprite = s_BTMark[1];
        else if (isBT && !isBT_18Line && BT_18LMark == _18Line)
            g_BTMainMark[2].GetComponent<Image>().sprite = s_BTMark[2];
        else if (isBT && !isBT_18Line && BT_18LMark <= 0)
        {
            isBT_18Line = true;
            g_BTMainMark[2].GetComponent<Image>().sprite = s_BTMark[3];
        }

        if (isBT && !isBT_17Line && BT_17LMark == _17Line * 2)
            g_BTMainMark[3].GetComponent<Image>().sprite = s_BTMark[1];
        else if (isBT && !isBT_17Line && BT_17LMark == _17Line)
            g_BTMainMark[3].GetComponent<Image>().sprite = s_BTMark[2];
        else if (isBT && !isBT_17Line && BT_17LMark <= 0)
        {
            isBT_17Line = true;
            g_BTMainMark[3].GetComponent<Image>().sprite = s_BTMark[3];
        }

        if (isBT && !isBT_16Line && BT_16LMark == _16Line * 2)
            g_BTMainMark[4].GetComponent<Image>().sprite = s_BTMark[1];
        else if (isBT && !isBT_16Line && BT_16LMark == _16Line)
            g_BTMainMark[4].GetComponent<Image>().sprite = s_BTMark[2];
        else if (isBT && !isBT_16Line && BT_16LMark <= 0)
        {
            isBT_16Line = true;
            g_BTMainMark[4].GetComponent<Image>().sprite = s_BTMark[3];
        }

        if (isBT && !isBT_15Line && BT_15LMark == _15Line * 2)
            g_BTMainMark[5].GetComponent<Image>().sprite = s_BTMark[1];
        else if (isBT && !isBT_15Line && BT_15LMark == _15Line)
            g_BTMainMark[5].GetComponent<Image>().sprite = s_BTMark[2];
        else if (isBT && !isBT_15Line && BT_15LMark <= 0)
        {
            isBT_15Line = true;
            g_BTMainMark[5].GetComponent<Image>().sprite = s_BTMark[3];
        }

        if (isBT && !isBT_BullLine && BT_BullLMark == _BullLine * 2)
            g_BTMainMark[6].GetComponent<Image>().sprite = s_BTMark[1];
        else if (isBT && !isBT_BullLine && BT_BullLMark == _BullLine)
            g_BTMainMark[6].GetComponent<Image>().sprite = s_BTMark[2];
        else if (isBT && !isBT_BullLine && BT_BullLMark <= 0)
        {
            isBT_BullLine = true;
            g_BTMainMark[6].GetComponent<Image>().sprite = s_BTMark[3];
        }
        /*--------------------------------------------------------------*/
        if (isAT_20Line && isBT_20Line)
        {
            g_Fishbar[0].SetActive(true);
            g_ATMainMark[0].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[0].GetComponent<Image>().sprite = s_OffMark;
            is20AllLine = true;
        }
        if (isAT_19Line && isBT_19Line)
        {
            g_Fishbar[1].SetActive(true);
            g_ATMainMark[1].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[1].GetComponent<Image>().sprite = s_OffMark;
            is19AllLine = true;
        }
        if (isAT_18Line && isBT_18Line)
        {
            g_Fishbar[2].SetActive(true);
            g_ATMainMark[2].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[2].GetComponent<Image>().sprite = s_OffMark;
            is18AllLine = true;
        }
        if (isAT_17Line && isBT_17Line)
        {
            g_Fishbar[3].SetActive(true);
            g_ATMainMark[3].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[3].GetComponent<Image>().sprite = s_OffMark;
            is17AllLine = true;
        }
        if (isAT_16Line && isBT_16Line)
        {
            g_Fishbar[4].SetActive(true);
            g_ATMainMark[4].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[4].GetComponent<Image>().sprite = s_OffMark;
            is16AllLine = true;
        }
        if (isAT_15Line && isBT_15Line)
        {
            g_Fishbar[5].SetActive(true);
            g_ATMainMark[5].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[5].GetComponent<Image>().sprite = s_OffMark;
            is15AllLine = true;
        }
        if (isAT_BullLine && isBT_BullLine)
        {
            g_Fishbar[6].SetActive(true);
            g_ATMainMark[6].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[6].GetComponent<Image>().sprite = s_OffMark;
            isBullAllLine = true;
        }

        if (isAT_20Line && isAT_19Line && isAT_18Line && isAT_17Line && isAT_16Line && isAT_15Line && isAT_BullLine)
            isATAllLine = true;

        if (isBT_20Line && isBT_19Line && isBT_18Line && isBT_17Line && isBT_16Line && isBT_15Line && isBT_BullLine)
            isBTAllLine = true;
    }

    void LineScore()
    {
        if (Counting != 3 && gmg.isAni == false)
        {
            /*-----------------------------------------------------------------*/
            if (Teams == 0 && !isAT_20Line && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                else if (Players == 2)
                    AT3MarkCounting++;
                else if (Players == 3)
                    AT4MarkCounting++;
                else if (Players == 4)
                    AT5MarkCounting++;
                else if (Players == 5)
                    AT6MarkCounting++;
                AT_20LMark -= csSingleton.getInstance.g_nTargetScore;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 0 && !isAT_19Line && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                else if (Players == 2)
                    AT3MarkCounting++;
                else if (Players == 3)
                    AT4MarkCounting++;
                else if (Players == 4)
                    AT5MarkCounting++;
                else if (Players == 5)
                    AT6MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_19LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 0 && !isAT_18Line && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                else if (Players == 2)
                    AT3MarkCounting++;
                else if (Players == 3)
                    AT4MarkCounting++;
                else if (Players == 4)
                    AT5MarkCounting++;
                else if (Players == 5)
                    AT6MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_18LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 0 && !isAT_17Line && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
            {
                 if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                else if (Players == 2)
                    AT3MarkCounting++;
                else if (Players == 3)
                    AT4MarkCounting++;
                else if (Players == 4)
                    AT5MarkCounting++;
                else if (Players == 5)
                    AT6MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_17LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 0 && !isAT_16Line && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                else if (Players == 2)
                    AT3MarkCounting++;
                else if (Players == 3)
                    AT4MarkCounting++;
                else if (Players == 4)
                    AT5MarkCounting++;
                else if (Players == 5)
                    AT6MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_16LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 0 && !isAT_15Line && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                else if (Players == 2)
                    AT3MarkCounting++;
                else if (Players == 3)
                    AT4MarkCounting++;
                else if (Players == 4)
                    AT5MarkCounting++;
                else if (Players == 5)
                    AT6MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_15LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 0 && !isAT_BullLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                else if (Players == 2)
                    AT3MarkCounting++;
                else if (Players == 3)
                    AT4MarkCounting++;
                else if (Players == 4)
                    AT5MarkCounting++;
                else if (Players == 5)
                    AT6MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_BullLMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            /*-----------------------------------------------------------------*/
            if (Teams == 1 && !isBT_20Line && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                else if (Players == 2)
                    BT3MarkCounting++;
                else if (Players == 3)
                    BT4MarkCounting++;
                else if (Players == 4)
                    BT5MarkCounting++;
                else if (Players == 5)
                    BT6MarkCounting++;

                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_20LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 1 && !isBT_19Line && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                else if (Players == 2)
                    BT3MarkCounting++;
                else if (Players == 3)
                    BT4MarkCounting++;
                else if (Players == 4)
                    BT5MarkCounting++;
                else if (Players == 5)
                    BT6MarkCounting++;

                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_19LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 1 && !isBT_18Line && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                else if (Players == 2)
                    BT3MarkCounting++;
                else if (Players == 3)
                    BT4MarkCounting++;
                else if (Players == 4)
                    BT5MarkCounting++;
                else if (Players == 5)
                    BT6MarkCounting++;

                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_18LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 1 && !isBT_17Line && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                else if (Players == 2)
                    BT3MarkCounting++;
                else if (Players == 3)
                    BT4MarkCounting++;
                else if (Players == 4)
                    BT5MarkCounting++;
                else if (Players == 5)
                    BT6MarkCounting++;

                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_17LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 1 && !isBT_16Line && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                else if (Players == 2)
                    BT3MarkCounting++;
                else if (Players == 3)
                    BT4MarkCounting++;
                else if (Players == 4)
                    BT5MarkCounting++;
                else if (Players == 5)
                    BT6MarkCounting++;

                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_16LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 1 && !isBT_15Line && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                else if (Players == 2)
                    BT3MarkCounting++;
                else if (Players == 3)
                    BT4MarkCounting++;
                else if (Players == 4)
                    BT5MarkCounting++;
                else if (Players == 5)
                    BT6MarkCounting++;

                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_15LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else if (Teams == 1 && !isBT_BullLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                else if (Players == 2)
                    BT3MarkCounting++;
                else if (Players == 3)
                    BT4MarkCounting++;
                else if (Players == 4)
                    BT5MarkCounting++;
                else if (Players == 5)
                    BT6MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_BullLMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;

            }
            else
            {
            }
            /*-----------------------------------------------------------------*/
            if (AT_20LMark <= 0 && !isAT_20Line)
            {
                if (!isBT_20Line)
                {
                    AT_20LMark *= -1;
                    TeamScore[0] += AT_20LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                AT_20LMark = 0;
            }
            else if (AT_19LMark <= 0 && !isAT_19Line)
            {
                if (!isBT_19Line)
                {
                    AT_19LMark *= -1;
                    TeamScore[0] += AT_19LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                AT_19LMark = 0;
            }
            else if (AT_18LMark <= 0 && !isAT_18Line)
            {
                if (!isBT_18Line)
                {
                    AT_18LMark *= -1;
                    TeamScore[0] += AT_18LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                AT_18LMark = 0;
            }
            else if (AT_17LMark <= 0 && !isAT_17Line)
            {
                if (!isBT_17Line)
                {
                    AT_17LMark *= -1;
                    TeamScore[0] += AT_17LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                AT_17LMark = 0;
            }
            else if (AT_16LMark <= 0 && !isAT_16Line)
            {
                if (!isBT_16Line)
                {
                    AT_16LMark *= -1;
                    TeamScore[0] += AT_16LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                AT_16LMark = 0;
            }
            else if (AT_15LMark <= 0 && !isAT_15Line)
            {
                if (!isBT_15Line)
                {
                    AT_15LMark *= -1;
                    TeamScore[0] += AT_15LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                AT_15LMark = 0;
            }
            else if (AT_BullLMark <= 0 && !isAT_BullLine)
            {
                if (!isBT_BullLine)
                {
                    AT_BullLMark *= -1;
                    TeamScore[0] += AT_BullLMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                AT_BullLMark = 0;
            }
            /*-----------------------------------------------------------------*/
            else if (BT_20LMark <= 0 && !isBT_20Line)
            {
                if (!isAT_20Line)
                {
                    BT_20LMark *= -1;
                    TeamScore[1] += BT_20LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                BT_20LMark = 0;
            }
            else if (BT_19LMark <= 0 && !isBT_19Line)
            {
                if (!isAT_20Line)
                {
                    BT_19LMark *= -1;
                    TeamScore[1] += BT_19LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                BT_19LMark = 0;
            }
            else if (BT_18LMark <= 0 && !isBT_18Line)
            {
                if (!isAT_18Line)
                {
                    BT_18LMark *= -1;
                    TeamScore[1] += BT_18LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                BT_18LMark = 0;
            }
            else if (BT_17LMark <= 0 && !isBT_17Line)
            {
                if (!isAT_17Line)
                {
                    BT_17LMark *= -1;
                    TeamScore[1] += BT_17LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                BT_17LMark = 0;
            }
            else if (BT_16LMark <= 0 && !isBT_16Line)
            {
                if (!isAT_16Line)
                {
                    BT_16LMark *= -1;
                    TeamScore[1] += BT_16LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                BT_16LMark = 0;
            }
            else if (BT_15LMark <= 0 && !isBT_15Line)
            {
                if (!isAT_15Line)
                {
                    BT_15LMark *= -1;
                    TeamScore[1] += BT_15LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                BT_15LMark = 0;
            }
            else if (BT_BullLMark <= 0 && !isBT_BullLine)
            {
                if (!isAT_BullLine)
                {
                    BT_BullLMark *= -1;
                    TeamScore[1] += BT_BullLMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                BT_BullLMark = 0;
            }
            else
            {
            }
            /*-----------------------------------------------------------------*/

        }
    }
    void MarkAll()
    {
        if (csSingleton.getInstance.g_nTargetBasicScore == _BullLine && isBullAllLine)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 0 && Players == 2)
                AT3MarkCounting++;
            else if (Teams == 0 && Players == 3)
                AT4MarkCounting++;
            else if (Teams == 0 && Players == 4)
                AT5MarkCounting++;
            else if (Teams == 0 && Players == 5)
                AT6MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 1 && Players == 2)
                BT3MarkCounting++;
            else if (Teams == 1 && Players == 3)
                BT4MarkCounting++;
            else if (Teams == 1 && Players == 4)
                BT5MarkCounting++;
            else if (Teams == 1 && Players == 5)
                BT6MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == _20Line && is20AllLine)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 0 && Players == 2)
                AT3MarkCounting++;
            else if (Teams == 0 && Players == 3)
                AT4MarkCounting++;
            else if (Teams == 0 && Players == 4)
                AT5MarkCounting++;
            else if (Teams == 0 && Players == 5)
                AT6MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 1 && Players == 2)
                BT3MarkCounting++;
            else if (Teams == 1 && Players == 3)
                BT4MarkCounting++;
            else if (Teams == 1 && Players == 4)
                BT5MarkCounting++;
            else if (Teams == 1 && Players == 5)
                BT6MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == _19Line && is19AllLine)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 0 && Players == 2)
                AT3MarkCounting++;
            else if (Teams == 0 && Players == 3)
                AT4MarkCounting++;
            else if (Teams == 0 && Players == 4)
                AT5MarkCounting++;
            else if (Teams == 0 && Players == 5)
                AT6MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 1 && Players == 2)
                BT3MarkCounting++;
            else if (Teams == 1 && Players == 3)
                BT4MarkCounting++;
            else if (Teams == 1 && Players == 4)
                BT5MarkCounting++;
            else if (Teams == 1 && Players == 5)
                BT6MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == _18Line && is18AllLine)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 0 && Players == 2)
                AT3MarkCounting++;
            else if (Teams == 0 && Players == 3)
                AT4MarkCounting++;
            else if (Teams == 0 && Players == 4)
                AT5MarkCounting++;
            else if (Teams == 0 && Players == 5)
                AT6MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 1 && Players == 2)
                BT3MarkCounting++;
            else if (Teams == 1 && Players == 3)
                BT4MarkCounting++;
            else if (Teams == 1 && Players == 4)
                BT5MarkCounting++;
            else if (Teams == 1 && Players == 5)
                BT6MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == _17Line && is17AllLine)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 0 && Players == 2)
                AT3MarkCounting++;
            else if (Teams == 0 && Players == 3)
                AT4MarkCounting++;
            else if (Teams == 0 && Players == 4)
                AT5MarkCounting++;
            else if (Teams == 0 && Players == 5)
                AT6MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 1 && Players == 2)
                BT3MarkCounting++;
            else if (Teams == 1 && Players == 3)
                BT4MarkCounting++;
            else if (Teams == 1 && Players == 4)
                BT5MarkCounting++;
            else if (Teams == 1 && Players == 5)
                BT6MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == _16Line && is16AllLine)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 0 && Players == 2)
                AT3MarkCounting++;
            else if (Teams == 0 && Players == 3)
                AT4MarkCounting++;
            else if (Teams == 0 && Players == 4)
                AT5MarkCounting++;
            else if (Teams == 0 && Players == 5)
                AT6MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 1 && Players == 2)
                BT3MarkCounting++;
            else if (Teams == 1 && Players == 3)
                BT4MarkCounting++;
            else if (Teams == 1 && Players == 4)
                BT5MarkCounting++;
            else if (Teams == 1 && Players == 5)
                BT6MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == _15Line && is15AllLine)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 0 && Players == 2)
                AT3MarkCounting++;
            else if (Teams == 0 && Players == 3)
                AT4MarkCounting++;
            else if (Teams == 0 && Players == 4)
                AT5MarkCounting++;
            else if (Teams == 0 && Players == 5)
                AT6MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 1 && Players == 2)
                BT3MarkCounting++;
            else if (Teams == 1 && Players == 3)
                BT4MarkCounting++;
            else if (Teams == 1 && Players == 4)
                BT5MarkCounting++;
            else if (Teams == 1 && Players == 5)
                BT6MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
    }


    void AniMation()
    {
        if (is20Line)
        {
            A_20Line.SetBool("Hit", true);
            g_20Line[_20Line].SetActive(true);
        }
        if (is19Line)
        {
            A_19Line.SetBool("Hit", true);
            g_19Line[_19Line].SetActive(true);
        }
        if (is18Line)
        {
            A_18Line.SetBool("Hit", true);
            g_18Line[_18Line].SetActive(true);
        }
        if (is17Line)
        {
            A_17Line.SetBool("Hit", true);
            g_17Line[_17Line].SetActive(true);
        }
        if (is16Line)
        {
            A_16Line.SetBool("Hit", true);
            g_16Line[_16Line].SetActive(true);
        }
        if (is15Line)
        {
            A_15Line.SetBool("Hit", true);
            g_15Line[_15Line].SetActive(true);
        }
        if (isBullLine)
        {
            A_BullLine.SetBool("Hit", true);
            g_BullLine[_BullLine].SetActive(true);
        }
    }

    void TeamNumberPlus()
    {
        isAT = false;
        isBT = true;
        isRead = false;
        g_C_Ani.SetActive(false);
        Counting = 0;
        Teams = 1;
    }

    void TeamNumberMinus()
    {
        isAT = true;
        isBT = false;
        isRead = false;
        Counting = 0;
        Teams = 0;
    }

    void PlayerNumberPlus()
    {
        g_C_Ani.SetActive(false);
        Counting = 0;
        Players += 1;
    }

    void PlayerNumberMinus()
    {
        g_C_Ani.SetActive(false);
        Counting = 0;
        Players = 0;
    }

    void FirstStart()
    {
        isAT = true;
        isBT = false;
        for (int i = 0; i < g_Dart.Length; i++)
            g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
        g_ScorePlate.SetActive(false);
        g_R_Ani.SetActive(true);
        g_RoundR.SetActive(true);
        g_RoundNum[Round].SetActive(true);
        g_RoundOn.SetActive(true);
        Invoke("FirstStartAniStop", 1f);
    }

    void FirstStartAniStop()
    {
        g_RoundR.SetActive(false);
        g_RoundOn.SetActive(false);
        g_RoundNum[Round].SetActive(false);
        g_R_Ani.SetActive(false);
        g_ScorePlate.SetActive(true);
        RoundCountingA1 = 1;
        RoundCountingA2 = 1;
        RoundCountingA3 = 1;
        RoundCountingA4 = 1;
        RoundCountingA5 = 1;
        RoundCountingA6 = 1;
        RoundCountingB1 = 1;
        RoundCountingB2 = 1;
        RoundCountingB3 = 1;
        RoundCountingB4 = 1;
        RoundCountingB5 = 1;
        RoundCountingB6 = 1;
        Round = 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
    }

    void MPRScore(int Dart)
    {
        if (Teams == 0 && Players == 0)
        {
            TotalA1 += Dart;
            AverageA1 = TotalA1 / RoundCountingA1;
            t_MPRText1.text = string.Format("{0:N2}", AverageA1);
        }
        if (Teams == 0 && Players == 1)
        {
            TotalA2 += Dart;
            AverageA2 = TotalA2 / RoundCountingA2;
            t_MPRText2.text = string.Format("{0:N2}", AverageA2);
        }
        if (Teams == 0 && Players == 2)
        {
            TotalA3 += Dart;
            AverageA3 = TotalA3 / RoundCountingA3;
            t_MPRText3.text = string.Format("{0:N2}", AverageA3);
        }
        if (Teams == 0 && Players == 3)
        {
            TotalA4 += Dart;
            AverageA4 = TotalA4 / RoundCountingA4;
            t_MPRText4.text = string.Format("{0:N2}", AverageA4);
        }
        if (Teams == 0 && Players == 4)
        {
            TotalA5 += Dart;
            AverageA5 = TotalA5 / RoundCountingA5;
            t_MPRText5.text = string.Format("{0:N2}", AverageA5);
        }
        if (Teams == 0 && Players == 5)
        {
            TotalA6 += Dart;
            AverageA6 = TotalA6 / RoundCountingA6;
            t_MPRText6.text = string.Format("{0:N2}", AverageA6);
        }
        if (Teams == 1 && Players == 0)
        {
            TotalB1 += Dart;
            AverageB1 = TotalB1 / RoundCountingB1;
            t_MPRText7.text = string.Format("{0:N2}", AverageB1);
        }
        if (Teams == 1 && Players == 1)
        {
            TotalB2 += Dart;
            AverageB2 = TotalB2 / RoundCountingB2;
            t_MPRText8.text = string.Format("{0:N2}", AverageB2);
        }
        if (Teams == 1 && Players == 2)
        {
            TotalB3 += Dart;
            AverageB3 = TotalB3 / RoundCountingB3;
            t_MPRText9.text = string.Format("{0:N2}", AverageB3);
        }
        if (Teams == 1 && Players == 3)
        {
            TotalB4 += Dart;
            AverageB4 = TotalB4 / RoundCountingB4;
            t_MPRText10.text = string.Format("{0:N2}", AverageB4);
        }
        if (Teams == 1 && Players == 4)
        {
            TotalB5 += Dart;
            AverageB5 = TotalB5 / RoundCountingB5;
            t_MPRText11.text = string.Format("{0:N2}", AverageB5);
        }
        if (Teams == 1 && Players == 5)
        {
            TotalB6 += Dart;
            AverageB6 = TotalB6 / RoundCountingB6;
            t_MPRText12.text = string.Format("{0:N2}", AverageB6);
        }
        if (Teams == 0)
            AverageATotla = AverageA1 + AverageA2 + AverageA3 + AverageA4 + AverageA5 + AverageA6 / 6;
        if (Teams == 1)
            AverageBTotla = AverageB1 + AverageB2 + AverageB3 + AverageB4 + AverageB5 + AverageB6 / 6;
    }

    public int GetMovie()
    {
        if (m_oDartInfo[0].nScore == 50 && m_oDartInfo[1].nScore == 50 && m_oDartInfo[2].nScore == 50)
        {
            gmg.MoviePlay(1);
        }
        else if ((m_oDartInfo[0].nScore == 25 || m_oDartInfo[0].nScore == 50) && (m_oDartInfo[1].nScore == 25 || m_oDartInfo[1].nScore == 50) && (m_oDartInfo[2].nScore == 25 || m_oDartInfo[2].nScore == 50))
        {//hattrick
            gmg.MoviePlay(2);
        }
        else if (m_oDartInfo[0].nScore + m_oDartInfo[1].nScore + m_oDartInfo[2].nScore > 151)
        {//highton
            gmg.MoviePlay(3);
        }
        else if (m_oDartInfo[0].nScore + m_oDartInfo[1].nScore + m_oDartInfo[2].nScore > 100 && m_oDartInfo[0].nScore + m_oDartInfo[1].nScore + m_oDartInfo[2].nScore < 150)
        {//lowton
            gmg.MoviePlay(4);
        }
        else if (m_oDartInfo[0].nLine == m_oDartInfo[1].nLine && m_oDartInfo[0].nLine == m_oDartInfo[2].nLine && m_oDartInfo[1].nLine == m_oDartInfo[2].nLine &&
            m_oDartInfo[0].nScore == m_oDartInfo[1].nScore && m_oDartInfo[0].nScore == m_oDartInfo[2].nScore && m_oDartInfo[1].nScore == m_oDartInfo[2].nScore)
        {//three in a bed
            gmg.MoviePlay(5);
        }
        else if (m_oDartInfo[0].nLine == 3 && m_oDartInfo[1].nLine == 3 && m_oDartInfo[2].nLine == 3 &&
                      m_oDartInfo[0].nScore != m_oDartInfo[1].nScore && m_oDartInfo[0].nScore != m_oDartInfo[2].nScore && m_oDartInfo[1].nScore != m_oDartInfo[2].nScore)
        {//white horse
            gmg.MoviePlay(6);
        }
        else
            return 0;
        return 0;
    }
}
