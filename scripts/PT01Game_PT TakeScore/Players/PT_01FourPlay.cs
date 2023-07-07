using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class PT_01FourPlay : MonoBehaviour
{
    public Text t_RoundText;
    public Text t_PPDText1;
    public Text t_PPDText2;
    public Text t_PPDText3;
    public Text t_PPDText4;
    public Text[] t_P1RScoreText = new Text[5];
    public Text[] t_P2RScoreText = new Text[5];
    public Text[] t_P3RScoreText = new Text[5];
    public Text[] t_P4RScoreText = new Text[5];

    public Sprite s_OnDart;
    public Sprite s_OffDart;
    public Sprite[] s_RScore = new Sprite[20];
    public Sprite[] s_PlayerOn = new Sprite[4];
    public Sprite[] s_PlayerOff = new Sprite[4];
    public Image[] i_RScore1 = new Image[5];
    public Image[] i_RScore2 = new Image[5];
    public Image[] i_RScore3 = new Image[5];
    public Image[] i_RScore4 = new Image[5];
    public GameObject g_P1; //플레이어 바 부모
    public GameObject g_P2;
    public GameObject g_P3;
    public GameObject g_P4;
    public GameObject[] g_i_Player = new GameObject[4];   //플레이어 숫자이미지
    public GameObject[] g_Dart = new GameObject[3];//다트
    public GameObject g_G_Bust; //버스트
    public GameObject g_D_ani;    //특정구역 다트 맞으면 나오는애니
    public GameObject g_C_Ani;    //플레이어끼리 체인지 애니
    public GameObject g_R_Ani;    //라운드 끝나면 나오는 애니
    public GameObject g_P_Ani; //라운드 끝나다는걸 알려주는 애니
    public GameObject g_RoundOn;
    public GameObject g_RoundR;
    public GameObject[] g_RoundScore = new GameObject[4];
    public GameObject[] g_PPDScore = new GameObject[4];
    public GameObject[] g_RoundNum = new GameObject[21];
    public GameObject[] g_M_Score = new GameObject[4];
    public GameObject[] g_P_Score = new GameObject[4];
    public GameObject[] g_OffScore = new GameObject[4];

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int RoundStop = 0;
    public int DefultScore = 0;

    public int Counting = 0;//카운팅
    public int Round = 0;//라운드
    public int[] DartScore = new int[3]; //첫 다트 점수
    public int P1_DartCount = 0;//다트 총합
    public int P2_DartCount = 0;
    public int P3_DartCount = 0;
    public int P4_DartCount = 0;
    public int RScore = 0; //R관련 카운팅
    public int Players = 0; //플레이어
    public int P1_Total = 0;//다트 총합
    public int P2_Total = 0;
    public int P3_Total = 0;
    public int P4_Total = 0;
    public int PlayerBasicScore = 0;
    public int[] DartBasicScore = new int[3];
    public int[] PlayerScore = new int[4];
    public int[] BustScore = new int[4];
    public int[] P1_ScoreSave = new int[20];
    public int[] P2_ScoreSave = new int[20];
    public int[] P3_ScoreSave = new int[20];
    public int[] P4_ScoreSave = new int[20];
    public int win = 0;

    public float P1_Average = 0;//다트 평균값 
    public float P2_Average = 0;
    public float P3_Average = 0;
    public float P4_Average = 0;

    public string[] playerName = new string[4];

    public bool isP1 = true;
    public bool isP2 = false;
    public bool isP3 = false;
    public bool isP4 = false;
    public bool isBust = false;
    public bool isRead = false;
    public bool isSpace = false;
    public bool isWin = false;

    public cs01GameManager csgmg;
    public _TARGET_INFO[] m_oDartInfo = new _TARGET_INFO[3];

    void Start()
    {
        Players = 0;
        for (int i = 0; i < PlayerScore.Length; i++)
            PlayerScore[i] = DefultScore;
        for (int i = 0; i < g_RoundNum.Length; i++)
            g_RoundNum[i].SetActive(false);
        for (int i = 0; i < g_M_Score.Length; i++)
        {
            g_M_Score[i].GetComponent<csNumber>().CreateNumber(3, 250, 3f, 0);
            g_P_Score[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_OffScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_M_Score[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
            g_P_Score[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
            g_OffScore[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
        }
        g_G_Bust.SetActive(false);
        g_P_Ani.SetActive(false);
        g_C_Ani.SetActive(false);
        MyTurn();
        FirstStart();
    }

    void Update()
    {
        MyTurn();
        ImageUp();
        if (csSingleton.getInstance.g_bTarget && !isRead && !isSpace && !isWin && !isBust)
        {
            csSingleton.getInstance.g_bTarget = false;
            if (Round <= RoundStop && !isRead && !isBust)
            {
                if (Players == 0 && isP1 && !isP2 && !isP3 && !isP4 && !isBust && !isRead)
                {
                    if (Counting == 0 && isP1 && !isP2 && !isP3 && !isP4 && !isBust && !isRead)
                    {
                        P1_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[0];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[0]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    else if (Counting == 1 && isP1 && !isP2 && !isP3 && !isP4 && !isBust && !isRead)
                    {
                        P1_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[1];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[1]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    else if (Counting == 2 && isP1 && !isP2 && !isP3 && !isP4 && !isBust && !isRead)
                    {
                        P1_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[2];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[2]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    if (Counting == 3 && isP1 && !isP2 && !isP3 && !isP4 && !isBust && !isRead)
                    {
                        GetMovie();
                        BustScore[0] = PlayerScore[0];
                        g_M_Score[0].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                else if (Players == 1 && isP2 && !isP3 && !isP4 && !isP1 && !isRead && !isBust)
                {
                    if (Counting == 0 && isP2 && !isP3 && !isP4 && !isP1 && !isBust && !isRead)
                    {
                        P2_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[0];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[0]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    else if (Counting == 1 && isP2 && !isP3 && !isP4 && !isP1 && !isBust && !isRead)
                    {
                        P2_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[1];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[1]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    else if (Counting == 2 && isP2 && !isP3 && !isP4 && !isP1 && !isBust && !isRead)
                    {
                        P2_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[2];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[2]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);

                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    if (Counting == 3 && isP2 && !isP3 && !isP4 && !isP1 && !isBust && !isRead)
                    {
                        GetMovie();
                        BustScore[1] = PlayerScore[1];
                        g_M_Score[1].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                else if (Players == 2 && isP3 && !isP4 && !isP1 && !isP2 && !isRead && !isBust)
                {
                    if (Counting == 0 && isP3 && !isP4 && !isP1 && !isP2 && !isBust && !isRead)
                    {
                        P3_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[0];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[0]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    else if (Counting == 1 && isP3 && !isP4 && !isP1 && !isP2 && !isBust && !isRead)
                    {
                        P3_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[1];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[1]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    else if (Counting == 2 && isP3 && !isP4 && !isP1 && !isP2 && !isBust && !isRead)
                    {
                        P3_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[2];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[2]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    if (Counting == 3 && isP3 && !isP4 && !isP1 && !isP2 && !isBust && !isRead)
                    {
                        GetMovie();
                        BustScore[2] = PlayerScore[2];
                        g_M_Score[2].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                else if (Players == 3 && isP4 && !isP1 && !isP2 && !isP3 && !isRead && !isBust)
                {
                    if (Counting == 0 && isP4 && !isP1 && !isP2 && !isP3 && !isBust && !isRead)
                    {
                        P4_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[0];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[0]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    else if (Counting == 1 && isP4 && !isP1 && !isP2 && !isP3 && !isBust && !isRead)
                    {
                        P4_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[1];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[1]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    else if (Counting == 2 && isP4 && !isP1 && !isP2 && !isP3 && !isBust && !isRead)
                    {
                        P4_DartCount++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        PlayerBasicScore = DartScore[2];
                        PPDScore(PlayerBasicScore);
                        RoundScore(DartScore[2]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        BustAndRoundRead();
                        PlayerBasicScore = 0;
                    }
                    if (Counting == 3 && isP4 && !isP1 && !isP2 && !isP3 && !isBust && !isRead)
                    {
                        GetMovie();
                        BustScore[3] = PlayerScore[3];
                        g_M_Score[3].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && Counting == 4 && !isWin && isSpace || (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1005) && Counting == 4 && !isWin && isSpace)
        {
            if (Players == 0 && isP1)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("PlayerNumberPlus", 4f);
            }
            else if (Players == 1 && isP2)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("PlayerNumberPlus", 4f);
            }
            else if (Players == 2 && isP3)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("PlayerNumberPlus", 4f);
            }
            else if (Players == 3 && isP4)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                RScore += 1;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("PlayerNumberMinus", 4f);
                BustAndRoundRead();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && isBust || (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1005) && isBust)
        {
            if (Players == 0 && isP1)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("PlayerNumberPlus", 4f);
            }
            else if (Players == 1 && isP2)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("PlayerNumberPlus", 4f);
            }
            else if (Players == 2 && isP3)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("PlayerNumberPlus", 4f);
            }
            else if (Players == 3 && isP4)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                RScore += 1;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("PlayerNumberMinus", 4f);
                BustAndRoundRead();
            }
        }
        if (Round == RoundStop && Counting == 3 && isP4)
            GameEndRead();
    }

    void BustAndRoundRead()
    {
        if (PlayerScore[Players] < PlayerBasicScore && !isRead)
            Bust();

        if (PlayerScore[Players] >= PlayerBasicScore && !isRead && !isBust)
            NextShotRead();

        if (PlayerScore[Players] == 0 && !isBust && !isRead)
        {
            g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            WinRead();
        }
        if (Round == RoundStop && Counting == 4 && isP4)
        {
            g_C_Ani.SetActive(false);
            GameEndRead();
        }

    }

    void Bust()
    {
        isRead = true;
        g_G_Bust.SetActive(true);
        g_M_Score[Players].SetActive(false);
        PlayerScore[Players] = BustScore[Players];
        g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        g_OffScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        Invoke("Delay", 2f);
    }

    void Delay()
    {
        Counting = 4;
        g_P_Ani.SetActive(true);
        g_G_Bust.SetActive(false);
        isBust = true;
    }

    void NextShotRead()
    {
        if (Counting != 4 && !isBust && !isRead)
        {
            PlayerScore[Players] -= DartScore[Counting];
            g_M_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_OffScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            Counting++;
        }
        if (Counting == 4 && isP4 && !isBust && !isRead)
            RoundRead();
    }

    void RoundRead()
    {
        isRead = true;
        g_P_Ani.SetActive(false);
        g_P_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        g_C_Ani.SetActive(true);
        g_M_Score[Players].SetActive(false);
        for (int i = 0; i < g_M_Score.Length; i++)
            g_M_Score[i].SetActive(false);
        Invoke("RoundStart", 3f);
    }

    void RoundStart()
    {
        g_C_Ani.SetActive(false);
        g_RoundNum[Round].SetActive(true);
        g_RoundR.SetActive(true);
        g_RoundOn.SetActive(true);
        g_R_Ani.SetActive(true);
        Invoke("GameStart", 1f);
    }

    void GameStart()
    {
        Counting = 0;
        g_RoundNum[Round].SetActive(false);
        g_RoundR.SetActive(false);
        g_RoundOn.SetActive(false);
        g_R_Ani.SetActive(false);
        g_M_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        g_M_Score[Players].SetActive(true);
        Round += 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void WinRead() // 이기면 바로 여기로
    {
        if (isP1 && !isP2 && !isP3 && !isP4)
        {
            win = 0;
            isWin = true;
            isP1 = true;
            isP2 = false;
            isP3 = false;
            isP4 = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (isP2 && !isP3 && !isP4 && !isP1)
        {
            win = 1;
            isWin = true;
            isP1 = false;
            isP2 = true;
            isP3 = false;
            isP4 = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (isP3 && !isP4 && !!isP1 && !isP2)
        {
            win = 2;
            isWin = true;
            isP1 = false;
            isP2 = false;
            isP3 = true;
            isP4 = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (isP4 && !isP1 && !isP2 && !isP3)
        {
            win = 3;
            isWin = true;
            isP1 = false;
            isP2 = false;
            isP3 = false;
            isP4 = true;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }
    }

    void GameEndRead()
    {
        if (PlayerScore[1] < PlayerScore[0] && PlayerScore[2] < PlayerScore[0] && PlayerScore[3] < PlayerScore[0])
        {
            win = 0;
            isP1 = true;
            isP2 = false;
            isP3 = false;
            isP4 = false;
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (PlayerScore[0] < PlayerScore[1] && PlayerScore[2] < PlayerScore[1] && PlayerScore[3] < PlayerScore[1])
        {
            win = 1;
            isP2 = true;
            isP3 = false;
            isP4 = false;
            isP1 = false;
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (PlayerScore[0] < PlayerScore[2] && PlayerScore[1] < PlayerScore[2] && PlayerScore[3] < PlayerScore[2])
        {
            win = 2;
            isP3 = true;
            isP4 = false;
            isP1 = false;
            isP2 = false;
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (PlayerScore[0] < PlayerScore[3] && PlayerScore[1] < PlayerScore[3] && PlayerScore[2] < PlayerScore[3])
        {
            win = 3;
            isP1 = false;
            isP2 = false;
            isP3 = false;
            isP4 = true;
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (PlayerScore[0] == PlayerScore[1] && PlayerScore[0] == PlayerScore[2] &&
            PlayerScore[0] == PlayerScore[3] && PlayerScore[1] == PlayerScore[2] &&
            PlayerScore[1] == PlayerScore[3] && PlayerScore[2] == PlayerScore[3])
        {
            if (P2_Average < P1_Average && P3_Average < P1_Average && P4_Average < P1_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P2_Average && P3_Average < P2_Average && P4_Average < P2_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P3_Average && P2_Average < P3_Average && P4_Average < P3_Average)
            {
                win = 2;
                isP1 = false;
                isP2 = false;
                isP3 = true;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P4_Average && P2_Average < P4_Average && P3_Average < P4_Average)
            {
                win = 3;
                isP1 = false;
                isP2 = false;
                isP3 = false;
                isP4 = true;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P2_Average && P1_Average == P3_Average && P1_Average == P4_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average == P3_Average && P2_Average == P4_Average &&
                P1_Average != P2_Average && P1_Average != P3_Average &&
                P1_Average != P4_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            } //BC BD

            if (P3_Average == P4_Average
                && P2_Average != P3_Average && P2_Average != P4_Average
                && P1_Average != P2_Average && P1_Average != P3_Average
                && P1_Average != P4_Average)
            {
                win = 2;
                isP1 = false;
                isP2 = false;
                isP3 = true;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            } //CD
        } //ALL

        if (PlayerScore[0] == PlayerScore[1] && PlayerScore[0] == PlayerScore[2] &&
           PlayerScore[0] != PlayerScore[3] && PlayerScore[1] != PlayerScore[3] &&
           PlayerScore[2] != PlayerScore[3])
        {
            if (P2_Average < P1_Average && P3_Average < P1_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P2_Average && P3_Average < P2_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P3_Average && P2_Average < P3_Average)
            {
                win = 2;
                isP1 = false;
                isP2 = false;
                isP3 = true;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P2_Average && P1_Average == P3_Average && P2_Average != P3_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average == P4_Average && P1_Average != P2_Average && P1_Average != P3_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P4_Average && P1_Average != P2_Average && P4_Average != P2_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P2_Average && P1_Average == P3_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
        }  //ABC

        if (PlayerScore[0] == PlayerScore[2] && PlayerScore[0] == PlayerScore[3] &&
            PlayerScore[2] == PlayerScore[3] && PlayerScore[0] != PlayerScore[1] &&
            PlayerScore[2] != PlayerScore[1] && PlayerScore[3] != PlayerScore[1])
        {
            if (P2_Average < P1_Average && P4_Average < P1_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P2_Average && P4_Average < P2_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P4_Average && P2_Average < P4_Average)
            {
                win = 3;
                isP1 = false;
                isP2 = false;
                isP3 = false;
                isP4 = true;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P2_Average && P1_Average == P4_Average && P2_Average != P4_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average == P4_Average && P1_Average != P2_Average && P1_Average != P4_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P4_Average && P1_Average != P2_Average && P4_Average != P2_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P2_Average && P1_Average == P4_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
        } //ACD

        if (PlayerScore[0] == PlayerScore[1] && PlayerScore[0] == PlayerScore[3] &&
            PlayerScore[1] == PlayerScore[3] && PlayerScore[0] != PlayerScore[2] &&
            PlayerScore[1] != PlayerScore[2] && PlayerScore[3] != PlayerScore[2])
        {
            if (P2_Average < P1_Average && P4_Average < P1_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P2_Average && P4_Average < P2_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P4_Average && P3_Average < P4_Average)
            {
                win = 3;
                isP1 = false;
                isP2 = false;
                isP3 = false;
                isP4 = true;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P2_Average && P1_Average == P4_Average && P2_Average != P4_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average == P4_Average && P2_Average != P1_Average && P4_Average != P1_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P4_Average && P2_Average != P1_Average && P2_Average != P4_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P2_Average && P1_Average == P4_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
        } //ABD

        if (PlayerScore[1] == PlayerScore[2] && PlayerScore[1] == PlayerScore[3] &&
            PlayerScore[2] == PlayerScore[3] && PlayerScore[1] != PlayerScore[0] &&
            PlayerScore[2] != PlayerScore[0] && PlayerScore[3] != PlayerScore[0])
        {
            if (P3_Average < P2_Average && P4_Average < P2_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average < P3_Average && P4_Average < P3_Average)
            {
                win = 2;
                isP1 = false;
                isP2 = false;
                isP3 = true;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average < P4_Average && P3_Average < P4_Average)
            {
                win = 3;
                isP1 = false;
                isP2 = false;
                isP3 = false;
                isP4 = true;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average == P3_Average && P2_Average == P4_Average && P3_Average != P4_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P3_Average == P4_Average && P2_Average != P3_Average && P2_Average != P4_Average)
            {
                win = 2;
                isP1 = false;
                isP2 = false;
                isP3 = true;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average == P4_Average && P3_Average != P2_Average && P3_Average != P4_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average == P3_Average && P2_Average == P4_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
        } //BCD

        if (PlayerScore[0] == PlayerScore[1] && PlayerScore[0] != PlayerScore[2] &&
            PlayerScore[0] != PlayerScore[3] && PlayerScore[1] != PlayerScore[2] &&
            PlayerScore[1] != PlayerScore[3] && PlayerScore[2] != PlayerScore[3])
        {
            if (P2_Average < P1_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P2_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P2_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
        } //A B

        if (PlayerScore[0] == PlayerScore[2] && PlayerScore[0] != PlayerScore[1] &&
            PlayerScore[0] != PlayerScore[3] && PlayerScore[1] != PlayerScore[2] &&
            PlayerScore[1] != PlayerScore[3] && PlayerScore[2] != PlayerScore[3])
        {
            if (P3_Average < P1_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P3_Average)
            {
                win = 2;
                isP1 = false;
                isP2 = false;
                isP3 = true;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P3_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
        } //A C

        if (PlayerScore[0] == PlayerScore[3] && PlayerScore[0] != PlayerScore[1] &&
            PlayerScore[0] != PlayerScore[2] && PlayerScore[1] != PlayerScore[2] &&
            PlayerScore[1] != PlayerScore[3] && PlayerScore[2] != PlayerScore[3])
        {
            if (P4_Average < P1_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average < P4_Average)
            {
                win = 3;
                isP1 = false;
                isP2 = false;
                isP3 = false;
                isP4 = true;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P1_Average == P4_Average)
            {
                win = 0;
                isP1 = true;
                isP2 = false;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
        } //A D

        if (PlayerScore[1] == PlayerScore[2] && PlayerScore[0] != PlayerScore[1] &&
            PlayerScore[0] != PlayerScore[2] && PlayerScore[0] != PlayerScore[3] &&
            PlayerScore[1] != PlayerScore[3] && PlayerScore[2] != PlayerScore[3])
        {
            if (P2_Average < P3_Average)
            {
                win = 2;
                isP1 = false;
                isP2 = false;
                isP3 = true;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P3_Average < P2_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average == P3_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
        } //B C

        if (PlayerScore[1] == PlayerScore[3] && PlayerScore[0] != PlayerScore[1] &&
            PlayerScore[0] != PlayerScore[2] && PlayerScore[0] != PlayerScore[3] &&
            PlayerScore[1] != PlayerScore[2] && PlayerScore[2] != PlayerScore[3])
        {
            if (P2_Average < P4_Average)
            {
                win = 3;
                isP1 = false;
                isP2 = false;
                isP3 = false;
                isP4 = true;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P4_Average < P2_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P2_Average == P4_Average)
            {
                win = 1;
                isP1 = false;
                isP2 = true;
                isP3 = false;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
        } //B D

        if (PlayerScore[2] == PlayerScore[3] && PlayerScore[0] != PlayerScore[1] &&
            PlayerScore[0] != PlayerScore[2] && PlayerScore[0] != PlayerScore[3] &&
            PlayerScore[1] != PlayerScore[2] && PlayerScore[1] != PlayerScore[3])
        {
            if (P3_Average < P4_Average)
            {
                win = 3;
                isP1 = false;
                isP2 = false;
                isP3 = false;
                isP4 = true;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P4_Average < P3_Average)
            {
                win = 2;
                isP1 = false;
                isP2 = false;
                isP3 = true;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
            if (P3_Average == P4_Average)
            {
                win = 2;
                isP1 = false;
                isP2 = false;
                isP3 = true;
                isP4 = false;
                for (int i = 0; i < g_M_Score.Length; i++)
                    g_M_Score[i].SetActive(false);
                csgmg.GameEndRead(win);
            }
        } //C D
    }

    void ImageUp()
    {
        if (isP1 && !isP2 && !isP3 && !isP4)
        {
            if (RScore == 5)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[5];

                t_P1RScoreText[0].text = P1_ScoreSave[1].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[2].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[3].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[4].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[6];

                t_P1RScoreText[0].text = P1_ScoreSave[2].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[3].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[4].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[5].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[7];

                t_P1RScoreText[0].text = P1_ScoreSave[3].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[4].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[5].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[6].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[8];

                t_P1RScoreText[0].text = P1_ScoreSave[4].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[5].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[6].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[7].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[9];

                t_P1RScoreText[0].text = P1_ScoreSave[5].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[6].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[7].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[8].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[10];

                t_P1RScoreText[0].text = P1_ScoreSave[6].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[7].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[8].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[9].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[11];

                t_P1RScoreText[0].text = P1_ScoreSave[7].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[8].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[9].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[10].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[12];

                t_P1RScoreText[0].text = P1_ScoreSave[8].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[9].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[10].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[11].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[13];

                t_P1RScoreText[0].text = P1_ScoreSave[9].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[10].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[11].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[12].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[14];

                t_P1RScoreText[0].text = P1_ScoreSave[10].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[11].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[12].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[13].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[15];

                t_P1RScoreText[0].text = P1_ScoreSave[11].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[12].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[13].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[14].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[16];

                t_P1RScoreText[0].text = P1_ScoreSave[12].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[13].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[14].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[15].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[17];

                t_P1RScoreText[0].text = P1_ScoreSave[13].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[14].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[15].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[16].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[18];

                t_P1RScoreText[0].text = P1_ScoreSave[14].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[15].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[16].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[17].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[19];

                t_P1RScoreText[0].text = P1_ScoreSave[15].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[16].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[17].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[18].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[20];

                t_P1RScoreText[0].text = P1_ScoreSave[16].ToString();
                t_P1RScoreText[1].text = P1_ScoreSave[17].ToString();
                t_P1RScoreText[2].text = P1_ScoreSave[18].ToString();
                t_P1RScoreText[3].text = P1_ScoreSave[19].ToString();
                t_P1RScoreText[4].text = P1_ScoreSave[20].ToString();
            }

        }

        if (isP2 && !isP3 && !isP4 && !isP1)
        {
            if (RScore == 5)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[5];

                t_P2RScoreText[0].text = P2_ScoreSave[1].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[2].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[3].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[4].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[6];

                t_P2RScoreText[0].text = P2_ScoreSave[2].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[3].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[4].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[5].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[7];

                t_P2RScoreText[0].text = P2_ScoreSave[3].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[4].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[5].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[6].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[8];

                t_P2RScoreText[0].text = P2_ScoreSave[4].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[5].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[6].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[7].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[9];

                t_P2RScoreText[0].text = P2_ScoreSave[5].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[6].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[7].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[8].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[10];

                t_P2RScoreText[0].text = P2_ScoreSave[6].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[7].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[8].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[9].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[11];

                t_P2RScoreText[0].text = P2_ScoreSave[7].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[8].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[9].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[10].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[12];

                t_P2RScoreText[0].text = P2_ScoreSave[8].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[9].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[10].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[11].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[13];

                t_P2RScoreText[0].text = P2_ScoreSave[9].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[10].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[11].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[12].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[14];

                t_P2RScoreText[0].text = P2_ScoreSave[10].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[11].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[12].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[13].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[15];

                t_P2RScoreText[0].text = P2_ScoreSave[11].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[12].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[13].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[14].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[16];

                t_P2RScoreText[0].text = P2_ScoreSave[12].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[13].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[14].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[15].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[17];

                t_P2RScoreText[0].text = P2_ScoreSave[13].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[14].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[15].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[16].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[18];

                t_P2RScoreText[0].text = P2_ScoreSave[14].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[15].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[16].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[17].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[19];

                t_P2RScoreText[0].text = P2_ScoreSave[15].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[16].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[17].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[18].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[20];

                t_P2RScoreText[0].text = P2_ScoreSave[16].ToString();
                t_P2RScoreText[1].text = P2_ScoreSave[17].ToString();
                t_P2RScoreText[2].text = P2_ScoreSave[18].ToString();
                t_P2RScoreText[3].text = P2_ScoreSave[19].ToString();
                t_P2RScoreText[4].text = P2_ScoreSave[20].ToString();
            }

        }

        if (isP3 && !isP4 && !isP1 && !isP2)
        {
            if (RScore == 5)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[5];

                t_P3RScoreText[0].text = P3_ScoreSave[1].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[2].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[3].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[4].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[6];

                t_P3RScoreText[0].text = P3_ScoreSave[2].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[3].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[4].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[5].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[7];

                t_P3RScoreText[0].text = P3_ScoreSave[3].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[4].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[5].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[6].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[8];

                t_P3RScoreText[0].text = P3_ScoreSave[4].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[5].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[6].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[7].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[9];

                t_P3RScoreText[0].text = P3_ScoreSave[5].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[6].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[7].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[8].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[10];

                t_P3RScoreText[0].text = P3_ScoreSave[6].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[7].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[8].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[9].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[11];

                t_P3RScoreText[0].text = P3_ScoreSave[7].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[8].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[9].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[10].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[12];

                t_P3RScoreText[0].text = P3_ScoreSave[8].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[9].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[10].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[11].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[13];

                t_P3RScoreText[0].text = P3_ScoreSave[9].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[10].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[11].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[12].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[14];

                t_P3RScoreText[0].text = P3_ScoreSave[10].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[11].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[12].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[13].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[15];

                t_P3RScoreText[0].text = P3_ScoreSave[11].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[12].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[13].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[14].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[16];

                t_P3RScoreText[0].text = P3_ScoreSave[12].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[13].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[14].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[15].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[17];

                t_P3RScoreText[0].text = P3_ScoreSave[13].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[14].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[15].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[16].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[18];

                t_P3RScoreText[0].text = P3_ScoreSave[14].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[15].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[16].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[17].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[19];

                t_P3RScoreText[0].text = P3_ScoreSave[15].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[16].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[17].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[18].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScore3[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore3[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore3[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore3[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScore3[4].GetComponent<Image>().sprite = s_RScore[20];

                t_P3RScoreText[0].text = P3_ScoreSave[16].ToString();
                t_P3RScoreText[1].text = P3_ScoreSave[17].ToString();
                t_P3RScoreText[2].text = P3_ScoreSave[18].ToString();
                t_P3RScoreText[3].text = P3_ScoreSave[19].ToString();
                t_P3RScoreText[4].text = P3_ScoreSave[20].ToString();
            }

        }

        if (isP4 && !isP1 && !isP2 && !isP3)
        {
            if (RScore == 5)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[5];

                t_P4RScoreText[0].text = P4_ScoreSave[1].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[2].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[3].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[4].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[6];

                t_P4RScoreText[0].text = P4_ScoreSave[2].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[3].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[4].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[5].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[7];

                t_P4RScoreText[0].text = P4_ScoreSave[3].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[4].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[5].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[6].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[8];

                t_P4RScoreText[0].text = P4_ScoreSave[4].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[5].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[6].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[7].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[9];

                t_P4RScoreText[0].text = P4_ScoreSave[5].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[6].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[7].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[8].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[10];

                t_P4RScoreText[0].text = P4_ScoreSave[6].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[7].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[8].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[9].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[11];

                t_P4RScoreText[0].text = P4_ScoreSave[7].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[8].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[9].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[10].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[12];

                t_P4RScoreText[0].text = P4_ScoreSave[8].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[9].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[10].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[11].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[13];

                t_P4RScoreText[0].text = P4_ScoreSave[9].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[10].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[11].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[12].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[14];

                t_P4RScoreText[0].text = P4_ScoreSave[10].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[11].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[12].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[13].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[15];

                t_P4RScoreText[0].text = P4_ScoreSave[11].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[12].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[13].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[14].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[16];

                t_P4RScoreText[0].text = P4_ScoreSave[12].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[13].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[14].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[15].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[17];

                t_P4RScoreText[0].text = P4_ScoreSave[13].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[14].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[15].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[16].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[18];

                t_P4RScoreText[0].text = P4_ScoreSave[14].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[15].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[16].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[17].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[19];

                t_P4RScoreText[0].text = P4_ScoreSave[15].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[16].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[17].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[18].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScore4[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore4[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore4[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore4[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScore4[4].GetComponent<Image>().sprite = s_RScore[20];

                t_P4RScoreText[0].text = P4_ScoreSave[16].ToString();
                t_P4RScoreText[1].text = P4_ScoreSave[17].ToString();
                t_P4RScoreText[2].text = P4_ScoreSave[18].ToString();
                t_P4RScoreText[3].text = P4_ScoreSave[19].ToString();
                t_P4RScoreText[4].text = P4_ScoreSave[20].ToString();
            }

        }
    } //라운드가 끝나고 이미지를 한칸씩올려줄 함수

    void RoundScore(int DartScore)
    {
        if (isP1 && !isP2 && !isP3 && !isP4)
        {
            P1_ScoreSave[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_P1RScoreText[0].text = P1_ScoreSave[0].ToString();

                if (RScore == 1)
                    t_P1RScoreText[1].text = P1_ScoreSave[1].ToString();

                if (RScore == 2)
                    t_P1RScoreText[2].text = P1_ScoreSave[2].ToString();

                if (RScore == 3)
                    t_P1RScoreText[3].text = P1_ScoreSave[3].ToString();

                if (RScore == 4)
                    t_P1RScoreText[4].text = P1_ScoreSave[4].ToString();

                if (RScore == 5)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[1].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[2].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[3].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[4].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[5].ToString();
                }

                if (RScore == 6)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[2].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[3].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[4].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[5].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[6].ToString();
                }

                if (RScore == 7)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[3].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[4].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[5].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[6].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[7].ToString();
                }

                if (RScore == 8)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[4].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[5].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[6].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[7].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[8].ToString();
                }

                if (RScore == 9)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[5].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[6].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[7].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[8].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[9].ToString();
                }

                if (RScore == 10)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[6].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[7].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[8].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[9].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[10].ToString();
                }

                if (RScore == 11)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[7].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[8].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[9].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[10].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[11].ToString();
                }

                if (RScore == 12)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[8].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[9].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[10].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[11].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[12].ToString();
                }

                if (RScore == 13)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[9].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[10].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[11].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[12].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[13].ToString();
                }

                if (RScore == 14)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[10].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[11].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[12].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[13].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[14].ToString();
                }

                if (RScore == 15)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[11].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[12].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[13].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[14].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[15].ToString();
                }

                if (RScore == 16)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[12].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[13].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[14].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[15].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[16].ToString();
                }

                if (RScore == 17)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[13].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[14].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[15].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[16].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[17].ToString();
                }

                if (RScore == 18)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[14].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[15].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[16].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[17].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[18].ToString();
                }

                if (RScore == 19)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[15].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[16].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[17].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[18].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[19].ToString();
                }

                if (RScore == 20)
                {
                    t_P1RScoreText[0].text = P1_ScoreSave[16].ToString();
                    t_P1RScoreText[1].text = P1_ScoreSave[17].ToString();
                    t_P1RScoreText[2].text = P1_ScoreSave[18].ToString();
                    t_P1RScoreText[3].text = P1_ScoreSave[19].ToString();
                    t_P1RScoreText[4].text = P1_ScoreSave[20].ToString();
                }
            }
        }

        if (isP2 && !isP3 && !isP4 && !isP1)
        {
            P2_ScoreSave[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_P2RScoreText[0].text = P2_ScoreSave[0].ToString();

                if (RScore == 1)
                    t_P2RScoreText[1].text = P2_ScoreSave[1].ToString();

                if (RScore == 2)
                    t_P2RScoreText[2].text = P2_ScoreSave[2].ToString();

                if (RScore == 3)
                    t_P2RScoreText[3].text = P2_ScoreSave[3].ToString();

                if (RScore == 4)
                    t_P2RScoreText[4].text = P2_ScoreSave[4].ToString();

                if (RScore == 5)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[1].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[2].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[3].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[4].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[5].ToString();
                }

                if (RScore == 6)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[2].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[3].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[4].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[5].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[6].ToString();
                }

                if (RScore == 7)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[3].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[4].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[5].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[6].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[7].ToString();
                }

                if (RScore == 8)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[4].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[5].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[6].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[7].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[8].ToString();
                }

                if (RScore == 9)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[5].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[6].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[7].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[8].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[9].ToString();
                }

                if (RScore == 10)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[6].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[7].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[8].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[9].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[10].ToString();
                }

                if (RScore == 11)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[7].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[8].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[9].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[10].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[11].ToString();
                }

                if (RScore == 12)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[8].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[9].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[10].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[11].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[12].ToString();
                }

                if (RScore == 13)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[9].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[10].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[11].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[12].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[13].ToString();
                }

                if (RScore == 14)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[10].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[11].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[12].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[13].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[14].ToString();
                }

                if (RScore == 15)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[11].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[12].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[13].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[14].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[15].ToString();
                }

                if (RScore == 16)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[12].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[13].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[14].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[15].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[16].ToString();
                }

                if (RScore == 17)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[13].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[14].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[15].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[16].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[17].ToString();
                }

                if (RScore == 18)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[14].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[15].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[16].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[17].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[18].ToString();
                }

                if (RScore == 19)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[15].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[16].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[17].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[18].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[19].ToString();
                }

                if (RScore == 20)
                {
                    t_P2RScoreText[0].text = P2_ScoreSave[16].ToString();
                    t_P2RScoreText[1].text = P2_ScoreSave[17].ToString();
                    t_P2RScoreText[2].text = P2_ScoreSave[18].ToString();
                    t_P2RScoreText[3].text = P2_ScoreSave[19].ToString();
                    t_P2RScoreText[4].text = P2_ScoreSave[20].ToString();
                }
            }
        }

        if (isP3 && !isP4 && !isP1 && !isP2)
        {
            P3_ScoreSave[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_P3RScoreText[0].text = P3_ScoreSave[0].ToString();

                if (RScore == 1)
                    t_P3RScoreText[1].text = P3_ScoreSave[1].ToString();

                if (RScore == 2)
                    t_P3RScoreText[2].text = P3_ScoreSave[2].ToString();

                if (RScore == 3)
                    t_P3RScoreText[3].text = P3_ScoreSave[3].ToString();

                if (RScore == 4)
                    t_P3RScoreText[4].text = P3_ScoreSave[4].ToString();

                if (RScore == 5)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[1].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[2].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[3].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[4].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[5].ToString();
                }

                if (RScore == 6)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[2].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[3].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[4].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[5].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[6].ToString();
                }

                if (RScore == 7)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[3].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[4].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[5].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[6].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[7].ToString();
                }

                if (RScore == 8)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[4].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[5].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[6].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[7].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[8].ToString();
                }

                if (RScore == 9)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[5].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[6].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[7].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[8].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[9].ToString();
                }

                if (RScore == 10)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[6].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[7].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[8].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[9].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[10].ToString();
                }

                if (RScore == 11)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[7].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[8].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[9].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[10].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[11].ToString();
                }

                if (RScore == 12)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[8].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[9].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[10].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[11].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[12].ToString();
                }

                if (RScore == 13)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[9].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[10].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[11].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[12].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[13].ToString();
                }

                if (RScore == 14)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[10].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[11].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[12].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[13].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[14].ToString();
                }

                if (RScore == 15)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[11].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[12].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[13].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[14].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[15].ToString();
                }

                if (RScore == 16)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[12].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[13].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[14].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[15].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[16].ToString();
                }

                if (RScore == 17)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[13].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[14].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[15].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[16].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[17].ToString();
                }

                if (RScore == 18)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[14].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[15].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[16].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[17].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[18].ToString();
                }

                if (RScore == 19)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[15].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[16].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[17].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[18].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[19].ToString();
                }

                if (RScore == 20)
                {
                    t_P3RScoreText[0].text = P3_ScoreSave[16].ToString();
                    t_P3RScoreText[1].text = P3_ScoreSave[17].ToString();
                    t_P3RScoreText[2].text = P3_ScoreSave[18].ToString();
                    t_P3RScoreText[3].text = P3_ScoreSave[19].ToString();
                    t_P3RScoreText[4].text = P3_ScoreSave[20].ToString();
                }
            }
        }

        if (isP4 && !isP1 && !isP2 && !isP3)
        {
            P4_ScoreSave[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_P4RScoreText[0].text = P4_ScoreSave[0].ToString();

                if (RScore == 1)
                    t_P4RScoreText[1].text = P4_ScoreSave[1].ToString();

                if (RScore == 2)
                    t_P4RScoreText[2].text = P4_ScoreSave[2].ToString();

                if (RScore == 3)
                    t_P4RScoreText[3].text = P4_ScoreSave[3].ToString();

                if (RScore == 4)
                    t_P4RScoreText[4].text = P4_ScoreSave[4].ToString();

                if (RScore == 5)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[1].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[2].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[3].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[4].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[5].ToString();
                }

                if (RScore == 6)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[2].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[3].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[4].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[5].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[6].ToString();
                }

                if (RScore == 7)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[3].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[4].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[5].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[6].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[7].ToString();
                }

                if (RScore == 8)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[4].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[5].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[6].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[7].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[8].ToString();
                }

                if (RScore == 9)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[5].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[6].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[7].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[8].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[9].ToString();
                }

                if (RScore == 10)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[6].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[7].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[8].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[9].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[10].ToString();
                }

                if (RScore == 11)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[7].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[8].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[9].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[10].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[11].ToString();
                }

                if (RScore == 12)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[8].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[9].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[10].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[11].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[12].ToString();
                }

                if (RScore == 13)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[9].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[10].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[11].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[12].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[13].ToString();
                }

                if (RScore == 14)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[10].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[11].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[12].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[13].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[14].ToString();
                }

                if (RScore == 15)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[11].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[12].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[13].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[14].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[15].ToString();
                }

                if (RScore == 16)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[12].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[13].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[14].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[15].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[16].ToString();
                }

                if (RScore == 17)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[13].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[14].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[15].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[16].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[17].ToString();
                }

                if (RScore == 18)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[14].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[15].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[16].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[17].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[18].ToString();
                }

                if (RScore == 19)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[15].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[16].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[17].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[18].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[19].ToString();
                }

                if (RScore == 20)
                {
                    t_P4RScoreText[0].text = P4_ScoreSave[16].ToString();
                    t_P4RScoreText[1].text = P4_ScoreSave[17].ToString();
                    t_P4RScoreText[2].text = P4_ScoreSave[18].ToString();
                    t_P4RScoreText[3].text = P4_ScoreSave[19].ToString();
                    t_P4RScoreText[4].text = P4_ScoreSave[20].ToString();
                }
            }
        }
    } //실시간으로 라운드별 점수를 저장을 할 함수

    void MyTurn()
    {
        if (isP1)
        {
            g_P1.transform.position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, -10f);
            g_P2.transform.position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, 0f);
            g_P3.transform.position = new Vector3(g_P3.transform.position.x, g_P3.transform.position.y, 0f);
            g_P4.transform.position = new Vector3(g_P4.transform.position.x, g_P4.transform.position.y, 0f);

            g_P1.transform.localScale = new Vector3(1f, 1f);
            g_P2.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P3.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P4.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[1];
            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOff[2];
            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOff[3];

            g_P_Score[0].SetActive(true);
            g_P_Score[1].SetActive(false);
            g_P_Score[2].SetActive(false);
            g_P_Score[3].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);
            g_OffScore[3].SetActive(true);

            g_RoundScore[0].SetActive(true);
            g_RoundScore[1].SetActive(false);
            g_RoundScore[2].SetActive(false);
            g_RoundScore[3].SetActive(false);

            g_PPDScore[0].SetActive(true);
            g_PPDScore[1].SetActive(false);
            g_PPDScore[2].SetActive(false);
            g_PPDScore[3].SetActive(false);

            for (int i = 0; i < i_RScore1.Length; i++)
            {
                i_RScore1[i].enabled = true;
                i_RScore2[i].enabled = false;
                i_RScore3[i].enabled = false;
                i_RScore4[i].enabled = false;
            }

        }
        if (isP2)
        {
            g_P1.transform.position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, 0f);
            g_P2.transform.position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, -10f);
            g_P3.transform.position = new Vector3(g_P3.transform.position.x, g_P3.transform.position.y, 0f);
            g_P4.transform.position = new Vector3(g_P4.transform.position.x, g_P4.transform.position.y, 0f);

            g_P1.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P2.transform.localScale = new Vector3(1f, 1f);
            g_P3.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P4.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOn[1];
            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOff[2];
            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOff[3];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[0];

            g_P_Score[1].SetActive(true);
            g_P_Score[2].SetActive(false);
            g_P_Score[3].SetActive(false);
            g_P_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[2].SetActive(true);
            g_OffScore[3].SetActive(true);
            g_OffScore[0].SetActive(true);

            g_RoundScore[1].SetActive(true);
            g_RoundScore[2].SetActive(false);
            g_RoundScore[3].SetActive(false);
            g_RoundScore[0].SetActive(false);

            g_PPDScore[1].SetActive(true);
            g_PPDScore[2].SetActive(false);
            g_PPDScore[3].SetActive(false);
            g_PPDScore[0].SetActive(false);

            for (int i = 0; i < i_RScore1.Length; i++)
            {
                i_RScore1[i].enabled = false;
                i_RScore2[i].enabled = true;
                i_RScore3[i].enabled = false;
                i_RScore4[i].enabled = false;
            }
        }
        if (isP3)
        {
            g_P1.transform.position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, 0f);
            g_P2.transform.position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, 0f);
            g_P3.transform.position = new Vector3(g_P3.transform.position.x, g_P3.transform.position.y, -10f);
            g_P4.transform.position = new Vector3(g_P4.transform.position.x, g_P4.transform.position.y, 0f);

            g_P1.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P2.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P3.transform.localScale = new Vector3(1f, 1f);
            g_P4.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOn[2];
            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOff[3];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[1];

            g_P_Score[2].SetActive(true);
            g_P_Score[3].SetActive(false);
            g_P_Score[0].SetActive(false);
            g_P_Score[1].SetActive(false);

            g_OffScore[2].SetActive(false);
            g_OffScore[3].SetActive(true);
            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(true);

            g_RoundScore[2].SetActive(true);
            g_RoundScore[3].SetActive(false);
            g_RoundScore[0].SetActive(false);
            g_RoundScore[1].SetActive(false);

            g_PPDScore[2].SetActive(true);
            g_PPDScore[3].SetActive(false);
            g_PPDScore[0].SetActive(false);
            g_PPDScore[1].SetActive(false);

            for (int i = 0; i < i_RScore1.Length; i++)
            {
                i_RScore1[i].enabled = false;
                i_RScore2[i].enabled = false;
                i_RScore3[i].enabled = true;
                i_RScore4[i].enabled = false;
            }
        }
        if (isP4)
        {
            g_P1.transform.position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, 0f);
            g_P2.transform.position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, 0f);
            g_P3.transform.position = new Vector3(g_P3.transform.position.x, g_P3.transform.position.y, 0f);
            g_P4.transform.position = new Vector3(g_P4.transform.position.x, g_P4.transform.position.y, -10f);

            g_P1.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P2.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P3.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P4.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[3].GetComponent<Image>().sprite = s_PlayerOn[3];
            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOff[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[1];
            g_i_Player[2].GetComponent<Image>().sprite = s_PlayerOff[2];

            g_P_Score[3].SetActive(true);
            g_P_Score[0].SetActive(false);
            g_P_Score[1].SetActive(false);
            g_P_Score[2].SetActive(false);

            g_OffScore[3].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);

            g_RoundScore[3].SetActive(true);
            g_RoundScore[0].SetActive(false);
            g_RoundScore[1].SetActive(false);
            g_RoundScore[2].SetActive(false);

            g_PPDScore[3].SetActive(true);
            g_PPDScore[0].SetActive(false);
            g_PPDScore[1].SetActive(false);
            g_PPDScore[2].SetActive(false);

            for (int i = 0; i < i_RScore1.Length; i++)
            {
                i_RScore1[i].enabled = false;
                i_RScore2[i].enabled = false;
                i_RScore3[i].enabled = false;
                i_RScore4[i].enabled = true;
            }
        }
        if (Round == RoundStop && Counting == 3)
        {
            g_P1.transform.position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, 0f);
            g_P2.transform.position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, 0f);
            g_P3.transform.position = new Vector3(g_P3.transform.position.x, g_P3.transform.position.y, 0f);
            g_P4.transform.position = new Vector3(g_P4.transform.position.x, g_P4.transform.position.y, 0f);
            for (int i = 0; i < g_OffScore.Length; i++)
            {
                g_OffScore[i].SetActive(false);
                g_P_Score[i].SetActive(true);
            }
        }
    }

    void PlayerNumberPlus()
    {
        g_C_Ani.SetActive(false);
        Counting = 0;
        g_M_Score[Players].SetActive(false);
        g_OffScore[Players].SetActive(true);
        Players += 1;
        g_M_Score[Players].SetActive(true);
        g_M_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        if (Players == 0)
        {
            isP1 = true;
            isP2 = false;
            isP3 = false;
            isP4 = false;
        }
        if (Players == 1)
        {
            isP2 = true;
            isP3 = false;
            isP4 = false;
            isP1 = false;
        }
        if (Players == 2)
        {
            isP3 = true;
            isP4 = false;
            isP1 = false;
            isP2 = false;
        }
        if (Players == 3)
        {
            isP4 = true;
            isP1 = false;
            isP2 = false;
            isP3 = false;
        }
    }

    void PlayerNumberMinus()
    {
        isP1 = true;
        isP2 = false;
        isP3 = false;
        isP4 = false;
        g_M_Score[Players].SetActive(false);
        g_OffScore[Players].SetActive(true);
        Players = 0;
        g_M_Score[Players].SetActive(true);
        g_M_Score[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
    }

    void FirstStart()
    {
        for (int i = 0; i < g_M_Score.Length; i++)
            g_M_Score[i].SetActive(false);
        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
        g_RoundR.SetActive(true);
        g_RoundNum[Round].SetActive(true);
        g_RoundOn.SetActive(true);
        g_R_Ani.SetActive(true);
        Invoke("FirstStartAniStop", 1f);
    }

    void FirstStartAniStop()
    {
        g_M_Score[Players].SetActive(true);
        g_RoundR.SetActive(false);
        g_RoundNum[Round].SetActive(false);
        g_RoundOn.SetActive(false);
        g_R_Ani.SetActive(false);
        Round = 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
    }

    void PPDScore(int Dart)
    {
        if (Players == 0)
        {
            P1_Total += Dart;
            P1_Average = P1_Total / P1_DartCount;
            t_PPDText1.text = string.Format("{0:N2}", P1_Average);
        }
        if (Players == 1)
        {
            P2_Total += Dart;
            P2_Average = P2_Total / P2_DartCount;
            t_PPDText2.text = string.Format("{0:N2}", P2_Average);
        }
        if (Players == 2)
        {
            P3_Total += Dart;
            P3_Average = P3_Total / P3_DartCount;
            t_PPDText3.text = string.Format("{0:N2}", P3_Average);
        }
        if (Players == 3)
        {
            P4_Total += Dart;
            P4_Average = P4_Total / P4_DartCount;
            t_PPDText4.text = string.Format("{0:N2}", P4_Average);
        }
    }

    public int GetMovie()
    {
        if (m_oDartInfo[0].nScore == 50 && m_oDartInfo[1].nScore == 50 && m_oDartInfo[2].nScore == 50)
        {
            csgmg.MoviePlay(1);
        }
        else if ((m_oDartInfo[0].nScore == 25 || m_oDartInfo[0].nScore == 50) && (m_oDartInfo[1].nScore == 25 || m_oDartInfo[1].nScore == 50) && (m_oDartInfo[2].nScore == 25 || m_oDartInfo[2].nScore == 50))
        {//hattrick
            csgmg.MoviePlay(2);
        }
        else if (m_oDartInfo[0].nScore + m_oDartInfo[1].nScore + m_oDartInfo[2].nScore > 151)
        {//highton
            csgmg.MoviePlay(3);
        }
        else if (m_oDartInfo[0].nScore + m_oDartInfo[1].nScore + m_oDartInfo[2].nScore > 100 && m_oDartInfo[0].nScore + m_oDartInfo[1].nScore + m_oDartInfo[2].nScore < 150)
        {//lowton
            csgmg.MoviePlay(4);
        }
        else if (m_oDartInfo[0].nLine == m_oDartInfo[1].nLine && m_oDartInfo[0].nLine == m_oDartInfo[2].nLine && m_oDartInfo[1].nLine == m_oDartInfo[2].nLine &&
            m_oDartInfo[0].nScore == m_oDartInfo[1].nScore && m_oDartInfo[0].nScore == m_oDartInfo[2].nScore && m_oDartInfo[1].nScore == m_oDartInfo[2].nScore)
        {//three in a bed
            csgmg.MoviePlay(5);
        }
        else if (m_oDartInfo[0].nLine == 3 && m_oDartInfo[1].nLine == 3 && m_oDartInfo[2].nLine == 3 &&
                      m_oDartInfo[0].nScore != m_oDartInfo[1].nScore && m_oDartInfo[0].nScore != m_oDartInfo[2].nScore && m_oDartInfo[1].nScore != m_oDartInfo[2].nScore)
        {//white horse
            csgmg.MoviePlay(6);
        }
        else
            return 0;
        return 0;
    }
}
