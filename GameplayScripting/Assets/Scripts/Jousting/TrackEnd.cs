using System;
using UnityEngine;

public class TrackEnd : MonoBehaviour
{
    public event Action OnRoundEnd;

    private void OnTriggerEnter2D()
    {
        OnRoundEnd();
    }
}
