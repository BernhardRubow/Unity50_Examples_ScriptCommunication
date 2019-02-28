using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_B1 : MonoBehaviour
{
    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private void Start()
    {
        // subscribes to event
        Script_A1.OnShowMessage += OnShowMessage;
    }

    


    // +++ Event Handler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public void OnShowMessage(string message)
    {
        Debug.Log(message);
    }
}
