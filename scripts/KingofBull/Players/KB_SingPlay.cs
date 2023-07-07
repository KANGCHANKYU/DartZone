using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KB_SingPlay : MonoBehaviour
{
    public Text t_Round;
    public Text t_PPDScore;
    public Text[] t_RScore = new Text[5];
    public Image[] i_RScore = new Image[5];

    public GameObject[] g_Dart = new GameObject[3];
    public GameObject[] g_RoundNum = new GameObject[8];
    public GameObject g_PAni;
    public GameObject g_RAni;
    public GameObject g_DAni;
    public GameObject g_CAni;
    public GameObject g_RoundOn;
    public GameObject g_RoundR;
    public GameObject g_PScore;
    public GameObject g_MScore;
    public GameObject g_P1;

    public Sprite s_OnDart;
    public Sprite s_OffDart;
    public Sprite[] s_RScore = new Sprite[8];

    public AudioSource a_source;
    public AudioClip ac_shoot1;
    public AudioClip ac_shoot2;

    public int Counting = 0;
    public int Round = 0;
    public int RoundStop = 8;
    public int DartTotal = 0;
    public int RScore = 0;
    public int PlayerScore = 0;
    public int Average = 0;
    public int AverageCounting = 0;
    public int[] DartScore = new int[3];
    public int[] DartBasicScore = new int[3];
    public int[] ScoreSave = new int[8];

    public string player1;

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
        if(csSingleton.getInstance.g_bTarget)
        {
            csSingleton.getInstance.g_bTarget = false;
            if(csSingleton.getInstance.g_nTargetBasicScore==25 || csSingleton.getInstance.g_nTargetBasicScore==50)
            {
                if(Round<RoundStop)
                {
                    if(Counting==0 && !isRead && !isSpace)
                    {
                        AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[0]);
                        PlayerScore += DartScore[0];
                        RoundScore(DartScore[0]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        g_PScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        Counting = 1;
                    }
                    else if(Counting==1 && !isRead &&!isSpace)
                    {
                        AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[1]);
                        PlayerScore += DartScore[1];
                        RoundScore(DartScore[1]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        g_MScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        g_PScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        Counting = 2;
                    }
                    else if(Counting==2 && !isRead && !isSpace)
                    {
                        AverageCounting++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        PPDScore(DartScore[2]);
                        PlayerScore += DartScore[2];
                        RoundScore(DartScore[2]);
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        g_MScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        g_PScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        Counting = 3;
                    }             
                }             
            }
            else
            {
                if (Counting !=3)
                {
                    AverageCounting++;
                    a_source.PlayOneShot(ac_shoot1, 1.0f);              
                    PPDScore(0);
                    RoundScore(0);
                    g_MScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                    g_PScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                    if (Counting == 0)
                    {
                        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        g_MScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        g_PScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        Counting = 1;
                    }
                    else if (Counting == 1)
                    {
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        g_MScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        g_PScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        Counting = 2;
                    }
                    else if (Counting == 2)
                    {
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        gmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        g_MScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        g_PScore.GetComponent<csNumber>().SetNumber(PlayerScore);
                        Counting = 3;
                    }
                }
            }
            if (Counting == 3 && !isRead && !isSpace)
            {
                if (Round < RoundStop)
                {
                    GetMovie();
                    g_MScore.SetActive(false);
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
        if(Input.GetKeyDown(KeyCode.Space) && gmg.isAni==false && isSpace && Counting==4)
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
        }
        if(isEnd)
        {
            gmg.GameEnd(0);
        }
    }

    void FistStart()
    {
        isRead = true;
        for (int i = 0; i < g_Dart.Length; i++)
            g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
        g_MScore.GetComponent<csNumber>().CreateNumber(4, 250, 3f, 0);
        g_PScore.GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
        g_MScore.GetComponent<csNumber>().SetNumber(PlayerScore);
        g_PScore.GetComponent<csNumber>().SetNumber(PlayerScore);
        g_RAni.SetActive(true);
        g_RoundOn.SetActive(true);
        g_RoundNum[Round].SetActive(true);
        g_RoundR.SetActive(true);
        g_CAni.SetActive(false);
        g_PAni.SetActive(false);
        g_MScore.SetActive(false);
        Invoke("FistAniStop", 1.5f);
    }
    void FistAniStop()
    {
        g_RAni.SetActive(false);
        g_RoundOn.SetActive(false);
        g_RoundNum[Round].SetActive(false);
        g_RoundR.SetActive(false);
        g_MScore.SetActive(true);
        g_MScore.GetComponent<csNumber>().SetNumber(PlayerScore);
        Round = 1;
        t_Round.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    public void RoundScore(int n)
    {
        ScoreSave[RScore] += n;
        if (Round <= RoundStop)
        {
            if (RScore == 0)
                t_RScore[0].text = ScoreSave[0].ToString();
            else if (RScore == 1)
                t_RScore[1].text = ScoreSave[1].ToString();
            else if (RScore == 2)
                t_RScore[2].text = ScoreSave[2].ToString();
            else if (RScore == 3)
                t_RScore[3].text = ScoreSave[3].ToString();
            else if (RScore == 4)
                t_RScore[4].text = ScoreSave[4].ToString();
            else if (RScore == 5)
            {
                t_RScore[0].text = ScoreSave[1].ToString();
                t_RScore[1].text = ScoreSave[2].ToString();
                t_RScore[2].text = ScoreSave[3].ToString();
                t_RScore[3].text = ScoreSave[4].ToString();
                t_RScore[4].text = ScoreSave[5].ToString();
            }
            else if (RScore == 6)
            {
                t_RScore[0].text = ScoreSave[2].ToString();
                t_RScore[1].text = ScoreSave[3].ToString();
                t_RScore[2].text = ScoreSave[4].ToString();
                t_RScore[3].text = ScoreSave[5].ToString();
                t_RScore[4].text = ScoreSave[6].ToString();
            }
            else if (RScore == 7)
            {
                t_RScore[0].text = ScoreSave[3].ToString();
                t_RScore[1].text = ScoreSave[4].ToString();
                t_RScore[2].text = ScoreSave[5].ToString();
                t_RScore[3].text = ScoreSave[6].ToString();
                t_RScore[4].text = ScoreSave[7].ToString();
            }
            else if (RScore == 8)
            {
                t_RScore[0].text = ScoreSave[4].ToString();
                t_RScore[1].text = ScoreSave[5].ToString();
                t_RScore[2].text = ScoreSave[6].ToString();
                t_RScore[3].text = ScoreSave[7].ToString();
                t_RScore[4].text = ScoreSave[8].ToString();
            }
        }
    }
    public void RScoreImageUp()
    {
        if (RScore == 5)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[1];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[2];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[3];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[4];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[5];
            t_RScore[4].text = "0".ToString();
        }
        if (RScore == 6)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[2];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[3];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[4];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[5];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[6];
            t_RScore[4].text = "0".ToString();
        }
        if (RScore == 7)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[3];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[4];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[5];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[6];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[7];
            t_RScore[4].text = "0".ToString();
        }
        if (RScore == 8)
        {
            i_RScore[0].GetComponent<Image>().sprite = s_RScore[4];
            i_RScore[1].GetComponent<Image>().sprite = s_RScore[5];
            i_RScore[2].GetComponent<Image>().sprite = s_RScore[6];
            i_RScore[3].GetComponent<Image>().sprite = s_RScore[7];
            i_RScore[4].GetComponent<Image>().sprite = s_RScore[8];
            t_RScore[4].text = "0".ToString();
        }
    }

    public void RoundRead()
    {
        g_PScore.GetComponent<csNumber>().SetNumber(PlayerScore);
        g_CAni.SetActive(true);
        g_MScore.SetActive(false);
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
        g_MScore.SetActive(true);
        g_MScore.GetComponent<csNumber>().SetNumber(PlayerScore);
        Round += 1;
        RScore += 1;
        t_Round.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void PPDScore(int n)
    {
        DartTotal += n;
        Average = DartTotal / AverageCounting;
        t_PPDScore.text = string.Format("{0:N2}", Average);
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
