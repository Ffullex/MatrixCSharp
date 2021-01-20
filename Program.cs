using System;

namespace Matrix
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы ");
            Console.WriteLine("Введите количество столбцов: ");
            int col1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк");
            int str1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Заполните матрицу");


            Matrix Mat1 = new Matrix(col1, str1);
            Mat1.PushInMat();
            Mat1.PushOutMat();
            Console.WriteLine();

            Console.WriteLine("Введите размерность матрицы ");
            Console.WriteLine("Введите количество столбцов: ");
            int col2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк");
            int str2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Заполните матрицу");

            Matrix Mat2 = new Matrix(col2, str2);
            Mat2.PushInMat();
            Mat2.PushOutMat();
            Console.WriteLine();

            if ((col1 == col2) && (str1 == str2)) {
                Console.WriteLine("Вы можете сложить либо вычесть  данные матрицы либо перемножить данные матрицы");
                Console.WriteLine("Если вы хотите их \n Сложить, нажмите 1. \n Вычесть, нажмите 2. \n Перемножить, нажмите 3");
                int press = Convert.ToInt32(Console.ReadLine());
                Matrix Mat3 = new Matrix(str1, col2);
                switch (press)
                {
                    case 1:
                        Mat3 = Mat1 + Mat2;
                        break;
                    case 2:
                        Mat3 = Mat1 - Mat2;
                        break;
                    case 3:
                        Mat3 = Mat1 * Mat2;
                        break;
                }
                Mat3.PushOutMat();
            }

            /*            else if (str1 == col2)
                        {
                            Console.WriteLine("Вы можете только перемножить данные матрицы. \n");
                            Matrix Mat4 = new Matrix(str1, col2);
                            Mat4 = Mat1 * Mat2;
                            Mat4.PushOutMat();
                        }*/
            else
            {
                Console.WriteLine("Матрицы разные, как... в общем, рекомендуется использовать одноразмерные матрицы. ");
            }

        }
    }
}
