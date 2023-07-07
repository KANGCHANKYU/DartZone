using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Threading;
using System;
using System.Linq;
using System.Text;
using System.IO;

public class _TARGET
{
    string strSignal;
    int nScore;
}

public enum ENUM_TARGET_SCORE
{
    NONE = 0,//_SCORE_NONE

    S00E = 0,

    S221E = 50,// DOUBLE_BULL
    S222E = 50 * 2,
    S223E = 50 * 3,

    S251E = 25,// SINGLE_BULL
    S252E = 25 * 2,
    S253E = 25 * 3,

    S201E = 20,//_SCORE_20_SINGLE    
    S202E = 20 * 2,//_SCORE_20_DOUBLE
    S203E = 20 * 3,//_SCORE_20_TRIPLE

    S191E = 19,//_SCORE_19_SINGLE
    S192E = 19 * 2,//_SCORE_19_DOUBLE
    S193E = 19 * 3,//_SCORE_19_TRIPLE

    S181E = 18,//_SCORE_18_SINGLE
    S182E = 18 * 2,//_SCORE_18_DOUBLE
    S183E = 18 * 3,//_SCORE_18_TRIPLE

    S171E = 17,//_SCORE_17_SINGLE
    S172E = 17 * 2,//_SCORE_17_DOUBLE
    S173E = 17 * 3,//_SCORE_17_TRIPLE

    S161E = 16,//_SCORE_16_SINGLE
    S162E = 16 * 2,//_SCORE_16_DOUBLE
    S163E = 16 * 3,//_SCORE_16_TRIPLE

    S151E = 15,//_SCORE_15_SINGLE
    S152E = 15 * 2,//_SCORE_15_DOUBLE
    S153E = 15 * 3,//_SCORE_15_TRIPLE

    S141E = 14,//_SCORE_14_SINGLE
    S142E = 14 * 2,//_SCORE_14_DOUBLE
    S143E = 14 * 3,//_SCORE_14_TRIPLE

    S131E = 13,//_SCORE_13_SINGLE
    S132E = 13 * 2,//_SCORE_13_DOUBLE
    S133E = 13 * 3,//_SCORE_13_TRIPLE

    S121E = 12,//_SCORE_12_SINGLE
    S122E = 12 * 2,//_SCORE_12_DOUBLE
    S123E = 12 * 3,//_SCORE_12_TRIPLE

    S111E = 11,//_SCORE_11_SINGLE
    S112E = 11 * 2,//_SCORE_11_DOUBLE
    S113E = 11 * 3,//_SCORE_11_TRIPLE

    S101E = 10,//_SCORE_10_SINGLE
    S102E = 10 * 2,//_SCORE_10_DOUBLE
    S103E = 10 * 3,//_SCORE_10_TRIPLE

    S91E = 9,//_SCORE_9_SINGLE
    S92E = 9 * 2,//_SCORE_9_DOUBLE
    S93E = 9 * 3,//_SCORE_9_TRIPLE

    S81E = 8,//_SCORE_8_SINGLE
    S82E = 8 * 2,//_SCORE_8_DOUBLE
    S83E = 8 * 3,//_SCORE_8_TRIPLE

    S71E = 7,//_SCORE_7_SINGLE
    S72E = 7 * 2,//_SCORE_7_DOUBLE
    S73E = 7 * 3,//_SCORE_7_TRIPLE

    S61E = 6,//_SCORE_6_SINGLE
    S62E = 6 * 2,//_SCORE_6_DOUBLE
    S63E = 6 * 3,//_SCORE_6_TRIPLE

    S51E = 5,//_SCORE_5_SINGLE
    S52E = 5 * 2,//_SCORE_5_DOUBLE
    S53E = 5 * 3,//_SCORE_5_TRIPLE

    S41E = 4,//_SCORE_4_SINGLE
    S42E = 4 * 2,//_SCORE_4_DOUBLE
    S43E = 4 * 3,//_SCORE_4_TRIPLE

    S31E = 3,//_SCORE_3_SINGLE
    S32E = 3 * 2,//_SCORE_3_DOUBLE
    S33E = 3 * 3,//_SCORE_3_TRIPLE

    S21E = 2,//_SCORE_2_SINGLE
    S22E = 2 * 2,//_SCORE_2_DOUBLE
    S23E = 2 * 3,//_SCORE_2_TRIPLE

    S11E = 1,//_SCORE_1_SINGLE
    S12E = 1 * 2,//_SCORE_1_DOUBLE
    S13E = 1 * 3,//_SCORE_1_TRIPLE


    UPER = -100,//상
    DOWN = -101,//하
    LEFT = -102,//좌
    RIGH = -103,//우
    OPTI = -104,//option
    STAT = -105,//start
}

public class csControlIO : MonoBehaviour
{
    static SerialPort m_oContrlPort;
    string m_strReciveData = "";// 전체 데이터
    string m_strSendData = "";// 보낼 데이트
    string m_strByteData = "";// 프레임마다 받은 데이터
    string m_strProcessData;

