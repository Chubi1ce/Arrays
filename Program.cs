using System.Security.AccessControl;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] a = { { 7, 3, 2}, { 4, 9, 6}, { 1, 8, 5} };
        int[] temp = new int[a.Length];
        int tempIndex = 0;

        int rowsCount = a.GetUpperBound(0)+1;
        int colsCount = a.Length / rowsCount;

        for (int i = 0; i < rowsCount; i++){
            for (int j = 0; j < colsCount; j++){
                temp[tempIndex] = a[i,j];
                tempIndex++;}}

        PrintArray(a);

        Array.Sort(temp);

        tempIndex = 0;
        for (int i = 0; i < rowsCount; i++){
            for (int j = 0; j < colsCount; j++){
                a[i, j] = temp[tempIndex];
                tempIndex++;}}

        PrintArray(a);

        void PrintArray(int[,] arr)
        {
            int rowsCount = a.GetUpperBound(0) + 1;
            int colsCount = a.Length / rowsCount;

            for (int i = 0; i < rowsCount; i++){
                for (int j = 0; j < colsCount; j++){
                    Console.Write(arr[i,j] + "  ");}
                Console.WriteLine();}
            Console.WriteLine();
        }
    }
}