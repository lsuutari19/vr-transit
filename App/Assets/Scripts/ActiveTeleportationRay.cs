using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActiveTeleportationRay : MonoBehaviour
{

    public GameObject leftTeleportation;
    public GameObject rightTeleportation;

    public InputActionProperty leftActive;
    public InputActionProperty rightActive; 

    // Update is called once per frame
    void Update()
    {
        leftTeleportation.SetActive(leftActive.action.ReadValue<float>() > 0.1f);
        rightTeleportation.SetActive(rightActive.action.ReadValue<float>() > 0.1f);
    }
}