    int m_nReadData;
    string m_strReadData;


    float PI = 3.141592f;

    bool m_bViewData = false;
    GUIStyle oFont;
    static int _ASCII_TO_NUMBER = 48;
    static int _PROCESS_DATA_SIZE = 4;
    string m_strSendControlData = "";
    int m_nTargetScore = 0;
    int m_nTargetLine = 0;

    int m_nCountNum = 4;
    string m_strCount4Data = "";
    bool m_bSwitch = false;


    void Start()
    {
        m_oContrlPort = new SerialPort("COM8", 19200, Parity.None, 8, StopBits.One);
        m_oContrlPort.ReadTimeout = 100;
        m_oContrlPort.Open();

        oFont = new GUIStyle();
        oFont.fontSize = 64;
        oFont.normal.textColor = Color.red;
    }

    void OnApplicationQuit()
    {
        if (m_oContrlPort != null)
            m_oContrlPort.Close();
    }

    // 데이터 보기
    void OnGUI()
    {
        //if (bViewData)
        {
            if (GUI.Button(new Rect(0, 0, Screen.width, 100), "data - " + m_strProcessData, oFont)) { }
            if (GUI.Button(new Rect(0, 100, Screen.width, 100), m_strSendData, oFont)) { }
            if (GUI.Button(new Rect(0, 200, Screen.width, 100), "score - " + m_nTargetScore.ToString(), oFont)) { }
        }
    }


    // 데이터 전송
    void SendData(string str)
    {
        if (m_oContrlPort != null)
        {
            m_strSendControlData = str;
            m_oContrlPort.Write(str);
        }
    }


