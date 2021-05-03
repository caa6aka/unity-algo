using UnityEngine;      // Debug.log

public class ArrayTree 
{
    Vector2 origin = new Vector2(0f, 3.25f);
    // Tree starts at index 1.. compute indices for right and left subtees accordingly
    public static Bulb[] array = new Bulb[64 + 1];    

    public  void Find(int value)
    {
        // TODO: binary search
    }

    public void Add(Bulb b, int ix=1)         
    {
        // if root:
        // b.transform.position = origin;  // <- place first item on top of tree
        // otherwise: 
        //     b.transform.position = new Vector2(item.transform.position.x - 1f, item.transform.position.y - 1f);

    }

    // root, left, right
    public void Preorder(int ix)
    {
            // LightLine.Flash(array[ix]);    
    }

    // Left subtree, Root, Right subtree
    public void Inorder(int ix)
    {
    }

    // left subtree, right subtree, root
    public void Postorder(int ix)
    {
    }

    // if too complex (using the Queue) leave out for time being
    public void LevelOrder(int ix)
    {
      
    }
  
}
