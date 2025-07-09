using System.Collections.Generic;
using System.Drawing;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tic_tac_toe_csharp
{
    internal class Program
    {
        // Фигуры в клетке поля
        const int empty = 0;
        const int cross = 1;
        const int nought = 2;

        // Состояния игрового процесса
        const int playing = 0;
        const int draw = 1; // ничья
        const int crossWin = 2; //победа Х
        const int noughtWin = 3; // победа 0
        const int quit = 3;

        static void Main(string[] args)
        {
            List<List<int>> board;
            int boardSize = 3; // размер игрового поля по-умолчанию  board = new int[boardSize][];
            int state = playing;
            int currentPlayer = cross; // текущий игрок

            while (true)
            {
                Write("Enter the size of the board (3-9): ");
                int? size = Convert.ToInt32(Console.ReadLine());
                size ??= boardSize;
                if (size < 3 || size > 9)
                {
                    WriteLine("Invalid size, please enter again");
                    continue;
                }
                boardSize = (int)size;
                board = Enumerable.Range(0, (int)size)
                      .Select(_ => Enumerable.Repeat(empty, boardSize).ToList())
                      .ToList();
                break;
            }

            // вывод в консоль состояния игрового поля
            Write("  ");
            for (int i = 0; i < boardSize; i++)
            {
                Write(i + 1); // Вывод номера столбца
            }

            Write("\n");

            for (int i = 0; i < boardSize; i++)
            {
                Write(i + 1); // Вывод номера строки
                for (int j = 0; j < boardSize; j++)
                {
                    switch (board[i][j])
                    {
                        case empty: Write(". ");
                            break;
                        case cross: Write("X ");
                            break;
                        case nought: Write("0 ");
                            break;

                    }
                }
                Write("");
            }
            // Завершение ввода терминала

            while (state == playing)
            {

            }
        }
    }
}
