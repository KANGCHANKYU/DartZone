using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Logo : MonoBehaviour
{

    //public csSingleton cs;
    //public csControlIO Io;
    //public GameObject m_oTest1;
    //public GameObject m_oTest2;
    //public GameObject m_oTest3;

    //void Start()
    //{
    //    m_oTest1.GetComponent<csNumber>().CreateNumber(8, 120, 0.8f);
    //    m_oTest2.GetComponent<csNumber>().CreateNumber(8, 120, 0.8f);
    //    m_oTest3.GetComponent<csNumber>().CreateNumber(8, 120, 0.8f);
    //    m_oTest1.GetComponent<csNumber>().SetNumber(12345);
    //    m_oTest2.GetComponent<csNumber>().SetNumber(1234);
    //    m_oTest3.GetComponent<csNumber>().SetNumber(123);

    //}
    void Update ()
    {
        //if (csSingleton.getInstance.g_bSwitch) //이게 트루이면 센서가 작동되었다 라는뜻
        //{
        //    csSingleton.getInstance.g_bSwitch = false;
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            csSingleton.getInstance.g_bSwitch = false;
            SceneManager.LoadScene("SampleScene");
        }

        if (csSingleton.getInstance.g_bSwitch && csSingleton.getInstance.g_nSwitch == 1005)
        {
            csSingleton.getInstance.g_bSwitch = false;
            SceneManager.LoadScene("SampleScene");
        }
    }
}
