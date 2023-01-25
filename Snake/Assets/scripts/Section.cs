using UnityEngine;

// a unit part of a snake
public class Section : MonoBehaviour {

    [Range(0.5f, 3f)]
    public float speed = 1f;

    Section prev;        // previous element of a snake, null if head  
    bool dead = false;
    
    static Vector3 Left = new Vector3(-1f, 0f, 0f);
    static Vector3 Right = Left * -1f;
    static Vector3 Up = new Vector3(0f, 1f, 0f);
    static Vector3 Down = Up * -1f;

    static Vector3 dir = Vector3.zero; // still until given direction

    void Start()
    {
        InvokeRepeating("Move", 1f, 1f / speed); 
    }

    public void Move()
    {
        // move in the current direction
    }

    public void Grow()
    {
        // grow a new head, and attach it to a body
    }

	void OnTriggerEnter2D(Collider2D coll) {

        // if got an apple, eat it and Grow
        // if bit a border or itself, die..
	}

    void Update()
    {
        // check key input, and adjust direction of movement
    }    

}

