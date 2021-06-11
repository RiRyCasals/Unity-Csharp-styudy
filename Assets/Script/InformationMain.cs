using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationMain : MonoBehaviour
{
    InputManager inputManager;
    InformationList informationList;

    void Start() {
        inputManager = new InputManager();
        informationList = new InformationList(5);
    }

    public void Register() {
        informationList.SetInformation(inputManager.GetInputName(),
                                        inputManager.GetInputAddress());
    }

    public void Print() {
        informationList.PrintInformations();
    }
}
