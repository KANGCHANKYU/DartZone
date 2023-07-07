using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class KB_ThreePlay : MonoBehaviour
{
    public Text t_Round;
    public Text t_PPDScoreP1;
    public Text t_PPDScoreP2;
    public Text t_PPDScoreP3;
    public Text[] t_RScoreP1 = new Text[5];
    public Text[] t_RScoreP2 = new Text[5];
    public Text[] t_RScoreP3 = new Text[5];
    public Image[] i_RScoreP1 = new Image[5];
    public Image[] i_RScoreP2 = new Image[5];
    public Image[] i_RScoreP3 = new Image[5];

    public GameObject[] g_Dart = new GameObject[3];
    public GameObject[] g_RoundNum = new GameObject[8];
    public GameObject g_PAni;
    public GameObject g_RAni;
    public GameObject g_DAni;
    public GameObject g_CAni;
    public GameObject g_RoundOn;
    public GameObject g_RoundR;
    public GameObject[] g_PScore = new GameObject[3];
    public GameObject[] g_MScore = new GameObject[3];
    public GameObject[] g_OffScore = new GameObject[3];
    public GameObject[] g_RScore = new GameObject[3];
    public GameObject g_P1;
    public GameObject g_P2;
    public GameObject g_P3;

    public Sprite s_OnDart;
    public Sprite s_OffDart;
    public Sprite[] s_RScore = new Sprite[8];

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int Players = 0;
    public int Counting = 0;
    public int Round = 0;
    public int RoundStop = 8;
    public int P1_DartTotal = 0;
    public int P2_DartTotal = 0;
    public int P3_DartTotal = 0;
    public int RScore = 0;
    public int[] PlayerScore = new int[3];
    public int P1_Average = 0;
    public int P2_Average = 0;
    public int P3_Average = 0;
    public int P1_AverageCounting = 0;
    public int P2_AverageCounting = 0;
    public int P3_AverageCounting = 0;
    public int[] DartScore = new int[3];
    public int[] DartBasicScore = new int[3];
    public int[] P1_ScoreSave = new int[8];
    public int[] P2_ScoreSave = new int[8];
    public int[] P3_ScoreSave = new int[8];

    public string[] player = new string[3];

    public bool isEnd;
    public bool isSpace = false;
    public bool isRead = false;

    public KB_GameManager gmg;
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
            if (csSingleton.getInstance.g_nTargetBasicScore == 25 || csSingleton.getInstance.g_nTargetBasicScore == 50)
            {
                if (Round < RoundStop)
                {
                    if (Players == 0 && !isRead && !isSpace && !isEnd)
                    {
                        if (Counting == 0 && !isRead && !isSpace)
                        {
                            P1_AverageCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            PPDScore(DartScore[0]);
                            PlayerScore[0] += DartScore[0];
                            RoundScore(DartScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_PScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            Counting = 1;
                        }
                        else if (Counting == 1 && !isRead && !isSpace)
                        {
                            P1_AverageCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            PPDScore(DartScore[1]);
                            PlayerScore[0] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_PScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            Counting = 2;
                        }
                        else if (Counting == 2 && !isRead && !isSpace)
                        {
                            P1_AverageCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            PPDScore(DartScore[2]);
                            PlayerScore[0] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            g_PScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
                            Counting = 3;
                        }
                    }
                    else if (Players == 1 && !isRead && !isSpace && !isEnd)
                    {
                        if (Counting == 0 && !isRead && !isSpace)
                        {
                            P2_AverageCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            PPDScore(DartScore[0]);
                            PlayerScore[1] += DartScore[0];
                            RoundScore(DartScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_PScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            Counting = 1;
                        }
                        else if (Counting == 1 && !isRead && !isSpace)
                        {
                            P2_AverageCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            PPDScore(DartScore[1]);
                            PlayerScore[1] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_PScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            Counting = 2;
                        }
                        else if (Counting == 2 && !isRead && !isSpace)
                        {
                            P2_AverageCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            PPDScore(DartScore[2]);
                            PlayerScore[1] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            g_PScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
                            Counting = 3;
                        }
                    }
                    else if (Players == 2 && !isRead && !isSpace && !isEnd)
                    {
                        if (Counting == 0 && !isRead && !isSpace)
                        {
                            P3_AverageCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                            DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                            DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                            PPDScore(DartScore[0]);
                            PlayerScore[2] += DartScore[0];
                            RoundScore(DartScore[0]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                            g_MScore[2].GetComponent<csNumber>().SetNumber(PlayerScore[2]);
                            g_PScore[2].GetComponent<csNumber>().SetNumber(PlayerScore[2]);
                            Counting = 1;
                        }
                        else if (Counting == 1 && !isRead && !isSpace)
                        {
                            P3_AverageCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                            DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                            DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                            PPDScore(DartScore[1]);
                            PlayerScore[2] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[2].GetComponent<csNumber>().SetNumber(PlayerScore[2]);
                            g_PScore[2].GetComponent<csNumber>().SetNumber(PlayerScore[2]);
                            Counting = 2;
                        }
                        else if (Counting == 2 && !isRead && !isSpace)
                        {
                            P3_AverageCounting++;
                            a_source.PlayOneShot(ac_shoot1, 1.0f);
                            DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                            DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                            m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                            m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                            PPDScore(DartScore[2]);
                            PlayerScore[2] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[2].GetComponent<csNumber>().SetNumber(PlayerScore[2]);
                            g_PScore[2].GetComponent<csNumber>().SetNumber(PlayerScore[2]);
                            Counting = 3;
                        }
                    }
                    if (Players == 2 && Counting == 3 && Round == RoundStop)
                    {
                        GameEndRead();
                    }

                }
            }
            else
            {
                if (Counting != 3 && !isSpace && !isRead && !isEnd)
                {
                    if (Players == 0)
                        P1_AverageCounting++;
                    else if (Players == 1)
                        P2_AverageCounting++;
                    else if (Players == 2)
                        P3_AverageCounting++;
                    a_source.PlayOneShot(ac_shoot1, 1.0f);
                    PPDScore(0);
                    RoundScore(0);
                    g_MScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                    g_PScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                    if (Counting == 0)
                    {
                        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                        Counting = 1;
                    }
                    else if (Counting == 1)
                    {
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                        Counting = 2;
                    }
                    else if (Counting == 2)
                    {
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        g_MScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                        g_PScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
                        Counting = 3;
                    }
                }
            }
            if (Counting == 3 && !isRead && !isSpace && !isEnd)
            {
                    GetMovie();
                    g_MScore[Players].SetActive(false);
                    g_PAni.SetActive(true);
                    isSpace = true;
                    Counting = 4;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && gmg.isAni == false && isSpace && Counting == 4)
        {
            if (Players == 0)
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
                Invoke("PlayerNumberPlus", 4.5f);
            }
            if (Players == 1)
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
                Invoke("PlayerNumberPlus", 4.5f);
            }
            else if (Players == 2)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                g_PAni.SetActive(false);
                gmg.DartScoreReSet();
                RoundRead();
                isSpace = false;
                isRead = true;
                Invoke("PlayerNumberMinus", 5f);
            }
        }
        if (isEnd)
        {
            GameEndRead();
        }
    }

    void FistStart()
    {
        isRead = true;
        for (int i = 0; i < g_Dart.Length; i++)
            g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
        for (int i = 0; i < g_MScore.Length; i++)
        {
            g_MScore[i].GetComponent<csNumber>().CreateNumber(4, 250, 3f, 0);
            g_PScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_OffScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_OffScore[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
            g_MScore[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
            g_PScore[i].GetComponent<csNumber>().SetNumber(PlayerScore[i]);
            g_MScore[i].SetActive(false);
            g_PScore[i].SetActive(false);
            g_OffScore[i].SetActive(false);
        }
        g_RAni.SetActive(true);
        g_RoundOn.SetActive(true);
        g_RoundNum[Round].SetActive(true);
        g_RoundR.SetActive(true);
        g_CAni.SetActive(false);
        g_PAni.SetActive(false);
        Invoke("FistAniStop", 1.5f);
    }
    void FistAniStop()
    {
        g_RAni.SetActive(false);
        g_RoundOn.SetActive(false);
        g_RoundNum[Round].SetActive(false);
        g_RoundR.SetActive(false);
        g_MScore[0].SetActive(true);
        g_MScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
        Round = 1;
        t_Round.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void PlayerNumberPlus()
    {
        isRead = false;
        Counting = 0;
        g_CAni.SetActive(false);
        g_MScore[Players].SetActive(false);
        g_PScore[Players].SetActive(false);
        g_OffScore[Players].SetActive(true);
        g_OffScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        Players += 1;
        g_MScore[Players].SetActive(true);
        g_PScore[Players].SetActive(true);
        g_OffScore[Players].SetActive(false);
        g_PScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        g_MScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);

    }
    void PlayerNumberMinus()
    {
        Counting = 0;
        g_CAni.SetActive(false);
        g_MScore[Players].SetActive(false);
        g_PScore[Players].SetActive(false);
        g_OffScore[Players].SetActive(true);
        g_OffScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        Players = 0;
        g_MScore[Players].SetActive(true);
        g_PScore[Players].SetActive(true);
        g_OffScore[Players].SetActive(false);
        g_PScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        g_MScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
    }

    public void RoundScore(int n)
    {
        if (Players == 0)
        {
            P1_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreP1[0].text = P1_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreP1[1].text = P1_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreP1[2].text = P1_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreP1[3].text = P1_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreP1[4].text = P1_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreP1[0].text = P1_ScoreSave[1].ToString();
                    t_RScoreP1[1].text = P1_ScoreSave[2].ToString();
                    t_RScoreP1[2].text = P1_ScoreSave[3].ToString();
                    t_RScoreP1[3].text = P1_ScoreSave[4].ToString();
                    t_RScoreP1[4].text = P1_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreP1[0].text = P1_ScoreSave[2].ToString();
                    t_RScoreP1[1].text = P1_ScoreSave[3].ToString();
                    t_RScoreP1[2].text = P1_ScoreSave[4].ToString();
                    t_RScoreP1[3].text = P1_ScoreSave[5].ToString();
                    t_RScoreP1[4].text = P1_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreP1[0].text = P1_ScoreSave[3].ToString();
                    t_RScoreP1[1].text = P1_ScoreSave[4].ToString();
                    t_RScoreP1[2].text = P1_ScoreSave[5].ToString();
                    t_RScoreP1[3].text = P1_ScoreSave[6].ToString();
                    t_RScoreP1[4].text = P1_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreP1[0].text = P1_ScoreSave[4].ToString();
                    t_RScoreP1[1].text = P1_ScoreSave[5].ToString();
                    t_RScoreP1[2].text = P1_ScoreSave[6].ToString();
                    t_RScoreP1[3].text = P1_ScoreSave[7].ToString();
                    t_RScoreP1[4].text = P1_ScoreSave[8].ToString();
                }
            }
        }
        else if (Players == 1)
        {
            P2_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreP2[0].text = P2_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreP2[1].text = P2_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreP2[2].text = P2_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreP2[3].text = P2_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreP2[4].text = P2_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreP2[0].text = P2_ScoreSave[1].ToString();
                    t_RScoreP2[1].text = P2_ScoreSave[2].ToString();
                    t_RScoreP2[2].text = P2_ScoreSave[3].ToString();
                    t_RScoreP2[3].text = P2_ScoreSave[4].ToString();
                    t_RScoreP2[4].text = P2_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreP2[0].text = P2_ScoreSave[2].ToString();
                    t_RScoreP2[1].text = P2_ScoreSave[3].ToString();
                    t_RScoreP2[2].text = P2_ScoreSave[4].ToString();
                    t_RScoreP2[3].text = P2_ScoreSave[5].ToString();
                    t_RScoreP2[4].text = P2_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreP2[0].text = P2_ScoreSave[3].ToString();
                    t_RScoreP2[1].text = P2_ScoreSave[4].ToString();
                    t_RScoreP2[2].text = P2_ScoreSave[5].ToString();
                    t_RScoreP2[3].text = P2_ScoreSave[6].ToString();
                    t_RScoreP2[4].text = P2_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreP2[0].text = P2_ScoreSave[4].ToString();
                    t_RScoreP2[1].text = P2_ScoreSave[5].ToString();
                    t_RScoreP2[2].text = P2_ScoreSave[6].ToString();
                    t_RScoreP2[3].text = P2_ScoreSave[7].ToString();
                    t_RScoreP2[4].text = P2_ScoreSave[8].ToString();
                }
            }
        }
        else if (Players == 2)
        {
            P3_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreP3[0].text = P3_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreP3[1].text = P3_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreP3[2].text = P3_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreP3[3].text = P3_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreP3[4].text = P3_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreP3[0].text = P3_ScoreSave[1].ToString();
                    t_RScoreP3[1].text = P3_ScoreSave[2].ToString();
                    t_RScoreP3[2].text = P3_ScoreSave[3].ToString();
                    t_RScoreP3[3].text = P3_ScoreSave[4].ToString();
                    t_RScoreP3[4].text = P3_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreP3[0].text = P3_ScoreSave[2].ToString();
                    t_RScoreP3[1].text = P3_ScoreSave[3].ToString();
                    t_RScoreP3[2].text = P3_ScoreSave[4].ToString();
                    t_RScoreP3[3].text = P3_ScoreSave[5].ToString();
                    t_RScoreP3[4].text = P3_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreP3[0].text = P3_ScoreSave[3].ToString();
                    t_RScoreP3[1].text = P3_ScoreSave[4].ToString();
                    t_RScoreP3[2].text = P3_ScoreSave[5].ToString();
                    t_RScoreP3[3].text = P3_ScoreSave[6].ToString();
                    t_RScoreP3[4].text = P3_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreP3[0].text = P3_ScoreSave[4].ToString();
                    t_RScoreP3[1].text = P3_ScoreSave[5].ToString();
                    t_RScoreP3[2].text = P3_ScoreSave[6].ToString();
                    t_RScoreP3[3].text = P3_ScoreSave[7].ToString();
                    t_RScoreP3[4].text = P3_ScoreSave[8].ToString();
                }
            }
        }

    }
    public void RScoreImageUp()
    {
        if (Players == 0)
        {
            if (RScore == 5)
            {
                i_RScoreP1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreP1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreP1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreP1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP1[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreP1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreP1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreP1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreP1[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreP1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreP1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreP1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreP1[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreP1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreP1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreP1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreP1[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Players == 1)
        {
            if (RScore == 5)
            {
                i_RScoreP2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreP2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreP2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreP2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP2[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreP2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreP2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreP2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreP2[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreP2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreP2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreP2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreP2[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreP2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreP2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreP2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreP2[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Players == 2)
        {
            if (RScore == 5)
            {
                i_RScoreP3[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreP3[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreP3[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreP3[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP3[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreP3[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreP3[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreP3[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP3[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreP3[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreP3[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreP3[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP3[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreP3[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreP3[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreP3[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreP3[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreP3[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreP3[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreP3[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
    }

    void MyTure()
    {
        if (Players == 0)
        {
            g_P1.GetComponent<Transform>().position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, -10f);
            g_P2.GetComponent<Transform>().position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, 0f);
            g_P3.GetComponent<Transform>().position = new Vector3(g_P3.transform.position.x, g_P3.transform.position.y, 0f);

            g_P1.transform.localScale = new Vector3(1f, 1f);
            g_P2.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P3.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);
            g_PScore[2].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);
            g_OffScore[2].GetComponent<csNumber>().SetNumber(PlayerScore[2]);

            g_RScore[0].SetActive(true);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);

            t_PPDScoreP1.enabled = true;
            t_PPDScoreP2.enabled = false;
            t_PPDScoreP3.enabled = false;

            for (int i = 0; i < i_RScoreP1.Length; i++)
            {
                i_RScoreP1[i].enabled = true;
                i_RScoreP2[i].enabled = false;
                i_RScoreP3[i].enabled = false;
            }

        }
        else if (Players == 1)
        {
            g_P1.GetComponent<Transform>().position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, 0f);
            g_P2.GetComponent<Transform>().position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, -10f);
            g_P3.GetComponent<Transform>().position = new Vector3(g_P3.transform.position.x, g_P3.transform.position.y, 0f);

            g_P1.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P2.transform.localScale = new Vector3(1f, 1f);
            g_P3.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(true);
            g_PScore[2].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[2].SetActive(true);

            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
            g_OffScore[2].GetComponent<csNumber>().SetNumber(PlayerScore[2]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(true);
            g_RScore[2].SetActive(false);

            t_PPDScoreP1.enabled = false;
            t_PPDScoreP2.enabled = true;
            t_PPDScoreP3.enabled = false;

            for (int i = 0; i < i_RScoreP1.Length; i++)
            {
                i_RScoreP1[i].enabled = false;
                i_RScoreP2[i].enabled = true;
                i_RScoreP3[i].enabled = false;
            }

        }
        else if (Players == 2)
        {
            g_P1.GetComponent<Transform>().position = new Vector3(g_P1.transform.position.x, g_P1.transform.position.y, 0f);
            g_P2.GetComponent<Transform>().position = new Vector3(g_P2.transform.position.x, g_P2.transform.position.y, 0f);
            g_P3.GetComponent<Transform>().position = new Vector3(g_P3.transform.position.x, g_P3.transform.position.y, -10f);

            g_P1.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P2.transform.localScale = new Vector3(0.75f, 0.75f);
            g_P3.transform.localScale = new Vector3(1f, 1f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(false);
            g_PScore[2].SetActive(true);

            g_OffScore[2].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);

            g_OffScore[0].GetComponent<csNumber>().SetNumber(PlayerScore[0]);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(PlayerScore[1]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(true);

            t_PPDScoreP1.enabled = false;
            t_PPDScoreP2.enabled = false;
            t_PPDScoreP3.enabled = true;

            for (int i = 0; i < i_RScoreP1.Length; i++)
            {
                i_RScoreP1[i].enabled = false;
                i_RScoreP2[i].enabled = false;
                i_RScoreP3[i].enabled = true;
            }

        }
    }

    void GameEndRead()
    {
        if (PlayerScore[0] > PlayerScore[1] && PlayerScore[0] > PlayerScore[2])
        {
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            gmg.GameEnd(0);
        }
        else if (PlayerScore[1] > PlayerScore[0] && PlayerScore[1] > PlayerScore[2])
        {
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            gmg.GameEnd(1);
        }
        else if (PlayerScore[2] > PlayerScore[0] && PlayerScore[2] > PlayerScore[1])
        {
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            gmg.GameEnd(2);
        }

        if (PlayerScore[0] == PlayerScore[1] && PlayerScore[0] == PlayerScore[2] && PlayerScore[1] == PlayerScore[2])
        {
            if (P2_Average < P1_Average && P3_Average < P1_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(0);
            }
            if (P1_Average < P2_Average && P3_Average < P2_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(1);
            }
            if (P1_Average < P3_Average && P2_Average < P3_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(2);
            }
            if (P1_Average == P2_Average && P1_Average != P3_Average && P2_Average != P3_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(0);
            }
            if (P1_Average == P3_Average && P1_Average != P3_Average && P2_Average != P3_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(0);
            }
            if (P1_Average == P2_Average && P1_Average == P3_Average && P2_Average != P3_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(0);
            }
            if (P2_Average == P3_Average && P2_Average == P3_Average && P1_Average != P3_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(1);
            }
        }
        if (PlayerScore[0] == PlayerScore[1] && PlayerScore[0] != PlayerScore[2])
        {
            if (P2_Average < P1_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(0);
            }
            if (P1_Average < P2_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(1);
            }
            if (P1_Average == P2_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(0);
            }
        }
        if (PlayerScore[0] == PlayerScore[2] && PlayerScore[0] != PlayerScore[1])
        {
            if (P3_Average < P1_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(0);
            }
            if (P1_Average < P3_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(2);
            }
            if (P1_Average == P3_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(0);
            }
        }
        if (PlayerScore[1] == PlayerScore[2] && PlayerScore[0] != PlayerScore[1] && PlayerScore[0] != PlayerScore[2])
        {
            if (P3_Average < P2_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(1);
            }
            if (P2_Average < P3_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(2);
            }
            if (P2_Average == P3_Average)
            {
                for (int i = 0; i < g_MScore.Length; i++)
                    g_MScore[i].SetActive(false);
                gmg.GameEnd(1);
            }
        }
    }

    public void RoundRead()
    {
        g_CAni.SetActive(true);
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
        g_MScore[Players].SetActive(true);
        g_MScore[Players].GetComponent<csNumber>().SetNumber(PlayerScore[Players]);
        Round += 1;
        RScore += 1;
        t_Round.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void PPDScore(int n)
    {
        if (Players == 0)
        {
            P1_DartTotal += n;
            P1_Average = P1_DartTotal / P1_AverageCounting;
            t_PPDScoreP1.text = string.Format("{0:N2}", P1_Average);
        }
        else if (Players == 1)
        {
            P2_DartTotal += n;
            P2_Average = P2_DartTotal / P2_AverageCounting;
            t_PPDScoreP2.text = string.Format("{0:N2}", P2_Average);
        }
        else if (Players == 2)
        {
            P3_DartTotal += n;
            P3_Average = P3_DartTotal / P3_AverageCounting;
            t_PPDScoreP3.text = string.Format("{0:N2}", P3_Average);
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
