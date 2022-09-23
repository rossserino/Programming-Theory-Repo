using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered");
    }
}
