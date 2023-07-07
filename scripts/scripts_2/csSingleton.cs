using UnityEngine;
//using System.Collections;
using System.Collections.Generic;


public class csSingletonM : MonoBehaviour {

    private static csSingleton instance;
	// Use this for initialization
    public static csSingleton getInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(csSingletonM)) as csSingleton;
            }

            if (instance == null)
            {
                GameObject obj = new GameObject("obj");
                instance = obj.AddComponent(typeof(csSingletonM)) as csSingleton;
            }

            return instance;
        }
    }

    // 방향키, 옵션, 시작
    public bool g_bSwitch = false;
    public int g_nSwitch = -1;

    // 타겟
    public bool g_bTarget = false;
    public int g_nTargetScore = -1;

    public ENUM_TARGET_SCORE g_enumSignal;





}
