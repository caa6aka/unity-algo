using UnityEngine;

// a glowing decoration light
public class Bulb : MonoBehaviour
{
    public int value;
    public Color hiliteColor = Color.red;

    SpriteRenderer sr;
    Color originalColor;

    bool installed = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();   
        originalColor = sr.color;
        value = int.Parse(name);
    }

    // traversal hilites bulbs, one at a time. seqnum gives us pause beween light-ups
    public void Flash()
    {
        Hilite();
        Invoke("Reset", 1f);
    }

    public void Hilite()
    {
        sr.color = hiliteColor;
    }

    void Reset()
    {
        sr.color = originalColor;
    }

    void OnMouseDown()   // place on tree - no removal, for simplicity
    {
        if (! installed)
        {
            Tree.Add(this);   
            installed = true;
        }
    }

}
