using System;

namespace MatrixPrinter
{
    public class MatrixActions
    {
        private const int MaxDirections = 8;

        public static void ChangeDirection(ref int directionRow, ref int directionCol)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;
            for (int directions = 0; directions < MaxDirections; directions++)
            {
                if (dirX[directions] == directionRow && dirY[directions] == directionCol)
                {
                    currentDirection = directions;
                    break;
                }
            }

            directionRow = dirX[(currentDirection + 1) % MaxDirections];
            directionCol = dirY[(currentDirection + 1) % MaxDirections];
        }

        public static bool CheckForPossibleMoves(int[,] matrix, int currentRow, int currentCol)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int directions = 0; directions < MaxDirections; directions++)
            {
                if (currentRow + dirX[directions] >= matrix.GetLength(0) || currentRow + dirX[directions] < 0)
                {
                    dirX[directions] = 0;
                }

                if (currentCol + dirY[directions] >= matrix.GetLength(0) || currentCol + dirY[directions] < 0)
                {
                    dirY[directions] = 0;
                }
            }

            for (int directions = 0; directions < MaxDirections; directions++)
            {
                if (matrix[currentRow + dirX[directions], currentCol + dirY[directions]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void FindPossibleCellToMove(int[,] matrix, out int foundRow, out int foundCol)
        {
            foundRow = 0;
            foundCol = 0;

            int matrixLength = matrix.GetLength(0);
            for (int row = 0; row < matrixLength; row++)
            {
                for (int col = 0; col < matrixLength; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        foundRow = row;
                        foundCol = col;
                        return;
                    }
                }
            }
        }

        public static bool CheckIfNextCellIsOutsideOfMatrix(int[,] matrix, int currentRow, int currentCol, int directionRow, int directionCol)
        {
            if (currentRow + directionRow >= matrix.GetLength(0) || currentRow + directionRow < 0 ||
                currentCol + directionCol >= matrix.GetLength(0) || currentCol + directionCol < 0)
            {
                return true;
            }

            return false;
        }
    }
}
