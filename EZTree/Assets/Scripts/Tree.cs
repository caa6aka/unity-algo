using UnityEngine;

public class Tree : MonoBehaviour
{
    public bool isArray;

    static ListTree lTree;      // could inherit from Tree, but no real need for it
    static ArrayTree aTree;     // as we want to keep Tree implemenations unrelated to Unity library

    void Start()
    {
        // only one at a time: either LL-based or array-based
        if(isArray)
           aTree = new ArrayTree();
        else
           lTree = new ListTree();
    }

    public static void Add(Bulb bulb)
    {
        if (aTree != null)
            aTree.Add(bulb);
        else
            lTree.Add(bulb);

        print("ltree is: " + lTree + ", atree is: " + aTree);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            print("starting preorder");
            if (aTree != null)
                aTree.Preorder(1);       // root index is 1
            else
                lTree.Preorder(lTree.root);
        }                           
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (aTree != null)
                aTree.Inorder(1);
            else
                lTree.Inorder(lTree.root);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (aTree != null)
                aTree.Postorder(1);
            else
                lTree.Postorder(lTree.root);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (aTree != null)
                aTree.LevelOrder(1);
            else
                lTree.LevelOrder(lTree.root);
        }
    }

}
