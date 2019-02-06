using UnityEngine;

public class PlayerColli : MonoBehaviour
{

    public PlayerMove move;
    public float restartDelay = 5f;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            move.enabled = false;
            Invoke("LoseCheck", restartDelay);
        }
    }

    void LoseCheck()
    {
        if (FindObjectOfType<GameManager>().wincond == false)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
