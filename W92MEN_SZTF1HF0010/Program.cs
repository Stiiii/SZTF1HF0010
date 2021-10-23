using System;

namespace W92MEN_SZTF1HF0010
{
    class Program
    {
        static int[,] matrixfeltoltes(int[,] matrixMetodusban,int sorokszama, int oszlopokszama)
        {
            matrixMetodusban = new int[sorokszama, oszlopokszama];
            Random r = new Random();
            for (int i = 0; i < matrixMetodusban.GetLength(0); i++)
            {
                for (int j = 0; j < matrixMetodusban.GetLength(1); j++)
                {
                    matrixMetodusban[i, j] = r.Next(0, 10);
                    Console.Write(matrixMetodusban[i, j] + " ");
                }
                Console.WriteLine();
            }
            return matrixMetodusban;
        }

        static void SpiralKiiras(int[,] matrix, int sorokszama, int oszlopokszama)
        {
            string vegeredmeny = "";
            int j = 0;
            int i = matrix.GetLength(0);
            int felsohatar = 0;
            int balhatar = 0;
            int alsohatar = matrix.GetLength(0);
            int jobboldalihatar = matrix.GetLength(1);

            while (vegeredmeny.Length < (sorokszama*oszlopokszama))
            {
                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && i > felsohatar)
                {
                    i--;
                    vegeredmeny += matrix[i, j];
                }
                balhatar++;

                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && j < jobboldalihatar)
                {
                    j++;
                    vegeredmeny += matrix[i, j];
                }
                felsohatar++;

                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && i < alsohatar)
                {
                    i++;
                    vegeredmeny += matrix[i, j];
                }
                jobboldalihatar--;

                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && j > balhatar)
                {
                    j--;
                    vegeredmeny += matrix[i, j];
                }
                alsohatar--;
            }
            Console.WriteLine(vegeredmeny);
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Add meg a mátrix méreteit!");
            string bemenet = Console.ReadLine();
            string[] SorokEsOszlopokSzama =(bemenet.Split(" "));
            int sorokszama = int.Parse(SorokEsOszlopokSzama[0]);
            int oszlopokszama = int.Parse(SorokEsOszlopokSzama[1]);
            int[,] matrix = new int[sorokszama,oszlopokszama];


            matrixfeltoltes(matrix,sorokszama,oszlopokszama);
            SpiralKiiras(matrix, sorokszama, oszlopokszama);

            Console.ReadKey();
        }
    }
}
