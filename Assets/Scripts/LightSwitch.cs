using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class LightSwitch : VRTK_InteractableObject {
    [Header("Light Button")] public List<LightAvailable> lights;

    public override void StartUsing(VRTK_InteractUse currentUsingObject = null) {
        base.StartUsing(currentUsingObject);
        lights.ForEach(l => l.toggle());
    }
}