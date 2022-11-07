using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTraceTeste.controller
{
    public class Utilidade
    {
        public static double[,] Matriz_View(float[] vetor, bool transpose = false)
        {
            double[,] mat = new double[vetor.Length, 2];
            int i;

            if (transpose == false) {
                for ( i = 0; i < vetor.Length; i++)
                {
                    mat[i, 0] = i;
                    mat[i, 1] = vetor[i];
                }
            } else {
                for (i = 0; i < vetor.Length; i++)
                {
                    mat[i, 1] = i;
                    mat[i, 0] = vetor[i];
                }
            }

            return mat;
        }
    }
}
