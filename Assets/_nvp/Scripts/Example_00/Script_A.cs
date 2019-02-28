using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_A : MonoBehaviour
{
    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Works but generally a bad idea
            Script_B scriptB = GameObject.FindObjectOfType<Script_B>();
            scriptB.ShowMessage("Hello, World");
        }
    }
}
