using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T01_ArraysAndHashing.P08_ValidSudoku_LC36
{
    public class ValidSudokuMySolution
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (int row = 0; row < 9; row++)
            {
                HashSet<char> seen = new HashSet<char>();
                for (int i = 0; i < 9; i++)
                {
                    if (board[row][i] == '.') continue;
                    if (seen.Contains(board[row][i])) return false;
                    seen.Add(board[row][i]);
                }
            }

            for (int col = 0; col < 9; col++)
            {
                HashSet<char> seen = new HashSet<char>();
                for (int i = 0; i < 9; i++)
                {
                    if (board[i][col] == '.') continue;
                    if (seen.Contains(board[i][col])) return false;
                    seen.Add(board[i][col]);
                }
            }

            for (int rowStart = 0; rowStart < 9; rowStart += 3)
            {
                for (int colStart = 0; colStart < 9; colStart += 3)
                {
                    HashSet<char> seen = new HashSet<char>();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            char cell = board[rowStart + i][colStart + j];
                            if (cell == '.') continue;
                            if (seen.Contains(cell)) return false;
                            seen.Add(cell);
                        }
                    }
                }
            }

            return true;
        }
    }
}
