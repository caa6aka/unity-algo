public class Generator {

    public static void Evolve(Cell[,] cells)
    {
        int rows = cells.GetLength(0);
        int cols = cells.GetLength(1);

        // we leave out borders, to avoid out of bounds exceptions
        // if our borderline cells are permanently dead, so be it
        for (int x = 1; x < rows - 1; x++)
            for (int y = 1; y < cols - 1; y++)
                ApplyRule3x3(cells, x, y);
          
    }

    /**********************************************************************************
     * Rules:
     Every cell interacts with its 8 neighbours
     Any live cell with two or three neighbors survives   
     Any dead cell with trhee neigbors awakens
     **********************************************************************************/
    static void ApplyRule3x3(Cell[,] population, int x, int y)
    {
        int count = 0;
        Cell myself = population[x, y];

        // count all neighboring cells, (skipping myself),
        // and depending on the result
        // set current cell to alive or noy
       
    }

}
