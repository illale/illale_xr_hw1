using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private bool changedLocation = false;
    private bool isPressed = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(XRNode.LeftHand), InputHelpers.Button.PrimaryButton, out bool PrimaryButton, 1f);
        if (PrimaryButton) {
            if (!isPressed) {
                if (changedLocation) {
                    transform.position = new Vector3(0, 2, 100);
                    changedLocation = false;
                } else {
                    transform.position = new Vector3(0, 2, 0);
                    changedLocation = true;
                }
            }
            isPressed = true;
        } else {
            isPressed = false;
        }
    }
}
