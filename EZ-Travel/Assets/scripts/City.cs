using UnityEngine;
using System;
using System.Collections.Generic;

public class City : MonoBehaviour {

    public GameObject[] destinations;    // uni-directional, unweighted

    [HideInInspector]
    public List<City> connections = new List<City>();

    // do this first, so that Graph has a list of City neighbors @Start
    void Awake()
    {
        // copy destinations into connections List

    }

    // support for generics - add GetHashCode and Equals, as appropritate

}
