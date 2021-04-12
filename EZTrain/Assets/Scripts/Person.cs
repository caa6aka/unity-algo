using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// an person that gets onto a train platform (placed in a Node)
public class Person : MonoBehaviour
{
    [HideInInspector]
    public int Name;
    
    SpriteRenderer sr;
    Station station;

    [HideInInspector]
    public GameObject car;
    [HideInInspector]
    public Vector2 originalPos;
    [HideInInspector]
    public bool boarded;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();   
        originalPos = transform.position;
        station = FindObjectOfType<Station>();
        Name = int.Parse(name);
    }
   
    public override string ToString()
    {
        return "" + Name;
    }


    // just use left-click to prepend and right-click to append (EZList operations only)
    // the important point is to realize that we're adding primitives, not the Nodes -> these are created
    // by the train
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject.name == name)
            {
                if (!boarded)
                {
                    print("boarding in front " + Name);
                    station.BoardInFront(this);
                    boarded = true;
                }
                else
                {
                    print("removing " + Name);
                    station.Remove(this);
                    boarded = false ;
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject.name == name)
            {
                if (!boarded)
                {
                    print("boarding in back " + Name);
                    station.BoardInBack(this);
                    boarded = true;
                }
                else
                {
                    print("removing  " + Name);
                    station.Remove(this);
                    boarded = false;
                }
            }
        }
    }
}
