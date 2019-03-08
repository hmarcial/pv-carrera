using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libetruga
{
    /// <summary>
    /// Clase tortuga hereda de la clase corredor
    /// </summary>
    class Tortuga:Corredor
    {
        /// <summary>
        /// Se obtiene el numero del corredor de la clase corredor
        /// </summary>
        /// <param el numero de la tortuga="numero"></param>
        public Tortuga(int numero) : base(numero)
        {
        }
        /// <summary>
        /// Se crea la accion correr
        /// </summary>
        /// <returns>un avanse o decremento </returns>
        new public int correr()
        {
            /// Se guarda el numero aleatorio generado el clase correr en varable entera a
            int a = base.correr();
            ///compara a con 12 ya que se usa del 13 a 20 como 40%
            if(a > 12)
            {
                ///Regresa un aumento de tres en posicion
               return _posicion += 3;
            }
            else
            {
                ///compara a con 8 ya que se usa 9 a 12 com 20%
                if (a > 8)
                {
                    ///regresa un aumento del 6 en posicion
                   return _posicion += 6;
                }
                else
                {
                    ///compara a con 4 ya que se usa 5 a 8 como 20%
                    if (a > 4)
                    {
                        ///regresa decremento del 5 en posicion
                        return _posicion -= 5;
                    }
                    else
                    {
                        ///si no es ninguna de las otras entonces es entre 1 a 4 20%
                        ///regresa decremento de 9 en posicion
                        return _posicion -= 9;
                    }
                }
            }
        }
    }
}
