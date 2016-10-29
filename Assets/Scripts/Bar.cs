using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public Text label;
    private int score;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        label.text = "Score: " + ++score;
    }
}