using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class PT_01TwoPlay : MonoBehaviour
{
    public Text t_RoundText;
    public Text t_PPDText1;
    public Text t_PPDText2;
    public Text[] t_P1RScoreText = new Text[5];
    public Text[] t_P2RScoreText = new Text[5];

    public Sprite s_OnDart;
    public Sprite s_OffDart;
    public Sprite[] s_RScore = new Sprite[20];
    public Sprite[] s_PlayerOn = new Sprite[2];
    public Sprite[] s_PlayerOff = new Sprite[2];
    public Sprite[] s_PlayerbarOn = new Sprite[2];
    public Sprite[] s_PlayerbarOff = new Sprite[2];

    public Image[] i_RScore1 = new Image[5];
    public Image[] i_RScore2 = new Image[5];
    public GameObject g_P1; //플레이어 바 부모

    public GameObject g_P2;
    public GameObject g_G_Bust; //버스트
    public GameObject g_D_ani;    //특정구역 다트 맞으면 나오는애니
    public GameObject g_CAni;    //플레이어끼리 체인지 애니
    public GameObject g_R_Ani;    //라운드 끝나면 나오는 애니
    public GameObject g_P_Ani; //라운드 끝나다는걸 알려주는 애니
    public GameObject g_RoundOn;
    public GameObject g_RoundR;
    public GameObject[] g_i_Player = new GameObject[2];   //플레이어 숫자이미지
    public GameObject[] g_Dart = new GameObject[3];//다트
    public GameObject[] g_RoundScore = new GameObject[2];
    public GameObject[] g_PPDScore = new GameObject[2];
    public GameObject[] g_RoundNum = new GameObject[21];
    public GameObject[] g_MScore = new GameObject[2];
    public GameObject[] g_PScore = new GameObject[2];
    public GameObject[] g_OffScore = new GameObject[2];

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int RoundStop = 0;
    public int DefultScore = 0;

    public int Counting = 0;//카운팅
    public int Round = 0;//라운드
    public int DartCount1 = 0;//다트 총합
    public int DartCount2 = 0;
    public int RScore = 0; //R관련 카운팅
    public int MainScore = 0; //화면에 큰 텍스트 점수
    public int Players = 0; //플레이어
    public int Total1 = 0;//다트 총합
    public int Total2 = 0;
    public int PlayerBasicScore = 0;
    public int[] PlayerScore = new int[2];
    public int[] DartScore = new int[3]; //첫 다트 점수
    public int[] DartBasicScore = new int[3];
    public int[] BustScore = new int[2];
    public int[] ScoreSave1 = new int[20];
    public int[] ScoreSave2 = new int[20];
    public int win = 0;

    public float Average1 = 0;//다트 평균값 
    public float Average2 = 0;

    public string[] playerName = new string[2];

    public bool isP1 = true;
    public bool isP2 = false;
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
        for (int i = 0; i < g_MScore.Length; i++)
        {
            g_MScore[i].GetComponent<csNumber>().CreateNumber(3, 250, 3f, 0);
            g_PScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_OffScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_MScore[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
            g_PScore[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
            g_OffScore[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
        }
        g_G_Bust.SetActive(false);
        g_P_Ani.SetActive(false);
        g_CAni.SetActive(false);
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
                if (Players == 0 && isP1 && !isBust && !isRead)
                {
                    if (Counting == 0 && isP1 && !isBust && !isRead)
                    {
                        DartCount1++;
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
                    else if (Counting == 1 && isP1 && !isBust && !isRead)
                    {
                        DartCount1++;
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
                    else if (Counting == 2 && isP1 && !isBust && !isRead)
                    {
                        DartCount1++;
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
                    if (Counting == 3 && !isBust && !isRead)
                    {

                        BustScore[0] = PlayerScore[0];
                        g_MScore[0].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                else if (Players == 1 && isP2)
                {
                    if (Counting == 0 && isP2 && !isBust && !isRead)
                    {
                        DartCount2++;
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
                    else if (Counting == 1 && isP2 && !isBust && !isRead)
                    {
                        DartCount1++;
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
                    else if (Counting == 2 && isP2 && !isBust && !isRead)
                    {
                        DartCount1++;
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
                    if (Counting == 3 && !isBust && !isRead)
                    {

                        BustScore[1] = PlayerScore[1];
                        g_MScore[1].SetActive(false);
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
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                csgmg.DartScoreReSet();
                g_CAni.SetActive(true);
                g_P_Ani.SetActive(false);
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("PlayerNumberPlus", 4.5f);
            }
            else if (Players == 1 && isP2)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                g_CAni.SetActive(true);
                g_P_Ani.SetActive(false);
                RScore += 1;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("PlayerNumberMinus", 4.5f);
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
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                csgmg.DartScoreReSet();
                g_CAni.SetActive(true);
                g_P_Ani.SetActive(false);
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("PlayerNumberPlus", 4.5f);
            }
            else if (Players == 1 && isP2)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                PlayerBasicScore = 0;
                g_CAni.SetActive(true);
                g_P_Ani.SetActive(false);
                RScore += 1;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("PlayerNumberMinus", 4.5f);
                BustAndRoundRead();
            }


        }
        if (Round == RoundStop && Counting == 3 && isP2)
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
            g_PScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            WinRead();
        }

        if (Round == RoundStop && Counting == 4 && isP2)
        {
            g_CAni.SetActive(false);
            GameEndRead();
        }
    }

    void Bust()
    {
        isRead = true;
        g_G_Bust.SetActive(true);
        g_MScore[Players].SetActive(false);
        PlayerScore[Players] = BustScore[Players];
        g_PScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
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
            g_MScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_PScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            g_OffScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
            Counting++;
        }

        if (Counting == 4 && isP2 && !isBust && !isRead)
            RoundRead();
    }

    void RoundRead()
    {
        isRead = true;
        g_P_Ani.SetActive(false);
        g_PScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        g_CAni.SetActive(true);
        g_MScore[Players].SetActive(false);
        for (int i = 0; i < g_MScore.Length; i++)
            g_MScore[i].SetActive(false);
        Invoke("RoundStart", 3f);
    }

    void RoundStart()
    {
        g_CAni.SetActive(false);
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
        g_MScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        g_MScore[Players].SetActive(true);
        Round += 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void WinRead() // 이기면 바로 여기로
    {
        if (isP1 && !isP2)
        {
            win = 0;
            isWin = true;
            isP1 = true;
            isP2 = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (isP2 && !isP1)
        {
            win = 1;
            isWin = true;
            isP1 = false;
            isP2 = true;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            csgmg.GameEndRead(win);
        }
    }

    void GameEndRead() //라운드 종료로 오면 여기로
    {
        if (PlayerScore[1] < PlayerScore[0])
        {
            win = 0;
            isWin = true;
            isP1 = true;
            isP2 = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (PlayerScore[0] < PlayerScore[1])
        {
            win = 1;
            isWin = true;
            isP1 = false;
            isP2 = true;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (PlayerScore[0] == PlayerScore[1])
        {
            win = 0;
            isWin = true;
            isP1 = true;
            isP2 = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            csgmg.GameEndRead(win);
        }
    }

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

                t_P1RScoreText[0].text = ScoreSave1[1].ToString();
                t_P1RScoreText[1].text = ScoreSave1[2].ToString();
                t_P1RScoreText[2].text = ScoreSave1[3].ToString();
                t_P1RScoreText[3].text = ScoreSave1[4].ToString();
                t_P1RScoreText[4].text = ScoreSave1[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[6];

                t_P1RScoreText[0].text = ScoreSave1[2].ToString();
                t_P1RScoreText[1].text = ScoreSave1[3].ToString();
                t_P1RScoreText[2].text = ScoreSave1[4].ToString();
                t_P1RScoreText[3].text = ScoreSave1[5].ToString();
                t_P1RScoreText[4].text = ScoreSave1[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[7];

                t_P1RScoreText[0].text = ScoreSave1[3].ToString();
                t_P1RScoreText[1].text = ScoreSave1[4].ToString();
                t_P1RScoreText[2].text = ScoreSave1[5].ToString();
                t_P1RScoreText[3].text = ScoreSave1[6].ToString();
                t_P1RScoreText[4].text = ScoreSave1[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[8];

                t_P1RScoreText[0].text = ScoreSave1[4].ToString();
                t_P1RScoreText[1].text = ScoreSave1[5].ToString();
                t_P1RScoreText[2].text = ScoreSave1[6].ToString();
                t_P1RScoreText[3].text = ScoreSave1[7].ToString();
                t_P1RScoreText[4].text = ScoreSave1[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[9];

                t_P1RScoreText[0].text = ScoreSave1[5].ToString();
                t_P1RScoreText[1].text = ScoreSave1[6].ToString();
                t_P1RScoreText[2].text = ScoreSave1[7].ToString();
                t_P1RScoreText[3].text = ScoreSave1[8].ToString();
                t_P1RScoreText[4].text = ScoreSave1[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[10];

                t_P1RScoreText[0].text = ScoreSave1[6].ToString();
                t_P1RScoreText[1].text = ScoreSave1[7].ToString();
                t_P1RScoreText[2].text = ScoreSave1[8].ToString();
                t_P1RScoreText[3].text = ScoreSave1[9].ToString();
                t_P1RScoreText[4].text = ScoreSave1[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[11];

                t_P1RScoreText[0].text = ScoreSave1[7].ToString();
                t_P1RScoreText[1].text = ScoreSave1[8].ToString();
                t_P1RScoreText[2].text = ScoreSave1[9].ToString();
                t_P1RScoreText[3].text = ScoreSave1[10].ToString();
                t_P1RScoreText[4].text = ScoreSave1[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[12];

                t_P1RScoreText[0].text = ScoreSave1[8].ToString();
                t_P1RScoreText[1].text = ScoreSave1[9].ToString();
                t_P1RScoreText[2].text = ScoreSave1[10].ToString();
                t_P1RScoreText[3].text = ScoreSave1[11].ToString();
                t_P1RScoreText[4].text = ScoreSave1[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[13];

                t_P1RScoreText[0].text = ScoreSave1[9].ToString();
                t_P1RScoreText[1].text = ScoreSave1[10].ToString();
                t_P1RScoreText[2].text = ScoreSave1[11].ToString();
                t_P1RScoreText[3].text = ScoreSave1[12].ToString();
                t_P1RScoreText[4].text = ScoreSave1[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[14];

                t_P1RScoreText[0].text = ScoreSave1[10].ToString();
                t_P1RScoreText[1].text = ScoreSave1[11].ToString();
                t_P1RScoreText[2].text = ScoreSave1[12].ToString();
                t_P1RScoreText[3].text = ScoreSave1[13].ToString();
                t_P1RScoreText[4].text = ScoreSave1[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[15];

                t_P1RScoreText[0].text = ScoreSave1[11].ToString();
                t_P1RScoreText[1].text = ScoreSave1[12].ToString();
                t_P1RScoreText[2].text = ScoreSave1[13].ToString();
                t_P1RScoreText[3].text = ScoreSave1[14].ToString();
                t_P1RScoreText[4].text = ScoreSave1[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[16];

                t_P1RScoreText[0].text = ScoreSave1[12].ToString();
                t_P1RScoreText[1].text = ScoreSave1[13].ToString();
                t_P1RScoreText[2].text = ScoreSave1[14].ToString();
                t_P1RScoreText[3].text = ScoreSave1[15].ToString();
                t_P1RScoreText[4].text = ScoreSave1[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[17];

                t_P1RScoreText[0].text = ScoreSave1[13].ToString();
                t_P1RScoreText[1].text = ScoreSave1[14].ToString();
                t_P1RScoreText[2].text = ScoreSave1[15].ToString();
                t_P1RScoreText[3].text = ScoreSave1[16].ToString();
                t_P1RScoreText[4].text = ScoreSave1[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[18];

                t_P1RScoreText[0].text = ScoreSave1[14].ToString();
                t_P1RScoreText[1].text = ScoreSave1[15].ToString();
                t_P1RScoreText[2].text = ScoreSave1[16].ToString();
                t_P1RScoreText[3].text = ScoreSave1[17].ToString();
                t_P1RScoreText[4].text = ScoreSave1[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[19];

                t_P1RScoreText[0].text = ScoreSave1[15].ToString();
                t_P1RScoreText[1].text = ScoreSave1[16].ToString();
                t_P1RScoreText[2].text = ScoreSave1[17].ToString();
                t_P1RScoreText[3].text = ScoreSave1[18].ToString();
                t_P1RScoreText[4].text = ScoreSave1[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScore1[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore1[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore1[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore1[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScore1[4].GetComponent<Image>().sprite = s_RScore[20];

                t_P1RScoreText[0].text = ScoreSave1[16].ToString();
                t_P1RScoreText[1].text = ScoreSave1[17].ToString();
                t_P1RScoreText[2].text = ScoreSave1[18].ToString();
                t_P1RScoreText[3].text = ScoreSave1[19].ToString();
                t_P1RScoreText[4].text = ScoreSave1[20].ToString();
            }

        }

        if (isP2 && !isP1)
        {
            if (RScore == 5)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[5];

                t_P2RScoreText[0].text = ScoreSave2[1].ToString();
                t_P2RScoreText[1].text = ScoreSave2[2].ToString();
                t_P2RScoreText[2].text = ScoreSave2[3].ToString();
                t_P2RScoreText[3].text = ScoreSave2[4].ToString();
                t_P2RScoreText[4].text = ScoreSave2[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[6];

                t_P2RScoreText[0].text = ScoreSave2[2].ToString();
                t_P2RScoreText[1].text = ScoreSave2[3].ToString();
                t_P2RScoreText[2].text = ScoreSave2[4].ToString();
                t_P2RScoreText[3].text = ScoreSave2[5].ToString();
                t_P2RScoreText[4].text = ScoreSave2[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[7];

                t_P2RScoreText[0].text = ScoreSave2[3].ToString();
                t_P2RScoreText[1].text = ScoreSave2[4].ToString();
                t_P2RScoreText[2].text = ScoreSave2[5].ToString();
                t_P2RScoreText[3].text = ScoreSave2[6].ToString();
                t_P2RScoreText[4].text = ScoreSave2[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[8];

                t_P2RScoreText[0].text = ScoreSave2[4].ToString();
                t_P2RScoreText[1].text = ScoreSave2[5].ToString();
                t_P2RScoreText[2].text = ScoreSave2[6].ToString();
                t_P2RScoreText[3].text = ScoreSave2[7].ToString();
                t_P2RScoreText[4].text = ScoreSave2[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[9];

                t_P2RScoreText[0].text = ScoreSave2[5].ToString();
                t_P2RScoreText[1].text = ScoreSave2[6].ToString();
                t_P2RScoreText[2].text = ScoreSave2[7].ToString();
                t_P2RScoreText[3].text = ScoreSave2[8].ToString();
                t_P2RScoreText[4].text = ScoreSave2[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[10];

                t_P2RScoreText[0].text = ScoreSave2[6].ToString();
                t_P2RScoreText[1].text = ScoreSave2[7].ToString();
                t_P2RScoreText[2].text = ScoreSave2[8].ToString();
                t_P2RScoreText[3].text = ScoreSave2[9].ToString();
                t_P2RScoreText[4].text = ScoreSave2[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[11];

                t_P2RScoreText[0].text = ScoreSave2[7].ToString();
                t_P2RScoreText[1].text = ScoreSave2[8].ToString();
                t_P2RScoreText[2].text = ScoreSave2[9].ToString();
                t_P2RScoreText[3].text = ScoreSave2[10].ToString();
                t_P2RScoreText[4].text = ScoreSave2[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[12];

                t_P2RScoreText[0].text = ScoreSave2[8].ToString();
                t_P2RScoreText[1].text = ScoreSave2[9].ToString();
                t_P2RScoreText[2].text = ScoreSave2[10].ToString();
                t_P2RScoreText[3].text = ScoreSave2[11].ToString();
                t_P2RScoreText[4].text = ScoreSave2[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[13];

                t_P2RScoreText[0].text = ScoreSave2[9].ToString();
                t_P2RScoreText[1].text = ScoreSave2[10].ToString();
                t_P2RScoreText[2].text = ScoreSave2[11].ToString();
                t_P2RScoreText[3].text = ScoreSave2[12].ToString();
                t_P2RScoreText[4].text = ScoreSave2[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[14];

                t_P2RScoreText[0].text = ScoreSave2[10].ToString();
                t_P2RScoreText[1].text = ScoreSave2[11].ToString();
                t_P2RScoreText[2].text = ScoreSave2[12].ToString();
                t_P2RScoreText[3].text = ScoreSave2[13].ToString();
                t_P2RScoreText[4].text = ScoreSave2[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[15];

                t_P2RScoreText[0].text = ScoreSave2[11].ToString();
                t_P2RScoreText[1].text = ScoreSave2[12].ToString();
                t_P2RScoreText[2].text = ScoreSave2[13].ToString();
                t_P2RScoreText[3].text = ScoreSave2[14].ToString();
                t_P2RScoreText[4].text = ScoreSave2[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[16];

                t_P2RScoreText[0].text = ScoreSave2[12].ToString();
                t_P2RScoreText[1].text = ScoreSave2[13].ToString();
                t_P2RScoreText[2].text = ScoreSave2[14].ToString();
                t_P2RScoreText[3].text = ScoreSave2[15].ToString();
                t_P2RScoreText[4].text = ScoreSave2[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[17];

                t_P2RScoreText[0].text = ScoreSave2[13].ToString();
                t_P2RScoreText[1].text = ScoreSave2[14].ToString();
                t_P2RScoreText[2].text = ScoreSave2[15].ToString();
                t_P2RScoreText[3].text = ScoreSave2[16].ToString();
                t_P2RScoreText[4].text = ScoreSave2[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[18];

                t_P2RScoreText[0].text = ScoreSave2[14].ToString();
                t_P2RScoreText[1].text = ScoreSave2[15].ToString();
                t_P2RScoreText[2].text = ScoreSave2[16].ToString();
                t_P2RScoreText[3].text = ScoreSave2[17].ToString();
                t_P2RScoreText[4].text = ScoreSave2[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[19];

                t_P2RScoreText[0].text = ScoreSave2[15].ToString();
                t_P2RScoreText[1].text = ScoreSave2[16].ToString();
                t_P2RScoreText[2].text = ScoreSave2[17].ToString();
                t_P2RScoreText[3].text = ScoreSave2[18].ToString();
                t_P2RScoreText[4].text = ScoreSave2[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScore2[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScore2[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScore2[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScore2[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScore2[4].GetComponent<Image>().sprite = s_RScore[20];

                t_P2RScoreText[0].text = ScoreSave2[16].ToString();
                t_P2RScoreText[1].text = ScoreSave2[17].ToString();
                t_P2RScoreText[2].text = ScoreSave2[18].ToString();
                t_P2RScoreText[3].text = ScoreSave2[19].ToString();
                t_P2RScoreText[4].text = ScoreSave2[20].ToString();
            }

        }
    } //라운드가 끝나고 이미지를 한칸씩올려줄 함수

    void RoundScore(int DartScore)
    {
        if (isP1 && !isP2)
        {
            ScoreSave1[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_P1RScoreText[0].text = ScoreSave1[0].ToString();

                if (RScore == 1)
                    t_P1RScoreText[1].text = ScoreSave1[1].ToString();

                if (RScore == 2)
                    t_P1RScoreText[2].text = ScoreSave1[2].ToString();

                if (RScore == 3)
                    t_P1RScoreText[3].text = ScoreSave1[3].ToString();

                if (RScore == 4)
                    t_P1RScoreText[4].text = ScoreSave1[4].ToString();

                if (RScore == 5)
                {
                    t_P1RScoreText[0].text = ScoreSave1[1].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[2].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[3].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[4].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[5].ToString();
                }

                if (RScore == 6)
                {
                    t_P1RScoreText[0].text = ScoreSave1[2].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[3].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[4].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[5].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[6].ToString();
                }

                if (RScore == 7)
                {
                    t_P1RScoreText[0].text = ScoreSave1[3].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[4].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[5].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[6].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[7].ToString();
                }

                if (RScore == 8)
                {
                    t_P1RScoreText[0].text = ScoreSave1[4].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[5].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[6].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[7].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[8].ToString();
                }

                if (RScore == 9)
                {
                    t_P1RScoreText[0].text = ScoreSave1[5].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[6].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[7].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[8].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[9].ToString();
                }

                if (RScore == 10)
                {
                    t_P1RScoreText[0].text = ScoreSave1[6].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[7].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[8].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[9].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[10].ToString();
                }

                if (RScore == 11)
                {
                    t_P1RScoreText[0].text = ScoreSave1[7].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[8].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[9].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[10].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[11].ToString();
                }

                if (RScore == 12)
                {
                    t_P1RScoreText[0].text = ScoreSave1[8].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[9].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[10].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[11].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[12].ToString();
                }

                if (RScore == 13)
                {
                    t_P1RScoreText[0].text = ScoreSave1[9].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[10].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[11].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[12].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[13].ToString();
                }

                if (RScore == 14)
                {
                    t_P1RScoreText[0].text = ScoreSave1[10].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[11].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[12].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[13].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[14].ToString();
                }

                if (RScore == 15)
                {
                    t_P1RScoreText[0].text = ScoreSave1[11].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[12].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[13].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[14].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[15].ToString();
                }

                if (RScore == 16)
                {
                    t_P1RScoreText[0].text = ScoreSave1[12].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[13].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[14].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[15].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[16].ToString();
                }

                if (RScore == 17)
                {
                    t_P1RScoreText[0].text = ScoreSave1[13].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[14].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[15].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[16].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[17].ToString();
                }

                if (RScore == 18)
                {
                    t_P1RScoreText[0].text = ScoreSave1[14].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[15].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[16].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[17].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[18].ToString();
                }

                if (RScore == 19)
                {
                    t_P1RScoreText[0].text = ScoreSave1[15].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[16].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[17].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[18].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[19].ToString();
                }

                if (RScore == 20)
                {
                    t_P1RScoreText[0].text = ScoreSave1[16].ToString();
                    t_P1RScoreText[1].text = ScoreSave1[17].ToString();
                    t_P1RScoreText[2].text = ScoreSave1[18].ToString();
                    t_P1RScoreText[3].text = ScoreSave1[19].ToString();
                    t_P1RScoreText[4].text = ScoreSave1[20].ToString();
                }
            }
        }

        if (isP2 && !isP1)
        {
            ScoreSave2[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_P2RScoreText[0].text = ScoreSave2[0].ToString();

                if (RScore == 1)
                    t_P2RScoreText[1].text = ScoreSave2[1].ToString();

                if (RScore == 2)
                    t_P2RScoreText[2].text = ScoreSave2[2].ToString();

                if (RScore == 3)
                    t_P2RScoreText[3].text = ScoreSave2[3].ToString();

                if (RScore == 4)
                    t_P2RScoreText[4].text = ScoreSave2[4].ToString();

                if (RScore == 5)
                {
                    t_P2RScoreText[0].text = ScoreSave2[1].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[2].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[3].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[4].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[5].ToString();
                }

                if (RScore == 6)
                {
                    t_P2RScoreText[0].text = ScoreSave2[2].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[3].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[4].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[5].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[6].ToString();
                }

                if (RScore == 7)
                {
                    t_P2RScoreText[0].text = ScoreSave2[3].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[4].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[5].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[6].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[7].ToString();
                }

                if (RScore == 8)
                {
                    t_P2RScoreText[0].text = ScoreSave2[4].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[5].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[6].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[7].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[8].ToString();
                }

                if (RScore == 9)
                {
                    t_P2RScoreText[0].text = ScoreSave2[5].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[6].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[7].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[8].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[9].ToString();
                }

                if (RScore == 10)
                {
                    t_P2RScoreText[0].text = ScoreSave2[6].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[7].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[8].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[9].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[10].ToString();
                }

                if (RScore == 11)
                {
                    t_P2RScoreText[0].text = ScoreSave2[7].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[8].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[9].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[10].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[11].ToString();
                }

                if (RScore == 12)
                {
                    t_P2RScoreText[0].text = ScoreSave2[8].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[9].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[10].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[11].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[12].ToString();
                }

                if (RScore == 13)
                {
                    t_P2RScoreText[0].text = ScoreSave2[9].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[10].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[11].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[12].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[13].ToString();
                }

                if (RScore == 14)
                {
                    t_P2RScoreText[0].text = ScoreSave2[10].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[11].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[12].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[13].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[14].ToString();
                }

                if (RScore == 15)
                {
                    t_P2RScoreText[0].text = ScoreSave2[11].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[12].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[13].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[14].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[15].ToString();
                }

                if (RScore == 16)
                {
                    t_P2RScoreText[0].text = ScoreSave2[12].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[13].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[14].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[15].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[16].ToString();
                }

                if (RScore == 17)
                {
                    t_P2RScoreText[0].text = ScoreSave2[13].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[14].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[15].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[16].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[17].ToString();
                }

                if (RScore == 18)
                {
                    t_P2RScoreText[0].text = ScoreSave2[14].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[15].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[16].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[17].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[18].ToString();
                }

                if (RScore == 19)
                {
                    t_P2RScoreText[0].text = ScoreSave2[15].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[16].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[17].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[18].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[19].ToString();
                }

                if (RScore == 20)
                {
                    t_P2RScoreText[0].text = ScoreSave2[16].ToString();
                    t_P2RScoreText[1].text = ScoreSave2[17].ToString();
                    t_P2RScoreText[2].text = ScoreSave2[18].ToString();
                    t_P2RScoreText[3].text = ScoreSave2[19].ToString();
                    t_P2RScoreText[4].text = ScoreSave2[20].ToString();
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

            g_P1.transform.localScale = new Vector3(1f, 1f);
            g_P2.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_PlayerOn[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_PlayerOff[1];

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            g_RoundScore[0].SetActive(true);
            g_RoundScore[1].SetActive(false);

            g_PPDScore[0].SetActive(true);
            g_PPDScore[1].SetActive(false);

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

            g_PScore[1].SetActive(true);
            g_PScore[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            g_RoundScore[1].SetActive(true);
            g_RoundScore[0].SetActive(false);

            g_PPDScore[1].SetActive(true);
            g_PPDScore[0].SetActive(false);

            for (int i = 0; i < i_RScore1.Length; i++)
            {
                i_RScore1[i].enabled = false;
                i_RScore2[i].enabled = true;
            }
        }
        if (Round == RoundStop && Counting == 3)
        {
            g_P1.transform.position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, 0f);
            g_P2.transform.position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, 0f);

            for (int i = 0; i < g_OffScore.Length; i++)
            {
                g_OffScore[i].SetActive(false);
                g_PScore[i].SetActive(true);
            }
        }
    }

    void PlayerNumberPlus()
    {
        isP1 = false;
        isP2 = true;
        isRead = false;
        Counting = 0;
        g_CAni.SetActive(false);
        g_MScore[0].SetActive(false);
        g_PScore[0].SetActive(false);
        g_OffScore[0].SetActive(true);
        g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
        Players = 1;
        g_MScore[Players].SetActive(true);
        g_PScore[Players].SetActive(true);
        g_OffScore[Players].SetActive(false);
        g_PScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
        g_MScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
    }

    void PlayerNumberMinus()
    {
        isP1 = true;
        isP2 = false;
        Counting = 0;
        g_CAni.SetActive(false);
        g_MScore[1].SetActive(false);
        g_PScore[1].SetActive(false);
        g_OffScore[1].SetActive(true);
        g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
        Players = 0;
        g_MScore[Players].SetActive(true);
        g_PScore[Players].SetActive(true);
        g_OffScore[Players].SetActive(false);
        g_PScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
        g_MScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
    }

    void FirstStart()
    {
        isP1 = true;
        isP2 = false;
        for (int i = 0; i < g_MScore.Length; i++)
            g_MScore[i].SetActive(false);
        for (int i = 0; i < g_Dart.Length; i++)
            g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
        g_RoundR.SetActive(true);
        g_RoundNum[Round].SetActive(true);
        g_RoundOn.SetActive(true);
        g_R_Ani.SetActive(true);
        Invoke("FirstStartAniStop", 1f);
    }
    void FirstStartAniStop()
    {
        g_MScore[Players].SetActive(true);
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
            Total1 += Dart;
            Average1 = Total1 / DartCount1;
            t_PPDText1.text = string.Format("{0:N2}", Average1);
        }
        else if (Players == 1)
        {
            Total2 += Dart;
            Average2 = Total2 / DartCount1;
            t_PPDText2.text = string.Format("{0:N2}", Average2);
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
