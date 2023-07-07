using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PT_01tir33 : MonoBehaviour
{
    public Text t_RoundText; //라운드 텍스트
    public Text[] t_PPDText = new Text[6]; //각각 ppd 
    public Text[] t_TA1RScoreText = new Text[5]; //A팀의 1 플레이어의 라운드 스코어
    public Text[] t_TA2RScoreText = new Text[5]; //A팀의 2플레이어의 라운드 스코어
    public Text[] t_TA3RScoreText = new Text[5]; //A팀의 3플레이어의 라운드 스코어
    public Text[] t_TB1RScoreText = new Text[5]; //B팀의 1플레이어의 라운드 스코어
    public Text[] t_TB2RScoreText = new Text[5]; //B팀의 2플레이어의 라운드 스코어
    public Text[] t_TB3RScoreText = new Text[5]; //B팀의 3플레이어의 라운드 스코어

    public Sprite s_OnDart; //다트 On이미지
    public Sprite s_OffDart; //다트 Off 이미지
    public Sprite[] s_RScore = new Sprite[20]; //라운드 스코어의 이미지 1~20
    public Sprite[] s_TeamOn = new Sprite[3]; //자기팀의 자기차레의일떄 차레 숫자on
    public Sprite[] s_TeamOff = new Sprite[3]; //자기팀의 차레가아닐떄 off 할 숫자 이미지
    public Sprite[] s_TeambarOn = new Sprite[2]; //팀 바 이미지 on
    public Sprite[] s_TeambarOff = new Sprite[2]; //팀 바 이미지 off

    public Image[] i_RScoreA1 = new Image[5]; //A팀의 1플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreA2 = new Image[5]; //A팀의 2플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreA3 = new Image[5]; //A팀의 3플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreB1 = new Image[5]; //B팀의 1플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreB2 = new Image[5]; //B팀의 2플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreB3 = new Image[5]; //B팀의 3플레이어의 라운드 스코어의 이미지

    public GameObject[] g_i_Player = new GameObject[2]; //팀 마다 플레이어의 순서이미지를 가지고있는 부모
    public GameObject[] g_Dart = new GameObject[3]; //다트 이미지를 가지고있는 부모
    public GameObject[] g_RoundScore = new GameObject[6]; //각 플레이어의 라운드 스코어를 가지고있는 부모
    public GameObject[] g_PPDScore = new GameObject[6]; //각 플레이어의 PPD 스코어를 가지고있는 부모
    public GameObject[] g_RoundNum = new GameObject[21]; //각 라운드의 숫자의 이미지를 가지고있는 부모
    public GameObject[] g_M_Score = new GameObject[2]; // 각 팀의 메인 큰 스코어
    public GameObject[] g_T_Score = new GameObject[2]; // 각 팀의 스코어
    public GameObject[] g_OffScore = new GameObject[2]; // 각 팀의 off 상태일떄 스코어
    public GameObject[] g_Teambar = new GameObject[2]; //각 팀의 바 이미지를 가지고있는 부모

    public GameObject g_TeamA; //A팀의 부모
    public GameObject g_TeamB; //B의 부모
    public GameObject g_G_Bust; //버스트 상태를 알려줄 애니
    public GameObject g_D_Ani; //특정 점수마다 다트 애니
    public GameObject g_C_Ani;// 플레이어와 플레이어가 바뀔떄 나올 애니
    public GameObject g_R_Ani;//각 라운드가 바뀔떄 나오는 애니
    public GameObject g_P_Ani;// 라운드가 끝날떄 다음라운드로 넘어가기위해 버튼을 누르라는 표시
    public GameObject g_RoundOn; //라운드가 바뀔떄마다 라운드 이미지의 부모
    public GameObject g_RoundR; // 라운드라고 알려줄 변수

    public AudioSource a_source; //메인카메라의 오디오소스
    public AudioClip ac_shoot1; //다트가 들어왔다고 알려줄 클립
    public AudioClip ac_shoot2;// 차레가 끝났다고 알려줄 클립

    public int RoundStop = 0; //게임매니저에서 정해진 라운드수를 저장할 변수
    public int DefultScore = 0; //게임매니저에서 정해진 스코어를 저장할 변수

    public int Counting = 0; //다트를 얼마나 던졌는지 카운팅할 변수
    public int Round = 0; //실시간라운드수를 가지고있는 변수
    public int TeamBasicScore = 0;
    public int DartCountA1 = 0; //A팀의 1플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountA2 = 0;//A팀의 2플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountA3 = 0;//A팀의 3플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountB1 = 0; //B팀의 1플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountB2 = 0;//B팀의 2플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountB3 = 0;//B팀의 3플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int RScore = 0; //라운드가 끝날떄마다 증가를 해 라운드 스코어를 저장할 이미지를 한칸씩 올려주기위한 변수
    public int Teams = 0; // 0이면 A팀 1이면 B팀을 알려줄 변수
    public int Players = 0; //P=0이면 팀의 1플레이어 P=1 이면 팀의 2플레이어
    public int TotalA1 = 0; //A팀의 1플레이어의 총합점수
    public int TotalA2 = 0; //A팀의 2플레이어의 총합점수
    public int TotalA3 = 0; //A팀의 3플레이어의 총합점수
    public int TotalB1 = 0; //B팀의 1플레이어의 총합점수
    public int TotalB2 = 0; //B팀의 2플레이어의 총합점수
    public int TotalB3 = 0; //B팀의 2플레이어의 총합점수
    public int win = 0; //0이면 A팀 1이면 B팀이 이겼다고 알려줄 변수

    public int[] DartBasicScore = new int[3];
    public int[] DartScore = new int[3]; //다트1의 점수를 저장할 변수
    public int[] TeamScore = new int[2]; //각팀의 점수를 저장할 변수
    public int[] Bustscore = new int[2]; //버스트가 될경우 전라운드 스코어를 저장을 해줄 변수
    public int[] ScoreSaveA1 = new int[20]; //A팀의 1플레이어의 각라운드 스코어를 저장해줄 변수
    public int[] ScoreSaveA2 = new int[20]; //A팀의 2플레이어의 각라운드 스코어를 저장해줄 변수
    public int[] ScoreSaveA3 = new int[20]; //A팀의 3플레이어의 각라운드 스코어를 저장해줄 변수
    public int[] ScoreSaveB1 = new int[20]; //B팀의 1플레이어의 각라운드 스코어를 저장해줄 변수
    public int[] ScoreSaveB2 = new int[20]; //B팀의 2플레이어의 각라운드 스코어를 저장해줄 변수
    public int[] ScoreSaveB3 = new int[20]; //B팀의 3플레이어의 각라운드 스코어를 저장해줄 변수

    public float AverageA1 = 0; //A팀의 1플레이어의 평균값
    public float AverageA2 = 0; //A팀의 2플레이어의 평균값
    public float AverageA3 = 0; //A팀의 3플레이어의 평균값
    public float AverageB1 = 0; //B팀의 1플레이어의 평균값
    public float AverageB2 = 0; //B팀의 2플레이어의 평균값
    public float AverageB3 = 0; //B팀의 3플레이어의 평균값
    public float AverageAT = 0;
    public float AverageBT = 0;

    public string[] PlayerName = new string[6]; //각 플레이어의 이름을 저장해줄변수
    public string[] TeamName = new string[2]; //0이면 A팀 1이면 B팀을 저장해줄 변수

    public bool isAT = true; //A팀 차레라고 말해줄 변수
    public bool isBT = false; //B팀 차레라고 말해줄 변수
    public bool isBust = false; //버스트 라고 말해줄 변수
    public bool isRead = false; //준비 라고 말해줄 변수
    public bool isSpace = false; //라운드가 끝났다고 말해줄 변수
    public bool isWin = false; //이겼다고 말해줄 변수

    public cs01GameManager csgmg; //게임매니저
    public _TARGET_INFO[] m_oDartInfo = new _TARGET_INFO[3];

    void Start()
    {
        Players = 0;
        Teams = 0;
        for (int i = 0; i < TeamScore.Length; i++)
            TeamScore[i] = DefultScore;
        for (int i = 0; i < g_RoundNum.Length; i++)
            g_RoundNum[i].SetActive(false);
        for (int i = 0; i < g_M_Score.Length; i++)
        {
            g_M_Score[i].GetComponent<csNumber>().CreateNumber(3, 250, 3f, 0);
            g_T_Score[i].GetComponent<csNumber>().CreateNumber(4, 65, 0.7f, 0);
            g_OffScore[i].GetComponent<csNumber>().CreateNumber(3, 65, 0.7f, 0);
            g_M_Score[i].GetComponent<csNumber>().SetNumber(TeamScore[i]);
            g_T_Score[i].GetComponent<csNumber>().SetNumber(TeamScore[i]);
            g_OffScore[i].GetComponent<csNumber>().SetNumber(TeamScore[i]);
        }
        g_G_Bust.SetActive(false);
        g_P_Ani.SetActive(false);
        g_C_Ani.SetActive(false);
        Myturn();
        FirstStart();
    }

    void Update()
    {
        Myturn();
        ImageUP();
        if (csSingleton.getInstance.g_bTarget && !isRead && !isSpace && !isWin && !isBust && csgmg.isAni == false)
        {
            csSingleton.getInstance.g_bTarget = false;

            if (Round <= RoundStop && !isRead && !isBust)
            {
                if (isAT && !isBT && !isBust && !isRead && Players == 0)
                {
                    if (Counting == 0 && isAT && !isBT && !isBust && !isRead)
                    {
                        DartCountA1++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[0];
                        PPDScore(DartScore[0]);
                        RoundScore(DartScore[0]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 1 && isAT && !isBT && !isBust && !isRead)
                    {
                        DartCountA1++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[1];
                        PPDScore(DartScore[1]);
                        RoundScore(DartScore[1]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 2 && isAT && !isBT && !isBust && !isRead)
                    {
                        DartCountA1++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[2];
                        PPDScore(DartScore[2]);
                        RoundScore(DartScore[2]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    if (Counting == 3 && isAT && !isBT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[0] = TeamScore[0];
                        g_M_Score[0].SetActive(false);
                        g_P_Ani.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Players == 1 && isAT && !isBT && !isBust && !isRead)
                {
                    if (Counting == 0 && isAT && !isBT && !isRead && !isBust)
                    {
                        DartCountA2++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[0];
                        PPDScore(DartScore[0]);
                        RoundScore(DartScore[0]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 1 && isAT && !isBT && !isRead && !isBust)
                    {
                        DartCountA2++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[1];
                        PPDScore(DartScore[1]);
                        RoundScore(DartScore[1]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 2 && isAT && !isBT && !isRead && !isBust)
                    {
                        DartCountA2++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[2];
                        PPDScore(DartScore[2]);
                        RoundScore(DartScore[2]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    if (Counting == 3 && isAT && !isBT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[0] = TeamScore[0];
                        g_M_Score[0].SetActive(false);
                        g_P_Ani.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Players == 2 && isAT && !isBT && !isBust && !isRead)
                {
                    if (Counting == 0 && isAT && !isBT && !isRead && !isBust)
                    {
                        DartCountA3++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[0];
                        PPDScore(DartScore[0]);
                        RoundScore(DartScore[0]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 1 && isAT && !isBT && !isRead && !isBust)
                    {
                        DartCountA3++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[1];
                        PPDScore(DartScore[1]);
                        RoundScore(DartScore[1]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 2 && isAT && !isBT && !isRead && !isBust)
                    {
                        DartCountA3++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[2];
                        PPDScore(DartScore[2]);
                        RoundScore(DartScore[2]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    if (Counting == 3 && isAT && !isBT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[0] = TeamScore[0];
                        g_M_Score[0].SetActive(false);
                        g_P_Ani.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Players == 0 && isBT && !isAT && !isRead && !isBust)
                {
                    if (Counting == 0 && isBT && !isAT && !isBust && !isRead)
                    {
                        DartCountB1++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[0];
                        PPDScore(DartScore[0]);
                        RoundScore(DartScore[0]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 1 && isBT && !isAT && !isBust && !isRead)
                    {
                        DartCountB1++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[1];
                        PPDScore(DartScore[1]);
                        RoundScore(DartScore[1]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 2 && isBT && !isAT && !isBust && !isRead)
                    {
                        DartCountB1++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[2];
                        PPDScore(DartScore[2]);
                        RoundScore(DartScore[2]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    if (Counting == 3 && isBT && !isAT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[1] = TeamScore[1];
                        g_M_Score[1].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                else if (Players == 1 && isBT && !isAT && !isBust && !isRead)
                {
                    if (Counting == 0 && isBT && !isAT && !isBust && !isRead)
                    {
                        DartCountB2++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[0];
                        PPDScore(DartScore[0]);
                        RoundScore(DartScore[0]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 1 && isBT && !isAT && !isBust && !isRead)
                    {
                        DartCountB2++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[1];
                        PPDScore(DartScore[1]);
                        RoundScore(DartScore[1]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 2 && isBT && !isAT && !isBust && !isRead)
                    {
                        DartCountB2++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[2];
                        PPDScore(DartScore[2]);
                        RoundScore(DartScore[2]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    if (Counting == 3 && isBT && !isAT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[1] = TeamScore[1];
                        g_M_Score[1].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                else if (Players == 2 && isBT && !isAT && !isBust && !isRead)
                {
                    if (Counting == 0 && isBT && !isAT && !isBust && !isRead)
                    {
                        DartCountB3++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[1].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[0] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[0] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[0].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[0].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[0];
                        PPDScore(DartScore[0]);
                        RoundScore(DartScore[0]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[0], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 1 && isBT && !isAT && !isBust && !isRead)
                    {
                        DartCountB3++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        g_Dart[2].GetComponent<Image>().sprite = s_OnDart;
                        DartScore[1] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[1] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[1].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[1].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[1];
                        PPDScore(DartScore[1]);
                        RoundScore(DartScore[1]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[1], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    else if (Counting == 2 && isBT && !isAT && !isBust && !isRead)
                    {
                        DartCountB3++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
                        DartScore[2] = csSingleton.getInstance.g_nTargetScore;
                        DartBasicScore[2] = csSingleton.getInstance.g_nTargetBasicScore;
                        m_oDartInfo[2].nScore = csSingleton.getInstance.g_nTargetScore;
                        m_oDartInfo[2].nLine = csSingleton.getInstance.g_nTargetLine;
                        TeamBasicScore = DartScore[2];
                        PPDScore(DartScore[2]);
                        RoundScore(DartScore[2]);
                        csgmg.DartScoreActor(csSingleton.getInstance.g_nTargetLine, DartBasicScore[2], Counting);
                        BustAndRoundRead();
                        TeamBasicScore = 0;
                    }
                    if (Counting == 3 && isBT && !isAT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[1] = TeamScore[1];
                        g_M_Score[1].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && Counting == 4 && !isWin && isSpace && csgmg.isAni == false)
        {
            if (isAT && Players == 0) //팀 숫자 증가
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                csgmg.DartScoreReSet();
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if (isAT && Players == 1) //팀 숫자 증가
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                csgmg.DartScoreReSet();
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if (isAT && Players == 2) //팀 숫자 증가
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                csgmg.DartScoreReSet();
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if (isBT && Players == 0) //팀 숫자 뺴고 플레이어 숫자 증가
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("TeamNumberMinus", 4f);
                Invoke("PlayerNumberPlus", 4f);
            }
            if (isBT && Players == 1) //팀숫자 뺴고 플레이어 숫자 뺴기
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("TeamNumberMinus", 4f);
                Invoke("PlayerNumberPlus", 4f);
            }
            if (isBT && Players == 2) //팀숫자 뺴고 플레이어 숫자 뺴기
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                RScore += 1;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("TeamNumberMinus", 4f);
                Invoke("PlayerNumberMinus", 4f);
                BustAndRoundRead();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && isBust && csgmg.isAni == false)
        {
            if (Teams == 0 && Players == 0)
            {
                Counting = 4;
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                csgmg.DartScoreReSet();
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 3f);
            }
            if (Teams == 0 && Players == 1)
            {
                Counting = 4;
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                csgmg.DartScoreReSet();
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 3f);
            }
            if (Teams == 0 && Players == 2)
            {
                Counting = 4;
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                csgmg.DartScoreReSet();
                g_C_Ani.SetActive(true);
                g_P_Ani.SetActive(false);
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 3f);
            }
            if (Teams == 1 && Players == 0)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("TeamNumberMinus", 4f);
                Invoke("PlayerNumberPlus", 4f);
            }
            if (Teams == 1 && Players == 1)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("TeamNumberMinus", 4f);
                Invoke("PlayerNumberPlus", 4f);
            }
            if (Teams == 1 && Players == 2)
            {
                a_source.PlayOneShot(ac_shoot2, 1.0f);
                for (int i = 0; i < g_Dart.Length; i++)
                    g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
                g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
                for (int i = 0; i < DartScore.Length; i++)
                    DartScore[i] = 0;
                TeamBasicScore = 0;
                RScore += 1;
                isBust = false;
                isRead = false;
                isSpace = false;
                csgmg.DartScoreReSet();
                Invoke("TeamNumberMinus", 4f);
                Invoke("PlayerNumberMinus", 4f);
                BustAndRoundRead();
            }
        }
        if (Round == RoundStop && Counting == 3 && isBT && !isWin)
            GameEndRead();
    }

    /*----------게임 관련 함수-----------------*/
    void BustAndRoundRead()
    {
        if (TeamScore[Teams] < TeamBasicScore && !isRead && !isWin)
            Bust();

        if (TeamScore[Teams] >= TeamBasicScore && !isRead && !isBust && !isWin)
            NextShoot();

        if (TeamScore[Teams] == 0 && !isBust && !isRead && !isWin)
        {
            g_T_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            WinRead();
        }
        if (Round == RoundStop && Counting == 4 && isBT && !isWin)
        {
            g_C_Ani.SetActive(false);
            GameEndRead();
        }
    }

    void Bust()
    {
        isRead = true;
        g_G_Bust.SetActive(true);
        g_M_Score[Teams].SetActive(false);
        TeamScore[Teams] = Bustscore[Teams];
        g_T_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_OffScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        Invoke("Delay", 2f);
    }

    void Delay()
    {
        Counting = 4;
        g_P_Ani.SetActive(true);
        g_G_Bust.SetActive(false);
        isBust = true;
    }

    void NextShoot()
    {
        if (Counting != 4 && !isBust && !isRead)
        {
            TeamScore[Teams] -= DartScore[Counting];
            g_M_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            g_T_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            g_OffScore[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
            Counting++;
        }
        if (Counting == 4 && isBT && !isBust && !isRead)
            RoundRead();
    }

    void RoundRead()
    {
        isRead = true;
        g_P_Ani.SetActive(false);
        g_T_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_C_Ani.SetActive(true);
        g_M_Score[Teams].SetActive(false);
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
        g_M_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
        g_M_Score[Teams].SetActive(true);
        Round += 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
        isRead = false;
    }

    void WinRead()
    {
        if (TeamScore[1] < TeamScore[0])
        {
            win = 0;
            isWin = true;
            isAT = true;
            isBT = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (TeamScore[0] < TeamScore[1])
        {
            win = 1;
            isWin = true;
            isAT = false;
            isBT = true;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }
    }

    void GameEndRead()
    {
        if (TeamScore[1] < TeamScore[0])
        {
            win = 0;
            isWin = true;
            isAT = true;
            isBT = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }
        if (TeamScore[0] < TeamScore[1])
        {
            win = 1;
            isWin = true;
            isAT = false;
            isBT = true;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }
        if (TeamScore[0] == TeamScore[1])
        {
            win = 0;
            isWin = true;
            isAT = true;
            isBT = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }
    }

    /*-------------------------이미지 관련 함수---------------------------------*/
    void ImageUP()
    {
        if (isAT && !isBT && Players == 0)
        {
            if (RScore == 5)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[5];

                t_TA1RScoreText[0].text = ScoreSaveA1[1].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[2].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[3].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[4].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[6];

                t_TA1RScoreText[0].text = ScoreSaveA1[2].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[3].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[4].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[5].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[7];

                t_TA1RScoreText[0].text = ScoreSaveA1[3].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[4].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[5].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[6].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[8];

                t_TA1RScoreText[0].text = ScoreSaveA1[4].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[5].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[6].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[7].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[9];

                t_TA1RScoreText[0].text = ScoreSaveA1[5].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[6].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[7].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[8].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[10];

                t_TA1RScoreText[0].text = ScoreSaveA1[6].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[7].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[8].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[9].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[11];

                t_TA1RScoreText[0].text = ScoreSaveA1[7].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[8].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[9].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[10].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[12];

                t_TA1RScoreText[0].text = ScoreSaveA1[8].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[9].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[10].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[11].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[13];

                t_TA1RScoreText[0].text = ScoreSaveA1[9].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[10].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[11].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[12].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[14];

                t_TA1RScoreText[0].text = ScoreSaveA1[10].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[11].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[12].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[13].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[15];

                t_TA1RScoreText[0].text = ScoreSaveA1[11].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[12].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[13].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[14].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[16];

                t_TA1RScoreText[0].text = ScoreSaveA1[12].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[13].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[14].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[15].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[17];

                t_TA1RScoreText[0].text = ScoreSaveA1[13].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[14].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[15].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[16].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[18];

                t_TA1RScoreText[0].text = ScoreSaveA1[14].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[15].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[16].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[17].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[19];

                t_TA1RScoreText[0].text = ScoreSaveA1[15].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[16].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[17].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[18].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScoreA1[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA1[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreA1[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreA1[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScoreA1[4].GetComponent<Image>().sprite = s_RScore[20];

                t_TA1RScoreText[0].text = ScoreSaveA1[16].ToString();
                t_TA1RScoreText[1].text = ScoreSaveA1[17].ToString();
                t_TA1RScoreText[2].text = ScoreSaveA1[18].ToString();
                t_TA1RScoreText[3].text = ScoreSaveA1[19].ToString();
                t_TA1RScoreText[4].text = ScoreSaveA1[20].ToString();
            }
        }

        if (isAT && !isBT && Players == 1)
        {
            if (RScore == 5)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[5];

                t_TA2RScoreText[0].text = ScoreSaveA2[1].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[2].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[3].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[4].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[6];

                t_TA2RScoreText[0].text = ScoreSaveA2[2].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[3].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[4].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[5].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[7];

                t_TA2RScoreText[0].text = ScoreSaveA2[3].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[4].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[5].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[6].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[8];

                t_TA2RScoreText[0].text = ScoreSaveA2[4].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[5].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[6].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[7].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[9];

                t_TA2RScoreText[0].text = ScoreSaveA2[5].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[6].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[7].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[8].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[10];

                t_TA2RScoreText[0].text = ScoreSaveA2[6].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[7].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[8].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[9].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[11];

                t_TA2RScoreText[0].text = ScoreSaveA2[7].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[8].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[9].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[10].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[12];

                t_TA2RScoreText[0].text = ScoreSaveA2[8].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[9].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[10].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[11].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[13];

                t_TA2RScoreText[0].text = ScoreSaveA2[9].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[10].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[11].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[12].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[14];

                t_TA2RScoreText[0].text = ScoreSaveA2[10].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[11].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[12].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[13].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[15];

                t_TA2RScoreText[0].text = ScoreSaveA2[11].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[12].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[13].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[14].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[16];

                t_TA2RScoreText[0].text = ScoreSaveA2[12].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[13].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[14].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[15].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[17];

                t_TA2RScoreText[0].text = ScoreSaveA2[13].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[14].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[15].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[16].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[18];

                t_TA2RScoreText[0].text = ScoreSaveA2[14].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[15].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[16].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[17].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[19];

                t_TA2RScoreText[0].text = ScoreSaveA2[15].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[16].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[17].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[18].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScoreA2[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA2[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreA2[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreA2[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScoreA2[4].GetComponent<Image>().sprite = s_RScore[20];

                t_TA2RScoreText[0].text = ScoreSaveA2[16].ToString();
                t_TA2RScoreText[1].text = ScoreSaveA2[17].ToString();
                t_TA2RScoreText[2].text = ScoreSaveA2[18].ToString();
                t_TA2RScoreText[3].text = ScoreSaveA2[19].ToString();
                t_TA2RScoreText[4].text = ScoreSaveA2[20].ToString();
            }
        }

        if (isAT && !isBT && Players == 2)
        {
            if (RScore == 5)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[5];

                t_TA3RScoreText[0].text = ScoreSaveA3[1].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[2].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[3].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[4].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[6];

                t_TA3RScoreText[0].text = ScoreSaveA3[2].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[3].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[4].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[5].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[7];

                t_TA3RScoreText[0].text = ScoreSaveA3[3].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[4].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[5].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[6].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[8];

                t_TA3RScoreText[0].text = ScoreSaveA3[4].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[5].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[6].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[7].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[9];

                t_TA3RScoreText[0].text = ScoreSaveA3[5].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[6].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[7].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[8].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[10];

                t_TA3RScoreText[0].text = ScoreSaveA2[6].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA2[7].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA2[8].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA2[9].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA2[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[11];

                t_TA3RScoreText[0].text = ScoreSaveA3[7].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[8].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[9].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[10].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[12];

                t_TA3RScoreText[0].text = ScoreSaveA3[8].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[9].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[10].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[11].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[13];

                t_TA3RScoreText[0].text = ScoreSaveA3[9].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[10].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[11].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[12].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[14];

                t_TA3RScoreText[0].text = ScoreSaveA3[10].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[11].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[12].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[13].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[15];

                t_TA3RScoreText[0].text = ScoreSaveA3[11].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[12].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[13].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[14].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[16];

                t_TA3RScoreText[0].text = ScoreSaveA2[12].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA2[13].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA2[14].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA2[15].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA2[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[17];

                t_TA3RScoreText[0].text = ScoreSaveA3[13].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[14].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[15].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[16].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[18];

                t_TA3RScoreText[0].text = ScoreSaveA3[14].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[15].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[16].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[17].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[19];

                t_TA3RScoreText[0].text = ScoreSaveA3[15].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA3[16].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA3[17].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA3[18].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA3[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScoreA3[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreA3[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreA3[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreA3[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScoreA3[4].GetComponent<Image>().sprite = s_RScore[20];

                t_TA3RScoreText[0].text = ScoreSaveA2[16].ToString();
                t_TA3RScoreText[1].text = ScoreSaveA2[17].ToString();
                t_TA3RScoreText[2].text = ScoreSaveA2[18].ToString();
                t_TA3RScoreText[3].text = ScoreSaveA2[19].ToString();
                t_TA3RScoreText[4].text = ScoreSaveA2[20].ToString();
            }
        }

        if (isBT && !isAT && Players == 0)
        {
            if (RScore == 5)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[5];

                t_TB1RScoreText[0].text = ScoreSaveB1[1].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[2].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[3].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[4].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[6];

                t_TB1RScoreText[0].text = ScoreSaveB1[2].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[3].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[4].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[5].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[7];

                t_TB1RScoreText[0].text = ScoreSaveB1[3].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[4].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[5].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[6].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[8];

                t_TB1RScoreText[0].text = ScoreSaveB1[4].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[5].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[6].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[7].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[9];

                t_TB1RScoreText[0].text = ScoreSaveB1[5].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[6].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[7].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[8].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[10];

                t_TB1RScoreText[0].text = ScoreSaveB1[6].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[7].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[8].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[9].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[11];

                t_TB1RScoreText[0].text = ScoreSaveB1[7].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[8].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[9].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[10].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[12];

                t_TB1RScoreText[0].text = ScoreSaveB1[8].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[9].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[10].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[11].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[13];

                t_TB1RScoreText[0].text = ScoreSaveB1[9].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[10].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[11].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[12].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[14];

                t_TB1RScoreText[0].text = ScoreSaveB1[10].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[11].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[12].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[13].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[15];

                t_TB1RScoreText[0].text = ScoreSaveB1[11].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[12].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[13].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[14].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[16];

                t_TB1RScoreText[0].text = ScoreSaveB1[12].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[13].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[14].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[15].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[17];

                t_TB1RScoreText[0].text = ScoreSaveB1[13].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[14].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[15].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[16].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[18];

                t_TB1RScoreText[0].text = ScoreSaveB1[14].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[15].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[16].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[17].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[19];

                t_TB1RScoreText[0].text = ScoreSaveB1[15].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[16].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[17].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[18].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScoreB1[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB1[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreB1[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreB1[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScoreB1[4].GetComponent<Image>().sprite = s_RScore[20];

                t_TB1RScoreText[0].text = ScoreSaveB1[16].ToString();
                t_TB1RScoreText[1].text = ScoreSaveB1[17].ToString();
                t_TB1RScoreText[2].text = ScoreSaveB1[18].ToString();
                t_TB1RScoreText[3].text = ScoreSaveB1[19].ToString();
                t_TB1RScoreText[4].text = ScoreSaveB1[20].ToString();
            }

        }

        if (isBT && !isAT && Players == 1)
        {
            if (RScore == 5)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[5];

                t_TB2RScoreText[0].text = ScoreSaveB2[1].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[2].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[3].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[4].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[6];

                t_TB2RScoreText[0].text = ScoreSaveB2[2].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[3].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[4].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[5].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[7];

                t_TB2RScoreText[0].text = ScoreSaveB2[3].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[4].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[5].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[6].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[8];

                t_TB2RScoreText[0].text = ScoreSaveB2[4].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[5].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[6].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[7].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[9];

                t_TB2RScoreText[0].text = ScoreSaveB2[5].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[6].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[7].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[8].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[10];

                t_TB2RScoreText[0].text = ScoreSaveB2[6].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[7].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[8].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[9].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[11];

                t_TB2RScoreText[0].text = ScoreSaveB2[7].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[8].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[9].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[10].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[12];

                t_TB2RScoreText[0].text = ScoreSaveB2[8].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[9].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[10].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[11].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[13];

                t_TB2RScoreText[0].text = ScoreSaveB2[9].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[10].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[11].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[12].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[14];

                t_TB2RScoreText[0].text = ScoreSaveB2[10].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[11].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[12].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[13].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[15];

                t_TB2RScoreText[0].text = ScoreSaveB2[11].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[12].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[13].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[14].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[16];

                t_TB2RScoreText[0].text = ScoreSaveB2[12].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[13].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[14].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[15].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[17];

                t_TB2RScoreText[0].text = ScoreSaveB2[13].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[14].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[15].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[16].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[18];

                t_TB2RScoreText[0].text = ScoreSaveB2[14].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[15].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[16].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[17].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[19];

                t_TB2RScoreText[0].text = ScoreSaveB2[15].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[16].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[17].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[18].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScoreB2[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB2[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreB2[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreB2[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScoreB2[4].GetComponent<Image>().sprite = s_RScore[20];

                t_TB2RScoreText[0].text = ScoreSaveB2[16].ToString();
                t_TB2RScoreText[1].text = ScoreSaveB2[17].ToString();
                t_TB2RScoreText[2].text = ScoreSaveB2[18].ToString();
                t_TB2RScoreText[3].text = ScoreSaveB2[19].ToString();
                t_TB2RScoreText[4].text = ScoreSaveB2[20].ToString();
            }

        }

        if (isBT && !isAT && Players == 2)
        {
            if (RScore == 5)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[5];

                t_TB3RScoreText[0].text = ScoreSaveB3[1].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[2].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[3].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[4].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[6];

                t_TB3RScoreText[0].text = ScoreSaveB3[2].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[3].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[4].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[5].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[7];

                t_TB3RScoreText[0].text = ScoreSaveB3[3].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[4].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[5].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[6].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[8];

                t_TB3RScoreText[0].text = ScoreSaveB3[4].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[5].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[6].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[7].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[9];

                t_TB3RScoreText[0].text = ScoreSaveB3[5].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[6].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[7].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[8].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[10];

                t_TB3RScoreText[0].text = ScoreSaveB3[6].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[7].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[8].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[9].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[11];

                t_TB3RScoreText[0].text = ScoreSaveB3[7].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[8].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[9].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[10].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[12];

                t_TB3RScoreText[0].text = ScoreSaveB3[8].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[9].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[10].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[11].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[13];

                t_TB3RScoreText[0].text = ScoreSaveB3[9].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[10].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[11].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[12].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[14];

                t_TB3RScoreText[0].text = ScoreSaveB3[10].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[11].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[12].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[13].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[15];

                t_TB3RScoreText[0].text = ScoreSaveB3[11].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[12].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[13].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[14].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[16];

                t_TB3RScoreText[0].text = ScoreSaveB3[12].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[13].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[14].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[15].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[17];

                t_TB3RScoreText[0].text = ScoreSaveB3[13].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[14].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[15].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[16].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[18];

                t_TB3RScoreText[0].text = ScoreSaveB3[14].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[15].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[16].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[17].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[19];

                t_TB3RScoreText[0].text = ScoreSaveB3[15].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[16].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[17].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[18].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScoreB3[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreB3[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreB3[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreB3[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScoreB3[4].GetComponent<Image>().sprite = s_RScore[20];

                t_TB3RScoreText[0].text = ScoreSaveB3[16].ToString();
                t_TB3RScoreText[1].text = ScoreSaveB3[17].ToString();
                t_TB3RScoreText[2].text = ScoreSaveB3[18].ToString();
                t_TB3RScoreText[3].text = ScoreSaveB3[19].ToString();
                t_TB3RScoreText[4].text = ScoreSaveB3[20].ToString();
            }

        }
    }

    void RoundScore(int DartScore)
    {
        if (isAT && !isBT && Players == 0)
        {
            ScoreSaveA1[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_TA1RScoreText[0].text = ScoreSaveA1[0].ToString();

                if (RScore == 1)
                    t_TA1RScoreText[1].text = ScoreSaveA1[1].ToString();

                if (RScore == 2)
                    t_TA1RScoreText[2].text = ScoreSaveA1[2].ToString();

                if (RScore == 3)
                    t_TA1RScoreText[3].text = ScoreSaveA1[3].ToString();

                if (RScore == 4)
                    t_TA1RScoreText[4].text = ScoreSaveA1[4].ToString();

                if (RScore == 5)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[1].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[2].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[3].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[4].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[5].ToString();
                }

                if (RScore == 6)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[2].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[3].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[4].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[5].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[6].ToString();
                }

                if (RScore == 7)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[3].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[4].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[5].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[6].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[7].ToString();
                }

                if (RScore == 8)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[4].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[5].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[6].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[7].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[8].ToString();
                }

                if (RScore == 9)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[5].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[6].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[7].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[8].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[9].ToString();
                }

                if (RScore == 10)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[6].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[7].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[8].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[9].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[10].ToString();
                }

                if (RScore == 11)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[7].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[8].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[9].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[10].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[11].ToString();
                }

                if (RScore == 12)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[8].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[9].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[10].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[11].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[12].ToString();
                }

                if (RScore == 13)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[9].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[10].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[11].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[12].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[13].ToString();
                }

                if (RScore == 14)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[10].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[11].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[12].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[13].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[14].ToString();
                }

                if (RScore == 15)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[11].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[12].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[13].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[14].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[15].ToString();
                }

                if (RScore == 16)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[12].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[13].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[14].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[15].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[16].ToString();
                }

                if (RScore == 17)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[15].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[16].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[15].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[16].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[17].ToString();
                }

                if (RScore == 18)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[14].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[15].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[16].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[17].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[18].ToString();
                }

                if (RScore == 19)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[15].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[16].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[17].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[18].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[19].ToString();
                }

                if (RScore == 20)
                {
                    t_TA1RScoreText[0].text = ScoreSaveA1[16].ToString();
                    t_TA1RScoreText[1].text = ScoreSaveA1[17].ToString();
                    t_TA1RScoreText[2].text = ScoreSaveA1[18].ToString();
                    t_TA1RScoreText[3].text = ScoreSaveA1[19].ToString();
                    t_TA1RScoreText[4].text = ScoreSaveA1[20].ToString();
                }
            }
        }

        if (isAT && !isBT && Players == 1)
        {
            ScoreSaveA2[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_TA2RScoreText[0].text = ScoreSaveA2[0].ToString();

                if (RScore == 1)
                    t_TA2RScoreText[1].text = ScoreSaveA2[1].ToString();

                if (RScore == 2)
                    t_TA2RScoreText[2].text = ScoreSaveA2[2].ToString();

                if (RScore == 3)
                    t_TA2RScoreText[3].text = ScoreSaveA2[3].ToString();

                if (RScore == 4)
                    t_TA2RScoreText[4].text = ScoreSaveA2[4].ToString();

                if (RScore == 5)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[1].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[2].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[3].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[4].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[5].ToString();
                }

                if (RScore == 6)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[2].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[3].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[4].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[5].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[6].ToString();
                }

                if (RScore == 7)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[3].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[4].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[5].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[6].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[7].ToString();
                }

                if (RScore == 8)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[4].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[5].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[6].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[7].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[8].ToString();
                }

                if (RScore == 9)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[5].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[6].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[7].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[8].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[9].ToString();
                }

                if (RScore == 10)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[6].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[7].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[8].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[9].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[10].ToString();
                }

                if (RScore == 11)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[7].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[8].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[9].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[10].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[11].ToString();
                }

                if (RScore == 12)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[8].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[9].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[10].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[11].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[12].ToString();
                }

                if (RScore == 13)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[9].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[10].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[11].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[12].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[13].ToString();
                }

                if (RScore == 14)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[10].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[11].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[12].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[13].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[14].ToString();
                }

                if (RScore == 15)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[11].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[12].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[13].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[14].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[15].ToString();
                }

                if (RScore == 16)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[12].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[13].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[14].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[15].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[16].ToString();
                }

                if (RScore == 17)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[15].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[16].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[15].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[16].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[17].ToString();
                }

                if (RScore == 18)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[14].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[15].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[16].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[17].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[18].ToString();
                }

                if (RScore == 19)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[15].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[16].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[17].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[18].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[19].ToString();
                }

                if (RScore == 20)
                {
                    t_TA2RScoreText[0].text = ScoreSaveA2[16].ToString();
                    t_TA2RScoreText[1].text = ScoreSaveA2[17].ToString();
                    t_TA2RScoreText[2].text = ScoreSaveA2[18].ToString();
                    t_TA2RScoreText[3].text = ScoreSaveA2[19].ToString();
                    t_TA2RScoreText[4].text = ScoreSaveA2[20].ToString();
                }
            }
        }

        if (isAT && !isBT && Players == 2)
        {
            ScoreSaveA3[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_TA3RScoreText[0].text = ScoreSaveA3[0].ToString();

                if (RScore == 1)
                    t_TA3RScoreText[1].text = ScoreSaveA3[1].ToString();

                if (RScore == 2)
                    t_TA3RScoreText[2].text = ScoreSaveA3[2].ToString();

                if (RScore == 3)
                    t_TA3RScoreText[3].text = ScoreSaveA3[3].ToString();

                if (RScore == 4)
                    t_TA3RScoreText[4].text = ScoreSaveA3[4].ToString();

                if (RScore == 5)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[1].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[2].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[3].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[4].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[5].ToString();
                }

                if (RScore == 6)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[2].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[3].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[4].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[5].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[6].ToString();
                }

                if (RScore == 7)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[3].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[4].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[5].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[6].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[7].ToString();
                }

                if (RScore == 8)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[4].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[5].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[6].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[7].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[8].ToString();
                }

                if (RScore == 9)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[5].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[6].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[7].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[8].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[9].ToString();
                }

                if (RScore == 10)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[6].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[7].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[8].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[9].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[10].ToString();
                }

                if (RScore == 11)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[7].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[8].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[9].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[10].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[11].ToString();
                }

                if (RScore == 12)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[8].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[9].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[10].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[11].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[12].ToString();
                }

                if (RScore == 13)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[9].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[10].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[11].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[12].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[13].ToString();
                }

                if (RScore == 14)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[10].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[11].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[12].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[13].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[14].ToString();
                }

                if (RScore == 15)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[11].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[12].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[13].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[14].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[15].ToString();
                }

                if (RScore == 16)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[12].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[13].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[14].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[15].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[16].ToString();
                }

                if (RScore == 17)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[15].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[16].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[15].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[16].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[17].ToString();
                }

                if (RScore == 18)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[14].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[15].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[16].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[17].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[18].ToString();
                }

                if (RScore == 19)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[15].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[16].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[17].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[18].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[19].ToString();
                }

                if (RScore == 20)
                {
                    t_TA3RScoreText[0].text = ScoreSaveA3[16].ToString();
                    t_TA3RScoreText[1].text = ScoreSaveA3[17].ToString();
                    t_TA3RScoreText[2].text = ScoreSaveA3[18].ToString();
                    t_TA3RScoreText[3].text = ScoreSaveA3[19].ToString();
                    t_TA3RScoreText[4].text = ScoreSaveA3[20].ToString();
                }
            }
        }

        if (isBT && !isAT && Players == 0)
        {
            ScoreSaveB1[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_TB1RScoreText[0].text = ScoreSaveB1[0].ToString();

                if (RScore == 1)
                    t_TB1RScoreText[1].text = ScoreSaveB1[1].ToString();

                if (RScore == 2)
                    t_TB1RScoreText[2].text = ScoreSaveB1[2].ToString();

                if (RScore == 3)
                    t_TB1RScoreText[3].text = ScoreSaveB1[3].ToString();

                if (RScore == 4)
                    t_TB1RScoreText[4].text = ScoreSaveB1[4].ToString();

                if (RScore == 5)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[1].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[2].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[3].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[4].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[5].ToString();
                }

                if (RScore == 6)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[2].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[3].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[4].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[5].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[6].ToString();
                }

                if (RScore == 7)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[3].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[4].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[5].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[6].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[7].ToString();
                }

                if (RScore == 8)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[4].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[5].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[6].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[7].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[8].ToString();
                }

                if (RScore == 9)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[5].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[6].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[7].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[8].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[9].ToString();
                }

                if (RScore == 10)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[6].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[7].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[8].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[9].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[10].ToString();
                }

                if (RScore == 11)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[7].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[8].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[9].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[10].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[11].ToString();
                }

                if (RScore == 12)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[8].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[9].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[10].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[11].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[12].ToString();
                }

                if (RScore == 13)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[9].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[10].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[11].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[12].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[13].ToString();
                }

                if (RScore == 14)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[10].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[11].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[12].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[13].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[14].ToString();
                }

                if (RScore == 15)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[11].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[12].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[13].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[14].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[15].ToString();
                }

                if (RScore == 16)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[12].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[13].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[14].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[15].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[16].ToString();
                }

                if (RScore == 17)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[13].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[14].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[15].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[16].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[17].ToString();
                }

                if (RScore == 18)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[14].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[15].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[16].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[17].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[18].ToString();
                }

                if (RScore == 19)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[15].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[16].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[17].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[18].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[19].ToString();
                }

                if (RScore == 20)
                {
                    t_TB1RScoreText[0].text = ScoreSaveB1[16].ToString();
                    t_TB1RScoreText[1].text = ScoreSaveB1[17].ToString();
                    t_TB1RScoreText[2].text = ScoreSaveB1[18].ToString();
                    t_TB1RScoreText[3].text = ScoreSaveB1[19].ToString();
                    t_TB1RScoreText[4].text = ScoreSaveB1[20].ToString();
                }
            }
        }

        if (isBT && !isAT && Players == 1)
        {
            ScoreSaveB2[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_TB2RScoreText[0].text = ScoreSaveB2[0].ToString();

                if (RScore == 1)
                    t_TB2RScoreText[1].text = ScoreSaveB2[1].ToString();

                if (RScore == 2)
                    t_TB2RScoreText[2].text = ScoreSaveB2[2].ToString();

                if (RScore == 3)
                    t_TB2RScoreText[3].text = ScoreSaveB2[3].ToString();

                if (RScore == 4)
                    t_TB2RScoreText[4].text = ScoreSaveB2[4].ToString();

                if (RScore == 5)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[1].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[2].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[3].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[4].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[5].ToString();
                }

                if (RScore == 6)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[2].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[3].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[4].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[5].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[6].ToString();
                }

                if (RScore == 7)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[3].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[4].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[5].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[6].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[7].ToString();
                }

                if (RScore == 8)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[4].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[5].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[6].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[7].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[8].ToString();
                }

                if (RScore == 9)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[5].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[6].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[7].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[8].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[9].ToString();
                }

                if (RScore == 10)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[6].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[7].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[8].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[9].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[10].ToString();
                }

                if (RScore == 11)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[7].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[8].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[9].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[10].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[11].ToString();
                }

                if (RScore == 12)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[8].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[9].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[10].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[11].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[12].ToString();
                }

                if (RScore == 13)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[9].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[10].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[11].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[12].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[13].ToString();
                }

                if (RScore == 14)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[10].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[11].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[12].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[13].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[14].ToString();
                }

                if (RScore == 15)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[11].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[12].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[13].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[14].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[15].ToString();
                }

                if (RScore == 16)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[12].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[13].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[14].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[15].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[16].ToString();
                }

                if (RScore == 17)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[13].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[14].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[15].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[16].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[17].ToString();
                }

                if (RScore == 18)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[14].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[15].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[16].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[17].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[18].ToString();
                }

                if (RScore == 19)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[15].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[16].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[17].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[18].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[19].ToString();
                }

                if (RScore == 20)
                {
                    t_TB2RScoreText[0].text = ScoreSaveB2[16].ToString();
                    t_TB2RScoreText[1].text = ScoreSaveB2[17].ToString();
                    t_TB2RScoreText[2].text = ScoreSaveB2[18].ToString();
                    t_TB2RScoreText[3].text = ScoreSaveB2[19].ToString();
                    t_TB2RScoreText[4].text = ScoreSaveB2[20].ToString();
                }
            }
        }

        if (isBT && !isAT && Players == 2)
        {
            ScoreSaveB3[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_TB3RScoreText[0].text = ScoreSaveB3[0].ToString();

                if (RScore == 1)
                    t_TB3RScoreText[1].text = ScoreSaveB3[1].ToString();

                if (RScore == 2)
                    t_TB3RScoreText[2].text = ScoreSaveB3[2].ToString();

                if (RScore == 3)
                    t_TB3RScoreText[3].text = ScoreSaveB3[3].ToString();

                if (RScore == 4)
                    t_TB3RScoreText[4].text = ScoreSaveB3[4].ToString();

                if (RScore == 5)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[1].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[2].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[3].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[4].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[5].ToString();
                }

                if (RScore == 6)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[2].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[3].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[4].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[5].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[6].ToString();
                }

                if (RScore == 7)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[3].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[4].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[5].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[6].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[7].ToString();
                }

                if (RScore == 8)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[4].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[5].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[6].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[7].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[8].ToString();
                }

                if (RScore == 9)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[5].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[6].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[7].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[8].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[9].ToString();
                }

                if (RScore == 10)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[6].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[7].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[8].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[9].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[10].ToString();
                }

                if (RScore == 11)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[7].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[8].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[9].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[10].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[11].ToString();
                }

                if (RScore == 12)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[8].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[9].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[10].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[11].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[12].ToString();
                }

                if (RScore == 13)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[9].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[10].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[11].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[12].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[13].ToString();
                }

                if (RScore == 14)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[10].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[11].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[12].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[13].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[14].ToString();
                }

                if (RScore == 15)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[11].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[12].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[13].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[14].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[15].ToString();
                }

                if (RScore == 16)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[12].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[13].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[14].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[15].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[16].ToString();
                }

                if (RScore == 17)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[13].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[14].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[15].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[16].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[17].ToString();
                }

                if (RScore == 18)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[14].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[15].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[16].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[17].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[18].ToString();
                }

                if (RScore == 19)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[15].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[16].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[17].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[18].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[19].ToString();
                }

                if (RScore == 20)
                {
                    t_TB3RScoreText[0].text = ScoreSaveB3[16].ToString();
                    t_TB3RScoreText[1].text = ScoreSaveB3[17].ToString();
                    t_TB3RScoreText[2].text = ScoreSaveB3[18].ToString();
                    t_TB3RScoreText[3].text = ScoreSaveB3[19].ToString();
                    t_TB3RScoreText[4].text = ScoreSaveB3[20].ToString();
                }
            }
        }
    }

    void Myturn() //각 플레이어의 차레일떄 이미지변화를 주는 함수
    {
        if (isAT && !isBT && Players == 0)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, -10f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);

            g_TeamA.transform.localScale = new Vector3(1f, 1f);
            g_TeamB.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOn[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOff[0];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_T_Score[0].SetActive(true);
            g_T_Score[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            for (int i = 0; i < g_PPDScore.Length; i++)
            {
                g_PPDScore[i].SetActive(false);
                g_RoundScore[i].SetActive(false);
            }
            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = true;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
            }
            g_PPDScore[0].SetActive(true);
            g_RoundScore[0].SetActive(true);

        }

        if (isAT && !isBT && Players == 1)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, -10f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);

            g_TeamA.transform.localScale = new Vector3(1f, 1f);
            g_TeamB.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOn[1];
            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOff[1];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_T_Score[0].SetActive(true);
            g_T_Score[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            for (int i = 0; i < g_PPDScore.Length; i++)
            {
                g_PPDScore[i].SetActive(false);
                g_RoundScore[i].SetActive(false);
            }

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = true;
                i_RScoreA3[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
            }

            g_PPDScore[1].SetActive(true);
            g_RoundScore[1].SetActive(true);
        }

        if (isAT && !isBT && Players == 2)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, -10f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);

            g_TeamA.transform.localScale = new Vector3(1f, 1f);
            g_TeamB.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOn[2];
            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOff[2];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];

            g_T_Score[0].SetActive(true);
            g_T_Score[1].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);

            for (int i = 0; i < g_PPDScore.Length; i++)
            {
                g_PPDScore[i].SetActive(false);
                g_RoundScore[i].SetActive(false);
            }

            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = true;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
            }

            g_PPDScore[2].SetActive(true);
            g_RoundScore[2].SetActive(true);
        }

        if (isBT && !isAT && Players == 0)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, -10f);

            g_TeamA.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamB.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOn[0];
            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOff[0];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_T_Score[1].SetActive(true);
            g_T_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            for (int i = 0; i < g_PPDScore.Length; i++)
            {
                g_PPDScore[i].SetActive(false);
                g_RoundScore[i].SetActive(false);
            }
            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreB1[i].enabled = true;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = false;
            }
            g_PPDScore[3].SetActive(true);
            g_RoundScore[3].SetActive(true);
        }

        if (isBT && !isAT && Players == 1)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, -10f);

            g_TeamA.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamB.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOn[1];
            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOff[1];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_T_Score[1].SetActive(true);
            g_T_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            for (int i = 0; i < g_PPDScore.Length; i++)
            {
                g_PPDScore[i].SetActive(false);
                g_RoundScore[i].SetActive(false);
            }
            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = true;
                i_RScoreB3[i].enabled = false;
            }
            g_PPDScore[4].SetActive(true);
            g_RoundScore[4].SetActive(true);
        }

        if (isBT && !isAT && Players == 2)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, -10f);

            g_TeamA.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamB.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOn[2];
            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOff[2];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_T_Score[1].SetActive(true);
            g_T_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[0].SetActive(true);

            for (int i = 0; i < g_PPDScore.Length; i++)
            {
                g_PPDScore[i].SetActive(false);
                g_RoundScore[i].SetActive(false);
            }
            for (int i = 0; i < i_RScoreA1.Length; i++)
            {
                i_RScoreA1[i].enabled = false;
                i_RScoreA2[i].enabled = false;
                i_RScoreA3[i].enabled = false;
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreB3[i].enabled = true;
            }
            g_PPDScore[5].SetActive(true);
            g_RoundScore[5].SetActive(true);
        }

        if (Round == RoundStop && Counting == 3)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);
            for (int i = 0; i < g_OffScore.Length; i++)
            {
                g_OffScore[i].SetActive(false);
                g_T_Score[i].SetActive(true);
            }
        }
    }

    void FirstStart() //처음 시작할떄 초기화 할꺼
    {
        isAT = true;
        isBT = false;
        for (int i = 0; i < g_M_Score.Length; i++)
            g_M_Score[i].SetActive(false);
        for (int i = 0; i < g_Dart.Length; i++)
            g_Dart[i].GetComponent<Image>().sprite = s_OffDart;
        g_Dart[0].GetComponent<Image>().sprite = s_OnDart;
        g_RoundR.SetActive(true);
        g_RoundNum[Round].SetActive(true);
        g_RoundOn.SetActive(true);
        g_R_Ani.SetActive(true);
        Invoke("FirstStartAniStop", 1f);
    }

    void FirstStartAniStop() //애니메이션 스탑
    {
        g_M_Score[Players].SetActive(true);
        g_RoundR.SetActive(false);
        g_RoundNum[Round].SetActive(false);
        g_RoundOn.SetActive(false);
        g_R_Ani.SetActive(false);
        Round = 1;
        t_RoundText.text = Round.ToString() + "/" + RoundStop.ToString();
    }

    void TeamNumberMinus() //A팀으로 바꿈
    {
        isAT = true;
        isBT = false;
        g_C_Ani.SetActive(false);
        Counting = 0;
        g_M_Score[1].SetActive(false);
        g_T_Score[1].SetActive(true);
        Teams = 0;
        g_M_Score[Teams].SetActive(true);
        g_M_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void TeamNumberPlus()//B팀으로 바꿈
    {
        isAT = false;
        isBT = true;
        g_C_Ani.SetActive(false);
        Counting = 0;
        g_M_Score[0].SetActive(false);
        g_OffScore[0].SetActive(true);
        Teams = 1;
        g_M_Score[Teams].SetActive(true);
        g_M_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void PlayerNumberMinus()//2플레이어에서 1플레이어로 넘겨주는 역활
    {
        g_C_Ani.SetActive(false);
        Counting = 0;
        g_M_Score[1].SetActive(false);
        g_OffScore[1].SetActive(true);
        Players = 0;
        g_M_Score[Teams].SetActive(true);
        g_M_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void PlayerNumberPlus() //1플레이어에서 2플레이어로 넘겨주는 역활
    {
        g_C_Ani.SetActive(false);
        Counting = 0;
        g_M_Score[0].SetActive(false);
        g_OffScore[0].SetActive(true);
        Players += 1;
        g_M_Score[Teams].SetActive(true);
        g_M_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void PPDScore(int Dart) //각 플레이어의 총합점수와 평균점수값을 나눔
    {
        if (Teams == 0 && Players == 0)
        {
            TotalA1 += Dart;
            AverageA1 = TotalA1 / DartCountA1;
            t_PPDText[0].text = string.Format("{0:N2}", AverageA1);
        }
        else if (Teams == 0 && Players == 1)
        {
            TotalA2 += Dart;
            AverageA2 = TotalA2 / DartCountA2;
            t_PPDText[1].text = string.Format("{0:N2}", AverageA2);
        }
        else if (Teams == 0 && Players == 2)
        {
            TotalA3 += Dart;
            AverageA3 = TotalA3 / DartCountA3;
            t_PPDText[2].text = string.Format("{0:N2}", AverageA3);
        }
        else if (Teams == 1 && Players == 0)
        {
            TotalB1 += Dart;
            AverageB1 = TotalB1 / DartCountB1;
            t_PPDText[3].text = string.Format("{0:N2}", AverageB1);
        }
        else if (Teams == 1 && Players == 1)
        {
            TotalB2 += Dart;
            AverageB2 = TotalB2 / DartCountB2;
            t_PPDText[4].text = string.Format("{0:N2}", AverageB2);
        }
        else if (Teams == 1 && Players == 2)
        {
            TotalB3 += Dart;
            AverageB3 = TotalB3 / DartCountB3;
            t_PPDText[5].text = string.Format("{0:N2}", AverageB3);
        }

        if (Teams == 0)
            AverageAT = AverageA1 + AverageA2 + AverageA3 / 3;
        else if (Teams == 1)
            AverageBT = AverageB1 + AverageB2 + AverageB3 / 3;
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
