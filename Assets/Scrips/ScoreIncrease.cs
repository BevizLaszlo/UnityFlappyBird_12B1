using UnityEngine;

public class ScoreIncrease : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Score.instance.ScoreUpdae();
        }
    }
}
