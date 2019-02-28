using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_B : MonoBehaviour
{
    // +++ public class methods +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    // Must be public if called by other classes
    public void ShowMessage(string message)
    {
        Debug.Log(message);
    }
}
