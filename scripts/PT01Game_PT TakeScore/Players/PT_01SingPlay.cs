using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class PT_01SingPlay : MonoBehaviour
{
    public Text t_RoundText;
    public Text t_PPDText;
    public Text[] t_RScoreText = new Text[5];

    public GameObject[] g_Dart = new GameObject[3];
    public Sprite s_OnDart;
    public Sprite s_OffDart;
    public Sprite[] s_RScore = new Sprite[20];
    public Image[] i_RScore = new Image[5];

    public GameObject G_Bust;
    public GameObject g_R_Ani;
    public GameObject g_C_Ani;
    public GameObject g_P_Ani;
    public GameObject g_D_Ani;
    public GameObject g_RoundOn;
    public GameObject g_RoundR;
    public GameObject[] g_RoundNum = new GameObject[21];
    public GameObject g_M_Score;
    public GameObject g_P_Score;

    public VideoPlayer v_BustMove;

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int Couting = 0;//카운팅
    public int Round = 0;//라운드
    public int RoundStop = 0;//라운드 제한수
    public int[] DartScore = new int[3]; //다트 점수
    public int[] DartBasicScore = new int[3];
    public int DartTotal = 0;
    public float Average = 0; //평균값 을 받고 초기화
    public int RScore = 0; //R1같은 점수
    public int DefultScore = 0; //처음 점수
    public int BustScore = 0;   //버스트 되기전 점수
    public int PlayerScore = 0; //플레이어 점수
    public int PlayerBasicScore = 0;
    public int DartCount = 0;//평균값내기위한 카운팅
    public int[] ScoreSave = new int[20];

    public string player1;

    public bool isBust = false;
    public bool isRead = false;
    public bool isWin = false;
    public bool isSpace = false;

    public _TARGET_INFO[] m_oDartInfo = new _TARGET_INFO[3];
    public cs01GameManager csgmg;

    void Start()
    {
        PlayerScore = DefultScore;
        GameStart();
        for (int i = 0; i < g_RoundNum.Length; i++)
            g_RoundNum[i].SetActive(false);
        g_RoundR.SetActive(true);
        g_RoundNum[Round].SetActive(true);
        g_RoundOn.SetActive(true);
        G_Bust.SetActive(false);
    }


    void Update()
    {
        ImageUp();
        if (csSingleton.getInstance.g_bTarget && !isRead && !isSpace && !isWin && !isBust)
        {
            csSingleton.getInstance.g_bTarget = false;
            if (Round <= RoundStop && !isRead && !isWin && !isBust)
            {
                if (Couting == 0 && !isRead && !isBust)
                {
                    DartCount++;
                    a_source.PlayOneShot(ac_shoot1, 1.0f);
                    g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                    DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                    DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                    m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                    m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                    PlayerBasicScore = DartScore[0];
                    PPDScore(PlayerBasicScore);
                    RoundScore(DartScore[0]);
                    csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Couting);
                    BustAndRoundRead();
                    PlayerBasicScore = 0;
                }
                else if (Couting == 1 && !isRead && !isBust)
                {
                    DartCount++;
                    a_source.PlayOneShot(ac_shoot1, 1.0f);
                    g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                    DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                    DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                    m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                    m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                    PlayerBasicScore = DartScore[1];
                    PPDScore(PlayerBasicScore);
                    RoundScore(DartScore[1]);
                    csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Couting);
                    BustAndRoundRead();
                    PlayerBasicScore = 0;
                }
                else if (Couting == 2 && !isRead && !isBust)
                {
                    DartCount++;
                    a_source.PlayOneShot(ac_shoot1, 1.0f);
                    DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                    DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                    m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                    m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                    PlayerBasicScore = DartScore[2];
                    PPDScore(PlayerBasicScore);
                    RoundScore(DartScore[2]);
                    csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Couting);
                    BustAndRoundRead();
                    PlayerBasicScore = 0;
                }
                if (Couting == 3 && !isRead && !isBust)
                {
                    GetMovie();
                    BustScore = PlayerScore;
                    g_M_Score.SetActive(false);
                    g_P_Ani.SetActive(true);
                    isSpace = true;
                    Couting = 4;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && Couting == 4 && !isWin && isSpace)
        {
            a_source.PlayOneShot(ac_shoot2, 1.0f);
            for (int i = 0; i < g_Dart.Length; i++)
                g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
            g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
            for (int i = 0; i < DartScore.Length; i++)
                DartScore[i] = 0;
            csgmg.DartScoreReSet();
            RScore += 1;
            isBust = false;
            isRead = false;
            isSpace = false;
            BustAndRoundRead();
        }
        if (Input.GetKeyDown(KeyCode.Space) && isBust)
        {
            a_source.PlayOneShot(ac_shoot2, 1.0f);
            for (int i = 0; i < g_Dart.Length; i++)
                g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
            g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
            for (int i = 0; i < DartScore.Length; i++)
                DartScore[i] = 0;
            csgmg.DartScoreReSet();
            RScore += 1;
            isBust = false;
            isSpace = false;
            BustAndRoundRead();
        }
        if (Round == RoundStop && Couting == 4 && !isWin)
        {
            g_C_Ani.SetActive(false);
            GameEndRead();
        }
    }

    void BustAndRoundRead()
    {
        if (PlayerScore < PlayerBasicScore && !isRead && !isWin)
            Bust();

        if (PlayerScore >= PlayerBasicScore && !isRead && !isWin && !isBust)
            NextShotRead();

        if (PlayerScore == 0 && !isBust && !isRead && !isWin)
        {
            g_P_Score.GetComponent<csNumber>().SetNumber(PlayerScore);
            WinRead();
        }
        if (Round == RoundStop && Couting == 4 && !isWin)
        {
            g_C_Ani.SetActive(false);
            GameEndRead();
        }
    }

    void Bust()
    {
        isRead = true;
        G_Bust.SetActive(true);
        g_M_Score.SetActive(false);
        v_BustMove.Play();
        PlayerScore = BustScore;
        g_P_Score.GetComponent<csNumber>().SetNumber(PlayerScore);
        Invoke("Delay", 2f);
    }

    void Delay()
    {
        Couting = 4;
        g_P_Ani.SetActive(true);
        G_Bust.SetActive(false);
        v_BustMove.Stop();
        isBust = true;
    }

    void GameStart()
    {
        isRead = true;
        for (int i = 0; i < g_Dart.Length; i++)
            g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
        g_M_Score.GetComponent<csNumber>().CreateNumber(4, 250, 3f, 0);
        g_P_Score.GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
        g_M_Score.GetComponent<csNumber>().SetNumber(PlayerScore);
        g_P_Score.GetComponent<csNumber>().SetNumber(PlayerScore);
        g_R_Ani.SetActive(true);
        g_C_Ani.SetActive(false);
        g_P_Ani.SetActive(false);
        G_Bust.SetActive(false);
        g_M_Score.SetActive(false);
        Invoke("GameAniStop", 1f);
    }
    void GameAniStop()
    {
        isRead = false;
        g_M_Score.SetActive(true);
        g_M_Score.GetComponent<csNumber>().SetNumber(PlayerScore);
        g_RoundR.SetActive(false);
        g_RoundNum[Round].SetActive(false);
        g_RoundOn.SetActive(false);
        g_R_Ani.SetActive(false);
        Round = 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
    }

    public void ImageUp()
    {
        if (RScore == 5)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[1];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[2];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[3];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[4];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[5];

            t_RScoreText[0].text = ScoreSave[1].ToString();
            t_RScoreText[1].text = ScoreSave[2].ToString();
            t_RScoreText[2].text = ScoreSave[3].ToString();
            t_RScoreText[3].text = ScoreSave[4].ToString();
            t_RScoreText[4].text = ScoreSave[5].ToString();
        }

        if (RScore == 6)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[2];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[3];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[4];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[5];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[6];

            t_RScoreText[0].text = ScoreSave[2].ToString();
            t_RScoreText[1].text = ScoreSave[3].ToString();
            t_RScoreText[2].text = ScoreSave[4].ToString();
            t_RScoreText[3].text = ScoreSave[5].ToString();
            t_RScoreText[4].text = ScoreSave[6].ToString();
        }

        if (RScore == 7)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[3];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[4];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[5];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[6];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[7];

            t_RScoreText[0].text = ScoreSave[3].ToString();
            t_RScoreText[1].text = ScoreSave[4].ToString();
            t_RScoreText[2].text = ScoreSave[5].ToString();
            t_RScoreText[3].text = ScoreSave[6].ToString();
            t_RScoreText[4].text = ScoreSave[7].ToString();
        }

        if (RScore == 8)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[4];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[5];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[6];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[7];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[8];

            t_RScoreText[0].text = ScoreSave[4].ToString();
            t_RScoreText[1].text = ScoreSave[5].ToString();
            t_RScoreText[2].text = ScoreSave[6].ToString();
            t_RScoreText[3].text = ScoreSave[7].ToString();
            t_RScoreText[4].text = ScoreSave[8].ToString();
        }

        if (RScore == 9)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[5];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[6];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[7];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[8];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[9];

            t_RScoreText[0].text = ScoreSave[5].ToString();
            t_RScoreText[1].text = ScoreSave[6].ToString();
            t_RScoreText[2].text = ScoreSave[7].ToString();
            t_RScoreText[3].text = ScoreSave[8].ToString();
            t_RScoreText[4].text = ScoreSave[9].ToString();
        }

        if (RScore == 10)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[6];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[7];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[8];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[9];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[10];

            t_RScoreText[0].text = ScoreSave[6].ToString();
            t_RScoreText[1].text = ScoreSave[7].ToString();
            t_RScoreText[2].text = ScoreSave[8].ToString();
            t_RScoreText[3].text = ScoreSave[9].ToString();
            t_RScoreText[4].text = ScoreSave[10].ToString();
        }

        if (RScore == 11)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[7];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[8];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[9];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[10];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[11];

            t_RScoreText[0].text = ScoreSave[7].ToString();
            t_RScoreText[1].text = ScoreSave[8].ToString();
            t_RScoreText[2].text = ScoreSave[9].ToString();
            t_RScoreText[3].text = ScoreSave[10].ToString();
            t_RScoreText[4].text = ScoreSave[11].ToString();
        }

        if (RScore == 12)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[8];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[9];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[10];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[11];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[12];

            t_RScoreText[0].text = ScoreSave[8].ToString();
            t_RScoreText[1].text = ScoreSave[9].ToString();
            t_RScoreText[2].text = ScoreSave[10].ToString();
            t_RScoreText[3].text = ScoreSave[11].ToString();
            t_RScoreText[4].text = ScoreSave[12].ToString();
        }

        if (RScore == 13)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[9];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[10];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[11];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[12];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[13];

            t_RScoreText[0].text = ScoreSave[9].ToString();
            t_RScoreText[1].text = ScoreSave[10].ToString();
            t_RScoreText[2].text = ScoreSave[11].ToString();
            t_RScoreText[3].text = ScoreSave[12].ToString();
            t_RScoreText[4].text = ScoreSave[13].ToString();
        }

        if (RScore == 14)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[10];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[11];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[12];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[13];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[14];

            t_RScoreText[0].text = ScoreSave[10].ToString();
            t_RScoreText[1].text = ScoreSave[11].ToString();
            t_RScoreText[2].text = ScoreSave[12].ToString();
            t_RScoreText[3].text = ScoreSave[13].ToString();
            t_RScoreText[4].text = ScoreSave[14].ToString();
        }

        if (RScore == 15)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[11];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[12];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[13];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[14];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[15];

            t_RScoreText[0].text = ScoreSave[11].ToString();
            t_RScoreText[1].text = ScoreSave[12].ToString();
            t_RScoreText[2].text = ScoreSave[13].ToString();
            t_RScoreText[3].text = ScoreSave[14].ToString();
            t_RScoreText[4].text = ScoreSave[15].ToString();
        }

        if (RScore == 16)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[12];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[13];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[14];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[15];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[16];

            t_RScoreText[0].text = ScoreSave[12].ToString();
            t_RScoreText[1].text = ScoreSave[13].ToString();
            t_RScoreText[2].text = ScoreSave[14].ToString();
            t_RScoreText[3].text = ScoreSave[15].ToString();
            t_RScoreText[4].text = ScoreSave[16].ToString();
        }

        if (RScore == 17)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[13];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[14];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[15];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[16];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[17];

            t_RScoreText[0].text = ScoreSave[13].ToString();
            t_RScoreText[1].text = ScoreSave[14].ToString();
            t_RScoreText[2].text = ScoreSave[15].ToString();
            t_RScoreText[3].text = ScoreSave[16].ToString();
            t_RScoreText[4].text = ScoreSave[17].ToString();
        }

        if (RScore == 18)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[14];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[15];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[16];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[17];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[18];

            t_RScoreText[0].text = ScoreSave[14].ToString();
            t_RScoreText[1].text = ScoreSave[15].ToString();
            t_RScoreText[2].text = ScoreSave[16].ToString();
            t_RScoreText[3].text = ScoreSave[17].ToString();
            t_RScoreText[4].text = ScoreSave[18].ToString();
        }

        if (RScore == 19)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[15];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[16];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[17];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[18];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[19];

            t_RScoreText[0].text = ScoreSave[15].ToString();
            t_RScoreText[1].text = ScoreSave[16].ToString();
            t_RScoreText[2].text = ScoreSave[17].ToString();
            t_RScoreText[3].text = ScoreSave[18].ToString();
            t_RScoreText[4].text = ScoreSave[19].ToString();
        }

        if (RScore == 20)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[16];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[17];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[18];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[19];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[20];

            t_RScoreText[0].text = ScoreSave[16].ToString();
            t_RScoreText[1].text = ScoreSave[17].ToString();
            t_RScoreText[2].text = ScoreSave[18].ToString();
            t_RScoreText[3].text = ScoreSave[19].ToString();
            t_RScoreText[4].text = ScoreSave[20].ToString();
        }


    }

    public void RoundScore(int DartScore)
    {
        ScoreSave[RScore] += DartScore;
        if (Round <= RoundStop)
        {
            if (RScore == 0)
                t_RScoreText[0].text = ScoreSave[0].ToString();

            if (RScore == 1)
                t_RScoreText[1].text = ScoreSave[1].ToString();

            if (RScore == 2)
                t_RScoreText[2].text = ScoreSave[2].ToString();

            if (RScore == 3)
                t_RScoreText[3].text = ScoreSave[3].ToString();

            if (RScore == 4)
                t_RScoreText[4].text = ScoreSave[4].ToString();

            if (RScore == 5)
            {
                t_RScoreText[0].text = ScoreSave[1].ToString();
                t_RScoreText[1].text = ScoreSave[2].ToString();
                t_RScoreText[2].text = ScoreSave[3].ToString();
                t_RScoreText[3].text = ScoreSave[4].ToString();
                t_RScoreText[4].text = ScoreSave[5].ToString();
            }

            if (RScore == 6)
            {
                t_RScoreText[0].text = ScoreSave[2].ToString();
                t_RScoreText[1].text = ScoreSave[3].ToString();
                t_RScoreText[2].text = ScoreSave[4].ToString();
                t_RScoreText[3].text = ScoreSave[5].ToString();
                t_RScoreText[4].text = ScoreSave[6].ToString();
            }

            if (RScore == 7)
            {
                t_RScoreText[0].text = ScoreSave[3].ToString();
                t_RScoreText[1].text = ScoreSave[4].ToString();
                t_RScoreText[2].text = ScoreSave[5].ToString();
                t_RScoreText[3].text = ScoreSave[6].ToString();
                t_RScoreText[4].text = ScoreSave[7].ToString();
            }

            if (RScore == 8)
            {
                t_RScoreText[0].text = ScoreSave[4].ToString();
                t_RScoreText[1].text = ScoreSave[5].ToString();
                t_RScoreText[2].text = ScoreSave[6].ToString();
                t_RScoreText[3].text = ScoreSave[7].ToString();
                t_RScoreText[4].text = ScoreSave[8].ToString();
            }

            if (RScore == 9)
            {
                t_RScoreText[0].text = ScoreSave[5].ToString();
                t_RScoreText[1].text = ScoreSave[6].ToString();
                t_RScoreText[2].text = ScoreSave[7].ToString();
                t_RScoreText[3].text = ScoreSave[8].ToString();
                t_RScoreText[4].text = ScoreSave[9].ToString();
            }

            if (RScore == 10)
            {
                t_RScoreText[0].text = ScoreSave[6].ToString();
                t_RScoreText[1].text = ScoreSave[7].ToString();
                t_RScoreText[2].text = ScoreSave[8].ToString();
                t_RScoreText[3].text = ScoreSave[9].ToString();
                t_RScoreText[4].text = ScoreSave[10].ToString();
            }

            if (RScore == 11)
            {
                t_RScoreText[0].text = ScoreSave[7].ToString();
                t_RScoreText[1].text = ScoreSave[8].ToString();
                t_RScoreText[2].text = ScoreSave[9].ToString();
                t_RScoreText[3].text = ScoreSave[10].ToString();
                t_RScoreText[4].text = ScoreSave[11].ToString();
            }

            if (RScore == 12)
            {
                t_RScoreText[0].text = ScoreSave[8].ToString();
                t_RScoreText[1].text = ScoreSave[9].ToString();
                t_RScoreText[2].text = ScoreSave[10].ToString();
                t_RScoreText[3].text = ScoreSave[11].ToString();
                t_RScoreText[4].text = ScoreSave[12].ToString();
            }

            if (RScore == 13)
            {
                t_RScoreText[0].text = ScoreSave[9].ToString();
                t_RScoreText[1].text = ScoreSave[10].ToString();
                t_RScoreText[2].text = ScoreSave[11].ToString();
                t_RScoreText[3].text = ScoreSave[12].ToString();
                t_RScoreText[4].text = ScoreSave[13].ToString();
            }

            if (RScore == 14)
            {
                t_RScoreText[0].text = ScoreSave[10].ToString();
                t_RScoreText[1].text = ScoreSave[11].ToString();
                t_RScoreText[2].text = ScoreSave[12].ToString();
                t_RScoreText[3].text = ScoreSave[13].ToString();
                t_RScoreText[4].text = ScoreSave[14].ToString();
            }

            if (RScore == 15)
            {
                t_RScoreText[0].text = ScoreSave[11].ToString();
                t_RScoreText[1].text = ScoreSave[12].ToString();
                t_RScoreText[2].text = ScoreSave[13].ToString();
                t_RScoreText[3].text = ScoreSave[14].ToString();
                t_RScoreText[4].text = ScoreSave[15].ToString();
            }

            if (RScore == 16)
            {
                t_RScoreText[0].text = ScoreSave[12].ToString();
                t_RScoreText[1].text = ScoreSave[13].ToString();
                t_RScoreText[2].text = ScoreSave[14].ToString();
                t_RScoreText[3].text = ScoreSave[15].ToString();
                t_RScoreText[4].text = ScoreSave[16].ToString();
            }

            if (RScore == 17)
            {
                t_RScoreText[0].text = ScoreSave[13].ToString();
                t_RScoreText[1].text = ScoreSave[14].ToString();
                t_RScoreText[2].text = ScoreSave[15].ToString();
                t_RScoreText[3].text = ScoreSave[16].ToString();
                t_RScoreText[4].text = ScoreSave[17].ToString();
            }

            if (RScore == 18)
            {
                t_RScoreText[0].text = ScoreSave[14].ToString();
                t_RScoreText[1].text = ScoreSave[15].ToString();
                t_RScoreText[2].text = ScoreSave[16].ToString();
                t_RScoreText[3].text = ScoreSave[17].ToString();
                t_RScoreText[4].text = ScoreSave[18].ToString();
            }

            if (RScore == 19)
            {
                t_RScoreText[0].text = ScoreSave[15].ToString();
                t_RScoreText[1].text = ScoreSave[16].ToString();
                t_RScoreText[2].text = ScoreSave[17].ToString();
                t_RScoreText[3].text = ScoreSave[18].ToString();
                t_RScoreText[4].text = ScoreSave[19].ToString();
            }

            if (RScore == 20)
            {
                t_RScoreText[0].text = ScoreSave[16].ToString();
                t_RScoreText[1].text = ScoreSave[17].ToString();
                t_RScoreText[2].text = ScoreSave[18].ToString();
                t_RScoreText[3].text = ScoreSave[19].ToString();
                t_RScoreText[4].text = ScoreSave[20].ToString();
            }
        }
    }

    public void NextShotRead()
    {
        if (Couting != 4)
        {
            PlayerScore -= DartScore[Couting];
            g_M_Score.GetComponent<csNumber>().SetNumber(PlayerScore);
            g_P_Score.GetComponent<csNumber>().SetNumber(PlayerScore);
            Couting++;
        }
        if (Couting == 4 && !isBust && !isRead)
            RoundRead();
    }

    public void RoundRead()
    {
        isRead = true;
        g_P_Ani.SetActive(false);
        g_P_Score.GetComponent<csNumber>().SetNumber(PlayerScore);
        g_C_Ani.SetActive(true);
        g_M_Score.SetActive(false);
        Invoke("RoundStart", 3f);
    }
    public void RoundStart()
    {
        g_C_Ani.SetActive(false);
        g_RoundNum[Round].SetActive(true);
        g_RoundR.SetActive(true);
        g_RoundOn.SetActive(true);
        g_R_Ani.SetActive(true);
        Invoke("RoundAniEnd", 1f);
    }
    public void RoundAniEnd()
    {
        Couting = 0;
        g_RoundNum[Round].SetActive(false);
        g_RoundR.SetActive(false);
        g_RoundOn.SetActive(false);
        g_R_Ani.SetActive(false);
        g_M_Score.GetComponent<csNumber>().SetNumber(PlayerScore);
        g_M_Score.SetActive(true);
        Round += 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void GameEndRead()
    {
        isWin = true;
        g_P_Ani.SetActive(false);
        g_M_Score.SetActive(false);
        csgmg.GameEndRead(0);
    }

    void WinRead()
    {
        isWin = true;
        g_P_Ani.SetActive(false);
        g_M_Score.SetActive(false);
        csgmg.GameEndRead(0);
    }

    void PPDScore(int n)
    {
        DartTotal += n;
        Average = DartTotal / DartCount;
        t_PPDText.text = string.Format("{0:N2}", Average);
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
