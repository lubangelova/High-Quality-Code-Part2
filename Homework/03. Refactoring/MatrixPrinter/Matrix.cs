using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixPrinter
{
    public class Matrix
    {
        private int row;
        private int col;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.Body = new int[row, col];
        }

        public int Row
        {
            get
            {
                return this.row;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Row must be between 0 and 100!");
                }

                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Col must be between 0 and 100!");
                }

                this.col = value;
            }
        }

        public int[,] Body { get; private set; }

        public void FillMatrix()
        {
            int currentRow = 0;
            int currentCol = 0;
            int initialValue = 1;
            int directionRow = 1;
            int directionCol = 1;
            while (true)
            {
                this.Body[currentRow, currentCol] = initialValue;
                if (!MatrixActions.CheckForPossibleMoves(this.Body, currentRow, currentCol))
                {
                    MatrixActions.FindPossibleCellToMove(this.Body, out currentRow, out currentCol);
                    if (currentRow != 0 && currentCol != 0)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                while (MatrixActions.CheckIfNextCellIsOutsideOfMatrix(this.Body, currentRow, currentCol, directionRow, directionCol) ||
                    this.Body[currentRow + directionRow, currentCol + directionCol] != 0)
                {
                    MatrixActions.ChangeDirection(ref directionRow, ref directionCol);
                }

                currentRow += directionRow;
                currentCol += directionCol;
                initialValue++;
            }
        }

        public void PrintMatrix()
        {
            int matrixLength = this.Body.GetLength(0);
            for (int row = 0; row < matrixLength; row++)
            {
                for (int col = 0; col < matrixLength; col++)
                {
                    Console.Write("{0,3}", this.Body[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
