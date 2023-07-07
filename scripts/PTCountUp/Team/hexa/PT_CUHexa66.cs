﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PT_CUHexa66 : MonoBehaviour
{
    public Text t_RoundText;
    public Text t_PPDText_A1;
    public Text t_PPDText_A2;
    public Text t_PPDText_A3;
    public Text t_PPDText_A4;
    public Text t_PPDText_A5;
    public Text t_PPDText_A6;
    public Text t_PPDText_B1;
    public Text t_PPDText_B2;
    public Text t_PPDText_B3;
    public Text t_PPDText_B4;
    public Text t_PPDText_B5;
    public Text t_PPDText_B6;
    public Text[] t_RScoreText_A1 = new Text[5];
    public Text[] t_RScoreText_A2 = new Text[5];
    public Text[] t_RScoreText_A3 = new Text[5];
    public Text[] t_RScoreText_A4 = new Text[5];
    public Text[] t_RScoreText_A5 = new Text[5];
    public Text[] t_RScoreText_A6 = new Text[5];
    public Text[] t_RScoreText_B1 = new Text[5];
    public Text[] t_RScoreText_B2 = new Text[5];
    public Text[] t_RScoreText_B3 = new Text[5];
    public Text[] t_RScoreText_B4 = new Text[5];
    public Text[] t_RScoreText_B5 = new Text[5];
    public Text[] t_RScoreText_B6 = new Text[5];

    public GameObject[] g_Dart = new GameObject[3];
    public GameObject g_RAni;
    public GameObject g_DAni;
    public GameObject g_PAni;
    public GameObject g_CAni;
    public GameObject g_RoundOn;
    public GameObject g_RoundR;
    public GameObject[] g_RoundNum = new GameObject[8];
    public GameObject[] g_MScore = new GameObject[2];
    public GameObject[] g_PScore = new GameObject[2];
    public GameObject[] g_OffScore = new GameObject[2];
    public GameObject[] g_RScore = new GameObject[12];
    public GameObject[] g_Playerbar = new GameObject[2];
    public GameObject[] g_Teambar = new GameObject[2];
    public GameObject g_AT;
    public GameObject g_BT;

    public Sprite s_OnDart;
    public Sprite s_OffDart;
    public Sprite[] s_OnPlayer = new Sprite[6];
    public Sprite[] s_OffPlayer = new Sprite[6];
    public Sprite[] s_OnTeambar = new Sprite[2];
    public Sprite[] s_OffTeambar = new Sprite[2];
    public Sprite[] s_RScore = new Sprite[8];
    public Image[] i_Rscore_A1 = new Image[5];
    public Image[] i_Rscore_A2 = new Image[5];
    public Image[] i_Rscore_A3 = new Image[5];
    public Image[] i_Rscore_A4 = new Image[5];
    public Image[] i_Rscore_A5 = new Image[5];
    public Image[] i_Rscore_A6 = new Image[5];
    public Image[] i_Rscore_B1 = new Image[5];
    public Image[] i_Rscore_B2 = new Image[5];
    public Image[] i_Rscore_B3 = new Image[5];
    public Image[] i_Rscore_B4 = new Image[5];
    public Image[] i_Rscore_B5 = new Image[5];
    public Image[] i_Rscore_B6 = new Image[5];

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int Counting = 0;
    public int Round = 0;
    public int RoundStop = 8;
    public int A1_DartTotal = 0;
    public int A2_DartTotal = 0;
    public int A3_DartTotal = 0;
    public int A4_DartTotal = 0;
    public int A5_DartTotal = 0;
    public int A6_DartTotal = 0;
    public int B1_DartTotal = 0;
    public int B2_DartTotal = 0;
    public int B3_DartTotal = 0;
    public int B4_DartTotal = 0;
    public int B5_DartTotal = 0;
    public int B6_DartTotal = 0;
    public int RScore = 0;
    public int[] TeamScore = new int[2];
    public int A1_Average = 0;
    public int A2_Average = 0;
    public int A3_Average = 0;
    public int A4_Average = 0;
    public int A5_Average = 0;
    public int A6_Average = 0;
    public int B1_Average = 0;
    public int B2_Average = 0;
    public int B3_Average = 0;
    public int B4_Average = 0;
    public int B5_Average = 0;
    public int B6_Average = 0;
    public int AT_Average = 0;
    public int BT_Average = 0;

    public int A1_AverageCounting = 0;
    public int A2_AverageCounting = 0;
    public int A3_AverageCounting = 0;
    public int A4_AverageCounting = 0;
    public int A5_AverageCounting = 0;
    public int A6_AverageCounting = 0;
    public int B1_AverageCounting = 0;
    public int B2_AverageCounting = 0;
    public int B3_AverageCounting = 0;
    public int B4_AverageCounting = 0;
    public int B5_AverageCounting = 0;
    public int B6_AverageCounting = 0;

    public int Players = 0;
    public int Teams = 0;
    public int win = 0;
    public int[] DartScore = new int[3];
    public int[] DartBasicScore = new int[3];
    public int[] A1_ScoreSave = new int[8];
    public int[] A2_ScoreSave = new int[8];
    public int[] A3_ScoreSave = new int[8];
    public int[] A4_ScoreSave = new int[8];
    public int[] A5_ScoreSave = new int[8];
    public int[] A6_ScoreSave = new int[8];
    public int[] B1_ScoreSave = new int[8];
    public int[] B2_ScoreSave = new int[8];
    public int[] B3_ScoreSave = new int[8];
    public int[] B4_ScoreSave = new int[8];
    public int[] B5_ScoreSave = new int[8];
    public int[] B6_ScoreSave = new int[8];

    public string[] playerName = new string[12];

    public bool isEnd = false;
    public bool isSpace = false;
    public bool isRead = false;
    public bool isAT = true;
    public bool isBT = false;

    public CT_GameManager gmg;
    public _TARGET_INFO[] m_oDartInfo = new _TARGET_INFO[3];

    void Start()
    {
        for (int i = 0; i < g_RoundNum.Length; i++)
            g_RoundNum[i].SetActive(false);
        FistStart();
    }


    void Update()
    {
        RScoreImageUp();
        MyTure();
        if (csSingleton.getInstance.g_bTarget)
        {
            csSingleton.getInstance.g_bTarget = false;
            if (Round <= RoundStop && !isRead && !isSpace && !isEnd)
            {
                if (Teams == 0 && Players == 0 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        A1_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[0] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        A1_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        A1_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        GetMovie();
                        g_MScore[0].SetActive(false);
                        g_PAni.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Teams == 0 && Players == 1 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        A2_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[0] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        A2_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        A2_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        GetMovie();
                        g_MScore[0].SetActive(false);
                        g_PAni.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Teams == 0 && Players == 2 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        A3_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[0] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        A3_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        A3_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        GetMovie();
                        g_MScore[0].SetActive(false);
                        g_PAni.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Teams == 0 && Players == 3 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        A4_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[0] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        A4_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        A4_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        GetMovie();
                        g_MScore[0].SetActive(false);
                        g_PAni.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Teams == 0 && Players == 4 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        A5_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[0] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        A5_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        A5_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        GetMovie();
                        g_MScore[0].SetActive(false);
                        g_PAni.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Teams == 0 && Players == 5 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        A6_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[0] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        A6_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        A6_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[0] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        GetMovie();
                        g_MScore[0].SetActive(false);
                        g_PAni.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Teams == 1 && Players == 0 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        B1_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[1] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        B1_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        B1_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        GetMovie();
                        g_MScore[1].SetActive(false);
                        g_PAni.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Teams == 1 && Players == 1 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        B2_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[1] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        B2_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        B2_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        if (Round < RoundStop)
                        {
                            GetMovie();
                            g_MScore[1].SetActive(false);
                            g_PAni.SetActive(true);
                            isSpace = true;
                            Counting = 4;
                        }
                        else if (Round == RoundStop)
                        {
                            Counting = 4;
                            isEnd = true;
                        }
                    }
                }
                else if (Teams == 1 && Players == 2 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        B3_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[1] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        B3_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        B3_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        if (Round < RoundStop)
                        {
                            GetMovie();
                            g_MScore[1].SetActive(false);
                            g_PAni.SetActive(true);
                            isSpace = true;
                            Counting = 4;
                        }
                        else if (Round == RoundStop)
                        {
                            Counting = 4;
                            isEnd = true;
                        }
                    }
                }
                else if (Teams == 1 && Players == 3 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        B4_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[1] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        B4_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        B4_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        if (Round < RoundStop)
                        {
                            GetMovie();
                            g_MScore[1].SetActive(false);
                            g_PAni.SetActive(true);
                            isSpace = true;
                            Counting = 4;
                        }
                        else if (Round == RoundStop)
                        {
                            Counting = 4;
                            isEnd = true;
                        }
                    }
                }
                else if (Teams == 1 && Players == 4 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        B5_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[1] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        B5_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        B5_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        if (Round < RoundStop)
                        {
                            GetMovie();
                            g_MScore[1].SetActive(false);
                            g_PAni.SetActive(true);
                            isSpace = true;
                            Counting = 4;
                        }
                        else if (Round == RoundStop)
                        {
                            Counting = 4;
                            isEnd = true;
                        }
                    }
                }
                else if (Teams == 1 && Players == 5 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        B6_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[1] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        B6_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        B6_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[1] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        g_PScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        if (Round < RoundStop)
                        {
                            GetMovie();
                            g_MScore[1].SetActive(false);
                            g_PAni.SetActive(true);
                            isSpace = true;
                            Counting = 4;
                        }
                        else if (Round == RoundStop)
                        {
                            Counting = 4;
                            isEnd = true;
                        }
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && gmg.isAni == false && isSpace && Counting == 4 && !isEnd)
        {
            if (Teams == 0 && Players == 0 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberPlus", 4.5f);
            }
            else if (Teams == 0 && Players == 1 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberPlus", 4.5f);
            }
            else if (Teams == 0 && Players == 2 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberPlus", 4.5f);
            }
            else if (Teams == 0 && Players == 3 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberPlus", 4.5f);
            }
            else if (Teams == 0 && Players == 4 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberPlus", 4.5f);
            }
            else if (Teams == 0 && Players == 5 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberPlus", 4.5f);
            }
            else if (Teams == 1 && Players == 0 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberMinus", 4.5f);
                Invoke("PlayerNumberPlus", 4.5f);
            }
            else if (Teams == 1 && Players == 1 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberMinus", 4.5f);
                Invoke("PlayerNumberPlus", 4.5f);
            }
            else if (Teams == 1 && Players == 2 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberMinus", 4.5f);
                Invoke("PlayerNumberPlus", 4.5f);
            }
            else if (Teams == 1 && Players == 3 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberMinus", 4.5f);
                Invoke("PlayerNumberPlus", 4.5f);
            }
            else if (Teams == 1 && Players == 4 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                g_CAni.SetActive(true);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                Invoke("TeamNumberMinus", 4.5f);
                Invoke("PlayerNumberPlus", 4.5f);
            }
            else if (Teams == 1 && Players == 5 && !isRead && !isEnd)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                RScore += 1;
                RoundRead();
                Invoke("TeamNumberMinus", 4.5f);
                Invoke("PlayerNumberMinus", 4.5f);
            }
        }
        if (isEnd)
        {
            GameEndRead();
        }
    }

    void MyTure()
    {
        if (isAT && !isBT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            g_RScore[0].SetActive(true);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OnPlayer[0];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[0];

            g_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];

            t_PPDText_A1.enabled = true;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = false;
            t_PPDText_B6.enabled = false;

            for (int i = 0; i < i_Rscore_A1.Length; i++)
            {
                i_Rscore_A1[i].enabled = true;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isBT && !isAT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(true);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(false);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);

            g_RScore[6].SetActive(true);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(false);

            g_Playerbar[1].GetComponent<Image>().sprite = s_OnPlayer[0];
            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[0];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = true;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = false;
            t_PPDText_B6.enabled = false;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = true;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isAT && !isBT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(true);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OnPlayer[1];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[1];

            g_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = true;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = false;
            t_PPDText_B6.enabled = false;

            for (int i = 0; i < i_Rscore_A1.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = true;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isBT && !isAT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(true);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(false);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);

            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(true);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[1];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OnPlayer[1];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = true;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = false;
            t_PPDText_B6.enabled = false;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = true;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isAT && !isBT && Players == 2)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(true);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OnPlayer[2];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[2];

            g_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = true;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = false;
            t_PPDText_B6.enabled = false;

            for (int i = 0; i < i_Rscore_A1.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = true;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isBT && !isAT && Players == 2)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(true);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(false);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);

            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(true);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[2];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OnPlayer[2];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = true;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = false;
            t_PPDText_B6.enabled = false;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = true;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isAT && !isBT && Players == 3)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(true);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OnPlayer[3];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[3];

            g_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = true;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = false;
            t_PPDText_B6.enabled = false;

            for (int i = 0; i < i_Rscore_A1.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = true;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isBT && !isAT && Players == 3)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(true);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(false);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(true);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[3];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OnPlayer[3];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = true;
            t_PPDText_B5.enabled = false;
            t_PPDText_B6.enabled = false;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = true;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isAT && !isBT && Players == 4)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(true);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OnPlayer[4];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[4];

            g_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = true;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = false;
            t_PPDText_B5.enabled = false;

            for (int i = 0; i < i_Rscore_A1.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = true;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isBT && !isAT && Players == 4)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(true);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(false);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(true);
            g_RScore[11].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[4];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OnPlayer[4];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = true;
            t_PPDText_B6.enabled = false;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = true;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isAT && !isBT && Players == 5)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(true);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OnPlayer[5];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[5];

            g_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = true;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = false;
            t_PPDText_B5.enabled = false;

            for (int i = 0; i < i_Rscore_A1.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = true;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = false;
            }
        }

        else if (isBT && !isAT && Players == 5)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(true);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(false);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);
            g_RScore[9].SetActive(false);
            g_RScore[10].SetActive(false);
            g_RScore[11].SetActive(true);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[5];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OnPlayer[5];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_A4.enabled = false;
            t_PPDText_A5.enabled = false;
            t_PPDText_A6.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_B4.enabled = false;
            t_PPDText_B5.enabled = false;
            t_PPDText_B6.enabled = true;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_A4[i].enabled = false;
                i_Rscore_A5[i].enabled = false;
                i_Rscore_A6[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_B4[i].enabled = false;
                i_Rscore_B5[i].enabled = false;
                i_Rscore_B6[i].enabled = true;
            }
        }
    }

    void TeamNumberPlus()
    {
        g_MScore[Teams].SetActive(false);
        g_PScore[Teams].SetActive(false);
        isAT = false;
        isBT = true;
        isRead = false;
        g_CAni.SetActive(false);
        Counting = 0;
        Teams = 1;
        g_MScore[Teams].SetActive(true);
        g_PScore[Teams].SetActive(true);
        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_PScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void TeamNumberMinus()
    {
        g_MScore[Teams].SetActive(false);
        g_PScore[Teams].SetActive(false);
        isAT = true;
        isBT = false;
        isRead = false;
        g_CAni.SetActive(false);
        Counting = 0;
        Teams = 0;
        g_MScore[Teams].SetActive(true);
        g_PScore[Teams].SetActive(true);
        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_PScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void PlayerNumberPlus()
    {
        g_MScore[Teams].SetActive(false);
        g_PScore[Teams].SetActive(false);
        g_CAni.SetActive(false);
        Counting = 0;
        Players += 1;
        g_MScore[Teams].SetActive(true);
        g_PScore[Teams].SetActive(true);
        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_PScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void PlayerNumberMinus()
    {
        g_MScore[Teams].SetActive(false);
        g_PScore[Teams].SetActive(false);
        g_CAni.SetActive(false);
        Counting = 0;
        Players = 0;
        g_MScore[Teams].SetActive(true);
        g_PScore[Teams].SetActive(true);
        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_PScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void FistStart()
    {
        isRead = true;
        isAT = true;
        isBT = false;
        for (int i = 0; i < g_Dart.Length; i++)
            g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
        for (int i = 0; i < g_MScore.Length; i++)
        {
            g_MScore[i].GetComponent<csNumber>().CreateNumber(4, 250, 3f, 0);
            g_PScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_OffScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_MScore[i].GetComponent<csNumber>().SetNumber(0);
            g_PScore[i].GetComponent<csNumber>().SetNumber(0);
            g_OffScore[i].GetComponent<csNumber>().SetNumber(0);
        }
        g_RAni.SetActive(true);
        g_RoundOn.SetActive(true);
        g_RoundNum[Round].SetActive(true);
        g_RoundR.SetActive(true);
        g_CAni.SetActive(false);
        g_PAni.SetActive(false);
        for (int i = 0; i < g_MScore.Length; i++)
            g_MScore[i].SetActive(false);
        Invoke("FistAniStop", 1.5f);
    }

    void FistAniStop()
    {
        g_RAni.SetActive(false);
        g_RoundOn.SetActive(false);
        g_RoundR.SetActive(false);
        g_RoundNum[Round].SetActive(false);
        g_MScore[0].SetActive(true);
        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
        Round = 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    public void RoundScore(int n)
    {
        if (isAT && !isBT && Players == 0)
        {
            A1_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_A1[0].text = A1_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_A1[1].text = A1_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_A1[2].text = A1_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_A1[3].text = A1_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_A1[4].text = A1_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_A1[0].text = A1_ScoreSave[1].ToString();
                    t_RScoreText_A1[1].text = A1_ScoreSave[2].ToString();
                    t_RScoreText_A1[2].text = A1_ScoreSave[3].ToString();
                    t_RScoreText_A1[3].text = A1_ScoreSave[4].ToString();
                    t_RScoreText_A1[4].text = A1_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_A1[0].text = A1_ScoreSave[2].ToString();
                    t_RScoreText_A1[1].text = A1_ScoreSave[3].ToString();
                    t_RScoreText_A1[2].text = A1_ScoreSave[4].ToString();
                    t_RScoreText_A1[3].text = A1_ScoreSave[5].ToString();
                    t_RScoreText_A1[4].text = A1_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_A1[0].text = A1_ScoreSave[3].ToString();
                    t_RScoreText_A1[1].text = A1_ScoreSave[4].ToString();
                    t_RScoreText_A1[2].text = A1_ScoreSave[5].ToString();
                    t_RScoreText_A1[3].text = A1_ScoreSave[6].ToString();
                    t_RScoreText_A1[4].text = A1_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_A1[0].text = A1_ScoreSave[4].ToString();
                    t_RScoreText_A1[1].text = A1_ScoreSave[5].ToString();
                    t_RScoreText_A1[2].text = A1_ScoreSave[6].ToString();
                    t_RScoreText_A1[3].text = A1_ScoreSave[7].ToString();
                    t_RScoreText_A1[4].text = A1_ScoreSave[8].ToString();
                }
            }
        }
        else if (isAT && !isBT && Players == 1)
        {
            A2_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_A2[0].text = A2_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_A2[1].text = A2_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_A2[2].text = A2_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_A2[3].text = A2_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_A2[4].text = A2_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_A2[0].text = A2_ScoreSave[1].ToString();
                    t_RScoreText_A2[1].text = A2_ScoreSave[2].ToString();
                    t_RScoreText_A2[2].text = A2_ScoreSave[3].ToString();
                    t_RScoreText_A2[3].text = A2_ScoreSave[4].ToString();
                    t_RScoreText_A2[4].text = A2_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_A2[0].text = A2_ScoreSave[2].ToString();
                    t_RScoreText_A2[1].text = A2_ScoreSave[3].ToString();
                    t_RScoreText_A2[2].text = A2_ScoreSave[4].ToString();
                    t_RScoreText_A2[3].text = A2_ScoreSave[5].ToString();
                    t_RScoreText_A2[4].text = A2_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_A2[0].text = A2_ScoreSave[3].ToString();
                    t_RScoreText_A2[1].text = A2_ScoreSave[4].ToString();
                    t_RScoreText_A2[2].text = A2_ScoreSave[5].ToString();
                    t_RScoreText_A2[3].text = A2_ScoreSave[6].ToString();
                    t_RScoreText_A2[4].text = A2_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_A2[0].text = A2_ScoreSave[4].ToString();
                    t_RScoreText_A2[1].text = A2_ScoreSave[5].ToString();
                    t_RScoreText_A2[2].text = A2_ScoreSave[6].ToString();
                    t_RScoreText_A2[3].text = A2_ScoreSave[7].ToString();
                    t_RScoreText_A2[4].text = A2_ScoreSave[8].ToString();
                }
            }
        }
        else if (isAT && !isBT && Players == 2)
        {
            A3_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_A3[0].text = A3_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_A3[1].text = A3_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_A3[2].text = A3_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_A3[3].text = A3_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_A3[4].text = A3_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_A3[0].text = A3_ScoreSave[1].ToString();
                    t_RScoreText_A3[1].text = A3_ScoreSave[2].ToString();
                    t_RScoreText_A3[2].text = A3_ScoreSave[3].ToString();
                    t_RScoreText_A3[3].text = A3_ScoreSave[4].ToString();
                    t_RScoreText_A3[4].text = A3_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_A3[0].text = A3_ScoreSave[2].ToString();
                    t_RScoreText_A3[1].text = A3_ScoreSave[3].ToString();
                    t_RScoreText_A3[2].text = A3_ScoreSave[4].ToString();
                    t_RScoreText_A3[3].text = A3_ScoreSave[5].ToString();
                    t_RScoreText_A3[4].text = A3_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_A3[0].text = A3_ScoreSave[3].ToString();
                    t_RScoreText_A3[1].text = A3_ScoreSave[4].ToString();
                    t_RScoreText_A3[2].text = A3_ScoreSave[5].ToString();
                    t_RScoreText_A3[3].text = A3_ScoreSave[6].ToString();
                    t_RScoreText_A3[4].text = A3_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_A3[0].text = A3_ScoreSave[4].ToString();
                    t_RScoreText_A3[1].text = A3_ScoreSave[5].ToString();
                    t_RScoreText_A3[2].text = A3_ScoreSave[6].ToString();
                    t_RScoreText_A3[3].text = A3_ScoreSave[7].ToString();
                    t_RScoreText_A3[4].text = A3_ScoreSave[8].ToString();
                }
            }
        }
        else if (isAT && !isBT && Players == 3)
        {
            A4_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_A4[0].text = A4_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_A4[1].text = A4_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_A4[2].text = A4_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_A4[3].text = A4_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_A4[4].text = A4_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_A4[0].text = A4_ScoreSave[1].ToString();
                    t_RScoreText_A4[1].text = A4_ScoreSave[2].ToString();
                    t_RScoreText_A4[2].text = A4_ScoreSave[3].ToString();
                    t_RScoreText_A4[3].text = A4_ScoreSave[4].ToString();
                    t_RScoreText_A4[4].text = A4_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_A4[0].text = A4_ScoreSave[2].ToString();
                    t_RScoreText_A4[1].text = A4_ScoreSave[3].ToString();
                    t_RScoreText_A4[2].text = A4_ScoreSave[4].ToString();
                    t_RScoreText_A4[3].text = A4_ScoreSave[5].ToString();
                    t_RScoreText_A4[4].text = A4_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_A4[0].text = A4_ScoreSave[3].ToString();
                    t_RScoreText_A4[1].text = A4_ScoreSave[4].ToString();
                    t_RScoreText_A4[2].text = A4_ScoreSave[5].ToString();
                    t_RScoreText_A4[3].text = A4_ScoreSave[6].ToString();
                    t_RScoreText_A4[4].text = A4_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_A4[0].text = A4_ScoreSave[4].ToString();
                    t_RScoreText_A4[1].text = A4_ScoreSave[5].ToString();
                    t_RScoreText_A4[2].text = A4_ScoreSave[6].ToString();
                    t_RScoreText_A4[3].text = A4_ScoreSave[7].ToString();
                    t_RScoreText_A4[4].text = A4_ScoreSave[8].ToString();
                }
            }
        }
        else if (isAT && !isBT && Players == 4)
        {
            A5_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_A5[0].text = A5_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_A5[1].text = A5_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_A5[2].text = A5_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_A5[3].text = A5_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_A5[4].text = A5_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_A5[0].text = A5_ScoreSave[1].ToString();
                    t_RScoreText_A5[1].text = A5_ScoreSave[2].ToString();
                    t_RScoreText_A5[2].text = A5_ScoreSave[3].ToString();
                    t_RScoreText_A5[3].text = A5_ScoreSave[4].ToString();
                    t_RScoreText_A5[4].text = A5_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_A5[0].text = A5_ScoreSave[2].ToString();
                    t_RScoreText_A5[1].text = A5_ScoreSave[3].ToString();
                    t_RScoreText_A5[2].text = A5_ScoreSave[4].ToString();
                    t_RScoreText_A5[3].text = A5_ScoreSave[5].ToString();
                    t_RScoreText_A5[4].text = A5_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_A5[0].text = A5_ScoreSave[3].ToString();
                    t_RScoreText_A5[1].text = A5_ScoreSave[4].ToString();
                    t_RScoreText_A5[2].text = A5_ScoreSave[5].ToString();
                    t_RScoreText_A5[3].text = A5_ScoreSave[6].ToString();
                    t_RScoreText_A5[4].text = A5_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_A5[0].text = A5_ScoreSave[4].ToString();
                    t_RScoreText_A5[1].text = A5_ScoreSave[5].ToString();
                    t_RScoreText_A5[2].text = A5_ScoreSave[6].ToString();
                    t_RScoreText_A5[3].text = A5_ScoreSave[7].ToString();
                    t_RScoreText_A5[4].text = A5_ScoreSave[8].ToString();
                }
            }
        }
        else if (isAT && !isBT && Players == 5)
        {
            A6_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_A6[0].text = A6_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_A6[1].text = A6_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_A6[2].text = A6_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_A6[3].text = A6_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_A6[4].text = A6_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_A6[0].text = A6_ScoreSave[1].ToString();
                    t_RScoreText_A6[1].text = A6_ScoreSave[2].ToString();
                    t_RScoreText_A6[2].text = A6_ScoreSave[3].ToString();
                    t_RScoreText_A6[3].text = A6_ScoreSave[4].ToString();
                    t_RScoreText_A6[4].text = A6_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_A6[0].text = A6_ScoreSave[2].ToString();
                    t_RScoreText_A6[1].text = A6_ScoreSave[3].ToString();
                    t_RScoreText_A6[2].text = A6_ScoreSave[4].ToString();
                    t_RScoreText_A6[3].text = A6_ScoreSave[5].ToString();
                    t_RScoreText_A6[4].text = A6_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_A6[0].text = A6_ScoreSave[3].ToString();
                    t_RScoreText_A6[1].text = A6_ScoreSave[4].ToString();
                    t_RScoreText_A6[2].text = A6_ScoreSave[5].ToString();
                    t_RScoreText_A6[3].text = A6_ScoreSave[6].ToString();
                    t_RScoreText_A6[4].text = A6_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_A6[0].text = A6_ScoreSave[4].ToString();
                    t_RScoreText_A6[1].text = A6_ScoreSave[5].ToString();
                    t_RScoreText_A6[2].text = A6_ScoreSave[6].ToString();
                    t_RScoreText_A6[3].text = A6_ScoreSave[7].ToString();
                    t_RScoreText_A6[4].text = A6_ScoreSave[8].ToString();
                }
            }
        }
        else if (isBT && !isAT && Players == 0)
        {
            B1_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_B1[0].text = B1_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_B1[1].text = B1_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_B1[2].text = B1_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_B1[3].text = B1_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_B1[4].text = B1_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_B1[0].text = B1_ScoreSave[1].ToString();
                    t_RScoreText_B1[1].text = B1_ScoreSave[2].ToString();
                    t_RScoreText_B1[2].text = B1_ScoreSave[3].ToString();
                    t_RScoreText_B1[3].text = B1_ScoreSave[4].ToString();
                    t_RScoreText_B1[4].text = B1_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_B1[0].text = B1_ScoreSave[2].ToString();
                    t_RScoreText_B1[1].text = B1_ScoreSave[3].ToString();
                    t_RScoreText_B1[2].text = B1_ScoreSave[4].ToString();
                    t_RScoreText_B1[3].text = B1_ScoreSave[5].ToString();
                    t_RScoreText_B1[4].text = B1_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_B1[0].text = B1_ScoreSave[3].ToString();
                    t_RScoreText_B1[1].text = B1_ScoreSave[4].ToString();
                    t_RScoreText_B1[2].text = B1_ScoreSave[5].ToString();
                    t_RScoreText_B1[3].text = B1_ScoreSave[6].ToString();
                    t_RScoreText_B1[4].text = B1_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_B1[0].text = B1_ScoreSave[4].ToString();
                    t_RScoreText_B1[1].text = B1_ScoreSave[5].ToString();
                    t_RScoreText_B1[2].text = B1_ScoreSave[6].ToString();
                    t_RScoreText_B1[3].text = B1_ScoreSave[7].ToString();
                    t_RScoreText_B1[4].text = B1_ScoreSave[8].ToString();
                }
            }
        }
        else if (isBT && !isAT && Players == 1)
        {
            B2_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_B2[0].text = B2_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_B2[1].text = B2_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_B2[2].text = B2_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_B2[3].text = B2_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_B2[4].text = B2_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_B2[0].text = B2_ScoreSave[1].ToString();
                    t_RScoreText_B2[1].text = B2_ScoreSave[2].ToString();
                    t_RScoreText_B2[2].text = B2_ScoreSave[3].ToString();
                    t_RScoreText_B2[3].text = B2_ScoreSave[4].ToString();
                    t_RScoreText_B2[4].text = B2_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_B2[0].text = B2_ScoreSave[2].ToString();
                    t_RScoreText_B2[1].text = B2_ScoreSave[3].ToString();
                    t_RScoreText_B2[2].text = B2_ScoreSave[4].ToString();
                    t_RScoreText_B2[3].text = B2_ScoreSave[5].ToString();
                    t_RScoreText_B2[4].text = B2_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_B2[0].text = B2_ScoreSave[3].ToString();
                    t_RScoreText_B2[1].text = B2_ScoreSave[4].ToString();
                    t_RScoreText_B2[2].text = B2_ScoreSave[5].ToString();
                    t_RScoreText_B2[3].text = B2_ScoreSave[6].ToString();
                    t_RScoreText_B2[4].text = B2_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_B2[0].text = B2_ScoreSave[4].ToString();
                    t_RScoreText_B2[1].text = B2_ScoreSave[5].ToString();
                    t_RScoreText_B2[2].text = B2_ScoreSave[6].ToString();
                    t_RScoreText_B2[3].text = B2_ScoreSave[7].ToString();
                    t_RScoreText_B2[4].text = B2_ScoreSave[8].ToString();
                }
            }
        }
        else if (isBT && !isAT && Players == 2)
        {
            B3_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_B3[0].text = B3_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_B3[1].text = B3_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_B3[2].text = B3_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_B3[3].text = B3_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_B3[4].text = B3_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_B3[0].text = B3_ScoreSave[1].ToString();
                    t_RScoreText_B3[1].text = B3_ScoreSave[2].ToString();
                    t_RScoreText_B3[2].text = B3_ScoreSave[3].ToString();
                    t_RScoreText_B3[3].text = B3_ScoreSave[4].ToString();
                    t_RScoreText_B3[4].text = B3_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_B3[0].text = B3_ScoreSave[2].ToString();
                    t_RScoreText_B3[1].text = B3_ScoreSave[3].ToString();
                    t_RScoreText_B3[2].text = B3_ScoreSave[4].ToString();
                    t_RScoreText_B3[3].text = B3_ScoreSave[5].ToString();
                    t_RScoreText_B3[4].text = B3_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_B3[0].text = B3_ScoreSave[3].ToString();
                    t_RScoreText_B3[1].text = B3_ScoreSave[4].ToString();
                    t_RScoreText_B3[2].text = B3_ScoreSave[5].ToString();
                    t_RScoreText_B3[3].text = B3_ScoreSave[6].ToString();
                    t_RScoreText_B3[4].text = B3_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_B3[0].text = B3_ScoreSave[4].ToString();
                    t_RScoreText_B3[1].text = B3_ScoreSave[5].ToString();
                    t_RScoreText_B3[2].text = B3_ScoreSave[6].ToString();
                    t_RScoreText_B3[3].text = B3_ScoreSave[7].ToString();
                    t_RScoreText_B3[4].text = B3_ScoreSave[8].ToString();
                }
            }
        }
        else if (isBT && !isAT && Players == 3)
        {
            B4_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_B4[0].text = B4_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_B4[1].text = B4_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_B4[2].text = B4_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_B4[3].text = B4_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_B4[4].text = B4_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_B4[0].text = B4_ScoreSave[1].ToString();
                    t_RScoreText_B4[1].text = B4_ScoreSave[2].ToString();
                    t_RScoreText_B4[2].text = B4_ScoreSave[3].ToString();
                    t_RScoreText_B4[3].text = B4_ScoreSave[4].ToString();
                    t_RScoreText_B4[4].text = B4_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_B4[0].text = B4_ScoreSave[2].ToString();
                    t_RScoreText_B4[1].text = B4_ScoreSave[3].ToString();
                    t_RScoreText_B4[2].text = B4_ScoreSave[4].ToString();
                    t_RScoreText_B4[3].text = B4_ScoreSave[5].ToString();
                    t_RScoreText_B4[4].text = B4_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_B4[0].text = B4_ScoreSave[3].ToString();
                    t_RScoreText_B4[1].text = B4_ScoreSave[4].ToString();
                    t_RScoreText_B4[2].text = B4_ScoreSave[5].ToString();
                    t_RScoreText_B4[3].text = B4_ScoreSave[6].ToString();
                    t_RScoreText_B4[4].text = B4_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_B4[0].text = B4_ScoreSave[4].ToString();
                    t_RScoreText_B4[1].text = B4_ScoreSave[5].ToString();
                    t_RScoreText_B4[2].text = B4_ScoreSave[6].ToString();
                    t_RScoreText_B4[3].text = B4_ScoreSave[7].ToString();
                    t_RScoreText_B4[4].text = B4_ScoreSave[8].ToString();
                }
            }
        }
        else if (isBT && !isAT && Players == 4)
        {
            B5_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_B5[0].text = B5_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_B5[1].text = B5_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_B5[2].text = B5_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_B5[3].text = B5_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_B5[4].text = B5_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_B5[0].text = B5_ScoreSave[1].ToString();
                    t_RScoreText_B5[1].text = B5_ScoreSave[2].ToString();
                    t_RScoreText_B5[2].text = B5_ScoreSave[3].ToString();
                    t_RScoreText_B5[3].text = B5_ScoreSave[4].ToString();
                    t_RScoreText_B5[4].text = B5_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_B5[0].text = B5_ScoreSave[2].ToString();
                    t_RScoreText_B5[1].text = B5_ScoreSave[3].ToString();
                    t_RScoreText_B5[2].text = B5_ScoreSave[4].ToString();
                    t_RScoreText_B5[3].text = B5_ScoreSave[5].ToString();
                    t_RScoreText_B5[4].text = B5_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_B5[0].text = B5_ScoreSave[3].ToString();
                    t_RScoreText_B5[1].text = B5_ScoreSave[4].ToString();
                    t_RScoreText_B5[2].text = B5_ScoreSave[5].ToString();
                    t_RScoreText_B5[3].text = B5_ScoreSave[6].ToString();
                    t_RScoreText_B5[4].text = B5_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_B5[0].text = B5_ScoreSave[4].ToString();
                    t_RScoreText_B5[1].text = B5_ScoreSave[5].ToString();
                    t_RScoreText_B5[2].text = B5_ScoreSave[6].ToString();
                    t_RScoreText_B5[3].text = B5_ScoreSave[7].ToString();
                    t_RScoreText_B5[4].text = B5_ScoreSave[8].ToString();
                }
            }
        }
        else if (isBT && !isAT && Players == 5)
        {
            B6_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_B6[0].text = B6_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_B6[1].text = B6_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_B6[2].text = B6_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_B6[3].text = B6_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_B6[4].text = B6_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_B6[0].text = B6_ScoreSave[1].ToString();
                    t_RScoreText_B6[1].text = B6_ScoreSave[2].ToString();
                    t_RScoreText_B6[2].text = B6_ScoreSave[3].ToString();
                    t_RScoreText_B6[3].text = B6_ScoreSave[4].ToString();
                    t_RScoreText_B6[4].text = B6_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_B6[0].text = B6_ScoreSave[2].ToString();
                    t_RScoreText_B6[1].text = B6_ScoreSave[3].ToString();
                    t_RScoreText_B6[2].text = B6_ScoreSave[4].ToString();
                    t_RScoreText_B6[3].text = B6_ScoreSave[5].ToString();
                    t_RScoreText_B6[4].text = B6_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_B6[0].text = B6_ScoreSave[3].ToString();
                    t_RScoreText_B6[1].text = B6_ScoreSave[4].ToString();
                    t_RScoreText_B6[2].text = B6_ScoreSave[5].ToString();
                    t_RScoreText_B6[3].text = B6_ScoreSave[6].ToString();
                    t_RScoreText_B6[4].text = B6_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_B6[0].text = B6_ScoreSave[4].ToString();
                    t_RScoreText_B6[1].text = B6_ScoreSave[5].ToString();
                    t_RScoreText_B6[2].text = B6_ScoreSave[6].ToString();
                    t_RScoreText_B6[3].text = B6_ScoreSave[7].ToString();
                    t_RScoreText_B6[4].text = B6_ScoreSave[8].ToString();
                }
            }
        }
        else
        {
        }
    }
    public void RScoreImageUp()
    {
        if (isAT && !isBT && Players == 0)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_A1[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_A1[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A1[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A1[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A1[4].GetComponent<Image>().sprite = s_RScore[5];

                }
                if (RScore == 6)
                {
                    i_Rscore_A1[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A1[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A1[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A1[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A1[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_A1[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A1[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A1[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A1[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A1[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_A1[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A1[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A1[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A1[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_A1[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isAT && !isBT && Players == 1)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_A2[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_A2[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A2[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A2[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A2[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_A2[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A2[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A2[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A2[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A2[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_A2[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A2[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A2[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A2[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A2[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_A2[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A2[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A2[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A2[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_A2[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isAT && !isBT && Players == 2)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_A3[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_A3[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A3[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A3[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A3[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_A3[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A3[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A3[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A3[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A3[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_A3[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A3[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A3[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A3[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A3[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_A3[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A3[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A3[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A3[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_A3[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isAT && !isBT && Players == 3)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_A4[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_A4[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A4[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A4[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A4[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_A4[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A4[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A4[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A4[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A4[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_A4[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A4[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A4[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A4[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A4[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_A4[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A4[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A4[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A4[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_A4[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isAT && !isBT && Players == 4)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_A5[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_A5[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A5[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A5[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A5[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_A5[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A5[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A5[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A5[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A5[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_A5[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A5[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A5[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A5[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A5[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_A5[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A5[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A5[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A5[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_A5[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isAT && !isBT && Players == 5)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_A6[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_A6[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A6[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A6[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A6[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_A6[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_A6[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A6[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A6[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A6[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_A6[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_A6[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A6[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A6[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A6[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_A6[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_A6[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_A6[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_A6[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_A6[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isBT && !isAT && Players == 0)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_B1[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_B1[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B1[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B1[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B1[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_B1[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B1[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B1[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B1[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B1[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_B1[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B1[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B1[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B1[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B1[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_B1[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B1[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B1[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B1[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_B1[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isBT && !isAT && Players == 1)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_B2[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_B2[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B2[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B2[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B2[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_B2[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B2[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B2[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B2[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B2[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_B2[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B2[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B2[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B2[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B2[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_B2[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B2[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B2[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B2[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_B2[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isBT && !isAT && Players == 2)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_B3[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_B3[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B3[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B3[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B3[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_B3[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B3[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B3[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B3[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B3[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_B3[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B3[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B3[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B3[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B3[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_B3[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B3[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B3[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B3[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_B3[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isBT && !isAT && Players == 3)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_B4[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_B4[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B4[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B4[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B4[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_B4[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B4[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B4[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B4[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B4[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_B4[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B4[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B4[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B4[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B4[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_B4[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B4[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B4[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B4[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_B4[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isBT && !isAT && Players == 4)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_B5[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_B5[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B5[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B5[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B5[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_B5[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B5[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B5[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B5[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B5[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_B5[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B5[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B5[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B5[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B5[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_B5[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B5[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B5[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B5[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_B5[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else if (isBT && !isAT && Players == 5)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_B6[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_B6[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B6[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B6[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B6[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_B6[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_B6[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B6[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B6[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B6[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_B6[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_B6[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B6[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B6[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B6[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_B6[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_B6[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_B6[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_B6[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_B6[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        else { }
    }

    public void RoundRead()
    {
        g_PScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_CAni.SetActive(true);
        g_MScore[Teams].SetActive(false);
        Invoke("RoundStart", 3f);
    }
    public void RoundStart()
    {
        g_CAni.SetActive(false);
        g_RoundOn.SetActive(true);
        g_RAni.SetActive(true);
        g_RoundNum[Round].SetActive(true);
        g_RoundR.SetActive(true);
        Invoke("RoundAniStop", 1.5f);
    }
    public void RoundAniStop()
    {
        Counting = 0;
        g_RoundNum[Round].SetActive(false);
        g_RoundOn.SetActive(false);
        g_RoundR.SetActive(false);
        g_RAni.SetActive(false);
        g_MScore[Teams].SetActive(true);
        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        Round += 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void GameEndRead() //라운드 종료로 오면 여기로
    {
        if (TeamScore[1] < TeamScore[0])
        {
            win = 0;
            isEnd = true;
            isAT = true;
            isBT = false;
            g_PAni.SetActive(false);
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            gmg.GameEnd(win);
        }

        if (TeamScore[0] < TeamScore[1])
        {
            win = 1;
            isEnd = true;
            isAT = false;
            isBT = true;
            g_PAni.SetActive(false);
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            gmg.GameEnd(win);
        }

        if (TeamScore[0] == TeamScore[1])
        {
            win = 0;
            isEnd = true;
            isAT = true;
            isBT = false;
            g_PAni.SetActive(false);
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            gmg.GameEnd(win);
        }
    }

    void PPDScore(int n)
    {
        if (Teams == 0 && Players == 0)
        {
            A1_DartTotal += n;
            A1_Average = A1_DartTotal / A1_AverageCounting;
            t_PPDText_A1.text = string.Format("{0:N2}", A1_Average);
        }
        else if (Teams == 0 && Players == 1)
        {
            A2_DartTotal += n;
            A2_Average = A2_DartTotal / A2_AverageCounting;
            t_PPDText_A2.text = string.Format("{0:N2}", A2_Average);
        }
        else if (Teams == 0 && Players == 2)
        {
            A3_DartTotal += n;
            A3_Average = A3_DartTotal / A3_AverageCounting;
            t_PPDText_A3.text = string.Format("{0:N2}", A3_Average);
        }
        else if (Teams == 0 && Players == 3)
        {
            A4_DartTotal += n;
            A4_Average = A4_DartTotal / A4_AverageCounting;
            t_PPDText_A4.text = string.Format("{0:N2}", A4_Average);
        }
        else if (Teams == 0 && Players == 4)
        {
            A5_DartTotal += n;
            A5_Average = A5_DartTotal / A5_AverageCounting;
            t_PPDText_A5.text = string.Format("{0:N2}", A5_Average);
        }
        else if (Teams == 0 && Players == 5)
        {
            A6_DartTotal += n;
            A6_Average = A6_DartTotal / A6_AverageCounting;
            t_PPDText_A6.text = string.Format("{0:N2}", A6_Average);
        }
        else if (Teams == 1 && Players == 0)
        {
            B1_DartTotal += n;
            B1_Average = B1_DartTotal / B1_AverageCounting;
            t_PPDText_B1.text = string.Format("{0:N2}", B1_Average);
        }
        else if (Teams == 1 && Players == 1)
        {
            B2_DartTotal += n;
            B2_Average = B2_DartTotal / B2_AverageCounting;
            t_PPDText_B2.text = string.Format("{0:N2}", B2_Average);
        }
        else if (Teams == 1 && Players == 2)
        {
            B3_DartTotal += n;
            B3_Average = B3_DartTotal / B3_AverageCounting;
            t_PPDText_B3.text = string.Format("{0:N2}", B3_Average);
        }
        else if (Teams == 1 && Players == 3)
        {
            B4_DartTotal += n;
            B4_Average = B4_DartTotal / B4_AverageCounting;
            t_PPDText_B4.text = string.Format("{0:N2}", B4_Average);
        }
        else if (Teams == 1 && Players == 4)
        {
            B5_DartTotal += n;
            B5_Average = B5_DartTotal / B5_AverageCounting;
            t_PPDText_B5.text = string.Format("{0:N2}", B5_Average);
        }
        else if (Teams == 1 && Players == 5)
        {
            B6_DartTotal += n;
            B6_Average = B6_DartTotal / B6_AverageCounting;
            t_PPDText_B6.text = string.Format("{0:N2}", B6_Average);
        }

        if (Teams == 0)
            AT_Average = A1_Average + A2_Average + A3_Average + A4_Average + A5_Average + A6_Average / 6;

        else if (Teams == 1)
            BT_Average = B1_Average + B2_Average + B3_Average + B4_Average + B5_Average + B6_Average / 6;
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
