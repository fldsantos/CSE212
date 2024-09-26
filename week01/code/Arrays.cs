using System.Diagnostics;

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
        // I will create a 'for' loop that does the value of 'length' iterations.
        // Each iteration will push a number to the list, with the value 'number' * 'i'
        // Finally, return the List's value

        double[] multiples = new double[length];

        for (int i = 1; i <= length; i++) {
            multiples[i-1] = number * i;
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
        // I will slice the targeted range off the original list, and add it to the start of the list

        List<int> slicedList = data.GetRange(data.Count-amount, amount);
        data.RemoveRange(data.Count-amount, amount);
        slicedList.AddRange(data);

        data.Clear();
        data.AddRange(slicedList);

        Debug.WriteLine(String.Join(", ", data));
    }

}
