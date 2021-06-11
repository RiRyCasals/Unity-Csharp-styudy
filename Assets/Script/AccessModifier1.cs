using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessModifier1 : MonoBehaviour
{
    private int num1;
    private int num2;
    public string str;

    public void setNum(int num1, int num2) {
        this.num1 = num1;
        this.num2 = num2;
    }

    public int getNum1() {
        return num1;
    }
    public int getNum2() {
        return num2;
    }
}
