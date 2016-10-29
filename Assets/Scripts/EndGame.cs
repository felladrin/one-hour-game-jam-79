using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject EndGameText;

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(coll.gameObject);
        EndGameText.SetActive(true);
    }
}