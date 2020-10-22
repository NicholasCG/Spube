using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("MENU");
    }
}
