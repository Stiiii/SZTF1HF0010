﻿using System;

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
            bool leptunke = false;
            string vegeredmeny = "";
            int i = matrix.GetLength(0) - 1;
            int j = 0;
            int felsohatar = 0;
            int balhatar = 0;
            int alsohatar = matrix.GetLength(0)-1;
            int jobboldalihatar = matrix.GetLength(1)-1;

            while (vegeredmeny.Length < (sorokszama*oszlopokszama))
            {
                bool beszorulte = false;

                //fel
                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && i > felsohatar)
                {
                    vegeredmeny += matrix[i, j];
                    i--;
                    leptunke = true;
                    beszorulte = true;
                }
                if (leptunke)
                {
                    balhatar++;
                }
                leptunke = false;

                //jobb
                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && j < jobboldalihatar)
                {
                    vegeredmeny += matrix[i, j];
                    j++;
                    leptunke = true;
                    beszorulte = true;
                }
                if (leptunke)
                {
                    felsohatar++;
                }
                leptunke = false;

                //le
                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && i < alsohatar)
                {
                    vegeredmeny += matrix[i, j];
                    i++;
                    leptunke = true;
                    beszorulte = true;
                }
                if (leptunke)
                {
                    jobboldalihatar--;
                }
                leptunke = false;

                //bal
                while (vegeredmeny.Length < (sorokszama * oszlopokszama) && j > balhatar)
                {
                    vegeredmeny += matrix[i, j];
                    j--;
                    leptunke = true;
                    beszorulte = true;
                }
                if (leptunke)
                {
                    alsohatar--;
                }
                leptunke = false;
                if (!beszorulte)
                {
                    vegeredmeny += matrix[i, j];
                }
                Console.WriteLine(i+" "+j+ " "+ vegeredmeny+"   Felsohatar: " +felsohatar+"  JobboldaliHatar: "+jobboldalihatar+"  alsohatar: "+alsohatar+"  baloldalihatar: "+balhatar );
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

            matrix = matrixfeltoltes(matrix, sorokszama, oszlopokszama);
            SpiralKiiras(matrix, sorokszama, oszlopokszama);

            Console.ReadKey();
        }
    }
}
