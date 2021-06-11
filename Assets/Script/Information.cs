using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information : MonoBehaviour
{
    string name;
    string address;

    public Information(string name, string address) {
        this.name = name;
        this.address = address;
    }

    public void PrintMember() {
        Debug.Log("Name : " + this.name);
        Debug.Log("Address : " + this.address);
    }
}