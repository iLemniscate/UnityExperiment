using UnityEngine;
using UnityEngine.UI;

public class StartScore : MonoBehaviour
{
    public Score sc;
    //public Text t;
    //public Color newColor;

    public void Startsc()
    {
        //t.color = Color.Lerp(t.color, newColor, 0.1f);
        sc.enabled = true;
    }
}
