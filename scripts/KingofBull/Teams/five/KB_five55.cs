using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class KB_five55 : MonoBehaviour
{
    public Text t_Round;
    public Text t_PPDScoreA1;
    public Text t_PPDScoreA2;
    public Text t_PPDScoreA3;
    public Text t_PPDScoreA4;
    public Text t_PPDScoreA5;
    public Text t_PPDScoreB1;
    public Text t_PPDScoreB2;
    public Text t_PPDScoreB3;
    public Text t_PPDScoreB4;
    public Text t_PPDScoreB5;
    public Text[] t_RScoreA1 = new Text[5];
    public Text[] t_RScoreA2 = new Text[5];
    public Text[] t_RScoreA3 = new Text[5];
    public Text[] t_RScoreA4 = new Text[5];
    public Text[] t_RScoreA5 = new Text[5];
    public Text[] t_RScoreB1 = new Text[5];
    public Text[] t_RScoreB2 = new Text[5];
    public Text[] t_RScoreB3 = new Text[5];
    public Text[] t_RScoreB4 = new Text[5];
    public Text[] t_RScoreB5 = new Text[5];
    public Image[] i_RScoreA1 = new Image[5];
    public Image[] i_RScoreA2 = new Image[5];
    public Image[] i_RScoreA3 = new Image[5];
    public Image[] i_RScoreA4 = new Image[5];
    public Image[] i_RScoreA5 = new Image[5];
    public Image[] i_RScoreB1 = new Image[5];
    public Image[] i_RScoreB2 = new Image[5];
    public Image[] i_RScoreB3 = new Image[5];
    public Image[] i_RScoreB4 = new Image[5];
    public Image[] i_RScoreB5 = new Image[5];
    public Image[] i_TeamName = new Image[2];
    public Image[] i_Teambar = new Image[2];

    public GameObject[] g_Dart = new GameObject[3];
    public GameObject[] g_RoundNum = new GameObject[8];
    public GameObject g_PAni;
    public GameObject g_RAni;
    public GameObject g_DAni;
    public GameObject g_CAni;
    public GameObject g_RoundOn;
    public GameObject g_RoundR;
    public GameObject[] g_TScore = new GameObject[2];
    public GameObject[] g_MScore = new GameObject[2];
    public GameObject[] g_OffScore = new GameObject[2];
    public GameObject[] g_RScore = new GameObject[10];
    public GameObject g_AT;
    public GameObject g_BT;

    public Sprite s_OnDart;
    public Sprite s_OffDart;
    public Sprite[] s_RScore = new Sprite[8];
    public Sprite[] s_OnPlayer = new Sprite[5];
    public Sprite[] s_OffPlayer = new Sprite[5];
    public Sprite[] s_OnTeambar = new Sprite[2];
    public Sprite[] s_OffTeambar = new Sprite[2];

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int Teams = 0;
    public int Players = 0;
    public int Counting = 0;
    public int Round = 0;
    public int RoundStop = 8;
    public int A1_DartTotal = 0;
    public int A2_DartTotal = 0;
    public int A3_DartTotal = 0;
    public int A4_DartTotal = 0;
    public int A5_DartTotal = 0;
    public int B1_DartTotal = 0;
    public int B2_DartTotal = 0;
    public int B3_DartTotal = 0;
    public int B4_DartTotal = 0;
    public int B5_DartTotal = 0;
    public int RScore = 0;
    public int[] TeamScore = new int[2];
    public int A1_Average = 0;
    public int A2_Average = 0;
    public int A3_Average = 0;
    public int A4_Average = 0;
    public int A5_Average = 0;
    public int B1_Average = 0;
    public int B2_Average = 0;
    public int B3_Average = 0;
    public int B4_Average = 0;
    public int B5_Average = 0;
    public int A1_AverageCounting = 0;
    public int A2_AverageCounting = 0;
    public int A3_AverageCounting = 0;
    public int A4_AverageCounting = 0;
    public int A5_AverageCounting = 0;
    public int B1_AverageCounting = 0;
    public int B2_AverageCounting = 0;
    public int B3_AverageCounting = 0;
    public int B4_AverageCounting = 0;
    public int B5_AverageCounting = 0;
    public int AT_Average = 0;
    public int BT_Average = 0;
    public int[] DartScore = new int[3];
    public int[] DartBasicScore = new int[3];
    public int[] A1_ScoreSave = new int[8];
    public int[] A2_ScoreSave = new int[8];
    public int[] A3_ScoreSave = new int[8];
    public int[] A4_ScoreSave = new int[8];
    public int[] A5_ScoreSave = new int[8];
    public int[] B1_ScoreSave = new int[8];
    public int[] B2_ScoreSave = new int[8];
    public int[] B3_ScoreSave = new int[8];
    public int[] B4_ScoreSave = new int[8];
    public int[] B5_ScoreSave = new int[8];

    public string[] player = new string[10];

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
                if (Round <= RoundStop && !isEnd)
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
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
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
                            PPDScore(DartScore[1]);
                            TeamScore[0] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
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
                            PPDScore(DartScore[2]);
                            TeamScore[0] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            Counting = 3;
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
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
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
                            PPDScore(DartScore[1]);
                            TeamScore[0] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
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
                            PPDScore(DartScore[2]);
                            TeamScore[0] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            Counting = 3;
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
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
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
                            PPDScore(DartScore[1]);
                            TeamScore[0] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
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
                            PPDScore(DartScore[2]);
                            TeamScore[0] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            Counting = 3;
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
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
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
                            PPDScore(DartScore[1]);
                            TeamScore[0] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
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
                            PPDScore(DartScore[2]);
                            TeamScore[0] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            Counting = 3;
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
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
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
                            PPDScore(DartScore[1]);
                            TeamScore[0] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
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
                            PPDScore(DartScore[2]);
                            TeamScore[0] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
                            Counting = 3;
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
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
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
                            PPDScore(DartScore[1]);
                            TeamScore[1] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
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
                            PPDScore(DartScore[2]);
                            TeamScore[1] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            Counting = 3;
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
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
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
                            PPDScore(DartScore[1]);
                            TeamScore[1] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
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
                            PPDScore(DartScore[2]);
                            TeamScore[1] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            Counting = 3;
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
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
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
                            PPDScore(DartScore[1]);
                            TeamScore[1] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
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
                            PPDScore(DartScore[2]);
                            TeamScore[1] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            Counting = 3;
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
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
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
                            PPDScore(DartScore[1]);
                            TeamScore[1] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
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
                            PPDScore(DartScore[2]);
                            TeamScore[1] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            Counting = 3;
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
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
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
                            PPDScore(DartScore[1]);
                            TeamScore[1] += DartScore[1];
                            RoundScore(DartScore[1]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
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
                            PPDScore(DartScore[2]);
                            TeamScore[1] += DartScore[2];
                            RoundScore(DartScore[2]);
                            gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                            g_MScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            g_TScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
                            Counting = 3;
                        }
                    }
                    if (Teams == 1 && Counting == 3 && Round == RoundStop)
                    {
                        GameEndRead();
                    }
                }
            }
            else
            {
                if (Counting != 3 && !isSpace && !isRead && !isEnd)
                {
                    if (Teams == 0 && Players == 0)
                        A1_AverageCounting++;
                    else if (Teams == 0 && Players == 1)
                        A2_AverageCounting++;
                    else if (Teams == 0 && Players == 2)
                        A3_AverageCounting++;
                    else if (Teams == 0 && Players == 3)
                        A4_AverageCounting++;
                    else if (Teams == 0 && Players == 4)
                        A5_AverageCounting++;
                    else if (Teams == 1 && Players == 0)
                        B1_AverageCounting++;
                    else if (Teams == 1 && Players == 1)
                        B2_AverageCounting++;
                    else if (Teams == 1 && Players == 2)
                        B3_AverageCounting++;
                    else if (Teams == 1 && Players == 3)
                        B4_AverageCounting++;
                    else if (Teams == 1 && Players == 4)
                        B5_AverageCounting++;

                    a_source.PlayOneShot(ac_shoot1, 1.0f);
                    PPDScore(0);
                    RoundScore(0);
                    g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                    g_TScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                    if (Counting == 0)
                    {
                        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                        g_TScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                        Counting = 1;
                    }
                    else if (Counting == 1)
                    {
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                        g_TScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                        Counting = 2;
                    }
                    else if (Counting == 2)
                    {
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                        g_TScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
                        Counting = 3;
                    }
                }
            }
            if (Counting == 3 && !isRead && !isSpace && !isEnd)
            {
                GetMovie();
                g_MScore[Teams].SetActive(false);
                g_PAni.SetActive(true);
                isSpace = true;
                Counting = 4;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && gmg.isAni == false && isSpace && Counting == 4)
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
                RoundRead();
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
                RoundRead();
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
                RoundRead();
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
                RoundRead();
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
                gmg.DartScoreReSet();
                isSpace = false;
                isRead = true;
                RoundRead();
                RScore += 1;
                Invoke("TeamNumberMinus", 4.5f);
                Invoke("PlayerNumberMinus", 4.5f);
            }
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
            g_TScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_OffScore[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_OffScore[i].GetComponent<csNumber>().SetNumber(TeamScore[i]);
            g_MScore[i].GetComponent<csNumber>().SetNumber(TeamScore[i]);
            g_TScore[i].GetComponent<csNumber>().SetNumber(TeamScore[i]);
            g_MScore[i].SetActive(false);
            g_TScore[i].SetActive(false);
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
        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
        Round = 1;
        t_Round.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void TeamNumberPlus()
    {
        g_MScore[Teams].SetActive(false);
        g_TScore[Teams].SetActive(false);
        isRead = false;
        g_CAni.SetActive(false);
        Counting = 0;
        Teams = 1;
        g_MScore[Teams].SetActive(true);
        g_TScore[Teams].SetActive(true);
        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_TScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void TeamNumberMinus()
    {
        g_MScore[Teams].SetActive(false);
        g_TScore[Teams].SetActive(false);
        isRead = false;
        g_CAni.SetActive(false);
        Counting = 0;
        Teams = 0;
        g_MScore[Teams].SetActive(true);
        g_TScore[Teams].SetActive(true);
        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_TScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void PlayerNumberPlus()
    {
        g_MScore[Teams].SetActive(false);
        g_TScore[Teams].SetActive(false);
        g_CAni.SetActive(false);
        Counting = 0;
        Players += 1;
        g_MScore[Teams].SetActive(true);
        g_TScore[Teams].SetActive(true);
        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_TScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void PlayerNumberMinus()
    {
        g_MScore[Teams].SetActive(false);
        g_TScore[Teams].SetActive(false);
        g_CAni.SetActive(false);
        Counting = 0;
        Players = 0;
        g_MScore[Teams].SetActive(true);
        g_TScore[Teams].SetActive(true);
        g_MScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_TScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    public void RoundScore(int n)
    {
        if (Teams == 0 && Players == 0)
        {
            A1_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreA1[0].text = A1_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreA1[1].text = A1_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreA1[2].text = A1_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreA1[3].text = A1_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreA1[4].text = A1_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreA1[0].text = A1_ScoreSave[1].ToString();
                    t_RScoreA1[1].text = A1_ScoreSave[2].ToString();
                    t_RScoreA1[2].text = A1_ScoreSave[3].ToString();
                    t_RScoreA1[3].text = A1_ScoreSave[4].ToString();
                    t_RScoreA1[4].text = A1_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreA1[0].text = A1_ScoreSave[2].ToString();
                    t_RScoreA1[1].text = A1_ScoreSave[3].ToString();
                    t_RScoreA1[2].text = A1_ScoreSave[4].ToString();
                    t_RScoreA1[3].text = A1_ScoreSave[5].ToString();
                    t_RScoreA1[4].text = A1_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreA1[0].text = A1_ScoreSave[3].ToString();
                    t_RScoreA1[1].text = A1_ScoreSave[4].ToString();
                    t_RScoreA1[2].text = A1_ScoreSave[5].ToString();
                    t_RScoreA1[3].text = A1_ScoreSave[6].ToString();
                    t_RScoreA1[4].text = A1_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreA1[0].text = A1_ScoreSave[4].ToString();
                    t_RScoreA1[1].text = A1_ScoreSave[5].ToString();
                    t_RScoreA1[2].text = A1_ScoreSave[6].ToString();
                    t_RScoreA1[3].text = A1_ScoreSave[7].ToString();
                    t_RScoreA1[4].text = A1_ScoreSave[8].ToString();
                }
            }
        }
        else if (Teams == 0 && Players == 1)
        {
            A2_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreA2[0].text = A2_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreA2[1].text = A2_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreA2[2].text = A2_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreA2[3].text = A2_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreA2[4].text = A2_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreA2[0].text = A2_ScoreSave[1].ToString();
                    t_RScoreA2[1].text = A2_ScoreSave[2].ToString();
                    t_RScoreA2[2].text = A2_ScoreSave[3].ToString();
                    t_RScoreA2[3].text = A2_ScoreSave[4].ToString();
                    t_RScoreA2[4].text = A2_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreA2[0].text = A2_ScoreSave[2].ToString();
                    t_RScoreA2[1].text = A2_ScoreSave[3].ToString();
                    t_RScoreA2[2].text = A2_ScoreSave[4].ToString();
                    t_RScoreA2[3].text = A2_ScoreSave[5].ToString();
                    t_RScoreA2[4].text = A2_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreA2[0].text = A2_ScoreSave[3].ToString();
                    t_RScoreA2[1].text = A2_ScoreSave[4].ToString();
                    t_RScoreA2[2].text = A2_ScoreSave[5].ToString();
                    t_RScoreA2[3].text = A2_ScoreSave[6].ToString();
                    t_RScoreA2[4].text = A2_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreA2[0].text = A2_ScoreSave[4].ToString();
                    t_RScoreA2[1].text = A2_ScoreSave[5].ToString();
                    t_RScoreA2[2].text = A2_ScoreSave[6].ToString();
                    t_RScoreA2[3].text = A2_ScoreSave[7].ToString();
                    t_RScoreA2[4].text = A2_ScoreSave[8].ToString();
                }
            }
        }
        else if (Teams == 0 && Players == 2)
        {
            A3_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreA3[0].text = A3_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreA3[1].text = A3_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreA3[2].text = A3_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreA3[3].text = A3_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreA3[4].text = A3_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreA3[0].text = A3_ScoreSave[1].ToString();
                    t_RScoreA3[1].text = A3_ScoreSave[2].ToString();
                    t_RScoreA3[2].text = A3_ScoreSave[3].ToString();
                    t_RScoreA3[3].text = A3_ScoreSave[4].ToString();
                    t_RScoreA3[4].text = A3_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreA3[0].text = A3_ScoreSave[2].ToString();
                    t_RScoreA3[1].text = A3_ScoreSave[3].ToString();
                    t_RScoreA3[2].text = A3_ScoreSave[4].ToString();
                    t_RScoreA3[3].text = A3_ScoreSave[5].ToString();
                    t_RScoreA3[4].text = A3_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreA3[0].text = A3_ScoreSave[3].ToString();
                    t_RScoreA3[1].text = A3_ScoreSave[4].ToString();
                    t_RScoreA3[2].text = A3_ScoreSave[5].ToString();
                    t_RScoreA3[3].text = A3_ScoreSave[6].ToString();
                    t_RScoreA3[4].text = A3_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreA3[0].text = A3_ScoreSave[4].ToString();
                    t_RScoreA3[1].text = A3_ScoreSave[5].ToString();
                    t_RScoreA3[2].text = A3_ScoreSave[6].ToString();
                    t_RScoreA3[3].text = A3_ScoreSave[7].ToString();
                    t_RScoreA3[4].text = A3_ScoreSave[8].ToString();
                }
            }
        }
        else if (Teams == 0 && Players == 3)
        {
            A4_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreA4[0].text = A4_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreA4[1].text = A4_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreA4[2].text = A4_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreA4[3].text = A4_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreA4[4].text = A4_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreA4[0].text = A4_ScoreSave[1].ToString();
                    t_RScoreA4[1].text = A4_ScoreSave[2].ToString();
                    t_RScoreA4[2].text = A4_ScoreSave[3].ToString();
                    t_RScoreA4[3].text = A4_ScoreSave[4].ToString();
                    t_RScoreA4[4].text = A4_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreA4[0].text = A4_ScoreSave[2].ToString();
                    t_RScoreA4[1].text = A4_ScoreSave[3].ToString();
                    t_RScoreA4[2].text = A4_ScoreSave[4].ToString();
                    t_RScoreA4[3].text = A4_ScoreSave[5].ToString();
                    t_RScoreA4[4].text = A4_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreA4[0].text = A4_ScoreSave[3].ToString();
                    t_RScoreA4[1].text = A4_ScoreSave[4].ToString();
                    t_RScoreA4[2].text = A4_ScoreSave[5].ToString();
                    t_RScoreA4[3].text = A4_ScoreSave[6].ToString();
                    t_RScoreA4[4].text = A4_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreA4[0].text = A4_ScoreSave[4].ToString();
                    t_RScoreA4[1].text = A4_ScoreSave[5].ToString();
                    t_RScoreA4[2].text = A4_ScoreSave[6].ToString();
                    t_RScoreA4[3].text = A4_ScoreSave[7].ToString();
                    t_RScoreA4[4].text = A4_ScoreSave[8].ToString();
                }
            }
        }
        else if (Teams == 0 && Players == 4)
        {
            A5_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreA5[0].text = A5_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreA5[1].text = A5_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreA5[2].text = A5_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreA5[3].text = A5_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreA5[4].text = A5_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreA5[0].text = A5_ScoreSave[1].ToString();
                    t_RScoreA5[1].text = A5_ScoreSave[2].ToString();
                    t_RScoreA5[2].text = A5_ScoreSave[3].ToString();
                    t_RScoreA5[3].text = A5_ScoreSave[4].ToString();
                    t_RScoreA5[4].text = A5_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreA5[0].text = A5_ScoreSave[2].ToString();
                    t_RScoreA5[1].text = A5_ScoreSave[3].ToString();
                    t_RScoreA5[2].text = A5_ScoreSave[4].ToString();
                    t_RScoreA5[3].text = A5_ScoreSave[5].ToString();
                    t_RScoreA5[4].text = A5_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreA5[0].text = A5_ScoreSave[3].ToString();
                    t_RScoreA5[1].text = A5_ScoreSave[4].ToString();
                    t_RScoreA5[2].text = A5_ScoreSave[5].ToString();
                    t_RScoreA5[3].text = A5_ScoreSave[6].ToString();
                    t_RScoreA5[4].text = A5_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreA5[0].text = A5_ScoreSave[4].ToString();
                    t_RScoreA5[1].text = A5_ScoreSave[5].ToString();
                    t_RScoreA5[2].text = A5_ScoreSave[6].ToString();
                    t_RScoreA5[3].text = A5_ScoreSave[7].ToString();
                    t_RScoreA5[4].text = A5_ScoreSave[8].ToString();
                }
            }
        }
        else if (Teams == 1 && Players == 0)
        {
            B1_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreB1[0].text = B1_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreB1[1].text = B1_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreB1[2].text = B1_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreB1[3].text = B1_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreB1[4].text = B1_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreB1[0].text = B1_ScoreSave[1].ToString();
                    t_RScoreB1[1].text = B1_ScoreSave[2].ToString();
                    t_RScoreB1[2].text = B1_ScoreSave[3].ToString();
                    t_RScoreB1[3].text = B1_ScoreSave[4].ToString();
                    t_RScoreB1[4].text = B1_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreB1[0].text = B1_ScoreSave[2].ToString();
                    t_RScoreB1[1].text = B1_ScoreSave[3].ToString();
                    t_RScoreB1[2].text = B1_ScoreSave[4].ToString();
                    t_RScoreB1[3].text = B1_ScoreSave[5].ToString();
                    t_RScoreB1[4].text = B1_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreB1[0].text = B1_ScoreSave[3].ToString();
                    t_RScoreB1[1].text = B1_ScoreSave[4].ToString();
                    t_RScoreB1[2].text = B1_ScoreSave[5].ToString();
                    t_RScoreB1[3].text = B1_ScoreSave[6].ToString();
                    t_RScoreB1[4].text = B1_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreB1[0].text = B1_ScoreSave[4].ToString();
                    t_RScoreB1[1].text = B1_ScoreSave[5].ToString();
                    t_RScoreB1[2].text = B1_ScoreSave[6].ToString();
                    t_RScoreB1[3].text = B1_ScoreSave[7].ToString();
                    t_RScoreB1[4].text = B1_ScoreSave[8].ToString();
                }
            }
        }
        else if (Teams == 1 && Players == 1)
        {
            B2_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreB2[0].text = B2_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreB2[1].text = B2_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreB2[2].text = B2_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreB2[3].text = B2_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreB2[4].text = B2_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreB2[0].text = B2_ScoreSave[1].ToString();
                    t_RScoreB2[1].text = B2_ScoreSave[2].ToString();
                    t_RScoreB2[2].text = B2_ScoreSave[3].ToString();
                    t_RScoreB2[3].text = B2_ScoreSave[4].ToString();
                    t_RScoreB2[4].text = B2_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreB2[0].text = B2_ScoreSave[2].ToString();
                    t_RScoreB2[1].text = B2_ScoreSave[3].ToString();
                    t_RScoreB2[2].text = B2_ScoreSave[4].ToString();
                    t_RScoreB2[3].text = B2_ScoreSave[5].ToString();
                    t_RScoreB2[4].text = B2_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreB2[0].text = B2_ScoreSave[3].ToString();
                    t_RScoreB2[1].text = B2_ScoreSave[4].ToString();
                    t_RScoreB2[2].text = B2_ScoreSave[5].ToString();
                    t_RScoreB2[3].text = B2_ScoreSave[6].ToString();
                    t_RScoreB2[4].text = B2_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreB2[0].text = B2_ScoreSave[4].ToString();
                    t_RScoreB2[1].text = B2_ScoreSave[5].ToString();
                    t_RScoreB2[2].text = B2_ScoreSave[6].ToString();
                    t_RScoreB2[3].text = B2_ScoreSave[7].ToString();
                    t_RScoreB2[4].text = B2_ScoreSave[8].ToString();
                }
            }
        }
        else if (Teams == 1 && Players == 2)
        {
            B3_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreB3[0].text = B3_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreB3[1].text = B3_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreB3[2].text = B3_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreB3[3].text = B3_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreB3[4].text = B3_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreB3[0].text = B3_ScoreSave[1].ToString();
                    t_RScoreB3[1].text = B3_ScoreSave[2].ToString();
                    t_RScoreB3[2].text = B3_ScoreSave[3].ToString();
                    t_RScoreB3[3].text = B3_ScoreSave[4].ToString();
                    t_RScoreB3[4].text = B3_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreB3[0].text = B3_ScoreSave[2].ToString();
                    t_RScoreB3[1].text = B3_ScoreSave[3].ToString();
                    t_RScoreB3[2].text = B3_ScoreSave[4].ToString();
                    t_RScoreB3[3].text = B3_ScoreSave[5].ToString();
                    t_RScoreB3[4].text = B3_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreB3[0].text = B3_ScoreSave[3].ToString();
                    t_RScoreB3[1].text = B3_ScoreSave[4].ToString();
                    t_RScoreB3[2].text = B3_ScoreSave[5].ToString();
                    t_RScoreB3[3].text = B3_ScoreSave[6].ToString();
                    t_RScoreB3[4].text = B3_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreB3[0].text = B3_ScoreSave[4].ToString();
                    t_RScoreB3[1].text = B3_ScoreSave[5].ToString();
                    t_RScoreB3[2].text = B3_ScoreSave[6].ToString();
                    t_RScoreB3[3].text = B3_ScoreSave[7].ToString();
                    t_RScoreB3[4].text = B3_ScoreSave[8].ToString();
                }
            }
        }
        else if (Teams == 1 && Players == 3)
        {
            B4_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreB4[0].text = B4_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreB4[1].text = B4_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreB4[2].text = B4_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreB4[3].text = B4_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreB4[4].text = B4_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreB4[0].text = B4_ScoreSave[1].ToString();
                    t_RScoreB4[1].text = B4_ScoreSave[2].ToString();
                    t_RScoreB4[2].text = B4_ScoreSave[3].ToString();
                    t_RScoreB4[3].text = B4_ScoreSave[4].ToString();
                    t_RScoreB4[4].text = B4_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreB4[0].text = B4_ScoreSave[2].ToString();
                    t_RScoreB4[1].text = B4_ScoreSave[3].ToString();
                    t_RScoreB4[2].text = B4_ScoreSave[4].ToString();
                    t_RScoreB4[3].text = B4_ScoreSave[5].ToString();
                    t_RScoreB4[4].text = B4_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreB4[0].text = B4_ScoreSave[3].ToString();
                    t_RScoreB4[1].text = B4_ScoreSave[4].ToString();
                    t_RScoreB4[2].text = B4_ScoreSave[5].ToString();
                    t_RScoreB4[3].text = B4_ScoreSave[6].ToString();
                    t_RScoreB4[4].text = B4_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreB4[0].text = B4_ScoreSave[4].ToString();
                    t_RScoreB4[1].text = B4_ScoreSave[5].ToString();
                    t_RScoreB4[2].text = B4_ScoreSave[6].ToString();
                    t_RScoreB4[3].text = B4_ScoreSave[7].ToString();
                    t_RScoreB4[4].text = B4_ScoreSave[8].ToString();
                }
            }
        }
        else if (Teams == 1 && Players == 4)
        {
            B5_ScoreSave[RScore] += n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreB5[0].text = B5_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreB5[1].text = B5_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreB5[2].text = B5_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreB5[3].text = B5_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreB5[4].text = B5_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreB5[0].text = B5_ScoreSave[1].ToString();
                    t_RScoreB5[1].text = B5_ScoreSave[2].ToString();
                    t_RScoreB5[2].text = B5_ScoreSave[3].ToString();
                    t_RScoreB5[3].text = B5_ScoreSave[4].ToString();
                    t_RScoreB5[4].text = B5_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreB5[0].text = B5_ScoreSave[2].ToString();
                    t_RScoreB5[1].text = B5_ScoreSave[3].ToString();
                    t_RScoreB5[2].text = B5_ScoreSave[4].ToString();
                    t_RScoreB5[3].text = B5_ScoreSave[5].ToString();
                    t_RScoreB5[4].text = B5_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreB5[0].text = B5_ScoreSave[3].ToString();
                    t_RScoreB5[1].text = B5_ScoreSave[4].ToString();
                    t_RScoreB5[2].text = B5_ScoreSave[5].ToString();
                    t_RScoreB5[3].text = B5_ScoreSave[6].ToString();
                    t_RScoreB5[4].text = B5_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreB5[0].text = B5_ScoreSave[4].ToString();
                    t_RScoreB5[1].text = B5_ScoreSave[5].ToString();
                    t_RScoreB5[2].text = B5_ScoreSave[6].ToString();
                    t_RScoreB5[3].text = B5_ScoreSave[7].ToString();
                    t_RScoreB5[4].text = B5_ScoreSave[8].ToString();
                }
            }
        }

    }
    public void RScoreImageUp()
    {
        if (Teams == 0 && Players == 0)
        {
            if (RScore == 5)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Teams == 0 && Players == 1)
        {
            if (RScore == 5)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Teams == 0 && Players == 2)
        {
            if (RScore == 5)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Teams == 0 && Players == 3)
        {
            if (RScore == 5)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreA4[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA4[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA4[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA4[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA4[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Teams == 0 && Players == 4)
        {
            if (RScore == 5)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreA5[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA5[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA5[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA5[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA5[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Teams == 1 && Players == 0)
        {
            if (RScore == 5)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Teams == 1 && Players == 1)
        {
            if (RScore == 5)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Teams == 1 && Players == 2)
        {
            if (RScore == 5)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Teams == 1 && Players == 3)
        {
            if (RScore == 5)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreB4[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB4[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB4[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB4[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB4[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
        else if (Teams == 1 && Players == 4)
        {
            if (RScore == 5)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[5];
            }
            if (RScore == 6)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[6];
            }
            if (RScore == 7)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[7];
            }
            if (RScore == 8)
            {
                i_RScoreB5[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB5[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB5[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB5[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB5[4].GetComponent<Image>().sprite = s_RScore[8];
            }
        }
    }

    void MyTure()
    {
        if (Teams == 0 && Players == 0)
        {
            g_AT.GetComponent<Transform>().position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.GetComponent<Transform>().position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_TScore[0].SetActive(true);
            g_TScore[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            i_TeamName[0].GetComponent<Image>().sprite = s_OnPlayer[0];
            i_TeamName[1].GetComponent<Image>().sprite = s_OffPlayer[0];

            i_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            i_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];

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

            t_PPDScoreA1.enabled = true;
            t_PPDScoreA2.enabled = false;
            t_PPDScoreA3.enabled = false;
            t_PPDScoreA4.enabled = false;
            t_PPDScoreA5.enabled = false;
            t_PPDScoreB1.enabled = false;
            t_PPDScoreB2.enabled = false;
            t_PPDScoreB3.enabled = false;
            t_PPDScoreB4.enabled = false;
            t_PPDScoreB5.enabled = false;

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = true;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
            }

        }
        else if (Teams == 0 && Players == 1)
        {
            g_AT.GetComponent<Transform>().position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.GetComponent<Transform>().position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_TScore[0].SetActive(true);
            g_TScore[1].SetActive(false);

            g_OffScore[1].SetActive(true);
            g_OffScore[0].SetActive(false);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            i_TeamName[0].GetComponent<Image>().sprite = s_OnPlayer[1];
            i_TeamName[1].GetComponent<Image>().sprite = s_OffPlayer[1];

            i_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            i_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];

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

            t_PPDScoreA1.enabled = false;
            t_PPDScoreA2.enabled = true;
            t_PPDScoreA3.enabled = false;
            t_PPDScoreA4.enabled = false;
            t_PPDScoreA5.enabled = false;
            t_PPDScoreB1.enabled = false;
            t_PPDScoreB2.enabled = false;
            t_PPDScoreB3.enabled = false;
            t_PPDScoreB4.enabled = false;
            t_PPDScoreB5.enabled = false;

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = true;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
            }

        }
        else if (Teams == 0 && Players == 2)
        {
            g_AT.GetComponent<Transform>().position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.GetComponent<Transform>().position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_TScore[0].SetActive(true);
            g_TScore[1].SetActive(false);

            g_OffScore[1].SetActive(true);
            g_OffScore[0].SetActive(false);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            i_TeamName[0].GetComponent<Image>().sprite = s_OnPlayer[2];
            i_TeamName[1].GetComponent<Image>().sprite = s_OffPlayer[2];

            i_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            i_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];

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

            t_PPDScoreA1.enabled = false;
            t_PPDScoreA2.enabled = false;
            t_PPDScoreA3.enabled = true;
            t_PPDScoreA4.enabled = false;
            t_PPDScoreA5.enabled = false;
            t_PPDScoreB1.enabled = false;
            t_PPDScoreB2.enabled = false;
            t_PPDScoreB3.enabled = false;
            t_PPDScoreB4.enabled = false;
            t_PPDScoreB5.enabled = false;

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = true;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
            }

        }
        else if (Teams == 0 && Players == 3)
        {
            g_AT.GetComponent<Transform>().position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.GetComponent<Transform>().position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_TScore[0].SetActive(true);
            g_TScore[1].SetActive(false);

            g_OffScore[1].SetActive(true);
            g_OffScore[0].SetActive(false);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            i_TeamName[0].GetComponent<Image>().sprite = s_OnPlayer[3];
            i_TeamName[1].GetComponent<Image>().sprite = s_OffPlayer[3];

            i_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            i_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];

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

            t_PPDScoreA1.enabled = false;
            t_PPDScoreA2.enabled = false;
            t_PPDScoreA3.enabled = false;
            t_PPDScoreA4.enabled = true;
            t_PPDScoreA5.enabled = false;
            t_PPDScoreB1.enabled = false;
            t_PPDScoreB2.enabled = false;
            t_PPDScoreB3.enabled = false;
            t_PPDScoreB4.enabled = false;
            t_PPDScoreB5.enabled = false;

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = true;
                i_RScoreA5[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
            }

        }
        else if (Teams == 0 && Players == 4)
        {
            g_AT.GetComponent<Transform>().position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.GetComponent<Transform>().position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_TScore[0].SetActive(true);
            g_TScore[1].SetActive(false);

            g_OffScore[1].SetActive(true);
            g_OffScore[0].SetActive(false);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            i_TeamName[0].GetComponent<Image>().sprite = s_OnPlayer[4];
            i_TeamName[1].GetComponent<Image>().sprite = s_OffPlayer[4];

            i_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            i_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];

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

            t_PPDScoreA1.enabled = false;
            t_PPDScoreA2.enabled = false;
            t_PPDScoreA3.enabled = false;
            t_PPDScoreA4.enabled = false;
            t_PPDScoreA5.enabled = true;
            t_PPDScoreB1.enabled = false;
            t_PPDScoreB2.enabled = false;
            t_PPDScoreB3.enabled = false;
            t_PPDScoreB4.enabled = false;
            t_PPDScoreB5.enabled = false;

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = true;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
            }

        }
        else if (Teams == 1 && Players == 0)
        {
            g_AT.GetComponent<Transform>().position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.GetComponent<Transform>().position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_TScore[0].SetActive(false);
            g_TScore[1].SetActive(true);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            i_TeamName[0].GetComponent<Image>().sprite = s_OffPlayer[0];
            i_TeamName[1].GetComponent<Image>().sprite = s_OnPlayer[0];

            i_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            i_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

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

            t_PPDScoreA1.enabled = false;
            t_PPDScoreA2.enabled = false;
            t_PPDScoreA3.enabled = false;
            t_PPDScoreA4.enabled = false;
            t_PPDScoreA5.enabled = false;
            t_PPDScoreB1.enabled = true;
            t_PPDScoreB2.enabled = false;
            t_PPDScoreB3.enabled = false;
            t_PPDScoreB4.enabled = false;
            t_PPDScoreB5.enabled = false;

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreB1[i].enabled = true;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
            }

        }
        else if (Teams == 1 && Players == 1)
        {
            g_AT.GetComponent<Transform>().position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.GetComponent<Transform>().position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_TScore[0].SetActive(false);
            g_TScore[1].SetActive(true);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            i_TeamName[0].GetComponent<Image>().sprite = s_OffPlayer[1];
            i_TeamName[1].GetComponent<Image>().sprite = s_OnPlayer[1];

            i_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            i_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

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

            t_PPDScoreA1.enabled = false;
            t_PPDScoreA2.enabled = false;
            t_PPDScoreA3.enabled = false;
            t_PPDScoreA4.enabled = false;
            t_PPDScoreA5.enabled = false;
            t_PPDScoreB1.enabled = false;
            t_PPDScoreB2.enabled = true;
            t_PPDScoreB3.enabled = false;
            t_PPDScoreB4.enabled = false;
            t_PPDScoreB5.enabled = false;

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = true;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
            }

        }
        else if (Teams == 1 && Players == 2)
        {
            g_AT.GetComponent<Transform>().position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.GetComponent<Transform>().position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_TScore[0].SetActive(false);
            g_TScore[1].SetActive(true);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            i_TeamName[0].GetComponent<Image>().sprite = s_OffPlayer[2];
            i_TeamName[1].GetComponent<Image>().sprite = s_OnPlayer[2];

            i_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            i_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

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

            t_PPDScoreA1.enabled = false;
            t_PPDScoreA2.enabled = false;
            t_PPDScoreA3.enabled = false;
            t_PPDScoreA4.enabled = false;
            t_PPDScoreA5.enabled = false;
            t_PPDScoreB1.enabled = false;
            t_PPDScoreB2.enabled = false;
            t_PPDScoreB3.enabled = true;
            t_PPDScoreB4.enabled = false;
            t_PPDScoreB5.enabled = false;

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = true;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = false;
            }

        }
        else if (Teams == 1 && Players == 3)
        {
            g_AT.GetComponent<Transform>().position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.GetComponent<Transform>().position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_TScore[0].SetActive(false);
            g_TScore[1].SetActive(true);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            i_TeamName[0].GetComponent<Image>().sprite = s_OffPlayer[3];
            i_TeamName[1].GetComponent<Image>().sprite = s_OnPlayer[3];

            i_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            i_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

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

            t_PPDScoreA1.enabled = false;
            t_PPDScoreA2.enabled = false;
            t_PPDScoreA3.enabled = false;
            t_PPDScoreA4.enabled = false;
            t_PPDScoreA5.enabled = false;
            t_PPDScoreB1.enabled = false;
            t_PPDScoreB2.enabled = false;
            t_PPDScoreB3.enabled = false;
            t_PPDScoreB4.enabled = true;
            t_PPDScoreB5.enabled = false;

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = true;
                i_RScoreB5[i].enabled = false;
            }

        }
        else if (Teams == 1 && Players == 4)
        {
            g_AT.GetComponent<Transform>().position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.GetComponent<Transform>().position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);

            g_TScore[0].SetActive(false);
            g_TScore[1].SetActive(true);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);

            i_TeamName[0].GetComponent<Image>().sprite = s_OffPlayer[4];
            i_TeamName[1].GetComponent<Image>().sprite = s_OnPlayer[4];

            i_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            i_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];

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

            t_PPDScoreA1.enabled = false;
            t_PPDScoreA2.enabled = false;
            t_PPDScoreA3.enabled = false;
            t_PPDScoreA4.enabled = false;
            t_PPDScoreA5.enabled = false;
            t_PPDScoreB1.enabled = false;
            t_PPDScoreB2.enabled = false;
            t_PPDScoreB3.enabled = false;
            t_PPDScoreB4.enabled = false;
            t_PPDScoreB5.enabled = true;

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreA4[i].enabled = false;
                i_RScoreA5[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
                i_RScoreB4[i].enabled = false;
                i_RScoreB5[i].enabled = true;
            }

        }
    }

    void GameEndRead()
    {
        if (TeamScore[0] > TeamScore[1])
        {
            isEnd = true;
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            gmg.GameEnd(0);
        }
        else if (TeamScore[1] > TeamScore[0])
        {
            isEnd = true;
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            gmg.GameEnd(1);
        }
        else if (TeamScore[0] == TeamScore[1])
        {
            isEnd = true;
            for (int i = 0; i < g_MScore.Length; i++)
                g_MScore[i].SetActive(false);
            gmg.GameEnd(0);
        }
    }

    public void RoundRead()
    {
        g_TScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
        g_CAni.SetActive(true);
        g_MScore[0].SetActive(false);
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
        g_MScore[0].SetActive(true);
        g_MScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
        Round += 1;
        t_Round.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void PPDScore(int n)
    {
        if (Teams == 0 && Players == 0)
        {
            A1_DartTotal += n;
            A1_Average = A1_DartTotal / A1_AverageCounting;
            t_PPDScoreA1.text = string.Format("{0:N2}", A1_Average);
        }
        else if (Teams == 0 && Players == 1)
        {
            A2_DartTotal += n;
            A2_Average = A2_DartTotal / A2_AverageCounting;
            t_PPDScoreA2.text = string.Format("{0:N2}", A2_Average);
        }
        else if (Teams == 0 && Players == 2)
        {
            A3_DartTotal += n;
            A3_Average = A3_DartTotal / A3_AverageCounting;
            t_PPDScoreA3.text = string.Format("{0:N2}", A3_Average);
        }
        else if (Teams == 0 && Players == 3)
        {
            A4_DartTotal += n;
            A4_Average = A4_DartTotal / A4_AverageCounting;
            t_PPDScoreA4.text = string.Format("{0:N2}", A4_Average);
        }
        else if (Teams == 0 && Players == 4)
        {
            A5_DartTotal += n;
            A5_Average = A5_DartTotal / A5_AverageCounting;
            t_PPDScoreA5.text = string.Format("{0:N2}", A5_Average);
        }

        else if (Teams == 1 && Players == 0)
        {
            B1_DartTotal += n;
            B1_Average = B1_DartTotal / B1_AverageCounting;
            t_PPDScoreB1.text = string.Format("{0:N2}", B1_Average);
        }
        else if (Teams == 1 && Players == 1)
        {
            B2_DartTotal += n;
            B2_Average = B2_DartTotal / B2_AverageCounting;
            t_PPDScoreB2.text = string.Format("{0:N2}", B2_Average);
        }
        else if (Teams == 1 && Players == 2)
        {
            B3_DartTotal += n;
            B3_Average = B3_DartTotal / B3_AverageCounting;
            t_PPDScoreB3.text = string.Format("{0:N2}", B3_Average);
        }
        else if (Teams == 1 && Players == 3)
        {
            B4_DartTotal += n;
            B4_Average = B4_DartTotal / B4_AverageCounting;
            t_PPDScoreB4.text = string.Format("{0:N2}", B4_Average);
        }
        else if (Teams == 1 && Players == 4)
        {
            B5_DartTotal += n;
            B5_Average = B5_DartTotal / B5_AverageCounting;
            t_PPDScoreB5.text = string.Format("{0:N2}", B5_Average);
        }

        if (Teams == 0)
            AT_Average = A1_Average + A2_Average + A3_Average + A4_Average + A5_Average / 5;
        else if (Teams == 1)
            BT_Average = B1_Average + B2_Average + B3_Average + B4_Average + B5_Average / 5;
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
