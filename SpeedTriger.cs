using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other) //Когда персонаж находется в колайдере 
    {
        //Увеличение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other) //Когда персонаж не задивает колайдер
    {
        //Понижение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
