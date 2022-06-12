using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public abstract class Persona
    {
        public string Nombre, Apellido, Correo, Telefono, DNI, Domicilio;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

    }
}
