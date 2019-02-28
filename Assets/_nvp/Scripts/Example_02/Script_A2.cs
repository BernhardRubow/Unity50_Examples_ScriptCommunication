using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_A2 : MonoBehaviour
{
    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            // More loosely coupled
            NvpEventController.InvokeEvent(NvpGameEvents.OnShowMessage, this, "Hello, World by EventController");
        }
    }
}
