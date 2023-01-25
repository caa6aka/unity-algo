using UnityEngine;

// snakes love apples..
public class Apple : MonoBehaviour {
    
    public GameObject img;

    // Borders
    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;

    [Range(1, 3)]
    public float interval;

    private int minX, maxX;
    private int minY, maxY;
    
    void Start () {

        minX = (int) borderLeft.position.x +1;      // avoid placing ferrets inside borders
        maxX = (int) borderRight.position.x -1;

        minY = (int) borderBottom.position.y +1;
        maxY = (int) borderTop.position.y -1;

        // Pop up ferrets every n seconds
        InvokeRepeating("PopUp", interval, interval);
    }

    // Pop up a ferret
    void PopUp() {
        
        int x = Random.Range(minX, maxX);       // x position between left & right border
        int y = Random.Range(minY, maxY);

        // Instantiate the food at (x, y)
        Instantiate(img, new Vector2(x, y), Quaternion.identity); // default rotation
    }

}