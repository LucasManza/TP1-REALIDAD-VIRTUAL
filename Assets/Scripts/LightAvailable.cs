using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAvailable : MonoBehaviour {
    private Light light;

    // Use this for initialization
    void Start() {
        light = GetComponent<Light>();
    }


    public void toggle() {
        if (light.enabled) {
            light.enabled = false;
        }
        else
            light.enabled = true;
    }
}