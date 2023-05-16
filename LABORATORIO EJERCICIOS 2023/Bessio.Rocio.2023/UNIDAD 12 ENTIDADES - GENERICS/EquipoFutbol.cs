using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_12_ENTIDADES___GENERICS
{
    /// <summary>
    /// Generar la clase EquipoFutbol que herede de Equipo.
    /// </summary>
    public class EquipoFutbol : Equipo
    { 
        public EquipoFutbol(string nombre, DateTime fecha)
            : base(nombre, fecha)
        {

        }
    }
}
