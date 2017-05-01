using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLibrary;

namespace TictacToeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeEngine engine = new TicTacToeEngine();
            String[] board = engine.board;
            bool active = true;
            bool isValid = true;
            Console.WriteLine("Type 1-9 + enter to pick a field. You can reset the game with 'reset' and you can quit the application with 'quit'");

            while (active)
            {
                if (isValid)
                {
                    writeBoard(board);
                    Console.WriteLine(engine.getGameStatus());
                }
                isValid = true;
                

                String input = Console.ReadLine();

                if (String.Equals(input, "1", StringComparison.OrdinalIgnoreCase)) { processTurn(engine, 1); }
                else if (String.Equals(input, "2", StringComparison.OrdinalIgnoreCase)) { processTurn(engine, 2); }
                else if (String.Equals(input, "3", StringComparison.OrdinalIgnoreCase)) { processTurn(engine, 3); }
                else if (String.Equals(input, "4", StringComparison.OrdinalIgnoreCase)) { processTurn(engine, 4); }
                else if (String.Equals(input, "5", StringComparison.OrdinalIgnoreCase)) { processTurn(engine, 5); }
                else if (String.Equals(input, "6", StringComparison.OrdinalIgnoreCase)) { processTurn(engine, 6); }
                else if (String.Equals(input, "7", StringComparison.OrdinalIgnoreCase)) { processTurn(engine, 7); }
                else if (String.Equals(input, "8", StringComparison.OrdinalIgnoreCase)) { processTurn(engine, 8); }
                else if (String.Equals(input, "9", StringComparison.OrdinalIgnoreCase)) { processTurn(engine, 9); }
                else if (String.Equals(input, "reset", StringComparison.OrdinalIgnoreCase))
                {
                    engine.reset();
                    Console.WriteLine("Game has been reset");
                }
                else if (String.Equals(input, "quit", StringComparison.OrdinalIgnoreCase))
                {
                    active = false;
                }
                else
                {
                    Console.WriteLine("\"" +input + "\" is not a valid command. Please type a number ranging from 1 to 9, 'reset' or 'quit'");
                    isValid = false;
                }

            }
        }

        private static void processTurn(TicTacToeEngine engine, int pos)
        {
            if (engine.board[pos - 1].Equals(pos.ToString()))
            {                
                engine.setPos(pos);                
                String status = engine.getGameStatus();
                if (status.Equals("X wins!") || (status.Equals("O wins!")) || (status.Equals("Draw")))
                {
                    writeBoard(engine.board);
                    Console.WriteLine(status, status, status);
                    engine.reset();
                }
            }
            else
            {
                Console.WriteLine("This field has already been taken");
            }
        }

        private static void writeBoard(string[] board)
        {
            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| " + board[0] + " | " + board[1] + " | " + board[2] + " |");
            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| " + board[3] + " | " + board[4] + " | " + board[5] + " |");
            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| " + board[6] + " | " + board[7] + " | " + board[8] + " |");
            Console.WriteLine("|---|---|---|");
        }
    }
}
