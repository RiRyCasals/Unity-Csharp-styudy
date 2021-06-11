using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    void Start() {
        string objectName = gameObject.name;

        switch (objectName) {
            case "Sphere":
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
            case "Cube":
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case "Capsule":
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;
            default:
                Debug.Log("default");
                break;
        }
    }
}
