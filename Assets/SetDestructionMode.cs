using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetDestructionMode : MonoBehaviour
{
    public static bool destructive = false;
    public Toggle dest;
    public void setDestructive()
    {
        destructive=dest.isOn;
    }
}
