using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    public int Round = 6;
    public int[] RoundValue = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 25 };
    public int n1 = 0;
    public int n2 = 0;
    public int n3 = 0;
    public int n4 = 0;
    public int n5 = 0;
    public int n6 = 0;

	void Start ()
    {
        for (int i = 0; i < Round; ++i)
        {
            int ranIdx = Random.Range(i, RoundValue.Length);

            int tmp = RoundValue[ranIdx];
            RoundValue[ranIdx] = RoundValue[i];
            RoundValue[i] = tmp;
        }
        n1 = RoundValue[0];
        n2 = RoundValue[1];
        n3 = RoundValue[2];
        n4 = RoundValue[3];
        n5 = RoundValue[4];
        n6 = RoundValue[5];
    }
	

	void Update () {
		
	}
}
