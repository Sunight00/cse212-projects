public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // I created an array of doubles with the size of length input
        // Used the length input to create a loop, inside the loop I set the value of each index to be the multiple of the number input and the index + 1
        // 3. Return the array of multiples
        double [] multiples = new double[length];
        for (int i=0; i< length ; i++){
            multiples[i] = (i+1) * number;
        }
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // First I get the size of the list so I know how many elements I'm working with
        int n = data.Count;

        // If the amount is bigger than the list size, I use modulo so it wraps around correctly
        amount = amount % n;

        // I figure out where the list should be split
        // Since I'm rotating right, the last "amount" numbers should move to the front
        int splitIndex = n - amount;

        // I take the last "amount" numbers (these will go to the front)
        var lastPart = data.GetRange(splitIndex, amount);

        // Then I take the first part of the list (everything before the split)
        var firstPart = data.GetRange(0, splitIndex);

        // I clear the original list so I can rebuild it in the new order
        data.Clear();

        // I add the last part first because those numbers move to the front
        data.AddRange(lastPart);

        // Then I add the rest of the numbers after them
        data.AddRange(firstPart);

    }
}
