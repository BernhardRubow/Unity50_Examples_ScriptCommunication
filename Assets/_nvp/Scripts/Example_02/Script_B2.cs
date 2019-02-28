using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_B2 : MonoBehaviour
{
    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private void Start()
    {
        // subscribes to event
        SubscribeToEvents();
    }




    // +++ event handler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private void OnDisable()
    {
        UnsubscribeToEvents();
    }

    private void OnShowMessage(object sender, object eventArgs)
    {
        string msg = eventArgs as string;

        Debug.Log(msg);
    }


    // +++ private class methods ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private void SubscribeToEvents()
    {
        NvpEventController.SubscribeToEvent(NvpGameEvents.OnShowMessage, OnShowMessage);
    }

    private void UnsubscribeToEvents()
    {
        NvpEventController.UnsubscribeFromEvent(NvpGameEvents.OnShowMessage, OnShowMessage);
    }
}
