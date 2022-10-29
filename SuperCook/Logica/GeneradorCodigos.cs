using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GeneradorCodigos
    {
        private static int CodigoIngrediente;
        private static int CodigoReceta;
        private static int CodigoComida;

        public static int GetNuevoCodigoIngrediente()
        {
            CodigoIngrediente++;
            return CodigoIngrediente;
        }

        public static int GetNuevoCodigoReceta()
        {
            CodigoReceta++;
            return CodigoReceta;
        }
        public static int GetNuevoCodigoComida()
        {
            CodigoComida++;
            return CodigoComida;
        }
    }
}
