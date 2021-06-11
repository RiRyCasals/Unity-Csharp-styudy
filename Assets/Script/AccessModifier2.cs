using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessModifier2 : MonoBehaviour
{
    AccessModifier1 testAccessModifier;

    int num1_check;
    int num2_check;

    private void Start() {
        testAccessModifier = new AccessModifier1();
        
        testAccessModifier.str = "Test";

        testAccessModifier.setNum(10, 20);
        num1_check = testAccessModifier.getNum1();
        num2_check = testAccessModifier.getNum2();

        Debug.Log("string = " + testAccessModifier.str + ", num1 = " + num1_check + ", num2 = " + num2_check);
    }
}
