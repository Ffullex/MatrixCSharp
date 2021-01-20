using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Matrix
    {
        private int col;
        private int str;
        public int[,] matset;
        public int Column
        {
            get { return col; }                  // Считывание элемента
            set { if (value > 0) col = value; }  // Запись значения
        }
        public int String
        {
            get { return str; }                  // Считывание элемента
            set { if (value > 0) str = value; }  // Запись значения
        }
        // Конструктор матрицы
        public Matrix(int col, int str)
        {
            this.col = col;
            this.str = str;
            matset = new int[this.col, this.str];
        }
        // Индексатор
        public int this[int i, int j]
        {
            get
            {
               return matset[i, j];
            }
            set
            {
                matset[i, j] = value;
            }
        }

        public void PushInMat()
        {
            for (int j = 0; j < str; j++)
            {
                for (int i = 0; i < col; i++)
                {

                    matset[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void PushOutMat()
        {
            Console.WriteLine("Rоличество столбцов: " + col);
            Console.WriteLine("Rоличество строк" + str);
            Console.WriteLine("Заполните вашу матрицу");
            for (int j = 0; j < str; j++)
            {
                for (int i = 0; i < col; i++)
                {

                    Console.Write(matset[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static Matrix summer(Matrix a, Matrix b)
        {
            Matrix resultSum = new Matrix(a.col, a.str);
            for (int i = 0; i < a.str; i++)
            {
                for (int j = 0; j < a.col; j++)
                {
                    resultSum[i, j] = a[i, j] + b[i, j];
                }
            }
            return resultSum;
        }
        // Перегрузка сложения
        public static Matrix operator +(Matrix a, Matrix b)
        {
            return Matrix.summer(a, b);
        }

        public static Matrix substractor(Matrix a, Matrix b)
        {
            Matrix resultSub = new Matrix(a.str, b.col);
            for (int i = 0; i < a.str; i++)
            {
                for (int j = 0; j < b.col; j++)
                {
                    resultSub[i, j] = a[i, j] - b[i, j];
                }
            }
            return resultSub;
        }
        // Перегрузка оператора вычитания
        public static Matrix operator -(Matrix a, Matrix b)
        {
            return Matrix.substractor(a, b);
        }
        public static Matrix multiplicator1(Matrix a, Matrix b)
        {
            Matrix resultMul = new Matrix(a.str, b.col);
            for(int i = 0; i < a.str; i++)
            {
                for (int j = 0; j < b.col; j++)
                {
                    resultMul[i, j] = 0;
                    for (int k = 0; k < a.col; k++)
                    {
                        resultMul[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return resultMul;
        }

        // перегрузка оператора умножения
        public static Matrix operator *(Matrix a, Matrix b)
        {
            return Matrix.multiplicator1(a, b);
        }

        // Деструктор 
        ~Matrix()
        {
            Console.WriteLine("Очистка");
        }
    }
}
