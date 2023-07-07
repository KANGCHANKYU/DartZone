using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csSingleton2 : MonoBehaviour
{
    private static csSingleton2 instance;

    public static csSingleton2 getinstance
    {
        get
        {
            if(instance==null)
            {
                instance = FindObjectOfType(typeof(csSingleton2)) as csSingleton2;
            }

            if(instance==null)
            {
                GameObject obj = new GameObject("obj");
                instance = obj.AddComponent(typeof(csSingleton2)) as csSingleton2;
            }

            return instance;
        }
    }

    public int COUT_UP = 0;
    public int KINGOFBULL = 1;
    public int TAKESCORE = 2;
    public int _301 = 3;
    public int _501 = 4;
    public int _701 = 5;
    public int _901 = 6;
    public int _1101 = 7;
    public int _1501 = 8;
    public int STANDARDCR=9;
    public int CUTTHROATCR = 10;
    public int HIDDENCR = 11;
    public int PT_301 = 12;
    public int PT_501 = 13;
    public int PT_COUNT_UP = 14;
    public int PT_KINGOFBULL = 15;
    public int PT_TAKESCORE = 16;
    public int PT_STANDARDCR = 17;
    public int BINGGO33 = 18;
    public int BINGGO44 = 19;
    public int BINGGO55 = 20;
    public int BB33 = 21;
    public int BB44 = 22;
    public int BBporket = 23;
    public int FITNUMBER = 24;
    public int _END = 25;

}
