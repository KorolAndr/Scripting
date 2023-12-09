using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int jumpFactor = 10;
    public int jumpFactor2 = 2;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = jumpFactor;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = jumpFactor2;
    }
}
