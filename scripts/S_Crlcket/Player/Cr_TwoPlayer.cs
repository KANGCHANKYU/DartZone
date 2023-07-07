using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Cr_TwoPlayer : MonoBehaviour
{
    public Text t_RoundText;
    public Text t_MPRText1;
    public Text t_MPRText2;

    public GameObject[] g_P1RMark1 = new GameObject[3];
    public GameObject[] g_P1RMark2 = new GameObject[3];
    public GameObject[] g_P1RMark3 = new GameObject[3];
    public GameObject[] g_P1RMark4 = new GameObject[3];
    public GameObject[] g_P1RMark5 = new GameObject[3];
    public GameObject[] g_P2RMark1 = new GameObject[3];
    public GameObject[] g_P2RMark2 = new GameObject[3];
    public GameObject[] g_P2RMark3 = new GameObject[3];
    public GameObject[] g_P2RMark4 = new GameObject[3];
    public GameObject[] g_P2RMark5 = new GameObject[3];
    public GameObject[] g_P1MainMark = new GameObject[7];
    public GameObject[] g_P2MainMark = new GameObject[7];
    public GameObject[] g_i_Player = new GameObject[2];
    public GameObject[] g_Dart = new GameObject[3];
    public GameObject[] g_RoundScore = new GameObject[2];
    public GameObject[] g_MRPScore = new GameObject[2];
    public GameObject[] g_RoundNum = new GameObject[15];
    public GameObject[] g_P_Score = new GameObject[2];
    public GameObject[] g_OffScore = new GameObject[2];
    public GameObject[] g_Fishbar = new GameObject[7];
    public GameObject g_P1;
    public GameObject g_P2;
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
    public Sprite[] s_PlayerOn = new Sprite[2];
    public Sprite[] s_PlayerOff = new Sprite[2];
    public Sprite[] s_PlayerbarOn = new Sprite[2];
    public Sprite[] s_PlayerbarOff = new Sprite[2];
    public Sprite[] s_P1Mark = new Sprite[4];
    public Sprite[] s_P2Mark = new Sprite[4];
    public Sprite s_OffMark;

    public Image[] i_RScore1 = new Image[5];
    public Image[] i_RScore2 = new Image[5];

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int RoundStop;

    public int[] PlayerScore = new int[2];
    public int[] MarkSaveP1 = new int[45];
    public int[] MarkSaveP2 = new int[45];
    public int[] DartBasicScore = new int[3];
    public int P1MarkCounting = 0;
    public int P2MarkCounting = 0;
    public int Counting = 0;
    public int Round = 0;
    public int RoundCountingP1 = 0;
    public int RoundCountingP2 = 0;
    public int TotalP1 = 0;
    public int TotalP2 = 0;
    public int RScore = 0;
    public int Players = 0;
    public int win = 0;

    public int P1_20Mark = 60;
    public int P1_19Mark = 57;
    public int P1_18Mark = 54;
    public int P1_17Mark = 51;
    public int P1_16Mark = 48;
    public int P1_15Mark = 45;
    public int P1_BullMark = 75;
    public int P2_20Mark = 60;
    public int P2_19Mark = 57;
    public int P2_18Mark = 54;
    public int P2_17Mark = 51;
    public int P2_16Mark = 48;
    public int P2_15Mark = 45;
    public int P2_BullMark = 75;

    public float Average1 = 0;
    public float Average2 = 0;

    public string[] playername = new string[2];

    public bool isP1_20Mark = false;
    public bool isP2_20Mark = false;
    public bool isP1_19Mark = false;
    public bool isP2_19Mark = false;
    public bool isP1_18Mark = false;
    public bool isP2_18Mark = false;
    public bool isP1_17Mark = false;
    public bool isP2_17Mark = false;
    public bool isP1_16Mark = false;
    public bool isP2_16Mark = false;
    public bool isP1_15Mark = false;
    public bool isP2_15Mark = false;
    public bool isP1_BullMark = false;
    public bool isP2_BullMark = false;
    public bool is20AllMark = false;
    public bool is19AllMark = false;
    public bool is18AllMark = false;
    public bool is17AllMark = false;
    public bool is16AllMark = false;
    public bool is15AllMark = false;
    public bool isBullAllMark = false;
    public bool isP1AllMark = false;
    public bool isP2AllMark = false;
    public bool isP1 = true;
    public bool isP2 = false;
    public bool isRead = false;
    public bool isSpace = false;
    public bool isWin = false;

    public _CrlcketGameManager gmg;
    public _TARGET_INFO[] m_oDartInfo = new _TARGET_INFO[3];

    void Start()
    {
        Players = 0;
        for (int i = 0; i < g_RoundNum.Length; i++)
            g_RoundNum[i].SetActive(false);
        for (int i = 0; i < g_Fishbar.Length; i++)
            g_Fishbar[i].SetActive(false);
        for (int i = 0; i < g_P_Score.Length; i++)
        {
            g_P_Score[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.75f, 0);
            g_OffScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.75f, 0);
            g_P_Score[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
            g_OffScore[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
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

                    if (Players == 0 && !isRead && !isSpace && !isWin && isP1_20Mark && !is20AllMark && csSingleton.getInstance.g_nTargetBasicScore == 20)
                    {
                        if (Counting == 0)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_19Mark && !is19AllMark && csSingleton.getInstance.g_nTargetBasicScore == 19)
                    {
                        if (Counting == 0)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_18Mark && !is18AllMark && csSingleton.getInstance.g_nTargetBasicScore == 18)
                    {
                        if (Counting == 0)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_17Mark && !is17AllMark && csSingleton.getInstance.g_nTargetBasicScore == 17)
                    {
                        if (Counting == 0)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_16Mark && !is16AllMark && csSingleton.getInstance.g_nTargetBasicScore == 16)
                    {
                        if (Counting == 0)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_15Mark && !is15AllMark && csSingleton.getInstance.g_nTargetBasicScore == 15)
                    {
                        if (Counting == 0)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_BullMark && !isBullAllMark && csSingleton.getInstance.g_nTargetBasicScore == 25)
                    {
                        if (Counting == 0)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P1MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[0] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_20Mark && !is20AllMark && csSingleton.getInstance.g_nTargetBasicScore == 20)
                    {
                        if (Counting == 0)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_19Mark && !is19AllMark && csSingleton.getInstance.g_nTargetBasicScore == 19)
                    {
                        if (Counting == 0)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_18Mark && !is18AllMark && csSingleton.getInstance.g_nTargetBasicScore == 18)
                    {
                        if (Counting == 0)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_17Mark && !is17AllMark && csSingleton.getInstance.g_nTargetBasicScore == 17)
                    {
                        if (Counting == 0)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_16Mark && !is16AllMark && csSingleton.getInstance.g_nTargetBasicScore == 16)
                    {
                        if (Counting == 0)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_15Mark && !is15AllMark && csSingleton.getInstance.g_nTargetBasicScore == 15)
                    {
                        if (Counting == 0)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_BullMark && !isBullAllMark && csSingleton.getInstance.g_nTargetBasicScore == 25)
                    {
                        if (Counting == 0)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            P2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            PlayerScore[1] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
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
                    if (Players == 0)
                        P1MarkCounting++;
                    else if (Players == 1)
                        P2MarkCounting++;
                    a_source.PlayOneShot(ac_shoot1, 1.0f);
                    MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                    RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                    g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
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
        if (Input.GetKeyDown(KeyCode.Space) && Counting == 4 && !isWin && gmg.isAni != true && isSpace)
        {
            if (Players == 0 && isP1)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingP1++;
                isSpace = false;
                gmg.DartScoreReSet();
                Invoke("PlayerNumberPlus", 5f);
            }
            if (Players == 1 && isP2)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RScore += 1;
                RoundCountingP2++;
                isSpace = false;
                gmg.DartScoreReSet();
                RoundRead();
                Invoke("PlayerNumberMinus", 5f);

            }
        }
        if (Round == RoundStop && isP2 && Counting == 4)
            GameEndRead();
        if (isP1AllMark)
        {
            win = 0;
            isWin = true;
            isP1 = true;
            isP2 = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isP2AllMark)
        {
            win = 1;
            isWin = true;
            isP1 = false;
            isP2 = true;
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
        if (PlayerScore[0] < PlayerScore[1])
        {
            isP1 = false;
            isP2 = true;
            isWin = true;
            WinRead();
        }
        if (PlayerScore[1] < PlayerScore[0])
        {
            isP1 = true;
            isP2 = false;
            isWin = true;
            WinRead();
        }
        if (PlayerScore[0] == PlayerScore[1])
        {
            if (Average1 < Average2)
            {
                isP2 = true;
                isP1 = false;
                isWin = true;
                WinRead();
            }
            if (Average2 < Average1)
            {
                isP1 = true;
                isP2 = false;
                isWin = true;
                WinRead();
            }
            if (Average1 == Average2)
            {
                isP1 = true;
                isP2 = false;
                isWin = true;
                WinRead();
            }
        }
    }

    void WinRead()
    {
        if(isP1&&!isP2)
        {
            win = 0;
            isWin = true;
            isP1 = true;
            isP2 = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isP2 && !isP1)
        {
            win = 1;
            isWin = true;
            isP1 = false;
            isP2 = true;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
    }

    void Comparison()
    {
        if (isP1_20Mark && isP2_20Mark)
            is20AllMark = true;

        if (isP1_19Mark && isP2_19Mark)
            is19AllMark = true;

        if (isP1_18Mark && isP2_18Mark)
            is18AllMark = true;

        if (isP1_17Mark && isP2_17Mark)
            is17AllMark = true;

        if (isP1_16Mark && isP2_16Mark)
            is16AllMark = true;

        if (isP1_15Mark && isP2_15Mark)
            is15AllMark = true;

        if (isP1_BullMark && isP2_BullMark)
            isBullAllMark = true;
    }
    void MyTurn()
    {
        if (isP1)
        {
            g_P1.transform.position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, -10f);
            g_P2.transform.position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, 0f);

            g_P1.transform.localScale = new Vector3(1f, 1f);
            g_P2.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[1];

            g_P_Score[0].SetActive(true);
            g_P_Score[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            g_RoundScore[0].SetActive(true);
            g_RoundScore[1].SetActive(false);

            g_MRPScore[0].SetActive(true);
            g_MRPScore[1].SetActive(false);

            for (int i = 0; i < i_RScore1.Length; i++)
            {
                i_RScore1[i].enabled = true;
                i_RScore2[i].enabled = false;
            }
        }
        if (isP2)
        {
            g_P1.transform.position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, 0f);
            g_P2.transform.position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, -10f);

            g_P1.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P2.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOn[1];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[0];

            g_P_Score[1].SetActive(true);
            g_P_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            g_RoundScore[1].SetActive(true);
            g_RoundScore[0].SetActive(false);

            g_MRPScore[1].SetActive(true);
            g_MRPScore[0].SetActive(false);

            for (int i = 0; i < i_RScore1.Length; i++)
            {
                i_RScore1[i].enabled = false;
                i_RScore2[i].enabled = true;
            }
        }
    }
/*============서브적인 기능========================*/
    void ImageUp()
    {
        if (isP1&&!isP2)
        {

            if (RScore == 5)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[5];

                g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[4]];
                g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[5]];
                g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[6]];

                g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[7]];
                g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[8]];
                g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[9]];

                g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[10]];
                g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[11]];
                g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[12]];

                g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[13]];
                g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[14]];
                g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[15]];

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[16]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[17]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[18]];
            }

            if (RScore == 6)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[6];

                g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[7]];
                g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[8]];
                g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[9]];

                g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[10]];
                g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[11]];
                g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[12]];

                g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[13]];
                g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[14]];
                g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[15]];

                g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[16]];
                g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[17]];
                g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[18]];

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[19]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[20]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[21]];
            }

            if (RScore == 7)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[7];

                g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[10]];
                g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[11]];
                g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[12]];

                g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[13]];
                g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[14]];
                g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[15]];

                g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[16]];
                g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[17]];
                g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[18]];

                g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[19]];
                g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[20]];
                g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[21]];

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[22]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[23]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[24]];
            }

            if (RScore == 8)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[8];

                g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[13]];
                g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[14]];
                g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[15]];

                g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[16]];
                g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[17]];
                g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[18]];

                g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[19]];
                g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[20]];
                g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[21]];

                g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[22]];
                g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[23]];
                g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[24]];

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[25]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[26]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[27]];
            }

            if (RScore == 9)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[9];

                g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[16]];
                g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[17]];
                g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[18]];

                g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[19]];
                g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[20]];
                g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[21]];

                g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[22]];
                g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[23]];
                g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[24]];

                g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[25]];
                g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[26]];
                g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[27]];

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
            }

            if (RScore == 10)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[10];

                g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[19]];
                g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[20]];
                g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[21]];

                g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[22]];
                g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[23]];
                g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[24]];

                g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[25]];
                g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[26]];
                g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[27]];

                g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
                g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[33]];
            }

            if (RScore == 11)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[11];

                g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[22]];
                g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[23]];
                g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[24]];

                g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[25]];
                g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[26]];
                g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[27]];

                g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
                g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];

                g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
                g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[33]];

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[34]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[35]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[36]];
            }

            if (RScore == 12)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[12];

                g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[25]];
                g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[26]];
                g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[27]];

                g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
                g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];

                g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
                g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[33]];

                g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[34]];
                g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[35]];
                g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[36]];

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[37]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[38]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[39]];
            }

            if (RScore == 13)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[13];

                g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
                g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];

                g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
                g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[33]];

                g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[34]];
                g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[35]];
                g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[36]];

                g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[37]];
                g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[38]];
                g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[39]];

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[40]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[41]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[42]];
            }

            if (RScore == 14)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[14];

                g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
                g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[33]];

                g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[34]];
                g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[35]];
                g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[36]];

                g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[37]];
                g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[38]];
                g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[39]];

                g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[40]];
                g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[41]];
                g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[42]];

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[43]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[44]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[45]];
            }
        }

       else if (isP2&&!isP1)
        {
            if (RScore == 5)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[5];

                g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[4]];
                g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[5]];
                g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[6]];

                g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[7]];
                g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[8]];
                g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[9]];

                g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[10]];
                g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[11]];
                g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[12]];

                g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[13]];
                g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[14]];
                g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[15]];

                g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[16]];
                g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[17]];
                g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[18]];
            }

            if (RScore == 6)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[6];

                g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[7]];
                g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[8]];
                g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[9]];

                g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[10]];
                g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[11]];
                g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[12]];

                g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[13]];
                g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[14]];
                g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[15]];

                g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[16]];
                g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[17]];
                g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[18]];

                g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[19]];
                g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[20]];
                g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[21]];
            }

            if (RScore == 7)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[7];

                g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[10]];
                g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[11]];
                g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[12]];

                g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[13]];
                g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[14]];
                g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[15]];

                g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[16]];
                g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[17]];
                g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[18]];

                g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[19]];
                g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[20]];
                g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[21]];

                g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[22]];
                g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[23]];
                g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[24]];
            }

            if (RScore == 8)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[8];

                g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[13]];
                g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[14]];
                g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[15]];

                g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[16]];
                g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[17]];
                g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[18]];

                g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[19]];
                g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[20]];
                g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[21]];

                g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[22]];
                g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[23]];
                g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[24]];

                g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[25]];
                g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[26]];
                g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[27]];
            }

            if (RScore == 9)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[9];

                g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[16]];
                g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[17]];
                g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[18]];

                g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[19]];
                g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[20]];
                g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[21]];

                g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[22]];
                g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[23]];
                g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[24]];

                g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[25]];
                g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[26]];
                g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[27]];

                g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[28]];
                g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[29]];
                g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[30]];
            }

            if (RScore == 10)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[10];

                g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[19]];
                g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[20]];
                g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[21]];

                g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[22]];
                g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[23]];
                g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[24]];

                g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[25]];
                g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[26]];
                g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[27]];

                g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[28]];
                g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[29]];
                g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[30]];

                g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[31]];
                g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[32]];
                g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[33]];
            }

            if (RScore == 11)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[11];

                g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[22]];
                g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[23]];
                g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[24]];

                g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[25]];
                g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[26]];
                g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[27]];

                g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[28]];
                g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[29]];
                g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[30]];

                g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[31]];
                g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[32]];
                g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[33]];

                g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[34]];
                g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[35]];
                g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[36]];
            }

            if (RScore == 12)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[12];

                g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[25]];
                g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[26]];
                g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[27]];

                g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[28]];
                g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[29]];
                g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[30]];

                g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[31]];
                g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[32]];
                g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[33]];

                g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[34]];
                g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[35]];
                g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[36]];

                g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[37]];
                g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[38]];
                g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[39]];
            }

            if (RScore == 13)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[13];

                g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[28]];
                g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[29]];
                g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[30]];

                g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[31]];
                g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[32]];
                g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[33]];

                g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[34]];
                g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[35]];
                g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[36]];

                g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[37]];
                g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[38]];
                g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[39]];

                g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[40]];
                g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[41]];
                g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[42]];
            }

            if (RScore == 14)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[14];

                g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[31]];
                g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[32]];
                g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[33]];

                g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[34]];
                g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[35]];
                g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[36]];

                g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[37]];
                g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[38]];
                g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[39]];

                g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[40]];
                g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[41]];
                g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[42]];

                g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[43]];
                g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[44]];
                g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[45]];
            }
        }
    }
    void RoundScore(int MarkScore)
    {
        if (isP1 && !isP2)
        {
            MarkSaveP1[P1MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_P1RMark1[Counting].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[P1MarkCounting]];

                if (RScore == 1)
                    g_P1RMark2[Counting].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[P1MarkCounting]];

                if (RScore == 2)
                    g_P1RMark3[Counting].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[P1MarkCounting]];

                if (RScore == 3)
                    g_P1RMark4[Counting].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[P1MarkCounting]];

                if (RScore == 4)
                    g_P1RMark5[Counting].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[P1MarkCounting]];

                if (RScore == 5)
                {
                    g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[4]];
                    g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[5]];
                    g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[6]];

                    g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[7]];
                    g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[8]];
                    g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[9]];

                    g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[10]];
                    g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[11]];
                    g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[12]];

                    g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[13]];
                    g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[14]];
                    g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[15]];

                    g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[16]];
                    g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[17]];
                    g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[18]];
                }

                if (RScore == 6)
                {
                    g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[7]];
                    g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[8]];
                    g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[9]];

                    g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[10]];
                    g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[11]];
                    g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[12]];

                    g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[13]];
                    g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[14]];
                    g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[15]];

                    g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[16]];
                    g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[17]];
                    g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[18]];

                    g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[19]];
                    g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[20]];
                    g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[21]];
                }

                if (RScore == 7)
                {
                    g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[10]];
                    g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[11]];
                    g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[12]];

                    g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[13]];
                    g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[14]];
                    g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[15]];

                    g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[16]];
                    g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[17]];
                    g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[18]];

                    g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[19]];
                    g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[20]];
                    g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[21]];

                    g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[22]];
                    g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[23]];
                    g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[24]];
                }

                if (RScore == 8)
                {
                    g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[13]];
                    g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[14]];
                    g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[15]];

                    g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[16]];
                    g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[17]];
                    g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[18]];

                    g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[19]];
                    g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[20]];
                    g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[21]];

                    g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[22]];
                    g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[23]];
                    g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[24]];

                    g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[25]];
                    g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[26]];
                    g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[27]];
                }

                if (RScore == 9)
                {
                    g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[16]];
                    g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[17]];
                    g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[18]];

                    g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[19]];
                    g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[20]];
                    g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[21]];
                
                    g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[22]];
                    g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[23]];
                    g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[24]];

                    g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[25]];
                    g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[26]];
                    g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[27]];

                    g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                    g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
                    g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];
                }

                if (RScore == 10)
                {
                    g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[19]];
                    g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[20]];
                    g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[21]];

                    g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[22]];
                    g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[23]];
                    g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[24]];

                    g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[25]];
                    g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[26]];
                    g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[27]];

                    g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                    g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
                    g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];

                    g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                    g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
                    g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[33]];
                }

                if (RScore == 11)
                {
                    g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[22]];
                    g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[23]];
                    g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[24]];

                    g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[25]];
                    g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[26]];
                    g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[27]];

                    g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                    g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
                    g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];

                    g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                    g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
                    g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[33]];

                    g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[34]];
                    g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[35]];
                    g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[36]];
                }

                if (RScore == 12)
                {
                    g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[25]];
                    g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[26]];
                    g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[27]];

                    g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                    g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
                    g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];

                    g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                    g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
                    g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[33]];

                    g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[34]];
                    g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[35]];
                    g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[36]];

                    g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[37]];
                    g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[38]];
                    g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[39]];
                }

                if (RScore == 13)
                {
                    g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[28]];
                    g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
                    g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];

                    g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                    g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
                    g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[33]];

                    g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[34]];
                    g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[35]];
                    g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[36]];

                    g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[37]];
                    g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[38]];
                    g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[39]];

                    g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[40]];
                    g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[41]];
                    g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[42]];
                }

                if (RScore == 14)
                {
                    g_P1RMark1[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                    g_P1RMark1[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
                    g_P1RMark1[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[33]];

                    g_P1RMark2[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[34]];
                    g_P1RMark2[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[35]];
                    g_P1RMark2[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[36]];

                    g_P1RMark3[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[37]];
                    g_P1RMark3[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[38]];
                    g_P1RMark3[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[39]];

                    g_P1RMark4[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[40]];
                    g_P1RMark4[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[41]];
                    g_P1RMark4[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[42]];

                    g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[43]];
                    g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[44]];
                    g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[45]];
                }

            }
        }

        else if (isP2 && !isP1)
        {
            MarkSaveP2[P2MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_P2RMark1[Counting].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[P2MarkCounting]];

                if (RScore == 1)
                    g_P2RMark2[Counting].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[P2MarkCounting]];

                if (RScore == 2)
                    g_P2RMark3[Counting].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[P2MarkCounting]];

                if (RScore == 3)
                    g_P2RMark4[Counting].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[P2MarkCounting]];

                if (RScore == 4)
                    g_P2RMark5[Counting].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[P2MarkCounting]];

                if (RScore == 5)
                {
                    g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[4]];
                    g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[5]];
                    g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[6]];

                    g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[7]];
                    g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[8]];
                    g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[9]];

                    g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[10]];
                    g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[11]];
                    g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[12]];

                    g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[13]];
                    g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[14]];
                    g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[15]];

                    g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[16]];
                    g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[17]];
                    g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[18]];
                }

                if (RScore == 6)
                {
                    g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[7]];
                    g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[8]];
                    g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[9]];

                    g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[10]];
                    g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[11]];
                    g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[12]];

                    g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[13]];
                    g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[14]];
                    g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[15]];

                    g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[16]];
                    g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[17]];
                    g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[18]];

                    g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[19]];
                    g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[20]];
                    g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[21]];
                }

                if (RScore == 7)
                {
                    g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[10]];
                    g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[11]];
                    g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[12]];

                    g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[13]];
                    g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[14]];
                    g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[15]];

                    g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[16]];
                    g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[17]];
                    g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[18]];

                    g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[19]];
                    g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[20]];
                    g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[21]];

                    g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[22]];
                    g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[23]];
                    g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[24]];
                }

                if (RScore == 8)
                {
                    g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[13]];
                    g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[14]];
                    g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[15]];

                    g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[16]];
                    g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[17]];
                    g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[18]];

                    g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[19]];
                    g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[20]];
                    g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[21]];

                    g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[22]];
                    g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[23]];
                    g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[24]];

                    g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[25]];
                    g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[26]];
                    g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[27]];
                }

                if (RScore == 9)
                {
                    g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[16]];
                    g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[17]];
                    g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[18]];

                    g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[19]];
                    g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[20]];
                    g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[21]];

                    g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[22]];
                    g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[23]];
                    g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[24]];

                    g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[25]];
                    g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[26]];
                    g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[27]];

                    g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[28]];
                    g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[29]];
                    g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[30]];
                }

                if (RScore == 10)
                {
                    g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[19]];
                    g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[20]];
                    g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[21]];

                    g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[22]];
                    g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[23]];
                    g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[24]];

                    g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[25]];
                    g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[26]];
                    g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[27]];

                    g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[28]];
                    g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[29]];
                    g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[30]];

                    g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[31]];
                    g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[32]];
                    g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[33]];
                }

                if (RScore == 11)
                {
                    g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[22]];
                    g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[23]];
                    g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[24]];

                    g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[25]];
                    g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[26]];
                    g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[27]];

                    g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[28]];
                    g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[29]];
                    g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[30]];

                    g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[31]];
                    g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[32]];
                    g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[33]];

                    g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[34]];
                    g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[35]];
                    g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[36]];
                }

                if (RScore == 12)
                {
                    g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[25]];
                    g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[26]];
                    g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[27]];

                    g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[28]];
                    g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[29]];
                    g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[30]];

                    g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[31]];
                    g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[32]];
                    g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[33]];

                    g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[34]];
                    g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[35]];
                    g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[36]];

                    g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[37]];
                    g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[38]];
                    g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[39]];
                }

                if (RScore == 13)
                {
                    g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[28]];
                    g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[29]];
                    g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[30]];

                    g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[31]];
                    g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[32]];
                    g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[33]];

                    g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[34]];
                    g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[35]];
                    g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[36]];

                    g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[37]];
                    g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[38]];
                    g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[39]];

                    g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[40]];
                    g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[41]];
                    g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[42]];
                }

                if (RScore == 14)
                {
                    g_P2RMark1[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[31]];
                    g_P2RMark1[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[32]];
                    g_P2RMark1[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[33]];

                    g_P2RMark2[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[34]];
                    g_P2RMark2[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[35]];
                    g_P2RMark2[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[36]];

                    g_P2RMark3[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[37]];
                    g_P2RMark3[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[38]];
                    g_P2RMark3[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[39]];

                    g_P2RMark4[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[40]];
                    g_P2RMark4[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[41]];
                    g_P2RMark4[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[42]];

                    g_P2RMark5[0].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[43]];
                    g_P2RMark5[1].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[44]];
                    g_P2RMark5[2].GetComponent<Image>().sprite = s_P2Mark[MarkSaveP2[45]];
                }

            }
        }
    }
    void MainMark()
    {
        if (P1_20Mark == 40)
            g_P1MainMark[0].GetComponent<Image>().sprite = s_P1Mark[1];
        if (P1_20Mark == 20)
            g_P1MainMark[0].GetComponent<Image>().sprite = s_P1Mark[2];
        if (P1_20Mark <= 0)
            g_P1MainMark[0].GetComponent<Image>().sprite = s_P1Mark[3];

        if (P1_19Mark == 38)
            g_P1MainMark[1].GetComponent<Image>().sprite = s_P1Mark[1];
        if (P1_19Mark == 19)
            g_P1MainMark[1].GetComponent<Image>().sprite = s_P1Mark[2];
        if (P1_19Mark <= 0)
            g_P1MainMark[1].GetComponent<Image>().sprite = s_P1Mark[3];

        if (P1_18Mark == 36)
            g_P1MainMark[2].GetComponent<Image>().sprite = s_P1Mark[1];
        if (P1_18Mark == 18)
            g_P1MainMark[2].GetComponent<Image>().sprite = s_P1Mark[2];
        if (P1_18Mark <= 0)
            g_P1MainMark[2].GetComponent<Image>().sprite = s_P1Mark[3];

        if (P1_17Mark == 34)
            g_P1MainMark[3].GetComponent<Image>().sprite = s_P1Mark[1];
        if (P1_17Mark == 17)
            g_P1MainMark[3].GetComponent<Image>().sprite = s_P1Mark[2];
        if (P1_17Mark <= 0)
            g_P1MainMark[3].GetComponent<Image>().sprite = s_P1Mark[3];

        if (P1_16Mark == 32)
            g_P1MainMark[4].GetComponent<Image>().sprite = s_P1Mark[1];
        if (P1_16Mark == 16)
            g_P1MainMark[4].GetComponent<Image>().sprite = s_P1Mark[2];
        if (P1_16Mark <= 0)
            g_P1MainMark[4].GetComponent<Image>().sprite = s_P1Mark[3];

        if (P1_15Mark == 30)
            g_P1MainMark[5].GetComponent<Image>().sprite = s_P1Mark[1];
        if (P1_15Mark == 15)
            g_P1MainMark[5].GetComponent<Image>().sprite = s_P1Mark[2];
        if (P1_15Mark <= 0)
            g_P1MainMark[5].GetComponent<Image>().sprite = s_P1Mark[3];

        if (P1_BullMark == 50)
            g_P1MainMark[6].GetComponent<Image>().sprite = s_P1Mark[1];
        if (P1_BullMark == 25)
            g_P1MainMark[6].GetComponent<Image>().sprite = s_P1Mark[2];
        if (P1_BullMark <= 0)
            g_P1MainMark[6].GetComponent<Image>().sprite = s_P1Mark[3];

        /*=======================BBB==================================*/
        if (P2_20Mark == 40)
            g_P2MainMark[0].GetComponent<Image>().sprite = s_P2Mark[1];
        if (P2_20Mark == 20)
            g_P2MainMark[0].GetComponent<Image>().sprite = s_P2Mark[2];
        if (P2_20Mark <= 0)
            g_P2MainMark[0].GetComponent<Image>().sprite = s_P2Mark[3];

        if (P2_19Mark == 38)
            g_P2MainMark[1].GetComponent<Image>().sprite = s_P2Mark[1];
        if (P2_19Mark == 19)
            g_P2MainMark[1].GetComponent<Image>().sprite = s_P2Mark[2];
        if (P2_19Mark <= 0)
            g_P2MainMark[1].GetComponent<Image>().sprite = s_P2Mark[3];

        if (P2_18Mark == 36)
            g_P2MainMark[2].GetComponent<Image>().sprite = s_P2Mark[1];
        if (P2_18Mark == 18)
            g_P2MainMark[2].GetComponent<Image>().sprite = s_P2Mark[2];
        if (P2_18Mark <= 0)
            g_P2MainMark[2].GetComponent<Image>().sprite = s_P2Mark[3];

        if (P2_17Mark == 34)
            g_P2MainMark[3].GetComponent<Image>().sprite = s_P2Mark[1];
        if (P2_17Mark == 17)
            g_P2MainMark[3].GetComponent<Image>().sprite = s_P2Mark[2];
        if (P2_17Mark <= 0)
            g_P2MainMark[3].GetComponent<Image>().sprite = s_P2Mark[3];
    
        if (P2_16Mark == 32)
            g_P2MainMark[4].GetComponent<Image>().sprite = s_P2Mark[1];
        if (P2_16Mark == 16)
            g_P2MainMark[4].GetComponent<Image>().sprite = s_P2Mark[2];
        if (P2_16Mark <= 0)
            g_P2MainMark[4].GetComponent<Image>().sprite = s_P2Mark[3];

        if (P2_15Mark == 30)
            g_P2MainMark[5].GetComponent<Image>().sprite = s_P2Mark[1];
        if (P2_15Mark == 15)
            g_P2MainMark[5].GetComponent<Image>().sprite = s_P2Mark[2];
        if (P2_15Mark <= 0)
            g_P2MainMark[5].GetComponent<Image>().sprite = s_P2Mark[3];
    
        if (P2_BullMark == 50)
            g_P2MainMark[6].GetComponent<Image>().sprite = s_P2Mark[1];
        if (P2_BullMark == 25)
            g_P2MainMark[6].GetComponent<Image>().sprite = s_P2Mark[2];
        if (P2_BullMark <= 0)
            g_P2MainMark[6].GetComponent<Image>().sprite = s_P2Mark[3];

        if(isP1_20Mark&&isP2_20Mark)
        {
            g_Fishbar[0].SetActive(true);
            g_P1MainMark[0].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[0].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isP1_19Mark && isP2_19Mark)
        {
            g_Fishbar[1].SetActive(true);
            g_P1MainMark[1].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[1].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isP1_18Mark && isP2_18Mark)
        {
            g_Fishbar[2].SetActive(true);
            g_P1MainMark[2].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[2].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isP1_17Mark && isP2_17Mark)
        {
            g_Fishbar[3].SetActive(true);
            g_P1MainMark[3].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[3].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isP1_16Mark && isP2_16Mark)
        {
            g_Fishbar[4].SetActive(true);
            g_P1MainMark[4].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[4].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isP1_15Mark && isP2_15Mark)
        {
            g_Fishbar[5].SetActive(true);
            g_P1MainMark[5].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[5].GetComponent<Image>().sprite = s_OffMark;
        }
        if (isP1_BullMark && isP2_BullMark)
        {
            g_Fishbar[6].SetActive(true);
            g_P1MainMark[6].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[6].GetComponent<Image>().sprite = s_OffMark;
        }

        if (isP1_20Mark && isP1_19Mark && isP1_18Mark && isP1_17Mark && isP1_16Mark && isP1_15Mark && isP1_BullMark)
            isP1AllMark = true;

        if (isP2_20Mark && isP2_19Mark && isP2_18Mark && isP2_17Mark && isP2_16Mark && isP2_15Mark && isP2_BullMark)
            isP2AllMark = true;
    }
    void LineScore()
    {
        if (Counting != 3 && gmg.isAni == false)
        {
         
            /*-----------------------------------------------------------------*/
            if (Players == 0 && !isP1_20Mark && csSingleton.getInstance.g_nTargetBasicScore == 20)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                P1_20Mark -= csSingleton.getInstance.g_nTargetScore;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 0 && !isP1_19Mark && csSingleton.getInstance.g_nTargetBasicScore == 19)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_19Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 0 && !isP1_18Mark && csSingleton.getInstance.g_nTargetBasicScore == 18)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_18Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 0 && !isP1_17Mark && csSingleton.getInstance.g_nTargetBasicScore == 17)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_17Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 0 && !isP1_16Mark && csSingleton.getInstance.g_nTargetBasicScore == 16)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_16Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 0 && !isP1_15Mark && csSingleton.getInstance.g_nTargetBasicScore == 15)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_15Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 0 && !isP1_BullMark && csSingleton.getInstance.g_nTargetBasicScore == 25)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_BullMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            /*-----------------------------------------------------------------*/
            if (Players == 1 && !isP2_20Mark && csSingleton.getInstance.g_nTargetBasicScore == 20)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_20Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 1 && !isP2_19Mark && csSingleton.getInstance.g_nTargetBasicScore == 19)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_19Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 1 && !isP2_18Mark && csSingleton.getInstance.g_nTargetBasicScore == 18)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_18Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 1 && !isP2_17Mark && csSingleton.getInstance.g_nTargetBasicScore == 17)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_17Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 1 && !isP2_16Mark && csSingleton.getInstance.g_nTargetBasicScore == 16)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_16Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 1 && !isP2_15Mark && csSingleton.getInstance.g_nTargetBasicScore == 15)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_15Mark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            else if (Players == 1 && !isP2_BullMark && csSingleton.getInstance.g_nTargetBasicScore == 25)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_BullMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
                Comparison();
            }
            /*-----------------------------------------------------------------*/
            if (P1_20Mark <= 0 && !isP1_20Mark)
            {
                if (!isP2_20Mark)
                {
                    P1_20Mark *= -1;
                    PlayerScore[0] += P1_20Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                isP1_20Mark = true;
                P1_20Mark = 0;
            }
            else if (P1_19Mark <= 0 && !isP1_19Mark)
            {
                if (!isP2_19Mark)
                {
                    P1_19Mark *= -1;
                    PlayerScore[0] += P1_19Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                isP1_19Mark = true;
                P1_19Mark = 0;
            }
            else if (P1_18Mark <= 0 && !isP1_18Mark)
            {
                if (!isP2_18Mark)
                {
                    P1_18Mark *= -1;
                    PlayerScore[0] += P1_18Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                isP1_18Mark = true;
                P1_18Mark = 0;
            }
            else if (P1_17Mark <= 0 && !isP1_17Mark)
            {
                if (!isP2_17Mark)
                {
                    P1_17Mark *= -1;
                    PlayerScore[0] += P1_17Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                isP1_17Mark = true;
                P1_17Mark = 0;
            }
            else if (P1_16Mark <= 0 && !isP1_16Mark)
            {
                if (!isP2_16Mark)
                {
                    P1_16Mark *= -1;
                    PlayerScore[0] += P1_16Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                isP1_16Mark = true;
                P1_16Mark = 0;
            }
            else if (P1_15Mark <= 0 && !isP1_15Mark)
            {
                if (!isP2_15Mark)
                {
                    P1_15Mark *= -1;
                    PlayerScore[0] += P1_15Mark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }

                isP1_15Mark = true;
                P1_15Mark = 0;
            }
            else if (P1_BullMark <= 0 && !isP1_BullMark)
            {
                if (!isP2_BullMark)
                {
                    P1_BullMark *= -1;
                    PlayerScore[0] += P1_BullMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                isP1_BullMark = true;
                P1_BullMark = 0;
            }
            /*-----------------------------------------------------------------*/
            else if (P2_20Mark <= 0 && !isP2_20Mark)
            {
                if (!isP1_20Mark)
                {
                    P2_20Mark *= -1;
                    PlayerScore[1] += P2_20Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                isP2_20Mark = true;
                P2_20Mark = 0;
            }
            else if (P2_19Mark <= 0 && !isP2_19Mark)
            {
                if (!isP1_19Mark)
                {
                    P2_19Mark *= -1;
                    PlayerScore[1] += P2_19Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                isP2_19Mark = true;
                P2_19Mark = 0;
            }
            else if (P2_18Mark <= 0 && !isP2_18Mark)
            {
                if (!isP1_18Mark)
                {
                    P2_18Mark *= -1;
                    PlayerScore[1] += P2_18Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                isP2_18Mark = true;
                P2_18Mark = 0;
            }
            else if (P2_17Mark <= 0 && !isP2_17Mark)
            {
                if (!isP1_17Mark)
                {
                    P2_17Mark *= -1;
                    PlayerScore[1] += P2_17Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                isP2_17Mark = true;
                P2_17Mark = 0;
            }
            else if (P2_16Mark <= 0 && !isP2_16Mark)
            {
                if (!isP1_16Mark)
                {
                    P2_16Mark *= -1;
                    PlayerScore[1] += P2_16Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                isP2_16Mark = true;
                P2_16Mark = 0;
            }
            else if (P2_15Mark <= 0 && !isP2_15Mark)
            {
                if (!isP1_15Mark)
                {
                    P2_15Mark *= -1;
                    PlayerScore[1] += P2_15Mark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                isP2_15Mark = true;
                P2_15Mark = 0;
            }
            else if (P2_BullMark <= 0 && !isP2_BullMark)
            {
                if (!isP1_BullMark)
                {
                    P2_BullMark *= -1;
                    PlayerScore[1] += P2_BullMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                isP2_BullMark = true;
                P2_BullMark = 0;
            }
            /*-----------------------------------------------------------------*/

        }
    }
    void MarkAll()
    {
        if (csSingleton.getInstance.g_nTargetBasicScore == 25 && isBullAllMark)
        {
            if (Players == 0)
                P1MarkCounting++;
            else if (Players == 1)
                P2MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == 20 && is20AllMark)
        {
            if (Players == 0)
                P1MarkCounting++;
            else if (Players == 1)
                P2MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == 19 && is19AllMark)
        {
            if (Players == 0)
                P1MarkCounting++;
            else if (Players == 1)
                P2MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == 18 && is18AllMark)
        {
            if (Players == 0)
                P1MarkCounting++;
            else if (Players == 1)
                P2MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == 17 && is17AllMark)
        {
            if (Players == 0)
                P1MarkCounting++;
            else if (Players == 1)
                P2MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == 16 && is16AllMark)
        {
            if (Players == 0)
                P1MarkCounting++;
            else if (Players == 1)
                P2MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }
        else if (csSingleton.getInstance.g_nTargetBasicScore == 15 && is15AllMark)
        {
            if (Players == 0)
                P1MarkCounting++;
            else if (Players == 1)
                P2MarkCounting++;
            a_source.PlayOneShot(ac_shoot1, 1.0f);
            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
            g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
            DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
            m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
            m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
            gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
            Counting++;
        }  
    }
    void PlayerNumberPlus()
    {
        isP1 = false;
        isP2 = true;
        isRead = false;
        g_C_Ani.SetActive(false);
        Counting = 0;
        Players = 1;
    }
    void PlayerNumberMinus()
    {
        isP1 = true;
        isP2 = false;
        isRead = false;
        Players = 0;
    }
    void FirstStart()
    {
        isP1 = true;
        isP2 = false;
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
        RoundCountingP1 = 1;
        RoundCountingP2 = 1;
        Round = 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
    }
    void MPRScore(int Dart)
    {
        if(Players==0)
        {
            TotalP1 += Dart;
            Average1 = TotalP1 / RoundCountingP1;
            t_MPRText1.text = string.Format("{0:N2}", Average1);
        }
        if (Players == 1)
        {
            TotalP2 += Dart;
            Average2 = TotalP2 / RoundCountingP2;
            t_MPRText2.text = string.Format("{0:N2}", Average2);
        }
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
