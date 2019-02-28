using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Script_B3 : MonoBehaviour
{
    [Inject]
    private INvpEventModel _eventModel;

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
        _eventModel.SubscribeToEvent(NvpGameEvents.OnShowMessage, OnShowMessage);
    }

    private void UnsubscribeToEvents()
    {
        _eventModel.UnsubscribeFromEvent(NvpGameEvents.OnShowMessage, OnShowMessage);
    }
}
