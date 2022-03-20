class ArraySlot
{
    public static int TestX(char[,] letters, int currentRow)
    {

        int temp;

        for (var i = 0; i < letters.GetLength(0); i++)
        {
            temp = letters[currentRow, i].CompareTo('\0');

            if (temp == 0)
            {
                return (i);
            }

        }
        return (-1);
    }
    
    public static int TestY(int currentRow) {
        if(R.IsKeyDown(Rs.KeyboardKey.KEY_ENTER)) {
            currentRow += 1;
        }
        return currentRow;
    }
}