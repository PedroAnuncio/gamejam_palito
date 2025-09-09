using UnityEngine;

public class breaking : MonoBehaviour
{
    public Sprite[] blockStates;
    private int hits = 0;
    private SpriteRenderer sr;
    
    public GameObject hitter;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = blockStates[hits];
    }

    public void TakeHit()
    {
        hits++;

        if (hits < blockStates.Length)
        {
            sr.sprite = blockStates[hits];
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == hitter)
        {
            print($"{hitter.name} bateu!");
            TakeHit();
        }
    }
}
