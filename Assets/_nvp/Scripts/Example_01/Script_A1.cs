using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_A1 : MonoBehaviour
{
    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public delegate void OnShowMessageDelegate(string message);

    public static event OnShowMessageDelegate OnShowMessage = delegate { };





    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            // More loosely coupled
            OnShowMessage("Hello, World by Events");
        }
    }
}
