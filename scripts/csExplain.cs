using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csExplain : MonoBehaviour
{

    public GameObject[] m_poExplain = new GameObject[45];//이미지 저장
    

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    public void SetExplain(int nNo)
    {
        for (int i = 0; i < csSingleton.getInstance._EXPLAIN_NUM; i++) //싱글톤에서 코드로인한 저장 총 45개
        {
            m_poExplain[i].SetActive(false);     
        }
        m_poExplain[nNo].SetActive(true);
        

    }


}
