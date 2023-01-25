using UnityEngine;
using UnityEngine.UI;

public class SimRunner : MonoBehaviour {

    public GameObject[ ] objects;
	public Text msgText;

	private int generation = 0;

    private bool running = false;
    private Cell [ ] cells;

    void Start()
    {
        cells = new Cell[objects.Length];

        for (int i = 0; i < objects.Length; i++)
            cells[i] = objects[i].GetComponent<Cell>();

        msgText.text = "Generation: 0";
    }

    // single step
    public void Next () {

		msgText.text = "Generation: " + ++generation;
        Generator.Evolve(cells);
	}

    // repeating steps
    public void Loop()
    {
        if (running)
            return;

        running = true;

        // Call Next in a repetitive way...

    }

}
