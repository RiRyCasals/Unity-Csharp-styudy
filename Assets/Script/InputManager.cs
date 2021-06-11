using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    InputField inputName;
    InputField inputAddress;

    public InputManager() {
        inputName = GameObject.Find("InputName").GetComponent<InputField>();
        inputAddress = GameObject.Find("InputAddress").GetComponent<InputField>();
    }

    public string GetInputName() {
        string name = inputName.text;
        inputName.text = "";
        return name;
    }

    public string GetInputAddress() {
        string address = inputAddress.text;
        inputAddress.text = "";
        return address;
    }
}
