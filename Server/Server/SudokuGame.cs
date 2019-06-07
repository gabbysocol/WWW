using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    class SudokuGame
    {
        public int[,] Numbers { get; private set; }
        //private int Counter;

        public SudokuGame()
        {
            Generate();
            Update();
        }

        private void Generate()
        {
            Numbers = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Numbers[i, j] = (i * 3 + i / 3 + j) % 9 + 1;
                }
            }
        }

        private void transp()//метод, который транспонирует матрицу.
        {
            int tmp;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    tmp = Numbers[i, j];
                    Numbers[i, j] = Numbers[j, i];
                    Numbers[j, i] = tmp;
                }
            }
        }

        private void swapRowsArea()
        {
            Random rnd = new Random();
            int getArea = rnd.Next(1, 2);
            int getArea2 = 3;

            int tmp;
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    tmp = Numbers[3 * getArea - 1 - i, j];
                    Numbers[3 * getArea - 1 - i, j] = Numbers[3 * getArea2 - 1 - i, j];
                    Numbers[3 * getArea2 - 1 - i, j] = tmp;
                }
            }

        }
        private void swapRowsSmall()
        {
            Random rnd = new Random();
            int getRowOfMatrix = rnd.Next(1, 3);
            int line1 = 1;
            int line2 = 2;

            int tmp;
            for (int j = 0; j < 9; j++)
            {

                tmp = Numbers[3 * getRowOfMatrix - line1, j];
                Numbers[3 * getRowOfMatrix - line1, j] = Numbers[3 * getRowOfMatrix - line2, j];
                Numbers[3 * getRowOfMatrix - line2, j] = tmp;

            }
        }

        private void swapColumnSmall()
        {
            transp();
            swapRowsSmall();
            transp();
        }

        private void swapColumnArea()
        {
            transp();
            swapRowsArea();
            transp();
        }

        private void Update()
        {
            Random rnd = new Random();
            int numb = rnd.Next(1, 6);
            switch (numb)
            {
                case 1:
                    swapRowsArea();
                    transp();
                    swapColumnSmall();
                    break;
                case 2:
                    swapRowsSmall();
                    swapColumnArea();
                    transp();
                    swapColumnSmall();
                    break;
                case 3:
                    transp();
                    swapColumnSmall();
                    swapRowsSmall();
                    transp();
                    swapColumnArea();
                    break;
                case 4:
                    swapRowsArea();
                    swapRowsSmall();
                    transp();
                    swapColumnSmall();
                    break;
                case 5:
                    swapRowsSmall();
                    transp();
                    swapColumnSmall();
                    swapColumnArea();
                    transp();
                    break;
                default:
                    swapColumnSmall();
                    swapRowsSmall();
                    transp();
                    swapColumnArea();
                    break;
            }
        }

        public override string ToString()
        {
            var SB = new StringBuilder();
            for (int i = 0; i < Numbers.GetLength(0); i++)
            {
                for (int i2 = 0; i2 < Numbers.GetLength(1); i2++)
                {
                    SB.Append(Numbers[i, i2]);
                }
            }
            return base.ToString();
        }

    }
}
