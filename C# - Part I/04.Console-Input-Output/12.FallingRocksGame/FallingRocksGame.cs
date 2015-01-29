// Problem 12.** Falling Rocks
// 
// Implement the "Falling Rocks" game in the text console.
// A small dwarf stays at the bottom of the screen and can move left / and /right (by the arrows keys).
// A number of rocks of different sizes and forms constantly fall  down //and you need to avoid a crash.
// Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - / distributed /with appropriate density. The dwarf is (O).
// Ensure a constant game speed by Thread.Sleep(150).
// Implement collision detection and scoring system.

using System;
using System.Linq;
using System.Media;
using System.Threading;

class FallingRocks
{
    static int position;
    static char[,] gameField;
    static char[] rockTypes = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
    static Random randomGenerator = new Random();
    static SoundPlayer backgroundMusic;
    static bool endOfGame;
    static int score;

    static void InitializeGameField()
    {
        Console.SetWindowSize(50, 50); // Set window size
        Console.BufferWidth = Console.WindowWidth; // Prevent scrolling
        Console.BufferHeight = Console.WindowHeight; // Prevent scrolling

        score = -Console.WindowHeight + 1;
        Console.ForegroundColor = ConsoleColor.Magenta;
        backgroundMusic = new SoundPlayer(@"..\..\purple-hills-short.wav");
        backgroundMusic.PlayLooping();

        gameField = new char[Console.WindowHeight, Console.WindowWidth];
        for (int i = 0; i < gameField.GetLength(0); i++)
        {
            for (int j = 0; j < gameField.GetLength(1); j++)
            {
                gameField[i, j] = ' ';
            }
        }
        position = Console.WindowWidth / 2;
        gameField[gameField.GetLength(0) - 1, position - 1] = '(';
        gameField[gameField.GetLength(0) - 1, position] = 'O';
        gameField[gameField.GetLength(0) - 1, position + 1] = ')';

    }

    static void MoveDwarfLeft()
    {
        if (position > 1)
        {
            position--;
            gameField[gameField.GetLength(0) - 1, position + 2] = ' ';
            gameField[gameField.GetLength(0) - 1, position - 1] = '(';
            gameField[gameField.GetLength(0) - 1, position] = 'O';
            gameField[gameField.GetLength(0) - 1, position + 1] = ')';

        }
    }

    static void MoveDwarfRight()
    {
        if (position < gameField.GetLength(1) - 3)
        {
            position++;
            gameField[gameField.GetLength(0) - 1, position - 2] = ' ';
            gameField[gameField.GetLength(0) - 1, position - 1] = '(';
            gameField[gameField.GetLength(0) - 1, position] = 'O';
            gameField[gameField.GetLength(0) - 1, position + 1] = ')';
        }
    }

    static void MoveDwarf()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            MoveDwarfLeft();
        }

        if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            MoveDwarfRight();
        }
    }

    static void DrawField()
    {
        Console.Clear();
        for (int i = 0; i < gameField.GetLength(0); i++)
        {
            byte color = (byte)randomGenerator.Next(6);
            for (int j = 0; j < gameField.GetLength(1) - 1; j++)
            {
                Console.Write(gameField[i, j]);
            }
            if (i == gameField.GetLength(0) - 1)
            {
                continue;
            }
            Console.WriteLine();
        }
    }

    static char[] GenerateRocks()
    {
        byte numberOfRocksPerLine = (byte)randomGenerator.Next(1, 4);
        char[] rocks = new char[Console.WindowWidth - 1];
        for (int i = 0; i < rocks.GetLength(0); i++)
        {
            rocks[i] = ' ';
        }

        for (int i = 0; i < numberOfRocksPerLine; i++)
        {
            byte arrIndex = (byte)randomGenerator.Next(0, Console.WindowWidth - 1);
            byte typeIndex = (byte)randomGenerator.Next(0, rockTypes.Length - 1);
            rocks[arrIndex] = rockTypes[typeIndex];
        }

        return rocks;
    }

    static void GameCycle()
    {
        while (!endOfGame)
        {
            if (
                (gameField[Console.WindowHeight - 2, position] != ' ') ||
                (gameField[Console.WindowHeight - 2, position - 1] != ' ') ||
                (gameField[Console.WindowHeight - 2, position + 1] != ' ')
                )
            {
                endOfGame = true;
            }

            else
            {
                score++;
            }

            for (int i = Console.WindowHeight - 2; i > 0; i--)
            {
                for (int j = 0; j < Console.WindowWidth - 1; j++)
                {
                    gameField[i, j] = gameField[i - 1, j];
                }

            }
            char[] rocks = GenerateRocks();
            for (int i = 0; i < gameField.GetLength(1) - 1; i++)
            {
                gameField[0, i] = rocks[i];
            }
            DrawField();
            Thread.Sleep(150);
        }
    }

    static void EndGame()
    {
        Console.Clear();
        Console.WriteLine("Game Over! Your score is {0} ", score);
        Console.WriteLine("Press Esc to exit!");

        ConsoleKeyInfo escKey;

        do
        {
            escKey = Console.ReadKey();
        } 
        while (escKey.Key != ConsoleKey.Escape);

        Environment.Exit(0);

    }

    static void Main(string[] args)
    {
        InitializeGameField();
        Console.WriteLine("Press any key to start.");
        Console.WriteLine("Press Esc to quit.");

        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
        Thread inputThread = new Thread(delegate()
        {
            while (true)
            {
                MoveDwarf();
            }
        });

        inputThread.IsBackground = true;
        inputThread.Start();
        GameCycle();
        EndGame();
    }
}