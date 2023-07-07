using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class _01Dou2222 : MonoBehaviour
{
    public Text t_RoundText; //라운드 텍스트
    public Text[] t_PPDText = new Text[8]; //각각 ppd 
    public Text[] t_TA1RScoreText = new Text[5]; //A팀의 1플레이어의 라운드 스코어
    public Text[] t_TA2RScoreText = new Text[5]; //A팀의 2플레이어의 라운드 스코어
    public Text[] t_TB1RScoreText = new Text[5]; //B팀의 1플레이어의 라운드 스코어
    public Text[] t_TB2RScoreText = new Text[5]; //B팀의 2플레이어의 라운드 스코어
    public Text[] t_TC1RScoreText = new Text[5]; //C팀의 1플레이어의 라운드 스코어
    public Text[] t_TC2RScoreText = new Text[5]; //C팀의 2플레이어의 라운드 스코어
    public Text[] t_TD1RScoreText = new Text[5]; //D팀의 1플레이어의 라운드 스코어
    public Text[] t_TD2RScoreText = new Text[5]; //D팀의 2플레이어의 라운드 스코어

    public Sprite s_OnDart; //다트 On이미지
    public Sprite s_OffDart; //다트 Off 이미지
    public Sprite[] s_RScore = new Sprite[20]; //라운드 스코어의 이미지 1~20
    public Sprite[] s_TeamOn = new Sprite[4]; //자기팀의 차레일떄 on
    public Sprite[] s_TeamOff = new Sprite[4]; //자기팀의 차레가아닐떄 off 할 이미지
    public Sprite[] s_TeambarOn = new Sprite[4]; //팀 바 이미지 on
    public Sprite[] s_TeambarOff = new Sprite[4]; //팀 바 이미지 off

    public Image[] i_RScoreA1 = new Image[5]; //A팀의 1플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreA2 = new Image[5]; //A팀의 2플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreB1 = new Image[5]; //B팀의 1플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreB2 = new Image[5]; //B팀의 2플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreC1 = new Image[5]; //C팀의 1플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreC2 = new Image[5]; //C팀의 2플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreD1 = new Image[5]; //D팀의 1플레이어의 라운드 스코어의 이미지
    public Image[] i_RScoreD2 = new Image[5]; //D팀의 2플레이어의 라운드 스코어의 이미지

    public GameObject[] g_i_Player = new GameObject[4]; //팀 마다 플레이어의 순서이미지를 가지고있는 부모
    public GameObject[] g_Dart = new GameObject[3]; //다트 이미지를 가지고있는 부모
    public GameObject[] g_RoundScore = new GameObject[8]; //각 플레이어의 라운드 스코어를 가지고있는 부모
    public GameObject[] g_PPDScore = new GameObject[8]; //각 플레이어의 PPD 스코어를 가지고있는 부모
    public GameObject[] g_RoundNum = new GameObject[21]; //각 라운드의 숫자의 이미지를 가지고있는 부모
    public GameObject[] g_M_Score = new GameObject[4]; // 각 팀의 메인 큰 스코어
    public GameObject[] g_T_Score = new GameObject[4]; // 각 팀의 스코어
    public GameObject[] g_OffScore = new GameObject[4]; // 각 팀의 off 상태일떄 스코어
    public GameObject[] g_Teambar = new GameObject[4]; //각 팀의 바 이미지를 가지고있는 부모

    public GameObject g_TeamA; //A팀의 부모
    public GameObject g_TeamB; //B의 부모
    public GameObject g_TeamC; //C팀의 부모
    public GameObject g_TeamD; //D팀의 부모
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
    public int DartCountA2 = 0; //A팀의 2플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountB1 = 0; //B팀의 1플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountB2 = 0; //B팀의 2플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountC1 = 0; //C팀의 1플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountC2 = 0; //C팀의 2플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountD1 = 0; //D팀의 1플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int DartCountD2 = 0; //D팀의 2플레이어가 게임이 끝날떄까지 다트를 던진 횟수를 저장할 변수
    public int RScore = 0; //라운드가 끝날떄마다 증가를 해 라운드 스코어를 저장할 이미지를 한칸씩 올려주기위한 변수
    public int Teams = 0; // 0이면 A팀 1이면 B팀 2이면 C팀 을 알려줄 변수
    public int Players = 0; //P=0이면 팀의 1플레이어 P=1 이면 팀의 2플레이어
    public int TotalA1 = 0; //A팀의 1플레이어의 총합점수
    public int TotalA2 = 0; //A팀의 2플레이어의 총합점수
    public int TotalB1 = 0; //B팀의 1플레이어의 총합점수
    public int TotalB2 = 0; //B팀의 2플레이어의 총합점수
    public int TotalC1 = 0; //C팀의 1플레이어의 총합점수
    public int TotalC2 = 0; //C팀의 2플레이어의 총합점수
    public int TotalD1 = 0; //D팀의 1플레이어의 총합점수
    public int TotalD2 = 0; //D팀의 2플레이어의 총합점수
    public int win = 0; //0이면 A팀 1이면 B팀이 2이면 C팀 이겼다고 알려줄 변수

    public int[] TeamScore = new int[4]; //각팀의 점수를 저장할 변수
    public int[] DartScore = new int[3]; //다트의 점수를 저장할 변수
    public int[] DartBasicScore = new int[3];
    public int[] Bustscore = new int[4]; //버스트가 될경우 전라운드 스코어를 저장을 해줄 변수
    public int[] ScoreSaveA1 = new int[20]; //A팀의 1플레이어의 각라운드 스코어를 저장해줄 변수
    public int[] ScoreSaveA2 = new int[20]; //A팀의 2플레이어의 각라운드 스코어를 저장해줄 변수
    public int[] ScoreSaveB1 = new int[20]; //B팀의 1플레이어의 각라운드 스코어를 저장해줄 변수
    public int[] ScoreSaveB2 = new int[20]; //B팀의 2플레이어의 각라운드 스코어를 저장해줄 변수
    public int[] ScoreSaveC1 = new int[20]; //C팀의 1플레이어의 각라운드 스코어를 저장해줄 변수
    public int[] ScoreSaveC2 = new int[20]; //C팀의 2플레이어의 각라운드 스코어를 저장해줄변수
    public int[] ScoreSaveD1 = new int[20]; //D팀의 1플레이어의 각라운드 스코어를 저장해줄변수
    public int[] ScoreSaveD2 = new int[20]; //D팀의 2플레이어의 각라운드 스코어를 저장해줄변수

    public float AverageA1 = 0; //A팀의 1플레이어의 평균값
    public float AverageA2 = 0; //A팀의 2플레이어의 평균값
    public float AverageB1 = 0; //B팀의 1플레이어의 평균값
    public float AverageB2 = 0; //B팀의 2플레이어의 평균값
    public float AverageC1 = 0; //C팀의 1플레이어의 평균값
    public float AverageC2 = 0; //C팀의 2플레이어의 평균값
    public float AverageD1 = 0; //D팀의 1플레이어의 평균값
    public float AverageD2 = 0; //D팀의 2플레이어의 평균값
    public float AverageAT = 0;
    public float AverageBT = 0;
    public float AverageCT = 0;
    public float AverageDT = 0;

    public string[] PlayerName = new string[8]; //각 플레이어의 이름을 저장해줄변수
    public string[] TeamName = new string[4]; //0이면 A팀 1이면 B팀을 저장해줄 변수

    public bool isAT = true;  //A팀 차레라고 말해줄 변수
    public bool isBT = false; //B팀 차레라고 말해줄 변수
    public bool isCT = false; //C팀 차레라고 말해줄 변수
    public bool isDT = false;
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
        if (csSingleton.getInstance.g_bTarget && !isRead && !isSpace && !isWin && !isBust)
        {
            csSingleton.getInstance.g_bTarget = false;
            if (Round <= RoundStop && !isRead && !isBust && csgmg.isAni==false)
            {
                if (isAT && !isBT && !isCT && !isBust && !isRead && Players == 0)
                {
                    if (Counting == 0 && isAT && !isBT && !isCT && !isDT && !isBust && !isRead)
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
                    else if (Counting == 1 && isAT && !isBT && !isCT && !isDT && !isBust && !isRead)
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
                    else if (Counting == 2 && isAT && !isBT && !isCT && !isDT && !isBust && !isRead)
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
                    if (Counting == 3 && isAT && !isBT && !isCT && !isDT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[0] = TeamScore[0];
                        g_M_Score[0].SetActive(false);
                        g_P_Ani.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                else if (Players == 1 && isAT && !isBT && !isCT && !isDT && !isBust && !isRead)
                {
                    if (Counting == 0 && isAT && !isBT && !isCT && !isDT && !isRead && !isBust)
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
                    else if (Counting == 1 && isAT && !isBT && !isCT && !isDT && !isRead && !isBust)
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
                    else if (Counting == 2 && isAT && !isBT && !isCT && !isDT && !isRead && !isBust)
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
                    if (Counting == 3 && isAT && !isBT && !isCT && !isDT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[0] = TeamScore[0];
                        g_M_Score[0].SetActive(false);
                        g_P_Ani.SetActive(true);
                        isSpace = true;
                        Counting = 4;
                    }
                }
                /*---------------ATeam-------------------------------------------*/
                else if (Players == 0 && isBT && !isCT && !isDT && !isAT && !isRead && !isBust)
                {
                    if (Counting == 0 && isBT && !isCT && !isDT && !isAT && !isBust && !isRead)
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
                    else if (Counting == 1 && isBT && !isCT && !isDT && !isAT && !isBust && !isRead)
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
                    else if (Counting == 2 && isBT && !isCT && !isDT && !isAT && !isBust && !isRead)
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
                    if (Counting == 3 && isBT && !isCT && !isDT && !isAT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[1] = TeamScore[1];
                        g_M_Score[1].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                else if (Players == 1 && isBT && !isCT && !isDT && !isAT && !isBust && !isRead)
                {
                    if (Counting == 0 && isBT && !isCT && !isDT && !isAT && !isBust && !isRead)
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
                    else if (Counting == 1 && isBT && !isCT && !isDT && !isAT && !isBust && !isRead)
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
                    else if (Counting == 2 && isBT && !isCT && !isDT && !isAT && !isBust && !isRead)
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
                    if (Counting == 3 && isBT && !isCT && !isDT && !isAT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[1] = TeamScore[1];
                        g_M_Score[1].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                /*----------------------BTeam------------------------------*/
                else if (Players == 0 && isCT && !isDT && !isAT && !isBT && !isBust && !isRead)
                {
                    if (Counting == 0 && isCT && !isDT && !isAT && !isBT && !isBust && !isRead)
                    {
                        DartCountC1++;
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
                    else if (Counting == 1 && isCT && !isDT && !isAT && !isBT && !isBust && !isRead)
                    {
                        DartCountC1++;
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
                    else if (Counting == 2 && isCT && !isDT && !isAT && !isBT && !isBust && !isRead)
                    {
                        DartCountC1++;
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
                    if (Counting == 3 && isCT && !isDT && !isAT && !isBT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[2] = TeamScore[2];
                        g_M_Score[2].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                else if (Players == 1 && isCT && !isDT && !isAT && !isBT && !isBust && !isRead)
                {
                    if (Counting == 0 && isCT && !isDT && !isAT && !isBT && !isBust && !isRead)
                    {
                        DartCountC2++;
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
                    else if (Counting == 1 && isCT && !isDT && !isAT && !isBT && !isBust && !isRead)
                    {
                        DartCountC2++;
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
                    else if (Counting == 2 && isCT && !isDT && !isAT && !isBT && !isBust && !isRead)
                    {
                        DartCountC2++;
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
                    if (Counting == 3 && isCT && !isDT && !isAT && !isBT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[2] = TeamScore[2];
                        g_M_Score[2].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                /*------------------CTeam-------------------------------*/
                else if (Players == 0 && isDT && !isAT && !isBT && !isCT && !isBust && !isRead)
                {
                    if (Counting == 0 && isDT && !isAT && !isBT && !isCT && !isBust && !isRead)
                    {
                        DartCountD1++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
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
                    else if (Counting == 1 && isDT && !isAT && !isBT && !isCT && !isBust && !isRead)
                    {
                        DartCountD1++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
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
                    else if (Counting == 2 && isDT && !isAT && !isBT && !isCT && !isBust && !isRead)
                    {
                        DartCountD1++;
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
                    if (Counting == 3 && isDT && !isAT && !isBT && !isCT && !isBust && !isRead)
                    {
                        GetMovie();
                        Bustscore[3] = TeamScore[3];
                        g_M_Score[3].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
                else if (Players == 1 && isDT && !isAT && !isBT && !isCT && !isBust && !isRead)
                {
                    if (Counting == 0&&isDT&&!isAT&&!isBT&&!isCT&&!isBust&&!isRead)
                    {
                        DartCountD2++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
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
                    else if(Counting==1&&isDT&&!isAT&&!isBT&&!isCT&&!isBust&&!isRead)
                    {
                        DartCountD2++;
                        a_source.PlayOneShot(ac_shoot1, 1.0f);
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
                    else if(Counting==2&&isDT&&!isAT&&!isBT&&!isCT&&!isBust&&!isRead)
                    {
                        DartCountD2++;
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
                    if(Counting==3&&isDT&&!isAT&&!isBT&&!isCT&&!isBust&&!isRead)
                    {
                        GetMovie();
                        Bustscore[3] = TeamScore[3];
                        g_M_Score[3].SetActive(false);
                        g_P_Ani.SetActive(true);
                        Counting = 4;
                        isSpace = true;
                    }
                }
            }
            else
            {
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && Counting == 4 && !isWin && isSpace && csgmg.isAni == false)
        {
            if (isAT && Players == 0) //팀 플러스
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);

            }
            if (isBT && Players == 0) //팀 플러스
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);

            }
            if (isCT && Players == 0) //팀 마이너스 및 플레이어 플러스
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);

            }
            if (isDT && Players == 0)
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberMinus", 4f);
                Invoke("PlayerNumberPlus", 4f);
                BustAndRoundRead();
            }
            if (isAT && Players == 1) //플레이어 증가
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if (isBT && Players == 1) //플레이어 증가
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if (isCT && Players == 1) //팀 감소 플레이어 감소
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if(isDT&&Players==1)
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
                RScore += 1;
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberMinus", 4f);
                Invoke("PlayerNumberMinus", 4f);
                BustAndRoundRead();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && isBust && csgmg.isAni==false)
        {
            if (Teams == 0 && Players == 0) //팀 플러스
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if (Teams == 1 && Players == 0) //팀 플러스
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if (Teams == 2 && Players == 0) 
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if (Teams == 3 && Players == 0)
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberMinus", 4f);
                Invoke("PlayerNumberPlus",4f);
                BustAndRoundRead();
            }
            if (Teams == 0 && Players == 1) //팀 증가
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if (Teams == 1 && Players == 1) //팀 증가
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
            if (Teams == 2 && Players == 1) //팀 감소 플레이어 감소
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
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberPlus", 4f);
            }
      
            if(Teams==3&&Players==1)
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
                RScore += 1;
                isBust = false;
                isRead = false;
                isSpace = false;
                Invoke("TeamNumberMinus", 4f);
                Invoke("PlayerNumberMinus", 4f);
                BustAndRoundRead();
            }
        }
        if (Round == RoundStop && isDT && Counting == 4)
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
        if (Round == RoundStop && Counting == 4 && isDT && !isWin)
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
        if (Counting == 4 && isDT && !isBust && !isRead)
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
        if (TeamScore[1] < TeamScore[0] && TeamScore[2] < TeamScore[0] && TeamScore[3] < TeamScore[0])
        {
            win = 0;
            isWin = true;
            isAT = true;
            isBT = false;
            isCT = false;
            isDT = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (TeamScore[0] < TeamScore[1] && TeamScore[2] < TeamScore[1] && TeamScore[3] < TeamScore[1])
        {
            win = 1;
            isWin = true;
            isAT = false;
            isBT = true;
            isCT = false;
            isDT = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (TeamScore[0] < TeamScore[2] && TeamScore[1] < TeamScore[2] && TeamScore[3] < TeamScore[2])
        {
            win = 2;
            isWin = true;
            isAT = false;
            isBT = false;
            isCT = true;
            isDT = false;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }

        if (TeamScore[0] < TeamScore[3] && TeamScore[1] < TeamScore[3] && TeamScore[2] < TeamScore[3])
        {
            win = 3;
            isWin = true;
            isAT = false;
            isBT = false;
            isCT = false;
            isDT = true;
            g_P_Ani.SetActive(false);
            for (int i = 0; i < g_M_Score.Length; i++)
                g_M_Score[i].SetActive(false);
            csgmg.GameEndRead(win);
        }
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
            csgmg.GameEndRead(win);
        }

        if (TeamScore[0] < TeamScore[1] && TeamScore[2] < TeamScore[1] && TeamScore[3] < TeamScore[1])
        {
            win = 1;
            isBT = true;
            isAT = false;
            isCT = false;
            isDT = false;
            isWin = true;
            csgmg.GameEndRead(win);
        }

        if (TeamScore[0] < TeamScore[2] && TeamScore[1] < TeamScore[2] && TeamScore[3] < TeamScore[2])
        {
            win = 2;
            isCT = true;
            isAT = false;
            isBT = false;
            isDT = false;
            isWin = true;
            csgmg.GameEndRead(win);
        }

        if (TeamScore[0] < TeamScore[3] && TeamScore[1] < TeamScore[3] && TeamScore[2] < TeamScore[3])
        {
            win = 3;
            isAT = false;
            isBT = false;
            isCT = false;
            isDT = true;
            isWin = true;
            csgmg.GameEndRead(win);
        }

        if (TeamScore[0] == TeamScore[1] && TeamScore[0] == TeamScore[2] &&
            TeamScore[0] == TeamScore[3] && TeamScore[1] == TeamScore[2] &&
            TeamScore[1] == TeamScore[3] && TeamScore[2] == TeamScore[3])
        {
            if (AverageBT < AverageAT && AverageCT < AverageAT && AverageDT < AverageAT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageBT && AverageCT < AverageBT && AverageDT < AverageBT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageCT && AverageBT < AverageCT && AverageDT < AverageCT)
            {
                win = 2;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageDT && AverageBT < AverageDT && AverageCT < AverageDT)
            {
                win = 3;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageBT && AverageAT == AverageCT && AverageAT == AverageDT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageBT == AverageCT && AverageBT == AverageDT &&
                 AverageAT != AverageBT && AverageAT != AverageCT &&
                 AverageAT != AverageDT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            } //BC BD

            if (AverageCT == AverageDT
                && AverageBT != AverageCT && AverageBT != AverageDT
                && AverageAT != AverageBT && AverageAT != AverageCT
                && AverageAT != AverageDT)
            {
                win = 2;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                csgmg.GameEndRead(win);
            } //CD
        } //ALL

        if (TeamScore[0] == TeamScore[1] && TeamScore[0] == TeamScore[2] &&
           TeamScore[0] != TeamScore[3] && TeamScore[1] != TeamScore[3] &&
           TeamScore[2] != TeamScore[3])
        {
            if (AverageBT < AverageAT && AverageCT < AverageAT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageBT && AverageCT < AverageBT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageCT && AverageBT < AverageCT)
            {
                win = 2;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageBT && AverageAT == AverageCT && AverageBT != AverageCT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageBT == AverageDT && AverageAT != AverageBT && AverageAT != AverageCT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageDT && AverageAT != AverageBT && AverageDT != AverageBT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageBT && AverageAT == AverageCT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
        }  //ABC

        if (TeamScore[0] == TeamScore[2] && TeamScore[0] == TeamScore[3] &&
            TeamScore[2] == TeamScore[3] && TeamScore[0] != TeamScore[1] &&
            TeamScore[2] != TeamScore[1] && TeamScore[3] != TeamScore[1])
        {
            if (AverageBT < AverageAT && AverageDT < AverageAT)
            {
                win = 0;
                isWin = false;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageBT && AverageDT < AverageBT)
            {
                win = 1;
                isWin = false;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageDT && AverageBT < AverageDT)
            {
                win = 3;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageBT && AverageAT == AverageDT && AverageBT != AverageDT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageBT == AverageDT && AverageAT != AverageBT && AverageAT != AverageDT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageDT && AverageAT != AverageBT && AverageDT != AverageBT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageBT && AverageAT == AverageDT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
        } //ACD

        if (TeamScore[0] == TeamScore[1] && TeamScore[0] == TeamScore[3] &&
            TeamScore[1] == TeamScore[3] && TeamScore[0] != TeamScore[2] &&
            TeamScore[1] != TeamScore[2] && TeamScore[3] != TeamScore[2])
        {
            if (AverageBT < AverageAT && AverageDT < AverageAT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageBT && AverageDT < AverageBT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageDT && AverageCT < AverageDT)
            {
                win = 3;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageBT && AverageAT == AverageDT && AverageBT != AverageDT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageBT == AverageDT && AverageBT != AverageAT && AverageDT != AverageAT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageDT && AverageBT != AverageAT && AverageBT != AverageDT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageBT && AverageAT == AverageDT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
        } //ABD

        if (TeamScore[1] == TeamScore[2] && TeamScore[1] == TeamScore[3] &&
            TeamScore[2] == TeamScore[3] && TeamScore[1] != TeamScore[0] &&
            TeamScore[2] != TeamScore[0] && TeamScore[3] != TeamScore[0])
        {
            if (AverageCT < AverageBT && AverageDT < AverageBT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageBT < AverageCT && AverageDT < AverageCT)
            {
                win = 2;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageBT < AverageDT && AverageCT < AverageDT)
            {
                win = 3;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                csgmg.GameEndRead(win);
            }
            if (AverageBT == AverageCT && AverageBT == AverageDT && AverageCT != AverageDT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageCT == AverageDT && AverageBT != AverageCT && AverageBT != AverageDT)
            {
                win = 2;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageBT == AverageDT && AverageCT != AverageBT && AverageCT != AverageDT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageBT == AverageCT && AverageBT == AverageDT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
        } //BCD

        if (TeamScore[0] == TeamScore[1] && TeamScore[0] != TeamScore[2] &&
            TeamScore[0] != TeamScore[3] && TeamScore[1] != TeamScore[2] &&
            TeamScore[1] != TeamScore[3] && TeamScore[2] != TeamScore[3])
        {
            if (AverageBT < AverageAT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageBT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageBT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
        } //A B

        if (TeamScore[0] == TeamScore[2] && TeamScore[0] != TeamScore[1] &&
            TeamScore[0] != TeamScore[3] && TeamScore[1] != TeamScore[2] &&
            TeamScore[1] != TeamScore[3] && TeamScore[2] != TeamScore[3])
        {
            if (AverageCT < AverageAT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageCT)
            {
                win = 2;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageCT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
        } //A C

        if (TeamScore[0] == TeamScore[3] && TeamScore[0] != TeamScore[1] &&
            TeamScore[0] != TeamScore[2] && TeamScore[1] != TeamScore[2] &&
            TeamScore[1] != TeamScore[3] && TeamScore[2] != TeamScore[3])
        {
            if (AverageDT < AverageAT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageAT < AverageDT)
            {
                win = 3;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                csgmg.GameEndRead(win);
            }
            if (AverageAT == AverageDT)
            {
                win = 0;
                isWin = true;
                isAT = true;
                isBT = false;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
        } //A D

        if (TeamScore[1] == TeamScore[2] && TeamScore[0] != TeamScore[1] &&
            TeamScore[0] != TeamScore[2] && TeamScore[0] != TeamScore[3] &&
            TeamScore[1] != TeamScore[3] && TeamScore[2] != TeamScore[3])
        {
            if (AverageBT < AverageCT)
            {
                win = 2;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageCT < AverageBT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageBT == AverageCT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
        } //B C

        if (TeamScore[1] == TeamScore[3] && TeamScore[0] != TeamScore[1] &&
            TeamScore[0] != TeamScore[2] && TeamScore[0] != TeamScore[3] &&
            TeamScore[1] != TeamScore[2] && TeamScore[2] != TeamScore[3])
        {
            if (AverageBT < AverageDT)
            {
                win = 3;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                csgmg.GameEndRead(win);
            }
            if (AverageDT < AverageBT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageBT == AverageDT)
            {
                win = 1;
                isWin = true;
                isAT = false;
                isBT = true;
                isCT = false;
                isDT = false;
                csgmg.GameEndRead(win);
            }
        } //B D

        if (TeamScore[2] == TeamScore[3] && TeamScore[0] != TeamScore[1] &&
            TeamScore[0] != TeamScore[2] && TeamScore[0] != TeamScore[3] &&
            TeamScore[1] != TeamScore[2] && TeamScore[1] != TeamScore[3])
        {
            if (AverageCT < AverageDT)
            {
                win = 3;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = false;
                isDT = true;
                csgmg.GameEndRead(win);
            }
            if (AverageDT < AverageCT)
            {
                win = 2;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                csgmg.GameEndRead(win);
            }
            if (AverageCT == AverageDT)
            {
                win = 2;
                isWin = true;
                isAT = false;
                isBT = false;
                isCT = true;
                isDT = false;
                csgmg.GameEndRead(win);
            }
        } //C D

    }

    /*-------------------------이미지 관련 함수---------------------------------*/
    void ImageUP()
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

        if (isAT && !isBT && !isCT && !isDT && Players == 1)
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

        if (isBT && !isCT && !isDT && !isAT && Players == 0)
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

        if (isBT && !isCT && !isDT && !isAT && Players == 1)
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

        if (isCT && !isDT && !isAT && !isBT && Players == 0)
        {
            if (RScore == 5)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[1];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[5];

                t_TC1RScoreText[0].text = ScoreSaveC1[1].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[2].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[3].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[4].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[6];

                t_TC1RScoreText[0].text = ScoreSaveC1[2].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[3].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[4].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[5].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[7];

                t_TC1RScoreText[0].text = ScoreSaveC1[3].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[4].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[5].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[6].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[8];

                t_TC1RScoreText[0].text = ScoreSaveC1[4].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[5].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[6].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[7].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[9];

                t_TC1RScoreText[0].text = ScoreSaveC1[5].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[6].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[7].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[8].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[10];

                t_TC1RScoreText[0].text = ScoreSaveC1[6].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[7].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[8].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[9].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[11];

                t_TC1RScoreText[0].text = ScoreSaveC1[7].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[8].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[9].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[10].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[12];

                t_TC1RScoreText[0].text = ScoreSaveC1[8].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[9].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[10].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[11].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[13];

                t_TC1RScoreText[0].text = ScoreSaveC1[9].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[10].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[11].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[12].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[14];

                t_TC1RScoreText[0].text = ScoreSaveC1[10].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[11].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[12].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[13].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[15];

                t_TC1RScoreText[0].text = ScoreSaveC1[11].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[12].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[13].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[14].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[16];

                t_TC1RScoreText[0].text = ScoreSaveC1[12].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[13].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[14].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[15].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[17];

                t_TC1RScoreText[0].text = ScoreSaveC1[13].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[14].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[15].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[16].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[18];

                t_TC1RScoreText[0].text = ScoreSaveC1[14].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[15].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[16].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[17].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[19];

                t_TC1RScoreText[0].text = ScoreSaveC1[15].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[16].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[17].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[18].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScoreC1[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreC1[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreC1[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreC1[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScoreC1[4].GetComponent<Image>().sprite = s_RScore[20];

                t_TC1RScoreText[0].text = ScoreSaveC1[16].ToString();
                t_TC1RScoreText[1].text = ScoreSaveC1[17].ToString();
                t_TC1RScoreText[2].text = ScoreSaveC1[18].ToString();
                t_TC1RScoreText[3].text = ScoreSaveC1[19].ToString();
                t_TC1RScoreText[4].text = ScoreSaveC1[20].ToString();
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

                t_TC2RScoreText[0].text = ScoreSaveC2[1].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[2].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[3].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[4].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[6];

                t_TC2RScoreText[0].text = ScoreSaveC2[2].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[3].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[4].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[5].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[7];

                t_TC2RScoreText[0].text = ScoreSaveC2[3].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[4].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[5].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[6].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[8];

                t_TC2RScoreText[0].text = ScoreSaveC2[4].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[5].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[6].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[7].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[9];

                t_TC2RScoreText[0].text = ScoreSaveC2[5].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[6].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[7].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[8].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[10];

                t_TC2RScoreText[0].text = ScoreSaveC2[6].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[7].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[8].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[9].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[11];

                t_TC2RScoreText[0].text = ScoreSaveC2[7].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[8].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[9].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[10].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[12];

                t_TC2RScoreText[0].text = ScoreSaveC2[8].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[9].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[10].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[11].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[13];

                t_TC2RScoreText[0].text = ScoreSaveC2[9].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[10].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[11].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[12].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[14];

                t_TC2RScoreText[0].text = ScoreSaveC2[10].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[11].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[12].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[13].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[15];

                t_TC2RScoreText[0].text = ScoreSaveC2[11].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[12].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[13].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[14].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[16];

                t_TC2RScoreText[0].text = ScoreSaveC2[12].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[13].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[14].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[15].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[17];

                t_TC2RScoreText[0].text = ScoreSaveC2[13].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[14].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[15].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[16].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[18];

                t_TC2RScoreText[0].text = ScoreSaveC2[14].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[15].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[16].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[17].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[19];

                t_TC2RScoreText[0].text = ScoreSaveC2[15].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[16].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[17].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[18].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScoreC2[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreC2[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreC2[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreC2[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScoreC2[4].GetComponent<Image>().sprite = s_RScore[20];

                t_TC2RScoreText[0].text = ScoreSaveC2[16].ToString();
                t_TC2RScoreText[1].text = ScoreSaveC2[17].ToString();
                t_TC2RScoreText[2].text = ScoreSaveC2[18].ToString();
                t_TC2RScoreText[3].text = ScoreSaveC2[19].ToString();
                t_TC2RScoreText[4].text = ScoreSaveC2[20].ToString();
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

                t_TD1RScoreText[0].text = ScoreSaveD1[1].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[2].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[3].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[4].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[6];

                t_TD1RScoreText[0].text = ScoreSaveD1[2].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[3].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[4].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[5].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[7];

                t_TD1RScoreText[0].text = ScoreSaveD1[3].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[4].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[5].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[6].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[8];

                t_TD1RScoreText[0].text = ScoreSaveD1[4].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[5].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[6].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[7].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[9];

                t_TD1RScoreText[0].text = ScoreSaveD1[5].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[6].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[7].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[8].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[10];

                t_TD1RScoreText[0].text = ScoreSaveD1[6].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[7].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[8].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[9].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[11];

                t_TD1RScoreText[0].text = ScoreSaveD1[7].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[8].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[9].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[10].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[12];

                t_TD1RScoreText[0].text = ScoreSaveD1[8].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[9].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[10].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[11].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[13];

                t_TD1RScoreText[0].text = ScoreSaveD1[9].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[10].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[11].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[12].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[14];

                t_TD1RScoreText[0].text = ScoreSaveD1[10].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[11].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[12].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[13].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[15];

                t_TD1RScoreText[0].text = ScoreSaveD1[11].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[12].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[13].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[14].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[15].ToString();
            }

            if (RScore == 16)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[16];
            
                t_TD1RScoreText[0].text = ScoreSaveD1[12].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[13].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[14].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[15].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[17];

                t_TD1RScoreText[0].text = ScoreSaveD1[13].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[14].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[15].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[16].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[18];

                t_TD1RScoreText[0].text = ScoreSaveD1[14].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[15].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[16].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[17].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[19];

                t_TD1RScoreText[0].text = ScoreSaveD1[15].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[16].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[17].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[18].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScoreD1[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreD1[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreD1[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreD1[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScoreD1[4].GetComponent<Image>().sprite = s_RScore[20];
            
                t_TD1RScoreText[0].text = ScoreSaveD1[16].ToString();
                t_TD1RScoreText[1].text = ScoreSaveD1[17].ToString();
                t_TD1RScoreText[2].text = ScoreSaveD1[18].ToString();
                t_TD1RScoreText[3].text = ScoreSaveD1[19].ToString();
                t_TD1RScoreText[4].text = ScoreSaveD1[20].ToString();
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

                t_TD2RScoreText[0].text = ScoreSaveD2[1].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[2].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[3].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[4].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[5].ToString();
            }

            if (RScore == 6)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[2];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[6];

                t_TD2RScoreText[0].text = ScoreSaveD2[2].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[3].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[4].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[5].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[6].ToString();
            }

            if (RScore == 7)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[3];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[7];

                t_TD2RScoreText[0].text = ScoreSaveD2[3].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[4].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[5].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[6].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[7].ToString();
            }

            if (RScore == 8)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[4];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[8];

                t_TD2RScoreText[0].text = ScoreSaveD2[4].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[5].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[6].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[7].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[8].ToString();
            }

            if (RScore == 9)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[5];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[9];

                t_TD2RScoreText[0].text = ScoreSaveD2[5].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[6].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[7].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[8].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[9].ToString();
            }

            if (RScore == 10)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[6];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[10];

                t_TD2RScoreText[0].text = ScoreSaveD2[6].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[7].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[8].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[9].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[10].ToString();
            }

            if (RScore == 11)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[7];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[11];
            
                t_TD2RScoreText[0].text = ScoreSaveD2[7].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[8].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[9].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[10].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[11].ToString();
            }

            if (RScore == 12)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[8];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[12];

                t_TD2RScoreText[0].text = ScoreSaveD2[8].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[9].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[10].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[11].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[12].ToString();
            }

            if (RScore == 13)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[9];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[13];

                t_TD2RScoreText[0].text = ScoreSaveD2[9].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[10].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[11].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[12].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[13].ToString();
            }

            if (RScore == 14)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[10];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[14];

                t_TD2RScoreText[0].text = ScoreSaveD2[10].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[11].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[12].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[13].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[14].ToString();
            }

            if (RScore == 15)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[11];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[15];

                t_TD2RScoreText[0].text = ScoreSaveD2[11].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[12].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[13].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[14].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[15].ToString();
            }
    
            if (RScore == 16)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[12];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[16];

                t_TD2RScoreText[0].text = ScoreSaveD2[12].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[13].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[14].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[15].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[16].ToString();
            }

            if (RScore == 17)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[13];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[17];

                t_TD2RScoreText[0].text = ScoreSaveD2[13].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[14].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[15].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[16].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[17].ToString();
            }

            if (RScore == 18)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[14];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[18];

                t_TD2RScoreText[0].text = ScoreSaveD2[14].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[15].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[16].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[17].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[18].ToString();
            }

            if (RScore == 19)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[15];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[19];

                t_TD2RScoreText[0].text = ScoreSaveD2[15].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[16].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[17].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[18].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[19].ToString();
            }

            if (RScore == 20)
            {
                i_RScoreD2[0].GetComponent<Image>().sprite = s_RScore[16];
                i_RScoreD2[1].GetComponent<Image>().sprite = s_RScore[17];
                i_RScoreD2[2].GetComponent<Image>().sprite = s_RScore[18];
                i_RScoreD2[3].GetComponent<Image>().sprite = s_RScore[19];
                i_RScoreD2[4].GetComponent<Image>().sprite = s_RScore[20];

                t_TD2RScoreText[0].text = ScoreSaveD2[16].ToString();
                t_TD2RScoreText[1].text = ScoreSaveD2[17].ToString();
                t_TD2RScoreText[2].text = ScoreSaveD2[18].ToString();
                t_TD2RScoreText[3].text = ScoreSaveD2[19].ToString();
                t_TD2RScoreText[4].text = ScoreSaveD2[20].ToString();
            }

        }

    }

    void RoundScore(int DartScore)
    {
        if (isAT && !isBT && !isCT && !isDT && Players == 0)
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

        if (isAT && !isBT && !isCT && !isDT && Players == 1)
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

        if (isBT && !isCT && !isDT && !isAT && Players == 0)
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

        if (isBT && !isCT && !isDT && !isAT && Players == 1)
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

        if (isCT && !isDT && !isAT && !isBT && Players == 0)
        {
            ScoreSaveC1[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_TC1RScoreText[0].text = ScoreSaveC1[0].ToString();

                if (RScore == 1)
                    t_TC1RScoreText[1].text = ScoreSaveC1[1].ToString();

                if (RScore == 2)
                    t_TC1RScoreText[2].text = ScoreSaveC1[2].ToString();

                if (RScore == 3)
                    t_TC1RScoreText[3].text = ScoreSaveC1[3].ToString();

                if (RScore == 4)
                    t_TC1RScoreText[4].text = ScoreSaveC1[4].ToString();

                if (RScore == 5)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[1].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[2].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[3].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[4].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[5].ToString();
                }

                if (RScore == 6)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[2].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[3].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[4].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[5].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[6].ToString();
                }

                if (RScore == 7)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[3].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[4].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[5].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[6].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[7].ToString();
                }

                if (RScore == 8)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[4].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[5].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[6].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[7].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[8].ToString();
                }

                if (RScore == 9)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[5].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[6].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[7].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[8].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[9].ToString();
                }

                if (RScore == 10)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[6].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[7].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[8].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[9].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[10].ToString();
                }

                if (RScore == 11)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[7].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[8].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[9].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[10].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[11].ToString();
                }

                if (RScore == 12)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[8].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[9].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[10].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[11].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[12].ToString();
                }

                if (RScore == 13)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[9].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[10].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[11].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[12].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[13].ToString();
                }

                if (RScore == 14)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[10].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[11].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[12].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[13].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[14].ToString();
                }

                if (RScore == 15)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[11].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[12].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[13].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[14].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[15].ToString();
                }

                if (RScore == 16)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[12].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[13].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[14].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[15].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[16].ToString();
                }

                if (RScore == 17)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[13].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[14].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[15].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[16].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[17].ToString();
                }

                if (RScore == 18)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[14].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[15].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[16].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[17].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[18].ToString();
                }

                if (RScore == 19)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[15].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[16].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[17].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[18].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[19].ToString();
                }

                if (RScore == 20)
                {
                    t_TC1RScoreText[0].text = ScoreSaveC1[16].ToString();
                    t_TC1RScoreText[1].text = ScoreSaveC1[17].ToString();
                    t_TC1RScoreText[2].text = ScoreSaveC1[18].ToString();
                    t_TC1RScoreText[3].text = ScoreSaveC1[19].ToString();
                    t_TC1RScoreText[4].text = ScoreSaveC1[20].ToString();
                }
            }
        }

        if (isCT && !isDT && !isAT && !isBT && Players == 1)
        {
            ScoreSaveC2[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_TC2RScoreText[0].text = ScoreSaveC2[0].ToString();

                if (RScore == 1)
                    t_TC2RScoreText[1].text = ScoreSaveC2[1].ToString();

                if (RScore == 2)
                    t_TC2RScoreText[2].text = ScoreSaveC2[2].ToString();

                if (RScore == 3)
                    t_TC2RScoreText[3].text = ScoreSaveC2[3].ToString();

                if (RScore == 4)
                    t_TC2RScoreText[4].text = ScoreSaveC2[4].ToString();

                if (RScore == 5)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[1].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[2].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[3].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[4].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[5].ToString();
                }

                if (RScore == 6)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[2].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[3].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[4].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[5].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[6].ToString();
                }

                if (RScore == 7)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[3].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[4].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[5].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[6].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[7].ToString();
                }

                if (RScore == 8)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[4].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[5].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[6].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[7].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[8].ToString();
                }

                if (RScore == 9)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[5].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[6].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[7].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[8].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[9].ToString();
                }

                if (RScore == 10)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[6].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[7].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[8].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[9].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[10].ToString();
                }

                if (RScore == 11)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[7].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[8].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[9].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[10].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[11].ToString();
                }

                if (RScore == 12)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[8].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[9].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[10].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[11].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[12].ToString();
                }

                if (RScore == 13)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[9].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[10].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[11].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[12].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[13].ToString();
                }

                if (RScore == 14)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[10].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[11].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[12].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[13].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[14].ToString();
                }

                if (RScore == 15)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[11].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[12].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[13].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[14].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[15].ToString();
                }

                if (RScore == 16)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[12].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[13].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[14].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[15].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[16].ToString();
                }

                if (RScore == 17)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[13].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[14].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[15].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[16].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[17].ToString();
                }

                if (RScore == 18)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[14].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[15].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[16].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[17].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[18].ToString();
                }

                if (RScore == 19)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[15].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[16].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[17].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[18].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[19].ToString();
                }

                if (RScore == 20)
                {
                    t_TC2RScoreText[0].text = ScoreSaveC2[16].ToString();
                    t_TC2RScoreText[1].text = ScoreSaveC2[17].ToString();
                    t_TC2RScoreText[2].text = ScoreSaveC2[18].ToString();
                    t_TC2RScoreText[3].text = ScoreSaveC2[19].ToString();
                    t_TC2RScoreText[4].text = ScoreSaveC2[20].ToString();
                }
            }
        }

        if (isDT && !isAT && !isBT && !isCT && Players == 0)
        {
            ScoreSaveD1[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_TD1RScoreText[0].text = ScoreSaveD1[0].ToString();

                if (RScore == 1)
                    t_TD1RScoreText[1].text = ScoreSaveD1[1].ToString();

                if (RScore == 2)
                    t_TD1RScoreText[2].text = ScoreSaveD1[2].ToString();

                if (RScore == 3)
                    t_TD1RScoreText[3].text = ScoreSaveD1[3].ToString();

                if (RScore == 4)
                    t_TD1RScoreText[4].text = ScoreSaveD1[4].ToString();

                if (RScore == 5)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[1].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[2].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[3].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[4].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[5].ToString();
                }

                if (RScore == 6)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[2].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[3].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[4].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[5].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[6].ToString();
                }

                if (RScore == 7)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[3].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[4].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[5].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[6].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[7].ToString();
                }

                if (RScore == 8)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[4].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[5].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[6].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[7].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[8].ToString();
                }

                if (RScore == 9)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[5].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[6].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[7].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[8].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[9].ToString();
                }

                if (RScore == 10)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[6].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[7].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[8].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[9].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[10].ToString();
                }

                if (RScore == 11)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[7].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[8].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[9].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[10].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[11].ToString();
                }

                if (RScore == 12)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[8].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[9].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[10].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[11].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[12].ToString();
                }

                if (RScore == 13)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[9].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[10].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[11].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[12].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[13].ToString();
                }

                if (RScore == 14)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[10].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[11].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[12].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[13].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[14].ToString();
                }

                if (RScore == 15)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[11].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[12].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[13].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[14].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[15].ToString();
                }

                if (RScore == 16)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[12].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[13].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[14].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[15].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[16].ToString();
                }

                if (RScore == 17)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[13].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[14].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[15].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[16].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[17].ToString();
                }

                if (RScore == 18)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[14].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[15].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[16].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[17].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[18].ToString();
                }

                if (RScore == 19)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[15].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[16].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[17].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[18].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[19].ToString();
                }

                if (RScore == 20)
                {
                    t_TD1RScoreText[0].text = ScoreSaveD1[16].ToString();
                    t_TD1RScoreText[1].text = ScoreSaveD1[17].ToString();
                    t_TD1RScoreText[2].text = ScoreSaveD1[18].ToString();
                    t_TD1RScoreText[3].text = ScoreSaveD1[19].ToString();
                    t_TD1RScoreText[4].text = ScoreSaveD1[20].ToString();
                }
            }
        }

        if (isDT && !isAT && !isBT && !isCT && Players == 1)
        {
            ScoreSaveD2[RScore] += DartScore;
            if (Round <= RoundStop)
            {
                if (RScore == 0)
                    t_TD2RScoreText[0].text = ScoreSaveD2[0].ToString();

                if (RScore == 1)
                    t_TD2RScoreText[1].text = ScoreSaveD2[1].ToString();

                if (RScore == 2)
                    t_TD2RScoreText[2].text = ScoreSaveD2[2].ToString();
            
                if (RScore == 3)
                    t_TD2RScoreText[3].text = ScoreSaveD2[3].ToString();

                if (RScore == 4)
                    t_TD2RScoreText[4].text = ScoreSaveD2[4].ToString();

                if (RScore == 5)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[1].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[2].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[3].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[4].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[5].ToString();
                }

                if (RScore == 6)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[2].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[3].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[4].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[5].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[6].ToString();
                }

                if (RScore == 7)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[3].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[4].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[5].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[6].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[7].ToString();
                }

                if (RScore == 8)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[4].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[5].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[6].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[7].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[8].ToString();
                }

                if (RScore == 9)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[5].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[6].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[7].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[8].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[9].ToString();
                }

                if (RScore == 10)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[6].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[7].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[8].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[9].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[10].ToString();
                }

                if (RScore == 11)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[7].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[8].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[9].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[10].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[11].ToString();
                }

                if (RScore == 12)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[8].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[9].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[10].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[11].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[12].ToString();
                }

                if (RScore == 13)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[9].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[10].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[11].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[12].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[13].ToString();
                }

                if (RScore == 14)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[10].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[11].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[12].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[13].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[14].ToString();
                }

                if (RScore == 15)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[11].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[12].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[13].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[14].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[15].ToString();
                }

                if (RScore == 16)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[12].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[13].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[14].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[15].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[16].ToString();
                }

                if (RScore == 17)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[13].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[14].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[15].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[16].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[17].ToString();
                }

                if (RScore == 18)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[14].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[15].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[16].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[17].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[18].ToString();
                }

                if (RScore == 19)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[15].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[16].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[17].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[18].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[19].ToString();
                }

                if (RScore == 20)
                {
                    t_TD2RScoreText[0].text = ScoreSaveD2[16].ToString();
                    t_TD2RScoreText[1].text = ScoreSaveD2[17].ToString();
                    t_TD2RScoreText[2].text = ScoreSaveD2[18].ToString();
                    t_TD2RScoreText[3].text = ScoreSaveD2[19].ToString();
                    t_TD2RScoreText[4].text = ScoreSaveD2[20].ToString();
                }
            }
        }
    }

    void Myturn() //각 플레이어의 차레일떄 이미지변화를 주는 함수
    {
        if (isAT && !isBT && !isCT && !isDT && Players == 0)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, -10f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);
            g_TeamC.transform.position = new Vector3(g_TeamC.transform.position.x, g_TeamC.transform.position.y, 0f);
            g_TeamD.transform.position = new Vector3(g_TeamD.transform.position.x, g_TeamD.transform.position.y, 0f);

            g_TeamA.transform.localScale = new Vector3(1f, 1f);
            g_TeamB.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamC.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamD.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOn[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOff[0];
            g_i_Player[2].GetComponent<Image>().sprite = s_TeamOff[0];
            g_i_Player[3].GetComponent<Image>().sprite = s_TeamOff[0];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];

            g_T_Score[0].SetActive(true);
            g_T_Score[1].SetActive(false);
            g_T_Score[2].SetActive(false);
            g_T_Score[3].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);
            g_OffScore[3].SetActive(true);

            for (int i = 0; i < g_PPDScore.Length; i++)
            {
                g_PPDScore[i].SetActive(false);
                g_RoundScore[i].SetActive(false);
            }
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
            g_PPDScore[0].SetActive(true);
            g_RoundScore[0].SetActive(true);
        }

        if (isAT && !isBT && !isCT && !isDT && Players == 1)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, -10f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);
            g_TeamC.transform.position = new Vector3(g_TeamC.transform.position.x, g_TeamC.transform.position.y, 0f);
            g_TeamD.transform.position = new Vector3(g_TeamD.transform.position.x, g_TeamD.transform.position.y, 0f);

            g_TeamA.transform.localScale = new Vector3(1f, 1f);
            g_TeamB.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamC.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamD.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOn[1];
            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOff[1];
            g_i_Player[2].GetComponent<Image>().sprite = s_TeamOff[1];
            g_i_Player[3].GetComponent<Image>().sprite = s_TeamOff[1];

            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOn[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];

            g_T_Score[0].SetActive(true);
            g_T_Score[1].SetActive(false);
            g_T_Score[2].SetActive(false);
            g_T_Score[3].SetActive(false);

            g_OffScore[0].SetActive(false);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);
            g_OffScore[3].SetActive(true);

            for (int i = 0; i < g_PPDScore.Length; i++)
            {
                g_PPDScore[i].SetActive(false);
                g_RoundScore[i].SetActive(false);
            }
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
            g_PPDScore[1].SetActive(true);
            g_RoundScore[1].SetActive(true);
        }

        if (isBT && !isCT && !isDT&& !isAT && Players == 0)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, -10f);
            g_TeamC.transform.position = new Vector3(g_TeamC.transform.position.x, g_TeamC.transform.position.y, 0f);
            g_TeamD.transform.position = new Vector3(g_TeamD.transform.position.x, g_TeamD.transform.position.y, 0f);

            g_TeamA.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamB.transform.localScale = new Vector3(1f, 1f);
            g_TeamC.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamD.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOn[0];
            g_i_Player[2].GetComponent<Image>().sprite = s_TeamOff[0];
            g_i_Player[3].GetComponent<Image>().sprite = s_TeamOff[0];
            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOff[0];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_T_Score[1].SetActive(true);
            g_T_Score[2].SetActive(false);
            g_T_Score[3].SetActive(false);
            g_T_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[2].SetActive(true);
            g_OffScore[3].SetActive(true);
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
                i_RScoreB1[i].enabled = true;
                i_RScoreB2[i].enabled = false;
                i_RScoreC1[i].enabled = false;
                i_RScoreC2[i].enabled = false;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = false;
            }
            g_PPDScore[2].SetActive(true);
            g_RoundScore[2].SetActive(true);
        }

        if (isBT && !isCT && !isDT&& !isAT && Players == 1)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, -10f);
            g_TeamC.transform.position = new Vector3(g_TeamC.transform.position.x, g_TeamC.transform.position.y, 0f);
            g_TeamD.transform.position = new Vector3(g_TeamD.transform.position.x, g_TeamD.transform.position.y, 0f);

            g_TeamA.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamB.transform.localScale = new Vector3(1f, 1f);
            g_TeamC.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamD.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOn[1];
            g_i_Player[2].GetComponent<Image>().sprite = s_TeamOff[1];
            g_i_Player[3].GetComponent<Image>().sprite = s_TeamOff[1];
            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOff[1];

            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOn[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_T_Score[1].SetActive(true);
            g_T_Score[2].SetActive(false);
            g_T_Score[3].SetActive(false);
            g_T_Score[0].SetActive(false);

            g_OffScore[1].SetActive(false);
            g_OffScore[2].SetActive(true);
            g_OffScore[3].SetActive(true);
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
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = true;
                i_RScoreC1[i].enabled = false;
                i_RScoreC1[i].enabled = false;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = false;
            }
            g_PPDScore[3].SetActive(true);
            g_RoundScore[3].SetActive(true);
        }

        if (isCT && !isDT && !isAT && !isBT && Players == 0)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);
            g_TeamC.transform.position = new Vector3(g_TeamC.transform.position.x, g_TeamC.transform.position.y, -10f);
            g_TeamD.transform.position = new Vector3(g_TeamD.transform.position.x, g_TeamD.transform.position.y, 0f);

            g_TeamA.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamB.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamC.transform.localScale = new Vector3(1f, 1f);
            g_TeamD.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[2].GetComponent<Image>().sprite = s_TeamOn[0];
            g_i_Player[3].GetComponent<Image>().sprite = s_TeamOff[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOff[0];
            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOff[0];

            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOn[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_T_Score[2].SetActive(true);
            g_T_Score[3].SetActive(false);
            g_T_Score[1].SetActive(false);
            g_T_Score[0].SetActive(false);

            g_OffScore[2].SetActive(false);
            g_OffScore[3].SetActive(true);
            g_OffScore[1].SetActive(true);
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
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreC1[i].enabled = true;
                i_RScoreC2[i].enabled = false;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = false;
            }
            g_PPDScore[4].SetActive(true);
            g_RoundScore[4].SetActive(true);
        }

        if (isCT && !isDT && !isAT && !isBT && Players == 1)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);
            g_TeamC.transform.position = new Vector3(g_TeamC.transform.position.x, g_TeamC.transform.position.y, -10f);
            g_TeamD.transform.position = new Vector3(g_TeamD.transform.position.x, g_TeamD.transform.position.y, 0f);

            g_TeamA.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamB.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamC.transform.localScale = new Vector3(1f, 1f);
            g_TeamD.transform.localScale = new Vector3(0.75f, 0.75f);

            g_i_Player[2].GetComponent<Image>().sprite = s_TeamOn[1];
            g_i_Player[3].GetComponent<Image>().sprite = s_TeamOff[1];
            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOff[1];
            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOff[1];

            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOn[2];
            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOff[3];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];

            g_T_Score[2].SetActive(true);
            g_T_Score[3].SetActive(false);
            g_T_Score[1].SetActive(false);
            g_T_Score[0].SetActive(false);

            g_OffScore[2].SetActive(false);
            g_OffScore[3].SetActive(true);
            g_OffScore[1].SetActive(true);
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
                i_RScoreB1[i].enabled = false;
                i_RScoreB2[i].enabled = false;
                i_RScoreC1[i].enabled = false;
                i_RScoreC2[i].enabled = true;
                i_RScoreD1[i].enabled = false;
                i_RScoreD2[i].enabled = false;
            }
            g_PPDScore[5].SetActive(true);
            g_RoundScore[5].SetActive(true);
        }

        if (isDT && !isAT && !isBT && !isCT && Players == 0)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);
            g_TeamC.transform.position = new Vector3(g_TeamC.transform.position.x, g_TeamC.transform.position.y, 0f);
            g_TeamD.transform.position = new Vector3(g_TeamD.transform.position.x, g_TeamD.transform.position.y, -10f);

            g_TeamA.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamB.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamC.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamD.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[3].GetComponent<Image>().sprite = s_TeamOn[0];
            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOff[0];
            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOff[0];
            g_i_Player[2].GetComponent<Image>().sprite = s_TeamOff[0];

            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOn[3];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];

            g_T_Score[3].SetActive(true);
            g_T_Score[0].SetActive(false);
            g_T_Score[1].SetActive(false);
            g_T_Score[2].SetActive(false);

            g_OffScore[3].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);

            for (int i = 0; i < g_PPDScore.Length; i++)
            {
                g_PPDScore[i].SetActive(false);
                g_RoundScore[i].SetActive(false);
            }
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
            g_PPDScore[6].SetActive(true);
            g_RoundScore[6].SetActive(true);
        }

        if (isDT && !isAT && !isBT && !isCT && Players == 1)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);
            g_TeamC.transform.position = new Vector3(g_TeamC.transform.position.x, g_TeamC.transform.position.y, 0f);
            g_TeamD.transform.position = new Vector3(g_TeamD.transform.position.x, g_TeamD.transform.position.y, -10f);

            g_TeamA.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamB.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamC.transform.localScale = new Vector3(0.75f, 0.75f);
            g_TeamD.transform.localScale = new Vector3(1f, 1f);

            g_i_Player[3].GetComponent<Image>().sprite = s_TeamOn[1];
            g_i_Player[0].GetComponent<Image>().sprite = s_TeamOff[1];
            g_i_Player[1].GetComponent<Image>().sprite = s_TeamOff[1];
            g_i_Player[2].GetComponent<Image>().sprite = s_TeamOff[1];

            g_Teambar[3].GetComponent<Image>().sprite = s_TeambarOn[3];
            g_Teambar[0].GetComponent<Image>().sprite = s_TeambarOff[0];
            g_Teambar[1].GetComponent<Image>().sprite = s_TeambarOff[1];
            g_Teambar[2].GetComponent<Image>().sprite = s_TeambarOff[2];

            g_T_Score[3].SetActive(true);
            g_T_Score[0].SetActive(false);
            g_T_Score[1].SetActive(false);
            g_T_Score[2].SetActive(false);

            g_OffScore[3].SetActive(false);
            g_OffScore[0].SetActive(true);
            g_OffScore[1].SetActive(true);
            g_OffScore[2].SetActive(true);

            for (int i = 0; i < g_PPDScore.Length; i++)
            {
                g_PPDScore[i].SetActive(false);
                g_RoundScore[i].SetActive(false);
            }
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
            g_PPDScore[7].SetActive(true);
            g_RoundScore[7].SetActive(true);
        }

        if (Round == RoundStop && Counting == 3)
        {
            g_TeamA.transform.position = new Vector3(g_TeamA.transform.position.x, g_TeamA.transform.position.y, 0f);
            g_TeamB.transform.position = new Vector3(g_TeamB.transform.position.x, g_TeamB.transform.position.y, 0f);
            g_TeamC.transform.position = new Vector3(g_TeamC.transform.position.x, g_TeamC.transform.position.y, 0f);
            g_TeamD.transform.position = new Vector3(g_TeamD.transform.position.x, g_TeamD.transform.position.y, 0f);
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
        isCT = false;
        isDT = false;
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
        isCT = false;
        isDT = false;
        g_C_Ani.SetActive(false);
        Counting = 0;
        g_M_Score[Teams].SetActive(false);
        g_T_Score[Teams].SetActive(true);
        Teams = 0;
        g_M_Score[Teams].SetActive(true);
        g_M_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void TeamNumberPlus()//팀 바꿈
    {
        g_C_Ani.SetActive(false);
        Counting = 0;
        g_M_Score[0].SetActive(false);
        g_OffScore[0].SetActive(true);
        Teams += 1;
        if (Teams == 0)
        {
            isAT = true;
            isBT = false;
            isCT = false;
            isDT = false;
        }
        if (Teams == 1)
        {
            isBT = true;
            isCT = false;
            isDT = false;
            isAT = false;
        }
        if (Teams == 2)
        {
            isCT = true;
            isDT = false;
            isAT = false;
            isBT = false;
        }
        if(Teams==3)
        {
            isDT = true;
            isAT = false;
            isBT = false;
            isCT = false;
        }
        g_M_Score[Teams].SetActive(true);
        g_M_Score[Teams].GetComponent<csNumber>().SetNumber(TeamScore[Teams]);
    }

    void PlayerNumberMinus()//2플레이어에서 1플레이어로 넘겨주는 역활
    {
        g_C_Ani.SetActive(false);
        Counting = 0;
        g_M_Score[2].SetActive(false);
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
        Players = 1;
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
        if (Teams == 0 && Players == 1)
        {
            TotalA2 += Dart;
            AverageA2 = TotalA2 / DartCountA2;
            t_PPDText[1].text = string.Format("{0:N2}", AverageA2);
        }
        if (Teams == 1 && Players == 0)
        {
            TotalB1 += Dart;
            AverageB1 = TotalB1 / DartCountB1;
            t_PPDText[2].text = string.Format("{0:N2}", AverageB1);
        }
        if (Teams == 1 && Players == 1)
        {
            TotalB2 += Dart;
            AverageB2 = TotalB2 / DartCountB2;
            t_PPDText[3].text = string.Format("{0:N2}", AverageB2);
        }
        if (Teams == 2 && Players == 0)
        {
            TotalC1 += Dart;
            AverageC1 = TotalC1 / DartCountC1;
            t_PPDText[4].text = string.Format("{0:N2}", AverageC1);
        }
        if (Teams == 2 && Players == 1)
        {
            TotalC2 += Dart;
            AverageC2 = TotalC2 / DartCountC2;
            t_PPDText[5].text = string.Format("{0:N2}", AverageC2);
        }
        if (Teams == 3 && Players == 0)
        {
            TotalD1 += Dart;
            AverageD1 = TotalD1 / DartCountD1;
            t_PPDText[6].text = string.Format("{0:N2}", AverageD1);
        }
        if (Teams == 3 && Players == 1)
        {
            TotalD2 += Dart;
            AverageD2 = TotalD2 / DartCountD2;
            t_PPDText[7].text = string.Format("{0:N2}", AverageD2);
        }

        if (Teams == 0)
            AverageAT = AverageA1 + AverageA2 / 2;
        else if (Teams == 1)
            AverageBT = AverageB1 + AverageB2 / 2;
        else if (Teams == 2)
            AverageCT = AverageC1 + AverageC2 / 2;
        else if (Teams == 3)
            AverageDT = AverageD1 + AverageD2 / 2;
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
