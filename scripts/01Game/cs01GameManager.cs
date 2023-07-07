using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class cs01GameManager : MonoBehaviour
{
    public int TakeScore = 201;
    public int _301 = 301;
    public int _501 = 501;
    public int _701 = 701;
    public int _901 = 901;
    public int _1101 = 1101;
    public int _1501 = 1501;
    public int Round = 0;
    public int Players = 0;
    public int Teams = 0;
    public int meun1;
    public int meun2;
    public int meun3;

    public string player1;
    public string player2;
    public string player3;
    public string player4;
    public string player5;
    public string player6;
    public string player7;
    public string player8;
    public string player9;
    public string player10;
    public string player11;
    public string player12;

    public bool isOpen = false;
    public bool isAni = false;

    public GameObject G_save;
    public GameObject[] g_Playerbar = new GameObject[4];
    public GameObject[] g_TeamBar = new GameObject[3];
    public GameObject _01Banner;
    public GameObject g_Meun;
    public GameObject[] g_DAni=new GameObject[4];
    public GameObject[] g_Move = new GameObject[7];
    public GameObject[] g_WMove = new GameObject[4];
    public GameObject[] g_Dart = new GameObject[3];
    public GameObject[] g_BlueDartScore = new GameObject[3];
    public GameObject[] g_OrangDartScore = new GameObject[3];
    public GameObject[] g_BlackDartScore = new GameObject[3];
    public GameObject[] g_PPDScore = new GameObject[12];
    public GameObject[] g_RScore = new GameObject[12];
    public GameObject g_MoveOn;

    public Sprite[] s_GameName = new Sprite[7];
    public Sprite[] s_DartScore = new Sprite[5];

    public _01Meun meun;
    public Save save;
    public _01SingPlay sing;
    public _01TwoPlay Two;
    public _01ThreePlay Three;
    public _01FourPlay Four;
    public _01Dou22 dou22;
    public _01Dou222 dou222;
    public _01Dou2222 dou2222;
    public _01tir33 tir33;
    public _01tir333 tir333;
    public _01tir3333 tir3333;
    public _01Four44 four44;
    public _01Four444 four444;
    public _01Five55 five55;
    public _01Hexa hexa66;

	void Awake ()
    { 
        G_save = GameObject.FindWithTag("Save");
        save = G_save.GetComponent<Save>();

        meun2 = save.meun2;
        meun3 = save.meun3;
        meun1 = save.meun1;
        Players = save.Players;
        Teams = save.Teams;

        player1 = save.player1;
        player2 = save.player2;
        player3 = save.player3;
        player4 = save.player4;
        player5 = save.player5;
        player6 = save.player6;
        player7 = save.player7;
        player8 = save.player8;
        player9 = save.player9;
        player10 = save.player10;
        player11 = save.player11;
        player12 = save.player12;

        for (int i = 0; i < g_Playerbar.Length; i++)
            g_Playerbar[i].SetActive(false);
        for (int i = 0; i < g_TeamBar.Length; i++)
            g_TeamBar[i].SetActive(false);

        sing = g_Playerbar[0].GetComponent<_01SingPlay>();
        Two = g_Playerbar[1].GetComponent<_01TwoPlay>();
        Three = g_Playerbar[2].GetComponent<_01ThreePlay>();
        Four = g_Playerbar[3].GetComponent<_01FourPlay>();

        dou22= g_TeamBar[0].GetComponent<_01Dou22>();
        tir33 = g_TeamBar[0].GetComponent<_01tir33>();
        four44 = g_TeamBar[0].GetComponent<_01Four44>();
        five55 = g_TeamBar[0].GetComponent<_01Five55>();
        hexa66 = g_TeamBar[0].GetComponent<_01Hexa>();

        dou222 = g_TeamBar[1].GetComponent<_01Dou222>();
        tir333 = g_TeamBar[1].GetComponent<_01tir333>();
        four444 = g_TeamBar[1].GetComponent<_01Four444>();

        dou2222 = g_TeamBar[2].GetComponent<_01Dou2222>();
        tir3333 = g_TeamBar[2].GetComponent<_01tir3333>();

        for(int i=0;i<g_BlackDartScore.Length;i++)
        {
            g_BlackDartScore[i].GetComponent<csNumber>().CreateNumber(2, 65, 1f, 0);
            g_BlueDartScore[i].GetComponent<csNumber>().CreateNumber(2, 65, 1f, 0);
            g_OrangDartScore[i].GetComponent<csNumber>().CreateNumber(2, 65, 1f, 0);
            g_BlackDartScore[i].GetComponent<csNumber>().SetNumber(-1);
            g_OrangDartScore[i].GetComponent<csNumber>().SetNumber(-1);
            g_BlueDartScore[i].GetComponent<csNumber>().SetNumber(-1);
        }

        g_Meun.SetActive(false);

        for (int i = 0; i < g_DAni.Length; i++)
            g_DAni[i].SetActive(false);
        for (int i = 0; i < g_WMove.Length; i++)
            g_WMove[i].SetActive(false);

        for(int i=0;i< g_PPDScore.Length;i++)
        {
            g_PPDScore[i].SetActive(false);
            g_RScore[i].SetActive(false);
        }

        Mono(meun1,meun2, meun3);
        Team(meun1,meun2, meun3);


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && Input.GetKeyDown(KeyCode.LeftAlt) && !isOpen ||( csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1004 && !isOpen))
        {
            isOpen = true;
            g_Meun.SetActive(true);
            csSingleton.getInstance.g_bSwitch = false;
        }

        else if(Input.GetKeyDown(KeyCode.C)&& isOpen &&meun.m_nMeunSelect<=0||
            (csSingleton.getInstance.g_bSwitch&&csSingleton.getInstance.g_nSwitch==1004&& isOpen &&meun.m_nMeunSelect<=0))
        {
            meun.m_nMeunSelect = -1;
            meun.Expain.enabled = true;
            meun.RuleExpaln.SetActive(false);
        }

        else if (Input.GetKeyDown(KeyCode.C) && isOpen && meun.m_nMeunSelect==-1 ||
            (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1004 && isOpen && meun.m_nMeunSelect == -1))
        {
            isOpen = false;
            g_Meun.SetActive(false);
            meun.m_nMeunSelect = 0;
            csSingleton.getInstance.g_bSwitch = false;
        }

        if (Input.GetKeyDown(KeyCode.Q) && isOpen || (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1005 && isOpen))
        {
            g_Meun.GetComponent<_01Meun>().ArrowButton(100);
            csSingleton.getInstance.g_bSwitch = false;
        }

        if (Input.GetKeyDown(KeyCode.W) && isOpen || (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1000 && isOpen))
        {
            g_Meun.GetComponent<_01Meun>().ArrowButton(0);
            csSingleton.getInstance.g_bSwitch = false;
        }

        if (Input.GetKeyDown(KeyCode.S) && isOpen ||( csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1001 && isOpen))
        {
            g_Meun.GetComponent<_01Meun>().ArrowButton(1);
            csSingleton.getInstance.g_bSwitch = false;
        }

        
    }

    void Mono(int meun1, int meun2, int meun3)
    {
        switch (meun1)
        {
            case 0:
                {
                    switch (meun2)
                    {
                        case 2:
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[6];
                                Round = 8;
                                switch (meun3)
                                {
                                    case 0:
                                        {
                                            g_Playerbar[0].SetActive(true);
                                            sing.DefultScore = TakeScore;
                                            sing.RoundStop = Round;
                                            sing.player1 = player1;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 1:
                                        {
                                            g_Playerbar[1].SetActive(true);
                                            Two.DefultScore = TakeScore;
                                            Two.RoundStop = Round;
                                            Two.Players = Players;
                                            Two.playerName[0] = player1;
                                            Two.playerName[1] = player2;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                            g_PPDScore[1].SetActive(false);
                                            g_RScore[1].SetActive(false);
                                        }
                                        break;
                                    case 2:
                                        {
                                            g_Playerbar[2].SetActive(true);
                                            Three.DefultScore = TakeScore;
                                            Three.RoundStop = Round;
                                            Three.Players = Players;
                                            Three.playerName[0] = player1;
                                            Three.playerName[1] = player2;
                                            Three.playerName[2] = player3;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 3:
                                        {
                                            g_Playerbar[3].SetActive(true);
                                            Four.DefultScore = TakeScore;
                                            Four.RoundStop = Round;
                                            Four.Players = Players;
                                            Four.playerName[0] = player1;
                                            Four.playerName[1] = player2;
                                            Four.playerName[2] = player3;
                                            Four.playerName[3] = player4;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;
                    }
                }
                break;
            case 1:
                {
                    switch (meun2)
                    {
                        case 0://301
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[0];
                                Round = 10;
                                switch (meun3)
                                {
                                    case 0:
                                        {
                                            g_Playerbar[0].SetActive(true);
                                            sing.DefultScore = _301;
                                            sing.RoundStop = Round;
                                            sing.player1 = player1;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 1:
                                        {
                                            g_Playerbar[1].SetActive(true);
                                            Two.DefultScore = _301;
                                            Two.RoundStop = Round;
                                            Two.Players = Players;
                                            Two.playerName[0] = player1;
                                            Two.playerName[1] = player2;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                            g_PPDScore[1].SetActive(false);
                                            g_RScore[1].SetActive(false);
                                        }
                                        break;
                                    case 2:
                                        {
                                            g_Playerbar[2].SetActive(true);
                                            Three.DefultScore = _301;
                                            Three.RoundStop = Round;
                                            Three.Players = Players;
                                            Three.playerName[0] = player1;
                                            Three.playerName[1] = player2;
                                            Three.playerName[2] = player3;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 3:
                                        {
                                            g_Playerbar[3].SetActive(true);
                                            Four.DefultScore = _301;
                                            Four.RoundStop = Round;
                                            Four.Players = Players;
                                            Four.playerName[0] = player1;
                                            Four.playerName[1] = player2;
                                            Four.playerName[2] = player3;
                                            Four.playerName[3] = player4;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;

                        case 1://501
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[1];
                                Round = 10;
                                switch (meun3)
                                {
                                    case 0:
                                        {
                                            g_Playerbar[0].SetActive(true);
                                            sing.DefultScore = _501;
                                            sing.RoundStop = Round;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 1:
                                        {
                                            g_Playerbar[1].SetActive(true);
                                            Two.DefultScore = _501;
                                            Two.RoundStop = Round;
                                            Two.Players = Players;
                                            Two.playerName[0] = player1;
                                            Two.playerName[1] = player2;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                            g_PPDScore[1].SetActive(false);
                                            g_RScore[1].SetActive(false);
                                        }
                                        break;
                                    case 2:
                                        {
                                            g_Playerbar[2].SetActive(true);
                                            Three.DefultScore = _501;
                                            Three.RoundStop = Round;
                                            Three.Players = Players;
                                            Three.playerName[0] = player1;
                                            Three.playerName[1] = player2;
                                            Three.playerName[2] = player3;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 3:
                                        {
                                            g_Playerbar[3].SetActive(true);
                                            Four.DefultScore = _501;
                                            Four.RoundStop = Round;
                                            Four.Players = Players;
                                            Four.playerName[0] = player1;
                                            Four.playerName[1] = player2;
                                            Four.playerName[2] = player3;
                                            Four.playerName[3] = player4;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;

                        case 2://701
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[2];
                                Round = 15;
                                switch (meun3)
                                {
                                    case 0:
                                        {
                                            g_Playerbar[0].SetActive(true);
                                            sing.DefultScore = _501;
                                            sing.RoundStop = Round;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 1:
                                        {
                                            g_Playerbar[1].SetActive(true);
                                            Two.DefultScore = _501;
                                            Two.RoundStop = Round;
                                            Two.Players = Players;
                                            Two.playerName[0] = player1;
                                            Two.playerName[1] = player2;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                            g_PPDScore[1].SetActive(false);
                                            g_RScore[1].SetActive(false);
                                        }
                                        break;
                                    case 2:
                                        {
                                            g_Playerbar[2].SetActive(true);
                                            Three.DefultScore = _501;
                                            Three.RoundStop = Round;
                                            Three.Players = Players;
                                            Three.playerName[0] = player1;
                                            Three.playerName[1] = player2;
                                            Three.playerName[2] = player3;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 3:
                                        {
                                            g_Playerbar[3].SetActive(true);
                                            Four.DefultScore = _501;
                                            Four.RoundStop = Round;
                                            Four.Players = Players;
                                            Four.playerName[0] = player1;
                                            Four.playerName[1] = player2;
                                            Four.playerName[2] = player3;
                                            Four.playerName[3] = player4;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;

                        case 3://901
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[2];
                                Round = 20;
                                sing.RoundStop = Round;
                                switch (meun3)
                                {
                                    case 0:
                                        {
                                            g_Playerbar[0].SetActive(true);
                                            sing.DefultScore = _901;
                                            sing.RoundStop = Round;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 1:
                                        {
                                            g_Playerbar[1].SetActive(true);
                                            Two.DefultScore = _901;
                                            Two.RoundStop = Round;
                                            Two.Players = Players;
                                            Two.playerName[0] = player1;
                                            Two.playerName[1] = player2;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 2:
                                        {
                                            g_Playerbar[2].SetActive(true);
                                            Three.DefultScore = _901;
                                            Three.RoundStop = Round;
                                            Three.Players = Players;
                                            Three.playerName[0] = player1;
                                            Three.playerName[1] = player2;
                                            Three.playerName[2] = player3;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 3:
                                        {
                                            g_Playerbar[3].SetActive(true);
                                            Four.DefultScore = _901;
                                            Four.RoundStop = Round;
                                            Four.Players = Players;
                                            Four.playerName[0] = player1;
                                            Four.playerName[1] = player2;
                                            Four.playerName[2] = player3;
                                            Four.playerName[3] = player4;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;

                        case 4://1101
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[3];
                                Round = 20;
                                switch (meun3)
                                {
                                    case 0:
                                        {
                                            g_Playerbar[0].SetActive(true);
                                            sing.DefultScore = _1101;
                                            sing.RoundStop = Round;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 1:
                                        {
                                            g_Playerbar[1].SetActive(true);
                                            Two.DefultScore = _1101;
                                            Two.RoundStop = Round;
                                            Two.Players = Players;
                                            Two.playerName[0] = player1;
                                            Two.playerName[1] = player2;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 2:
                                        {
                                            g_Playerbar[2].SetActive(true);
                                            Three.DefultScore = _1101;
                                            Three.RoundStop = Round;
                                            Three.Players = Players;
                                            Three.playerName[0] = player1;
                                            Three.playerName[1] = player2;
                                            Three.playerName[2] = player3;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 3:
                                        {
                                            g_Playerbar[3].SetActive(true);
                                            Four.DefultScore = _1101;
                                            Four.RoundStop = Round;
                                            Four.Players = Players;
                                            Four.playerName[0] = player1;
                                            Four.playerName[1] = player2;
                                            Four.playerName[2] = player3;
                                            Four.playerName[3] = player4;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;

                        case 5://1501
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[4];
                                Round = 20;
                                switch (meun3)
                                {
                                    case 0:
                                        {
                                            g_Playerbar[0].SetActive(true);
                                            sing.DefultScore = _1501;
                                            sing.RoundStop = Round;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 1:
                                        {
                                            g_Playerbar[1].SetActive(true);
                                            Two.DefultScore = _1501;
                                            Two.RoundStop = Round;
                                            Two.Players = Players;
                                            Two.playerName[0] = player1;
                                            Two.playerName[1] = player2;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 2:
                                        {
                                            g_Playerbar[2].SetActive(true);
                                            Three.DefultScore = _1501;
                                            Three.RoundStop = Round;
                                            Three.Players = Players;
                                            Three.playerName[0] = player1;
                                            Three.playerName[1] = player2;
                                            Three.playerName[2] = player3;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 3:
                                        {
                                            g_Playerbar[3].SetActive(true);
                                            Four.DefultScore = _1501;
                                            Four.RoundStop = Round;
                                            Four.Players = Players;
                                            Four.playerName[0] = player1;
                                            Four.playerName[1] = player2;
                                            Four.playerName[2] = player3;
                                            Four.playerName[3] = player4;
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;
                    }
                }break;
        }
    }

    void Team(int meun1, int meun2, int meun3)
    {
        switch (meun1)
        {
            case 0:
                {
                    switch (meun2)
                    {
                        case 2://301
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[6];
                                Round = 8;
                                switch (meun3)
                                {
                                    case 4: //22
                                        {
                                            dou22.enabled = true;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            dou22.DefultScore = TakeScore;
                                            dou22.RoundStop = Round;
                                            dou22.Players = Players;
                                            dou22.Teams = Teams;

                                            dou22.PlayerName[0] = player1;
                                            dou22.PlayerName[1] = player2;
                                            dou22.PlayerName[2] = player3;
                                            dou22.PlayerName[3] = player4;

                                            dou22.TeamName[0] = "A";
                                            dou22.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);

                                        }
                                        break;
                                    case 5: //222
                                        {
                                            dou222.enabled = true;
                                            tir333.enabled = false;
                                            four444.enabled = false;

                                            dou222.DefultScore = TakeScore;
                                            dou222.RoundStop = Round;
                                            dou222.Players = Players;
                                            dou222.Teams = Teams;

                                            dou222.PlayerName[0] = player1;
                                            dou222.PlayerName[1] = player2;
                                            dou222.PlayerName[2] = player3;
                                            dou222.PlayerName[3] = player4;
                                            dou222.PlayerName[4] = player5;

                                            dou222.PlayerName[5] = player6;
                                            dou222.TeamName[0] = "A";
                                            dou222.TeamName[1] = "B";
                                            dou222.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 6: //2222
                                        {
                                            dou2222.enabled = true;
                                            tir3333.enabled = false;

                                            dou2222.DefultScore = TakeScore;
                                            dou2222.RoundStop = Round;
                                            dou2222.Players = Players;
                                            dou2222.Teams = Teams;

                                            dou2222.PlayerName[0] = player1;
                                            dou2222.PlayerName[1] = player2;
                                            dou2222.PlayerName[2] = player3;
                                            dou2222.PlayerName[3] = player4;
                                            dou2222.PlayerName[4] = player5;
                                            dou2222.PlayerName[5] = player6;
                                            dou2222.PlayerName[6] = player7;
                                            dou2222.PlayerName[7] = player8;

                                            dou2222.TeamName[0] = "A";
                                            dou2222.TeamName[1] = "B";
                                            dou2222.TeamName[2] = "C";
                                            dou2222.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 7: //33
                                        {
                                            tir33.enabled = true;
                                            dou22.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            tir33.DefultScore = TakeScore;
                                            tir33.RoundStop = Round;
                                            tir33.Players = Players;
                                            tir33.Teams = Teams;

                                            tir33.PlayerName[0] = player1;
                                            tir33.PlayerName[1] = player2;
                                            tir33.PlayerName[2] = player3;
                                            tir33.PlayerName[3] = player4;
                                            tir33.PlayerName[4] = player5;
                                            tir33.PlayerName[5] = player6;

                                            tir33.TeamName[0] = "A";
                                            tir33.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 8: //333
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = true;
                                            four444.enabled = false;

                                            tir333.DefultScore = TakeScore;
                                            tir333.RoundStop = Round;
                                            tir333.Players = Players;
                                            tir333.Teams = Teams;

                                            tir333.PlayerName[0] = player1;
                                            tir333.PlayerName[1] = player2;
                                            tir333.PlayerName[2] = player3;
                                            tir333.PlayerName[3] = player4;
                                            tir333.PlayerName[4] = player5;
                                            tir333.PlayerName[5] = player6;
                                            tir333.PlayerName[6] = player7;
                                            tir333.PlayerName[7] = player8;
                                            tir333.PlayerName[8] = player9;

                                            tir333.TeamName[0] = "A";
                                            tir333.TeamName[1] = "B";
                                            tir333.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 9: //3333
                                        {
                                            dou2222.enabled = false;
                                            tir3333.enabled = true;

                                            tir3333.DefultScore = TakeScore;
                                            tir3333.RoundStop = Round;
                                            tir3333.Players = Players;
                                            tir3333.Teams = Teams;

                                            tir3333.PlayerName[0] = player1;
                                            tir3333.PlayerName[1] = player2;
                                            tir3333.PlayerName[2] = player3;
                                            tir3333.PlayerName[3] = player4;
                                            tir3333.PlayerName[4] = player5;
                                            tir3333.PlayerName[5] = player6;
                                            tir3333.PlayerName[6] = player7;
                                            tir3333.PlayerName[7] = player8;
                                            tir3333.PlayerName[8] = player9;
                                            tir3333.PlayerName[9] = player10;
                                            tir3333.PlayerName[10] = player11;
                                            tir3333.PlayerName[11] = player12;

                                            tir3333.TeamName[0] = "A";
                                            tir3333.TeamName[1] = "B";
                                            tir3333.TeamName[2] = "C";
                                            tir3333.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 10: //44
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = true;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            four44.DefultScore = TakeScore;
                                            four44.RoundStop = Round;
                                            four44.Players = Players;
                                            four44.Teams = Teams;

                                            four44.PlayerName[0] = player1;
                                            four44.PlayerName[1] = player2;
                                            four44.PlayerName[2] = player3;
                                            four44.PlayerName[3] = player4;
                                            four44.PlayerName[4] = player5;
                                            four44.PlayerName[5] = player6;
                                            four44.PlayerName[6] = player7;
                                            four44.PlayerName[7] = player8;

                                            four44.TeamName[0] = "A";
                                            four44.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 11: //444
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = false;
                                            four444.enabled = true;

                                            four444.DefultScore = TakeScore;
                                            four444.RoundStop = Round;
                                            four444.Players = Players;
                                            four444.Teams = Teams;

                                            four444.PlayerName[0] = player1;
                                            four444.PlayerName[1] = player2;
                                            four444.PlayerName[2] = player3;
                                            four444.PlayerName[3] = player4;
                                            four444.PlayerName[4] = player5;
                                            four444.PlayerName[5] = player6;
                                            four444.PlayerName[6] = player7;
                                            four444.PlayerName[7] = player8;
                                            four444.PlayerName[8] = player9;
                                            four444.PlayerName[9] = player10;
                                            four444.PlayerName[10] = player11;
                                            four444.PlayerName[11] = player12;

                                            four444.TeamName[0] = "A";
                                            four444.TeamName[1] = "B";
                                            four444.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 12: //55
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = true;
                                            hexa66.enabled = false;

                                            five55.DefultScore = TakeScore;
                                            five55.RoundStop = Round;
                                            five55.Players = Players;
                                            five55.Teams = Teams;

                                            five55.PlayerName[0] = player1;
                                            five55.PlayerName[1] = player2;
                                            five55.PlayerName[2] = player3;
                                            five55.PlayerName[3] = player4;
                                            five55.PlayerName[4] = player5;
                                            five55.PlayerName[5] = player6;
                                            five55.PlayerName[6] = player7;
                                            five55.PlayerName[7] = player8;
                                            five55.PlayerName[8] = player9;
                                            five55.PlayerName[9] = player10;

                                            five55.TeamName[0] = "A";
                                            five55.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 13: //66
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = true;

                                            hexa66.DefultScore = TakeScore;
                                            hexa66.RoundStop = Round;
                                            hexa66.Players = Players;
                                            hexa66.Teams = Teams;

                                            hexa66.PlayerName[0] = player1;
                                            hexa66.PlayerName[1] = player2;
                                            hexa66.PlayerName[2] = player3;
                                            hexa66.PlayerName[3] = player4;
                                            hexa66.PlayerName[4] = player5;
                                            hexa66.PlayerName[5] = player6;
                                            hexa66.PlayerName[6] = player7;
                                            hexa66.PlayerName[7] = player8;
                                            hexa66.PlayerName[8] = player9;
                                            hexa66.PlayerName[9] = player10;
                                            hexa66.PlayerName[10] = player11;
                                            hexa66.PlayerName[11] = player12;

                                            hexa66.TeamName[0] = "A";
                                            hexa66.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;
                    }
                }
                break;
            case 1:
                {
                    switch (meun2)
                    {
                        case 0://301
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[0];
                                Round = 10;
                                switch (meun3)
                                {
                                    case 4: //22
                                        {
                                            dou22.enabled = true;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            dou22.DefultScore = _301;
                                            dou22.RoundStop = Round;
                                            dou22.Players = Players;
                                            dou22.Teams = Teams;

                                            dou22.PlayerName[0] = player1;
                                            dou22.PlayerName[1] = player2;
                                            dou22.PlayerName[2] = player3;
                                            dou22.PlayerName[3] = player4;

                                            dou22.TeamName[0] = "A";
                                            dou22.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);

                                        }
                                        break;
                                    case 5: //222
                                        {
                                            dou222.enabled = true;
                                            tir333.enabled = false;
                                            four444.enabled = false;

                                            dou222.DefultScore = _301;
                                            dou222.RoundStop = Round;
                                            dou222.Players = Players;
                                            dou222.Teams = Teams;

                                            dou222.PlayerName[0] = player1;
                                            dou222.PlayerName[1] = player2;
                                            dou222.PlayerName[2] = player3;
                                            dou222.PlayerName[3] = player4;
                                            dou222.PlayerName[4] = player5;

                                            dou222.PlayerName[5] = player6;
                                            dou222.TeamName[0] = "A";
                                            dou222.TeamName[1] = "B";
                                            dou222.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 6: //2222
                                        {
                                            dou2222.enabled = true;
                                            tir3333.enabled = false;

                                            dou2222.DefultScore = _301;
                                            dou2222.RoundStop = Round;
                                            dou2222.Players = Players;
                                            dou2222.Teams = Teams;

                                            dou2222.PlayerName[0] = player1;
                                            dou2222.PlayerName[1] = player2;
                                            dou2222.PlayerName[2] = player3;
                                            dou2222.PlayerName[3] = player4;
                                            dou2222.PlayerName[4] = player5;
                                            dou2222.PlayerName[5] = player6;
                                            dou2222.PlayerName[6] = player7;
                                            dou2222.PlayerName[7] = player8;

                                            dou2222.TeamName[0] = "A";
                                            dou2222.TeamName[1] = "B";
                                            dou2222.TeamName[2] = "C";
                                            dou2222.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 7: //33
                                        {
                                            tir33.enabled = true;
                                            dou22.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            tir33.DefultScore = _301;
                                            tir33.RoundStop = Round;
                                            tir33.Players = Players;
                                            tir33.Teams = Teams;

                                            tir33.PlayerName[0] = player1;
                                            tir33.PlayerName[1] = player2;
                                            tir33.PlayerName[2] = player3;
                                            tir33.PlayerName[3] = player4;
                                            tir33.PlayerName[4] = player5;
                                            tir33.PlayerName[5] = player6;

                                            tir33.TeamName[0] = "A";
                                            tir33.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 8: //333
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = true;
                                            four444.enabled = false;

                                            tir333.DefultScore = _301;
                                            tir333.RoundStop = Round;
                                            tir333.Players = Players;
                                            tir333.Teams = Teams;

                                            tir333.PlayerName[0] = player1;
                                            tir333.PlayerName[1] = player2;
                                            tir333.PlayerName[2] = player3;
                                            tir333.PlayerName[3] = player4;
                                            tir333.PlayerName[4] = player5;
                                            tir333.PlayerName[5] = player6;
                                            tir333.PlayerName[6] = player7;
                                            tir333.PlayerName[7] = player8;
                                            tir333.PlayerName[8] = player9;

                                            tir333.TeamName[0] = "A";
                                            tir333.TeamName[1] = "B";
                                            tir333.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 9: //3333
                                        {
                                            dou2222.enabled = false;
                                            tir3333.enabled = true;

                                            tir3333.DefultScore = _301;
                                            tir3333.RoundStop = Round;
                                            tir3333.Players = Players;
                                            tir3333.Teams = Teams;

                                            tir3333.PlayerName[0] = player1;
                                            tir3333.PlayerName[1] = player2;
                                            tir3333.PlayerName[2] = player3;
                                            tir3333.PlayerName[3] = player4;
                                            tir3333.PlayerName[4] = player5;
                                            tir3333.PlayerName[5] = player6;
                                            tir3333.PlayerName[6] = player7;
                                            tir3333.PlayerName[7] = player8;
                                            tir3333.PlayerName[8] = player9;
                                            tir3333.PlayerName[9] = player10;
                                            tir3333.PlayerName[10] = player11;
                                            tir3333.PlayerName[11] = player12;

                                            tir3333.TeamName[0] = "A";
                                            tir3333.TeamName[1] = "B";
                                            tir3333.TeamName[2] = "C";
                                            tir3333.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 10: //44
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = true;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            four44.DefultScore = _301;
                                            four44.RoundStop = Round;
                                            four44.Players = Players;
                                            four44.Teams = Teams;

                                            four44.PlayerName[0] = player1;
                                            four44.PlayerName[1] = player2;
                                            four44.PlayerName[2] = player3;
                                            four44.PlayerName[3] = player4;
                                            four44.PlayerName[4] = player5;
                                            four44.PlayerName[5] = player6;
                                            four44.PlayerName[6] = player7;
                                            four44.PlayerName[7] = player8;

                                            four44.TeamName[0] = "A";
                                            four44.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 11: //444
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = false;
                                            four444.enabled = true;

                                            four444.DefultScore = _301;
                                            four444.RoundStop = Round;
                                            four444.Players = Players;
                                            four444.Teams = Teams;

                                            four444.PlayerName[0] = player1;
                                            four444.PlayerName[1] = player2;
                                            four444.PlayerName[2] = player3;
                                            four444.PlayerName[3] = player4;
                                            four444.PlayerName[4] = player5;
                                            four444.PlayerName[5] = player6;
                                            four444.PlayerName[6] = player7;
                                            four444.PlayerName[7] = player8;
                                            four444.PlayerName[8] = player9;
                                            four444.PlayerName[9] = player10;
                                            four444.PlayerName[10] = player11;
                                            four444.PlayerName[11] = player12;

                                            four444.TeamName[0] = "A";
                                            four444.TeamName[1] = "B";
                                            four444.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 12: //55
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = true;
                                            hexa66.enabled = false;

                                            five55.DefultScore = _301;
                                            five55.RoundStop = Round;
                                            five55.Players = Players;
                                            five55.Teams = Teams;

                                            five55.PlayerName[0] = player1;
                                            five55.PlayerName[1] = player2;
                                            five55.PlayerName[2] = player3;
                                            five55.PlayerName[3] = player4;
                                            five55.PlayerName[4] = player5;
                                            five55.PlayerName[5] = player6;
                                            five55.PlayerName[6] = player7;
                                            five55.PlayerName[7] = player8;
                                            five55.PlayerName[8] = player9;
                                            five55.PlayerName[9] = player10;

                                            five55.TeamName[0] = "A";
                                            five55.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 13: //66
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = true;

                                            hexa66.DefultScore = _301;
                                            hexa66.RoundStop = Round;
                                            hexa66.Players = Players;
                                            hexa66.Teams = Teams;

                                            hexa66.PlayerName[0] = player1;
                                            hexa66.PlayerName[1] = player2;
                                            hexa66.PlayerName[2] = player3;
                                            hexa66.PlayerName[3] = player4;
                                            hexa66.PlayerName[4] = player5;
                                            hexa66.PlayerName[5] = player6;
                                            hexa66.PlayerName[6] = player7;
                                            hexa66.PlayerName[7] = player8;
                                            hexa66.PlayerName[8] = player9;
                                            hexa66.PlayerName[9] = player10;
                                            hexa66.PlayerName[10] = player11;
                                            hexa66.PlayerName[11] = player12;

                                            hexa66.TeamName[0] = "A";
                                            hexa66.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;

                        case 1://501
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[0];
                                Round = 10;
                                switch (meun3)
                                {
                                    case 4: //22
                                        {
                                            dou22.enabled = true;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            dou22.DefultScore = _501;
                                            dou22.RoundStop = Round;
                                            dou22.Players = Players;
                                            dou22.Teams = Teams;

                                            dou22.PlayerName[0] = player1;
                                            dou22.PlayerName[1] = player2;
                                            dou22.PlayerName[2] = player3;
                                            dou22.PlayerName[3] = player4;

                                            dou22.TeamName[0] = "A";
                                            dou22.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);

                                        }
                                        break;
                                    case 5: //222
                                        {
                                            dou222.enabled = true;
                                            tir333.enabled = false;
                                            four444.enabled = false;

                                            dou222.DefultScore = _501;
                                            dou222.RoundStop = Round;
                                            dou222.Players = Players;
                                            dou222.Teams = Teams;

                                            dou222.PlayerName[0] = player1;
                                            dou222.PlayerName[1] = player2;
                                            dou222.PlayerName[2] = player3;
                                            dou222.PlayerName[3] = player4;
                                            dou222.PlayerName[4] = player5;

                                            dou222.PlayerName[5] = player6;
                                            dou222.TeamName[0] = "A";
                                            dou222.TeamName[1] = "B";
                                            dou222.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 6: //2222
                                        {
                                            dou2222.enabled = true;
                                            tir3333.enabled = false;

                                            dou2222.DefultScore = _501;
                                            dou2222.RoundStop = Round;
                                            dou2222.Players = Players;
                                            dou2222.Teams = Teams;

                                            dou2222.PlayerName[0] = player1;
                                            dou2222.PlayerName[1] = player2;
                                            dou2222.PlayerName[2] = player3;
                                            dou2222.PlayerName[3] = player4;
                                            dou2222.PlayerName[4] = player5;
                                            dou2222.PlayerName[5] = player6;
                                            dou2222.PlayerName[6] = player7;
                                            dou2222.PlayerName[7] = player8;

                                            dou2222.TeamName[0] = "A";
                                            dou2222.TeamName[1] = "B";
                                            dou2222.TeamName[2] = "C";
                                            dou2222.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 7: //33
                                        {
                                            tir33.enabled = true;
                                            dou22.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            tir33.DefultScore = _501;
                                            tir33.RoundStop = Round;
                                            tir33.Players = Players;
                                            tir33.Teams = Teams;

                                            tir33.PlayerName[0] = player1;
                                            tir33.PlayerName[1] = player2;
                                            tir33.PlayerName[2] = player3;
                                            tir33.PlayerName[3] = player4;
                                            tir33.PlayerName[4] = player5;
                                            tir33.PlayerName[5] = player6;

                                            tir33.TeamName[0] = "A";
                                            tir33.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 8: //333
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = true;
                                            four444.enabled = false;

                                            tir333.DefultScore = _501;
                                            tir333.RoundStop = Round;
                                            tir333.Players = Players;
                                            tir333.Teams = Teams;

                                            tir333.PlayerName[0] = player1;
                                            tir333.PlayerName[1] = player2;
                                            tir333.PlayerName[2] = player3;
                                            tir333.PlayerName[3] = player4;
                                            tir333.PlayerName[4] = player5;
                                            tir333.PlayerName[5] = player6;
                                            tir333.PlayerName[6] = player7;
                                            tir333.PlayerName[7] = player8;
                                            tir333.PlayerName[8] = player9;

                                            tir333.TeamName[0] = "A";
                                            tir333.TeamName[1] = "B";
                                            tir333.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 9: //3333
                                        {
                                            dou2222.enabled = false;
                                            tir3333.enabled = true;

                                            tir3333.DefultScore = _501;
                                            tir3333.RoundStop = Round;
                                            tir3333.Players = Players;
                                            tir3333.Teams = Teams;

                                            tir3333.PlayerName[0] = player1;
                                            tir3333.PlayerName[1] = player2;
                                            tir3333.PlayerName[2] = player3;
                                            tir3333.PlayerName[3] = player4;
                                            tir3333.PlayerName[4] = player5;
                                            tir3333.PlayerName[5] = player6;
                                            tir3333.PlayerName[6] = player7;
                                            tir3333.PlayerName[7] = player8;
                                            tir3333.PlayerName[8] = player9;
                                            tir3333.PlayerName[9] = player10;
                                            tir3333.PlayerName[10] = player11;
                                            tir3333.PlayerName[11] = player12;

                                            tir3333.TeamName[0] = "A";
                                            tir3333.TeamName[1] = "B";
                                            tir3333.TeamName[2] = "C";
                                            tir3333.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 10: //44
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = true;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            four44.DefultScore = _501;
                                            four44.RoundStop = Round;
                                            four44.Players = Players;
                                            four44.Teams = Teams;

                                            four44.PlayerName[0] = player1;
                                            four44.PlayerName[1] = player2;
                                            four44.PlayerName[2] = player3;
                                            four44.PlayerName[3] = player4;
                                            four44.PlayerName[4] = player5;
                                            four44.PlayerName[5] = player6;
                                            four44.PlayerName[6] = player7;
                                            four44.PlayerName[7] = player8;

                                            four44.TeamName[0] = "A";
                                            four44.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 11: //444
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = false;
                                            four444.enabled = true;

                                            four444.DefultScore = _501;
                                            four444.RoundStop = Round;
                                            four444.Players = Players;
                                            four444.Teams = Teams;

                                            four444.PlayerName[0] = player1;
                                            four444.PlayerName[1] = player2;
                                            four444.PlayerName[2] = player3;
                                            four444.PlayerName[3] = player4;
                                            four444.PlayerName[4] = player5;
                                            four444.PlayerName[5] = player6;
                                            four444.PlayerName[6] = player7;
                                            four444.PlayerName[7] = player8;
                                            four444.PlayerName[8] = player9;
                                            four444.PlayerName[9] = player10;
                                            four444.PlayerName[10] = player11;
                                            four444.PlayerName[11] = player12;

                                            four444.TeamName[0] = "A";
                                            four444.TeamName[1] = "B";
                                            four444.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 12: //55
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = true;
                                            hexa66.enabled = false;

                                            five55.DefultScore = _501;
                                            five55.RoundStop = Round;
                                            five55.Players = Players;
                                            five55.Teams = Teams;

                                            five55.PlayerName[0] = player1;
                                            five55.PlayerName[1] = player2;
                                            five55.PlayerName[2] = player3;
                                            five55.PlayerName[3] = player4;
                                            five55.PlayerName[4] = player5;
                                            five55.PlayerName[5] = player6;
                                            five55.PlayerName[6] = player7;
                                            five55.PlayerName[7] = player8;
                                            five55.PlayerName[8] = player9;
                                            five55.PlayerName[9] = player10;

                                            five55.TeamName[0] = "A";
                                            five55.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 13: //66
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = true;

                                            hexa66.DefultScore = _501;
                                            hexa66.RoundStop = Round;
                                            hexa66.Players = Players;
                                            hexa66.Teams = Teams;

                                            hexa66.PlayerName[0] = player1;
                                            hexa66.PlayerName[1] = player2;
                                            hexa66.PlayerName[2] = player3;
                                            hexa66.PlayerName[3] = player4;
                                            hexa66.PlayerName[4] = player5;
                                            hexa66.PlayerName[5] = player6;
                                            hexa66.PlayerName[6] = player7;
                                            hexa66.PlayerName[7] = player8;
                                            hexa66.PlayerName[8] = player9;
                                            hexa66.PlayerName[9] = player10;
                                            hexa66.PlayerName[10] = player11;
                                            hexa66.PlayerName[11] = player12;

                                            hexa66.TeamName[0] = "A";
                                            hexa66.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;

                        case 2://701
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[2];
                                Round = 15;
                                switch (meun3)
                                {
                                    case 4: //22
                                        {
                                            dou22.enabled = true;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            dou22.DefultScore = _701;
                                            dou22.RoundStop = Round;
                                            dou22.Players = Players;
                                            dou22.Teams = Teams;

                                            dou22.PlayerName[0] = player1;
                                            dou22.PlayerName[1] = player2;
                                            dou22.PlayerName[2] = player3;
                                            dou22.PlayerName[3] = player4;

                                            dou22.TeamName[0] = "A";
                                            dou22.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);

                                        }
                                        break;
                                    case 5: //222
                                        {
                                            dou222.enabled = true;
                                            tir333.enabled = false;
                                            four444.enabled = false;

                                            dou222.DefultScore = _701;
                                            dou222.RoundStop = Round;
                                            dou222.Players = Players;
                                            dou222.Teams = Teams;

                                            dou222.PlayerName[0] = player1;
                                            dou222.PlayerName[1] = player2;
                                            dou222.PlayerName[2] = player3;
                                            dou222.PlayerName[3] = player4;
                                            dou222.PlayerName[4] = player5;

                                            dou222.PlayerName[5] = player6;
                                            dou222.TeamName[0] = "A";
                                            dou222.TeamName[1] = "B";
                                            dou222.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 6: //2222
                                        {
                                            dou2222.enabled = true;
                                            tir3333.enabled = false;

                                            dou2222.DefultScore = _701;
                                            dou2222.RoundStop = Round;
                                            dou2222.Players = Players;
                                            dou2222.Teams = Teams;

                                            dou2222.PlayerName[0] = player1;
                                            dou2222.PlayerName[1] = player2;
                                            dou2222.PlayerName[2] = player3;
                                            dou2222.PlayerName[3] = player4;
                                            dou2222.PlayerName[4] = player5;
                                            dou2222.PlayerName[5] = player6;
                                            dou2222.PlayerName[6] = player7;
                                            dou2222.PlayerName[7] = player8;

                                            dou2222.TeamName[0] = "A";
                                            dou2222.TeamName[1] = "B";
                                            dou2222.TeamName[2] = "C";
                                            dou2222.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 7: //33
                                        {
                                            tir33.enabled = true;
                                            dou22.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            tir33.DefultScore = _701;
                                            tir33.RoundStop = Round;
                                            tir33.Players = Players;
                                            tir33.Teams = Teams;

                                            tir33.PlayerName[0] = player1;
                                            tir33.PlayerName[1] = player2;
                                            tir33.PlayerName[2] = player3;
                                            tir33.PlayerName[3] = player4;
                                            tir33.PlayerName[4] = player5;
                                            tir33.PlayerName[5] = player6;

                                            tir33.TeamName[0] = "A";
                                            tir33.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 8: //333
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = true;
                                            four444.enabled = false;

                                            tir333.DefultScore = _701;
                                            tir333.RoundStop = Round;
                                            tir333.Players = Players;
                                            tir333.Teams = Teams;

                                            tir333.PlayerName[0] = player1;
                                            tir333.PlayerName[1] = player2;
                                            tir333.PlayerName[2] = player3;
                                            tir333.PlayerName[3] = player4;
                                            tir333.PlayerName[4] = player5;
                                            tir333.PlayerName[5] = player6;
                                            tir333.PlayerName[6] = player7;
                                            tir333.PlayerName[7] = player8;
                                            tir333.PlayerName[8] = player9;

                                            tir333.TeamName[0] = "A";
                                            tir333.TeamName[1] = "B";
                                            tir333.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 9: //3333
                                        {
                                            dou2222.enabled = false;
                                            tir3333.enabled = true;

                                            tir3333.DefultScore = _701;
                                            tir3333.RoundStop = Round;
                                            tir3333.Players = Players;
                                            tir3333.Teams = Teams;

                                            tir3333.PlayerName[0] = player1;
                                            tir3333.PlayerName[1] = player2;
                                            tir3333.PlayerName[2] = player3;
                                            tir3333.PlayerName[3] = player4;
                                            tir3333.PlayerName[4] = player5;
                                            tir3333.PlayerName[5] = player6;
                                            tir3333.PlayerName[6] = player7;
                                            tir3333.PlayerName[7] = player8;
                                            tir3333.PlayerName[8] = player9;
                                            tir3333.PlayerName[9] = player10;
                                            tir3333.PlayerName[10] = player11;
                                            tir3333.PlayerName[11] = player12;

                                            tir3333.TeamName[0] = "A";
                                            tir3333.TeamName[1] = "B";
                                            tir3333.TeamName[2] = "C";
                                            tir3333.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 10: //44
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = true;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            four44.DefultScore = _701;
                                            four44.RoundStop = Round;
                                            four44.Players = Players;
                                            four44.Teams = Teams;

                                            four44.PlayerName[0] = player1;
                                            four44.PlayerName[1] = player2;
                                            four44.PlayerName[2] = player3;
                                            four44.PlayerName[3] = player4;
                                            four44.PlayerName[4] = player5;
                                            four44.PlayerName[5] = player6;
                                            four44.PlayerName[6] = player7;
                                            four44.PlayerName[7] = player8;

                                            four44.TeamName[0] = "A";
                                            four44.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 11: //444
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = false;
                                            four444.enabled = true;

                                            four444.DefultScore = _701;
                                            four444.RoundStop = Round;
                                            four444.Players = Players;
                                            four444.Teams = Teams;

                                            four444.PlayerName[0] = player1;
                                            four444.PlayerName[1] = player2;
                                            four444.PlayerName[2] = player3;
                                            four444.PlayerName[3] = player4;
                                            four444.PlayerName[4] = player5;
                                            four444.PlayerName[5] = player6;
                                            four444.PlayerName[6] = player7;
                                            four444.PlayerName[7] = player8;
                                            four444.PlayerName[8] = player9;
                                            four444.PlayerName[9] = player10;
                                            four444.PlayerName[10] = player11;
                                            four444.PlayerName[11] = player12;

                                            four444.TeamName[0] = "A";
                                            four444.TeamName[1] = "B";
                                            four444.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 12: //55
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = true;
                                            hexa66.enabled = false;

                                            five55.DefultScore = _701;
                                            five55.RoundStop = Round;
                                            five55.Players = Players;
                                            five55.Teams = Teams;

                                            five55.PlayerName[0] = player1;
                                            five55.PlayerName[1] = player2;
                                            five55.PlayerName[2] = player3;
                                            five55.PlayerName[3] = player4;
                                            five55.PlayerName[4] = player5;
                                            five55.PlayerName[5] = player6;
                                            five55.PlayerName[6] = player7;
                                            five55.PlayerName[7] = player8;
                                            five55.PlayerName[8] = player9;
                                            five55.PlayerName[9] = player10;

                                            five55.TeamName[0] = "A";
                                            five55.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 13: //66
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = true;

                                            hexa66.DefultScore = _701;
                                            hexa66.RoundStop = Round;
                                            hexa66.Players = Players;
                                            hexa66.Teams = Teams;

                                            hexa66.PlayerName[0] = player1;
                                            hexa66.PlayerName[1] = player2;
                                            hexa66.PlayerName[2] = player3;
                                            hexa66.PlayerName[3] = player4;
                                            hexa66.PlayerName[4] = player5;
                                            hexa66.PlayerName[5] = player6;
                                            hexa66.PlayerName[6] = player7;
                                            hexa66.PlayerName[7] = player8;
                                            hexa66.PlayerName[8] = player9;
                                            hexa66.PlayerName[9] = player10;
                                            hexa66.PlayerName[10] = player11;
                                            hexa66.PlayerName[11] = player12;

                                            hexa66.TeamName[0] = "A";
                                            hexa66.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;

                        case 3://901
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[3];
                                Round = 20;
                                switch (meun3)
                                {
                                    case 4: //22
                                        {
                                            dou22.enabled = true;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            dou22.DefultScore = _901;
                                            dou22.RoundStop = Round;
                                            dou22.Players = Players;
                                            dou22.Teams = Teams;

                                            dou22.PlayerName[0] = player1;
                                            dou22.PlayerName[1] = player2;
                                            dou22.PlayerName[2] = player3;
                                            dou22.PlayerName[3] = player4;

                                            dou22.TeamName[0] = "A";
                                            dou22.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);

                                        }
                                        break;
                                    case 5: //222
                                        {
                                            dou222.enabled = true;
                                            tir333.enabled = false;
                                            four444.enabled = false;

                                            dou222.DefultScore = _901;
                                            dou222.RoundStop = Round;
                                            dou222.Players = Players;
                                            dou222.Teams = Teams;

                                            dou222.PlayerName[0] = player1;
                                            dou222.PlayerName[1] = player2;
                                            dou222.PlayerName[2] = player3;
                                            dou222.PlayerName[3] = player4;
                                            dou222.PlayerName[4] = player5;

                                            dou222.PlayerName[5] = player6;
                                            dou222.TeamName[0] = "A";
                                            dou222.TeamName[1] = "B";
                                            dou222.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 6: //2222
                                        {
                                            dou2222.enabled = true;
                                            tir3333.enabled = false;

                                            dou2222.DefultScore = _901;
                                            dou2222.RoundStop = Round;
                                            dou2222.Players = Players;
                                            dou2222.Teams = Teams;

                                            dou2222.PlayerName[0] = player1;
                                            dou2222.PlayerName[1] = player2;
                                            dou2222.PlayerName[2] = player3;
                                            dou2222.PlayerName[3] = player4;
                                            dou2222.PlayerName[4] = player5;
                                            dou2222.PlayerName[5] = player6;
                                            dou2222.PlayerName[6] = player7;
                                            dou2222.PlayerName[7] = player8;

                                            dou2222.TeamName[0] = "A";
                                            dou2222.TeamName[1] = "B";
                                            dou2222.TeamName[2] = "C";
                                            dou2222.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 7: //33
                                        {
                                            tir33.enabled = true;
                                            dou22.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            tir33.DefultScore = _901;
                                            tir33.RoundStop = Round;
                                            tir33.Players = Players;
                                            tir33.Teams = Teams;

                                            tir33.PlayerName[0] = player1;
                                            tir33.PlayerName[1] = player2;
                                            tir33.PlayerName[2] = player3;
                                            tir33.PlayerName[3] = player4;
                                            tir33.PlayerName[4] = player5;
                                            tir33.PlayerName[5] = player6;

                                            tir33.TeamName[0] = "A";
                                            tir33.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 8: //333
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = true;
                                            four444.enabled = false;

                                            tir333.DefultScore = _901;
                                            tir333.RoundStop = Round;
                                            tir333.Players = Players;
                                            tir333.Teams = Teams;

                                            tir333.PlayerName[0] = player1;
                                            tir333.PlayerName[1] = player2;
                                            tir333.PlayerName[2] = player3;
                                            tir333.PlayerName[3] = player4;
                                            tir333.PlayerName[4] = player5;
                                            tir333.PlayerName[5] = player6;
                                            tir333.PlayerName[6] = player7;
                                            tir333.PlayerName[7] = player8;
                                            tir333.PlayerName[8] = player9;

                                            tir333.TeamName[0] = "A";
                                            tir333.TeamName[1] = "B";
                                            tir333.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 9: //3333
                                        {
                                            dou2222.enabled = false;
                                            tir3333.enabled = true;

                                            tir3333.DefultScore = _901;
                                            tir3333.RoundStop = Round;
                                            tir3333.Players = Players;
                                            tir3333.Teams = Teams;

                                            tir3333.PlayerName[0] = player1;
                                            tir3333.PlayerName[1] = player2;
                                            tir3333.PlayerName[2] = player3;
                                            tir3333.PlayerName[3] = player4;
                                            tir3333.PlayerName[4] = player5;
                                            tir3333.PlayerName[5] = player6;
                                            tir3333.PlayerName[6] = player7;
                                            tir3333.PlayerName[7] = player8;
                                            tir3333.PlayerName[8] = player9;
                                            tir3333.PlayerName[9] = player10;
                                            tir3333.PlayerName[10] = player11;
                                            tir3333.PlayerName[11] = player12;

                                            tir3333.TeamName[0] = "A";
                                            tir3333.TeamName[1] = "B";
                                            tir3333.TeamName[2] = "C";
                                            tir3333.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 10: //44
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = true;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            four44.DefultScore = _901;
                                            four44.RoundStop = Round;
                                            four44.Players = Players;
                                            four44.Teams = Teams;

                                            four44.PlayerName[0] = player1;
                                            four44.PlayerName[1] = player2;
                                            four44.PlayerName[2] = player3;
                                            four44.PlayerName[3] = player4;
                                            four44.PlayerName[4] = player5;
                                            four44.PlayerName[5] = player6;
                                            four44.PlayerName[6] = player7;
                                            four44.PlayerName[7] = player8;

                                            four44.TeamName[0] = "A";
                                            four44.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 11: //444
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = false;
                                            four444.enabled = true;

                                            four444.DefultScore = _901;
                                            four444.RoundStop = Round;
                                            four444.Players = Players;
                                            four444.Teams = Teams;

                                            four444.PlayerName[0] = player1;
                                            four444.PlayerName[1] = player2;
                                            four444.PlayerName[2] = player3;
                                            four444.PlayerName[3] = player4;
                                            four444.PlayerName[4] = player5;
                                            four444.PlayerName[5] = player6;
                                            four444.PlayerName[6] = player7;
                                            four444.PlayerName[7] = player8;
                                            four444.PlayerName[8] = player9;
                                            four444.PlayerName[9] = player10;
                                            four444.PlayerName[10] = player11;
                                            four444.PlayerName[11] = player12;

                                            four444.TeamName[0] = "A";
                                            four444.TeamName[1] = "B";
                                            four444.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 12: //55
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = true;
                                            hexa66.enabled = false;

                                            five55.DefultScore = _901;
                                            five55.RoundStop = Round;
                                            five55.Players = Players;
                                            five55.Teams = Teams;

                                            five55.PlayerName[0] = player1;
                                            five55.PlayerName[1] = player2;
                                            five55.PlayerName[2] = player3;
                                            five55.PlayerName[3] = player4;
                                            five55.PlayerName[4] = player5;
                                            five55.PlayerName[5] = player6;
                                            five55.PlayerName[6] = player7;
                                            five55.PlayerName[7] = player8;
                                            five55.PlayerName[8] = player9;
                                            five55.PlayerName[9] = player10;

                                            five55.TeamName[0] = "A";
                                            five55.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 13: //66
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = true;

                                            hexa66.DefultScore = _901;
                                            hexa66.RoundStop = Round;
                                            hexa66.Players = Players;
                                            hexa66.Teams = Teams;

                                            hexa66.PlayerName[0] = player1;
                                            hexa66.PlayerName[1] = player2;
                                            hexa66.PlayerName[2] = player3;
                                            hexa66.PlayerName[3] = player4;
                                            hexa66.PlayerName[4] = player5;
                                            hexa66.PlayerName[5] = player6;
                                            hexa66.PlayerName[6] = player7;
                                            hexa66.PlayerName[7] = player8;
                                            hexa66.PlayerName[8] = player9;
                                            hexa66.PlayerName[9] = player10;
                                            hexa66.PlayerName[10] = player11;
                                            hexa66.PlayerName[11] = player12;

                                            hexa66.TeamName[0] = "A";
                                            hexa66.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;

                        case 4://1101
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[4];
                                Round = 20;
                                switch (meun3)
                                {
                                    case 4: //22
                                        {
                                            dou22.enabled = true;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            dou22.DefultScore = _1101;
                                            dou22.RoundStop = Round;
                                            dou22.Players = Players;
                                            dou22.Teams = Teams;

                                            dou22.PlayerName[0] = player1;
                                            dou22.PlayerName[1] = player2;
                                            dou22.PlayerName[2] = player3;
                                            dou22.PlayerName[3] = player4;

                                            dou22.TeamName[0] = "A";
                                            dou22.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);

                                        }
                                        break;
                                    case 5: //222
                                        {
                                            dou222.enabled = true;
                                            tir333.enabled = false;
                                            four444.enabled = false;

                                            dou222.DefultScore = _1101;
                                            dou222.RoundStop = Round;
                                            dou222.Players = Players;
                                            dou222.Teams = Teams;

                                            dou222.PlayerName[0] = player1;
                                            dou222.PlayerName[1] = player2;
                                            dou222.PlayerName[2] = player3;
                                            dou222.PlayerName[3] = player4;
                                            dou222.PlayerName[4] = player5;

                                            dou222.PlayerName[5] = player6;
                                            dou222.TeamName[0] = "A";
                                            dou222.TeamName[1] = "B";
                                            dou222.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 6: //2222
                                        {
                                            dou2222.enabled = true;
                                            tir3333.enabled = false;

                                            dou2222.DefultScore = _1101;
                                            dou2222.RoundStop = Round;
                                            dou2222.Players = Players;
                                            dou2222.Teams = Teams;

                                            dou2222.PlayerName[0] = player1;
                                            dou2222.PlayerName[1] = player2;
                                            dou2222.PlayerName[2] = player3;
                                            dou2222.PlayerName[3] = player4;
                                            dou2222.PlayerName[4] = player5;
                                            dou2222.PlayerName[5] = player6;
                                            dou2222.PlayerName[6] = player7;
                                            dou2222.PlayerName[7] = player8;

                                            dou2222.TeamName[0] = "A";
                                            dou2222.TeamName[1] = "B";
                                            dou2222.TeamName[2] = "C";
                                            dou2222.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 7: //33
                                        {
                                            tir33.enabled = true;
                                            dou22.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            tir33.DefultScore = _1101;
                                            tir33.RoundStop = Round;
                                            tir33.Players = Players;
                                            tir33.Teams = Teams;

                                            tir33.PlayerName[0] = player1;
                                            tir33.PlayerName[1] = player2;
                                            tir33.PlayerName[2] = player3;
                                            tir33.PlayerName[3] = player4;
                                            tir33.PlayerName[4] = player5;
                                            tir33.PlayerName[5] = player6;

                                            tir33.TeamName[0] = "A";
                                            tir33.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 8: //333
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = true;
                                            four444.enabled = false;

                                            tir333.DefultScore = _1101;
                                            tir333.RoundStop = Round;
                                            tir333.Players = Players;
                                            tir333.Teams = Teams;

                                            tir333.PlayerName[0] = player1;
                                            tir333.PlayerName[1] = player2;
                                            tir333.PlayerName[2] = player3;
                                            tir333.PlayerName[3] = player4;
                                            tir333.PlayerName[4] = player5;
                                            tir333.PlayerName[5] = player6;
                                            tir333.PlayerName[6] = player7;
                                            tir333.PlayerName[7] = player8;
                                            tir333.PlayerName[8] = player9;

                                            tir333.TeamName[0] = "A";
                                            tir333.TeamName[1] = "B";
                                            tir333.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 9: //3333
                                        {
                                            dou2222.enabled = false;
                                            tir3333.enabled = true;

                                            tir3333.DefultScore = _1101;
                                            tir3333.RoundStop = Round;
                                            tir3333.Players = Players;
                                            tir3333.Teams = Teams;

                                            tir3333.PlayerName[0] = player1;
                                            tir3333.PlayerName[1] = player2;
                                            tir3333.PlayerName[2] = player3;
                                            tir3333.PlayerName[3] = player4;
                                            tir3333.PlayerName[4] = player5;
                                            tir3333.PlayerName[5] = player6;
                                            tir3333.PlayerName[6] = player7;
                                            tir3333.PlayerName[7] = player8;
                                            tir3333.PlayerName[8] = player9;
                                            tir3333.PlayerName[9] = player10;
                                            tir3333.PlayerName[10] = player11;
                                            tir3333.PlayerName[11] = player12;

                                            tir3333.TeamName[0] = "A";
                                            tir3333.TeamName[1] = "B";
                                            tir3333.TeamName[2] = "C";
                                            tir3333.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 10: //44
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = true;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            four44.DefultScore = _1101;
                                            four44.RoundStop = Round;
                                            four44.Players = Players;
                                            four44.Teams = Teams;

                                            four44.PlayerName[0] = player1;
                                            four44.PlayerName[1] = player2;
                                            four44.PlayerName[2] = player3;
                                            four44.PlayerName[3] = player4;
                                            four44.PlayerName[4] = player5;
                                            four44.PlayerName[5] = player6;
                                            four44.PlayerName[6] = player7;
                                            four44.PlayerName[7] = player8;

                                            four44.TeamName[0] = "A";
                                            four44.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 11: //444
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = false;
                                            four444.enabled = true;

                                            four444.DefultScore = _1101;
                                            four444.RoundStop = Round;
                                            four444.Players = Players;
                                            four444.Teams = Teams;

                                            four444.PlayerName[0] = player1;
                                            four444.PlayerName[1] = player2;
                                            four444.PlayerName[2] = player3;
                                            four444.PlayerName[3] = player4;
                                            four444.PlayerName[4] = player5;
                                            four444.PlayerName[5] = player6;
                                            four444.PlayerName[6] = player7;
                                            four444.PlayerName[7] = player8;
                                            four444.PlayerName[8] = player9;
                                            four444.PlayerName[9] = player10;
                                            four444.PlayerName[10] = player11;
                                            four444.PlayerName[11] = player12;

                                            four444.TeamName[0] = "A";
                                            four444.TeamName[1] = "B";
                                            four444.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 12: //55
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = true;
                                            hexa66.enabled = false;

                                            five55.DefultScore = _1101;
                                            five55.RoundStop = Round;
                                            five55.Players = Players;
                                            five55.Teams = Teams;

                                            five55.PlayerName[0] = player1;
                                            five55.PlayerName[1] = player2;
                                            five55.PlayerName[2] = player3;
                                            five55.PlayerName[3] = player4;
                                            five55.PlayerName[4] = player5;
                                            five55.PlayerName[5] = player6;
                                            five55.PlayerName[6] = player7;
                                            five55.PlayerName[7] = player8;
                                            five55.PlayerName[8] = player9;
                                            five55.PlayerName[9] = player10;

                                            five55.TeamName[0] = "A";
                                            five55.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 13: //66
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = true;

                                            hexa66.DefultScore = _1101;
                                            hexa66.RoundStop = Round;
                                            hexa66.Players = Players;
                                            hexa66.Teams = Teams;

                                            hexa66.PlayerName[0] = player1;
                                            hexa66.PlayerName[1] = player2;
                                            hexa66.PlayerName[2] = player3;
                                            hexa66.PlayerName[3] = player4;
                                            hexa66.PlayerName[4] = player5;
                                            hexa66.PlayerName[5] = player6;
                                            hexa66.PlayerName[6] = player7;
                                            hexa66.PlayerName[7] = player8;
                                            hexa66.PlayerName[8] = player9;
                                            hexa66.PlayerName[9] = player10;
                                            hexa66.PlayerName[10] = player11;
                                            hexa66.PlayerName[11] = player12;

                                            hexa66.TeamName[0] = "A";
                                            hexa66.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;

                        case 5://1501
                            {
                                _01Banner.GetComponent<Image>().sprite = s_GameName[5];
                                Round = 20;
                                switch (meun3)
                                {
                                    case 4: //22
                                        {
                                            dou22.enabled = true;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            dou22.DefultScore = _1501;
                                            dou22.RoundStop = Round;
                                            dou22.Players = Players;
                                            dou22.Teams = Teams;

                                            dou22.PlayerName[0] = player1;
                                            dou22.PlayerName[1] = player2;
                                            dou22.PlayerName[2] = player3;
                                            dou22.PlayerName[3] = player4;

                                            dou22.TeamName[0] = "A";
                                            dou22.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);

                                        }
                                        break;
                                    case 5: //222
                                        {
                                            dou222.enabled = true;
                                            tir333.enabled = false;
                                            four444.enabled = false;

                                            dou222.DefultScore = _1501;
                                            dou222.RoundStop = Round;
                                            dou222.Players = Players;
                                            dou222.Teams = Teams;

                                            dou222.PlayerName[0] = player1;
                                            dou222.PlayerName[1] = player2;
                                            dou222.PlayerName[2] = player3;
                                            dou222.PlayerName[3] = player4;
                                            dou222.PlayerName[4] = player5;

                                            dou222.PlayerName[5] = player6;
                                            dou222.TeamName[0] = "A";
                                            dou222.TeamName[1] = "B";
                                            dou222.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 6: //2222
                                        {
                                            dou2222.enabled = true;
                                            tir3333.enabled = false;

                                            dou2222.DefultScore = _1501;
                                            dou2222.RoundStop = Round;
                                            dou2222.Players = Players;
                                            dou2222.Teams = Teams;

                                            dou2222.PlayerName[0] = player1;
                                            dou2222.PlayerName[1] = player2;
                                            dou2222.PlayerName[2] = player3;
                                            dou2222.PlayerName[3] = player4;
                                            dou2222.PlayerName[4] = player5;
                                            dou2222.PlayerName[5] = player6;
                                            dou2222.PlayerName[6] = player7;
                                            dou2222.PlayerName[7] = player8;

                                            dou2222.TeamName[0] = "A";
                                            dou2222.TeamName[1] = "B";
                                            dou2222.TeamName[2] = "C";
                                            dou2222.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 7: //33
                                        {
                                            tir33.enabled = true;
                                            dou22.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            tir33.DefultScore = _1501;
                                            tir33.RoundStop = Round;
                                            tir33.Players = Players;
                                            tir33.Teams = Teams;

                                            tir33.PlayerName[0] = player1;
                                            tir33.PlayerName[1] = player2;
                                            tir33.PlayerName[2] = player3;
                                            tir33.PlayerName[3] = player4;
                                            tir33.PlayerName[4] = player5;
                                            tir33.PlayerName[5] = player6;

                                            tir33.TeamName[0] = "A";
                                            tir33.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 8: //333
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = true;
                                            four444.enabled = false;

                                            tir333.DefultScore = _1501;
                                            tir333.RoundStop = Round;
                                            tir333.Players = Players;
                                            tir333.Teams = Teams;

                                            tir333.PlayerName[0] = player1;
                                            tir333.PlayerName[1] = player2;
                                            tir333.PlayerName[2] = player3;
                                            tir333.PlayerName[3] = player4;
                                            tir333.PlayerName[4] = player5;
                                            tir333.PlayerName[5] = player6;
                                            tir333.PlayerName[6] = player7;
                                            tir333.PlayerName[7] = player8;
                                            tir333.PlayerName[8] = player9;

                                            tir333.TeamName[0] = "A";
                                            tir333.TeamName[1] = "B";
                                            tir333.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 9: //3333
                                        {
                                            dou2222.enabled = false;
                                            tir3333.enabled = true;

                                            tir3333.DefultScore = _1501;
                                            tir3333.RoundStop = Round;
                                            tir3333.Players = Players;
                                            tir3333.Teams = Teams;

                                            tir3333.PlayerName[0] = player1;
                                            tir3333.PlayerName[1] = player2;
                                            tir3333.PlayerName[2] = player3;
                                            tir3333.PlayerName[3] = player4;
                                            tir3333.PlayerName[4] = player5;
                                            tir3333.PlayerName[5] = player6;
                                            tir3333.PlayerName[6] = player7;
                                            tir3333.PlayerName[7] = player8;
                                            tir3333.PlayerName[8] = player9;
                                            tir3333.PlayerName[9] = player10;
                                            tir3333.PlayerName[10] = player11;
                                            tir3333.PlayerName[11] = player12;

                                            tir3333.TeamName[0] = "A";
                                            tir3333.TeamName[1] = "B";
                                            tir3333.TeamName[2] = "C";
                                            tir3333.TeamName[3] = "D";

                                            g_TeamBar[2].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 10: //44
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = true;
                                            five55.enabled = false;
                                            hexa66.enabled = false;

                                            four44.DefultScore = _1501;
                                            four44.RoundStop = Round;
                                            four44.Players = Players;
                                            four44.Teams = Teams;

                                            four44.PlayerName[0] = player1;
                                            four44.PlayerName[1] = player2;
                                            four44.PlayerName[2] = player3;
                                            four44.PlayerName[3] = player4;
                                            four44.PlayerName[4] = player5;
                                            four44.PlayerName[5] = player6;
                                            four44.PlayerName[6] = player7;
                                            four44.PlayerName[7] = player8;

                                            four44.TeamName[0] = "A";
                                            four44.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 11: //444
                                        {
                                            dou222.enabled = false;
                                            tir333.enabled = false;
                                            four444.enabled = true;

                                            four444.DefultScore = _1501;
                                            four444.RoundStop = Round;
                                            four444.Players = Players;
                                            four444.Teams = Teams;

                                            four444.PlayerName[0] = player1;
                                            four444.PlayerName[1] = player2;
                                            four444.PlayerName[2] = player3;
                                            four444.PlayerName[3] = player4;
                                            four444.PlayerName[4] = player5;
                                            four444.PlayerName[5] = player6;
                                            four444.PlayerName[6] = player7;
                                            four444.PlayerName[7] = player8;
                                            four444.PlayerName[8] = player9;
                                            four444.PlayerName[9] = player10;
                                            four444.PlayerName[10] = player11;
                                            four444.PlayerName[11] = player12;

                                            four444.TeamName[0] = "A";
                                            four444.TeamName[1] = "B";
                                            four444.TeamName[2] = "C";

                                            g_TeamBar[1].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 12: //55
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = true;
                                            hexa66.enabled = false;

                                            five55.DefultScore = _1501;
                                            five55.RoundStop = Round;
                                            five55.Players = Players;
                                            five55.Teams = Teams;

                                            five55.PlayerName[0] = player1;
                                            five55.PlayerName[1] = player2;
                                            five55.PlayerName[2] = player3;
                                            five55.PlayerName[3] = player4;
                                            five55.PlayerName[4] = player5;
                                            five55.PlayerName[5] = player6;
                                            five55.PlayerName[6] = player7;
                                            five55.PlayerName[7] = player8;
                                            five55.PlayerName[8] = player9;
                                            five55.PlayerName[9] = player10;

                                            five55.TeamName[0] = "A";
                                            five55.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                    case 13: //66
                                        {
                                            dou22.enabled = false;
                                            tir33.enabled = false;
                                            four44.enabled = false;
                                            five55.enabled = false;
                                            hexa66.enabled = true;

                                            hexa66.DefultScore = _1501;
                                            hexa66.RoundStop = Round;
                                            hexa66.Players = Players;
                                            hexa66.Teams = Teams;

                                            hexa66.PlayerName[0] = player1;
                                            hexa66.PlayerName[1] = player2;
                                            hexa66.PlayerName[2] = player3;
                                            hexa66.PlayerName[3] = player4;
                                            hexa66.PlayerName[4] = player5;
                                            hexa66.PlayerName[5] = player6;
                                            hexa66.PlayerName[6] = player7;
                                            hexa66.PlayerName[7] = player8;
                                            hexa66.PlayerName[8] = player9;
                                            hexa66.PlayerName[9] = player10;
                                            hexa66.PlayerName[10] = player11;
                                            hexa66.PlayerName[11] = player12;

                                            hexa66.TeamName[0] = "A";
                                            hexa66.TeamName[1] = "B";

                                            g_TeamBar[0].SetActive(true);
                                            g_PPDScore[0].SetActive(true);
                                            g_RScore[0].SetActive(true);
                                        }
                                        break;
                                }
                            }
                            break;
                    }
                }
                break;
        }
    }

    public void GameEndRead(int n)
    {
        switch (meun3)
        {
            case 0:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = sing.player1;
                    save.PPD1 = sing.Average;

                    Invoke("End", 16f);
                }
                break;
            case 1:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = Two.playerName[0];
                    save.player2 = Two.playerName[1];
                    save.PPD1 = Two.Average1;
                    save.PPD2 = Two.Average2;

                    Invoke("End", 16f);
                }
                break;
            case 2:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = Three.playerName[0];
                    save.player2 = Three.playerName[1];
                    save.player3 = Three.playerName[2];
                    save.PPD1 = Three.Average1;
                    save.PPD2 = Three.Average2;
                    save.PPD3 = Three.Average3;

                    Invoke("End", 16f);
                }
                break;
            case 3:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = Four.playerName[0];
                    save.player2 = Four.playerName[1];
                    save.player3 = Four.playerName[2];
                    save.player4 = Four.playerName[3];
                    save.PPD1 = Four.P1_Average;
                    save.PPD2 = Four.P2_Average;
                    save.PPD3 = Four.P3_Average;
                    save.PPD4 = Four.P4_Average;

                    Invoke("End", 16f);
                }
                break;
            case 4:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = dou22.PlayerName[0];
                    save.player2 = dou22.PlayerName[1];
                    save.player3 = dou22.PlayerName[2];
                    save.player4 = dou22.PlayerName[3];
                    save.PPD1 = dou22.AverageA1;
                    save.PPD2 = dou22.AverageA2;
                    save.PPD3 = dou22.AverageB1;
                    save.PPD4 = dou22.AverageB2;

                    Invoke("End", 16f);
                }
                break;
            case 5:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = dou222.PlayerName[0];
                    save.player2 = dou222.PlayerName[1];
                    save.player3 = dou222.PlayerName[2];
                    save.player4 = dou222.PlayerName[3];
                    save.player5 = dou222.PlayerName[4];
                    save.player6 = dou222.PlayerName[5];
                    save.PPD1 = dou222.AverageA1;
                    save.PPD2 = dou222.AverageA2;
                    save.PPD3 = dou222.AverageB1;
                    save.PPD4 = dou222.AverageB2;
                    save.PPD5 = dou222.AverageC1;
                    save.PPD6 = dou222.AverageC2;

                    Invoke("End", 16f);
                }
                break;
            case 6:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = dou2222.PlayerName[0];
                    save.player2 = dou2222.PlayerName[1];
                    save.player3 = dou2222.PlayerName[2];
                    save.player4 = dou2222.PlayerName[3];
                    save.player5 = dou2222.PlayerName[4];
                    save.player6 = dou2222.PlayerName[5];
                    save.player7 = dou2222.PlayerName[6];
                    save.player8 = dou2222.PlayerName[7];

                    save.PPD1 = dou2222.AverageA1;
                    save.PPD2 = dou2222.AverageA2;
                    save.PPD3 = dou2222.AverageB1;
                    save.PPD4 = dou2222.AverageB2;
                    save.PPD5 = dou2222.AverageC1;
                    save.PPD6 = dou2222.AverageC2;
                    save.PPD7 = dou2222.AverageD1;
                    save.PPD8 = dou2222.AverageD2;

                    Invoke("End", 16f);
                }
                break;
            case 7:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = tir33.PlayerName[0];
                    save.player2 = tir33.PlayerName[1];
                    save.player3 = tir33.PlayerName[2];
                    save.player4 = tir33.PlayerName[3];
                    save.player5 = tir33.PlayerName[4];
                    save.player6 = tir33.PlayerName[5];

                    save.PPD1 = tir33.AverageA1;
                    save.PPD2 = tir33.AverageA2;
                    save.PPD3 = tir33.AverageA3;
                    save.PPD4 = tir33.AverageB1;
                    save.PPD5 = tir33.AverageB2;
                    save.PPD6 = tir33.AverageB3;

                    Invoke("End", 16f);
                }
                break;
            case 8:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = tir333.PlayerName[0];
                    save.player2 = tir333.PlayerName[1];
                    save.player3 = tir333.PlayerName[2];
                    save.player4 = tir333.PlayerName[3];
                    save.player5 = tir333.PlayerName[4];
                    save.player6 = tir333.PlayerName[5];
                    save.player7 = tir333.PlayerName[6];
                    save.player8 = tir333.PlayerName[7];
                    save.player9 = tir333.PlayerName[8];

                    save.PPD1 = tir333.AverageA1;
                    save.PPD2 = tir333.AverageA2;
                    save.PPD3 = tir333.AverageA3;
                    save.PPD4 = tir333.AverageB1;
                    save.PPD5 = tir333.AverageB2;
                    save.PPD6 = tir333.AverageB3;
                    save.PPD7 = tir333.AverageC1;
                    save.PPD8 = tir333.AverageC2;
                    save.PPD9 = tir333.AverageC3;

                    Invoke("End", 16f);
                }
                break;
            case 9:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = tir3333.PlayerName[0];
                    save.player2 = tir3333.PlayerName[1];
                    save.player3 = tir3333.PlayerName[2];
                    save.player4 = tir3333.PlayerName[3];
                    save.player5 = tir3333.PlayerName[4];
                    save.player6 = tir3333.PlayerName[5];
                    save.player7 = tir3333.PlayerName[6];
                    save.player8 = tir3333.PlayerName[7];
                    save.player9 = tir3333.PlayerName[8];
                    save.player10 = tir3333.PlayerName[9];
                    save.player11 = tir3333.PlayerName[10];
                    save.player12 = tir3333.PlayerName[11];

                    save.PPD1 = tir3333.AverageA1;
                    save.PPD2 = tir3333.AverageA2;
                    save.PPD3 = tir3333.AverageA3;
                    save.PPD4 = tir3333.AverageB1;
                    save.PPD5 = tir3333.AverageB2;
                    save.PPD6 = tir3333.AverageB3;
                    save.PPD7 = tir3333.AverageC1;
                    save.PPD8 = tir3333.AverageC2;
                    save.PPD9 = tir3333.AverageC3;
                    save.PPD10 = tir3333.AverageD1;
                    save.PPD11 = tir3333.AverageD2;
                    save.PPD12 = tir3333.AverageD3;

                    Invoke("End", 16f);
                }
                break;
            case 10:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = four44.PlayerName[0];
                    save.player2 = four44.PlayerName[1];
                    save.player3 = four44.PlayerName[2];
                    save.player4 = four44.PlayerName[3];
                    save.player5 = four44.PlayerName[4];
                    save.player6 = four44.PlayerName[5];
                    save.player7 = four44.PlayerName[6];
                    save.player8 = four44.PlayerName[7];

                    save.PPD1 = four44.AverageA1;
                    save.PPD2 = four44.AverageA2;
                    save.PPD3 = four44.AverageA3;
                    save.PPD4 = four44.AverageA4;
                    save.PPD5 = four44.AverageB1;
                    save.PPD6 = four44.AverageB2;
                    save.PPD7 = four44.AverageB3;
                    save.PPD8 = four44.AverageB4;

                    Invoke("End", 16f);
                }
                break;
            case 11:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = four444.PlayerName[0];
                    save.player2 = four444.PlayerName[1];
                    save.player3 = four444.PlayerName[2];
                    save.player4 = four444.PlayerName[3];
                    save.player5 = four444.PlayerName[4];
                    save.player6 = four444.PlayerName[5];
                    save.player7 = four444.PlayerName[6];
                    save.player8 = four444.PlayerName[7];
                    save.player9 = four444.PlayerName[8];
                    save.player10 = four444.PlayerName[9];
                    save.player11 = four444.PlayerName[10];
                    save.player12 = four444.PlayerName[11];

                    save.PPD1 = four444.AverageA1;
                    save.PPD2 = four444.AverageA2;
                    save.PPD3 = four444.AverageA3;
                    save.PPD4 = four444.AverageA4;
                    save.PPD5 = four444.AverageB1;
                    save.PPD6 = four444.AverageB2;
                    save.PPD7 = four444.AverageB3;
                    save.PPD8 = four444.AverageB4;
                    save.PPD9 = four444.AverageC1;
                    save.PPD10 = four444.AverageC2;
                    save.PPD11 = four444.AverageC3;
                    save.PPD12 = four444.AverageC4;

                    Invoke("End", 16f);
                }
                break;
            case 12:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = five55.PlayerName[0];
                    save.player2 = five55.PlayerName[1];
                    save.player3 = five55.PlayerName[2];
                    save.player4 = five55.PlayerName[3];
                    save.player5 = five55.PlayerName[4];
                    save.player6 = five55.PlayerName[5];
                    save.player7 = five55.PlayerName[6];
                    save.player8 = five55.PlayerName[7];
                    save.player9 = five55.PlayerName[8];
                    save.player10 = five55.PlayerName[9];

                    save.PPD1 = five55.AverageA1;
                    save.PPD2 = five55.AverageA2;
                    save.PPD3 = five55.AverageA3;
                    save.PPD4 = five55.AverageA4;
                    save.PPD5 = five55.AverageA5;
                    save.PPD6 = five55.AverageB1;
                    save.PPD7 = five55.AverageB2;
                    save.PPD8 = five55.AverageB3;
                    save.PPD9 = five55.AverageB4;
                    save.PPD10 = five55.AverageB5;

                    Invoke("End", 16f);
                }
                break;
            case 13:
                {
                    g_MoveOn.SetActive(true);
                    g_WMove[n].SetActive(true);

                    save.player1 = hexa66.PlayerName[0];
                    save.player2 = hexa66.PlayerName[1];
                    save.player3 = hexa66.PlayerName[2];
                    save.player4 = hexa66.PlayerName[3];
                    save.player5 = hexa66.PlayerName[4];
                    save.player6 = hexa66.PlayerName[5];
                    save.player7 = hexa66.PlayerName[6];
                    save.player8 = hexa66.PlayerName[7];
                    save.player9 = hexa66.PlayerName[8];
                    save.player10 = hexa66.PlayerName[9];
                    save.player11 = hexa66.PlayerName[10];
                    save.player12 = hexa66.PlayerName[11];

                    save.PPD1 = hexa66.AverageA1;
                    save.PPD2 = hexa66.AverageA2;
                    save.PPD3 = hexa66.AverageA3;
                    save.PPD4 = hexa66.AverageA4;
                    save.PPD5 = hexa66.AverageA5;
                    save.PPD6 = hexa66.AverageA6;
                    save.PPD7 = hexa66.AverageA1;
                    save.PPD8 = hexa66.AverageA2;
                    save.PPD9 = hexa66.AverageA3;
                    save.PPD10 = hexa66.AverageA4;
                    save.PPD11 = hexa66.AverageA5;
                    save.PPD12 = hexa66.AverageA6;

                    Invoke("End", 16f);
                }
                break;

        }
    }

    public void DartScoreActor(int nDartLine, int nDartScore, int DartCount)
    {
        switch (nDartScore)
        {
            case 25:
                {
                    if (1 == nDartLine)
                    {
                        g_DAni[2].SetActive(true);
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[3];
                    }
                    else if (2 == nDartLine)
                    {
                        g_DAni[3].SetActive(true);
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[4];
                    }
                    else
                    {
                    }
                }
                break;
            case 20:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(20);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(20);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(20);
                    }
                    else
                    {
                    }
                }
                break;
            case 19:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(19);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(19);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(19);
                    }
                    else
                    {
                    }
                }
                break;
            case 18:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(18);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(18);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(18);
                    }
                    else
                    {
                    }
                }
                break;
            case 17:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(17);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(17);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(17);
                    }
                    else
                    {
                    }
                }
                break;
            case 16:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(16);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(16);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(16);
                    }
                    else
                    {
                    }
                }
                break;
            case 15:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(15);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(15);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(15);
                    }
                    else
                    {
                    }
                }
                break;
            case 14:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(14);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(14);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(14);
                    }
                    else
                    {
                    }
                }
                break;
            case 13:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(13);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(13);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(13);
                    }
                    else
                    {
                    }
                }
                break;
            case 12:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(12);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(12);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(12);
                    }
                    else
                    {
                    }
                }
                break;
            case 11:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(11);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(11);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(11);
                    }
                    else
                    {
                    }
                }
                break;
            case 10:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(10);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(10);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(10);
                    }
                    else
                    {
                    }
                }
                break;
            case 9:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(9);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(9);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(9);
                    }
                    else
                    {
                    }
                }
                break;
            case 8:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(8);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(8);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(8);
                    }
                    else
                    {
                    }
                }
                break;
            case 7:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(7);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(7);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(7);
                    }
                    else
                    {
                    }
                }
                break;
            case 6:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(6);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(6);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(6);
                    }
                    else
                    {
                    }
                }
                break;
            case 5:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(5);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(5);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(5);
                    }
                    else
                    {
                    }
                }
                break;
            case 4:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(4);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(4);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(4);
                    }
                    else
                    {
                    }
                }
                break;
            case 3:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(3);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(3);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(3);
                    }
                    else
                    {
                    }
                }
                break;
            case 2:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(2);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(2);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(2);
                    }
                    else
                    {
                    }
                }
                break;
            case 1:
                {
                    if (1 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
                        g_BlackDartScore[DartCount].GetComponent<csNumber>().SetNumber(1);
                    }
                    else if (2 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
                        g_OrangDartScore[DartCount].GetComponent<csNumber>().SetNumber(1);
                    }
                    else if (3 == nDartLine)
                    {
                        g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
                        g_BlueDartScore[DartCount].GetComponent<csNumber>().SetNumber(1);
                    }
                    else
                    {
                    }
                }
                break;
        }

        if (nDartLine == 3 && nDartScore != 25 && nDartScore != 50)
        {
            g_DAni[1].SetActive(true);
            g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[2];
        }
        else if (nDartLine == 2 && nDartScore != 25 && nDartScore != 50)
        {
            g_DAni[0].SetActive(true);
            g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[1];
        }
        else if (nDartLine == 1 && nDartScore != 25 && nDartScore != 50)
        {
            g_Dart[DartCount].GetComponent<Image>().sprite = s_DartScore[0];
        }
        else
        {
        }
        Invoke("AniStop", 1.5f);
    }

    void AniStop()
    {
        for (int i = 0; i < g_DAni.Length; i++)
            g_DAni[i].SetActive(false);
    }

    public void DartScoreReSet()
    {
        for (int i = 0; i < g_BlackDartScore.Length; i++)
        {
            g_BlackDartScore[i].GetComponent<csNumber>().SetNumber(-1);
            g_BlueDartScore[i].GetComponent<csNumber>().SetNumber(-1);
            g_OrangDartScore[i].GetComponent<csNumber>().SetNumber(-1);
        }
    }

    public void MoviePlay(int nNo)
    {
        isAni = true;
        g_MoveOn.SetActive(true);
        g_Move[nNo].SetActive(true);
        if (nNo == 1) //DeadEye
            Invoke("MovieStop", 16f);
        else if (nNo == 2) //Hattrick
            Invoke("MovieStop", 10f);
        else if (nNo == 3) //hightton
            Invoke("MovieStop", 9f);
        else if (nNo == 4) //lowton
            Invoke("MovieStop", 16f);
        else if (nNo == 5) //threeinabed
            Invoke("MovieStop", 14f);
        else if (nNo == 6) //wihitehore
            Invoke("MovieStop", 9f);
        else
        {
        }
    }

    void MovieStop()
    {
        for (int i = 0; i < g_Move.Length; i++)
            g_Move[i].SetActive(false);
        g_MoveOn.SetActive(false);
        isAni = false;

    }

    void End()
    {
        g_MoveOn.SetActive(false);
        SceneManager.LoadScene("Fish");
    }
}
