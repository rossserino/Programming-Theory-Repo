using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeBehavior : GameBehaviour
{
    //POLYMORPHISM
    public override void OnTriggerEnter(Collider other)
    {
        Debug.Log("Pipe behavior override Trigger entered");
        SceneManager.LoadScene(2);
    }
}
