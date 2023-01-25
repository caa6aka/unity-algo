using UnityEngine;

public class Cell : MonoBehaviour
{
    public Sprite liveImg, deadImg;
    private SpriteRenderer sr;
    public bool Alive;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
}