    void Update()
    {
        ReceiveData();


        if (Input.GetKeyDown(KeyCode.Z))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 1;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 2;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;

            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 3;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.V))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 4;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 5;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 6;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 7;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 8;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 9;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 10;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.G))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 11;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.H))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 12;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.J))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 13;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.K))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 14;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 15;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.Q))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 16;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 17;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 18;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 19;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.T))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 20;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            else if (Input.GetKey(KeyCode.RightShift))
            {
                csSingleton.getInstance.g_nTargetLine = 3;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }

        else if (Input.GetKeyDown(KeyCode.Y))
        {
            csSingleton.getInstance.g_bTarget = true;
            csSingleton.getInstance.g_nTargetLine = 1;
            csSingleton.getInstance.g_nTargetScore = 25;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                csSingleton.getInstance.g_nTargetLine = 2;
            }
            csSingleton.getInstance.g_nTargetScore = csSingleton.getInstance.g_nTargetScore * (csSingleton.getInstance.g_nTargetLine);
            csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;
            Debug.Log(csSingleton.getInstance.g_nTargetLine.ToString());
            Debug.Log(csSingleton.getInstance.g_nTargetScore.ToString());
        }
    }

    public void ReceiveData()
    {
        ENUM_TARGET_SCORE oEnum;
        try
        {
            //m_nReadData = m_oContrlPort.ReadByte();
            //m_strReadData = m_nReadData.ToString("X");
            m_nReadData = m_oContrlPort.ReadByte();
            //m_strReadData = 

            if (m_nReadData == '\n' || m_nReadData == '\r')
            {
                if (m_nReadData == '\n')
                {
                    int a = 0;
                    a = 1;
                }
                else if (m_nReadData == '\r')
                {
                    int b = 0;
                    b = 1;
                }
            }
            else
            {
                m_strReciveData += Convert.ToChar(m_nReadData);
            }
            

            if (m_strReciveData.Length >= _PROCESS_DATA_SIZE)
            {
                m_strCount4Data = m_strReciveData.Substring(3, 1);
                if (m_strCount4Data == "E")
                {
                    m_nCountNum = 4;
                }
                else if (m_strCount4Data == "R" || m_strCount4Data == "N" || m_strCount4Data == "T" || m_strCount4Data == "H" || m_strCount4Data == "I" || m_strCount4Data == "T")
                {
                    m_bSwitch = true;
                    m_nCountNum = 4;
                }
                else
                {
                    m_nCountNum = 5;
                }

                //----------------------------------------------
                // 데이터 해석
                //----------------------------------------------
                if (m_strReciveData.Length >= m_nCountNum)
                {
                    m_strProcessData = m_strReciveData.Substring(0, m_nCountNum);
                    m_strReciveData = m_strReciveData.Substring(m_nCountNum);

                    oEnum = (ENUM_TARGET_SCORE)Enum.Parse(typeof(ENUM_TARGET_SCORE), m_strProcessData);
                    m_nTargetScore = (int)oEnum;

                    //----------------------------------------------
                    // 전역변수에 저장
                    //----------------------------------------------
                    if (oEnum.Equals(ENUM_TARGET_SCORE.UPER) || oEnum.Equals(ENUM_TARGET_SCORE.DOWN) ||
                        oEnum.Equals(ENUM_TARGET_SCORE.LEFT) || oEnum.Equals(ENUM_TARGET_SCORE.RIGH) ||
                        oEnum.Equals(ENUM_TARGET_SCORE.STAT))
                    {
                        csSingleton.getInstance.g_bSwitch = true;
                        csSingleton.getInstance.g_nSwitch = (int)oEnum;
                    }
                    else
                    {
                        csSingleton.getInstance.g_bTarget = true;
                        csSingleton.getInstance.g_nTargetScore = m_nTargetScore;

                        //if (oEnum.Equals(ENUM_TARGET_SCORE.S201E) || oEnum.Equals(ENUM_TARGET_SCORE.S202E) || oEnum.Equals(ENUM_TARGET_SCORE.S203E))
                        if (m_strProcessData=="S201E" || m_strProcessData == "S202E" || m_strProcessData == "S203E")
                        {
                            if (m_strProcessData == "S201E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S202E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S203E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S191E" || m_strProcessData == "S192E" || m_strProcessData == "S193E")
                        {
                            if (m_strProcessData == "S191E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S192E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S193E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S181E" || m_strProcessData == "S82E" || m_strProcessData == "S83E")
                        {
                            if (m_strProcessData == "S181E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S182E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S183E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S171E" || m_strProcessData == "S172E" || m_strProcessData == "S173E")
                        {
                            if (m_strProcessData == "S171E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S172E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S173E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S161E" || m_strProcessData == "S162E" || m_strProcessData == "S163E")
                        {
                            if (m_strProcessData == "S161E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S162E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S163E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S151E" || m_strProcessData == "S152E" || m_strProcessData == "S153E")
                        {
                            if (m_strProcessData == "S151E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S152E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S153E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S141E" || m_strProcessData == "S142E" || m_strProcessData == "S143E")
                        {
                            if (m_strProcessData == "S141E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S142E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S143E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S131E" || m_strProcessData == "S132E" || m_strProcessData == "S133E")
                        {
                            if (m_strProcessData == "S131E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S132E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S133E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S121E" || m_strProcessData == "S122E" || m_strProcessData == "S123E")
                        {
                            if (m_strProcessData == "S121E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S122E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S123E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S111E" || m_strProcessData == "S112E" || m_strProcessData == "S113E")
                        {
                            if (m_strProcessData == "S111E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S112E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S113E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S101E" || m_strProcessData == "S102E" || m_strProcessData == "S103E")
                        {
                            if (m_strProcessData == "S101E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S102E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S103E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S91E" || m_strProcessData == "S92E" || m_strProcessData == "S93E")
                        {
                            if (m_strProcessData == "S91E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S92E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S93E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S81E" || m_strProcessData == "S82E" || m_strProcessData == "S83E")
                        {
                            if (m_strProcessData == "S81E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S82E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S83E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S71E" || m_strProcessData == "S72E" || m_strProcessData == "S73E")
                        {
                            if (m_strProcessData == "S71E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S72E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S73E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S61E" || m_strProcessData == "S62E" || m_strProcessData == "S63E")
                        {
                            if (m_strProcessData == "S61E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S62E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S63E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S51E" || m_strProcessData == "S52E" || m_strProcessData == "S53E")
                        {
                            if (m_strProcessData == "S51E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S52E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S53E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S41E" || m_strProcessData == "S42E" || m_strProcessData == "S43E")
                        {
                            if (m_strProcessData == "S41E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S42E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S43E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S31E" || m_strProcessData == "S32E" || m_strProcessData == "S33E")
                        {
                            if (m_strProcessData == "S31E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S32E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S33E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S21E" || m_strProcessData == "S22E" || m_strProcessData == "S23E")
                        {
                            if (m_strProcessData == "S21E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S22E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S23E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else if (m_strProcessData == "S11E" || m_strProcessData == "S12E" || m_strProcessData == "S13E")
                        {
                            if (m_strProcessData == "S11E")
                                csSingleton.getInstance.g_nTargetLine = 1;
                            else if (m_strProcessData == "S12E")
                                csSingleton.getInstance.g_nTargetLine = 2;
                            else if (m_strProcessData == "S13E")
                                csSingleton.getInstance.g_nTargetLine = 3;
                            else
                            {
                                csSingleton.getInstance.g_nTargetLine = 1;
                            }
                        }
                        else
                        {
                        }

                        csSingleton.getInstance.g_nTargetBasicScore = csSingleton.getInstance.g_nTargetScore / csSingleton.getInstance.g_nTargetLine;

                        Debug.Log("csSingleton.getInstance.g_nTargetBasicScore " + csSingleton.getInstance.g_nTargetBasicScore.ToString());
                    }
                    csSingleton.getInstance.g_enumSignal = oEnum;
                    //----------------------------------------------
                    m_strReciveData = "";
                }
            }
        }
        catch (Exception e)
        {
            //string text = e.Message;
            //Debug.Log(e.Message);
            //int a = 0;
        }
    }

}