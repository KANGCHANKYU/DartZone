using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Cr_dou22 : MonoBehaviour
{
    public Text t_RoundText;
    public Text t_MPRText1;
    public Text t_MPRText2;
    public Text t_MPRText3;
    public Text t_MPRText4;

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
    public GameObject[] g_ATMainMark = new GameObject[7];
    public GameObject[] g_BTMainMark = new GameObject[7];
    public GameObject[] g_i_Team = new GameObject[2];
    public GameObject[] g_Teambar = new GameObject[2];
    public GameObject[] g_Dart = new GameObject[3];
    public GameObject[] g_RoundScore = new GameObject[4];
    public GameObject[] g_MRPScore = new GameObject[4];
    public GameObject[] g_RoundNum = new GameObject[15];
    public GameObject[] g_P_Score = new GameObject[2];
    public GameObject[] g_OffScore = new GameObject[2];
    public GameObject[] g_Fishbar = new GameObject[7];
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
    public Sprite[] s_TeamOn = new Sprite[2];
    public Sprite[] s_TeamOff = new Sprite[2];
    public Sprite[] s_TeambarOn = new Sprite[2];
    public Sprite[] s_TeambarOff = new Sprite[2];
    public Sprite[] s_ATMark = new Sprite[4];
    public Sprite[] s_BTMark = new Sprite[4];
    public Sprite s_OffMark;

    public Image[] i_RScoreA1 = new Image[5];
    public Image[] i_RScoreA2 = new Image[5];
    public Image[] i_RScoreB1 = new Image[5];
    public Image[] i_RScoreB2 = new Image[5];

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int RoundStop;

    public int[] TeamScore = new int[2];
    public int[] MarkSaveA1 = new int[45];
    public int[] MarkSaveA2 = new int[45];
    public int[] MarkSaveB1 = new int[45];
    public int[] MarkSaveB2 = new int[45];
    public int[] DartBasicScore = new int[3];
    public int AT1MarkCounting = 0;
    public int AT2MarkCounting = 0;
    public int BT1MarkCounting = 0;
    public int BT2MarkCounting = 0;
    public int Counting = 0;
    public int Round = 0;
    public int RoundCountingAT1 = 0;
    public int RoundCountingAT2 = 0;
    public int RoundCountingBT1 = 0;
    public int RoundCountingBT2 = 0;
    public int TotalA1 = 0;
    public int TotalA2 = 0;
    public int TotalB1 = 0;
    public int TotalB2 = 0;
    public int RScore = 0;
    public int Players = 0;
    public int Teams = 0;
    public int win = 0;

    public int AT_20Mark = 60;
    public int AT_19Mark = 57;
    public int AT_18Mark = 54;
    public int AT_17Mark = 51;
    public int AT_16Mark = 48;
    public int AT_15Mark = 45;
    public int AT_BullMark = 75;
    public int BT_20Mark = 60;
    public int BT_19Mark = 57;
    public int BT_18Mark = 54;
    public int BT_17Mark = 51;
    public int BT_16Mark = 48;
    public int BT_15Mark = 45;
    public int BT_BullMark = 75;

    public float AverageA1 = 0;
    public float AverageA2 = 0;
    public float AverageB1 = 0;
    public float AverageB2 = 0;
    public float AverageATotla = 0;
    public float AverageBTotla = 0;

    public string[] playername = new string[4];

    public bool isAT_20Mark = false;
    public bool isBT_20Mark = false;
    public bool isAT_19Mark = false;
    public bool isBT_19Mark = false;
    public bool isAT_18Mark = false;
    public bool isBT_18Mark = false;
    public bool isAT_17Mark = false;
    public bool isBT_17Mark = false;
    public bool isAT_16Mark = false;
    public bool isBT_16Mark = false;
    public bool isAT_15Mark = false;
    public bool isBT_15Mark = false;
    public bool isAT_BullMark = false;
    public bool isBT_BullMark = false;
    public bool is20AllMark = false;
    public bool is19AllMark = false;
    public bool is18AllMark = false;
    public bool is17AllMark = false;
    public bool is16AllMark = false;
    public bool is15AllMark = false;
    public bool isBullAllMark = false;
    public bool isATAllMark = false;
    public bool isBTAllMark = false;

    public bool isAT = true;
    public bool isBT = false;
    public bool isRead = false;
    public bool isSpace = false;
    public bool isWin = false;

    public _CrlcketGameManager gmg;
    public _TARGET_INFO[] m_oDartInfo = new _TARGET_INFO[3];

    void Start()
    {
        Players = 0;
        Teams = 0;
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
        g_P_Ani.SetActive(false);
        g_C_Ani.SetActive(false);

        FirstStart();
        MyTurn();
    }

    void Update()
    {
        MyTurn();
        ImageUp();
        MainMark();
        Comparison();
        /*========================20========================================*/
        if (csSingleton.getInstance.g_bTarget)
        {
            csSingleton.getInstance.g_bTarget = false;

            if (csSingleton.getInstance.g_nTargetBasicScore == 25 || csSingleton.getInstance.g_nTargetBasicScore == 20 || csSingleton.getInstance.g_nTargetBasicScore == 19 || csSingleton.getInstance.g_nTargetBasicScore == 18 ||
            csSingleton.getInstance.g_nTargetBasicScore == 17 || csSingleton.getInstance.g_nTargetBasicScore == 16 || csSingleton.getInstance.g_nTargetBasicScore == 15 && gmg.isAni == false)
            {
                if (Round <= RoundStop && gmg.isAni == false && !isSpace && !isRead && !isWin)
                {
                    if (is20AllMark || is19AllMark || is18AllMark || is17AllMark || is16AllMark || is15AllMark || isBullAllMark)
                        MarkAll();

                    if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_20Mark && !is20AllMark && csSingleton.getInstance.g_nTargetBasicScore == 20)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_19Mark && !is19AllMark && csSingleton.getInstance.g_nTargetBasicScore == 19)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_18Mark && !is18AllMark && csSingleton.getInstance.g_nTargetBasicScore == 18)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_17Mark && !is17AllMark && csSingleton.getInstance.g_nTargetBasicScore == 17)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_16Mark && !is16AllMark && csSingleton.getInstance.g_nTargetBasicScore == 16)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_15Mark && !is15AllMark && csSingleton.getInstance.g_nTargetBasicScore == 15)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_BullMark && !isBullAllMark && csSingleton.getInstance.g_nTargetBasicScore == 25)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                AT1MarkCounting++;
                            else if (Players == 1)
                                AT2MarkCounting++;
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

                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_20Mark && !is20AllMark && csSingleton.getInstance.g_nTargetBasicScore == 20)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_19Mark && !is19AllMark && csSingleton.getInstance.g_nTargetBasicScore == 19)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_18Mark && !is18AllMark && csSingleton.getInstance.g_nTargetBasicScore == 18)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_17Mark && !is17AllMark && csSingleton.getInstance.g_nTargetBasicScore == 17)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_16Mark && !is16AllMark && csSingleton.getInstance.g_nTargetBasicScore == 16)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_15Mark && !is15AllMark && csSingleton.getInstance.g_nTargetBasicScore == 15)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_BullMark && !isBullAllMark && csSingleton.getInstance.g_nTargetBasicScore == 25)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                BT1MarkCounting++;
                            else if (Players == 1)
                                BT2MarkCounting++;
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
                    else if (Counting != 3)
                        LineScore();

                }
                else
                {
                }
            }
            else
            {
                if (csSingleton.getInstance.g_nTargetBasicScore != 20 && csSingleton.getInstance.g_nTargetBasicScore != 19 && csSingleton.getInstance.g_nTargetBasicScore != 18 &&
                 csSingleton.getInstance.g_nTargetBasicScore != 17 && csSingleton.getInstance.g_nTargetBasicScore != 16 && csSingleton.getInstance.g_nTargetBasicScore != 15 &&
                 csSingleton.getInstance.g_nTargetBasicScore != 25 && Counting != 3 && !isSpace && !isRead && !isWin)
                {
                    if (Teams == 0 && Players == 0)
                        AT1MarkCounting++;
                    else if (Teams == 0 && Players == 1)
                        AT2MarkCounting++;
                    if (Teams == 1 && Players == 0)
                        BT1MarkCounting++;
                    else if (Teams == 1 && Players == 1)
                        BT2MarkCounting++;
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
        
        /*==================================================================================================*/
        if (Input.GetKeyDown(KeyCode.Space) && Counting == 4 && !isWin && gmg.isAni != true && isSpace || (csSingleton.getInstance.g_bSwitch
            && csSingleton.getInstance.g_nSwitch == 1005) && Counting == 4 && !isWin && gmg.isAni != true && isSpace)
        {
            if (Players == 0 && isAT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingAT1++;
                isSpace = false;
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
                RoundCountingAT2++;
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
                RoundCountingBT1++;
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
                RScore += 1;
                RoundCountingBT2++;
                isSpace = false;
                gmg.DartScoreReSet();
                RoundRead();
                Invoke("PlayerNumberMinus", 5f);
                Invoke("TeamNumberMinus", 5f);

            }
        }
        if (Round == RoundStop && isBT && Counting == 4)
        {
            GameEndRead();
        }

        if (isATAllMark)
        {
            win = 0;
            isWin = true;
            isAT = true;
            isBT = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isBTAllMark)
        {
            win = 1;
            isWin = true;
            isAT = false;
            isBT = true;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
    }

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
        if (TeamScore[1] < TeamScore[0])
        {
            win = 0;
            isAT = true;
            isBT = false;
            isWin = true;
            WinRead();
        }
        if (TeamScore[0] < TeamScore[1])
        {
            win = 1;
            isBT = true;
            isAT = false;
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
            if (AverageBTotla < AverageATotla)
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
        if (isAT && !isBT )
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

    void Comparison()
    {
        if (isAT_20Mark && isBT_20Mark)
            is20AllMark = true;

        if (isAT_19Mark && isBT_19Mark)
            is19AllMark = true;

        if (isAT_18Mark && isBT_18Mark)
            is18AllMark = true;

        if (isAT_17Mark && isBT_17Mark)
            is17AllMark = true;

        if (isAT_16Mark && isBT_16Mark)
            is16AllMark = true;

        if (isAT_15Mark && isBT_15Mark)
            is15AllMark = true;

        if (isAT_BullMark && isBT_BullMark)
            isBullAllMark = true;
    }

    void MyTurn()
    {
        if (isAT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Team[0].GetComponent<Image>().sprite = s_TeamOn[0];
            g_i_Team[1].GetComponent<Image>().sprite = s_TeamOff[0];

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
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
            }
        }

        if (isAT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Team[0].GetComponent<Image>().sprite = s_TeamOn[1];
            g_i_Team[1].GetComponent<Image>().sprite = s_TeamOff[1];

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
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
            }
        }

        if (isBT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_i_Team[1].GetComponent<Image>().sprite = s_TeamOn[0];
            g_i_Team[0].GetComponent<Image>().sprite = s_TeamOff[0];

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

            g_RoundScore[2].SetActive(true);
            g_MRPScore[2].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreB1[i].enabled = true;
                i_RScoreB2[i].enabled = false;
            }
        }

        if (isBT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_i_Team[1].GetComponent<Image>().sprite = s_TeamOn[1];
            g_i_Team[0].GetComponent<Image>().sprite = s_TeamOff[1];

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

            g_RoundScore[3].SetActive(true);
            g_MRPScore[3].SetActive(true);

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = true;
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

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[4]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[5]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[6]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[7]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[8]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[9]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[10]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[11]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[12]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[13]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[14]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[15]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[16]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[17]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[18]];
            }

            if (RScore == 6)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[6];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[7]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[8]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[9]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[10]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[11]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[12]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[13]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[14]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[15]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[16]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[17]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[18]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[19]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[20]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[21]];
            }

            if (RScore == 7)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[7];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[10]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[11]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[12]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[13]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[14]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[15]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[16]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[17]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[18]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[19]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[20]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[21]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[22]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[23]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[24]];
            }

            if (RScore == 8)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[8];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[13]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[14]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[15]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[16]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[17]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[18]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[19]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[20]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[21]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[22]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[23]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[24]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[25]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[26]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[27]];
            }

            if (RScore == 9)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[9];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[16]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[17]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[18]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[19]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[20]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[21]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[22]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[23]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[24]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[25]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[26]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[27]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[28]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[29]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[30]];
            }

            if (RScore == 10)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[10];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[19]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[20]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[21]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[22]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[23]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[24]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[25]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[26]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[27]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[28]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[29]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[30]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[31]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[32]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[33]];
            }

            if (RScore == 11)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[11];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[22]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[23]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[24]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[25]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[26]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[27]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[28]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[29]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[30]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[31]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[32]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[33]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[34]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[35]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[36]];
            }

            if (RScore == 12)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[12];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[25]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[26]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[27]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[28]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[29]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[30]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[31]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[32]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[33]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[34]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[35]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[36]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[37]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[38]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[39]];
            }

            if (RScore == 13)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[13];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[28]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[29]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[30]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[31]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[32]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[33]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[34]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[35]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[36]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[37]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[38]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[39]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[40]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[41]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[42]];
            }

            if (RScore == 14)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[14];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[31]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[32]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[33]];
            
                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[34]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[35]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[36]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[37]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[38]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[39]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[40]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[41]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[42]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[43]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[44]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[45]];
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

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[4]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[5]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[6]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[7]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[8]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[9]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[10]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[11]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[12]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[13]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[14]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[15]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[16]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[17]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[18]];
            }

            if (RScore == 6)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[6];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[7]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[8]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[9]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[10]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[11]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[12]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[13]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[14]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[15]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[16]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[17]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[18]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[19]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[20]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[21]];
            }

            if (RScore == 7)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[7];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[10]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[11]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[12]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[13]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[14]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[15]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[16]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[17]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[18]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[19]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[20]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[21]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[22]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[23]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[24]];
            }

            if (RScore == 8)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[8];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[13]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[14]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[15]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[16]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[17]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[18]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[19]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[20]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[21]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[22]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[23]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[24]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[25]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[26]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[27]];
            }

            if (RScore == 9)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[9];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[16]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[17]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[18]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[19]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[20]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[21]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[22]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[23]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[24]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[25]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[26]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[27]];
            
                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[28]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[29]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[30]];
            }

            if (RScore == 10)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[10];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[19]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[20]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[21]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[22]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[23]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[24]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[25]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[26]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[27]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[28]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[29]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[30]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[31]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[32]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[33]];
            }

            if (RScore == 11)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[11];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[22]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[23]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[24]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[25]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[26]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[27]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[28]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[29]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[30]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[31]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[32]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[33]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[34]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[35]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[36]];
            }

            if (RScore == 12)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[12];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[25]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[26]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[27]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[28]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[29]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[30]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[31]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[32]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[33]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[34]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[35]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[36]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[37]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[38]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[39]];
            }

            if (RScore == 13)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[13];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[28]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[29]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[30]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[31]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[32]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[33]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[34]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[35]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[36]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[37]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[38]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[39]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[40]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[41]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[42]];
            }

            if (RScore == 14)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[14];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[31]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[32]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[33]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[34]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[35]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[36]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[37]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[38]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[39]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[40]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[41]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[42]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[43]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[44]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[45]];
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

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[4]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[5]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[6]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[7]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[8]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[9]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[10]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[11]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[12]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[13]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[14]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[15]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[16]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[17]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[18]];
            }
        
            if (RScore == 6)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[6];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[7]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[8]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[9]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[10]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[11]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[12]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[13]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[14]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[15]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[16]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[17]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[18]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[19]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[20]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[21]];
            }

            if (RScore == 7)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[7];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[10]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[11]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[12]];
            
                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[13]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[14]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[15]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[16]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[17]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[18]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[19]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[20]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[21]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[22]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[23]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[24]];
            }

            if (RScore == 8)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[8];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[13]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[14]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[15]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[16]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[17]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[18]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[19]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[20]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[21]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[22]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[23]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[24]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[25]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[26]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[27]];
            }

            if (RScore == 9)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[9];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[16]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[17]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[18]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[19]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[20]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[21]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[22]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[23]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[24]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[25]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[26]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[27]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[28]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[29]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[30]];
            }

            if (RScore == 10)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[10];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[19]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[20]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[21]];
            
                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[22]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[23]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[24]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[25]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[26]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[27]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[28]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[29]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[30]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[31]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[32]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[33]];
            }

            if (RScore == 11)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[11];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[22]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[23]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[24]];
            
                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[25]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[26]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[27]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[28]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[29]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[30]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[31]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[32]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[33]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[34]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[35]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[36]];
            }

            if (RScore == 12)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[12];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[25]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[26]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[27]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[28]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[29]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[30]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[31]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[32]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[33]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[34]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[35]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[36]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[37]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[38]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[39]];
            }

            if (RScore == 13)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[13];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[28]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[29]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[30]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[31]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[32]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[33]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[34]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[35]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[36]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[37]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[38]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[39]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[40]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[41]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[42]];
            }

            if (RScore == 14)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[14];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[31]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[32]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[33]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[34]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[35]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[36]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[37]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[38]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[39]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[40]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[41]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[42]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[43]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[44]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[45]];
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

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[4]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[5]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[6]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[7]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[8]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[9]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[10]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[11]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[12]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[13]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[14]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[15]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[16]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[17]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[18]];
            }

            if (RScore == 6)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[6];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[7]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[8]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[9]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[10]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[11]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[12]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[13]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[14]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[15]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[16]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[17]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[18]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[19]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[20]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[21]];
            }

            if (RScore == 7)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[7];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[10]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[11]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[12]];
            
                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[13]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[14]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[15]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[16]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[17]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[18]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[19]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[20]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[21]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[22]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[23]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[24]];
            }

            if (RScore == 8)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[8];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[13]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[14]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[15]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[16]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[17]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[18]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[19]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[20]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[21]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[22]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[23]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[24]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[25]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[26]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[27]];
            }

            if (RScore == 9)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[9];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[16]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[17]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[18]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[19]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[20]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[21]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[22]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[23]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[24]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[25]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[26]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[27]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[28]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[29]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[30]];
            }

            if (RScore == 10)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[10];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[19]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[20]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[21]];
            
                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[22]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[23]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[24]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[25]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[26]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[27]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[28]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[29]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[30]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[31]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[32]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[33]];
            }

            if (RScore == 11)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[11];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[22]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[23]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[24]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[25]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[26]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[27]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[28]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[29]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[30]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[31]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[32]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[33]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[34]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[35]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[36]];
            }

            if (RScore == 12)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[12];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[25]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[26]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[27]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[28]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[29]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[30]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[31]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[32]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[33]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[34]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[35]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[36]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[37]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[38]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[39]];
            }

            if (RScore == 13)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[13];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[28]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[29]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[30]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[31]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[32]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[33]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[34]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[35]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[36]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[37]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[38]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[39]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[40]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[41]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[42]];
            }

            if (RScore == 14)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[14];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[31]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[32]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[33]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[34]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[35]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[36]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[37]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[38]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[39]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[40]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[41]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[42]];
            
                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[43]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[44]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[45]];
            }
        }
    }
    void RoundScore(int MarkScore)
    {
        if (isAT && !isBT && Players == 0)
        {
            MarkSaveA1[AT1MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_AT1RMark1[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[AT1MarkCounting]];

                if (RScore == 1)
                    g_AT1RMark2[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[AT1MarkCounting]];

                if (RScore == 2)
                    g_AT1RMark3[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[AT1MarkCounting]];

                if (RScore == 3)
                    g_AT1RMark4[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[AT1MarkCounting]];

                if (RScore == 4)
                    g_AT1RMark5[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[AT1MarkCounting]];

                if (RScore == 5)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[4]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[5]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[6]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[7]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[8]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[9]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[10]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[11]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[12]];
                
                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[13]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[14]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[15]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[16]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[17]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[18]];
                }

                if (RScore == 6)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[7]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[8]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[9]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[10]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[11]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[12]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[13]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[14]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[15]];
                
                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[16]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[17]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[18]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[19]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[20]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[21]];
                }

                if (RScore == 7)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[10]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[11]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[12]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[13]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[14]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[15]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[16]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[17]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[18]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[19]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[20]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[21]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[22]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[23]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[24]];
                }

                if (RScore == 8)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[13]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[14]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[15]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[16]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[17]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[18]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[19]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[20]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[21]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[22]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[23]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[24]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[25]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[26]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[27]];

                }
                if (RScore == 9)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[16]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[17]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[18]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[19]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[20]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[21]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[22]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[23]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[24]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[25]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[26]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[27]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[28]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[29]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[30]];
                }

                if (RScore == 10)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[19]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[20]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[21]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[22]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[23]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[24]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[25]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[26]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[27]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[28]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[29]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[30]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[31]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[32]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[33]];
                }

                if (RScore == 11)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[22]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[23]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[24]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[25]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[26]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[27]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[28]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[29]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[30]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[31]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[32]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[33]];
                
                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[34]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[35]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[36]];
                }

                if (RScore == 12)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[25]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[26]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[27]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[28]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[29]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[30]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[31]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[32]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[33]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[34]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[35]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[36]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[37]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[38]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[39]];
                }

                if (RScore == 13)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[28]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[29]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[30]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[31]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[32]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[33]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[34]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[35]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[36]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[37]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[38]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[39]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[40]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[41]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[42]];
                }
                if (RScore == 14)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[31]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[32]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[33]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[34]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[35]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[36]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[37]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[38]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[39]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[40]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[41]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[42]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[43]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[44]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA1[45]];
                }
            }
        }

        else if (isAT && !isBT && Players == 1)
        {
            MarkSaveA2[AT2MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_AT2RMark1[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[AT2MarkCounting]];

                if (RScore == 1)
                    g_AT2RMark2[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[AT2MarkCounting]];

                if (RScore == 2)
                    g_AT2RMark3[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[AT2MarkCounting]];

                if (RScore == 3)
                    g_AT2RMark4[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[AT2MarkCounting]];

                if (RScore == 4)
                    g_AT2RMark5[Counting].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[AT2MarkCounting]];

                if (RScore == 5)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[4]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[5]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[6]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[7]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[8]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[9]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[10]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[11]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[12]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[13]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[14]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[15]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[16]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[17]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[18]];
                }

                if (RScore == 6)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[7]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[8]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[9]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[10]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[11]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[12]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[13]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[14]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[15]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[16]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[17]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[18]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[19]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[20]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[21]];
                }

                if (RScore == 7)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[10]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[11]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[12]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[13]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[14]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[15]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[16]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[17]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[18]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[19]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[20]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[21]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[22]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[23]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[24]];
                }

                if (RScore == 8)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[13]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[14]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[15]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[16]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[17]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[18]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[19]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[20]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[21]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[22]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[23]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[24]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[25]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[26]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[27]];
                }

                if (RScore == 9)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[16]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[17]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[18]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[19]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[20]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[21]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[22]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[23]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[24]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[25]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[26]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[27]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[28]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[29]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[30]];
                }

                if (RScore == 10)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[19]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[20]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[21]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[22]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[23]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[24]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[25]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[26]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[27]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[28]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[29]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[30]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[31]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[32]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[33]];
                }

                if (RScore == 11)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[22]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[23]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[24]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[25]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[26]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[27]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[28]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[29]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[30]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[31]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[32]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[33]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[34]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[35]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[36]];
                }

                if (RScore == 12)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[25]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[26]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[27]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[28]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[29]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[30]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[31]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[32]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[33]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[34]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[35]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[36]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[37]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[38]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[39]];
                }

                if (RScore == 13)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[28]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[29]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[30]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[31]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[32]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[33]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[34]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[35]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[36]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[37]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[38]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[39]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[40]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[41]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[42]];
                }

                if (RScore == 14)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[31]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[32]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[33]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[34]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[35]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[36]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[37]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[38]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[39]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[40]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[41]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[42]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[43]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[44]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveA2[45]];
                }
            }
        }

        else if (isBT && !isAT && Players == 0)
        {
            MarkSaveB1[BT1MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_BT1RMark1[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[BT1MarkCounting]];

                if (RScore == 1)
                    g_BT1RMark2[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[BT1MarkCounting]];

                if (RScore == 2)
                    g_BT1RMark3[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[BT1MarkCounting]];

                if (RScore == 3)
                    g_BT1RMark4[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[BT1MarkCounting]];

                if (RScore == 4)
                    g_BT1RMark5[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[BT1MarkCounting]];

                if (RScore == 5)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[4]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[5]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[6]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[7]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[8]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[9]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[10]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[11]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[12]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[13]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[14]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[15]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[16]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[17]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[18]];
                }

                if (RScore == 6)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[7]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[8]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[9]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[10]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[11]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[12]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[13]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[14]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[15]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[16]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[17]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[18]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[19]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[20]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[21]];
                }

                if (RScore == 7)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[10]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[11]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[12]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[13]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[14]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[15]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[16]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[17]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[18]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[19]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[20]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[21]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[22]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[23]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[24]];
                }

                if (RScore == 8)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[13]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[14]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[15]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[16]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[17]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[18]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[19]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[20]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[21]];
                
                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[22]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[23]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[24]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[25]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[26]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[27]];

                }
                if (RScore == 9)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[16]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[17]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[18]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[19]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[20]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[21]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[22]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[23]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[24]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[25]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[26]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[27]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[28]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[29]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[30]];
                }

                if (RScore == 10)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[19]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[20]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[21]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[22]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[23]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[24]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[25]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[26]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[27]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[28]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[29]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[30]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[31]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[32]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[33]];
                }

                if (RScore == 11)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[22]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[23]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[24]];
                
                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[25]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[26]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[27]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[28]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[29]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[30]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[31]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[32]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[33]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[34]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[35]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[36]];
                }

                if (RScore == 12)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[25]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[26]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[27]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[28]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[29]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[30]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[31]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[32]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[33]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[34]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[35]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[36]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[37]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[38]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[39]];
                }

                if (RScore == 13)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[28]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[29]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[30]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[31]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[32]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[33]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[34]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[35]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[36]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[37]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[38]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[39]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[40]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[41]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[42]];
                }
                if (RScore == 14)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[31]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[32]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[33]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[34]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[35]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[36]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[37]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[38]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[39]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[40]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[41]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[42]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[43]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[44]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB1[45]];
                }
            }
        }

        else if (isBT && !isAT && Players == 1)
        {
            MarkSaveB2[BT2MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_BT2RMark1[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[BT2MarkCounting]];

                if (RScore == 1)
                    g_BT2RMark2[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[BT2MarkCounting]];

                if (RScore == 2)
                    g_BT2RMark3[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[BT2MarkCounting]];

                if (RScore == 3)
                    g_BT2RMark4[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[BT2MarkCounting]];

                if (RScore == 4)
                    g_BT2RMark5[Counting].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[BT2MarkCounting]];

                if (RScore == 5)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[4]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[5]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[6]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[7]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[8]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[9]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[10]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[11]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[12]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[13]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[14]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[15]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[16]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[17]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[18]];
                }

                if (RScore == 6)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[7]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[8]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[9]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[10]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[11]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[12]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[13]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[14]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[15]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[16]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[17]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[18]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[19]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[20]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[21]];
                }

                if (RScore == 7)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[10]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[11]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[12]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[13]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[14]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[15]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[16]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[17]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[18]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[19]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[20]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[21]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[22]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[23]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[24]];
                }

                if (RScore == 8)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[13]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[14]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[15]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[16]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[17]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[18]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[19]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[20]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[21]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[22]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[23]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[24]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[25]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[26]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[27]];

                }
                if (RScore == 9)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[16]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[17]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[18]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[19]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[20]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[21]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[22]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[23]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[24]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[25]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[26]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[27]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[28]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[29]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[30]];
                }

                if (RScore == 10)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[19]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[20]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[21]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[22]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[23]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[24]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[25]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[26]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[27]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[28]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[29]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[30]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[31]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[32]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[33]];
                }

                if (RScore == 11)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[22]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[23]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[24]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[25]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[26]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[27]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[28]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[29]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[30]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[31]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[32]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[33]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[34]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[35]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[36]];
                }

                if (RScore == 12)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[25]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[26]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[27]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[28]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[29]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[30]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[31]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[32]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[33]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[34]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[35]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[36]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[37]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[38]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[39]];
                }

                if (RScore == 13)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[28]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[29]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[30]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[31]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[32]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[33]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[34]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[35]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[36]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[37]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[38]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[39]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[40]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[41]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[42]];
                }
                if (RScore == 14)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[31]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[32]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[33]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[34]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[35]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[36]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[37]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[38]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[39]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[40]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[41]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[42]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[43]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[44]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveB2[45]];
                }
            }
        }

    }

    void MainMark()
    {
        if (AT_20Mark == 40)
            g_ATMainMark[0].GetComponent<Image>().sprite = s_ATMark[1];
        if (AT_20Mark == 20)
            g_ATMainMark[0].GetComponent<Image>().sprite = s_ATMark[2];
        if (AT_20Mark <= 0)
            g_ATMainMark[0].GetComponent<Image>().sprite = s_ATMark[3];

        if (AT_19Mark == 38)
            g_ATMainMark[1].GetComponent<Image>().sprite = s_ATMark[1];
        if (AT_19Mark == 19)
            g_ATMainMark[1].GetComponent<Image>().sprite = s_ATMark[2];
        if (AT_19Mark <= 0)
            g_ATMainMark[1].GetComponent<Image>().sprite = s_ATMark[3];

        if (AT_18Mark == 36)
            g_ATMainMark[2].GetComponent<Image>().sprite = s_ATMark[1];
        if (AT_18Mark == 18)
            g_ATMainMark[2].GetComponent<Image>().sprite = s_ATMark[2];
        if (AT_18Mark <= 0)
            g_ATMainMark[2].GetComponent<Image>().sprite = s_ATMark[3];

        if (AT_17Mark == 34)
            g_ATMainMark[3].GetComponent<Image>().sprite = s_ATMark[1];
        if (AT_17Mark == 17)
            g_ATMainMark[3].GetComponent<Image>().sprite = s_ATMark[2];
        if (AT_17Mark <= 0)
            g_ATMainMark[3].GetComponent<Image>().sprite = s_ATMark[3];

        if (AT_16Mark == 32)
            g_ATMainMark[4].GetComponent<Image>().sprite = s_ATMark[1];
        if (AT_16Mark == 16)
            g_ATMainMark[4].GetComponent<Image>().sprite = s_ATMark[2];
        if (AT_16Mark <= 0)
            g_ATMainMark[4].GetComponent<Image>().sprite = s_ATMark[3];

        if (AT_15Mark == 30)
            g_ATMainMark[5].GetComponent<Image>().sprite = s_ATMark[1];
        if (AT_15Mark == 15)
            g_ATMainMark[5].GetComponent<Image>().sprite = s_ATMark[2];
        if (AT_15Mark <= 0)
            g_ATMainMark[5].GetComponent<Image>().sprite = s_ATMark[3];

        if (AT_BullMark == 50)
            g_ATMainMark[6].GetComponent<Image>().sprite = s_ATMark[1];
        if (AT_BullMark == 25)
            g_ATMainMark[6].GetComponent<Image>().sprite = s_ATMark[2];
        if (AT_BullMark <= 0)
            g_ATMainMark[6].GetComponent<Image>().sprite = s_ATMark[3];

        /*=======================BBB==================================*/
        if (BT_20Mark == 40)
            g_BTMainMark[0].GetComponent<Image>().sprite = s_BTMark[1];
        if (BT_20Mark == 20)
            g_BTMainMark[0].GetComponent<Image>().sprite = s_BTMark[2];
        if (BT_20Mark <= 0)
            g_BTMainMark[0].GetComponent<Image>().sprite = s_BTMark[3];

        if (BT_19Mark == 38)
            g_BTMainMark[1].GetComponent<Image>().sprite = s_BTMark[1];
        if (BT_19Mark == 19)
            g_BTMainMark[1].GetComponent<Image>().sprite = s_BTMark[2];
        if (BT_19Mark <= 0)
            g_BTMainMark[1].GetComponent<Image>().sprite = s_BTMark[3];

        if (BT_18Mark == 36)
            g_BTMainMark[2].GetComponent<Image>().sprite = s_BTMark[1];
        if (BT_18Mark == 18)
            g_BTMainMark[2].GetComponent<Image>().sprite = s_BTMark[2];
        if (BT_18Mark <= 0)
            g_BTMainMark[2].GetComponent<Image>().sprite = s_BTMark[3];

        if (BT_17Mark == 34)
            g_BTMainMark[3].GetComponent<Image>().sprite = s_BTMark[1];
        if (BT_17Mark == 17)
            g_BTMainMark[3].GetComponent<Image>().sprite = s_BTMark[2];
        if (BT_17Mark <= 0)
            g_BTMainMark[3].GetComponent<Image>().sprite = s_BTMark[3];

        if (BT_16Mark == 32)
            g_BTMainMark[4].GetComponent<Image>().sprite = s_BTMark[1];
        if (BT_16Mark == 16)
            g_BTMainMark[4].GetComponent<Image>().sprite = s_BTMark[2];
        if (BT_16Mark <= 0)
            g_BTMainMark[4].GetComponent<Image>().sprite = s_BTMark[3];

        if (BT_15Mark == 30)
            g_BTMainMark[5].GetComponent<Image>().sprite = s_BTMark[1];
        if (BT_15Mark == 15)
            g_BTMainMark[5].GetComponent<Image>().sprite = s_BTMark[2];
        if (BT_15Mark <= 0)
            g_BTMainMark[5].GetComponent<Image>().sprite = s_BTMark[3];

        if (BT_BullMark == 50)
            g_BTMainMark[6].GetComponent<Image>().sprite = s_BTMark[1];
        if (BT_BullMark == 25)
            g_BTMainMark[6].GetComponent<Image>().sprite = s_BTMark[2];
        if (BT_BullMark <= 0)
            g_BTMainMark[6].GetComponent<Image>().sprite = s_BTMark[3];

        if (isAT_20Mark && isBT_20Mark)
        {
            g_Fishbar[0].SetActive(true);
            g_ATMainMark[0].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[0].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isAT_19Mark && isBT_19Mark)
        {
            g_Fishbar[1].SetActive(true);
            g_ATMainMark[1].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[1].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isAT_18Mark && isBT_18Mark)
        {
            g_Fishbar[2].SetActive(true);
            g_ATMainMark[2].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[2].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isAT_17Mark && isBT_17Mark)
        {
            g_Fishbar[3].SetActive(true);
            g_ATMainMark[3].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[3].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isAT_16Mark && isBT_16Mark)
        {
            g_Fishbar[4].SetActive(true);
            g_ATMainMark[4].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[4].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isAT_15Mark && isBT_15Mark)
        {
            g_Fishbar[5].SetActive(true);
            g_ATMainMark[5].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[5].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isAT_BullMark && isBT_BullMark)
        {
            g_Fishbar[6].SetActive(true);
            g_ATMainMark[6].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[6].GetComponent<Image>().sprite = s_OffMark;
        }

        if (isAT_20Mark && isAT_19Mark && isAT_18Mark && isAT_17Mark && isAT_16Mark && isAT_15Mark && isAT_BullMark)
            isATAllMark = true;

        if (isBT_20Mark && isBT_19Mark && isBT_18Mark && isBT_17Mark && isBT_16Mark && isBT_15Mark && isBT_BullMark)
            isBTAllMark = true;
    }

    void LineScore()
    {
        if (Counting != 3 && gmg.isAni == false)
        {
            /*-----------------------------------------------------------------*/
            if (Teams == 0 && !isAT_20Mark && csSingleton.getInstance.g_nTargetBasicScore == 20)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                AT_20Mark -= csSingleton.getInstance.g_nTargetScore;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 0 && !isAT_19Mark && csSingleton.getInstance.g_nTargetBasicScore == 19)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_19Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 0 && !isAT_18Mark && csSingleton.getInstance.g_nTargetBasicScore == 18)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_18Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 0 && !isAT_17Mark && csSingleton.getInstance.g_nTargetBasicScore == 17)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_17Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 0 && !isAT_16Mark && csSingleton.getInstance.g_nTargetBasicScore == 16)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_16Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 0 && !isAT_15Mark && csSingleton.getInstance.g_nTargetBasicScore == 15)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_15Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 0 && !isAT_BullMark && csSingleton.getInstance.g_nTargetBasicScore == 25)
            {
                if (Players == 0)
                    AT1MarkCounting++;
                else if (Players == 1)
                    AT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                AT_BullMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            /*-----------------------------------------------------------------*/
            if (Teams == 1 && !isBT_20Mark && csSingleton.getInstance.g_nTargetBasicScore == 20)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_20Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 1 && !isBT_19Mark && csSingleton.getInstance.g_nTargetBasicScore == 19)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_19Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 1 && !isBT_18Mark && csSingleton.getInstance.g_nTargetBasicScore == 18)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_18Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 1 && !isBT_17Mark && csSingleton.getInstance.g_nTargetBasicScore == 17)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_17Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 1 && !isBT_16Mark && csSingleton.getInstance.g_nTargetBasicScore == 16)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_16Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 1 && !isBT_15Mark && csSingleton.getInstance.g_nTargetBasicScore == 15)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_15Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Teams == 1 && !isBT_BullMark && csSingleton.getInstance.g_nTargetBasicScore == 25)
            {
                if (Players == 0)
                    BT1MarkCounting++;
                else if (Players == 1)
                    BT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                BT_BullMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            /*-----------------------------------------------------------------*/
            if (AT_20Mark <= 0 && !isAT_20Mark)
            {
                if (!isBT_20Mark)
                {
                    AT_20Mark *= -1;
                    TeamScore[0] += AT_20Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                isAT_20Mark = true;
                AT_20Mark = 0;
            }
            else if (AT_19Mark <= 0 && !isAT_19Mark)
            {
                if (!isBT_19Mark)
                {
                    AT_19Mark *= -1;
                    TeamScore[0] += AT_19Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                isAT_19Mark = true;
                AT_19Mark = 0;
            }
            else if (AT_18Mark <= 0 && !isAT_18Mark)
            {
                if (!isBT_18Mark)
                {
                    AT_18Mark *= -1;
                    TeamScore[0] += AT_18Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                isAT_18Mark = true;
                AT_18Mark = 0;
            }
            else if (AT_17Mark <= 0 && !isAT_17Mark)
            {
                if (!isBT_17Mark)
                {
                    AT_17Mark *= -1;
                    TeamScore[0] += AT_17Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                isAT_17Mark = true;
                AT_17Mark = 0;
            }
            else if (AT_16Mark <= 0 && !isAT_16Mark)
            {
                if (!isBT_16Mark)
                {
                    AT_16Mark *= -1;
                    TeamScore[0] += AT_16Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                isAT_16Mark = true;
                AT_16Mark = 0;
            }
            else if (AT_15Mark <= 0 && !isAT_15Mark)
            {
                if (!isBT_15Mark)
                {
                    AT_15Mark *= -1;
                    TeamScore[0] += AT_15Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }

                isAT_15Mark = true;
                AT_15Mark = 0;
            }
            else if (AT_BullMark <= 0 && !isAT_BullMark)
            {
                if (!isBT_BullMark)
                {
                    AT_BullMark *= -1;
                    TeamScore[0] += AT_BullMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                isAT_BullMark = true;
                AT_BullMark = 0;
            }
            /*-----------------------------------------------------------------*/
            else if (BT_20Mark <= 0 && !isBT_20Mark)
            {
                if (!isAT_20Mark)
                {
                    BT_20Mark *= -1;
                    TeamScore[1] += BT_20Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                isBT_20Mark = true;
                BT_20Mark = 0;
            }
            else if (BT_19Mark <= 0 && !isBT_19Mark)
            {
                if (!isAT_19Mark)
                {
                    BT_19Mark *= -1;
                    TeamScore[1] += BT_19Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                isBT_19Mark = true;
                BT_19Mark = 0;
            }
            else if (BT_18Mark <= 0 && !isBT_18Mark)
            {
                if (!isAT_18Mark)
                {
                    BT_18Mark *= -1;
                    TeamScore[1] += BT_18Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                isBT_18Mark = true;
                BT_18Mark = 0;
            }
            else if (BT_17Mark <= 0 && !isBT_17Mark)
            {
                if (!isAT_17Mark)
                {
                    BT_17Mark *= -1;
                    TeamScore[1] += BT_17Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                isBT_17Mark = true;
                BT_17Mark = 0;
            }
            else if (BT_16Mark <= 0 && !isBT_16Mark)
            {
                if (!isAT_16Mark)
                {
                    BT_16Mark *= -1;
                    TeamScore[1] += BT_16Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                isBT_16Mark = true;
                BT_16Mark = 0;
            }
            else if (BT_15Mark <= 0 && !isBT_15Mark)
            {
                if (!isAT_15Mark)
                {
                    BT_15Mark *= -1;
                    TeamScore[1] += BT_15Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                isBT_15Mark = true;
                BT_15Mark = 0;
            }
            else if (BT_BullMark <= 0 && !isBT_BullMark)
            {
                if (!isAT_BullMark)
                {
                    BT_BullMark *= -1;
                    TeamScore[1] += BT_BullMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                isBT_BullMark = true;
                BT_BullMark = 0;
            }
            /*-----------------------------------------------------------------*/

        }
    }
    void MarkAll()
    {
        if (csSingleton.getInstance.g_nTargetBasicScore == 25 && isBullAllMark)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == 20 && is20AllMark)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == 19 && is19AllMark)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == 18 && is18AllMark)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == 17 && is17AllMark)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == 16 && is16AllMark)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == 15 && is15AllMark)
        {
            if (Teams == 0 && Players == 0)
                AT1MarkCounting++;
            else if (Teams == 0 && Players == 1)
                AT2MarkCounting++;
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
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
        g_C_Ani.SetActive(false);
        Counting = 0;
        Teams = 0;
    }

    void PlayerNumberPlus()
    {
        g_C_Ani.SetActive(false);
        Counting = 0;
        Players = 1;
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
        RoundCountingAT1 = 1;
        RoundCountingAT2 = 1;
        RoundCountingBT1 = 1;
        RoundCountingBT2 = 1;
        Round = 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
    }
    void MPRScore(int Dart)
    {
        if (Teams == 0 && Players == 0)
        {
            TotalA1 += Dart;
            AverageA1 = TotalA1 / RoundCountingAT1;
            t_MPRText1.text = string.Format("{0:N2}", AverageA1);
        }
        if (Teams == 0 && Players == 1)
        {
            TotalA2 += Dart;
            AverageA2 = TotalA2 / RoundCountingAT2;
            t_MPRText2.text = string.Format("{0:N2}", AverageA2);
        }
        if (Teams == 1 && Players == 0)
        {
            TotalB1 += Dart;
            AverageB1 = TotalB1 / RoundCountingBT1;
            t_MPRText3.text = string.Format("{0:N2}", AverageB1);
        }
        if (Teams == 1 && Players == 1)
        {
            TotalB2 += Dart;
            AverageB2 = TotalB2 / RoundCountingBT2;
            t_MPRText4.text = string.Format("{0:N2}", AverageB2);
        }

        if (Teams == 0)
            AverageATotla = AverageA1 + AverageA2 / 2;
        if (Teams == 1)
            AverageBTotla = AverageB1 + AverageB2 / 2;
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
