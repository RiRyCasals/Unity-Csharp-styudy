using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationList : MonoBehaviour
{
    Information[] informations;

    int max;
    int number;

    public InformationList(int length) {
        max = length;
        number = 0;
        informations = new Information[length];
    }

    public void SetInformation(string name, string address) {
        if (number == max) {
            Debug.Log("Can't save any more");
        } else {
            informations[number] = new Information(name, address);
            number++;
        }
    }

    public void PrintInformations() {
        for (int i = 0; i < number; i++) {
            Debug.Log("Number." + i);
            informations[i].PrintMember();
        }
    }
}
