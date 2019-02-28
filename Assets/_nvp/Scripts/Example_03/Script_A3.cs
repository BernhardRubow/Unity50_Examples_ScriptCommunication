using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Script_A3 : MonoBehaviour
{
    [Inject]
    private INvpEventModel _eventModel;

    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // More loosely coupled
            _eventModel.InvokeEvent(NvpGameEvents.OnShowMessage, this, "Hello, World by Injected EventModel");
        }
    }
}
