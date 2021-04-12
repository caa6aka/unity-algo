using System;
using UnityEngine;      // for printing

class Train
{
    protected Platform head, tail;


    // important: don't add the node, add the plain object!
    public void Append(Person passenger)
    {        
        // create a node with payload on it: place passenger on a platform
        Platform p = new Platform(passenger);  

        // initialize head and tail, if needed...
        // add the platform to the end of the train
        // ..

        Repaint();          // apply changes on-screen
    }

    public void Prepend(Person passenger)
    {
        // similar to Append, but place platform in front of the train

        Repaint();
    }

    public void Remove(Person i)
    {
        // remove platform with a requested passenger from the train
        // find passenger by name: i.Name      
        Repaint();      // apply our structural changes on-screen
    }

   
    /////////////////////////////////////////////////////////////////////////
    //////////////////// Convenience functions //////////////////////////////
    /////////////////////////////////////////////////////////////////////////
    public void Repaint()    // called by client code, after operating on list (same idea as printing it out)
    {
        if (head == null)
            return;

        Platform current = head;
        int i = 0;

        while (current != null)
        {
            current.passenger.gameObject.transform.position = new Vector2(i * 2.25f -3.5f, -1.75f);   // our track position
            current = current.next;
             i++;
        }

        string text = ToString();
        Debug.Log("List: " + text);    // for easy tracking
    }

    public override String ToString()
    {
        if (head == null)
            return "List Empty";

        string s = "";

        Platform p = head;
        while (p != null)
        {
            s = s + p + " ";
            p = p.next;
        }
        return s;
    }
}
