using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// build our travel route from origin to destination
public class Router : MonoBehaviour
{
    public string method;

    // Start is called before the first frame update
    void Start()
    {
        Traveler t = GameObject.FindObjectOfType<Traveler>();
        City startingPoint = t.origin;
        print("-- origin " + startingPoint);

        City[] cities = GameObject.FindObjectsOfType<City>();

        //Graph g = new Graph(cities);
        // List<City> path = g.Traverse(method, t.origin);
        //foreach (City next in path)
        //     print("next destination: " + next);
        //t.SetRoute(path.ToArray());
    }
    
}
