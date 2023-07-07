using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TwoPlayers : MonoBehaviour
{
    public Text t_RoundText;
    public Text t_MPRText1;
    public Text t_MPRText2;

    public GameObject[] g_HAni = new GameObject[7];
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
    public GameObject[] g_20Line = new GameObject[25];
    public GameObject[] g_19Line = new GameObject[25];
    public GameObject[] g_18Line = new GameObject[25];
    public GameObject[] g_17Line = new GameObject[25];
    public GameObject[] g_16Line = new GameObject[25];
    public GameObject[] g_15Line = new GameObject[25];
    public GameObject[] g_BullLine = new GameObject[25];
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

    public int P1_20LMark = 0;
    public int P1_19LMark = 0;
    public int P1_18LMark = 0;
    public int P1_17LMark = 0;
    public int P1_16LMark = 0;
    public int P1_15LMark = 0;
    public int P1_BullLMark = 0;

    public int P2_20LMark = 0;
    public int P2_19LMark = 0;
    public int P2_18LMark = 0;
    public int P2_17LMark = 0;
    public int P2_16LMark = 0;
    public int P2_15LMark = 0;
    public int P2_BullLMark = 0;

    public int[] RandomValue = new int[20];
    public int _20Line = 0;
    public int _19Line = 0;
    public int _18Line = 0;
    public int _17Line = 0;
    public int _16Line = 0;
    public int _15Line = 0;
    public int _BullLine = 0;

        
    public float Average1 = 0;
    public float Average2 = 0;

    public string[] playername = new string[2];

    public bool isP1_20Line = false;
    public bool isP1_19Line = false;
    public bool isP1_18Line = false;
    public bool isP1_17Line = false;
    public bool isP1_16Line = false;
    public bool isP1_15Line = false;
    public bool isP1_BullLine = false;

    public bool isP2_20Line = false;
    public bool isP2_19Line = false;
    public bool isP2_18Line = false;
    public bool isP2_17Line = false;
    public bool isP2_16Line = false;
    public bool isP2_15Line = false;
    public bool isP2_BullLine = false;
    /*여기 까지*/
    public bool isP1_BullAllLine = false;
    public bool isP2_BullAllLine = false;
    public bool is20AllLine = false;
    public bool is19AllLine = false;
    public bool is18AllLine = false;
    public bool is17AllLine = false;
    public bool is16AllLine = false;
    public bool is15AllLine = false;
    public bool isBullAllLine = false;
    public bool isP1AllLine = false;
    public bool isP2AllLine = false;

    public bool is20ALine = false;
    public bool is19ALine = false;
    public bool is18ALine = false;
    public bool is17ALine = false;
    public bool is16ALine = false;
    public bool is15ALine = false;
    public bool isBullALine = false;
    /*여기 까지*/
    public bool isP1 = true;
    public bool isP2 = false;
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
            g_P_Score[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
            g_OffScore[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
        }

        P1_20LMark = _20Line * 3;
        P1_19LMark = _19Line * 3;
        P1_18LMark = _18Line * 3;
        P1_17LMark = _17Line * 3;
        P1_16LMark = _16Line * 3;
        P1_15LMark = _15Line * 3;
        P1_BullLMark = _BullLine * 3;

        P2_20LMark = _20Line * 3;
        P2_19LMark = _19Line * 3;
        P2_18LMark = _18Line * 3;
        P2_17LMark = _17Line * 3;
        P2_16LMark = _16Line * 3;
        P2_15LMark = _15Line * 3;
        P2_BullLMark = _BullLine * 3;

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

                    if (Players == 0 && !isRead && !isSpace && !isWin && isP1_20Line && !is20AllLine && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
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
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_19Line && !is19AllLine && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
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
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_18Line && !is18AllLine && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
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
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_17Line && !is17AllLine && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
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
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_16Line && !is16AllLine && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
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
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_15Line && !is15AllLine && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
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
                    else if (Players == 0 && !isRead && !isSpace && !isWin && isP1_BullLine && !isBullAllLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
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

                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_20Line && !is20AllLine && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
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
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_19Line && !is19AllLine && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
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
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_18Line && !is18AllLine && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
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
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_17Line && !is17AllLine && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
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
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_16Line && !is16AllLine && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
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
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_15Line && !is15AllLine && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
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
                    else if (Players == 1 && !isRead && !isSpace && !isWin && isP2_BullLine && !isBullAllLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
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

                    if (Counting != 3)
                        LineScore();

                }
                else
                {
                }
            }
            else
            {
                if (csSingleton.getInstance.g_nTargetBasicScore!= _20Line && csSingleton.getInstance.g_nTargetBasicScore != _19Line && csSingleton.getInstance.g_nTargetBasicScore != _18Line &&
                    csSingleton.getInstance.g_nTargetBasicScore != _17Line && csSingleton.getInstance.g_nTargetBasicScore != _16Line && csSingleton.getInstance.g_nTargetBasicScore != _15Line &&
                    csSingleton.getInstance.g_nTargetBasicScore != _BullLine && Counting != 3 && !isSpace && !isRead && !isWin)
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
        MainMark();
        /*==================================================================================================*/
        if (Input.GetKeyDown(KeyCode.Space) && Counting == 4 && !isWin && gmg.isAni != true && isSpace )
        {
            if (is20ALine && g_HAni[0].activeSelf==true)
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
        if (isP1AllLine)
        {
            win = 0;
            isWin = true;
            isP1 = true;
            isP2 = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isP2AllLine)
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
        if (isP1 && !isP2)
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
        if (isP1 && !isP2)
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
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[29]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];
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

                g_P1RMark5[0].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[30]];
                g_P1RMark5[1].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[31]];
                g_P1RMark5[2].GetComponent<Image>().sprite = s_P1Mark[MarkSaveP1[32]];
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

       else if (isP2 && !isP1)
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
        if (isP1 && !isP1_20Line && P1_20LMark == _20Line*2)
            g_P1MainMark[0].GetComponent<Image>().sprite = s_P1Mark[1];
        else if (isP1 && !isP1_20Line && P1_20LMark == _20Line )
            g_P1MainMark[0].GetComponent<Image>().sprite = s_P1Mark[2];
        else if (isP1 && !isP1_20Line && P1_20LMark <= 0)
        {
            isP1_20Line = true;
            g_P1MainMark[0].GetComponent<Image>().sprite = s_P1Mark[3];
        }

        if (isP1 && !isP1_19Line && P1_19LMark == _19Line * 2)
            g_P1MainMark[1].GetComponent<Image>().sprite = s_P1Mark[1];
        else if (isP1 && !isP1_19Line && P1_19LMark == _19Line)
            g_P1MainMark[1].GetComponent<Image>().sprite = s_P1Mark[2];
        else if (isP1 && !isP1_19Line && P1_19LMark <= 0)
        {
            isP1_19Line = true;
            g_P1MainMark[1].GetComponent<Image>().sprite = s_P1Mark[3];
        }

        if (isP1 && !isP1_18Line && P1_18LMark == _18Line * 2)
            g_P1MainMark[2].GetComponent<Image>().sprite = s_P1Mark[1];
        else if (isP1 && !isP1_18Line && P1_18LMark == _18Line)
            g_P1MainMark[2].GetComponent<Image>().sprite = s_P1Mark[2];
        else if (isP1 && !isP1_18Line && P1_18LMark <= 0)
        {
            isP1_18Line = true;
            g_P1MainMark[2].GetComponent<Image>().sprite = s_P1Mark[3];
        }

        if (isP1 && !isP1_17Line && P1_17LMark == _17Line * 2)
            g_P1MainMark[3].GetComponent<Image>().sprite = s_P1Mark[1];
        else if (isP1 && !isP1_17Line && P1_17LMark == _17Line )
            g_P1MainMark[3].GetComponent<Image>().sprite = s_P1Mark[2];
        else if (isP1 && !isP1_17Line && P1_17LMark <= 0)
        {
            isP1_17Line = true;
            g_P1MainMark[3].GetComponent<Image>().sprite = s_P1Mark[3];
        }

        if (isP1 && !isP1_16Line && P1_16LMark == _16Line * 2)
            g_P1MainMark[4].GetComponent<Image>().sprite = s_P1Mark[1];
        else if (isP1 && !isP1_16Line && P1_16LMark == _16Line)
            g_P1MainMark[4].GetComponent<Image>().sprite = s_P1Mark[2];
        else if (isP1 && !isP1_16Line && P1_16LMark <= 0)
        {
            isP1_16Line = true;
            g_P1MainMark[4].GetComponent<Image>().sprite = s_P1Mark[3];
        }

        if (isP1 && !isP1_15Line && P1_15LMark == _15Line * 2)
            g_P1MainMark[5].GetComponent<Image>().sprite = s_P1Mark[1];
        else if (isP1 && !isP1_15Line && P1_15LMark == _15Line)
            g_P1MainMark[5].GetComponent<Image>().sprite = s_P1Mark[2];
        else if (isP1 && !isP1_15Line && P1_15LMark <= 0)
        {
            isP1_15Line = true;
            g_P1MainMark[5].GetComponent<Image>().sprite = s_P1Mark[3];
        }

        if (isP1 && !isP1_BullLine && P1_BullLMark == _BullLine * 2)
            g_P1MainMark[6].GetComponent<Image>().sprite = s_P1Mark[1];
        else if (isP1 && !isP1_BullLine && P1_BullLMark == _BullLine)
            g_P1MainMark[6].GetComponent<Image>().sprite = s_P1Mark[2];
        else if (isP1 && !isP1_BullLine && P1_BullLMark <= 0)
        {
            isP1_BullLine = true;
            g_P1MainMark[6].GetComponent<Image>().sprite = s_P1Mark[3];
        }
        /*-------------------------------------------------------------*/
        if (isP2 && !isP2_20Line && P2_20LMark == _20Line * 2)
            g_P2MainMark[0].GetComponent<Image>().sprite = s_P2Mark[1];
        else if (isP2 && !isP2_20Line && P2_20LMark == _20Line)
            g_P2MainMark[0].GetComponent<Image>().sprite = s_P2Mark[2];
        else if (isP2 && !isP2_20Line && P2_20LMark <= 0)
        {
            isP2_20Line = true;
            g_P2MainMark[0].GetComponent<Image>().sprite = s_P2Mark[3];
        }

        if (isP2 && !isP2_19Line && P2_19LMark == _19Line * 2)
            g_P2MainMark[1].GetComponent<Image>().sprite = s_P2Mark[1];
        else if (isP2 && !isP2_19Line && P2_19LMark == _19Line )
            g_P2MainMark[1].GetComponent<Image>().sprite = s_P2Mark[2];
        else if (isP2 && !isP2_19Line && P2_19LMark <= 0)
        {
            isP2_19Line = true;
            g_P2MainMark[1].GetComponent<Image>().sprite = s_P2Mark[3];
        }

        if (isP2 && !isP2_18Line && P2_18LMark == _18Line * 2)
            g_P2MainMark[2].GetComponent<Image>().sprite = s_P2Mark[1];
        else if (isP2 && !isP2_18Line && P2_18LMark == _18Line)
            g_P2MainMark[2].GetComponent<Image>().sprite = s_P2Mark[2];
        else if (isP2 && !isP2_18Line && P2_18LMark <= 0)
        {
            isP2_18Line = true;
            g_P2MainMark[2].GetComponent<Image>().sprite = s_P2Mark[3];
        }

        if (isP2 && !isP2_17Line && P2_17LMark == _17Line * 2)
            g_P2MainMark[3].GetComponent<Image>().sprite = s_P2Mark[1];
        else if (isP2 && !isP2_17Line && P2_17LMark == _17Line )
            g_P2MainMark[3].GetComponent<Image>().sprite = s_P2Mark[2];
        else if (isP2 && !isP2_17Line && P2_17LMark <= 0)
        {
            isP2_17Line = true;
            g_P2MainMark[3].GetComponent<Image>().sprite = s_P2Mark[3];
        }

        if (isP2 && !isP2_16Line && P2_16LMark == _16Line * 2)
            g_P2MainMark[4].GetComponent<Image>().sprite = s_P2Mark[1];
        else if (isP2 && !isP2_16Line && P2_16LMark == _16Line )
            g_P2MainMark[4].GetComponent<Image>().sprite = s_P2Mark[2];
        else if (isP2 && !isP2_16Line && P2_16LMark <= 0)
        {
            isP2_16Line = true;
            g_P2MainMark[4].GetComponent<Image>().sprite = s_P2Mark[3];
        }

        if (isP2 && !isP2_15Line && P2_15LMark == _15Line * 2)
            g_P2MainMark[5].GetComponent<Image>().sprite = s_P2Mark[1];
        else if (isP2 && !isP2_15Line && P2_15LMark == _15Line)
            g_P2MainMark[5].GetComponent<Image>().sprite = s_P2Mark[2];
        else if (isP2 && !isP2_15Line && P2_15LMark <= 0)
        {
            isP2_15Line = true;
            g_P2MainMark[5].GetComponent<Image>().sprite = s_P2Mark[3];
        }

        if (isP2 && !isP2_BullLine && P2_BullLMark == _BullLine * 2)
            g_P2MainMark[6].GetComponent<Image>().sprite = s_P2Mark[1];
        else if (isP2 && !isP2_BullLine && P2_BullLMark == _BullLine )
            g_P2MainMark[6].GetComponent<Image>().sprite = s_P2Mark[2];
        else if (isP2 && !isP2_BullLine && P2_BullLMark <= 0)
        {
            isP2_BullLine = true;
            g_P2MainMark[6].GetComponent<Image>().sprite = s_P2Mark[3];
        }
       /*--------------------------------------------------------------*/
        if (isP1_20Line && isP2_20Line)
        {
            g_Fishbar[0].SetActive(true);
            g_P1MainMark[0].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[0].GetComponent<Image>().sprite = s_OffMark;
            is20AllLine = true;
        }
        if (isP1_19Line && isP2_19Line)
        {
            g_Fishbar[1].SetActive(true);
            g_P1MainMark[1].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[1].GetComponent<Image>().sprite = s_OffMark;
            is19AllLine = true;
        }
        if (isP1_18Line && isP2_18Line)
        {
            g_Fishbar[2].SetActive(true);
            g_P1MainMark[2].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[2].GetComponent<Image>().sprite = s_OffMark;
            is18AllLine = true;
        }
        if (isP1_17Line && isP2_17Line)
        {
            g_Fishbar[3].SetActive(true);
            g_P1MainMark[3].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[3].GetComponent<Image>().sprite = s_OffMark;
            is17AllLine = true;
        }
        if (isP1_16Line && isP2_16Line)
        {
            g_Fishbar[4].SetActive(true);
            g_P1MainMark[4].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[4].GetComponent<Image>().sprite = s_OffMark;
            is16AllLine = true;
        }
        if (isP1_15Line && isP2_15Line)
        {
            g_Fishbar[5].SetActive(true);
            g_P1MainMark[5].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[5].GetComponent<Image>().sprite = s_OffMark;
            is15AllLine = true;
        }
        if (isP1_BullLine && isP2_BullLine)
        {
            g_Fishbar[6].SetActive(true);
            g_P1MainMark[6].GetComponent<Image>().sprite = s_OffMark;
            g_P2MainMark[6].GetComponent<Image>().sprite = s_OffMark;
            isBullAllLine = true;
        }

        if (isP1_20Line && isP1_19Line && isP1_18Line && isP1_17Line && isP1_16Line && isP1_15Line && isP1_BullLine)
            isP1AllLine = true;

        if (isP2_20Line && isP2_19Line && isP2_18Line && isP2_17Line && isP2_16Line && isP2_15Line && isP2_BullLine)
            isP2AllLine = true;
    }

    void LineScore()
    {
        if (Counting != 3 && gmg.isAni == false)
        {
            /*-----------------------------------------------------------------*/
            if (Players == 0 && !isP1_20Line && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                P1_20LMark -= csSingleton.getInstance.g_nTargetScore;
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
               // AniMation();
            }
            else if (Players == 0 && !isP1_19Line && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_19LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
               // AniMation();
            }
            else if (Players == 0 && !isP1_18Line && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_18LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
              //  AniMation();
            }
            else if (Players == 0 && !isP1_17Line && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_17LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
              //  AniMation();
            }
            else if (Players == 0 && !isP1_16Line && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_16LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
               // AniMation();
            }
            else if (Players == 0 && !isP1_15Line && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_15LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
               // AniMation();
            }
            else if (Players == 0 && !isP1_BullLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P1_BullLMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
               // AniMation();
            }
            /*-----------------------------------------------------------------*/
            if (Players == 1 && !isP2_20Line && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_20LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
               // AniMation();
            }
            else if (Players == 1 && !isP2_19Line && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_19LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
               // AniMation();
            }
            else if (Players == 1 && !isP2_18Line && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_18LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
               // AniMation();
            }
            else if (Players == 1 && !isP2_17Line && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_17LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
               // AniMation();
            }
            else if (Players == 1 && !isP2_16Line && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_16LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
               // AniMation();
            }
            else if (Players == 1 && !isP2_15Line && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_15LMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
               // AniMation();
            }
            else if (Players == 1 && !isP2_BullLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
            {
                if (Players == 0)
                    P1MarkCounting++;
                else if (Players == 1)
                    P2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                P2_BullLMark -= csSingleton.getInstance.g_nTargetScore;
                MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                g_Dart[Counting].GetComponent<Image>().sprite = s_OnDart;
                DartBasicScore[Counting] = csSingleton.getInstance.g_nTargetBasicScore;
                m_oDartInfo[Counting].nLine = csSingleton.getInstance.g_nTargetLine;
                m_oDartInfo[Counting].nScore = csSingleton.getInstance.g_nTargetScore;
                gmg.DartScoreActor(m_oDartInfo[Counting].nLine, DartBasicScore[Counting], Counting);
                Counting++;
              //  AniMation();
            }
            else
            {
            }
            /*-----------------------------------------------------------------*/
            if (P1_20LMark <= 0 && !isP1_20Line)
            {
                if (!isP2_20Line)
                {
                    P1_20LMark *= -1;
                    PlayerScore[0] += P1_20LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                P1_20LMark = 0;
            }
            else if (P1_19LMark <= 0 && !isP1_19Line)
            {
                if (!isP2_19Line)
                {
                    P1_19LMark *= -1;
                    PlayerScore[0] += P1_19LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                P1_19LMark = 0;
            }
            else if (P1_18LMark <= 0 && !isP1_18Line)
            {
                if (!isP2_18Line)
                {
                    P1_18LMark *= -1;
                    PlayerScore[0] += P1_18LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                P1_18LMark = 0;
            }
            else if (P1_17LMark <= 0 && !isP1_17Line)
            {
                if (!isP2_17Line)
                {
                    P1_17LMark *= -1;
                    PlayerScore[0] += P1_17LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                P1_17LMark = 0;
            }
            else if (P1_16LMark <= 0 && !isP1_16Line)
            {
                if (!isP2_16Line)
                {
                    P1_16LMark *= -1;
                    PlayerScore[0] += P1_16LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                P1_16LMark = 0;
            }
            else if (P1_15LMark <= 0 && !isP1_15Line)
            {
                if (!isP2_15Line)
                {
                    P1_15LMark *= -1;
                    PlayerScore[0] += P1_15LMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                P1_15LMark = 0;
            }
            else if (P1_BullLMark <= 0 && !isP1_BullLine)
            {
                if (!isP2_BullLine)
                {
                    P1_BullLMark *= -1;
                    PlayerScore[0] += P1_BullLMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                }
                P1_BullLMark = 0;
            }
            /*-----------------------------------------------------------------*/
            else if (P2_20LMark <= 0 && !isP2_20Line)
            {
                if (!isP1_20Line)
                {
                    P2_20LMark *= -1;
                    PlayerScore[1] += P2_20LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                P2_20LMark = 0;
            }
            else if (P2_19LMark <= 0 && !isP2_19Line)
            {
                if (!isP1_20Line)
                {
                    P2_19LMark *= -1;
                    PlayerScore[1] += P2_19LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                P2_19LMark = 0;
            }
            else if (P2_18LMark <= 0 && !isP2_18Line)
            {
                if (!isP1_18Line)
                {
                    P2_18LMark *= -1;
                    PlayerScore[1] += P2_18LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                P2_18LMark = 0;
            }
            else if (P2_17LMark <= 0 && !isP2_17Line)
            {
                if (!isP1_17Line)
                {
                    P2_17LMark *= -1;
                    PlayerScore[1] += P2_17LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                P2_17LMark = 0;
            }
            else if (P2_16LMark <= 0 && !isP2_16Line)
            {
                if (!isP1_16Line)
                {
                    P2_16LMark *= -1;
                    PlayerScore[1] += P2_16LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                P2_16LMark = 0;
            }
            else if (P2_15LMark <= 0 && !isP2_15Line)
            {
                if (!isP1_15Line)
                {
                    P2_15LMark *= -1;
                    PlayerScore[1] += P2_15LMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                P2_15LMark = 0;
            }
            else if (P2_BullLMark <= 0 && !isP2_BullLine)
            {
                if (!isP1_BullLine)
                {
                    P2_BullLMark *= -1;
                    PlayerScore[1] += P2_BullLMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                }
                P2_BullLMark = 0;
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == _20Line && is20AllLine)
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == _19Line && is19AllLine)
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == _18Line && is18AllLine)
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == _17Line && is17AllLine)
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == _16Line && is16AllLine)
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
        else if (csSingleton.getInstance.g_nTargetBasicScore == _15Line && is15AllLine)
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
        Counting = 0;
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
        if (Players == 0)
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
