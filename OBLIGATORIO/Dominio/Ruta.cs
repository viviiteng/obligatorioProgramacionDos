using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ruta
    {
        #region Atributo
        public int IdRuta { get; set; }
        public int UltimoIdRuta { get; set; }
        public Aeropuerto AeropuertoSalida { get; set; }
        public Aeropuerto AeropuertoLlegada { get; set; }
        public double Distancia { get; set; }
        #endregion

        #region Constructor
        #endregion

        #region Metodos

        #endregion
    }
}
