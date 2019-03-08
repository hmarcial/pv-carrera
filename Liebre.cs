using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libetruga
{
    /// <summary>
    /// clase liebre hereda de la clase corredor
    /// </summary>
    class Liebre:Corredor
    {
        /// <summary>
        /// Se llama el numero de corredor de la clase corredor
        /// </summary>
        /// <param numero de tortuga="numero"></param>
        public Liebre(int numero) : base(numero) { }
        /// <summary>
        /// Crea accion correr en liebre
        /// </summary>
        /// <returns>aumento o decremento de posicion</returns>
        new public int correr()
        {
            ///Guarda numero aleatorio en variable a
            int a = base.correr();
            ///compara a con 15 25%
            if(a > 15)
            {
                ///regresa aumento de 12 en posicion
                return _posicion += 12;
            }
            else
            {
                /// 15%
                if(a> 11)
                {
                    return _posicion += 5;
                }
                else
                {
                    /// 20%
                    if (a > 7)
                    {
                        return _posicion += 0;
                    }
                    else
                    {
                        ///20%
                        if (a > 3)
                        {
                            return _posicion -= 8;
                        }
                        ///20%
                        else
                        {
                            return _posicion -= 4;
                        }
                    }
                }
            }
        }
    }
}
