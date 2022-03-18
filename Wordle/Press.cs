using System;
using R = Raylib_cs.Raylib;
class Press
{
    public static char KeyPressed()
    {
        int keyCode;

        keyCode = R.GetKeyPressed();
        char key = (char) keyCode;

        return key;
    }
}