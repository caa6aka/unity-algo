using UnityEngine;

// our Node
public class Socket 
{
    public Bulb item;  // our value
    public Socket left, right;
    public Socket parent;       // for deletion, parent sets this child as null

    public Socket(Bulb b)
    {
        item = b;
    }

    // smaller values go left subtree, larger go to right
    public void Add(Bulb b)
    {
        // place to the left or the right of the parent, depending on value
        // if value is smaller, paint on screen below and to the left
       // b.transform.position = new Vector2(item.transform.position.x - 1f, item.transform.position.y - 1f);
       // otherwise, plant below and do the right...

    }
   
}
