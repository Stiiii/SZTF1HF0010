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
            int sorszam = 0;
            int oszlopszam = matrix.GetLength(0);
            int felsohatar = 0;
            int balhatar = 0;
            int alsohatar = matrix.GetLength(1);
            int jobboldalihatar = matrix.GetLength(1);

            while (vegeredmeny.Length < (sorokszama*oszlopokszama))
            {
                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && oszlopszam > felsohatar)
                {
                    oszlopszam--;
                    vegeredmeny += matrix[oszlopszam, sorszam];
                }
                balhatar++;

                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && sorszam < jobboldalihatar)
                {
                    sorszam++;
                    vegeredmeny += matrix[oszlopszam, sorszam];
                }
                felsohatar++;

                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && oszlopszam < alsohatar)
                {
                    oszlopszam++;
                    vegeredmeny += matrix[oszlopszam, sorszam];
                }
                jobboldalihatar--;

                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && sorszam > balhatar)
                {
                    sorszam--;
                    vegeredmeny += matrix[oszlopszam, sorszam];
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
