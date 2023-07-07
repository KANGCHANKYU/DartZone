using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csExplain_2 : MonoBehaviour
{
    public GameObject[] m_poExplain = new GameObject[25];
	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
		
	}

    public void SetExplain(int nNo)
    {
        for(int i=0;i<csSingleton2.getinstance._END;i++)
        {
            m_poExplain[i].SetActive(false);
        }
        m_poExplain[nNo].SetActive(true);
    }
}
