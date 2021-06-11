using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcMain : MonoBehaviour
{
    CalcSub calcSub;

    private void Start() {
        calcSub = new CalcSub();

        Debug.Log("Add = " + calcSub.Add(3, 4));
        Debug.Log("Sub = " + calcSub.Sub(3, 4));
        Debug.Log("Mul = " + calcSub.Mul(3, 4));
        Debug.Log("Div = " + calcSub.Div(3, 4));
    }
}
