using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libetruga
{
    class Corredor
    {
        /// <summary>
        /// se crea los componentes del corredor
        /// </summary>
        private int _num;
        protected int _posicion;
        /// <summary>
        /// Se genera el generador de numeros aleatorios
        /// </summary>
        private static Random corre = new Random();
        /// <summary>
        /// Se usa num solo lectura
        /// </summary>
        public int num
        {
            get { return _num; }
        }
        /// <summary>
        /// se usa posicion solo escritura
        /// </summary>
        public int posicion
        {
            get { return _posicion; }
        }
        /// <summary>
        /// se crea el constructor del corredor
        /// </summary>
        /// <param numero del corredor="numero"></param>
        public Corredor(int numero)
        {
            _num = numero;
            _posicion = 0;
        }
        /// <summary>
        /// Se crea la accion de correr
        /// </summary>
        /// <returns>Numero aleatorio del 1 a 20</returns>
        public int correr()
        {
            return corre.Next(1, 21);
        }
        /// <summary>
        /// Se crea la manera en que se va a mostrar la info a pantalla
        /// </summary>
        /// <returns>corredor "numero del corredor" avanzo "su posicion"</returns>
        public override string ToString()
        {
            return "corredor :" + _num + "avanso :" + _posicion;
        }
    }
}
