using UnityEngine;
using System.Collections;

public class Traveler : MonoBehaviour {

    public float speed = 1.0f;

    // set manually in editor for test
    //or by Graph in actual game
    public City origin;

    // set up manually in editor, or by router
    public City [] destinations;

    City next = null;
    int index = 0;

    public void SetRoute(City [] route)      // called by router
    {
        destinations = route;
        index = 0;
        next = destinations[0];
    }

    void Update() {

        if (Time.time < 0.5f)
            return;     // give other components to catch up & compute route

        // Vector2.Distance(a,b) is the same as (a-b).magnitude.
        // travel to the next destination, when close enough, move to the next one
      
    }

}
