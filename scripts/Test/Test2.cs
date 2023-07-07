using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public bool isOne = false;
    public bool isP1_20 = false;
    public bool isP2_20 = false;
    public bool isP1_19 = false;
    public bool isP2_19 = false;

    public int _20P1 = 60;
    public int _20P2 = 60;
    public int _19P1 = 57;
    public int _19P2 = 57;
    public int P1 = 0;
    public int P2 = 0;

	void Start ()
    {
		
	}


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!isOne)
            {
                isOne = true;
                Debug.Log("bool" + isOne);
            }
            else
                Debug.Log("h2");
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if (isP1_20&&!isP2_20||!isP1_20&&!isP2_20)
            {
                _20P1 -= 20;
                Debug.Log("_20P1 :" + _20P1.ToString());
            }
            if (_20P1 <= 0)
            {
                isP1_20 = true;

            }
            if (isP1_20 && !isP2_20)
            {
                _20P1 *= -1;
                P1 += _20P1;
                Debug.Log("P1 :" + P1.ToString());
                _20P1 = 0;
                Debug.Log("_20P1 :" + _20P1.ToString());
            }
            if (isP1_20 && isP2_20)
            {
                Debug.Log("20End");
            }

        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            if (isP1_20 && !isP2_20 || !isP1_20 && !isP2_20)
            {
                _20P1 -= 40;
                Debug.Log("_20P1 :" + _20P1.ToString());
            }
            if(_20P1<=0)
            {
                isP1_20 = true;
            }
            if(isP1_20&&!isP2_20)
            {
                _20P1 *= -1;
                P1 += _20P1;
                Debug.Log("P1 :" + P1.ToString());
                _20P1 = 0;
                Debug.Log("_20P1 :" + _20P1.ToString());
            }
            if (isP1_20 && isP2_20)
            {
                Debug.Log("20End");
            }
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            if (isP1_20 && !isP2_20 || !isP1_20 && !isP2_20)
            {
                _20P2 -= 20;
                Debug.Log("_20P2 :" + _20P2.ToString());
            }
            if (_20P2 <= 0)
            {
                isP2_20 = true;
            }
            if (isP2_20 && !isP1_20)
            {
                _20P2 *= -1;
                P2 += _20P2;
                Debug.Log("P2 :" + P2.ToString());
                _20P2 = 0;
                Debug.Log("_20P2 :" + _20P2.ToString());
            }
            if (isP1_20 && isP2_20)
            {
                Debug.Log("20End");
            }

        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (isP1_20 && !isP2_20 || !isP1_20 && !isP2_20)
            {
                _20P2 -= 40;
                Debug.Log("_20P2 :" + _20P2.ToString());
            }
            if (_20P2 <= 0)
            {
                isP2_20 = true;
            }
            if (isP2_20 && !isP1_20)
            {
                _20P2 *= -1;
                P2 += _20P2;
                Debug.Log("P2 :"+ P2.ToString());
                _20P2 = 0;
                 Debug.Log("_20P2 :" + _20P2.ToString());
            }
            if (isP1_20 && isP2_20)
            {
                Debug.Log("20End");
            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (isP1_19 && !isP2_19 || !isP1_19 && !isP2_19)
            {
                _19P1 -= 19;
                Debug.Log("_19P1 :" + _19P1.ToString());
            }
            if (_19P1 <= 0)
            {
                isP1_19 = true;
            }
            if (isP1_19 && !isP2_19)
            {
                _19P1 *= -1;
                P1 += _19P1;
                Debug.Log("P1 :" + P1.ToString());
                _19P1 = 0;
                Debug.Log("_19P1 :" + _19P1.ToString());
            }
            if (isP1_19 && isP2_19)
            {
                Debug.Log("19END");
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (isP1_19 && !isP2_19 || !isP1_19 && !isP2_19)
            {
                _19P1 -= 38;
                Debug.Log("_19P1 :" + _19P1.ToString());
            }
            if (_19P1 <= 0)
            {
                isP1_19 = true;
            }
            if (isP1_19 && !isP2_19)
            {
                _19P1 *= -1; ;
                P1 += _19P1;
                Debug.Log("P1 :" + P1.ToString());
                _19P1 = 0;
                Debug.Log("_19P1 :" + _19P1.ToString());
            }
            if (isP1_19 && isP2_19)
            {
                Debug.Log("19END");
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (isP1_19 && !isP2_19 || !isP1_19 && !isP2_19)
            {
                _19P2 -= 19;
                Debug.Log("_19P2 :" + _19P2.ToString());
            }
            if (_19P2 <= 0)
            {
                isP2_19 = true;
            }
            if (isP2_19 && !isP1_19)
            {
                _19P2 *= -1;
                P2 += _19P2;
                Debug.Log("P2 : " + P2.ToString());
                _19P2 = 0;
                Debug.Log("_19P2 :" + _19P2.ToString());
            }
            if (isP1_19 && isP2_19)
            {
                Debug.Log("19END");
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (isP1_19 && !isP2_19 || !isP1_19 && !isP2_19)
            {
                _19P2 -= 38;
                Debug.Log("_19P2 :" + _19P2.ToString());
            }
            if (_19P2 <= 0)
            {
                isP2_19 = true;
            }
            if (isP2_19 && !isP1_19)
            {
                _19P2 *= -1;
                P2 += _19P2;
                Debug.Log("P2 : " + P2.ToString());
                _19P2 = 0;
                Debug.Log("_19P2 :" + _19P2.ToString());
            }
            if (isP1_19 && isP2_19)
            {
                Debug.Log("19END");
            }
        }
 

    }
}
