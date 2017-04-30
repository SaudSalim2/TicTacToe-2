using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary
{
    public class TicTacToeEngine
    {
        public enum GameStatus { OPlays, XPlays, Draw, OWins, XWins }
        public int turn { get; set; } = 0;
        public String[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public String setPos()
        {
            if (turn % 2 == 1)
            {
                turn += 1;
                return "O";
            }
            else
            {
                turn += 1;
                return "X";
            }
        }

        public String setPos(int pos)
        {
            if (turn % 2 == 1)
            {
                turn += 1;
                board[pos - 1] = "O";
                return "O";
            }
            else
            {
                turn += 1;
                board[pos - 1] = "X";
                return "X";
            }
        }

        public String getGameStatus()
        {
            String status;
            status = determineWinner(board[0], board[1], board[2], board[3], board[4], board[5], board[6], board[7], board[8]);
            if (status != null) { return status; }
            if (turn % 2 == 1)
            {
                status = GameStatus.OPlays.ToString();
            }
            else
            {
                status = GameStatus.XPlays.ToString();
            }
            return status;
        }

        public String determineWinner(string pos1, string pos2, string pos3, string pos4, string pos5, string pos6, string pos7, string pos8, string pos9)
        {
            if (checkWin(pos1, pos2, pos3)) { return pos1 + " wins!"; }
            else if (checkWin(pos4, pos5, pos6)) { return pos4 + " wins!"; }
            else if (checkWin(pos7, pos8, pos9)) { return pos7 + " wins!"; }
            else if (checkWin(pos1, pos5, pos9)) { return pos1 + " wins!"; }
            else if (checkWin(pos3, pos5, pos7)) { return pos3 + " wins!"; }
            else if (checkWin(pos1, pos4, pos7)) { return pos1 + " wins!"; }
            else if (checkWin(pos2, pos5, pos8)) { return pos2 + " wins!"; }
            else if (checkWin(pos3, pos6, pos9)) { return pos3 + " wins!"; }
            else if (turn == 9) { return GameStatus.Draw.ToString(); };
            return null;
        }

        private Boolean checkWin(String a, String b, String c)
        {
            if (a == b && a == c && a != "")
            {
                return true;
            }
            return false;
        }

        public void reset()
        {
            turn = 0;
            board[0] = "1";
            board[1] = "2";
            board[2] = "3";
            board[3] = "4";
            board[4] = "5";
            board[5] = "6";
            board[6] = "7";
            board[7] = "8";
            board[8] = "9";
        }
    }
}
