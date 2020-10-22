using UnityEngine;
using UnityEngine.UI;

public class ButtonSettings : MonoBehaviour
{

    public static bool buttonState = false;
    public Toggle t;
    public void Start()
    {
        t.isOn = buttonState;
    }
    public void changeButton (bool newState)
    {
        buttonState = newState;
        Debug.Log(buttonState + "change");
    }
}
