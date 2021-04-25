using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// a self-replicating section of a Snake;
public class Segment : MonoBehaviour
{
    static Vector3 Right = new Vector3(1f, 0f, 0f);

    public void Grow()
    {
        // copy itself
        GameObject go = GameObject.Instantiate(gameObject);
        go.transform.position = transform.position + Right;

        // our link in a snake "chain"
        Segment link = go.GetComponent<Segment>();
    }
}
