using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ace_Laps : MonoBehaviour
{


    public int _currentLapCount;


    private void OnTriggerEnter(Collider other)
    {
        _currentLapCount += 1;
    }
}
