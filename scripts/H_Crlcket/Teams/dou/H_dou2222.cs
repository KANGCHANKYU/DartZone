using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class H_dou2222 : MonoBehaviour
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

    public GameObject[] g_CT1RMark1 = new GameObject[3];
    public GameObject[] g_CT1RMark2 = new GameObject[3];
    public GameObject[] g_CT1RMark3 = new GameObject[3];
    public GameObject[] g_CT1RMark4 = new GameObject[3];
    public GameObject[] g_CT1RMark5 = new GameObject[3];
    public GameObject[] g_CT2RMark1 = new GameObject[3];
    public GameObject[] g_CT2RMark2 = new GameObject[3];
    public GameObject[] g_CT2RMark3 = new GameObject[3];
    public GameObject[] g_CT2RMark4 = new GameObject[3];
    public GameObject[] g_CT2RMark5 = new GameObject[3];

    public GameObject[] g_DT1RMark1 = new GameObject[3];
    public GameObject[] g_DT1RMark2 = new GameObject[3];
    public GameObject[] g_DT1RMark3 = new GameObject[3];
    public GameObject[] g_DT1RMark4 = new GameObject[3];
    public GameObject[] g_DT1RMark5 = new GameObject[3];
    public GameObject[] g_DT2RMark1 = new GameObject[3];
    public GameObject[] g_DT2RMark2 = new GameObject[3];
    public GameObject[] g_DT2RMark3 = new GameObject[3];
    public GameObject[] g_DT2RMark4 = new GameObject[3];
    public GameObject[] g_DT2RMark5 = new GameObject[3];

    public GameObject[] g_ATMainMark = new GameObject[7];
    public GameObject[] g_BTMainMark = new GameObject[7];
    public GameObject[] g_CTMainMark = new GameObject[7];
    public GameObject[] g_DTMainMark = new GameObject[7];
    public GameObject[] g_i_Player = new GameObject[4];
    public GameObject[] g_Teambar = new GameObject[4];
    public GameObject[] g_Dart = new GameObject[3];
    public GameObject[] g_RoundScore = new GameObject[8];
    public GameObject[] g_MRPScore = new GameObject[8];
    public GameObject[] g_RoundNum = new GameObject[15];
    public GameObject[] g_P_Score = new GameObject[4];
    public GameObject[] g_OffScore = new GameObject[4];
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
    public GameObject g_CT;
    public GameObject g_DT;
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
    public Sprite[] s_PlayerOn = new Sprite[4];
    public Sprite[] s_PlayerOff = new Sprite[4];
    public Sprite[] s_TeambarOn = new Sprite[4];
    public Sprite[] s_TeambarOff = new Sprite[4];
    public Sprite[] s_ATMark = new Sprite[4];
    public Sprite[] s_BTMark = new Sprite[4];
    public Sprite[] s_CTMark = new Sprite[4];
    public Sprite[] s_DTMark = new Sprite[4];
    public Sprite s_OffMark;

    public Image[] i_RScoreA1 = new Image[5];
    public Image[] i_RScoreA2 = new Image[5];
    public Image[] i_RScoreB1 = new Image[5];
    public Image[] i_RScoreB2 = new Image[5];
    public Image[] i_RScoreC1 = new Image[5];
    public Image[] i_RScoreC2 = new Image[5];
    public Image[] i_RScoreD1 = new Image[5];
    public Image[] i_RScoreD2 = new Image[5];

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

    public int[] TeamScore = new int[8];
    public int[] MarkSaveAT1 = new int[45];
    public int[] MarkSaveAT2 = new int[45];
    public int[] MarkSaveBT1 = new int[45];
    public int[] MarkSaveBT2 = new int[45];
    public int[] MarkSaveCT1 = new int[45];
    public int[] MarkSaveCT2 = new int[45];
    public int[] MarkSaveDT1 = new int[45];
    public int[] MarkSaveDT2 = new int[45];
    public int[] DartBasicScore = new int[3];

    public int AT1MarkCounting = 0;
    public int AT2MarkCounting = 0;
    public int BT1MarkCounting = 0;
    public int BT2MarkCounting = 0;
    public int CT1MarkCounting = 0;
    public int CT2MarkCounting = 0;
    public int DT1MarkCounting = 0;
    public int DT2MarkCounting = 0;
    public int Counting = 0;
    public int Round = 0;
    public int RoundCountingA1 = 0;
    public int RoundCountingA2 = 0;
    public int RoundCountingB1 = 0;
    public int RoundCountingB2 = 0;
    public int RoundCountingC1 = 0;
    public int RoundCountingC2 = 0;
    public int RoundCountingD1 = 0;
    public int RoundCountingD2 = 0;
    public int TotalA1 = 0;
    public int TotalA2 = 0;
    public int TotalB1 = 0;
    public int TotalB2 = 0;
    public int TotalC1 = 0;
    public int TotalC2 = 0;
    public int TotalD1 = 0;
    public int TotalD2 = 0;
    public int RScore = 0;
    public int Players = 0;
    public int Teams = 0;
    public int win = 0;
    public int Line = 0;

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

    public int CT_20LMark = 0;
    public int CT_19LMark = 0;
    public int CT_18LMark = 0;
    public int CT_17LMark = 0;
    public int CT_16LMark = 0;
    public int CT_15LMark = 0;
    public int CT_BullLMark = 0;

    public int DT_20LMark = 0;
    public int DT_19LMark = 0;
    public int DT_18LMark = 0;
    public int DT_17LMark = 0;
    public int DT_16LMark = 0;
    public int DT_15LMark = 0;
    public int DT_BullLMark = 0;

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
    public float AverageB1 = 0;
    public float AverageB2 = 0;
    public float AverageC1 = 0;
    public float AverageC2 = 0;
    public float AverageD1 = 0;
    public float AverageD2 = 0;
    public float AverageATotla = 0;
    public float AverageBTotla = 0;
    public float AverageCTotla = 0;
    public float AverageDTotla = 0;

    public string[] playername = new string[8];

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

    public bool isCT_20Line = false;
    public bool isCT_19Line = false;
    public bool isCT_18Line = false;
    public bool isCT_17Line = false;
    public bool isCT_16Line = false;
    public bool isCT_15Line = false;
    public bool isCT_BullLine = false;

    public bool isDT_20Line = false;
    public bool isDT_19Line = false;
    public bool isDT_18Line = false;
    public bool isDT_17Line = false;
    public bool isDT_16Line = false;
    public bool isDT_15Line = false;
    public bool isDT_BullLine = false;
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
    public bool isCTAllLine = false;
    public bool isDTAllLine = false;

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
    public bool isCT = false;
    public bool isDT = false;
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

        CT_20LMark = _20Line * 3;
        CT_19LMark = _19Line * 3;
        CT_18LMark = _18Line * 3;
        CT_17LMark = _17Line * 3;
        CT_16LMark = _16Line * 3;
        CT_15LMark = _15Line * 3;
        CT_BullLMark = _BullLine * 3;

        DT_20LMark = _20Line * 3;
        DT_19LMark = _19Line * 3;
        DT_18LMark = _18Line * 3;
        DT_17LMark = _17Line * 3;
        DT_16LMark = _16Line * 3;
        DT_15LMark = _15Line * 3;
        DT_BullLMark = _BullLine * 3;

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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_19Line && !is19AllLine && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_18Line && !is18AllLine && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_17Line && !is17AllLine && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_16Line && !is16AllLine && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_15Line && !is15AllLine && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
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
                    else if (Teams == 0 && !isRead && !isSpace && !isWin && isAT_BullLine && !isBullAllLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
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

                    if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_20Line && !is20AllLine && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_19Line && !is19AllLine && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_18Line && !is18AllLine && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_17Line && !is17AllLine && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_16Line && !is16AllLine && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_15Line && !is15AllLine && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
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
                    else if (Teams == 1 && !isRead && !isSpace && !isWin && isBT_BullLine && !isBullAllLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
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

                    if (Teams == 2 && !isRead && !isSpace && !isWin && isCT_20Line && !is20AllLine && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 2 && !isRead && !isSpace && !isWin && isCT_19Line && !is19AllLine && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 2 && !isRead && !isSpace && !isWin && isCT_18Line && !is18AllLine && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 2 && !isRead && !isSpace && !isWin && isCT_17Line && !is17AllLine && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 2 && !isRead && !isSpace && !isWin && isCT_16Line && !is16AllLine && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 2 && !isRead && !isSpace && !isWin && isCT_15Line && !is15AllLine && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 2 && !isRead && !isSpace && !isWin && isCT_BullLine && !isBullAllLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                CT1MarkCounting++;
                            else if (Players == 1)
                                CT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[2] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }

                    }

                    if (Teams == 3 && !isRead && !isSpace && !isWin && isDT_20Line && !is20AllLine && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 3 && !isRead && !isSpace && !isWin && isDT_19Line && !is19AllLine && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 3 && !isRead && !isSpace && !isWin && isDT_18Line && !is18AllLine && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 3 && !isRead && !isSpace && !isWin && isDT_17Line && !is17AllLine && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 3 && !isRead && !isSpace && !isWin && isDT_16Line && !is16AllLine && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 3 && !isRead && !isSpace && !isWin && isDT_15Line && !is15AllLine && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            Counting++;
                        }
                    }
                    else if (Teams == 3 && !isRead && !isSpace && !isWin && isDT_BullLine && !isBullAllLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
                    {
                        if (Counting == 0)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            Counting++;
                        }
                        else if (Counting == 1)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            Counting++;
                        }
                        else if (Counting == 2)
                        {
                            if (Players == 0)
                                DT1MarkCounting++;
                            else if (Players == 1)
                                DT2MarkCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            MPRScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            RoundScore(csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetBasicScore);
                            TeamScore[3] += csSingleton.getInstance.g_nTargetScore;
                            g_P_Score[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
                            g_OffScore[3].GetComponent<csNumber>().SetNumber(TeamScore[3]);
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
                    else if (Teams == 1 && Players == 0)
                        BT1MarkCounting++;
                    else if (Teams == 1 && Players == 1)
                        BT2MarkCounting++;
                    else if (Teams == 2 && Players == 0)
                        CT1MarkCounting++;
                    else if (Teams == 2 && Players == 1)
                        CT2MarkCounting++;
                    else if (Teams == 3 && Players == 0)
                        DT1MarkCounting++;
                    else if (Teams == 3 && Players == 1)
                        DT2MarkCounting++;
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
                RoundCountingA1++;
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
                RoundCountingA2++;
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
                Invoke("TeamNumberPlus", 5f);
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
                Invoke("TeamNumberPlus", 5f);
            }

            if (Players == 0 && isCT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingC1++;
                isSpace = false;
                gmg.DartScoreReSet();
                Invoke("TeamNumberPlus", 5f);
            }

            if (Players == 1 && isCT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingC2++;
                isSpace = false;
                gmg.DartScoreReSet();
                Invoke("TeamNumberPlus", 5f);
            }

            if (Players == 0 && isDT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RoundCountingD1++;
                isSpace = false;
                gmg.DartScoreReSet();
                RoundRead();
                Invoke("TeamNumberMinus", 5f);
                Invoke("PlayerNumberPlus", 5f);
            }

            if (Players == 1 && isDT)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                RScore += 1;
                RoundCountingD2++;
                isSpace = false;
                gmg.DartScoreReSet();
                RoundRead();
                Invoke("PlayerNumberMinus", 5f);
                Invoke("TeamNumberMinus", 5f);

            }
        }
        if (Round == RoundStop && isDT && Counting == 4)
            GameEndRead();
        if (isATAllLine)
        {
            win = 0;
            isWin = true;
            isAT = true;
            isBT = false;
            isCT = false;
            isDT = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isBTAllLine)
        {
            win = 1;
            isWin = true;
            isAT = false;
            isBT = true;
            isCT = false;
            isDT = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isCTAllLine)
        {
            win = 2;
            isWin = true;
            isAT = false;
            isBT = false;
            isCT = true;
            isDT = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isDTAllLine)
        {
            win = 3;
            isWin = true;
            isAT = false;
            isBT = false;
            isCT = false;
            isDT = true;
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
        if (TeamScore[1] < TeamScore[0] && TeamScore[2] < TeamScore[0] && TeamScore[3] < TeamScore[0])
        {
            win = 0;
            isAT = true;
            isBT = false;
            isCT = false;
            isDT = false;
            isWin = true;
            WinRead();
        }

        if (TeamScore[0] < TeamScore[1] && TeamScore[2] < TeamScore[1] && TeamScore[3] < TeamScore[1])
        {
            win = 1;
            isBT = true;
            isAT = false;
            isCT = false;
            isDT = false;
            isWin = true;
            WinRead();
        }

        if (TeamScore[0] < TeamScore[2] && TeamScore[1] < TeamScore[2] && TeamScore[3] < TeamScore[2])
        {
            win = 2;
            isCT = true;
            isAT = false;
            isBT = false;
            isDT = false;
            isWin = true;
            WinRead();
        }

        if (TeamScore[0] < TeamScore[3] && TeamScore[1] < TeamScore[3] && TeamScore[2] < TeamScore[3])
        {
            win = 3;
            isAT = false;
            isBT = false;
            isCT = false;
            isDT = true;
            isWin = true;
            WinRead();
        }

        if (TeamScore[0] == TeamScore[1] && TeamScore[0] == TeamScore[2] &&
            TeamScore[0] == TeamScore[3] && TeamScore[1] == TeamScore[2] &&
            TeamScore[1] == TeamScore[3] && TeamScore[2] == TeamScore[3])
        {
            if (AverageBTotla < AverageATotla && AverageCTotla < AverageATotla && AverageDTotla < AverageATotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageBTotla && AverageCTotla < AverageBTotla && AverageDTotla < AverageBTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageCTotla && AverageBTotla < AverageCTotla && AverageDTotla < AverageCTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageDTotla && AverageBTotla < AverageDTotla && AverageCTotla < AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                WinRead();
            }
            if (AverageATotla == AverageBTotla && AverageATotla == AverageCTotla && AverageATotla == AverageDTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageBTotla == AverageCTotla && AverageBTotla == AverageDTotla &&
                AverageATotla != AverageBTotla && AverageATotla != AverageCTotla &&
                AverageATotla != AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            } //BC BD

            if (AverageCTotla == AverageDTotla
                && AverageBTotla != AverageCTotla && AverageBTotla != AverageDTotla
                && AverageATotla != AverageBTotla && AverageATotla != AverageCTotla
                && AverageATotla != AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                WinRead();
            } //CD
        } //ALL

        if (TeamScore[0] == TeamScore[1] && TeamScore[0] == TeamScore[2] &&
           TeamScore[0] != TeamScore[3] && TeamScore[1] != TeamScore[3] &&
           TeamScore[2] != TeamScore[3])
        {
            if (AverageBTotla < AverageATotla && AverageCTotla < AverageATotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageBTotla && AverageCTotla < AverageBTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageCTotla && AverageBTotla < AverageCTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                WinRead();
            }
            if (AverageATotla == AverageBTotla && AverageATotla == AverageCTotla && AverageBTotla != AverageCTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageBTotla == AverageDTotla && AverageATotla != AverageBTotla && AverageATotla != AverageCTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla == AverageDTotla && AverageATotla != AverageBTotla && AverageDTotla != AverageBTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla == AverageBTotla && AverageATotla == AverageCTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
        }  //ABC

        if (TeamScore[0] == TeamScore[2] && TeamScore[0] == TeamScore[3] &&
            TeamScore[2] == TeamScore[3] && TeamScore[0] != TeamScore[1] &&
            TeamScore[2] != TeamScore[1] && TeamScore[3] != TeamScore[1])
        {
            if (AverageBTotla < AverageATotla && AverageDTotla < AverageATotla)
            {
                isWin = false;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageBTotla && AverageDTotla < AverageBTotla)
            {
                isWin = false;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageDTotla && AverageBTotla < AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                WinRead();
            }
            if (AverageATotla == AverageBTotla && AverageATotla == AverageDTotla && AverageBTotla != AverageDTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageBTotla == AverageDTotla && AverageATotla != AverageBTotla && AverageATotla != AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla == AverageDTotla && AverageATotla != AverageBTotla && AverageDTotla != AverageBTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla == AverageBTotla && AverageATotla == AverageDTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
        } //ACD

        if (TeamScore[0] == TeamScore[1] && TeamScore[0] == TeamScore[3] &&
            TeamScore[1] == TeamScore[3] && TeamScore[0] != TeamScore[2] &&
            TeamScore[1] != TeamScore[2] && TeamScore[3] != TeamScore[2])
        {
            if (AverageBTotla < AverageATotla && AverageDTotla < AverageATotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageBTotla && AverageDTotla < AverageBTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageDTotla && AverageCTotla < AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                WinRead();
            }
            if (AverageATotla == AverageBTotla && AverageATotla == AverageDTotla && AverageBTotla != AverageDTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageBTotla == AverageDTotla && AverageBTotla != AverageATotla && AverageDTotla != AverageATotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla == AverageDTotla && AverageBTotla != AverageATotla && AverageBTotla != AverageDTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla == AverageBTotla && AverageATotla == AverageDTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
        } //ABD

        if (TeamScore[1] == TeamScore[2] && TeamScore[1] == TeamScore[3] &&
            TeamScore[2] == TeamScore[3] && TeamScore[1] != TeamScore[0] &&
            TeamScore[2] != TeamScore[0] && TeamScore[3] != TeamScore[0])
        {
            if (AverageCTotla < AverageBTotla && AverageDTotla < AverageBTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageBTotla < AverageCTotla && AverageDTotla < AverageCTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                WinRead();
            }
            if (AverageBTotla < AverageDTotla && AverageCTotla < AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                WinRead();
            }
            if (AverageBTotla == AverageCTotla && AverageBTotla == AverageDTotla && AverageCTotla != AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageCTotla == AverageDTotla && AverageBTotla != AverageCTotla && AverageBTotla != AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                WinRead();
            }
            if (AverageBTotla == AverageDTotla && AverageCTotla != AverageBTotla && AverageCTotla != AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageBTotla == AverageCTotla && AverageBTotla == AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
        } //BCD

        if (TeamScore[0] == TeamScore[1] && TeamScore[0] != TeamScore[2] &&
            TeamScore[0] != TeamScore[3] && TeamScore[1] != TeamScore[2] &&
            TeamScore[1] != TeamScore[3] && TeamScore[2] != TeamScore[3])
        {
            if (AverageBTotla < AverageATotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageBTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla == AverageBTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
        } //A B

        if (TeamScore[0] == TeamScore[2] && TeamScore[0] != TeamScore[1] &&
            TeamScore[0] != TeamScore[3] && TeamScore[1] != TeamScore[2] &&
            TeamScore[1] != TeamScore[3] && TeamScore[2] != TeamScore[3])
        {
            if (AverageCTotla < AverageATotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageCTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                WinRead();
            }
            if (AverageATotla == AverageCTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
        } //A C

        if (TeamScore[0] == TeamScore[3] && TeamScore[0] != TeamScore[1] &&
            TeamScore[0] != TeamScore[2] && TeamScore[1] != TeamScore[2] &&
            TeamScore[1] != TeamScore[3] && TeamScore[2] != TeamScore[3])
        {
            if (AverageDTotla < AverageATotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageATotla < AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                WinRead();
            }
            if (AverageATotla == AverageDTotla)
            {
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                WinRead();
            }
        } //A D

        if (TeamScore[1] == TeamScore[2] && TeamScore[0] != TeamScore[1] &&
            TeamScore[0] != TeamScore[2] && TeamScore[0] != TeamScore[3] &&
            TeamScore[1] != TeamScore[3] && TeamScore[2] != TeamScore[3])
        {
            if (AverageBTotla < AverageCTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                WinRead();
            }
            if (AverageCTotla < AverageBTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageBTotla == AverageCTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
        } //B C

        if (TeamScore[1] == TeamScore[3] && TeamScore[0] != TeamScore[1] &&
            TeamScore[0] != TeamScore[2] && TeamScore[0] != TeamScore[3] &&
            TeamScore[1] != TeamScore[2] && TeamScore[2] != TeamScore[3])
        {
            if (AverageBTotla < AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                WinRead();
            }
            if (AverageDTotla < AverageBTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
            if (AverageBTotla == AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                WinRead();
            }
        } //B D

        if (TeamScore[2] == TeamScore[3] && TeamScore[0] != TeamScore[1] &&
            TeamScore[0] != TeamScore[2] && TeamScore[0] != TeamScore[3] &&
            TeamScore[1] != TeamScore[2] && TeamScore[1] != TeamScore[3])
        {
            if (AverageCTotla < AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                WinRead();
            }
            if (AverageDTotla < AverageCTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                WinRead();
            }
            if (AverageCTotla == AverageDTotla)
            {
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                WinRead();
            }
        } //C D

    }

    void WinRead()
    {
        if (isAT && !isBT && !isCT && !isDT)
        {
            win = 0;
            isWin = true;
            isAT = true;
            isBT = false;
            isCT = false;
            isDT = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isBT && !isCT && !isDT && !isAT)
        {
            win = 1;
            isWin = true;
            isAT = false;
            isBT = true;
            isCT = false;
            isDT = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isCT && !isDT && !isAT && !isBT)
        {
            win = 2;
            isWin = true;
            isAT = false;
            isBT = false;
            isCT = true;
            isDT = false;
            g_P_Ani.SetActive(false);
            gmg.GameEndRead(win);
        }
        if (isDT && !isAT && !isBT && !isCT)
        {
            win = 3;
            isWin = true;
            isAT = false;
            isBT = false;
            isCT = false;
            isDT = true;
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
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);
            g_DT.transform.position = new Vector3(g_DT.transform.position.x, g_DT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_DT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[0];
            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOff[0];
            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOff[0];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];

            g_P_Score[0].SetActive(true);
            g_P_Score[1].SetActive(false);
            g_P_Score[2].SetActive(false);
            g_P_Score[3].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);
            g_OffScore[3].SetActive(true);

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
                i_RScoreC1[i].enabled = false;
                i_RScoreC2[i].enabled = false;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = false;
            }
        }

        if (isAT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);
            g_DT.transform.position = new Vector3(g_DT.transform.position.x, g_DT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_DT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[1];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[1];
            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOff[1];
            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOff[1];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];

            g_P_Score[0].SetActive(true);
            g_P_Score[1].SetActive(false);
            g_P_Score[2].SetActive(false);
            g_P_Score[3].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);
            g_OffScore[3].SetActive(true);

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
                i_RScoreC1[i].enabled = false;
                i_RScoreC2[i].enabled = false;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = false;
            }
        }

        if (isBT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);
            g_DT.transform.position = new Vector3(g_DT.transform.position.x, g_DT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_DT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOn[0];
            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOff[0];
            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOff[0];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[0];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_P_Score[1].SetActive(true);
            g_P_Score[2].SetActive(false);
            g_P_Score[3].SetActive(false);
            g_P_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[2].SetActive(true);
            g_OffScore[3].SetActive(true);
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
                i_RScoreC1[i].enabled = false;
                i_RScoreC2[i].enabled = false;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = false;
            }
        }

        if (isBT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);
            g_DT.transform.position = new Vector3(g_DT.transform.position.x, g_DT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_DT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOn[1];
            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOff[1];
            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOff[1];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[1];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_P_Score[1].SetActive(true);
            g_P_Score[2].SetActive(false);
            g_P_Score[3].SetActive(false);
            g_P_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[2].SetActive(true);
            g_OffScore[3].SetActive(true);
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
                i_RScoreC1[i].enabled = false;
                i_RScoreC2[i].enabled = false;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = false;
            }
        }

        if (isCT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, -10f);
            g_DT.transform.position = new Vector3(g_DT.transform.position.x, g_DT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(1f, 1f);
            g_DT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOn[0];
            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOff[0];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[0];

            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOn[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_P_Score[2].SetActive(true);
            g_P_Score[3].SetActive(false);
            g_P_Score[0].SetActive(false);
            g_P_Score[1].SetActive(false);

            g_OffScore[2].SetActive(false);
            g_OffScore[3].SetActive(true);
            g_OffScore[0].SetActive(true);
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
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreC1[i].enabled = true;
                i_RScoreC2[i].enabled = false;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = false;
            }
        }

        if (isCT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, -10f);
            g_DT.transform.position = new Vector3(g_DT.transform.position.x, g_DT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(1f, 1f);
            g_DT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOn[1];
            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOff[1];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[1];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[1];

            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOn[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_P_Score[2].SetActive(true);
            g_P_Score[3].SetActive(false);
            g_P_Score[0].SetActive(false);
            g_P_Score[1].SetActive(false);

            g_OffScore[2].SetActive(false);
            g_OffScore[3].SetActive(true);
            g_OffScore[0].SetActive(true);
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
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreC1[i].enabled = false;
                i_RScoreC2[i].enabled = true;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = false;
            }
        }

        if (isDT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);
            g_DT.transform.position = new Vector3(g_DT.transform.position.x, g_DT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_DT.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOn[0];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[0];
            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOff[0];

            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOn[3];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];

            g_P_Score[3].SetActive(true);
            g_P_Score[0].SetActive(false);
            g_P_Score[1].SetActive(false);
            g_P_Score[2].SetActive(false);

            g_OffScore[3].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);

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
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreC1[i].enabled = false;
                i_RScoreC2[i].enabled = false;
                i_RScoreD1[i].enabled = true;
                i_RScoreD2[i].enabled = false;
            }
        }

        if (isDT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);
            g_DT.transform.position = new Vector3(g_DT.transform.position.x, g_DT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_DT.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOn[1];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[1];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[1];
            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOff[1];

            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOn[3];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];

            g_P_Score[3].SetActive(true);
            g_P_Score[0].SetActive(false);
            g_P_Score[1].SetActive(false);
            g_P_Score[2].SetActive(false);

            g_OffScore[3].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);

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
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreC1[i].enabled = false;
                i_RScoreC2[i].enabled = false;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = true;
            }
        }
    }
    /*============서브적인 기능========================*/
    void ImageUp()
    {
        if (isAT && !isBT && !isCT && !isDT && Players == 0)
        {

            if (RScore == 5)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[5];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[3]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[4]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[5]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[6]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[7]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[8]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[9]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
            }

            if (RScore == 6)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[6];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[6]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[7]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[8]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[9]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
            }

            if (RScore == 7)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[7];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[9]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
            }

            if (RScore == 8)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[8];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];
            }

            if (RScore == 9)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[9];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
            }

            if (RScore == 10)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[10];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
            }

            if (RScore == 11)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[11];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];
            }

            if (RScore == 12)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[12];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];
            }

            if (RScore == 13)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[13];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[39]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[40]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[41]];
            }

            if (RScore == 14)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[14];

                g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];

                g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];
                g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];

                g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];
                g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];

                g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[39]];
                g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[40]];
                g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[41]];

                g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[42]];
                g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[43]];
                g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[44]];
            }
        }

        if (isAT && !isBT && !isCT && !isDT && Players == 1)
        {
            if (RScore == 5)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[5];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[3]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[4]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[5]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[6]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[7]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[8]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[9]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
            }

            if (RScore == 6)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[6];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[6]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[7]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[8]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[9]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
            }

            if (RScore == 7)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[7];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[9]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
            }

            if (RScore == 8)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[8];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
            }

            if (RScore == 9)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[9];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
            }

            if (RScore == 10)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[10];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
            }

            if (RScore == 11)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[11];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];
            }

            if (RScore == 12)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[12];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];
            }

            if (RScore == 13)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[13];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[39]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[40]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[41]];
            }

            if (RScore == 14)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[14];

                g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];

                g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];
                g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];

                g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];
                g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];

                g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[39]];
                g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[40]];
                g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[41]];

                g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[42]];
                g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[43]];
                g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[44]];
            }
        }

        if (isBT && !isCT && !isDT && !isAT && Players == 0)
        {

            if (RScore == 5)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[5];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[3]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[4]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[5]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[6]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[7]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[8]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[9]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
            }

            if (RScore == 6)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[6];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[6]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[7]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[8]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[9]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
            }

            if (RScore == 7)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[7];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[9]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
            }

            if (RScore == 8)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[8];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];
            }

            if (RScore == 9)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[9];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];

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

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
            }

            if (RScore == 11)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[11];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];
            }

            if (RScore == 12)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[12];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];
            }

            if (RScore == 13)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[13];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[39]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[40]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[41]];
            }

            if (RScore == 14)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[14];

                g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];

                g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];
                g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];

                g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];
                g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];

                g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[39]];
                g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[40]];
                g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[41]];

                g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[42]];
                g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[43]];
                g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[44]];
            }
        }

        if (isBT && !isCT && !isDT && !isAT && Players == 1)
        {
            if (RScore == 5)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[5];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[3]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[4]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[5]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[6]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[7]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[8]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[9]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
            }

            if (RScore == 6)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[6];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[6]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[7]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[8]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[9]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
            }

            if (RScore == 7)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[7];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[9]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
            }

            if (RScore == 8)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[8];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];
            }

            if (RScore == 9)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[9];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
            }

            if (RScore == 10)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[10];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
            }

            if (RScore == 11)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[11];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];
            }

            if (RScore == 12)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[12];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];
            }

            if (RScore == 13)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[13];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[39]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[40]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[41]];
            }

            if (RScore == 14)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[14];

                g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];

                g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];
                g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];

                g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];
                g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];

                g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[39]];
                g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[40]];
                g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[41]];

                g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[42]];
                g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[43]];
                g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[44]];
            }
        }

        if (isCT && !isDT && !isAT && !isBT && Players == 0)
        {

            if (RScore == 5)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[5];

                g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[3]];
                g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[4]];
                g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[5]];

                g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[6]];
                g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[7]];
                g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[8]];

                g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[9]];
                g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[10]];
                g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[11]];

                g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[12]];
                g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[13]];
                g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[14]];

                g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[15]];
                g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[16]];
                g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[17]];
            }

            if (RScore == 6)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[6];

                g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[6]];
                g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[7]];
                g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[8]];

                g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[9]];
                g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[10]];
                g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[11]];

                g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[12]];
                g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[13]];
                g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[14]];

                g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[15]];
                g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[16]];
                g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[17]];

                g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[18]];
                g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[19]];
                g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[20]];
            }

            if (RScore == 7)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[7];

                g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[9]];
                g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[10]];
                g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[11]];

                g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[12]];
                g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[13]];
                g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[14]];

                g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[15]];
                g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[16]];
                g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[17]];

                g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[18]];
                g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[19]];
                g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[20]];

                g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[21]];
                g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[22]];
                g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[23]];
            }

            if (RScore == 8)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[8];

                g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[12]];
                g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[13]];
                g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[14]];

                g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[15]];
                g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[16]];
                g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[17]];

                g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[18]];
                g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[19]];
                g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[20]];

                g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[21]];
                g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[22]];
                g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[23]];

                g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[24]];
                g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[25]];
                g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[26]];
            }

            if (RScore == 9)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[9];

                g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[15]];
                g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[16]];
                g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[17]];

                g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[18]];
                g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[19]];
                g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[20]];

                g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[21]];
                g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[22]];
                g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[23]];

                g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[24]];
                g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[25]];
                g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[26]];

                g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[27]];
                g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[28]];
                g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[29]];
            }

            if (RScore == 10)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[10];

                g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[18]];
                g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[19]];
                g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[20]];

                g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[21]];
                g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[22]];
                g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[23]];

                g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[24]];
                g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[25]];
                g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[26]];

                g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[27]];
                g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[28]];
                g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[29]];

                g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[30]];
                g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[31]];
                g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[32]];
            }

            if (RScore == 11)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[11];

                g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[21]];
                g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[22]];
                g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[23]];

                g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[24]];
                g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[25]];
                g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[26]];

                g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[27]];
                g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[28]];
                g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[29]];

                g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[30]];
                g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[31]];
                g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[32]];

                g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[33]];
                g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[34]];
                g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[35]];
            }

            if (RScore == 12)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[12];

                g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[24]];
                g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[25]];
                g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[26]];

                g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[27]];
                g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[28]];
                g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[29]];

                g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[30]];
                g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[31]];
                g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[32]];

                g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[33]];
                g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[34]];
                g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[35]];

                g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[36]];
                g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[37]];
                g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[38]];
            }

            if (RScore == 13)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[13];

                g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[27]];
                g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[28]];
                g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[29]];

                g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[30]];
                g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[31]];
                g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[32]];

                g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[33]];
                g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[34]];
                g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[35]];

                g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[36]];
                g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[37]];
                g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[38]];

                g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[39]];
                g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[40]];
                g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[41]];
            }

            if (RScore == 14)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[14];

                g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[30]];
                g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[31]];
                g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[32]];

                g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[33]];
                g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[34]];
                g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[35]];

                g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[36]];
                g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[37]];
                g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[38]];

                g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[39]];
                g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[40]];
                g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[41]];

                g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[42]];
                g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[43]];
                g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[44]];
            }
        }

        if (isCT && !isDT && !isAT && !isBT && Players == 1)
        {

            if (RScore == 5)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[5];

                g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[3]];
                g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[4]];
                g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[5]];

                g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[6]];
                g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[7]];
                g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[8]];

                g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[9]];
                g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[10]];
                g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[11]];

                g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[12]];
                g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[13]];
                g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[14]];

                g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[15]];
                g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[16]];
                g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[17]];
            }

            if (RScore == 6)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[6];

                g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[6]];
                g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[7]];
                g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[8]];

                g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[9]];
                g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[10]];
                g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[11]];

                g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[12]];
                g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[13]];
                g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[14]];

                g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[15]];
                g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[16]];
                g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[17]];

                g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[18]];
                g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[19]];
                g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[20]];
            }

            if (RScore == 7)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[7];

                g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[9]];
                g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[10]];
                g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[11]];

                g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[12]];
                g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[13]];
                g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[14]];

                g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[15]];
                g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[16]];
                g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[17]];

                g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[18]];
                g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[19]];
                g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[20]];

                g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[21]];
                g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[22]];
                g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[23]];
            }

            if (RScore == 8)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[8];

                g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[12]];
                g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[13]];
                g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[14]];

                g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[15]];
                g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[16]];
                g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[17]];

                g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[18]];
                g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[19]];
                g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[20]];

                g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[21]];
                g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[22]];
                g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[23]];

                g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[24]];
                g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[25]];
                g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[26]];
            }

            if (RScore == 9)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[9];

                g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[15]];
                g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[16]];
                g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[17]];

                g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[18]];
                g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[19]];
                g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[20]];

                g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[21]];
                g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[22]];
                g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[23]];

                g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[24]];
                g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[25]];
                g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[26]];

                g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[27]];
                g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[28]];
                g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[29]];
            }

            if (RScore == 10)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[10];

                g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[18]];
                g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[19]];
                g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[20]];

                g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[21]];
                g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[22]];
                g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[23]];

                g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[24]];
                g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[25]];
                g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[26]];

                g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[27]];
                g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[28]];
                g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[29]];

                g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[30]];
                g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[31]];
                g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[32]];
            }

            if (RScore == 11)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[11];

                g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[21]];
                g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[22]];
                g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[23]];

                g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[24]];
                g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[25]];
                g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[26]];

                g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[27]];
                g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[28]];
                g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[29]];

                g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[30]];
                g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[31]];
                g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[32]];

                g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[33]];
                g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[34]];
                g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[35]];
            }

            if (RScore == 12)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[12];

                g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[24]];
                g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[25]];
                g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[26]];

                g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[27]];
                g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[28]];
                g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[29]];

                g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[30]];
                g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[31]];
                g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[32]];

                g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[33]];
                g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[34]];
                g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[35]];

                g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[36]];
                g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[37]];
                g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[38]];
            }

            if (RScore == 13)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[13];

                g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[27]];
                g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[28]];
                g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[29]];

                g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[30]];
                g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[31]];
                g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[32]];

                g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[33]];
                g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[34]];
                g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[35]];

                g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[36]];
                g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[37]];
                g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[38]];

                g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[39]];
                g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[40]];
                g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[41]];
            }

            if (RScore == 14)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[14];

                g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[30]];
                g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[31]];
                g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[32]];

                g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[33]];
                g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[34]];
                g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[35]];

                g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[36]];
                g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[37]];
                g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[38]];

                g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[39]];
                g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[40]];
                g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[41]];

                g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[42]];
                g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[43]];
                g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[44]];
            }
        }

        if (isDT && !isAT && !isBT && !isCT && Players == 0)
        {
            if (RScore == 5)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[5];

                g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[3]];
                g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[4]];
                g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[5]];

                g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[6]];
                g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[7]];
                g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[8]];

                g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[9]];
                g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[10]];
                g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[11]];

                g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[12]];
                g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[13]];
                g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[14]];

                g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[15]];
                g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[16]];
                g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[17]];
            }

            if (RScore == 6)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[6];

                g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[6]];
                g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[7]];
                g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[8]];

                g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[9]];
                g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[10]];
                g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[11]];

                g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[12]];
                g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[13]];
                g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[14]];

                g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[15]];
                g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[16]];
                g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[17]];

                g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[18]];
                g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[19]];
                g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[20]];
            }

            if (RScore == 7)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[7];

                g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[9]];
                g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[10]];
                g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[11]];

                g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[12]];
                g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[13]];
                g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[14]];

                g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[15]];
                g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[16]];
                g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[17]];

                g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[18]];
                g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[19]];
                g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[20]];

                g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[21]];
                g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[22]];
                g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[23]];
            }

            if (RScore == 8)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[8];

                g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[12]];
                g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[13]];
                g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[14]];

                g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[15]];
                g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[16]];
                g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[17]];

                g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[18]];
                g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[19]];
                g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[20]];

                g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[21]];
                g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[22]];
                g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[23]];

                g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[24]];
                g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[25]];
                g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[26]];
            }

            if (RScore == 9)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[9];

                g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[15]];
                g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[16]];
                g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[17]];

                g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[18]];
                g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[19]];
                g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[20]];

                g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[21]];
                g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[22]];
                g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[23]];

                g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[24]];
                g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[25]];
                g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[26]];

                g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[27]];
                g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[28]];
                g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[29]];
            }

            if (RScore == 10)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[10];

                g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[18]];
                g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[19]];
                g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[20]];

                g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[21]];
                g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[22]];
                g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[23]];

                g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[24]];
                g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[25]];
                g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[26]];

                g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[27]];
                g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[28]];
                g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[29]];

                g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[30]];
                g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[31]];
                g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[32]];
            }

            if (RScore == 11)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[11];

                g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[21]];
                g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[22]];
                g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[23]];

                g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[24]];
                g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[25]];
                g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[26]];

                g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[27]];
                g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[28]];
                g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[29]];

                g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[30]];
                g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[31]];
                g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[32]];

                g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[33]];
                g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[34]];
                g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[35]];
            }

            if (RScore == 12)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[12];

                g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[24]];
                g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[25]];
                g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[26]];

                g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[27]];
                g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[28]];
                g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[29]];

                g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[30]];
                g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[31]];
                g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[32]];

                g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[33]];
                g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[34]];
                g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[35]];

                g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[36]];
                g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[37]];
                g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[38]];
            }

            if (RScore == 13)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[13];

                g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[27]];
                g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[28]];
                g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[29]];

                g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[30]];
                g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[31]];
                g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[32]];

                g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[33]];
                g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[34]];
                g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[35]];

                g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[36]];
                g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[37]];
                g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[38]];

                g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[39]];
                g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[40]];
                g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[41]];
            }

            if (RScore == 14)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[14];

                g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[30]];
                g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[31]];
                g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[32]];

                g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[33]];
                g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[34]];
                g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[35]];

                g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[36]];
                g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[37]];
                g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[38]];

                g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[39]];
                g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[40]];
                g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[41]];

                g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[42]];
                g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[43]];
                g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[44]];
            }
        }

        if (isDT && !isAT && !isBT && !isCT && Players == 1)
        {

            if (RScore == 5)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[5];

                g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[3]];
                g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[4]];
                g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[5]];

                g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[6]];
                g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[7]];
                g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[8]];

                g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[9]];
                g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[10]];
                g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[11]];

                g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[12]];
                g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[13]];
                g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[14]];

                g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[15]];
                g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[16]];
                g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[17]];
            }

            if (RScore == 6)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[6];

                g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[6]];
                g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[7]];
                g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[8]];

                g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[9]];
                g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[10]];
                g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[11]];

                g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[12]];
                g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[13]];
                g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[14]];

                g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[15]];
                g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[16]];
                g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[17]];

                g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[18]];
                g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[19]];
                g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[20]];
            }

            if (RScore == 7)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[7];

                g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[9]];
                g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[10]];
                g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[11]];

                g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[12]];
                g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[13]];
                g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[14]];

                g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[15]];
                g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[16]];
                g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[17]];

                g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[18]];
                g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[19]];
                g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[20]];

                g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[21]];
                g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[22]];
                g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[23]];
            }

            if (RScore == 8)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[8];

                g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[12]];
                g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[13]];
                g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[14]];

                g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[15]];
                g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[16]];
                g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[17]];

                g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[18]];
                g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[19]];
                g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[20]];

                g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[21]];
                g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[22]];
                g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[23]];

                g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[24]];
                g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[25]];
                g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[26]];
            }

            if (RScore == 9)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[9];

                g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[15]];
                g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[16]];
                g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[17]];

                g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[18]];
                g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[19]];
                g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[20]];

                g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[21]];
                g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[22]];
                g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[23]];

                g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[24]];
                g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[25]];
                g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[26]];

                g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[27]];
                g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[28]];
                g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[29]];
            }

            if (RScore == 10)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[10];

                g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[18]];
                g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[19]];
                g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[20]];

                g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[21]];
                g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[22]];
                g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[23]];

                g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[24]];
                g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[25]];
                g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[26]];

                g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[27]];
                g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[28]];
                g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[29]];

                g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[30]];
                g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[31]];
                g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[32]];
            }

            if (RScore == 11)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[11];

                g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[21]];
                g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[22]];
                g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[23]];

                g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[24]];
                g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[25]];
                g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[26]];

                g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[27]];
                g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[28]];
                g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[29]];

                g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[30]];
                g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[31]];
                g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[32]];

                g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[33]];
                g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[34]];
                g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[35]];
            }

            if (RScore == 12)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[12];

                g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[24]];
                g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[25]];
                g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[26]];

                g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[27]];
                g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[28]];
                g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[29]];

                g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[30]];
                g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[31]];
                g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[32]];

                g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[33]];
                g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[34]];
                g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[35]];

                g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[36]];
                g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[37]];
                g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[38]];
            }

            if (RScore == 13)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[13];

                g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[27]];
                g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[28]];
                g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[29]];

                g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[30]];
                g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[31]];
                g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[32]];

                g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[33]];
                g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[34]];
                g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[35]];

                g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[36]];
                g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[37]];
                g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[38]];

                g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[39]];
                g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[40]];
                g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[41]];
            }

            if (RScore == 14)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[14];

                g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[30]];
                g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[31]];
                g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[32]];

                g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[33]];
                g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[34]];
                g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[35]];

                g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[36]];
                g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[37]];
                g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[38]];

                g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[39]];
                g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[40]];
                g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[41]];

                g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[42]];
                g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[43]];
                g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[44]];
            }
        }
    }
    void RoundScore(int MarkScore)
    {
        if (isAT && !isBT && !isCT && !isDT && Players == 0)
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
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[3]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[4]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[5]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[6]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[7]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[8]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[9]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];
                }
                if (RScore == 6)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[6]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[7]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[8]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[9]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];
                }
                if (RScore == 7)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[9]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[10]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[11]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];
                }
                if (RScore == 8)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[12]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[13]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[14]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];

                }
                if (RScore == 9)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[15]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[16]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[17]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];
                }
                if (RScore == 10)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[18]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[19]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[20]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];
                }
                if (RScore == 11)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[21]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[22]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[23]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];
                }
                if (RScore == 12)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[24]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[25]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[26]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];
                }
                if (RScore == 13)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[27]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[28]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[29]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[40]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[41]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[42]];
                }
                if (RScore == 14)
                {
                    g_AT1RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[30]];
                    g_AT1RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[31]];
                    g_AT1RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[32]];

                    g_AT1RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[33]];
                    g_AT1RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[34]];
                    g_AT1RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[35]];

                    g_AT1RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[36]];
                    g_AT1RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[37]];
                    g_AT1RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[38]];

                    g_AT1RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[39]];
                    g_AT1RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[40]];
                    g_AT1RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[41]];

                    g_AT1RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[42]];
                    g_AT1RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[43]];
                    g_AT1RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT1[44]];
                }
            }
        }

        if (isAT && !isBT && !isCT && !isDT && Players == 1)
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
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[3]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[4]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[5]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[6]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[7]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[8]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[9]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];
                }
                if (RScore == 6)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[6]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[7]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[8]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[9]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];
                }
                if (RScore == 7)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[9]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[10]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[11]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];
                }
                if (RScore == 8)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[12]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[13]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[14]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];
                }
                if (RScore == 9)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[15]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[16]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[17]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];
                }
                if (RScore == 10)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[18]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[19]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[20]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];
                }
                if (RScore == 11)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[21]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[22]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[23]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];
                }
                if (RScore == 12)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[24]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[25]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[26]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];
                }
                if (RScore == 13)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[27]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[28]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[29]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[40]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[41]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[42]];
                }
                if (RScore == 14)
                {
                    g_AT2RMark1[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[30]];
                    g_AT2RMark1[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[31]];
                    g_AT2RMark1[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[32]];

                    g_AT2RMark2[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[33]];
                    g_AT2RMark2[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[34]];
                    g_AT2RMark2[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[35]];

                    g_AT2RMark3[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[36]];
                    g_AT2RMark3[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[37]];
                    g_AT2RMark3[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[38]];

                    g_AT2RMark4[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[39]];
                    g_AT2RMark4[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[40]];
                    g_AT2RMark4[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[41]];

                    g_AT2RMark5[0].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[42]];
                    g_AT2RMark5[1].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[43]];
                    g_AT2RMark5[2].GetComponent<Image>().sprite = s_ATMark[MarkSaveAT2[44]];
                }
            }
        }

        if (isBT && !isCT && !isDT && !isAT && Players == 0)
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
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[3]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[4]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[5]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[6]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[7]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[8]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[9]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];
                }
                if (RScore == 6)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[6]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[7]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[8]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[9]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];
                }
                if (RScore == 7)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[9]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[10]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[11]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];
                }
                if (RScore == 8)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[12]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[13]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[14]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];

                }
                if (RScore == 9)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[15]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[16]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[17]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];
                }
                if (RScore == 10)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[18]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[19]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[20]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];
                }
                if (RScore == 11)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[21]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[22]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[23]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];
                }
                if (RScore == 12)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[24]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[25]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[26]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];
                }
                if (RScore == 13)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[27]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[28]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[29]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[40]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[41]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[42]];
                }
                if (RScore == 14)
                {
                    g_BT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[30]];
                    g_BT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[31]];
                    g_BT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[32]];

                    g_BT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[33]];
                    g_BT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[34]];
                    g_BT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[35]];

                    g_BT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[36]];
                    g_BT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[37]];
                    g_BT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[38]];

                    g_BT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[39]];
                    g_BT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[40]];
                    g_BT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[41]];

                    g_BT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[42]];
                    g_BT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[43]];
                    g_BT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT1[44]];
                }
            }
        }

        if (isBT && !isCT && !isDT && !isAT && Players == 1)
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
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[3]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[4]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[5]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[6]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[7]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[8]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[9]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];
                }
                if (RScore == 6)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[6]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[7]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[8]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[9]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];
                }
                if (RScore == 7)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[9]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[10]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[11]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];
                }
                if (RScore == 8)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[12]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[13]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[14]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];

                }
                if (RScore == 9)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[15]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[16]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[17]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];
                }
                if (RScore == 10)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[18]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[19]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[20]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];
                }
                if (RScore == 11)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[21]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[22]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[23]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];
                }
                if (RScore == 12)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[24]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[25]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[26]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];
                }
                if (RScore == 13)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[27]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[28]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[29]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[40]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[41]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[42]];
                }
                if (RScore == 14)
                {
                    g_BT2RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[30]];
                    g_BT2RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[31]];
                    g_BT2RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[32]];

                    g_BT2RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[33]];
                    g_BT2RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[34]];
                    g_BT2RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[35]];

                    g_BT2RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[36]];
                    g_BT2RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[37]];
                    g_BT2RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[38]];

                    g_BT2RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[39]];
                    g_BT2RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[40]];
                    g_BT2RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[41]];

                    g_BT2RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[42]];
                    g_BT2RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[43]];
                    g_BT2RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveBT2[44]];
                }
            }
        }

        if (isCT && !isDT && !isAT && !isBT && Players == 0)
        {
            MarkSaveCT1[CT1MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_CT1RMark1[Counting].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[CT1MarkCounting]];

                if (RScore == 1)
                    g_CT1RMark2[Counting].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[CT1MarkCounting]];

                if (RScore == 2)
                    g_CT1RMark3[Counting].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[CT1MarkCounting]];

                if (RScore == 3)
                    g_CT1RMark4[Counting].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[CT1MarkCounting]];

                if (RScore == 4)
                    g_CT1RMark5[Counting].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[CT1MarkCounting]];

                if (RScore == 5)
                {
                    g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[3]];
                    g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[4]];
                    g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[5]];

                    g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[6]];
                    g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[7]];
                    g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[8]];

                    g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[9]];
                    g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[10]];
                    g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[11]];

                    g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[12]];
                    g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[13]];
                    g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[14]];

                    g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[15]];
                    g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[16]];
                    g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[17]];
                }
                if (RScore == 6)
                {
                    g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[6]];
                    g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[7]];
                    g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[8]];

                    g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[9]];
                    g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[10]];
                    g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[11]];

                    g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[12]];
                    g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[13]];
                    g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[14]];

                    g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[15]];
                    g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[16]];
                    g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[17]];

                    g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[18]];
                    g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[19]];
                    g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[20]];
                }
                if (RScore == 7)
                {
                    g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[9]];
                    g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[10]];
                    g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[11]];

                    g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[12]];
                    g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[13]];
                    g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[14]];

                    g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[15]];
                    g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[16]];
                    g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[17]];

                    g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[18]];
                    g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[19]];
                    g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[20]];

                    g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[21]];
                    g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[22]];
                    g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[23]];
                }
                if (RScore == 8)
                {
                    g_CT1RMark1[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[12]];
                    g_CT1RMark1[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[13]];
                    g_CT1RMark1[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[14]];

                    g_CT1RMark2[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[15]];
                    g_CT1RMark2[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[16]];
                    g_CT1RMark2[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[17]];

                    g_CT1RMark3[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[18]];
                    g_CT1RMark3[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[19]];
                    g_CT1RMark3[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[20]];

                    g_CT1RMark4[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[21]];
                    g_CT1RMark4[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[22]];
                    g_CT1RMark4[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[23]];

                    g_CT1RMark5[0].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[24]];
                    g_CT1RMark5[1].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[25]];
                    g_CT1RMark5[2].GetComponent<Image>().sprite = s_BTMark[MarkSaveCT1[26]];

                }
                if (RScore == 9)
                {
                    g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[15]];
                    g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[16]];
                    g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[17]];

                    g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[18]];
                    g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[19]];
                    g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[20]];

                    g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[21]];
                    g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[22]];
                    g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[23]];

                    g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[24]];
                    g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[25]];
                    g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[26]];

                    g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[27]];
                    g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[28]];
                    g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[29]];
                }
                if (RScore == 10)
                {
                    g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[18]];
                    g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[19]];
                    g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[20]];

                    g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[21]];
                    g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[22]];
                    g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[23]];

                    g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[24]];
                    g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[25]];
                    g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[26]];

                    g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[27]];
                    g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[28]];
                    g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[29]];

                    g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[30]];
                    g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[31]];
                    g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[32]];
                }
                if (RScore == 11)
                {
                    g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[21]];
                    g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[22]];
                    g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[23]];

                    g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[24]];
                    g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[25]];
                    g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[26]];

                    g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[27]];
                    g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[28]];
                    g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[29]];

                    g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[30]];
                    g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[31]];
                    g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[32]];

                    g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[33]];
                    g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[34]];
                    g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[35]];
                }
                if (RScore == 12)
                {
                    g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[24]];
                    g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[25]];
                    g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[26]];

                    g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[27]];
                    g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[28]];
                    g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[29]];

                    g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[30]];
                    g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[31]];
                    g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[32]];

                    g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[33]];
                    g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[34]];
                    g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[35]];

                    g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[36]];
                    g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[37]];
                    g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[38]];
                }
                if (RScore == 13)
                {
                    g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[27]];
                    g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[28]];
                    g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[29]];

                    g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[30]];
                    g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[31]];
                    g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[32]];

                    g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[33]];
                    g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[34]];
                    g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[35]];

                    g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[36]];
                    g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[37]];
                    g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[38]];

                    g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[40]];
                    g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[41]];
                    g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[42]];
                }
                if (RScore == 14)
                {
                    g_CT1RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[30]];
                    g_CT1RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[31]];
                    g_CT1RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[32]];

                    g_CT1RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[33]];
                    g_CT1RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[34]];
                    g_CT1RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[35]];

                    g_CT1RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[36]];
                    g_CT1RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[37]];
                    g_CT1RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[38]];

                    g_CT1RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[39]];
                    g_CT1RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[40]];
                    g_CT1RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[41]];

                    g_CT1RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[42]];
                    g_CT1RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[43]];
                    g_CT1RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT1[44]];
                }
            }
        }

        if (isCT && !isDT && !isAT && !isBT && Players == 1)
        {
            MarkSaveCT2[CT2MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_CT2RMark1[Counting].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[CT2MarkCounting]];

                if (RScore == 1)
                    g_CT2RMark2[Counting].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[CT2MarkCounting]];

                if (RScore == 2)
                    g_CT2RMark3[Counting].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[CT2MarkCounting]];

                if (RScore == 3)
                    g_CT2RMark4[Counting].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[CT2MarkCounting]];

                if (RScore == 4)
                    g_CT2RMark5[Counting].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[CT2MarkCounting]];

                if (RScore == 5)
                {
                    g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[3]];
                    g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[4]];
                    g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[5]];

                    g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[6]];
                    g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[7]];
                    g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[8]];

                    g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[9]];
                    g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[10]];
                    g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[11]];

                    g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[12]];
                    g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[13]];
                    g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[14]];

                    g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[15]];
                    g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[16]];
                    g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[17]];
                }
                if (RScore == 6)
                {
                    g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[6]];
                    g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[7]];
                    g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[8]];

                    g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[9]];
                    g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[10]];
                    g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[11]];

                    g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[12]];
                    g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[13]];
                    g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[14]];

                    g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[15]];
                    g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[16]];
                    g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[17]];

                    g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[18]];
                    g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[19]];
                    g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[20]];
                }
                if (RScore == 7)
                {
                    g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[9]];
                    g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[10]];
                    g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[11]];

                    g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[12]];
                    g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[13]];
                    g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[14]];

                    g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[15]];
                    g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[16]];
                    g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[17]];

                    g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[18]];
                    g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[19]];
                    g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[20]];

                    g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[21]];
                    g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[22]];
                    g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[23]];
                }
                if (RScore == 8)
                {
                    g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[12]];
                    g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[13]];
                    g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[14]];

                    g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[15]];
                    g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[16]];
                    g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[17]];

                    g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[18]];
                    g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[19]];
                    g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[20]];

                    g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[21]];
                    g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[22]];
                    g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[23]];

                    g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[24]];
                    g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[25]];
                    g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[26]];

                }
                if (RScore == 9)
                {
                    g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[15]];
                    g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[16]];
                    g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[17]];

                    g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[18]];
                    g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[19]];
                    g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[20]];

                    g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[21]];
                    g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[22]];
                    g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[23]];

                    g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[24]];
                    g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[25]];
                    g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[26]];

                    g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[27]];
                    g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[28]];
                    g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[29]];
                }
                if (RScore == 10)
                {
                    g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[18]];
                    g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[19]];
                    g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[20]];

                    g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[21]];
                    g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[22]];
                    g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[23]];

                    g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[24]];
                    g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[25]];
                    g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[26]];

                    g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[27]];
                    g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[28]];
                    g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[29]];

                    g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[30]];
                    g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[31]];
                    g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[32]];
                }
                if (RScore == 11)
                {
                    g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[21]];
                    g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[22]];
                    g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[23]];

                    g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[24]];
                    g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[25]];
                    g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[26]];

                    g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[27]];
                    g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[28]];
                    g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[29]];

                    g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[30]];
                    g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[31]];
                    g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[32]];

                    g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[33]];
                    g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[34]];
                    g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[35]];
                }
                if (RScore == 12)
                {
                    g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[24]];
                    g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[25]];
                    g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[26]];

                    g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[27]];
                    g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[28]];
                    g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[29]];

                    g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[30]];
                    g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[31]];
                    g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[32]];

                    g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[33]];
                    g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[34]];
                    g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[35]];

                    g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[36]];
                    g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[37]];
                    g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[38]];
                }
                if (RScore == 13)
                {
                    g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[27]];
                    g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[28]];
                    g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[29]];

                    g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[30]];
                    g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[31]];
                    g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[32]];

                    g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[33]];
                    g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[34]];
                    g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[35]];

                    g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[36]];
                    g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[37]];
                    g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[38]];

                    g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[40]];
                    g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[41]];
                    g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[42]];
                }
                if (RScore == 14)
                {
                    g_CT2RMark1[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[30]];
                    g_CT2RMark1[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[31]];
                    g_CT2RMark1[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[32]];

                    g_CT2RMark2[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[33]];
                    g_CT2RMark2[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[34]];
                    g_CT2RMark2[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[35]];

                    g_CT2RMark3[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[36]];
                    g_CT2RMark3[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[37]];
                    g_CT2RMark3[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[38]];

                    g_CT2RMark4[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[39]];
                    g_CT2RMark4[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[40]];
                    g_CT2RMark4[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[41]];

                    g_CT2RMark5[0].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[42]];
                    g_CT2RMark5[1].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[43]];
                    g_CT2RMark5[2].GetComponent<Image>().sprite = s_CTMark[MarkSaveCT2[44]];
                }
            }
        }

        if (isDT && !isAT && !isBT && !isCT && Players == 0)
        {
            MarkSaveDT1[DT1MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_DT1RMark1[Counting].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[DT1MarkCounting]];

                if (RScore == 1)
                    g_DT1RMark2[Counting].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[DT1MarkCounting]];

                if (RScore == 2)
                    g_DT1RMark3[Counting].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[DT1MarkCounting]];

                if (RScore == 3)
                    g_DT1RMark4[Counting].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[DT1MarkCounting]];

                if (RScore == 4)
                    g_DT1RMark5[Counting].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[DT1MarkCounting]];

                if (RScore == 5)
                {
                    g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[3]];
                    g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[4]];
                    g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[5]];

                    g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[6]];
                    g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[7]];
                    g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[8]];

                    g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[9]];
                    g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[10]];
                    g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[11]];

                    g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[12]];
                    g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[13]];
                    g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[14]];

                    g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[15]];
                    g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[16]];
                    g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[17]];
                }
                if (RScore == 6)
                {
                    g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[6]];
                    g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[7]];
                    g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[8]];

                    g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[9]];
                    g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[10]];
                    g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[11]];

                    g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[12]];
                    g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[13]];
                    g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[14]];

                    g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[15]];
                    g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[16]];
                    g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[17]];

                    g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[18]];
                    g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[19]];
                    g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[20]];
                }
                if (RScore == 7)
                {
                    g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[9]];
                    g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[10]];
                    g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[11]];

                    g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[12]];
                    g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[13]];
                    g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[14]];

                    g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[15]];
                    g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[16]];
                    g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[17]];

                    g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[18]];
                    g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[19]];
                    g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[20]];

                    g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[21]];
                    g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[22]];
                    g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[23]];
                }
                if (RScore == 8)
                {
                    g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[12]];
                    g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[13]];
                    g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[14]];

                    g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[15]];
                    g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[16]];
                    g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[17]];

                    g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[18]];
                    g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[19]];
                    g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[20]];

                    g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[21]];
                    g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[22]];
                    g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[23]];

                    g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[24]];
                    g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[25]];
                    g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[26]];

                }
                if (RScore == 9)
                {
                    g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[15]];
                    g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[16]];
                    g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[17]];

                    g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[18]];
                    g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[19]];
                    g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[20]];

                    g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[21]];
                    g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[22]];
                    g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[23]];

                    g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[24]];
                    g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[25]];
                    g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[26]];

                    g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[27]];
                    g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[28]];
                    g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[29]];
                }
                if (RScore == 10)
                {
                    g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[18]];
                    g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[19]];
                    g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[20]];

                    g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[21]];
                    g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[22]];
                    g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[23]];

                    g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[24]];
                    g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[25]];
                    g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[26]];

                    g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[27]];
                    g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[28]];
                    g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[29]];

                    g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[30]];
                    g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[31]];
                    g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[32]];
                }
                if (RScore == 11)
                {
                    g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[21]];
                    g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[22]];
                    g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[23]];

                    g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[24]];
                    g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[25]];
                    g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[26]];

                    g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[27]];
                    g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[28]];
                    g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[29]];

                    g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[30]];
                    g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[31]];
                    g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[32]];

                    g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[33]];
                    g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[34]];
                    g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[35]];
                }
                if (RScore == 12)
                {
                    g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[24]];
                    g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[25]];
                    g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[26]];

                    g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[27]];
                    g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[28]];
                    g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[29]];

                    g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[30]];
                    g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[31]];
                    g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[32]];

                    g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[33]];
                    g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[34]];
                    g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[35]];

                    g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[36]];
                    g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[37]];
                    g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[38]];
                }
                if (RScore == 13)
                {
                    g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[27]];
                    g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[28]];
                    g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[29]];

                    g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[30]];
                    g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[31]];
                    g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[32]];

                    g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[33]];
                    g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[34]];
                    g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[35]];

                    g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[36]];
                    g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[37]];
                    g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[38]];

                    g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[40]];
                    g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[41]];
                    g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[42]];
                }
                if (RScore == 14)
                {
                    g_DT1RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[30]];
                    g_DT1RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[31]];
                    g_DT1RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[32]];

                    g_DT1RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[33]];
                    g_DT1RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[34]];
                    g_DT1RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[35]];

                    g_DT1RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[36]];
                    g_DT1RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[37]];
                    g_DT1RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[38]];

                    g_DT1RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[39]];
                    g_DT1RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[40]];
                    g_DT1RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[41]];

                    g_DT1RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[42]];
                    g_DT1RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[43]];
                    g_DT1RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT1[44]];
                }
            }
        }

        if (isDT && !isAT && !isBT && !isCT && Players == 1)
        {
            MarkSaveDT2[DT2MarkCounting] = MarkScore;  //0이면 1마크 1이면 2마크 2이면 3마크
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    g_DT2RMark1[Counting].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[DT2MarkCounting]];

                if (RScore == 1)
                    g_DT2RMark2[Counting].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[DT2MarkCounting]];

                if (RScore == 2)
                    g_DT2RMark3[Counting].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[DT2MarkCounting]];

                if (RScore == 3)
                    g_DT2RMark4[Counting].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[DT2MarkCounting]];

                if (RScore == 4)
                    g_DT2RMark5[Counting].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[DT2MarkCounting]];

                if (RScore == 5)
                {
                    g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[3]];
                    g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[4]];
                    g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[5]];

                    g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[6]];
                    g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[7]];
                    g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[8]];

                    g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[9]];
                    g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[10]];
                    g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[11]];

                    g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[12]];
                    g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[13]];
                    g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[14]];

                    g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[15]];
                    g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[16]];
                    g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[17]];
                }
                if (RScore == 6)
                {
                    g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[6]];
                    g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[7]];
                    g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[8]];

                    g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[9]];
                    g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[10]];
                    g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[11]];

                    g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[12]];
                    g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[13]];
                    g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[14]];

                    g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[15]];
                    g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[16]];
                    g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[17]];

                    g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[18]];
                    g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[19]];
                    g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[20]];
                }
                if (RScore == 7)
                {
                    g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[9]];
                    g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[10]];
                    g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[11]];

                    g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[12]];
                    g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[13]];
                    g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[14]];

                    g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[15]];
                    g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[16]];
                    g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[17]];

                    g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[18]];
                    g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[19]];
                    g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[20]];

                    g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[21]];
                    g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[22]];
                    g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[23]];
                }
                if (RScore == 8)
                {
                    g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[12]];
                    g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[13]];
                    g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[14]];

                    g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[15]];
                    g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[16]];
                    g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[17]];

                    g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[18]];
                    g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[19]];
                    g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[20]];

                    g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[21]];
                    g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[22]];
                    g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[23]];

                    g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[24]];
                    g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[25]];
                    g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[26]];

                }
                if (RScore == 9)
                {
                    g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[15]];
                    g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[16]];
                    g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[17]];

                    g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[18]];
                    g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[19]];
                    g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[20]];

                    g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[21]];
                    g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[22]];
                    g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[23]];

                    g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[24]];
                    g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[25]];
                    g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[26]];

                    g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[27]];
                    g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[28]];
                    g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[29]];
                }
                if (RScore == 10)
                {
                    g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[18]];
                    g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[19]];
                    g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[20]];

                    g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[21]];
                    g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[22]];
                    g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[23]];

                    g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[24]];
                    g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[25]];
                    g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[26]];

                    g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[27]];
                    g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[28]];
                    g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[29]];

                    g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[30]];
                    g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[31]];
                    g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[32]];
                }
                if (RScore == 11)
                {
                    g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[21]];
                    g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[22]];
                    g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[23]];

                    g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[24]];
                    g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[25]];
                    g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[26]];

                    g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[27]];
                    g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[28]];
                    g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[29]];

                    g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[30]];
                    g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[31]];
                    g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[32]];

                    g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[33]];
                    g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[34]];
                    g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[35]];
                }
                if (RScore == 12)
                {
                    g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[24]];
                    g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[25]];
                    g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[26]];

                    g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[27]];
                    g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[28]];
                    g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[29]];

                    g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[30]];
                    g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[31]];
                    g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[32]];

                    g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[33]];
                    g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[34]];
                    g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[35]];

                    g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[36]];
                    g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[37]];
                    g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[38]];
                }
                if (RScore == 13)
                {
                    g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[27]];
                    g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[28]];
                    g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[29]];

                    g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[30]];
                    g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[31]];
                    g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[32]];

                    g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[33]];
                    g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[34]];
                    g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[35]];

                    g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[36]];
                    g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[37]];
                    g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[38]];

                    g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[40]];
                    g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[41]];
                    g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[42]];
                }
                if (RScore == 14)
                {
                    g_DT2RMark1[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[30]];
                    g_DT2RMark1[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[31]];
                    g_DT2RMark1[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[32]];

                    g_DT2RMark2[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[33]];
                    g_DT2RMark2[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[34]];
                    g_DT2RMark2[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[35]];

                    g_DT2RMark3[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[36]];
                    g_DT2RMark3[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[37]];
                    g_DT2RMark3[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[38]];

                    g_DT2RMark4[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[39]];
                    g_DT2RMark4[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[40]];
                    g_DT2RMark4[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[41]];

                    g_DT2RMark5[0].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[42]];
                    g_DT2RMark5[1].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[43]];
                    g_DT2RMark5[2].GetComponent<Image>().sprite = s_DTMark[MarkSaveDT2[44]];
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
        if (isCT && !isCT_20Line && CT_20LMark == _20Line * 2)
            g_CTMainMark[0].GetComponent<Image>().sprite = s_CTMark[1];
        else if (isCT && !isCT_20Line && CT_20LMark == _20Line)
            g_CTMainMark[0].GetComponent<Image>().sprite = s_CTMark[2];
        else if (isCT && !isCT_20Line && CT_20LMark <= 0)
        {
            isCT_20Line = true;
            g_CTMainMark[0].GetComponent<Image>().sprite = s_CTMark[3];
        }

        if (isCT && !isCT_19Line && CT_19LMark == _19Line * 2)
            g_CTMainMark[1].GetComponent<Image>().sprite = s_CTMark[1];
        else if (isCT && !isCT_19Line && CT_19LMark == _19Line)
            g_CTMainMark[1].GetComponent<Image>().sprite = s_CTMark[2];
        else if (isCT && !isCT_19Line && CT_19LMark <= 0)
        {
            isCT_19Line = true;
            g_CTMainMark[1].GetComponent<Image>().sprite = s_CTMark[3];
        }

        if (isCT && !isCT_18Line && CT_18LMark == _18Line * 2)
            g_CTMainMark[2].GetComponent<Image>().sprite = s_CTMark[1];
        else if (isCT && !isCT_18Line && CT_18LMark == _18Line)
            g_CTMainMark[2].GetComponent<Image>().sprite = s_CTMark[2];
        else if (isCT && !isCT_18Line && CT_18LMark <= 0)
        {
            isCT_18Line = true;
            g_CTMainMark[2].GetComponent<Image>().sprite = s_CTMark[3];
        }

        if (isCT && !isCT_17Line && CT_17LMark == _17Line * 2)
            g_CTMainMark[3].GetComponent<Image>().sprite = s_CTMark[1];
        else if (isCT && !isCT_17Line && CT_17LMark == _17Line)
            g_CTMainMark[3].GetComponent<Image>().sprite = s_CTMark[2];
        else if (isCT && !isCT_17Line && CT_17LMark <= 0)
        {
            isCT_17Line = true;
            g_CTMainMark[3].GetComponent<Image>().sprite = s_CTMark[3];
        }

        if (isCT && !isCT_16Line && CT_16LMark == _16Line * 2)
            g_CTMainMark[4].GetComponent<Image>().sprite = s_CTMark[1];
        else if (isCT && !isCT_16Line && CT_16LMark == _16Line)
            g_CTMainMark[4].GetComponent<Image>().sprite = s_CTMark[2];
        else if (isCT && !isCT_16Line && CT_16LMark <= 0)
        {
            isCT_16Line = true;
            g_CTMainMark[4].GetComponent<Image>().sprite = s_CTMark[3];
        }

        if (isCT && !isCT_15Line && CT_15LMark == _15Line * 2)
            g_CTMainMark[5].GetComponent<Image>().sprite = s_CTMark[1];
        else if (isCT && !isCT_15Line && CT_15LMark == _15Line)
            g_CTMainMark[5].GetComponent<Image>().sprite = s_CTMark[2];
        else if (isCT && !isCT_15Line && CT_15LMark <= 0)
        {
            isCT_15Line = true;
            g_CTMainMark[5].GetComponent<Image>().sprite = s_CTMark[3];
        }

        if (isCT && !isCT_BullLine && CT_BullLMark == _BullLine * 2)
            g_CTMainMark[6].GetComponent<Image>().sprite = s_CTMark[1];
        else if (isCT && !isCT_BullLine && CT_BullLMark == _BullLine)
            g_CTMainMark[6].GetComponent<Image>().sprite = s_CTMark[2];
        else if (isCT && !isCT_BullLine && CT_BullLMark <= 0)
        {
            isCT_BullLine = true;
            g_CTMainMark[6].GetComponent<Image>().sprite = s_CTMark[3];
        }
        /*--------------------------------------------------------------*/
        if (isDT && !isDT_20Line && DT_20LMark == _20Line * 2)
            g_DTMainMark[0].GetComponent<Image>().sprite = s_DTMark[1];
        else if (isDT && !isDT_20Line && DT_20LMark == _20Line)
            g_DTMainMark[0].GetComponent<Image>().sprite = s_DTMark[2];
        else if (isDT && !isDT_20Line && DT_20LMark <= 0)
        {
            isDT_20Line = true;
            g_DTMainMark[0].GetComponent<Image>().sprite = s_DTMark[3];
        }

        if (isDT && !isDT_19Line && DT_19LMark == _19Line * 2)
            g_DTMainMark[1].GetComponent<Image>().sprite = s_DTMark[1];
        else if (isDT && !isDT_19Line && DT_19LMark == _19Line)
            g_DTMainMark[1].GetComponent<Image>().sprite = s_DTMark[2];
        else if (isDT && !isDT_19Line && DT_19LMark <= 0)
        {
            isDT_19Line = true;
            g_DTMainMark[1].GetComponent<Image>().sprite = s_DTMark[3];
        }

        if (isDT && !isDT_18Line && DT_18LMark == _18Line * 2)
            g_DTMainMark[2].GetComponent<Image>().sprite = s_DTMark[1];
        else if (isDT && !isDT_18Line && DT_18LMark == _18Line)
            g_DTMainMark[2].GetComponent<Image>().sprite = s_DTMark[2];
        else if (isDT && !isDT_18Line && DT_18LMark <= 0)
        {
            isDT_18Line = true;
            g_DTMainMark[2].GetComponent<Image>().sprite = s_DTMark[3];
        }

        if (isDT && !isDT_17Line && DT_17LMark == _17Line * 2)
            g_DTMainMark[3].GetComponent<Image>().sprite = s_DTMark[1];
        else if (isDT && !isDT_17Line && DT_17LMark == _17Line)
            g_DTMainMark[3].GetComponent<Image>().sprite = s_DTMark[2];
        else if (isDT && !isDT_17Line && DT_17LMark <= 0)
        {
            isDT_17Line = true;
            g_DTMainMark[3].GetComponent<Image>().sprite = s_DTMark[3];
        }

        if (isDT && !isDT_16Line && DT_16LMark == _16Line * 2)
            g_DTMainMark[4].GetComponent<Image>().sprite = s_DTMark[1];
        else if (isDT && !isDT_16Line && DT_16LMark == _16Line)
            g_DTMainMark[4].GetComponent<Image>().sprite = s_DTMark[2];
        else if (isDT && !isDT_16Line && DT_16LMark <= 0)
        {
            isDT_16Line = true;
            g_DTMainMark[4].GetComponent<Image>().sprite = s_DTMark[3];
        }

        if (isDT && !isDT_15Line && DT_15LMark == _15Line * 2)
            g_DTMainMark[5].GetComponent<Image>().sprite = s_DTMark[1];
        else if (isDT && !isDT_15Line && DT_15LMark == _15Line)
            g_DTMainMark[5].GetComponent<Image>().sprite = s_DTMark[2];
        else if (isDT && !isDT_15Line && DT_15LMark <= 0)
        {
            isDT_15Line = true;
            g_DTMainMark[5].GetComponent<Image>().sprite = s_DTMark[3];
        }

        if (isDT && !isDT_BullLine && DT_BullLMark == _BullLine * 2)
            g_DTMainMark[6].GetComponent<Image>().sprite = s_DTMark[1];
        else if (isDT && !isDT_BullLine && DT_BullLMark == _BullLine)
            g_DTMainMark[6].GetComponent<Image>().sprite = s_DTMark[2];
        else if (isDT && !isDT_BullLine && DT_BullLMark <= 0)
        {
            isDT_BullLine = true;
            g_DTMainMark[6].GetComponent<Image>().sprite = s_DTMark[3];
        }
        /*--------------------------------------------------------------*/
        if (isAT_20Line && isBT_20Line && isCT_20Line && isDT_20Line)
        {
            g_Fishbar[0].SetActive(true);
            g_ATMainMark[0].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[0].GetComponent<Image>().sprite = s_OffMark;
            g_CTMainMark[0].GetComponent<Image>().sprite = s_OffMark;
            is20AllLine = true;
        }
        if (isAT_19Line && isBT_19Line && isBT_19Line && isDT_19Line)
        {
            g_Fishbar[1].SetActive(true);
            g_ATMainMark[1].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[1].GetComponent<Image>().sprite = s_OffMark;
            g_CTMainMark[1].GetComponent<Image>().sprite = s_OffMark;
            is19AllLine = true;
        }
        if (isAT_18Line && isBT_18Line && isCT_18Line && isDT_18Line)
        {
            g_Fishbar[2].SetActive(true);
            g_ATMainMark[2].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[2].GetComponent<Image>().sprite = s_OffMark;
            g_CTMainMark[2].GetComponent<Image>().sprite = s_OffMark;
            is18AllLine = true;
        }
        if (isAT_17Line && isBT_17Line && isCT_17Line && isDT_17Line)
        {
            g_Fishbar[3].SetActive(true);
            g_ATMainMark[3].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[3].GetComponent<Image>().sprite = s_OffMark;
            g_CTMainMark[3].GetComponent<Image>().sprite = s_OffMark;
            is17AllLine = true;
        }
        if (isAT_16Line && isBT_16Line && isCT_16Line && isDT_16Line)
        {
            g_Fishbar[4].SetActive(true);
            g_ATMainMark[4].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[4].GetComponent<Image>().sprite = s_OffMark;
            g_CTMainMark[4].GetComponent<Image>().sprite = s_OffMark;
            is16AllLine = true;
        }
        if (isAT_15Line && isBT_15Line && isCT_15Line && isDT_15Line)
        {
            g_Fishbar[5].SetActive(true);
            g_ATMainMark[5].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[5].GetComponent<Image>().sprite = s_OffMark;
            g_CTMainMark[5].GetComponent<Image>().sprite = s_OffMark;
            is15AllLine = true;
        }
        if (isAT_BullLine && isBT_BullLine && isCT_BullLine && isDT_BullLine)
        {
            g_Fishbar[6].SetActive(true);
            g_ATMainMark[6].GetComponent<Image>().sprite = s_OffMark;
            g_BTMainMark[6].GetComponent<Image>().sprite = s_OffMark;
            g_CTMainMark[6].GetComponent<Image>().sprite = s_OffMark;
            isBullAllLine = true;
        }

        if (isAT_20Line && isAT_19Line && isAT_18Line && isAT_17Line && isAT_16Line && isAT_15Line && isAT_BullLine)
            isATAllLine = true;

        if (isBT_20Line && isBT_19Line && isBT_18Line && isBT_17Line && isBT_16Line && isBT_15Line && isBT_BullLine)
            isBTAllLine = true;

        if (isCT_20Line && isCT_19Line && isCT_18Line && isCT_17Line && isCT_16Line && isCT_15Line && isCT_BullLine)
            isCTAllLine = true;

        if (isDT_20Line && isDT_19Line && isDT_18Line && isDT_17Line && isDT_16Line && isDT_15Line && isDT_BullLine)
            isDTAllLine = true;
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
                    AT1MarkCounting++;
               else if (Players == 1)
                    AT2MarkCounting++;
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
            /*-----------------------------------------------------------------*/
            if (Teams == 2 && !isCT_20Line && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
            {
                if (Players == 0)
                    CT1MarkCounting++;
                else if (Players == 1)
                    CT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                CT_20LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 2 && !isCT_19Line && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
            {
                if (Players == 0)
                    CT1MarkCounting++;
                else if (Players == 1)
                    CT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                CT_19LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 2 && !isCT_18Line && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
            {
                if (Players == 0)
                    CT1MarkCounting++;
                else if (Players == 1)
                    CT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                CT_18LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 2 && !isCT_17Line && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
            {
                if (Players == 0)
                    CT1MarkCounting++;
                else if (Players == 1)
                    CT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                CT_17LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 2 && !isCT_16Line && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
            {
                if (Players == 0)
                    CT1MarkCounting++;
                else if (Players == 1)
                    CT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                CT_16LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 2 && !isCT_15Line && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
            {
                if (Players == 0)
                    CT1MarkCounting++;
                else if (Players == 1)
                    CT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                CT_15LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 2 && !isCT_BullLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
            {
                if (Players == 0)
                    CT1MarkCounting++;
                else if (Players == 1)
                    CT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                CT_BullLMark -= csSingleton.getInstance.g_nTargetScore;
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
            if (Teams == 3 && !isDT_20Line && csSingleton.getInstance.g_nTargetBasicScore == _20Line)
            {
                if (Players == 0)
                    DT1MarkCounting++;
                else if (Players == 1)
                    DT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                DT_20LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 3 && !isDT_19Line && csSingleton.getInstance.g_nTargetBasicScore == _19Line)
            {
                if (Players == 0)
                    DT1MarkCounting++;
                else if (Players == 1)
                    DT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                DT_19LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 3 && !isDT_18Line && csSingleton.getInstance.g_nTargetBasicScore == _18Line)
            {
                if (Players == 0)
                    DT1MarkCounting++;
                else if (Players == 1)
                    DT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                DT_18LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 3 && !isDT_17Line && csSingleton.getInstance.g_nTargetBasicScore == _17Line)
            {
                if (Players == 0)
                    DT1MarkCounting++;
                else if (Players == 1)
                    DT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                DT_17LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 3 && !isDT_16Line && csSingleton.getInstance.g_nTargetBasicScore == _16Line)
            {
                if (Players == 0)
                    DT1MarkCounting++;
                else if (Players == 1)
                    DT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                DT_16LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 3 && !isDT_15Line && csSingleton.getInstance.g_nTargetBasicScore == _15Line)
            {
                if (Players == 0)
                    DT1MarkCounting++;
                else if (Players == 1)
                    DT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                DT_15LMark -= csSingleton.getInstance.g_nTargetScore;
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
            else if (Teams == 3 && !isDT_BullLine && csSingleton.getInstance.g_nTargetBasicScore == _BullLine)
            {
                if (Players == 0)
                    DT1MarkCounting++;
                else if (Players == 1)
                    DT2MarkCounting++;
                a_source.PlayOneShot(ac_shoot1, 1.0f);
                DT_BullLMark -= csSingleton.getInstance.g_nTargetScore;
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
            if (AT_20LMark <= 0 && !isAT_20Line)
            {
                if (!isBT_20Line || !isCT_20Line || !isDT_20Line)
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
                if (!isBT_19Line || !isCT_19Line || !isDT_19Line)
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
                if (!isBT_18Line || !isCT_18Line || !isDT_18Line)
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
                if (!isBT_17Line || !isCT_17Line || !isDT_17Line)
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
                if (!isBT_16Line || !isCT_16Line || !isDT_16Line)
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
                if (!isBT_15Line || !isCT_15Line || !isDT_15Line)
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
                if (!isBT_BullLine || !isCT_BullLine || !isDT_BullLine)
                {
                    AT_BullLMark *= -1;
                    TeamScore[0] += AT_BullLMark;
                    g_P_Score[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                    g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                }
                AT_BullLMark = 0;
            }
            /*-----------------------------------------------------------------*/
            if (BT_20LMark <= 0 && !isBT_20Line)
            {
                if (!isAT_20Line || !isCT_20Line || !isDT_20Line)
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
                if (!isAT_19Line || !isCT_19Line || !isDT_19Line)
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
                if (!isAT_18Line || !isCT_18Line || !isDT_18Line)
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
                if (!isAT_17Line || !isCT_17Line || !isDT_17Line)
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
                if (!isAT_16Line || !isCT_16Line || !isDT_16Line)
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
                if (!isAT_15Line || !isCT_15Line || !isDT_15Line)
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
                if (!isAT_BullLine || !isCT_BullLine || !isDT_BullLine)
                {
                    BT_BullLMark *= -1;
                    TeamScore[1] += BT_BullLMark;
                    g_P_Score[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                    g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                }
                BT_BullLMark = 0;
            }
            /*-----------------------------------------------------------------*/
            if (CT_20LMark <= 0 && !isCT_20Line)
            {
                if (!isAT_20Line || !isBT_20Line || !isDT_20Line)
                {
                    CT_20LMark *= -1;
                    TeamScore[2] += CT_20LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                CT_20LMark = 0;
            }
            else if (CT_19LMark <= 0 && !isCT_19Line)
            {
                if (!isAT_19Line || !isBT_19Line || !isDT_19Line)
                {
                    CT_19LMark *= -1;
                    TeamScore[2] += CT_19LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                CT_19LMark = 0;
            }
            else if (CT_18LMark <= 0 && !isCT_18Line)
            {
                if (!isAT_18Line || !isBT_18Line || !isDT_18Line)
                {
                    CT_18LMark *= -1;
                    TeamScore[2] += CT_18LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                CT_18LMark = 0;
            }
            else if (CT_17LMark <= 0 && !isCT_17Line)
            {
                if (!isAT_17Line || !isBT_17Line || !isDT_17Line)
                {
                    CT_17LMark *= -1;
                    TeamScore[2] += CT_17LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                CT_17LMark = 0;
            }
            else if (CT_16LMark <= 0 && !isCT_16Line)
            {
                if (!isAT_16Line || !isBT_16Line || !isDT_16Line)
                {
                    CT_16LMark *= -1;
                    TeamScore[2] += CT_16LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                CT_16LMark = 0;
            }
            else if (CT_15LMark <= 0 && !isCT_15Line)
            {
                if (!isAT_15Line || !isBT_15Line || !isDT_15Line)
                {
                    CT_15LMark *= -1;
                    TeamScore[2] += CT_15LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                CT_15LMark = 0;
            }
            else if (CT_BullLMark <= 0 && !isCT_BullLine)
            {
                if (!isAT_BullLine || !isBT_BullLine || !isDT_BullLine)
                {
                    CT_BullLMark *= -1;
                    TeamScore[2] += CT_BullLMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                CT_BullLMark = 0;
            }
            /*-----------------------------------------------------------------*/
            if (DT_20LMark <= 0 && !isDT_20Line)
            {
                if (!isAT_20Line || !isBT_20Line || !isDT_20Line)
                {
                    DT_20LMark *= -1;
                    TeamScore[2] += DT_20LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                DT_20LMark = 0;
            }
            else if (DT_19LMark <= 0 && !isDT_19Line)
            {
                if (!isAT_19Line || !isBT_19Line || !isDT_19Line)
                {
                    DT_19LMark *= -1;
                    TeamScore[2] += DT_19LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                DT_19LMark = 0;
            }
            else if (DT_18LMark <= 0 && !isDT_18Line)
            {
                if (!isAT_18Line || !isBT_18Line || !isDT_18Line)
                {
                    DT_18LMark *= -1;
                    TeamScore[2] += DT_18LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                DT_18LMark = 0;
            }
            else if (DT_17LMark <= 0 && !isDT_17Line)
            {
                if (!isAT_17Line || !isBT_17Line || !isDT_17Line)
                {
                    DT_17LMark *= -1;
                    TeamScore[2] += DT_17LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                DT_17LMark = 0;
            }
            else if (DT_16LMark <= 0 && !isDT_16Line)
            {
                if (!isAT_16Line || !isBT_16Line || !isDT_16Line)
                {
                    DT_16LMark *= -1;
                    TeamScore[2] += DT_16LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                DT_16LMark = 0;
            }
            else if (DT_15LMark <= 0 && !isDT_15Line)
            {
                if (!isAT_15Line || !isBT_15Line || !isDT_15Line)
                {
                    DT_15LMark *= -1;
                    TeamScore[2] += DT_15LMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                DT_15LMark = 0;
            }
            else if (DT_BullLMark <= 0 && !isDT_BullLine)
            {
                if (!isAT_BullLine || !isBT_BullLine || !isDT_BullLine)
                {
                    DT_BullLMark *= -1;
                    TeamScore[2] += DT_BullLMark;
                    g_P_Score[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                    g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                }
                DT_BullLMark = 0;
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
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 2 && Players == 0)
                CT1MarkCounting++;
            else if (Teams == 2 && Players == 1)
                CT2MarkCounting++;
            else if (Teams == 3 && Players == 0)
                DT1MarkCounting++;
            else if (Teams == 3 && Players == 1)
                DT2MarkCounting++;
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
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 2 && Players == 0)
                CT1MarkCounting++;
            else if (Teams == 2 && Players == 1)
                CT2MarkCounting++;
            else if (Teams == 3 && Players == 0)
                DT1MarkCounting++;
            else if (Teams == 3 && Players == 1)
                DT2MarkCounting++;
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
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 2 && Players == 0)
                CT1MarkCounting++;
            else if (Teams == 2 && Players == 1)
                CT2MarkCounting++;
            else if (Teams == 3 && Players == 0)
                DT1MarkCounting++;
            else if (Teams == 3 && Players == 1)
                DT2MarkCounting++;
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
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 2 && Players == 0)
                CT1MarkCounting++;
            else if (Teams == 2 && Players == 1)
                CT2MarkCounting++;
            else if (Teams == 3 && Players == 0)
                DT1MarkCounting++;
            else if (Teams == 3 && Players == 1)
                DT2MarkCounting++;
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
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 2 && Players == 0)
                CT1MarkCounting++;
            else if (Teams == 2 && Players == 1)
                CT2MarkCounting++;
            else if (Teams == 3 && Players == 0)
                DT1MarkCounting++;
            else if (Teams == 3 && Players == 1)
                DT2MarkCounting++;
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
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 2 && Players == 0)
                CT1MarkCounting++;
            else if (Teams == 2 && Players == 1)
                CT2MarkCounting++;
            else if (Teams == 3 && Players == 0)
                DT1MarkCounting++;
            else if (Teams == 3 && Players == 1)
                DT2MarkCounting++;
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
            else if (Teams == 1 && Players == 0)
                BT1MarkCounting++;
            else if (Teams == 1 && Players == 1)
                BT2MarkCounting++;
            else if (Teams == 2 && Players == 0)
                CT1MarkCounting++;
            else if (Teams == 2 && Players == 1)
                CT2MarkCounting++;
            else if (Teams == 3 && Players == 0)
                DT1MarkCounting++;
            else if (Teams == 3 && Players == 1)
                DT2MarkCounting++;
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
        isRead = false;
        g_C_Ani.SetActive(false);
        Counting = 0;
        Teams += 1;
        if (Teams == 0)
        {
            isAT = true;
            isBT = false;
            isCT = false;
            isDT = false;
        }
        else if (Teams == 1)
        {
            isAT = false;
            isBT = true;
            isCT = false;
            isDT = false;
        }
        else if (Teams == 2)
        {
            isAT = false;
            isBT = false;
            isCT = true;
            isDT = false;
        }
        else if (Teams == 3)
        {
            isAT = false;
            isBT = false;
            isCT = false;
            isDT = true;
        }
    }

    void TeamNumberMinus()
    {
        isAT = true;
        isBT = false;
        isCT = false;
        isDT = false;
        isRead = false;
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
        RoundCountingA1 = 1;
        RoundCountingA2 = 1;
        RoundCountingB1 = 1;
        RoundCountingB2 = 1;
        RoundCountingC1 = 1;
        RoundCountingC2 = 1;
        RoundCountingD1 = 1;
        RoundCountingD2 = 1;
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
        else if (Teams == 0 && Players == 1)
        {
            TotalA2 += Dart;
            AverageA2 = TotalA2 / RoundCountingA2;
            t_MPRText2.text = string.Format("{0:N2}", AverageA2);
        }

        else if (Teams == 1 && Players == 0)
        {
            TotalB1 += Dart;
            AverageB1 = TotalB1 / RoundCountingB1;
            t_MPRText3.text = string.Format("{0:N2}", AverageB1);
        }
        else if (Teams == 1 && Players == 1)
        {
            TotalB2 += Dart;
            AverageB2 = TotalB2 / RoundCountingB2;
            t_MPRText4.text = string.Format("{0:N2}", AverageB2);
        }

        else if (Teams == 2 && Players == 0)
        {
            TotalC1 += Dart;
            AverageC1 = TotalC1 / RoundCountingC1;
            t_MPRText5.text = string.Format("{0:N2}", AverageC1);
        }
        else if (Teams == 2 && Players == 1)
        {
            TotalC2 += Dart;
            AverageC2 = TotalC2 / RoundCountingC2;
            t_MPRText6.text = string.Format("{0:N2}", AverageC2);
        }

        else if (Teams == 3 && Players == 0)
        {
            TotalD1 += Dart;
            AverageD1 = TotalD1 / RoundCountingD1;
            t_MPRText7.text = string.Format("{0:N2}", AverageD1);
        }
        else if (Teams == 3 && Players == 1)
        {
            TotalD2 += Dart;
            AverageD2 = TotalD2 / RoundCountingD2;
            t_MPRText8.text = string.Format("{0:N2}", AverageD2);
        }

        if (Teams == 0)
            AverageATotla = AverageA1 + AverageA2 / 2;

        else if (Teams == 1)
            AverageBTotla = AverageB1 + AverageB2 / 2;

        else if (Teams == 2)
            AverageCTotla = AverageC1 + AverageC2 / 2;

        else if (Teams == 3)
            AverageDTotla = AverageD1 + AverageD2 / 2;
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
