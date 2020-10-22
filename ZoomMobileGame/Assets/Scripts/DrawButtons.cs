using UnityEngine;
using UnityEngine.UI;

public class DrawButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject left;
    public GameObject right;
    void Start()
    {
        Debug.Log(ButtonSettings.buttonState);
        left.SetActive(ButtonSettings.buttonState);
        right.SetActive(ButtonSettings.buttonState);
    }

}
