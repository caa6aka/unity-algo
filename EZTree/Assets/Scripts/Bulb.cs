using UnityEngine;

// our Node
public class Bulb : MonoBehaviour
{
    int value;
    bool installed = false;
    SpriteRenderer sr;
    Color originalColor;
    Color hiliteColor = Color.red;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        originalColor = sr.color;
        value = int.Parse(name);
    }

    public void Add(Bulb s)
    {
       // place in the structure..

        // for the UI, move it below, to the left or right:
       // s.transform.position = new Vector2(item.transform.position.x +- 1f, item.transform.position.y - 1f);

    }

    public void Flash()
    {

    }

    void OnMouseDown()   // place on tree - no removal, for simplicity
    {
        if (!installed)
        {
            Add(this);
            installed = true;
        }
    }

}
