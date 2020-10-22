using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public FollowPlayer followingCamera;
    public Score scoreChange;
    public PlayerMovement movement;
    public Rigidbody rb;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            movement.enabled = false;
            rb.constraints = RigidbodyConstraints.FreezePositionX;
            followingCamera.enabled = false;
            scoreChange.enabled = false;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
