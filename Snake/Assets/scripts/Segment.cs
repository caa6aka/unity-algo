using UnityEngine;

// a self-replicating section of a Snake;
public class Segment : MonoBehaviour
{
    // Snake grows when food is consumed
    public void Grow()
    {
        // copy itself
        GameObject go = GameObject.Instantiate(gameObject);
        go.transform.position = transform.position + Vector3.right;

        // hook up new segment to a snake "chain"
        Segment link = go.GetComponent<Segment>();
        // ..
    }
}
