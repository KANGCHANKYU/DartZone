using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public struct _TARGET_INFO
{
    public int nScore;
    public int nLine;// 0 : 1배당, 1 : 2배당 2: 3배당
};

public class Save : MonoBehaviour
{
    public int meun1 = 0;
    public int meun2 = 0;
    public int meun3 = 0;
    public int Teams = 0;
    public int ATeam = 0;
    public int BTeam = 0;
    public int CTeam = 0;
    public int DTeam = 0;
    public int Players = 0;

    public float PPD1 = 0;
    public float PPD2 = 0;
    public float PPD3 = 0;
    public float PPD4 = 0;
    public float PPD5 = 0;
    public float PPD6 = 0;
    public float PPD7 = 0;
    public float PPD8 = 0;
    public float PPD9 = 0;
    public float PPD10 = 0;
    public float PPD11 = 0;
    public float PPD12 = 0;

    public float MPR1 = 0;
    public float MPR2 = 0;
    public float MPR3 = 0;
    public float MPR4 = 0;
    public float MPR5 = 0;
    public float MPR6 = 0;
    public float MPR7 = 0;
    public float MPR8 = 0;
    public float MPR9 = 0;
    public float MPR10 = 0;
    public float MPR11 = 0;
    public float MPR12 = 0;

    public int PlayerScore1 = 0;
    public int PlayerScore2 = 0;
    public int PlayerScore3 = 0;
    public int PlayerScore4 = 0;
    public int PlayerScore5 = 0;
    public int PlayerScore6 = 0;
    public int PlayerScore7 = 0;
    public int PlayerScore8 = 0;
    public int PlayerScore9 = 0;
    public int PlayerScore10 = 0;
    public int PlayerScore11 = 0;
    public int PlayerScore12 = 0;

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


    void Start ()
    {
        
	}
	
	
	void Update ()
    {
        DontDestroyOnLoad(this);
	}

    public void defaultNum()
    {
        meun1 = 0;
        meun2 = 0;
        meun3 = 0;
        Teams = 0;
        ATeam = 0;
        BTeam = 0;
        CTeam = 0;
        DTeam = 0;
        Players = 0;
        PPD1 = 0;
        PPD2 = 0;
        PPD3 = 0;
        PPD4 = 0;
        PPD5 = 0;
        PPD6 = 0;
        PPD7 = 0;
        PPD8 = 0;
        PPD9 = 0;
        PPD10 = 0;
        PPD11 = 0;
        PPD12 = 0;
        MPR1 = 0;
        MPR2 = 0;
        MPR3 = 0;
        MPR4 = 0;
        MPR5 = 0;
        MPR6 = 0;
        MPR7 = 0;
        MPR8 = 0;
        MPR9 = 0;
        MPR10 = 0;
        MPR11= 0;
        MPR12 = 0;
        PlayerScore1 = 0;
        PlayerScore2 = 0;
        PlayerScore3 = 0;
        PlayerScore4 = 0;
        PlayerScore5 = 0;
        PlayerScore6 = 0;
        PlayerScore7 = 0;
        PlayerScore8 = 0;
        PlayerScore9 = 0;
        PlayerScore10 = 0;
        PlayerScore11 = 0;
        PlayerScore12 = 0;
        player1 = "";
        player2 = "";
        player3 = "";
        player4 = "";
        player5 = "";
        player6 = "";
        player7 = "";
        player8 = "";
        player9 = "";
        player10 = "";
        player11 = "";
        player12 = "";
    }

}
