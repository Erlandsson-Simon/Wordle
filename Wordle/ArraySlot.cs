class ArraySlot {
    public static (int, int) Test(char[,] letters) {
        for (var i = 0; i < letters.GetLength(0); i++)
        {
            for (var u = 0; u < letters.GetLength(1); u++)
            {
                if (letters[i,u] == '\0') {
                    return (i, u);
                }
            }
        }
        return (-1, -1);
    }
}