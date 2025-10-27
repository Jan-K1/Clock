using System;
using UnityEngine;

public class Clock : MonoBehaviour {
    [SerializeField]
    Transform hours_pivot, minutes_pivot, seconds_Pivot;
    const float hours_to_degrees = -30f, minutes_to_degrees = -6f, seconds_to_degrees = -6f;

    void Update () {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hours_pivot.localRotation =
         Quaternion.Euler(0f, 0f, hours_to_degrees * (float)time.TotalHours);
        minutes_pivot.localRotation =
         Quaternion.Euler(0f, 0f, minutes_to_degrees *  (float)time.TotalMinutes);
        seconds_Pivot.localRotation =
         Quaternion.Euler(0f, 0f, seconds_to_degrees * (float)time.TotalSeconds); 
         
        
    }
}