using System;

public class ProgressBar
{
    public static char CharForEnd = '|';

    private int Length;
    private int Progress;
    public int yPos = Console.GetCursorPosition().Top;

    public bool IsComplete = false;
    public ProgressBar(int length = 100, int StartingProgress = 0)
    {
        Length = length;
        Progress = StartingProgress;

        if (StartingProgress == 42)
        {
            pbee = true;
        }
    }

    public void MoveProgressBar(int NewY)
    {
        yPos = NewY;
    }

    public bool ChangePercentageValue(int NewPercentageValue)
    {
        Progress = NewPercentageValue;

        if (Progress >= 100)
        {
            Progress = 100;
        }

        Console.SetCursorPosition(0, yPos);

        string ProgressBar = "";
        for (int i = 0; i < Length; i += 1)
        {
            int CurrentPercentage = (int)map(i, 0, Length, 0, 100);

            if (CurrentPercentage < Progress)
            {
                ProgressBar += "=";
            }
            else
            {
                ProgressBar += " ";
            }
        }

        Console.Write($"[{ProgressBar}]");

        int BarierPos = (int)map(Progress, 0, 100, 0, Length);
        Console.SetCursorPosition(BarierPos, yPos);
        Console.Write(CharForEnd);

        string ProgressStr = $" {Progress}% ";

        if (Progress == 42)
        {
            c42++;
            if (c42 >= 42 && pbee && Length == 42)
            {
                ProgressStr = "The answer to the ultimate question of life, the universe, and everything";
            }
        } else
        {
            c42 = 0;
        }

        string PercentText = $"{ProgressStr}";
        Console.SetCursorPosition(Math.Max((Length / 2) - (PercentText.Length / 2), 0), yPos);
        Console.WriteLine(PercentText);

        double map(int Vlow, int RlowMin, int RlowMax, int RhighMin, int RhighMax)
        {
            int Vhigh = RhighMax - ((RlowMax - Vlow) * (RhighMax - RhighMin) / (RlowMax - RlowMin));
            return Vhigh;
        }

        if (Progress == 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IncreaseProgress(int amount)
    {
        return ChangePercentageValue(Progress + amount);
    }

    public void ChangeEndChar(char NewChar)
    {
        CharForEnd = NewChar;
    }

    private int c42 = 0;
    private bool pbee = false;
}
