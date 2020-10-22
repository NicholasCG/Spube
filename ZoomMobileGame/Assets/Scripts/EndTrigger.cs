using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public FollowPlayer followingCamera;
    public Rigidbody rb;
    public GameManager gameManager;
    public Score score;

    public GameObject left;
    public GameObject right;
    public GameObject pause;
    void OnTriggerEnter ()
    {
        followingCamera.enabled = false;
        score.enabled = false;

        left.SetActive(false);
        right.SetActive(false);
        pause.SetActive(false);

        rb.constraints = RigidbodyConstraints.FreezePositionX;
        gameManager.CompleteLevel();
    }
}
