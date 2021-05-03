using UnityEngine;      // Debug.log

public class ListTree 
{
    public Socket root;   // publc, so that we can call it from the Tree object

    Vector2 origin = new Vector2(0f, 3.25f);

    public void Find(int value)
    {
        // TODO: binary search
    }

    public void Add(Bulb b)    
    {
        // if root:
        //    b.transform.position = origin;  // <- place fist item on top of the tree
        // otherwise:
        //   root.Add(b);  // <- will compute corresponding position 
    }

    // root, left, right
    public void Preorder(Socket n)
    {
        // LightLine.Flash(n.item);        // add to illumination line
    }

    public void Inorder(Socket n)
    {
    }

    // left , right, root
    public void Postorder(Socket n)
    {
    }

    // if this is too complicated (using queue, leave out)
    public void LevelOrder(Socket n)
    {
    }
}
