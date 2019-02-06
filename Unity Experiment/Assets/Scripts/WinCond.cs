using UnityEngine;

public class WinCond : MonoBehaviour
{

    public GameManager gameM;
    public Rigidbody rb;
    public float y2 = 2f;

    void Update()
    {
        if (rb.position.y < y2)
        {
            gameM.CompleteLevel();
        }
    }
}
