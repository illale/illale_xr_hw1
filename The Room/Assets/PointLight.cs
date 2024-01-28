using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class PointLight : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light;
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(XRNode.RightHand), InputHelpers.Button.SecondaryButton, out bool SecondaryButton, 0.5f);
        if (SecondaryButton) {
            light.color = Color.blue;
            Debug.Log("Trigger button is pressed.");
        }
    }
}
