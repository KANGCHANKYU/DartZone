using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
public class csNumber : MonoBehaviour {

    public Sprite[] m_poNumberSprites = new Sprite[10];
    public GameObject m_oNumberPrefab;
    Image[] m_poNumber;
    Vector3 m_vecPos;
    string m_strNumber = "";
    int m_nNumber = 0;
    int m_nCount = 1;
    int m_nNumCount = 1;
    int m_nDist = 0;
    int m_nOption = 0;
    List<GameObject> m_oListNumber = new List<GameObject>();

    // Use this for initialization
    void Start () {

        m_vecPos = gameObject.transform.position;


    }
	
	// Update is called once per frame
	void Update () {
	}

    //---------------------------------------------------
    // public void CreateNumber(int nCount, int nDistX, float fScale, int nOption)
    // 숫자 생성 (자리수, 글자간 거리, 스케일, 옵션(0:가운데, 1:왼쪽, 2:오른쪽 )
    //---------------------------------------------------
    public void CreateNumber(int nCount, int nDistX, float fScale, int nOption)
    {
        m_nCount = nCount;
        m_nDist = nDistX;
        m_nOption = nOption;
        GameObject oObj;
        Vector3 vecPos;
        Vector3 vecScale;
        vecScale.x = fScale;
        vecScale.y = fScale;
        vecScale.z = fScale;
        for (int i = 0; i < nCount; i++)
        {
            vecPos = m_vecPos;
            vecPos.x += i * nDistX;

            oObj = Instantiate(m_oNumberPrefab, gameObject.transform) as GameObject;
            oObj.transform.localScale = vecScale;
            oObj.transform.position = vecPos;
            oObj.SetActive(false);
            m_oListNumber.Add(oObj);
        }
        //SetNumber(0);
    }

    //---------------------------------------------------
    // public void SetNumber(int nNumber)
    // 숫자 설정 (숫자)
    //---------------------------------------------------
    public void SetNumber(int nNumber)
    {
        m_nNumber = nNumber;
        m_strNumber = nNumber.ToString();
        m_nNumCount = m_strNumber.Length;

        //string[] strArrayWord = m_strNumber.split("");
        //m_nNumCount = strArrayWord.Length;

        if (m_nNumCount > m_nCount) return;
        for (int i = 0; i < m_nCount; i++)
        {
            m_oListNumber[i].SetActive(false);
        }

        if (nNumber < 0) return;

        int nNo = 0;
        for (int i = (m_nCount- m_nNumCount); i < m_nCount; i++)
        {
            m_oListNumber[i].GetComponent<Image>().sprite = m_poNumberSprites[Convert.ToInt32(m_strNumber.Substring(nNo, 1))];
            m_oListNumber[i].SetActive(true);
            nNo++;
        }

        int nPosNum = m_nCount - m_nNumCount;
        Vector3 vecFrom;
        switch (m_nOption)
        {
            case 0:
                {
                    vecFrom.x = -(float)(m_nNumCount - 1) * (float)m_nDist * 0.5f;
                    vecFrom.y = 0.0f;
                    vecFrom.z = 0.0f;

                    for (int i = (m_nCount - m_nNumCount); i < m_nCount; i++)
                    {
                        m_oListNumber[i].transform.localPosition = vecFrom;
                        vecFrom.x += m_nDist;
                    }
                }
                break;
            case 1:
                {
                    vecFrom.x = -(m_nCount-1)* m_nDist;
                    vecFrom.y = 0.0f;
                    vecFrom.z = 0.0f;

                    for (int i = 0; i < m_nCount; i++)
                    {
                        m_oListNumber[i].transform.localPosition = vecFrom;
                        vecFrom.x += m_nDist;
                    }
                }
                break;
            case 2:
                {
                    vecFrom.x = 0.0f;
                    vecFrom.y = 0.0f;
                    vecFrom.z = 0.0f;

                    for (int i = 0; i < m_nCount; i++)
                    {
                        m_oListNumber[i].transform.localPosition = vecFrom;
                        vecFrom.x += m_nDist;
                    }
                }
                break;
        }
        

    }
}
