using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CT_Tri333 : MonoBehaviour
{
    public Text t_RoundText;
    public Text t_PPDText_A1;
    public Text t_PPDText_A2;
    public Text t_PPDText_A3;
    public Text t_PPDText_B1;
    public Text t_PPDText_B2;
    public Text t_PPDText_B3;
    public Text t_PPDText_C1;
    public Text t_PPDText_C2;
    public Text t_PPDText_C3;
    public Text[] t_RScoreText_A1 = new Text[5];
    public Text[] t_RScoreText_A2 = new Text[5];
    public Text[] t_RScoreText_A3 = new Text[5];
    public Text[] t_RScoreText_B1 = new Text[5];
    public Text[] t_RScoreText_B2 = new Text[5];
    public Text[] t_RScoreText_B3 = new Text[5];
    public Text[] t_RScoreText_C1 = new Text[5];
    public Text[] t_RScoreText_C2 = new Text[5];
    public Text[] t_RScoreText_C3 = new Text[5];

    public GameObject[] g_Dart = new GameObject[3];
    public GameObject g_RAni;
    public GameObject g_DAni;
    public GameObject g_PAni;
    public GameObject g_CAni;
    public GameObject g_RoundOn;
    public GameObject g_RoundR;
    public GameObject[] g_RoundNum = new GameObject[8];
    public GameObject[] g_MScore = new GameObject[3];
    public GameObject[] g_PScore = new GameObject[3];
    public GameObject[] g_OffScore = new GameObject[3];
    public GameObject[] g_RScore = new GameObject[9];
    public GameObject[] g_Playerbar = new GameObject[3];
    public GameObject[] g_Teambar = new GameObject[3];
    public GameObject g_AT;
    public GameObject g_BT;
    public GameObject g_CT;

    public Sprite s_OnDart;
    public Sprite s_OffDart;
    public Sprite[] s_OnPlayer = new Sprite[3];
    public Sprite[] s_OffPlayer = new Sprite[3];
    public Sprite[] s_OnTeambar = new Sprite[3];
    public Sprite[] s_OffTeambar = new Sprite[3];
    public Sprite[] s_RScore = new Sprite[8];
    public Image[] i_Rscore_A1 = new Image[5];
    public Image[] i_Rscore_A2 = new Image[5];
    public Image[] i_Rscore_A3 = new Image[5];
    public Image[] i_Rscore_B1 = new Image[5];
    public Image[] i_Rscore_B2 = new Image[5];
    public Image[] i_Rscore_B3 = new Image[5];
    public Image[] i_Rscore_C1 = new Image[5];
    public Image[] i_Rscore_C2 = new Image[5];
    public Image[] i_Rscore_C3 = new Image[5];

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int Counting = 0;
    public int Round = 0;
    public int RoundStop = 8;
    public int A1_DartTotal = 0;
    public int A2_DartTotal = 0;
    public int A3_DartTotal = 0;
    public int B1_DartTotal = 0;
    public int B2_DartTotal = 0;
    public int B3_DartTotal = 0;
    public int C1_DartTotal = 0;
    public int C2_DartTotal = 0;
    public int C3_DartTotal = 0;
    public int DartS = 0;
    public int DartM = 0;
    public int RScore = 0;
    public int[] TeamScore = new int[3];
    public int A1_Average = 0;
    public int A2_Average = 0;
    public int A3_Average = 0;
    public int B1_Average = 0;
    public int B2_Average = 0;
    public int B3_Average = 0;
    public int C1_Average = 0;
    public int C2_Average = 0;
    public int C3_Average = 0;
    public int AT_Average = 0;
    public int BT_Average = 0;
    public int CT_Average = 0;

    public int A1_AverageCounting = 0;
    public int A2_AverageCounting = 0;
    public int A3_AverageCounting = 0;
    public int B1_AverageCounting = 0;
    public int B2_AverageCounting = 0;
    public int B3_AverageCounting = 0;
    public int C1_AverageCounting = 0;
    public int C2_AverageCounting = 0;
    public int C3_AverageCounting = 0;

    public int Players = 0;
    public int Teams = 0;
    public int win = 0;
    public int[] DartScore = new int[3];
    public int[] DartBasicScore = new int[3];
    public int[] A1_ScoreSave = new int[8];
    public int[] A2_ScoreSave = new int[8];
    public int[] A3_ScoreSave = new int[8];
    public int[] B1_ScoreSave = new int[8];
    public int[] B2_ScoreSave = new int[8];
    public int[] B3_ScoreSave = new int[8];
    public int[] C1_ScoreSave = new int[8];
    public int[] C2_ScoreSave = new int[8];
    public int[] C3_ScoreSave = new int[8];

    public string[] playerName = new string[9];

    public bool isEnd = false;
    public bool isSpace = false;
    public bool isRead = false;
    public bool isAT = true;
    public bool isBT = false;
    public bool isCT = false;

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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                        DartS = 0;
                        DartM = 0;
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
                else if (Teams == 2 && Players == 0 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        C1_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[2] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        g_PScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        DartS = 0;
                        DartM = 0;
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        C1_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[2] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        g_PScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        DartS = 0;
                        DartM = 0;
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        C1_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[2] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        g_PScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        DartS = 0;
                        DartM = 0;
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        GetMovie();
                        g_MScore[2].SetActive(false);
                        g_PAni.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Teams == 2 && Players == 1 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        C2_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[2] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        g_PScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        DartS = 0;
                        DartM = 0;
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        C2_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[2] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        g_PScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        DartS = 0;
                        DartM = 0;
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        C2_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[2] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        g_PScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        DartS = 0;
                        DartM = 0;
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        if (Round < RoundStop)
                        {
                            GetMovie();
                            g_MScore[2].SetActive(false);
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
                else if (Teams == 2 && Players == 2 && !isRead && !isSpace && !isEnd)
                {
                    if (Counting == 0 && !isRead && !isSpace)
                    {
                        C3_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        TeamScore[2] += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        g_PScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        DartS = 0;
                        DartM = 0;
                        Counting = 1;
                    }
                    else if (Counting == 1 && !isRead && !isSpace)
                    {
                        C3_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[2] += DartScore[1];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        RoundScore(DartScore[0] + DartScore[1]);
                        PPDScore(DartScore[1]);
                        g_MScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        g_PScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        DartS = 0;
                        DartM = 0;
                        Counting = 2;
                    }
                    else if (Counting == 2 && !isRead && !isSpace)
                    {
                        C3_AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamScore[2] += DartScore[2];
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        RoundScore(DartScore[0] + DartScore[1] + DartScore[2]);
                        PPDScore(DartScore[2]);
                        g_MScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        g_PScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);
                        DartS = 0;
                        DartM = 0;
                        Counting = 3;
                    }
                    if (Counting == 3 && !isRead && !isSpace)
                    {
                        if (Round < RoundStop)
                        {
                            GetMovie();
                            g_MScore[2].SetActive(false);
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
        if (Input.GetKeyDown(KeyCode.Space) && gmg.isAni==false && isSpace && Counting == 4 && !isEnd)
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
                Invoke("TeamNumberPlus", 4.5f);
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
                Invoke("TeamNumberPlus", 4.5f);
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
                Invoke("TeamNumberPlus", 4.5f);
            }
            else if (Teams == 2 && Players == 0 && !isRead && !isEnd)
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
            else if (Teams == 2 && Players == 1 && !isRead && !isEnd)
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
            else if (Teams == 2 && Players == 2 && !isRead && !isEnd)
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
        if (isAT && !isBT && !isCT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);
            g_PScore[2].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);

            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);

            g_RScore[0].SetActive(true);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OnPlayer[0];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[0];
            g_Playerbar[2].GetComponent<Image>().sprite = s_OffPlayer[0];

            g_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_OffTeambar[2];

            t_PPDText_A1.enabled = true;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_C1.enabled = false;
            t_PPDText_C2.enabled = false;
            t_PPDText_C3.enabled = false;

            for (int i = 0; i < i_Rscore_A1.Length; i++)
            {
                i_Rscore_A1[i].enabled = true;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_C1[i].enabled = false;
                i_Rscore_C2[i].enabled = false;
                i_Rscore_C3[i].enabled = false;
            }
        }

        else if (isBT && !isCT && !isAT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(true);
            g_PScore[2].SetActive(false);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(false);
            g_OffScore[2].SetActive(true);

            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(true);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);

            g_Playerbar[1].GetComponent<Image>().sprite = s_OnPlayer[0];
            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[0];
            g_Playerbar[2].GetComponent<Image>().sprite = s_OffPlayer[0];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_OffTeambar[2];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_B1.enabled = true;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_C1.enabled = false;
            t_PPDText_C2.enabled = false;
            t_PPDText_C3.enabled = false;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_B1[i].enabled = true;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_C1[i].enabled = false;
                i_Rscore_C2[i].enabled = false;
                i_Rscore_C3[i].enabled = false;
            }
        }

        else if (isCT && !isAT && !isBT && Players == 0)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(1f, 1f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(false);
            g_PScore[2].SetActive(true);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(false);

            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(true);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);

            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[0];
            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[0];
            g_Playerbar[2].GetComponent<Image>().sprite = s_OnPlayer[0];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_OnTeambar[2];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_C1.enabled = true;
            t_PPDText_C2.enabled = false;
            t_PPDText_C3.enabled = false;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_C1[i].enabled = true;
                i_Rscore_C2[i].enabled = false;
                i_Rscore_C3[i].enabled = false;
            }
        }

        else if (isAT && !isBT && !isCT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);
            g_PScore[2].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);

            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(true);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OnPlayer[1];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[1];
            g_Playerbar[2].GetComponent<Image>().sprite = s_OffPlayer[1];

            g_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_OffTeambar[2];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = true;
            t_PPDText_A3.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_C1.enabled = false;
            t_PPDText_C2.enabled = false;
            t_PPDText_C3.enabled = false;

            for (int i = 0; i < i_Rscore_A1.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = true;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_C1[i].enabled = false;
                i_Rscore_C2[i].enabled = false;
                i_Rscore_C3[i].enabled = false;
            }
        }

        else if (isBT && !isCT && !isAT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(true);
            g_PScore[2].SetActive(false);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(false);
            g_OffScore[2].SetActive(true);

            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);//
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(true);
            g_RScore[5].SetActive(false);//
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[1];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OnPlayer[1];
            g_Playerbar[2].GetComponent<Image>().sprite = s_OffPlayer[1];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_OffTeambar[2];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = true;
            t_PPDText_B3.enabled = false;
            t_PPDText_C1.enabled = false;
            t_PPDText_C2.enabled = false;
            t_PPDText_C3.enabled = false;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = true;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_C1[i].enabled = false;
                i_Rscore_C2[i].enabled = false;
                i_Rscore_C3[i].enabled = false;
            }
        }

        else if (isCT && !isAT && !isBT && Players == 1)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(1f, 1f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(false);
            g_PScore[2].SetActive(true);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(false);

            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(true);
            g_RScore[8].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[1];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[1];
            g_Playerbar[2].GetComponent<Image>().sprite = s_OnPlayer[1];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_OnTeambar[2];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_C1.enabled = false;
            t_PPDText_C2.enabled = true;
            t_PPDText_C3.enabled = false;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_C1[i].enabled = false;
                i_Rscore_C2[i].enabled = true;
                i_Rscore_C3[i].enabled = false;
            }
        }

        else if (isAT && !isBT && !isCT && Players == 2)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, -10f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(1f, 1f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(true);
            g_PScore[1].SetActive(false);
            g_PScore[2].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);

            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);
            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(true);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OnPlayer[2];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[2];
            g_Playerbar[2].GetComponent<Image>().sprite = s_OffPlayer[2];

            g_Teambar[0].GetComponent<Image>().sprite = s_OnTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_OffTeambar[2];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = true;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_C1.enabled = false;
            t_PPDText_C2.enabled = false;
            t_PPDText_C3.enabled = false;

            for (int i = 0; i < i_Rscore_A1.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = true;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_C1[i].enabled = false;
                i_Rscore_C2[i].enabled = false;
                i_Rscore_C3[i].enabled = false;
            }
        }

        else if (isBT && !isCT && !isAT && Players == 2)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, -10f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, 0f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(1f, 1f);
            g_CT.transform.localScale = new Vector3(0.75f, 0.75f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(true);
            g_PScore[2].SetActive(false);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(false);
            g_OffScore[2].SetActive(true);

            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
            g_OffScore[2].GetComponent<csNumber>().SetNumber(TeamScore[2]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);//
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(true);//
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(false);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[2];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OnPlayer[2];
            g_Playerbar[2].GetComponent<Image>().sprite = s_OffPlayer[2];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OnTeambar[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_OffTeambar[2];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = true;
            t_PPDText_C1.enabled = false;
            t_PPDText_C2.enabled = false;
            t_PPDText_C3.enabled = false;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = true;
                i_Rscore_C1[i].enabled = false;
                i_Rscore_C2[i].enabled = false;
                i_Rscore_C3[i].enabled = false;
            }
        }

        else if (isCT && !isAT && !isBT && Players == 2)
        {
            g_AT.transform.position = new Vector3(g_AT.transform.position.x, g_AT.transform.position.y, 0f);
            g_BT.transform.position = new Vector3(g_BT.transform.position.x, g_BT.transform.position.y, 0f);
            g_CT.transform.position = new Vector3(g_CT.transform.position.x, g_CT.transform.position.y, -10f);

            g_AT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_BT.transform.localScale = new Vector3(0.75f, 0.75f);
            g_CT.transform.localScale = new Vector3(1f, 1f);

            g_PScore[0].SetActive(false);
            g_PScore[1].SetActive(false);
            g_PScore[2].SetActive(true);

            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(false);

            g_OffScore[0].GetComponent<csNumber>().SetNumber(TeamScore[0]);
            g_OffScore[1].GetComponent<csNumber>().SetNumber(TeamScore[1]);

            g_RScore[0].SetActive(false);
            g_RScore[1].SetActive(false);
            g_RScore[2].SetActive(false);
            g_RScore[3].SetActive(false);
            g_RScore[4].SetActive(false);
            g_RScore[5].SetActive(false);
            g_RScore[6].SetActive(false);
            g_RScore[7].SetActive(false);
            g_RScore[8].SetActive(true);

            g_Playerbar[0].GetComponent<Image>().sprite = s_OffPlayer[2];
            g_Playerbar[1].GetComponent<Image>().sprite = s_OffPlayer[2];
            g_Playerbar[2].GetComponent<Image>().sprite = s_OnPlayer[2];

            g_Teambar[0].GetComponent<Image>().sprite = s_OffTeambar[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_OffTeambar[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_OnTeambar[2];

            t_PPDText_A1.enabled = false;
            t_PPDText_A2.enabled = false;
            t_PPDText_A3.enabled = false;
            t_PPDText_B1.enabled = false;
            t_PPDText_B2.enabled = false;
            t_PPDText_B3.enabled = false;
            t_PPDText_C1.enabled = false;
            t_PPDText_C2.enabled = false;
            t_PPDText_C3.enabled = true;

            for (int i = 0; i < i_Rscore_A2.Length; i++)
            {
                i_Rscore_A1[i].enabled = false;
                i_Rscore_A2[i].enabled = false;
                i_Rscore_A3[i].enabled = false;
                i_Rscore_B1[i].enabled = false;
                i_Rscore_B2[i].enabled = false;
                i_Rscore_B3[i].enabled = false;
                i_Rscore_C1[i].enabled = false;
                i_Rscore_C2[i].enabled = false;
                i_Rscore_C3[i].enabled = true;
            }
        }



    }

    void TeamNumberPlus()
    {
        g_MScore[Teams].SetActive(false);
        g_PScore[Teams].SetActive(false);
        isRead = false;
        g_CAni.SetActive(false);
        Counting = 0;
        Teams += 1;
        if (Teams == 0)
        {
            isAT = true;
            isBT = false;
            isCT = false;
        }
        else if (Teams == 1)
        {
            isAT = false;
            isBT = true;
            isCT = false;
        }
        else if (Teams == 2)
        {
            isAT = false;
            isBT = false;
            isCT = true;
        }
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
        isCT = false;
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
        isCT = false;
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
        if (isAT && !isBT && !isCT && Players == 0)
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
        else if (isAT && !isBT && !isCT && Players == 1)
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
        else if (isAT && !isBT && !isCT && Players == 2)
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
        else if (isBT && !isCT && !isAT && Players == 0)
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
        else if (isBT && !isCT && !isAT && Players == 1)
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
        else if (isBT && !isCT && !isAT && Players == 2)
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
        else if (isCT && !isAT && !isBT && Players == 0)
        {
            C1_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_C1[0].text = C1_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_C1[1].text = C1_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_C1[2].text = C1_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_C1[3].text = C1_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_C1[4].text = C1_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_C1[0].text = C1_ScoreSave[1].ToString();
                    t_RScoreText_C1[1].text = C1_ScoreSave[2].ToString();
                    t_RScoreText_C1[2].text = C1_ScoreSave[3].ToString();
                    t_RScoreText_C1[3].text = C1_ScoreSave[4].ToString();
                    t_RScoreText_C1[4].text = C1_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_C1[0].text = C1_ScoreSave[2].ToString();
                    t_RScoreText_C1[1].text = C1_ScoreSave[3].ToString();
                    t_RScoreText_C1[2].text = C1_ScoreSave[4].ToString();
                    t_RScoreText_C1[3].text = C1_ScoreSave[5].ToString();
                    t_RScoreText_C1[4].text = C1_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_C1[0].text = C1_ScoreSave[3].ToString();
                    t_RScoreText_C1[1].text = C1_ScoreSave[4].ToString();
                    t_RScoreText_C1[2].text = C1_ScoreSave[5].ToString();
                    t_RScoreText_C1[3].text = C1_ScoreSave[6].ToString();
                    t_RScoreText_C1[4].text = C1_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_C1[0].text = C1_ScoreSave[4].ToString();
                    t_RScoreText_C1[1].text = C1_ScoreSave[5].ToString();
                    t_RScoreText_C1[2].text = C1_ScoreSave[6].ToString();
                    t_RScoreText_C1[3].text = C1_ScoreSave[7].ToString();
                    t_RScoreText_C1[4].text = C1_ScoreSave[8].ToString();
                }
            }
        }
        else if (isCT && !isAT && !isBT && Players == 1)
        {
            C2_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_C2[0].text = C2_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_C2[1].text = C2_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_C2[2].text = C2_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_C2[3].text = C2_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_C2[4].text = C2_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_C2[0].text = C2_ScoreSave[1].ToString();
                    t_RScoreText_C2[1].text = C2_ScoreSave[2].ToString();
                    t_RScoreText_C2[2].text = C2_ScoreSave[3].ToString();
                    t_RScoreText_C2[3].text = C2_ScoreSave[4].ToString();
                    t_RScoreText_C2[4].text = C2_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_C2[0].text = C2_ScoreSave[2].ToString();
                    t_RScoreText_C2[1].text = C2_ScoreSave[3].ToString();
                    t_RScoreText_C2[2].text = C2_ScoreSave[4].ToString();
                    t_RScoreText_C2[3].text = C2_ScoreSave[5].ToString();
                    t_RScoreText_C2[4].text = C2_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_C2[0].text = C2_ScoreSave[3].ToString();
                    t_RScoreText_C2[1].text = C2_ScoreSave[4].ToString();
                    t_RScoreText_C2[2].text = C2_ScoreSave[5].ToString();
                    t_RScoreText_C2[3].text = C2_ScoreSave[6].ToString();
                    t_RScoreText_C2[4].text = C2_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_C2[0].text = C2_ScoreSave[4].ToString();
                    t_RScoreText_C2[1].text = C2_ScoreSave[5].ToString();
                    t_RScoreText_C2[2].text = C2_ScoreSave[6].ToString();
                    t_RScoreText_C2[3].text = C2_ScoreSave[7].ToString();
                    t_RScoreText_C2[4].text = C2_ScoreSave[8].ToString();
                }
            }
        }
        else if (isCT && !isAT && !isBT && Players == 2)
        {
            C3_ScoreSave[RScore] = n;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_RScoreText_C3[0].text = C3_ScoreSave[0].ToString();
                else if (RScore == 1)
                    t_RScoreText_C3[1].text = C3_ScoreSave[1].ToString();
                else if (RScore == 2)
                    t_RScoreText_C3[2].text = C3_ScoreSave[2].ToString();
                else if (RScore == 3)
                    t_RScoreText_C3[3].text = C3_ScoreSave[3].ToString();
                else if (RScore == 4)
                    t_RScoreText_C3[4].text = C3_ScoreSave[4].ToString();
                else if (RScore == 5)
                {
                    t_RScoreText_C3[0].text = C3_ScoreSave[1].ToString();
                    t_RScoreText_C3[1].text = C3_ScoreSave[2].ToString();
                    t_RScoreText_C3[2].text = C3_ScoreSave[3].ToString();
                    t_RScoreText_C3[3].text = C3_ScoreSave[4].ToString();
                    t_RScoreText_C3[4].text = C3_ScoreSave[5].ToString();
                }
                else if (RScore == 6)
                {
                    t_RScoreText_C3[0].text = C3_ScoreSave[2].ToString();
                    t_RScoreText_C3[1].text = C3_ScoreSave[3].ToString();
                    t_RScoreText_C3[2].text = C3_ScoreSave[4].ToString();
                    t_RScoreText_C3[3].text = C3_ScoreSave[5].ToString();
                    t_RScoreText_C3[4].text = C3_ScoreSave[6].ToString();
                }
                else if (RScore == 7)
                {
                    t_RScoreText_C3[0].text = C3_ScoreSave[3].ToString();
                    t_RScoreText_C3[1].text = C3_ScoreSave[4].ToString();
                    t_RScoreText_C3[2].text = C3_ScoreSave[5].ToString();
                    t_RScoreText_C3[3].text = C3_ScoreSave[6].ToString();
                    t_RScoreText_C3[4].text = C3_ScoreSave[7].ToString();
                }
                else if (RScore == 8)
                {
                    t_RScoreText_C3[0].text = C3_ScoreSave[4].ToString();
                    t_RScoreText_C3[1].text = C3_ScoreSave[5].ToString();
                    t_RScoreText_C3[2].text = C3_ScoreSave[6].ToString();
                    t_RScoreText_C3[3].text = C3_ScoreSave[7].ToString();
                    t_RScoreText_C3[4].text = C3_ScoreSave[8].ToString();
                }
            }
        }
    }
    public void RScoreImageUp()
    {
        if (isAT && !isBT && !isCT && Players == 0)
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
        if (isAT && !isBT && !isCT && Players == 1)
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
        if (isAT && !isBT && !isCT && Players == 2)
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
        if (isBT && !isCT && !isAT && Players == 0)
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
        if (isBT && !isCT && !isAT && Players == 1)
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
        if (isBT && !isCT && !isAT && Players == 2)
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
        if (isCT && !isAT && !isBT && Players == 0)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_C1[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_C1[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_C1[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_C1[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C1[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_C1[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_C1[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_C1[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C1[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_C1[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_C1[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_C1[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C1[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_C1[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_C1[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_C1[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C1[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_C1[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_C1[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_C1[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        if (isCT && !isAT && !isBT && Players == 1)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_C2[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_C2[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_C2[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_C2[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C2[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_C2[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_C2[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_C2[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C2[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_C2[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_C2[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_C2[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C2[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_C2[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_C2[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_C2[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C2[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_C2[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_C2[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_C2[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
        if (isCT && !isAT && !isBT && Players == 2)
        {
            if (Round <= RoundStop)
            {
                if (RScore == 5)
                {
                    i_Rscore_C3[0].GetComponent<Image>().sprite = s_RScore[1];
                    i_Rscore_C3[1].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_C3[2].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_C3[3].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C3[4].GetComponent<Image>().sprite = s_RScore[5];
                }
                if (RScore == 6)
                {
                    i_Rscore_C3[0].GetComponent<Image>().sprite = s_RScore[2];
                    i_Rscore_C3[1].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_C3[2].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C3[3].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_C3[4].GetComponent<Image>().sprite = s_RScore[6];
                }
                if (RScore == 7)
                {
                    i_Rscore_C3[0].GetComponent<Image>().sprite = s_RScore[3];
                    i_Rscore_C3[1].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C3[2].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_C3[3].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_C3[4].GetComponent<Image>().sprite = s_RScore[7];
                }
                if (RScore == 8)
                {
                    i_Rscore_C3[0].GetComponent<Image>().sprite = s_RScore[4];
                    i_Rscore_C3[1].GetComponent<Image>().sprite = s_RScore[5];
                    i_Rscore_C3[2].GetComponent<Image>().sprite = s_RScore[6];
                    i_Rscore_C3[3].GetComponent<Image>().sprite = s_RScore[7];
                    i_Rscore_C3[4].GetComponent<Image>().sprite = s_RScore[8];
                }
            }
        }
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

    void GameEndRead()
    {
        if (TeamScore[1] < TeamScore[0] && TeamScore[2] < TeamScore[0])
        {
            win = 0;
            isAT = true;
            isBT = false;
            isCT = false;
            isEnd = true;
            gmg.GameEnd(win);
        }
        if (TeamScore[0] < TeamScore[1] && TeamScore[2] < TeamScore[1])
        {
            win = 1;
            isBT = true;
            isAT = false;
            isCT = false;
            isEnd = true;
            gmg.GameEnd(win);
        }
        if (TeamScore[0] < TeamScore[2] && TeamScore[1] < TeamScore[2])
        {
            win = 2;
            isCT = true;
            isAT = false;
            isBT = false;
            isEnd = true;
            gmg.GameEnd(win);
        }
        if (TeamScore[0] == TeamScore[1] && TeamScore[0] == TeamScore[2] && TeamScore[1] == TeamScore[2])
        {
            if (CT_Average < AT_Average && BT_Average < AT_Average)
            {
                isEnd = true;
                isAT = true;
                isBT = false;
                isCT = false;
                gmg.GameEnd(win);
            }
            if (AT_Average < BT_Average && CT_Average < BT_Average)
            {
                isEnd = true;
                isAT = false;
                isBT = true;
                isCT = false;
                gmg.GameEnd(win);
            }
            if (AT_Average < CT_Average && BT_Average < CT_Average)
            {
                isEnd = true;
                isAT = false;
                isBT = false;
                isCT = true;
                gmg.GameEnd(win);
            }
            if (TeamScore[0] == TeamScore[1] && TeamScore[0] == TeamScore[2] && TeamScore[1] == TeamScore[2])
            {
                if (CT_Average < AT_Average && BT_Average < AT_Average)
                {
                    isEnd = true;
                    isAT = true;
                    isBT = false;
                    isCT = false;
                    gmg.GameEnd(win);
                } //A
                if (AT_Average < BT_Average && CT_Average < BT_Average)
                {
                    isEnd = true;
                    isAT = false;
                    isBT = true;
                    isCT = false;
                    gmg.GameEnd(win);
                } //B
                if (AT_Average < CT_Average && BT_Average < CT_Average)
                {
                    isEnd = true;
                    isAT = false;
                    isBT = false;
                    isCT = true;
                    gmg.GameEnd(win);
                } //C
                if (BT_Average == AT_Average && CT_Average == AT_Average)
                {
                    isEnd = true;
                    isAT = true;
                    isBT = false;
                    isCT = false;
                    gmg.GameEnd(win);
                } //ALL
                if (AT_Average == BT_Average && AT_Average != CT_Average && BT_Average != CT_Average)
                {
                    isEnd = true;
                    isAT = true;
                    isBT = false;
                    isCT = false;
                    gmg.GameEnd(win);
                } //AB
                if (AT_Average == CT_Average && AT_Average != BT_Average && CT_Average != BT_Average)
                {
                    isEnd = true;
                    isAT = true;
                    isBT = false;
                    isCT = false;
                    gmg.GameEnd(win);
                } //AC
                if (BT_Average == CT_Average && AT_Average != CT_Average && AT_Average != BT_Average)
                {
                    isEnd = true;
                    isAT = false;
                    isBT = true;
                    isCT = false;
                    gmg.GameEnd(win);
                } //BC
            } //ALL
            if (TeamScore[0] == TeamScore[1] && TeamScore[1] != TeamScore[2] && TeamScore[0] != TeamScore[2])
            {
                if (BT_Average < AT_Average)
                {
                    isEnd = true;
                    isAT = true;
                    isBT = false;
                    isCT = false;
                    gmg.GameEnd(win);
                }
                if (AT_Average < BT_Average)
                {
                    isEnd = true;
                    isAT = false;
                    isBT = true;
                    isCT = false;
                    gmg.GameEnd(win);
                }
                if (AT_Average == BT_Average)
                {
                    isEnd = true;
                    isAT = true;
                    isBT = false;
                    isCT = false;
                    gmg.GameEnd(win);
                }
            } //AB
            if (TeamScore[0] == TeamScore[2] && TeamScore[0] != TeamScore[1] && TeamScore[1] != TeamScore[2])
            {
                if (CT_Average < AT_Average)
                {
                    isEnd = true;
                    isAT = true;
                    isBT = false;
                    isCT = false;
                    gmg.GameEnd(win);
                }
                if (AT_Average < CT_Average)
                {
                    isEnd = true;
                    isAT = false;
                    isBT = false;
                    isCT = true;
                    gmg.GameEnd(win);
                }
                if (AT_Average == CT_Average)
                {
                    isEnd = true;
                    isAT = true;
                    isBT = false;
                    isCT = false;
                    gmg.GameEnd(win);
                }
            } //AC
            if (TeamScore[1] == TeamScore[2] && TeamScore[0] != TeamScore[1] && TeamScore[0] != TeamScore[2])
            {
                if (CT_Average < BT_Average)
                {
                    isEnd = true;
                    isAT = false;
                    isBT = true;
                    isCT = false;
                    gmg.GameEnd(win);
                }
                if (BT_Average < CT_Average)
                {
                    isEnd = true;
                    isAT = false;
                    isBT = false;
                    isCT = true;
                    gmg.GameEnd(win);
                }
                if (CT_Average == BT_Average)
                {
                    isEnd = true;
                    isAT = false;
                    isBT = true;
                    isCT = false;
                    gmg.GameEnd(win);
                }
            } //BC
        }
        if (TeamScore[0] == TeamScore[1] && TeamScore[1] != TeamScore[2] && TeamScore[0] != TeamScore[2])
        {
            if (BT_Average < AT_Average)
            {
                isEnd = true;
                isAT = true;
                isBT = false;
                isCT = false;
                gmg.GameEnd(win);
            }
            if (AT_Average < BT_Average)
            {
                isEnd = true;
                isAT = false;
                isBT = true;
                isCT = false;
                gmg.GameEnd(win);
            }
            if (AT_Average == BT_Average)
            {
                isEnd = true;
                isAT = true;
                isBT = false;
                isCT = false;
                gmg.GameEnd(win);
            }
        }
        if (TeamScore[0] == TeamScore[2] && TeamScore[0] != TeamScore[1] && TeamScore[1] != TeamScore[2])
        {
            if (CT_Average < AT_Average)
            {
                isEnd = true;
                isAT = true;
                isBT = false;
                isCT = false;
                gmg.GameEnd(win);
            }
            if (AT_Average < CT_Average)
            {
                isEnd = true;
                isAT = false;
                isBT = false;
                isCT = true;
                gmg.GameEnd(win);
            }
            if (AT_Average == CT_Average)
            {
                isEnd = true;
                isAT = true;
                isBT = false;
                isCT = false;
                gmg.GameEnd(win);
            }
        }
        if (TeamScore[1] == TeamScore[2] && TeamScore[0] != TeamScore[1] && TeamScore[0] != TeamScore[2])
        {
            if (CT_Average < BT_Average)
            {
                isEnd = true;
                isAT = false;
                isBT = true;
                isCT = false;
                gmg.GameEnd(win);
            }
            if (BT_Average < CT_Average)
            {
                isEnd = true;
                isAT = false;
                isBT = false;
                isCT = true;
                gmg.GameEnd(win);
            }
            if (CT_Average == BT_Average)
            {
                isEnd = true;
                isAT = false;
                isBT = true;
                isCT = false;
                gmg.GameEnd(win);
            }
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

        else if (Teams == 2 && Players == 0)
        {
            C1_DartTotal += n;
            C1_Average = C1_DartTotal / C1_AverageCounting;
            t_PPDText_C1.text = string.Format("{0:N2}", C1_Average);
        }
        else if (Teams == 2 && Players == 1)
        {
            C2_DartTotal += n;
            C2_Average = C2_DartTotal / C2_AverageCounting;
            t_PPDText_C2.text = string.Format("{0:N2}", C2_Average);
        }
        else if (Teams == 2 && Players == 2)
        {
            C3_DartTotal += n;
            C3_Average = C3_DartTotal / C3_AverageCounting;
            t_PPDText_C3.text = string.Format("{0:N2}", C3_Average);
        }

        if (Teams == 0)
            AT_Average = A1_Average + A2_Average+A3_Average / 3;
        else if (Teams == 1)
            BT_Average = B1_Average + B2_Average+B3_Average / 3;
        else if (Teams == 2)
            CT_Average = C1_Average + C2_Average+C3_Average / 3;
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
        else if (m_oDartInfo[0].nLine == 2 && m_oDartInfo[1].nLine == 2 && m_oDartInfo[2].nLine == 2 &&
                      m_oDartInfo[0].nScore != m_oDartInfo[1].nScore && m_oDartInfo[0].nScore != m_oDartInfo[2].nScore && m_oDartInfo[1].nScore != m_oDartInfo[2].nScore)
        {//white horse
            gmg.MoviePlay(6);
        }
        else
            return 0;
        return 0;
    }
}
