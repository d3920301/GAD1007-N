using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRound : MonoBehaviour
{
    public event Action OnEndRound;

    public bool canEndRound { get; set; } = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canEndRound)
        {
            //Debug.Log("End Round");
            OnEndRound();
        }
    }
}
