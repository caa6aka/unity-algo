public class Generator {

    public static void Evolve(Cell[] cells)
    {
        int sz = cells.Length;

        // for all cells in the list:
        // extract left-middle-right triplet
        // pass it to ApplyRule()
        
      
    }

    /**********************************************************************************
        * Rules:
        Every cell interacts with its two neighbours, 
        Score of 0 and 2 make alive, whereas 1 or 3 is dead (lonely or over-populated)
        -------------------------------------------------------------------------------------
        At each step in time, the following transitions occur: 
        * 
        * 111 110 101 100 011 010 001 000 
        *  v   v   v   v   v   v   v   v
        *  0   1   1   0   1   0   0   1
        **********************************************************************************/
     static void ApplyRule(Cell left, Cell me, Cell right)
     {
        // set me to Alive or dead by counting neighboring cells, 
        // and deciding the result using the above rules
     }

}
