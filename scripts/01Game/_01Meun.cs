using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class _01Meun : MonoBehaviour
{
    public int m_nMeunSelect = 0;
    public GameObject meue;
    public GameObject[] m_PoFuzzMeun=new GameObject[3];
    public Image Expain;
    public GameObject RuleExpaln;
    public Sprite[] On = new Sprite[3];
    public Sprite[] Off = new Sprite[3];
    public GameObject G_save;

    public cs01GameManager gmg;
    public Save save;

    void Start ()
    {
        G_save = GameObject.FindWithTag("Save");
        save = G_save.GetComponent<Save>();
        RuleExpaln.SetActive(false);
	}

    private void OnEnable()
    {
        for (int i = 0; i < m_PoFuzzMeun.Length; i++)
            m_PoFuzzMeun[i].GetComponent<Image>().sprite = Off[i];
        m_PoFuzzMeun[0].GetComponent<Image>().sprite = On[0];
    }

    void Update ()
    {
		
	}

    public void ArrowButton(int nDir)
    {
        switch(nDir)
        {
            case 0:
                {
                    m_nMeunSelect--;
                    if (m_nMeunSelect < 0)
                        m_nMeunSelect = 2;

                    for (int i = 0; i < m_PoFuzzMeun.Length; i++)
                        m_PoFuzzMeun[i].GetComponent<Image>().sprite = Off[i];
                    m_PoFuzzMeun[m_nMeunSelect].GetComponent<Image>().sprite = On[m_nMeunSelect];
                }break;
            case 1:
                {
                    m_nMeunSelect++;

                    if (m_nMeunSelect > 2)
                        m_nMeunSelect = 0;

                    for (int i = 0; i < m_PoFuzzMeun.Length; i++)
                        m_PoFuzzMeun[i].GetComponent<Image>().sprite = Off[i];
                    m_PoFuzzMeun[m_nMeunSelect].GetComponent<Image>().sprite = On[m_nMeunSelect];
                }
                break;
            case 100:
                {
                    if (m_nMeunSelect == 0)
                    {
                        RuleExpaln.SetActive(true);
                        Expain.enabled = false;
                    }

                    if (m_nMeunSelect == 1)
                    {
                        meue.SetActive(false);
                        gmg.isOpen = false;
                    }

                    if (m_nMeunSelect == 2)
                    {
                        SceneManager.LoadScene("SampleScene");
                    }
                }
                break;
            case 75:
                {
                    RuleExpaln.SetActive(false);
                }  
                break;
        }
    }

}
