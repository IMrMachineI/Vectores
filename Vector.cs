using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class Vector
    {
        private int tamaño { get; }
        int[] vector;
        public Vector(int tamaño)
        {
            this.tamaño = tamaño;
            vector = new int[tamaño];
        }
        public void llenarVector(int numInicial)
        {
            for (int i = 0; i < tamaño; i++)
            {
                vector[i] = numInicial;
                numInicial++;
            }
        }
        public void girarArriba()
        {
            int varTemporal;
            for(int i = tamaño;i>0;i--)
            {
                varTemporal = vector[i-1];
                vector[i - 1] = vector[tamaño - 1];
                vector[tamaño - 1] = varTemporal;
            }
        }
        public void girarAbajo()
        {
            int varTemporal;
            for (int i = 0; i < tamaño; i++)
            {
                varTemporal = vector[i];
                vector[i] = vector[tamaño - 1];
                vector[tamaño - 1] = varTemporal;
            }
        }
        public void invertir()
        {
            int varTemporal;
            int tamaño = vector.Length - 1;
            int i = 0;
            while ((vector.Length - i)>i)
            {
                varTemporal = vector[i];
                vector[i] = vector[tamaño - i];
                vector[tamaño - i] = varTemporal;
                i++;
            }
        }
        public override string ToString()
        {
            string regresar = "";
            for (int i = 0;i<tamaño;i++)//Controlar posiciones del vector
            {
                regresar = regresar + "["+i+"]="+vector[i]+"\r\n";
            }
            return regresar;
        }
    }
}
