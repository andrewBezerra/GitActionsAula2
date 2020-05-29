using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaMedica.Entidades
{
    public class Paciente
    {

        public Guid ID { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Paciente()
        {
            ID = Guid.NewGuid();
        }
    }
}
