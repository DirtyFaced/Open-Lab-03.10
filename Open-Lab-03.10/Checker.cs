using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int dlzka = str.Length;
            int pocet = 0;
            for (int i = 0; i < dlzka; i++)
            {if (str[i] == letter)
                { pocet = pocet + 1; } };
            return pocet;
        }
    }
}
