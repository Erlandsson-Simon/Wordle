global using System;
global using System.Numerics;
global using System.Collections.Generic;
global using System.Linq;
global using R = Raylib_cs.Raylib;
global using Rs = Raylib_cs;

string gameName = "Wordle";
char currentKey;

int currentRow = 0;
int currentColum = 0;

R.InitWindow(1200, 800, gameName);
R.SetTargetFPS(60);

char[,] letters = new char[5, 6];

while (!R.WindowShouldClose())
{
    R.BeginDrawing();
    R.ClearBackground(Rs.Color.WHITE);

    R.DrawRectangle(275, 0, 650, 750, Rs.Color.GRAY);

    for (var i = 0; i < letters.GetLength(0); i++)
    {
        for (var u = 0; u < letters.GetLength(1); u++)
        {
            R.DrawRectangle(300 + (i * 125), 25 + (u * 120), 100, 100, Rs.Color.BLACK);
            R.DrawText(letters[i, u].ToString(), 315 + (i * 125), 25 + (u * 120), 100, Rs.Color.WHITE);
        }
    }

    R.EndDrawing();

    currentColum = ArraySlot.TestX(letters, currentRow);
    currentRow = ArraySlot.TestY(currentRow);

    currentKey = Press.KeyPressed();
    Console.WriteLine(currentKey);

    // if(currentKey = "ENTER") {

    // }

    
    if (currentKey != 0) {
        letters[currentRow, currentColum] = currentKey;
    } 
}

R.CloseWindow();    