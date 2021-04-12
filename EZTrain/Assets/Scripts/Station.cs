using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
{
    public GameObject template;
    private Vector3 offset = new Vector3(0f, 0.8f, 0f);

    static Train choChoo;

    void Start()
    {
        choChoo = new Train();
    }

    public void BoardInBack(Person p)
    {
        GameObject car = Instantiate(template);
        p.car = car;       // so we can delete it when person unboards
        car.transform.parent = p.transform;     // hookup to a platform image
        car.transform.position = p.transform.position - offset;
        choChoo.Append(p);
    }

    public void BoardInFront(Person p)
    {
        GameObject car = Instantiate(template);
        p.car = car;       // so we can delete it when person unboards
        car.transform.parent = p.transform;     // hookup to a platform image
        car.transform.position = p.transform.position - offset;
        choChoo.Prepend(p);
    }

    public void Remove(Person p)
    {
        choChoo.Remove(p);
        Destroy(p.car);
        p.transform.position = p.originalPos;       // send him back
    }
}
