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
        if (dead)
            return;     // game over

        if (prev != null)
            transform.position = prev.transform.position;
        else // head            
            transform.position += dir;
    }

    public void Grow()
    {
        GameObject head = GameObject.Instantiate(gameObject);
        head.transform.position = transform.position + dir;
        Section headS = head.GetComponent<Section>();
        prev = headS;
    }

	void OnTriggerEnter2D(Collider2D coll) {

        if (prev != null)       // not my concern
            return;

        // only head collisions have consequences
		if (coll.tag == "Food" )
		{
			Destroy(coll.gameObject);       // eat him
            Grow();
		}

        if (coll.tag == "Border")
            dead = true;

        //print("collided with " + coll.gameObject);
        //if (coll.tag.StartsWith("Snake"))    // bit itself
            //dead = true;
	}

    void Update()
    {
        if (prev != null)
            return;     // not my concern

        if (Input.GetKey(KeyCode.UpArrow) && dir != Down)   // don't reverse on itself
            dir = Up;

        if (Input.GetKey(KeyCode.DownArrow) && dir != Up)
            dir = Down;

        if (Input.GetKey(KeyCode.RightArrow) && dir != Left)
            dir = Right;

        if (Input.GetKey(KeyCode.LeftArrow) && dir != Right)
            dir = Left;
    }    

}

